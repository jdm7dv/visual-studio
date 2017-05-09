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
using System.Collections.Generic;

namespace Zinj
{
	internal class JSDeclScope : JSEnvRec
	{
		protected Dictionary<string, JSValue> scopeValues;

		public JSDeclScope(JSEnvRec Parent) : base(Parent)
		{
			this.scopeValues = new Dictionary<string, JSValue>();
		}

		public override void CreateMutableBinding(string key)
		{
			if (!this.scopeValues.ContainsKey(key))
			{
				this.scopeValues.Add(key, JSUndefined.Instance);
			}
		}

		public override bool DeleteBinding(string key, bool Throw)
		{
			if (this.scopeValues.ContainsKey(key))
			{
				return false;
			}
			return true;
		}

		public override JSValue GetBindingValue(string key)
		{
			JSValue r;
			if (this.scopeValues.TryGetValue(key, out r))
			{
				return r;
			}
			if (base.Parent == null)
			{
				throw new JSRuntimeException("ReferenceError", key + " is not defined");
			}
			return base.Parent.GetBindingValue(key);
		}

		public override bool HasBinding(string key)
		{
			return this.scopeValues.ContainsKey(key);
		}

		public override void SetMutableBinding(string key, JSValue value)
		{
			this.scopeValues[key] = value;
		}
	}
}

