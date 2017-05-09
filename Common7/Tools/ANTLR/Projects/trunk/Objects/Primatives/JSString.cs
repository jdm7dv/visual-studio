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
	public class JSString : JSPrimitive
	{
		public static readonly JSString Empty = new JSString("");

		public JSString(string Value)
		{
			if (Value == null)
			{
				throw new ArgumentNullException("Value");
			}
			this.Value = Value;
		}

		public override bool BoolValue()
		{
			return (this.Value.Length > 0);
		}

		internal override void GenCode(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldstr, this.Value);
			gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
		}

		internal override void GenTyped(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldstr, this.Value);
		}

		public override int GetHashCode()
		{
			return this.Value.GetHashCode();
		}

		public override double NumberValue()
		{
			return this.Value.ToJSNumber();
		}

		public static implicit operator JSString(string v)
		{
			return new JSString(v);
		}

		public override string StringValue()
		{
			return this.Value;
		}

		public override JSObject ToJSObject()
		{
			return new JSBoxedString(this);
		}

		public override JSString ToJSString()
		{
			return this;
		}

		public override string ClassString
		{
			get
			{
				return "String";
			}
		}

		public override JSType DataType
		{
			get
			{
				return JSType.String;
			}
		}

		public override JSValue Prototype
		{
			get
			{
				return JSContext.CurrentGlobalContext.StringPrototype;
			}
		}

		public override string TypeOf
		{
			get
			{
				return "string";
			}
		}

		public string Value { get; private set; }
	}
}

