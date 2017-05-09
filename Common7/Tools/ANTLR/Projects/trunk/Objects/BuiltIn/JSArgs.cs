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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Zinj
{
	public class JSArgs : JSObject, IEnumerable<JSValue>, IEnumerable
	{
		private bool _PropsLoaded;
		internal JSValue[] ArgValues;
		private JSValue Callee;

		public JSArgs(JSValue Callee, params JSValue[] Args)
		{
			this.ArgValues = Args;
			this.Callee = Callee;
		}

		private void LoadProps()
		{
			this._PropsLoaded = true;
			base.SetDataProp("length", (double) this.ArgValues.Length, true, false, true);
			base.SetDataProp("callee", this.Callee, true, false, true);
			for (int i = 0; i < this.ArgValues.Length; i++)
			{
				base.SetDataProp(i.ToString(), this.ArgValues[i], true, false, true);
			}
		}

		IEnumerator<JSValue> IEnumerable<JSValue>.GetEnumerator()
		{
			return ((IEnumerable<JSValue>) this.ArgValues).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.ArgValues.GetEnumerator();
		}

		public int Count
		{
			get
			{
				return this.ArgValues.Length;
			}
		}

		public JSValue this[int ind]
		{
			get
			{
				if (ind >= this.ArgValues.Length)
				{
					return JSUndefined.Instance;
				}
				return this.ArgValues[ind];
			}
		}

		internal override Dictionary<string, PropWrapper> Members
		{
			get
			{
				if (!this._PropsLoaded)
				{
					this.LoadProps();
				}
				return base.Members;
			}
		}
	}
}

