/* 
 * Copyright 2010 Thomas Horne
 * 
 * This file is part of the Zinj EcmaScript Engine.
 * 
 * Zinj is free software: you can redistribute it and/or modify it under 
 * the terms of the GNU General Public License as published by the Free 
 * Software Foundation, either version 3 of the License, or (at your 
 * option) any later version.
 * 
 * Zinj is distributed in the hope that it will be useful, but WITHOUT 
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
 * or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public 
 * License for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * along with Zinj. If not, see http://www.gnu.org/licenses/.
 */

using Zinj;
using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		internal JSDelegateWrapper RegExpCtor;
		internal JSObject RegExpPrototype;

		private void AddRegExp()
		{
			this.RegExpCtor = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				string pattern;
				string flags;
				JSValue v = args[0];
				if (AsConstructor && (v is JSRegExp))
				{
					return v;
				}
				if (v is JSRegExp)
				{
					pattern = v["source"].StringValue();
				}
				else if (v is JSUndefined)
				{
					pattern = "";
				}
				else
				{
					pattern = v.StringValue();
				}
				v = args[1];
				if (v is JSUndefined)
				{
					flags = "";
				}
				else
				{
					flags = v.StringValue();
				}
				return new JSRegExp(this.RegExpPrototype, this.RegExpCtor, pattern, flags);
			});
			this.RegExpPrototype = new JSObject(this.ObjectPrototype, this.RegExpCtor);
			this.RegExpCtor.SetDataProp("prototype", this.RegExpPrototype, false, false, false);
		}

		private void AddRegexProperties()
		{
			this.Global.SetDataProp("RegExp", this.RegExpCtor, false, false, false);
			this.RegExpPrototype["exec"] = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return ((JSRegExp)ThisObj).exec(args[0].StringValue());
			});
			this.RegExpPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return "/" + ((JSRegExp)ThisObj).src + "/";
			}), true, false, true);
		}
	}

	internal class JSRegExp : JSObject
	{
		internal string src;
		private static Regex TokenConverter = new Regex(@"^/(?<pattern>(?:[^/[]|\\/|(?:\[[^]]*\]))*)/(?<flags>(?:[mig]|\\u006[79dD])*)$", RegexOptions.Compiled);

		public JSRegExp(string pattern, string flags) : this(JSContext.CurrentGlobalContext.RegExpPrototype, JSContext.CurrentGlobalContext.RegExpCtor, pattern, flags)
		{
		}

		public JSRegExp(JSObject o, JSValue ctor, string pattern, string flags) : base(o, ctor)
		{
			bool ignoreCase = false;
			bool multiline = false;
			foreach (char c in flags)
			{
				switch (c)
				{
					case 'g':
						this.global = true;
						break;

					case 'i':
						ignoreCase = true;
						break;

					case 'm':
						multiline = true;
						break;
				}
			}
			RegexOptions opt = RegexOptions.ECMAScript;
			if (ignoreCase)
			{
				opt |= RegexOptions.IgnoreCase;
			}
			if (multiline)
			{
				opt |= RegexOptions.Multiline;
			}
			try
			{
				this.CLRRegex = new Regex(pattern, opt);
			}
			catch(Exception ex)
			{
				throw new JSRuntimeException("SyntaxError", ex.Message);
			}
			this.src = pattern.Replace("/", @"\/");
			this["source"] = this.src;
			this["global"] = this.global;
			this["ignoreCase"] = ignoreCase;
			this["multiline"] = multiline;
		}

		internal JSValue exec(string p)
		{
			Match m = this.CLRRegex.Match(p);
			if (!m.Success)
			{
				return JSNull.Instance;
			}
			JSValue[] vals = new JSValue[m.Groups.Count];
			for (int i = 0; i < m.Groups.Count; i++)
			{
				if (m.Groups[i].Success)
				{
					vals[i] = m.Groups[i].Value;
				}
				else
				{
					vals[i] = JSUndefined.Instance;
				}
			}
			JSObject A = new JSArray(vals);
			A["index"] = (JSValue) m.Index;
			A["input"] = p;
			return A;
		}

		internal static void GenCode(ILGenerator gen, string p)
		{
			Match m = TokenConverter.Match(p);
			string pattern = m.Groups["pattern"].Value.Replace(@"\/", "/");
			LocalBuilder lfnc = gen.DeclareLocal(typeof(JSValue));
			gen.Emit(OpCodes.Ldarg_0);
			gen.Emit(OpCodes.Ldstr, "RegExp");
			gen.EmitCallV( CompileContext.mi_GetBindingValue);
			gen.Emit(OpCodes.Stloc, lfnc.LocalIndex);
			gen.Emit(OpCodes.Ldloc, lfnc.LocalIndex);
			gen.EmitCallV( CompileContext.fnc_Utilities_JSFunctionCast);
			gen.Emit(OpCodes.Ldarg_0);
			gen.Emit(OpCodes.Ldloc, lfnc.LocalIndex);
			gen.Emit(OpCodes.Ldc_I4_2);
			gen.Emit(OpCodes.Newarr, typeof(JSValue));
			gen.Emit(OpCodes.Dup);
			gen.Emit(OpCodes.Ldc_I4_0);
			gen.Emit(OpCodes.Ldstr, pattern);
			gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
			gen.Emit(OpCodes.Stelem_Ref);
			gen.Emit(OpCodes.Dup);
			gen.Emit(OpCodes.Ldc_I4_1);
			gen.Emit(OpCodes.Ldstr, ProcessFlags(m.Groups["flags"].Value));
			gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
			gen.Emit(OpCodes.Stelem_Ref);
			gen.Emit(OpCodes.Newobj, CompileContext.JSArgs_ctor);
			gen.EmitCallV( CompileContext.mi_JSFunctionBase_Construct);
		}

		private static string ProcessFlags(string p)
		{
			if (p.IndexOf('\\') != -1)
			{
				p = Regex.Replace(p, @"\\u(....)", delegate (Match x) {
					return ((char) int.Parse(x.Groups[1].Value, NumberStyles.AllowHexSpecifier)).ToString();
				});
			}
			return p;
		}

		public Regex CLRRegex { get; private set; }

		public bool global { get; private set; }
	}
}

