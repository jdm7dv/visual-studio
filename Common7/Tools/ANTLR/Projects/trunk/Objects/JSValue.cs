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
using System.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Zinj
{
	public abstract class JSValue : JSBase
	{
		protected JSValue()
		{
		}

		internal virtual IEnumerable<string> _EnumerateProps()
		{
			if (this.Prototype == null) return new string[] { };
			return this.Prototype._EnumerateProps();
		}

		public abstract bool BoolValue();
		public IEnumerable<string> EnumeratePropNames()
		{
			return this._EnumerateProps().Distinct().ToArray();
		}

		public virtual IList<KeyValuePair<string, PropWrapper>> GetOwnProperties()
		{
			return new KeyValuePair<string, PropWrapper>[0];
		}

		internal virtual PropWrapper GetOwnPropertyRef(string ind)
		{
			return null;
		}

		internal PropWrapper getRef(string ind, bool ForSet)
		{
			PropWrapper r = this.GetOwnPropertyRef(ind);
			if (r != null)
			{
				return r;
			}
			for (JSValue v = this.Prototype; v != null; v = v.Prototype)
			{
				r = v.GetOwnPropertyRef(ind);
				if (ForSet && (r is DataProperty))
				{
					return null;
				}
				if (r != null)
				{
					return r;
				}
			}
			return null;
		}

		private bool GreaterThan(JSValue b)
		{
			if ((this.DataType == JSType.String) && (b.DataType == JSType.String))
			{
				return (string.Compare(this.StringValue(), b.StringValue(), StringComparison.Ordinal) > 0);
			}
			return (this.NumberValue() > b.NumberValue());
		}

		private bool GreaterThanOrNull(JSValue b)
		{
			if ((this.DataType == JSType.String) && (b.DataType == JSType.String))
			{
				return (string.Compare(this.StringValue(), b.StringValue(), StringComparison.Ordinal) > 0);
			}
			return !(this.NumberValue() <= b.NumberValue());
		}

		public virtual bool HasOwnProperty(string key)
		{
			return false;
		}

		public virtual bool HasProperty(string key)
		{
			return ((this.Prototype != null) && this.Prototype.HasProperty(key));
		}

		public bool HasProperty_in(string key)
		{
			if (!(this is JSObject))
			{
				throw new JSRuntimeException("TypeError", "invalid 'in' operand");
			}
			return this.HasProperty(key);
		}

		public static bool JSEquals(JSValue a, JSValue b)
		{
			JSType t1 = a.ObjectType;
			JSType t2 = b.ObjectType;
			if (t1 != t2)
			{
				switch (t2)
				{
					case JSType.Boolean:
						return JSEquals(a, b.ToJSNumber());

					case JSType.Object:
						return JSEquals(a, b.ToPrimitive());
				}
				switch (t1)
				{
					case JSType.Number:
						if (t2 != JSType.String)
						{
							goto Label_016F;
						}
						return (a.NumberValue() == b.NumberValue());

					case JSType.String:
						if (t2 != JSType.Number)
						{
							goto Label_016F;
						}
						return (a.NumberValue() == b.NumberValue());

					case JSType.Boolean:
						return JSEquals(a.ToJSNumber(), b);

					case JSType.Object:
						return JSEquals(a.ToPrimitive(), b);

					case JSType.Array:
					case JSType.Function:
						goto Label_016F;

					case JSType.Null:
						return (t2 == JSType.Undefined);

					case JSType.Undefined:
						return (t2 == JSType.Null);
				}
			}
			else
			{
				switch (t1)
				{
					case JSType.Number:
						return (a.NumberValue() == b.NumberValue());

					case JSType.String:
						return (a.StringValue() == b.StringValue());

					case JSType.Boolean:
						return (a.BoolValue() == b.BoolValue());

					case JSType.Null:
						return true;

					case JSType.Undefined:
						return true;
				}
				return (a == b);
			}
		Label_016F:
			return false;
		}

		public static bool JSEqualsExact(JSValue a, JSValue b)
		{
			JSType t1 = a.ObjectType;
			JSType t2 = b.ObjectType;
			if (t1 != t2)
			{
				return false;
			}
			switch (t1)
			{
				case JSType.Number:
					return (a.NumberValue() == b.NumberValue());

				case JSType.String:
					return (a.StringValue() == b.StringValue());

				case JSType.Boolean:
					return (a.BoolValue() == b.BoolValue());

				case JSType.Null:
					return true;

				case JSType.Undefined:
					return true;
			}
			return (a == b);
		}

		public static JSValue LogAnd(JSValue a, JSValue b)
		{
			if (!a.BoolValue())
			{
				return a;
			}
			return b;
		}

		public static JSValue LogOr(JSValue a, JSValue b)
		{
			if (a.BoolValue())
			{
				return a;
			}
			return b;
		}

		public abstract double NumberValue();
		public static JSValue operator +(JSValue a, JSValue b)
		{
			a = a.ToPrimitive();
			b = b.ToPrimitive();
			if ((a.DataType == JSType.String) || (b.DataType == JSType.String))
			{
				return (a.StringValue() + b.StringValue());
			}
			return (a.NumberValue() + b.NumberValue());
		}

		public static JSValue operator /(JSValue a, JSValue b)
		{
			return new JSNumber(a.ToPrimitive().NumberValue() / b.ToPrimitive().NumberValue());
		}

		public static bool operator >(JSValue a, JSValue b)
		{
			return a.ToPrimitive().GreaterThan(b.ToPrimitive());
		}

		public static bool operator >=(JSValue a, JSValue b)
		{
			a = a.ToPrimitive();
			b = b.ToPrimitive();
			return !b.GreaterThanOrNull(a);
		}

		public static implicit operator JSValue(bool v)
		{
			return (v ? JSBool.True : JSBool.False);
		}

		public static implicit operator JSValue(double v)
		{
			return new JSNumber(v);
		}

		public static implicit operator JSValue(string v)
		{
			return new JSString(v);
		}

		public static bool operator <(JSValue a, JSValue b)
		{
			JSValue t = a.ToPrimitive();
			return b.ToPrimitive().GreaterThan(t);
		}

		public static bool operator <=(JSValue a, JSValue b)
		{
			a = a.ToPrimitive();
			b = b.ToPrimitive();
			return !a.GreaterThanOrNull(b);
		}

		public static JSValue operator %(JSValue a, JSValue b)
		{
			return new JSNumber(a.ToPrimitive().NumberValue() % b.ToPrimitive().NumberValue());
		}

		public static JSValue operator *(JSValue a, JSValue b)
		{
			return new JSNumber(a.ToPrimitive().NumberValue() * b.ToPrimitive().NumberValue());
		}

		public static JSValue operator -(JSValue a, JSValue b)
		{
			return new JSNumber(a.ToPrimitive().NumberValue() - b.ToPrimitive().NumberValue());
		}

		public abstract string StringValue();
		public virtual int ToInt32()
		{
			return this.NumberValue().JSToInt32();
		}

		public virtual JSBool ToJSBool()
		{
			return this.BoolValue();
		}

		public virtual JSNumber ToJSNumber()
		{
			return this.NumberValue();
		}

		public abstract JSObject ToJSObject();
		public virtual JSString ToJSString()
		{
			return this.StringValue();
		}

		public virtual JSValue ToPrimitive()
		{
			return this.ToPrimitive(false);
		}

		public abstract JSValue ToPrimitive(bool AsString);
		public override string ToString()
		{
			return this.ToPrimitive(true).StringValue();
		}

		public virtual uint ToUInt32()
		{
			return this.NumberValue().JSToUInt32();
		}

		public override string GetBindingType(string Key)
		{
			return this[Key].TypeOf;
		}

		public abstract string ClassString { get; }

		public abstract JSType DataType { get; }

		public virtual bool IsExtensible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual JSValue this[string ind]
		{
			get
			{
				PropWrapper r = this.getRef(ind, false);
				if (r != null)
				{
					return r.Get(this);
				}
				return JSUndefined.Instance;
			}
			set
			{
				PropWrapper r = this.getRef(ind, true);
				if (r != null)
				{
					r.Set(this, value);
				}
			}
		}

		public virtual JSType ObjectType
		{
			get
			{
				return this.DataType;
			}
		}

		public virtual JSValue Prototype
		{
			get
			{
				return null;
			}
		}

		public abstract string TypeOf { get; }
	}
}

