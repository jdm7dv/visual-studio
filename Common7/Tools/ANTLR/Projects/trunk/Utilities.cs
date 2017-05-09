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

using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Zinj
{
	public static class Utilities
	{
		public static bool CheckCoercible(this JSValue arg)
		{
			return (!(arg is JSUndefined) && !(arg is JSNull));
		}

		public static bool IsFinite(this double val)
		{
			if (double.IsNaN(val))
			{
				return false;
			}
			if (double.IsPositiveInfinity(val))
			{
				return false;
			}
			if (double.IsNegativeInfinity(val))
			{
				return false;
			}
			return true;
		}

		public static int JSToInt32(this double v)
		{
			try
			{
				return checked((int)v);
			}
			catch
			{
				if ((double.IsNaN(v) || double.IsPositiveInfinity(v)) || double.IsNegativeInfinity(v))
				{
					return 0;
				}
				double posInt = Math.Sign(v) * Math.Floor(Math.Abs(v));
				double int32bit = posInt / 4294967296;
				int32bit -= Math.Floor(int32bit);
				int32bit *= 4294967296;
				if (int32bit >= 2147483648)
				{
					return (int)(int32bit - 4294967296);
				}
				return (int)int32bit;
			}
		}

		public static double JSToInteger(this double number)
		{
			if (double.IsNaN(number))
			{
				return 0.0;
			}
			if (double.IsPositiveInfinity(number))
			{
				return number;
			}
			if (double.IsNegativeInfinity(number))
			{
				return number;
			}
			return Math.Truncate(number);
		}

		public static string JSToString(this double val)
		{
			if (double.IsNaN(val))
			{
				return "NaN";
			}
			if (val == 0.0)
			{
				return "0";
			}
			if (((val >= 1E-06) && (val < 1E+21)) || ((val <= -1E-06) && (val > -1E+21)))
			{
				return val.ToString("0.#################");
			}
			return val.ToString("0.#################e+0");
		}

		public static ushort JSToUInt16(this double v)
		{
			try
			{
				return checked((ushort)v);
			}
			catch
			{
				if ((double.IsNaN(v) || double.IsPositiveInfinity(v)) || double.IsNegativeInfinity(v))
				{
					return 0;
				}
				double posInt = Math.Sign(v) * Math.Floor(Math.Abs(v));
				double int16bit = posInt / 65536.0;
				int16bit -= Math.Floor(int16bit);
				int16bit *= 65536.0;
				return (ushort)int16bit;
			}
		}

		public static uint JSToUInt32(this double v)
		{
			try
			{
				return (uint)v;
			}
			catch
			{
				if ((double.IsNaN(v) || double.IsPositiveInfinity(v)) || double.IsNegativeInfinity(v))
				{
					return 0;
				}
				double posInt = Math.Sign(v) * Math.Floor(Math.Abs(v));
				double int32bit = posInt / 4294967296;
				int32bit -= Math.Floor(int32bit);
				int32bit *= 4294967296;
				return (uint)int32bit;
			}
		}

		public static double ToJSNumber(this string v)
		{
			double r;
			double m;
			v = v.UnicodeTrim();
			if (v.Length == 0)
			{
				return 0.0;
			}
			if (((v.Length > 2) && (v[0] == '0')) && ((v[1] == 'x') || (v[1] == 'X')))
			{
				int i;
				if (!int.TryParse(v.Substring(2), NumberStyles.AllowHexSpecifier, null, out i))
				{
					return double.NaN;
				}
				return (double)i;
			}
			if (v[0] == '-')
			{
				v = v.Substring(1);
				m = -1.0;
			}
			else
			{
				m = 1.0;
			}
			if (double.TryParse(v, NumberStyles.Float, (IFormatProvider)null, out r))
			{
				return (r * m);
			}
			try
			{
				return double.Parse(v, NumberStyles.Float);
			}
			catch (OverflowException)
			{
				return (double.PositiveInfinity * m);
			}
			catch (Exception)
			{
				if ((v == "Infinity") || (v == "+Infinity"))
				{
					return (double.PositiveInfinity * m);
				}
				return double.NaN;
			}
		}
	}
	internal static class InternalUtilities
	{
		private const double d_2_16 = 65536.0;
		private const double d_2_31 = 2147483648;
		private const double d_2_32 = 4294967296;

		internal static JSValue _Eval(JSContext Scope, JSArgs args, bool AsConstructor)
		{
			if (AsConstructor)
			{
				throw new JSRuntimeException("TypeError", "eval called as constructor");
			}
			JSValue arg = args[0];
			if (!(arg is JSString))
			{
				return arg;
			}
			JSContext EvalContext = new JSContext(Scope);
			JSContext.PushContext(EvalContext);
			try
			{
				return CompiledScript.Compile(arg.StringValue(), false).Run();
			}
			finally
			{
				JSContext.PopContext();
			}
		}

		internal static JSValue DirectEvalCall(JSFunctionBase fnc, JSContext Scope, JSValue ThisObj, JSArgs Args)
		{
			if (fnc == JSContext.CurrentGlobalContext.GlobalEval)
			{
				return _Eval(Scope, Args, false);
			}
			return fnc.Call(JSContext.CurrentGlobalContext, ThisObj, Args);
		}


		internal static JSFunctionBase JSFunctionCast(JSValue val)
		{
			JSFunctionBase r = val as JSFunctionBase;
			if (r == null)
			{
				throw new JSRuntimeException("TypeError", "not a function");
			}
			return r;
		}


		public static string UnicodeTrim(this string v)
		{
			int s = 0;
			while (s < v.Length)
			{
				if (!char.IsWhiteSpace(v[s]))
				{
					break;
				}
				s++;
			}
			int e = v.Length - 1;
			while (e > s)
			{
				if (!char.IsWhiteSpace(v[e]))
				{
					break;
				}
				e--;
			}
			return v.Substring(s, (1 + e) - s);
		}

		public static void EmitCallV(this System.Reflection.Emit.ILGenerator gen, System.Reflection.MethodInfo method)
		{
			gen.Emit(method.IsVirtual ? System.Reflection.Emit.OpCodes.Callvirt : System.Reflection.Emit.OpCodes.Call, method);
		}
	}
}

