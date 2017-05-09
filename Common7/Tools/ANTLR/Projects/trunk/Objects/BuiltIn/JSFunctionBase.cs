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
	public class JSFunctionBase : JSObject
	{
		internal JSFunctionBase() : base(JSContext.CurrentGlobalContext.ObjectPrototype)
		{
		}

		protected JSFunctionBase(JSValue Prototype, JSValue Constructor) : base(Prototype, Constructor)
		{
		}

		public virtual JSValue Call(JSValue ThisObj, params JSValue[] Args)
		{
			if (ThisObj == null)
			{
				ThisObj = JSUndefined.Instance;
			}
			return this.Call(JSContext.CurrentContext, ThisObj, new JSArgs(this, Args));
		}

		public virtual JSValue Call(JSContext Scope, JSValue ThisObj, JSArgs Args)
		{
			return JSUndefined.Instance;
		}

		public virtual JSValue Construct(JSContext Scope, JSArgs Args)
		{
			JSObject o = new JSObject(this["prototype"], this);
			JSValue r = this.Call(Scope, o, Args);
			if (r is JSObject)
			{
				return r;
			}
			return o;
		}

		protected virtual string GenerateArgsString()
		{
			int l = (int) this["length"].NumberValue();
			switch (l)
			{
				case 0:
					return "";

				case 1:
					return "A";
			}
			string r = "A";
			for (int i = 1; i < l; i++)
			{
				r = r + "," + ((char) (0x41 + i));
			}
			return r.Substring(1);
		}

		protected virtual string GenerateBodyString()
		{
			return "/* no body defined */";
		}

		public virtual string GenerateString()
		{
			return ("function(" + this.GenerateArgsString() + ") {" + this.GenerateBodyString() + "}");
		}

		public virtual bool HasInstance(JSValue obj)
		{
			JSValue CtorPrototype = this["prototype"];
			if (!(CtorPrototype is JSObject))
			{
				throw new JSRuntimeException("TypeError", "'prototype' property of function is not an object");
			}
			if (CtorPrototype == null)
			{
				return false;
			}
			while (true)
			{
				if (!(obj is JSObject))
				{
					return false;
				}
				if (CtorPrototype == ((JSObject) obj).Prototype)
				{
					return true;
				}
				obj = obj.Prototype;
			}
		}

		public override string ClassString
		{
			get
			{
				return "Function";
			}
		}

		public override JSType ObjectType
		{
			get
			{
				return JSType.Function;
			}
		}

		public override string TypeOf
		{
			get
			{
				return "function";
			}
		}
	}
}

