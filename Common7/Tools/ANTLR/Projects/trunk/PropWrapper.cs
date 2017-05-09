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
	public abstract class PropWrapper
	{
		protected int _flags = 7;

		public PropWrapper(bool Writable, bool Enumerable, bool Configurable)
		{
			this._flags = ((Writable ? 1 : 0) | (Enumerable ? 2 : 0)) | (Configurable ? 4 : 0);
		}

		public abstract JSValue Get(JSValue thisValue);
		public abstract void Set(JSValue thisValue, JSValue value);

		public virtual bool Configurable
		{
			get
			{
				return ((this._flags & 4) != 0);
			}
			set
			{
				this._flags = value ? (this._flags | 4) : (this._flags & -5);
			}
		}

		public virtual bool Enumerable
		{
			get
			{
				return ((this._flags & 2) != 0);
			}
			set
			{
				this._flags = value ? (this._flags | 2) : (this._flags & -3);
			}
		}

		public virtual bool Writable
		{
			get
			{
				return ((this._flags & 1) != 0);
			}
			set
			{
				this._flags = value ? (this._flags | 1) : (this._flags & -2);
			}
		}
	}
}

