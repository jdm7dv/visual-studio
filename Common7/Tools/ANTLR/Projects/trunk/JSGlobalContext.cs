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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		private DebugWrapper _debugger;
		private JSObject _global;
		private static Random _rand;
		private JSValue _returnValue;
		private static UTF8Encoding _UTF8Encoder;
		internal JSDelegateWrapper BooleanCtor;
		internal JSObject BooleanPrototype;
		private static bool[] DecodeReserved;
		private static readonly char[] DigitChars;
		private static bool[] EmptyBools;
		private static bool[] EncodeComponentPermit;
		private static bool[] EncodePermit;
		internal JSDelegateWrapper ErrorCtor;
		internal JSObject ErrorPrototype;
		private static bool[] EscapeAllow;
		internal JSDelegateWrapper EvalErrorCtor;
		internal JSObject EvalErrorPrototype;
		internal JSDelegateWrapper GlobalEval;
		private static Regex MatchFloat;
		internal JSDelegateWrapper NumberCtor;
		internal JSObject NumberPrototype;
		internal JSDelegateWrapper RangeErrorCtor;
		internal JSObject RangeErrorPrototype;
		internal JSDelegateWrapper ReferenceErrorCtor;
		internal JSObject ReferenceErrorPrototype;
		internal JSDelegateWrapper StringCtor;
		internal JSObject StringPrototype;
		internal JSDelegateWrapper SyntaxErrorCtor;
		internal JSObject SyntaxErrorPrototype;
		internal JSDelegateWrapper TypeErrorCtor;
		internal JSObject TypeErrorPrototype;
		internal JSDelegateWrapper URIErrorCtor;
		internal JSObject URIErrorPrototype;

		static JSGlobalContext()
		{
			int i;
			_UTF8Encoder = new UTF8Encoding(false, true);
			EncodeComponentPermit = new bool[0x80];
			EncodePermit = new bool[0x80];
			DecodeReserved = new bool[0x80];
			EmptyBools = new bool[0x80];
			EscapeAllow = new bool[0x80];
			MatchFloat = new Regex("\r\n^[+-]?\r\n(?:\r\n  Infinity\r\n| [0-9]+\\.[0-9]*(?:[eE][+-]?[0-9]+)?\r\n| \\.[0-9]+(?:[eE][+-]?[0-9]+)?\r\n| [0-9]+(?:[eE][+-]?[0-9]+)?\r\n)\r\n", RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);
			DigitChars = new char[] { 
				'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 
				'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 
				'W', 'X', 'Y', 'Z'
			 };
			_rand = new Random((int) DateTime.Now.Ticks);
			for (i = 0x61; i <= 0x7a; i++)
			{
				EncodePermit[i] = true;
			}
			for (i = 0x41; i <= 90; i++)
			{
				EncodePermit[i] = true;
			}
			for (i = 0x30; i <= 0x39; i++)
			{
				EncodePermit[i] = true;
			}
			Array.Copy(EncodePermit, EscapeAllow, 0x80);
			EncodePermit[0x2d] = true;
			EncodePermit[0x5f] = true;
			EncodePermit[0x2e] = true;
			EncodePermit[0x21] = true;
			EncodePermit[0x7e] = true;
			EncodePermit[0x2a] = true;
			EncodePermit[0x27] = true;
			EncodePermit[40] = true;
			EncodePermit[0x29] = true;
			Array.Copy(EncodePermit, EncodeComponentPermit, 0x80);
			EncodePermit[0x3b] = true;
			EncodePermit[0x2f] = true;
			EncodePermit[0x3f] = true;
			EncodePermit[0x3a] = true;
			EncodePermit[0x40] = true;
			EncodePermit[0x26] = true;
			EncodePermit[0x3d] = true;
			EncodePermit[0x2b] = true;
			EncodePermit[0x24] = true;
			EncodePermit[0x2c] = true;
			EncodePermit[0x23] = true;
			DecodeReserved[0x3b] = true;
			DecodeReserved[0x2f] = true;
			DecodeReserved[0x3f] = true;
			DecodeReserved[0x3a] = true;
			DecodeReserved[0x40] = true;
			DecodeReserved[0x26] = true;
			DecodeReserved[0x3d] = true;
			DecodeReserved[0x2b] = true;
			DecodeReserved[0x24] = true;
			DecodeReserved[0x2c] = true;
			DecodeReserved[0x23] = true;
			EncodePermit[0x40] = true;
			EncodePermit[0x2a] = true;
			EncodePermit[0x5f] = true;
			EncodePermit[0x2b] = true;
			EncodePermit[0x2d] = true;
			EncodePermit[0x2e] = true;
			EncodePermit[0x2f] = true;
		}

		public JSGlobalContext() : this(null)
		{
		}

		public JSGlobalContext(JSObject GlobalObject)
		{
			JSContext.PushContext(this);
			try
			{
				this.AddObject();
				this.AddFunction();
				this.AddArray();
				this.AddString();
				this.AddBoolean();
				this.AddNumber();
				this.AddDate();
				this.AddRegExp();
				this.AddExceptions();
				if (GlobalObject == null)
				{
					GlobalObject = new JSObject(this.ObjectPrototype, this.ObjectCtor);
				}
				this._global = GlobalObject;
				this.AddObjectProperties();
				this.AddFunctionProperties();
				this.AddArrayProperties();
				this.AddStringProperties();
				this.AddBooleanProperties();
				this.AddNumberProperties();
				this.AddDateProperties();
				this.AddRegexProperties();
				this.AddExceptionsProperties();
				this.AddMath();
				this.Global.SetDataProp("undefined", JSUndefined.Instance, false, false, false);
				this.Global.SetDataProp("NaN", JSNumber.NaN, false, false, false);
				this.Global.SetDataProp("Infinity", (double) 1.0 / (double) 0.0, false, false, false);
				this.GlobalEval = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					return InternalUtilities._Eval(JSContext.CurrentGlobalContext, args, AsConstructor);
				}, 1);
				this.Global.SetDataProp("eval", this.GlobalEval, false, false, false);
				this.Global.SetDataProp("isNaN", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "isNaN called as constructor");
					}
					return double.IsNaN(args[0].NumberValue());
				}, 1), false, false, false);
				this.Global.SetDataProp("isFinite", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "isFinite called as constructor");
					}
					return args[0].NumberValue().IsFinite();
				}, 1), true, false, true);
				this.Global.SetDataProp("parseInt", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					long lr;
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "parseInt called as constructor");
					}
					string v = args[0].StringValue().UnicodeTrim();
					int rdx = args[1].NumberValue().JSToInt32();
					if (rdx == 0)
					{
						rdx = (((v.Length >= 2) && (v[0] == '0')) && ((v[1] == 'x') || (v[1] == 'X'))) ? 0x10 : 10;
					}
					else if ((rdx < 2) || (rdx > 0x24))
					{
						return JSNumber.NaN;
					}
					if (rdx == 10)
					{
						if (long.TryParse(v, out lr))
						{
							return (double) lr;
						}
					}
					else if (rdx == 0x10)
					{
						if (((v.Length >= 2) && (v[0] == '0')) && ((v[1] == 'x') || (v[1] == 'X')))
						{
							v = v.Substring(2);
						}
						if (long.TryParse(v, NumberStyles.AllowHexSpecifier, null, out lr))
						{
							return (double) lr;
						}
					}
					if (v.Length == 0)
					{
						return JSNumber.NaN;
					}
					v = v.ToLowerInvariant();
					double neg = 1.0;
					if (v[0] == '-')
					{
						neg = -1.0;
						v = v.Substring(1);
					}
					else if (v[0] == '+')
					{
						v = v.Substring(1);
					}
					double r = 0.0;
					double drdx = rdx;
					char MaxNumChar = (char) ((0x30 + rdx) - 1);
					if (MaxNumChar > '9')
					{
						MaxNumChar = '9';
					}
					char MaxLetterChar = (char) ((0x61 + rdx) - 11);
					if (MaxLetterChar > 'z')
					{
						MaxLetterChar = 'z';
					}
					int i = 0;
					while (i < v.Length)
					{
						char c = v[i];
						int d = 0;
						if ((c >= '0') && (c <= MaxNumChar))
						{
							d = c - '0';
						}
						else
						{
							if ((c < 'a') || (c > MaxLetterChar))
							{
								break;
							}
							d = ('\n' + c) - 0x61;
						}
						r = (r * drdx) + d;
						i++;
					}
					if (i == 0)
					{
						return JSNumber.NaN;
					}
					return r * neg;
				}, 2), false, false, false);
				this.Global.SetDataProp("parseFloat", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "parseFloat called as constructor");
					}
					if (args.Count != 0)
					{
						double r;
						JSValue arg = args[0];
						if ((arg is JSUndefined) || (arg is JSNull))
						{
							return JSNumber.NaN;
						}
						string v = args[0].StringValue().UnicodeTrim();
						if (double.TryParse(v, out r))
						{
							return r;
						}
						Match m = MatchFloat.Match(v);
						if (m.Success && double.TryParse(m.Value, out r))
						{
							return r;
						}
						if (m.Value == "+Infinity")
						{
							return (double) 1.0 / (double) 0.0;
						}
					}
					return JSNumber.NaN;
				}, 1), false, false, false);
				this.Global.SetDataProp("encodeURI", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "encodeURI called as constructor");
					}
					if (args.Count == 0)
					{
						return JSUndefined.Instance;
					}
					return EncodeURI(args[0].StringValue(), EncodePermit);
				}, 1), false, false, false);
				this.Global.SetDataProp("_encodeURI", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "encodeURI called as constructor");
					}
					if (args.Count == 0)
					{
						return JSUndefined.Instance;
					}
					return EncodeURI(args[0].StringValue(), EncodePermit);
				}, 1), false, false, false);
				this.Global.SetDataProp("encodeURIComponent", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "encodeURIComponent called as constructor");
					}
					if (args.Count == 0)
					{
						return JSUndefined.Instance;
					}
					return EncodeURI(args[0].StringValue(), EncodeComponentPermit);
				}, 1), false, false, false);
				this.Global.SetDataProp("decodeURI", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "decodeURI called as constructor");
					}
					if (args.Count == 0)
					{
						return JSUndefined.Instance;
					}
					return DecodeURI(args[0].StringValue(), DecodeReserved);
				}, 1), false, false, false);
				this.Global.SetDataProp("decodeURIComponent", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
					if (AsConstructor)
					{
						throw new JSRuntimeException("TypeError", "decodeURIComponent called as constructor");
					}
					if (args.Count == 0)
					{
						return JSUndefined.Instance;
					}
					return DecodeURI(args[0].StringValue(), EmptyBools);
				}, 1), false, false, false);
				base.VariableEnv = new JSGlobalScope(null, this.Global);
				base.LexicalEnv = base.VariableEnv;
			}
			finally
			{
				JSContext.PopContext();
			}
		}

		private static void _concat_append(JSArray A, ref int n, JSValue E)
		{
			if (E is JSArray)
			{
				uint k = 0;
				uint len = E["length"].NumberValue().JSToUInt32();
				while (k < len)
				{
					string P = k.ToString();
					if (E.HasProperty(P))
					{
						JSValue subElement = E[P];
						A[((int) n).ToString()] = subElement;
					}
					n++;
					k++;
				}
			}
			else
			{
				A[((int) n).ToString()] = E;
				n++;
			}
		}

		private void AddBoolean()
		{
			this.BooleanCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				JSValue v = args[0];
				if (AsConstructor)
				{
					return new JSBoxedBoolean(v.ToJSBool());
				}
				return v.ToJSBool();
			});
			this.BooleanPrototype = new JSObject(this.ObjectPrototype, this.BooleanCtor);
			this.BooleanCtor.SetDataProp("prototype", this.BooleanPrototype, false, false, false);
		}

		private void AddBooleanProperties()
		{
			this.Global.SetDataProp("Boolean", this.BooleanCtor, false, false, false);
			this.BooleanPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.ToPrimitive(true).StringValue();
			}), true, false, true);
			this.BooleanPrototype.SetDataProp("valueOf", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.ToPrimitive(false);
			}), true, false, true);
		}

		private void AddExceptions()
		{
			this.ErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.ErrorPrototype = new ErrObj(this.ObjectPrototype, this.ErrorCtor);
			this.ErrorPrototype.SetDataProp("name", "Error", false, false, false);
			this.ErrorCtor.SetDataProp("prototype", this.ErrorPrototype, false, false, false);
			this.ErrorPrototype.SetDataProp("message", "", false, false, false);
			this.EvalErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.EvalErrorPrototype, this.EvalErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.EvalErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.EvalErrorPrototype.SetDataProp("name", "EvalError", false, false, false);
			this.EvalErrorCtor.SetDataProp("prototype", this.EvalErrorPrototype, false, false, false);
			this.RangeErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.RangeErrorPrototype, this.RangeErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.RangeErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.RangeErrorPrototype.SetDataProp("name", "RangeError", false, false, false);
			this.RangeErrorCtor.SetDataProp("prototype", this.RangeErrorPrototype, false, false, false);
			this.ReferenceErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.ReferenceErrorPrototype, this.ReferenceErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.ReferenceErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.ReferenceErrorPrototype.SetDataProp("name", "ReferenceError", false, false, false);
			this.ReferenceErrorCtor.SetDataProp("prototype", this.ReferenceErrorPrototype, false, false, false);
			this.SyntaxErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.SyntaxErrorPrototype, this.SyntaxErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.SyntaxErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.SyntaxErrorPrototype.SetDataProp("name", "SyntaxError", false, false, false);
			this.SyntaxErrorCtor.SetDataProp("prototype", this.SyntaxErrorPrototype, false, false, false);
			this.TypeErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.TypeErrorPrototype, this.TypeErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.TypeErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.TypeErrorPrototype.SetDataProp("name", "TypeError", false, false, false);
			this.TypeErrorCtor.SetDataProp("prototype", this.TypeErrorPrototype, false, false, false);
			this.URIErrorCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				ErrObj o = new ErrObj(this.URIErrorPrototype, this.URIErrorCtor);
				o.SetDataProp("message", args[0] is JSUndefined ? (JSValue)"" : args[0].ToJSString(), true, false, true);
				return o;
			}, 1);
			this.URIErrorPrototype = new ErrObj(this.ErrorPrototype, this.ErrorCtor);
			this.URIErrorPrototype.SetDataProp("name", "URIError", false, false, false);
			this.URIErrorCtor.SetDataProp("prototype", this.URIErrorPrototype, false, false, false);
		}

		private void AddExceptionsProperties()
		{
			this.Global.SetDataProp("Error", this.ErrorCtor, false, false, false);
			this.Global.SetDataProp("EvalError", this.EvalErrorCtor, false, false, false);
			this.Global.SetDataProp("RangeError", this.RangeErrorCtor, false, false, false);
			this.Global.SetDataProp("ReferenceError", this.ReferenceErrorCtor, false, false, false);
			this.Global.SetDataProp("SyntaxError", this.SyntaxErrorCtor, false, false, false);
			this.Global.SetDataProp("TypeError", this.TypeErrorCtor, false, false, false);
			this.Global.SetDataProp("URIError", this.URIErrorCtor, false, false, false);
			this.ErrorPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj["name"].StringValue() + ": " + ThisObj["message"].StringValue();
			}), true, false, false);
		}

		private void AddNumber()
		{
			this.NumberCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				JSNumber v;
				if (args.Count > 0)
				{
					v = args[0].ToJSNumber();
				}
				else
				{
					v = new JSNumber(0.0);
				}
				if (AsConstructor)
				{
					return new JSBoxedNumber(v);
				}
				return v;
			}, 1);
			this.NumberPrototype = new JSBoxedNumber(this.ObjectPrototype, this.NumberCtor);
			this.NumberCtor.SetDataProp("prototype", this.NumberPrototype, false, false, false);
		}

		private void AddNumberProperties()
		{
			this.Global.SetDataProp("Number", this.NumberCtor, false, false, false);
			this.NumberPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				if (!((ThisObj is JSNumber) || (ThisObj is JSBoxedNumber)))
				{
					throw new JSRuntimeException("TypeError", "Number.toString called on non-numeric type");
				}
				if (args[0] is JSUndefined)
				{
					return ThisObj.NumberValue().JSToString();
				}
				double r = args[0].NumberValue().JSToInteger();
				if ((r < 2.0) || (r > 36.0))
				{
					throw new JSRuntimeException("RangeError", "invalid radix");
				}
				if (r == 10.0)
				{
					return ThisObj.NumberValue().JSToString();
				}
				double x = ThisObj.NumberValue();
				if (!x.IsFinite())
				{
					return ThisObj.NumberValue().JSToString();
				}
				if (x == 0.0)
				{
					return "0";
				}
				StringBuilder sb = new StringBuilder();
				if (x < 0.0)
				{
					x = -x;
					sb.Append('-');
				}
				int d = (int) Math.Floor((double) (Math.Log(x) / Math.Log(36.0)));
				double m = Math.Pow(36.0, (double) d);
				x /= m;
				if (d < 0)
				{
					sb.Append("0.");
				}
				int i = 0;
				int z = -d - 1;
				while (i < z)
				{
					sb.Append('0');
					i++;
				}
				while (i < 0x10)
				{
					int dg = (int) Math.Truncate(x);
					sb.Append(DigitChars[dg]);
					x = (x - dg) * 36.0;
					if ((d <= 0) && (x < 0.0001))
					{
						break;
					}
					if (d == 0)
					{
						sb.Append('.');
					}
					d--;
					i++;
				}
				return sb.ToString();
			}), true, false, true);
			this.NumberPrototype.SetDataProp("toLocaleString", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				if (!((ThisObj is JSNumber) || (ThisObj is JSBoxedNumber)))
				{
					throw new JSRuntimeException("TypeError", "Number.toString called on non-numeric type");
				}
				return ThisObj.NumberValue().ToString(CultureInfo.CurrentCulture.NumberFormat);
			}), true, false, true);
			this.NumberPrototype.SetDataProp("valueOf", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				if (!((ThisObj is JSNumber) || (ThisObj is JSBoxedNumber)))
				{
					throw new JSRuntimeException("TypeError", "Number.valueOf called on non-numeric type");
				}
				return ThisObj.ToPrimitive(false);
			}), true, false, true);
			this.NumberPrototype.SetDataProp("toFixed", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				double f = args[0].NumberValue().JSToInteger();
				if ((f < 0.0) || (f > 20.0))
				{
					throw new JSRuntimeException("RangeError", "Number.toFixed: fractionDigits out of range");
				}
				double n = ThisObj.NumberValue();
				if (double.IsNaN(n))
				{
					return "NaN";
				}
				if ((n >= 1E+22) || (n <= -1E+22))
				{
					return n.JSToString();
				}
				return n.ToString("F" + ((int) f).ToString());
			}), true, false, true);
			this.NumberPrototype.SetDataProp("toExponential", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string fmt;
				if (args[0] is JSUndefined)
				{
					fmt = "0.#################e+0";
				}
				else
				{
					double f = args[0].NumberValue().JSToInteger();
					if ((f < 0.0) || (f > 20.0))
					{
						throw new JSRuntimeException("RangeError", "Number.toFixed: fractionDigits out of range");
					}
					fmt = "0." + new string('0', (int) f) + "e+0";
				}
				double val = ThisObj.NumberValue();
				if (double.IsNaN(val))
				{
					return "NaN";
				}
				if (val == 0.0)
				{
					return "0";
				}
				return val.ToString(fmt);
			}), true, false, true);
			this.NumberCtor.SetDataProp("NaN", JSNumber.NaN, false, false, false);
			this.NumberCtor.SetDataProp("POSITIVE_INFINITY", (double) 1.0 / (double) 0.0, false, false, false);
			this.NumberCtor.SetDataProp("NEGATIVE_INFINITY", (double) -1.0 / (double) 0.0, false, false, false);
			this.NumberCtor.SetDataProp("MAX_VALUE", 1.7976931348623157E+308, false, false, false);
			this.NumberCtor.SetDataProp("MIN_VALUE", 4.94065645841247E-324, false, false, false);
		}

		private void AddString()
		{
			this.StringCtor = new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				JSString v;
				if (args.Count == 0)
				{
					v = JSString.Empty;
				}
				else
				{
					v = args[0].ToJSString();
				}
				if (AsConstructor)
				{
					return new JSBoxedString(v);
				}
				return v;
			}, 1);
			this.StringPrototype = new JSBoxedString(this.ObjectPrototype, this.StringCtor);
			this.StringCtor.SetDataProp("prototype", this.StringPrototype, false, false, false);
		}

		private void AddStringProperties()
		{
			this.Global.SetDataProp("String", this.StringCtor, false, false, false);
			this.StringPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				if (!((ThisObj is JSString) || (ThisObj is JSBoxedString)))
				{
					throw new JSRuntimeException("TypeError", "String.toString called on non-string type");
				}
				return ThisObj.ToPrimitive(true);
			}), true, false, true);
			this.StringPrototype.SetDataProp("valueOf", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				if (!((ThisObj is JSString) || (ThisObj is JSBoxedString)))
				{
					throw new JSRuntimeException("TypeError", "String.valueOf called on non-string type");
				}
				return ThisObj.ToPrimitive(true);
			}), true, false, true);
			this.StringPrototype.SetDataProp("charAt", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				int i = args[0].NumberValue().JSToInt32();
				string v = ThisObj.StringValue();
				if ((i < 0) || (i >= v.Length))
				{
					return JSString.Empty;
				}
				return (v[i]).ToString();
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("charCodeAt", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				int i = args[0].NumberValue().JSToInt32();
				string v = ThisObj.StringValue();
				if ((i < 0) || (i >= v.Length))
				{
					return JSNumber.NaN;
				}
				return (double) v[i];
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("concat", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				StringBuilder sb = new StringBuilder(ThisObj.StringValue());
				foreach (JSValue v in (IEnumerable<JSValue>) args)
				{
					sb.Append(v.StringValue());
				}
				return sb.ToString();
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("indexOf", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string str = ThisObj.StringValue();
				string pat = args[0].StringValue();
				int start = (int) args[1].NumberValue().JSToInteger();
				if (start < 0)
				{
					start = 0;
				}
				if (start > str.Length)
				{
					return JSNumber.NegOne;
				}
				return (JSValue) str.IndexOf(pat, start);
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("lastIndexOf", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string str = ThisObj.StringValue();
				string pat = args[0].StringValue();
				double nStart = args[1].NumberValue();
				if (double.IsNaN(nStart))
				{
					nStart = str.Length;
				}
				int start = ((int) nStart) + pat.Length;
				if (start < 0)
				{
					return JSNumber.NegOne;
				}
				if (start > str.Length)
				{
					start = str.Length;
				}
				return (JSValue) str.LastIndexOf(pat, start);
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("localeCompare", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string str1 = ThisObj.StringValue();
				string str2 = args[0].StringValue();
				return (double) string.Compare(str1, str2, false, CultureInfo.CurrentCulture);
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("match", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				JSRegExp rx;
				string str = ThisObj.StringValue();
				if (args[0] is JSRegExp)
				{
					rx = (JSRegExp) args[0];
				}
				else
				{
					string pattern;
					JSValue v = args[0];
					if (v is JSUndefined)
					{
						pattern = "";
					}
					else
					{
						pattern = v.StringValue();
					}
					rx = new JSRegExp(this.RegExpPrototype, this.RegExpCtor, pattern, "");
				}
				if (!rx.global)
				{
					return rx.exec(str);
				}
				MatchCollection m = rx.CLRRegex.Matches(str);
				if (m.Count == 0)
				{
					return JSNull.Instance;
				}
				return new JSArray(m.Cast<Match>().Select<Match, JSValue>(((Func<Match, JSValue>) (x => new JSString(x.Value)))).ToArray<JSValue>());
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("replace", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string strRep;
				string str = ThisObj.StringValue();
				if (args[0] is JSRegExp)
				{
					JSRegExp rx = (JSRegExp) args[0];
					int MaxMatch = rx.global ? 0x7fffffff : 1;
					if (args[1] is JSFunctionBase)
					{
						return rx.CLRRegex.Replace(str, delegate (Match m) {
							JSValue[] ar = new JSValue[m.Groups.Count + 2];
							ar[0] = m.Value;
							int i = 1;
							while (i < m.Groups.Count)
							{
								ar[i] = m.Groups[i].Value;
								i++;
							}
							ar[i] = (JSValue) m.Index;
							ar[i + 1] = str;
							return ((JSFunctionBase) args[1]).Call(Scope, JSContext.CurrentGlobalContext.Global, new JSArgs(args[1], ar)).StringValue();
						}, MaxMatch);
					}
					return rx.CLRRegex.Replace(str, args[1].StringValue(), MaxMatch);
				}
				string strPat = args[0].StringValue();
				int ii = str.IndexOf(strPat);
				if (ii == -1)
				{
					return str;
				}
				if (args[1] is JSFunctionBase)
				{
					strRep = ((JSFunctionBase) args[1]).Call(Scope, JSContext.CurrentGlobalContext.Global, new JSArgs(args[1], new JSValue[] { strPat, (double) ii, str })).StringValue();
				}
				else
				{
					strRep = args[1].StringValue();
				}
				return str.Substring(0, ii) + strRep + str.Substring(ii + strPat.Length);
			}, 2), true, false, true);
			this.StringPrototype.SetDataProp("search", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				JSRegExp rx;
				string str = ThisObj.StringValue();
				if (args[0] is JSRegExp)
				{
					rx = (JSRegExp) args[0];
				}
				else
				{
					string pattern;
					JSValue v = args[0];
					if (v is JSUndefined)
					{
						pattern = "";
					}
					else
					{
						pattern = v.StringValue();
					}
					rx = new JSRegExp(this.RegExpPrototype, this.RegExpCtor, pattern, "");
				}
				Match m = rx.CLRRegex.Match(str);
				return m.Success ? ((double) m.Index) : ((double) (-1));
			}, 1), true, false, true);
			this.StringPrototype.SetDataProp("slice", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				string S = ThisObj.StringValue();
				int len = S.Length;
				int intStart = args[0].NumberValue().JSToInt32();
				JSValue end = args[1];
				int intEnd = (end is JSUndefined) ? len : end.NumberValue().JSToInt32();
				int from = (intStart < 0) ? ((int) Math.Max((len + intStart), 0)) : (Math.Min(intStart, len));
				int to = (intEnd < 0) ? ((int) Math.Max( (len + intEnd),  0)) : (Math.Min(intEnd, len));
				int span = Math.Max(to - from, 0);
				return S.Substring(from, span);
			}, 2), true, false, true);
			this.StringPrototype.SetDataProp("split", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				int limit;
				Match m;
				string str = ThisObj.StringValue();
				if (args[1] is JSUndefined)
				{
					limit = 0x7fffffff;
				}
				else
				{
					limit = (int) Math.Min(args[1].NumberValue().JSToUInt32(), 0x7fffffff);
				}
				JSRegExp rx = args[0] as JSRegExp;
				string splitStr = (rx == null) ? args[0].StringValue() : null;
				if (((splitStr != null) && (splitStr.Length == 0)) || ((rx != null) && rx.CLRRegex.Match("").Success))
				{
					return new JSArray(str.ToCharArray().Take<char>(limit).Select<char, JSString>(((Func<char, JSString>) (x => new JSString(x.ToString())))).ToArray<JSString>());
				}
				if (rx == null)
				{
					return new JSArray(str.Split(new string[] { splitStr }, StringSplitOptions.None).Take<string>(limit).Select<string, JSValue>(((Func<string, JSValue>) (x => x))).ToArray<JSValue>());
				}
				if (limit == 0)
				{
					return new JSArray(new JSValue[0]);
				}
				List<JSValue> els = new List<JSValue>();
				Regex r = rx.CLRRegex;
				int p = 0;
				while ((m = r.Match(str, p)).Success)
				{
					els.Add(str.Substring(p, m.Index - p));
					p = m.Index + m.Length;
					for (int i = 1; (i < m.Groups.Count) && (els.Count < limit); i++)
					{
						if (m.Groups[i].Success)
						{
							els.Add(m.Groups[i].Value);
						}
						else
						{
							els.Add(JSUndefined.Instance);
						}
					}
					if (els.Count == limit)
					{
						break;
					}
				}
				if (els.Count < limit)
				{
					els.Add(str.Substring(p, str.Length - p));
				}
				return new JSArray(els.Select<JSValue, JSValue>(((Func<JSValue, JSValue>) (x => x))).ToArray<JSValue>());
			}, 2), true, false, true);
			this.StringPrototype.SetDataProp("substring", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				int from;
				int to;
				string S = ThisObj.StringValue();
				int len = S.Length;
				double intStart = args[0].NumberValue().JSToInteger();
				JSValue end = args[1];
				double intEnd = (end is JSUndefined) ? ((double) len) : end.NumberValue().JSToInteger();
				if (intStart < 0.0)
				{
					intStart = 0.0;
				}
				if (intStart > len)
				{
					intStart = len;
				}
				if (intEnd < 0.0)
				{
					intEnd = 0.0;
				}
				if (intEnd > len)
				{
					intEnd = len;
				}
				if (intStart < intEnd)
				{
					from = (int) intStart;
					to = (int) intEnd;
				}
				else
				{
					from = (int) intEnd;
					to = (int) intStart;
				}
				return S.Substring(from, to - from);
			}, 2), true, false, true);
			this.StringPrototype.SetDataProp("toLowerCase", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.StringValue().ToLowerInvariant();
			}), true, false, true);
			this.StringPrototype.SetDataProp("toLocaleLowerCase", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.StringValue().ToLower();
			}), true, false, true);
			this.StringPrototype.SetDataProp("toUpperCase", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.StringValue().ToUpperInvariant();
			}), true, false, true);
			this.StringPrototype.SetDataProp("toLocaleUpperCase", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.StringValue().ToUpper();
			}), true, false, true);
			this.StringPrototype.SetDataProp("trim", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				return ThisObj.StringValue().UnicodeTrim();
			}), true, false, true);
			this.StringPrototype.SetProp("length", new JSDelegateProperty(delegate (JSValue ThisObj) {
				return (double) ThisObj.StringValue().Length;
			}, null, false, false, false));
			this.StringCtor.SetDataProp("fromCharCode", new JSDelegateWrapper(delegate (JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor) {
				StringBuilder sb = new StringBuilder();
				foreach (JSValue v in (IEnumerable<JSValue>) args)
				{
					sb.Append((char) v.NumberValue().JSToUInt16());
				}
				return sb.ToString();
			}, 1), false, false, false);
		}

		private static JSValue DecodeURI(string arg, bool[] ReservedSet)
		{
			byte[] bytes = new byte[6];
			StringBuilder sb = new StringBuilder();
			int i = 0;
			try
			{
				while (i < arg.Length)
				{
					char c = arg[i];
					if (c == '%')
					{
						byte cc = ReadEscapedChar(arg, i);
						if ((cc >= 0x80) || !ReservedSet[cc])
						{
							i += 3;
							if (cc < 0x80)
							{
								sb.Append((char) cc);
							}
							else
							{
								bytes[0] = cc;
								int j = 1;
								while ((cc & (((int) 0x80) >> j)) != 0)
								{
									if (arg[i] != '%')
									{
										throw new Exception();
									}
									bytes[j] = ReadEscapedChar(arg, i);
									i += 3;
									j++;
								}
								string res = _UTF8Encoder.GetString(bytes, 0, j);
								if (Encoding.UTF32.GetByteCount(res) != 4)
								{
									throw new Exception();
								}
								sb.Append(res);
							}
							continue;
						}
					}
					sb.Append(c);
					i++;
				}
			}
			catch
			{
				throw new JSRuntimeException("URIError", "Malformed URI");
			}
			return sb.ToString();
		}

		private static JSValue EncodeURI(string arg, bool[] PermitSet)
		{
			try
			{
				byte[] bytes = _UTF8Encoder.GetBytes(arg);
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
				{
					int c = bytes[i];
					if ((c < 0x80) && PermitSet[c])
					{
						sb.Append((char) c);
					}
					else
					{
						sb.Append('%');
						sb.Append(c.ToString("X02"));
					}
				}
				return sb.ToString();
			}
			catch
			{
				throw new JSRuntimeException("URIError", "Malformed URI");
			}
		}

		public void Enter()
		{
			JSContext.PushContext(this);
		}

		public void Exit()
		{
			if (JSContext.CurrentContext != this)
			{
				throw new Exception();
			}
			JSContext.PopContext();
		}

		private static byte ReadEscapedChar(string arg, int i)
		{
			string cs = arg.Substring(i + 1, 2);
			i += 3;
			if ((cs[0] == '\0') || (cs[1] == '\0'))
			{
				throw new Exception();
			}
			return (byte) int.Parse(cs, NumberStyles.AllowHexSpecifier);
		}

		public static JSValue test(JSContext context)
		{
			JSValue lThisObj;
			context.ReturnValue = JSUndefined.Instance;
			JSValue bindingValue = context.GetFunctionWithThis("ff", out lThisObj);
			context.ReturnValue = InternalUtilities.JSFunctionCast(bindingValue).Call(context, context.ImplicitThis, new JSArgs(bindingValue, new JSValue[0]));
			return context.ReturnValue;
		}

		private bool tryUnEscape(string str, ref int i, out char c2)
		{
			int cc;
			c2 = '\0';
			if (i > (str.Length - 3))
			{
				return false;
			}
			if (str[i + 1] == 'u')
			{
				if (i > (str.Length - 6))
				{
					return false;
				}
				if (!int.TryParse(str.Substring(i + 2, 4), NumberStyles.AllowHexSpecifier, null, out cc))
				{
					return false;
				}
				c2 = (char) cc;
				i += 5;
				return true;
			}
			if (i > (str.Length - 3))
			{
				return false;
			}
			if (!int.TryParse(str.Substring(i + 1, 2), NumberStyles.AllowHexSpecifier, null, out cc))
			{
				return false;
			}
			c2 = (char) cc;
			i += 2;
			return true;
		}

		internal override DebugWrapper Debugger
		{
			get
			{
				return this._debugger;
			}
			set
			{
				this._debugger = value;
			}
		}

		internal override JSValue ExplicitThis
		{
			get
			{
				return this.Global;
			}
		}

		public override JSObject Global
		{
			get
			{
				return this._global;
			}
		}

		public override JSValue ReturnValue
		{
			get
			{
				return this._returnValue;
			}
			set
			{
				this._returnValue = value;
			}
		}

		private class _sortHelper : IComparer<JSValue>
		{
			private JSArgs _ar;
			private JSFunctionBase _fnc;
			private JSObject _gl;
			private JSContext _scope;

			public _sortHelper(JSFunctionBase fnc, JSContext scope)
			{
				this._fnc = fnc;
				this._scope = scope;
				this._gl = JSContext.CurrentGlobalContext.Global;
				this._ar = new JSArgs(this._fnc, new JSValue[] { JSUndefined.Instance, JSUndefined.Instance });
			}

			public int Compare(JSValue x, JSValue y)
			{
				this._ar.ArgValues[0] = x;
				this._ar.ArgValues[1] = y;
				return (int) this._fnc.Call(this._scope, this._gl, this._ar).NumberValue();
			}
		}

		private class ErrObj : JSObject
		{
			public ErrObj(JSValue p, JSValue c) : base(p, c)
			{
			}

			public override string ClassString
			{
				get
				{
					return "Error";
				}
			}
		}
	}
}

