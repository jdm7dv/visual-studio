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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Zinj
{
	public class JSNull : JSPrimitive
	{

		static JSNull()
		{
			Instance = new JSNull();
		}

		private JSNull()
		{
		}

		public override bool BoolValue()
		{
			return false;
		}

		internal override void GenCode(ILGenerator gen)
		{
			gen.EmitCallV( CompileContext.mi_JSNull_Instance);
		}

		internal override void GenTyped(ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldnull);
		}

		public override double NumberValue()
		{
			return 0.0;
		}

		public override string StringValue()
		{
			return "null";
		}

		public override JSObject ToJSObject()
		{
			throw new JSRuntimeException("TypeError", "Cannot convert null to object");
		}

		public override string ClassString
		{
			get
			{
				return "Null";
			}
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Null;
			}
		}

		public static JSNull Instance { get; private set; }

		public override JSValue this[string ind]
		{
			get
			{
				throw new JSRuntimeException("TypeError", "null reference");
			}
			set
			{
				throw new JSRuntimeException("TypeError", "null reference");
			}
		}

		public override string TypeOf
		{
			get
			{
				return "object";
			}
		}
	}
}

