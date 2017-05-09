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
using System.Runtime.CompilerServices;

namespace Zinj
{
	public class JSRuntimeException : Exception
	{

		public JSRuntimeException(JSValue value) : base(value.StringValue())
		{
			this.Line = -1;
			this.value = value;
		}

		public JSRuntimeException(string ExType, string message) : base(message)
		{
			this.Line = -1;
			JSFunctionBase ExCtor = JSContext.CurrentContext.GetBindingValue(ExType) as JSFunctionBase;
			if (ExCtor == null)
			{
				this.value = new JSString(ExType + ": " + this.Message);
			}
			else
			{
				this.value = ExCtor.Construct(JSContext.CurrentContext, new JSArgs(ExCtor, new JSValue[] { new JSString(this.Message) }));
			}
		}

		public int Line { get; internal set; }

		public JSValue value { get; private set; }
	}
}

