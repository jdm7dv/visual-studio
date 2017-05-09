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

namespace Zinj
{
	public class JSBoxedString : JSObject
	{
		private JSString _val;

		public JSBoxedString(JSString val) : base(JSContext.CurrentGlobalContext.StringPrototype, JSContext.CurrentGlobalContext.StringCtor)
		{
			this._val = val;
			base.SetDataProp("length", (double) val.Value.Length, false, false, false);
		}

		internal JSBoxedString(JSValue Prototype, JSValue Constructor) : base(Prototype, Constructor)
		{
			this._val = JSString.Empty;
			base.SetDataProp("length", 0.0, false, false, false);
		}

		public override double NumberValue()
		{
			return this._val.NumberValue();
		}

		public override string StringValue()
		{
			return this._val.Value;
		}

		public override JSString ToJSString()
		{
			return this._val;
		}

		public override JSValue ToPrimitive(bool AsString)
		{
			return this._val;
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
	}
}

