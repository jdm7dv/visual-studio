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
	internal class JSDelegateProperty : PropWrapper
	{

		public JSDelegateProperty(Func<JSValue, JSValue> getter, Action<JSValue, JSValue> setter) : this(getter, setter, true, true, false)
		{
		}

		public JSDelegateProperty(Func<JSValue, JSValue> getter, Action<JSValue, JSValue> setter, bool Writable, bool Enumerable, bool Configurable) : base(Writable, Enumerable, Configurable)
		{
			this.Getter = getter;
			this.Setter = setter;
		}

		public override JSValue Get(JSValue thisValue)
		{
			if (this.Getter == null)
			{
				throw new NotSupportedException();
			}
			return this.Getter(thisValue);
		}

		public override void Set(JSValue thisValue, JSValue value)
		{
			if (this.Setter == null)
			{
				throw new NotSupportedException();
			}
			this.Setter(thisValue, value);
		}

		public Func<JSValue, JSValue> Getter { get; private set; }

		public Action<JSValue, JSValue> Setter { get; private set; }
	}
}

