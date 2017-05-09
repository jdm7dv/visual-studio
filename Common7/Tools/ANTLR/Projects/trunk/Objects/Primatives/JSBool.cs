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
	public abstract class JSBool : JSPrimitive
	{

		static JSBool()
		{
			True = new JSBool_T();
			False = new JSBool_F();
		}

		protected JSBool(bool Value)
		{
			this.Value = Value;
		}

		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		public static implicit operator JSBool(bool v)
		{
			return (v ? True : False);
		}

		public override JSBool ToJSBool()
		{
			return this;
		}

		public override JSObject ToJSObject()
		{
			return new JSBoxedBoolean(this);
		}

		public override string ClassString
		{
			get
			{
				return "Boolean";
			}
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Boolean;
			}
		}

		public static JSBool False { get; private set; }

		public override JSValue Prototype
		{
			get
			{
				return JSContext.CurrentGlobalContext.BooleanPrototype;
			}
		}

		public static JSBool True { get; private set; }

		public override string TypeOf
		{
			get
			{
				return "boolean";
			}
		}

		public bool Value { get; private set; }

		private class JSBool_F : JSBool
		{
			private static JSNumber nv = 0.0;

			public JSBool_F() : base(false)
			{
			}

			public override bool BoolValue()
			{
				return false;
			}

			internal override void GenCode(ILGenerator gen)
			{
				gen.EmitCallV( CompileContext.mi_JSBool_False);
			}

			internal override void GenTyped(ILGenerator gen)
			{
				gen.Emit(OpCodes.Ldc_I4_0);
			}

			public override double NumberValue()
			{
				return 0.0;
			}

			public override string StringValue()
			{
				return "false";
			}

			public override JSNumber ToJSNumber()
			{
				return nv;
			}
		}

		private class JSBool_T : JSBool
		{
			private static JSNumber nv = 1.0;

			public JSBool_T() : base(true)
			{
			}

			public override bool BoolValue()
			{
				return true;
			}

			internal override void GenCode(ILGenerator gen)
			{
				gen.EmitCallV( CompileContext.mi_JSBool_True);
			}

			internal override void GenTyped(ILGenerator gen)
			{
				gen.Emit(OpCodes.Ldc_I4_1);
			}

			public override double NumberValue()
			{
				return 1.0;
			}

			public override string StringValue()
			{
				return "true";
			}

			public override JSNumber ToJSNumber()
			{
				return nv;
			}
		}
	}
}

