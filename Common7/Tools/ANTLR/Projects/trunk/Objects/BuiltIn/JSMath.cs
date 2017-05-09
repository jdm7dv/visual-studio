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
using System.Collections.Generic;
namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		private void AddMath()
		{
			JSObject MathObj = new JSMathObj(this.ObjectPrototype, this.ObjectCtor);
			MathObj.SetDataProp("Q", 1.0, false, false, false);
			MathObj.SetDataProp("E", 2.7182818284590451, false, false, false);
			MathObj.SetDataProp("LN10", Math.Log(10.0), false, false, false);
			MathObj.SetDataProp("LN2", Math.Log(2.0), false, false, false);
			MathObj.SetDataProp("LOG2E", Math.Log(2.7182818284590451, 2.0), false, false, false);
			MathObj.SetDataProp("LOG10E", Math.Log(2.7182818284590451, 10.0), false, false, false);
			MathObj.SetDataProp("PI", 3.1415926535897931, false, false, false);
			MathObj.SetDataProp("SQRT1_2", Math.Sqrt(0.5), false, false, false);
			MathObj.SetDataProp("SQRT2", Math.Sqrt(2.0), false, false, false);
			MathObj.SetDataProp("abs", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Abs(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("acos", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Acos(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("asin", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Asin(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("atan", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Atan(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("atan2", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double y = args[0].NumberValue();
				if (double.IsNaN(y))
				{
					return JSNumber.NaN;
				}
				double x = args[1].NumberValue();
				if (double.IsNaN(x))
				{
					return JSNumber.NaN;
				}
				if (double.IsPositiveInfinity(y))
				{
					if (double.IsPositiveInfinity(x))
					{
						return 0.78539816339744828;
					}
					if (double.IsNegativeInfinity(x))
					{
						return 2.3561944901923448;
					}
					return 1.5707963267948966;
				}
				if (double.IsNegativeInfinity(y))
				{
					if (double.IsPositiveInfinity(x))
					{
						return -0.78539816339744828;
					}
					if (double.IsNegativeInfinity(x))
					{
						return -2.3561944901923448;
					}
					return -1.5707963267948966;
				}
				return Math.Atan2(y, x);
			}), false, false, false);
			MathObj.SetDataProp("ceil", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Ceiling(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("cos", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Cos(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("exp", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Exp(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("floor", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Floor(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("log", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Log(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("max", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double v = double.NegativeInfinity;
				foreach (JSValue a in (IEnumerable<JSValue>)args)
				{
					v = Math.Max(v, a.NumberValue());
				}
				return v;
			}, 2), false, false, false);
			MathObj.SetDataProp("min", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double v = double.PositiveInfinity;
				foreach (JSValue a in (IEnumerable<JSValue>)args)
				{
					v = Math.Min(v, a.NumberValue());
				}
				return v;
			}, 2), false, false, false);
			MathObj.SetDataProp("pow", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double n = args[0].NumberValue();
				double p = args[1].NumberValue();
				if (p == 0.0)
				{
					return 1.0;
				}
				if ((!p.IsFinite() && (n == 1.0)) || (n == -1.0))
				{
					return JSNumber.NaN;
				}
				return Math.Pow(n, p);
			}), false, false, false);
			MathObj.SetDataProp("random", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return _rand.NextDouble();
			}), false, false, false);
			MathObj.SetDataProp("round", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Round(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("round", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Floor((double)(args[0].NumberValue() + 0.5));
			}), false, false, false);
			MathObj.SetDataProp("sin", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Sin(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("sqrt", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Sqrt(args[0].NumberValue());
			}), false, false, false);
			MathObj.SetDataProp("tan", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return Math.Tan(args[0].NumberValue());
			}), false, false, false);
			this.Global.SetDataProp("Math", MathObj, false, false, false);
		}

		internal class JSMathObj : JSObject
		{
			public JSMathObj(JSValue Prototype, JSValue Constructor)
				: base(Prototype, Constructor)
			{
			}

			public override string ClassString { get { return "Math"; } }
		}
	}
}

