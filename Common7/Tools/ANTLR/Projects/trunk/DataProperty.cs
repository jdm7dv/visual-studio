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
	public class DataProperty : PropWrapper
	{

		public DataProperty() : this(JSUndefined.Instance)
		{
		}

		public DataProperty(JSValue value) : this(value, true, true, true)
		{
		}

		public DataProperty(JSValue value, bool Writable, bool Enumerable, bool Configurable) : base(Writable, Enumerable, Configurable)
		{
			this.Value = value;
		}

		public override JSValue Get(JSValue thisValue)
		{
			return this.Value;
		}

		public override void Set(JSValue thisValue, JSValue value)
		{
			if (this.Writable)
			{
				this.Value = value;
			}
		}

		public JSValue Value { get; set; }
	}
}

