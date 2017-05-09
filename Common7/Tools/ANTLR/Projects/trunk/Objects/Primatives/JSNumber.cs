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
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Zinj
{
	public class JSNumber : JSPrimitive
	{
		public static readonly JSNumber NaN = new JSNumber(double.NaN);
		public static readonly JSNumber NegOne = new JSNumber(-1.0);
		public static readonly JSNumber One = new JSNumber(1.0);
		public static readonly JSNumber Zero = new JSNumber(0.0);

		public JSNumber(double Value)
		{
			this.Value = Value;
		}

		public override bool BoolValue()
		{
			return (!double.IsNaN(this.Value) && (this.Value != 0.0));
		}

		internal override void GenCode(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldc_R8, this.Value);
			gen.Emit(OpCodes.Newobj, CompileContext.JSNumber_ctor);
		}

		internal override void GenTyped(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldc_R8, this.Value);
		}

		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		public override double NumberValue()
		{
			return this.Value;
		}

		public static implicit operator JSNumber(double v)
		{
			return new JSNumber(v);
		}

		public override string StringValue()
		{
			return this.Value.JSToString();
		}

		public override JSNumber ToJSNumber()
		{
			return this;
		}

		public override JSObject ToJSObject()
		{
			return new JSBoxedNumber(this);
		}

		public override string ClassString
		{
			get
			{
				return "Number";
			}
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Number;
			}
		}

		public override JSValue Prototype
		{
			get
			{
				return JSContext.CurrentGlobalContext.NumberPrototype;
			}
		}

		public override string TypeOf
		{
			get
			{
				return "number";
			}
		}

		public double Value { get; private set; }
	}
}

