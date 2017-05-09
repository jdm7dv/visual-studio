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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinj
{
	public abstract class JSEnvRec
	{
		internal Zinj.CompileContext CompileContext;

		public JSEnvRec(JSEnvRec Parent)
		{
			this.Parent = Parent;
		}

		public abstract void CreateMutableBinding(string key);
		public abstract bool DeleteBinding(string Key, bool Throw);
		public abstract JSValue GetBindingValue(string key);
		public abstract bool HasBinding(string key);
		public abstract void SetMutableBinding(string key, JSValue value);
		public virtual bool TryGetBindingValue(string key, out JSValue r)
		{
			if (this.HasBinding(key))
			{
				r = this.GetBindingValue(key);
				return true;
			}
			r = null;
			return false;
		}

		internal virtual bool TrySetBindingValue(string key, JSValue value)
		{
			if (this.HasBinding(key) || (this is JSGlobalScope))
			{
				this.SetMutableBinding(key, value);
				return true;
			}
			return ((this.Parent != null) && this.Parent.TrySetBindingValue(key, value));
		}

		internal virtual JSValue ImplicitThis
		{
			get
			{
				return JSUndefined.Instance;
			}
		}

		public JSEnvRec Parent { get; set; }

		public virtual JSValue ThisObject
		{
			get
			{
				return JSUndefined.Instance;
			}
		}
	}
}

