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
using System.Runtime.CompilerServices;

namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		internal JSDelegateWrapper FunctionCtor;
		internal JSObject FunctionPrototype;

		private void AddFunction()
		{
			this.FunctionCtor = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				string argNames;
				string sBody;
				if (args.Count > 1)
				{
					string[] ar = new string[args.Count - 1];
					for (int i = 0; i < (args.Count - 1); i++)
					{
						ar[i] = args[i].StringValue();
					}
					argNames = string.Join(",", ar);
				}
				else
				{
					argNames = "";
				}
				if (args.Count == 0)
				{
					sBody = "";
				}
				else
				{
					sBody = args[args.Count - 1].StringValue();
				}
				JSFunctionObject r = CompiledScript.Compile("(function (" + argNames + ") {" + sBody + "})", false).Run() as JSFunctionObject;
				r.Scope = JSContext.CurrentGlobalContext.LexicalEnv;
				return r;
			}, 1);
			this.FunctionPrototype = new JSFunctionBase();
			this.FunctionPrototype.SetDataProp("constructor", this.FunctionCtor, true, false, true);
			this.FunctionPrototype.SetDataProp("call", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSArgs newArgs;
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Function.call called as constructor");
				}
				JSFunctionBase fnc = InternalUtilities.JSFunctionCast(ThisObj);
				if (args.Count == 0)
				{
					newArgs = args;
				}
				else
				{
					JSValue[] newAr = new JSValue[args.Count - 1];
					Array.Copy(args.ArgValues, 1, newAr, 0, args.Count - 1);
					newArgs = new JSArgs(ThisObj, newAr);
				}
				return fnc.Call(Scope, args[0], newArgs);
			}, 1), true, false, true);
			this.FunctionPrototype.SetDataProp("apply", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Function.apply called as constructor");
				}
				JSFunctionBase fnc = InternalUtilities.JSFunctionCast(ThisObj);
				JSValue argArray = args[1];
				if ((argArray is JSUndefined) || (argArray is JSNull))
				{
					return fnc.Call(Scope, args[0], new JSArgs(ThisObj, new JSValue[0]));
				}
				if (!(argArray is JSObject))
				{
					throw new JSRuntimeException("TypeError", "Invalid argument to Function.apply");
				}
				JSValue olen = argArray["length"];
				if (!olen.CheckCoercible())
				{
					throw new JSRuntimeException("TypeError", "Invalid argument to Function.apply");
				}
				double nlen = olen.NumberValue();
				uint len = nlen.JSToUInt32();
				if (len != nlen)
				{
					throw new JSRuntimeException("TypeError", "Invalid argument to Function.apply");
				}
				JSValue[] newAr = new JSValue[len];
				for (int i = 0; i < len; i++)
				{
					newAr[i] = argArray[i.ToString()];
				}
				return fnc.Call(Scope, args[0], new JSArgs(ThisObj, newAr));
			}, 2), true, false, true);
			this.FunctionPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return InternalUtilities.JSFunctionCast(ThisObj).GenerateString();
			}), true, false, true);
			this.FunctionPrototype.SetDataProp("length", 0.0, true, false, true);
			this.FunctionCtor.SetDataProp("prototype", this.FunctionPrototype, false, false, false);
		}

		private void AddFunctionProperties()
		{
			this.Global.SetDataProp("Function", this.FunctionCtor, false, false, false);
		}
	}

	public class JSFunctionObject : JSFunctionBase
	{

		internal JSFunctionObject(functionExpressionNode def, JSEnvRec Scope) : base(JSContext.CurrentGlobalContext.FunctionPrototype, JSContext.CurrentGlobalContext.FunctionCtor)
		{
			this.FunctionDef = def;
			JSObject p = new JSObject();
			p.SetDataProp("constructor", this, true, false, true);
			base.SetDataProp("prototype", p, true, false, false);
			this.Scope = Scope;
		}

		public override JSValue Call(JSContext Scope, JSValue ThisObj, JSArgs Args)
		{
			if (ThisObj.CheckCoercible())
			{
				ThisObj = ThisObj.ToJSObject();
			}
			else
			{
				ThisObj = JSContext.CurrentGlobalContext.Global;
			}
			return this.FunctionDef.Call(Scope, ThisObj, this, Args);
		}

		public override string GenerateString()
		{
			return this.FunctionDef.GenerateString();
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Function;
			}
		}

		internal functionExpressionNode FunctionDef { get; private set; }

		public override JSType ObjectType
		{
			get
			{
				return JSType.Function;
			}
		}

		public JSEnvRec Scope { get; set; }
	}
}

