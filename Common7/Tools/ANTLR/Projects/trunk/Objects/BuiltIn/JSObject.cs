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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Linq;

namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		internal JSDelegateWrapper ObjectCtor;
		internal JSObject ObjectPrototype;

		private void AddObject()
		{
			this.ObjectCtor = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSValue arg = args[0];
				if ((arg is JSUndefined) || (arg is JSNull))
				{
					return new JSObject(this.ObjectPrototype, this.ObjectCtor);
				}
				return arg.ToJSObject();
			}, 1);
			this.ObjectPrototype = new JSObject(null, this.ObjectCtor);
			this.ObjectCtor.SetDataProp("prototype", this.ObjectPrototype, false, false, false);
		}

		private void AddObjectProperties()
		{
			this.Global.SetDataProp("Object", this.ObjectCtor, false, false, false);
			this.ObjectCtor.SetDataProp("getPrototypeOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "getPrototypeOf argument not an object");
				}
				JSValue r = arg.Prototype;
				if (r == null)
				{
					return JSNull.Instance;
				}
				return r;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("getOwnPropertyNames", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "getOwnPropertyNames argument not an object");
				}
				IList<KeyValuePair<string, PropWrapper>> c = arg.GetOwnProperties();
				List<JSValue> ar = new List<JSValue>();
				foreach (KeyValuePair<string, PropWrapper> p in c)
				{
					if (p.Value.Enumerable)
					{
						ar.Add(p.Key);
					}
				}
				return new JSArray(ar.ToArray());
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("create", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSValue arg = args[0];
				if (!((arg is JSObject) || (arg is JSNull)))
				{
					throw new JSRuntimeException("TypeError", "invalid prototype passed to Object.create");
				}
				if (arg is JSNull)
				{
					arg = null;
				}
				JSObject obj = new JSObject(arg);
				if (args.Count > 1)
				{
					throw new NotImplementedException();
				}
				return obj;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("defineProperty", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject O = args[0] as JSObject;
				if (O == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.defineProperty");
				}
				string P = args[1].StringValue();
				JSObject desc = args[2].ToJSObject();
				UpdatePropertyDescriptor(O, P, desc);
				return O;
			}, 3), true, false, true);
			this.ObjectCtor.SetDataProp("defineProperties", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ObjectCtor.SetDataProp("seal", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.seal");
				}
				foreach (KeyValuePair<string, PropWrapper> p in arg.GetOwnProperties())
				{
					p.Value.Configurable = false;
				}
				arg.IsExtensible = false;
				return arg;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("freeze", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.freeze");
				}
				foreach (KeyValuePair<string, PropWrapper> p in arg.GetOwnProperties())
				{
					if (p.Value is DataProperty)
					{
						p.Value.Writable = false;
					}
					p.Value.Configurable = false;
				}
				arg.IsExtensible = false;
				return arg;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("preventExtensions", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.preventExtensions");
				}
				arg.IsExtensible = false;
				return arg;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("isSealed", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.isSealed");
				}
				if (arg.IsExtensible)
				{
					return JSBool.False;
				}
				foreach (KeyValuePair<string, PropWrapper> p in arg.GetOwnProperties())
				{
					if (p.Value.Configurable)
					{
						return JSBool.False;
					}
				}
				return JSBool.True;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("isFrozen", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.isFrozen");
				}
				if (arg.IsExtensible)
				{
					return JSBool.False;
				}
				foreach (KeyValuePair<string, PropWrapper> p in arg.GetOwnProperties())
				{
					if ((p.Value is DataProperty) && p.Value.Writable)
					{
						return JSBool.False;
					}
					if (p.Value.Configurable)
					{
						return JSBool.False;
					}
				}
				return JSBool.True;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("isExtensible", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.isExtensible");
				}
				return arg.IsExtensible;
			}, 1), true, false, true);
			this.ObjectCtor.SetDataProp("keys", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject arg = args[0] as JSObject;
				if (arg == null)
				{
					throw new JSRuntimeException("TypeError", "invalid argument passed to Object.keys");
				}
				IList<KeyValuePair<string, PropWrapper>> ar = arg.GetOwnProperties();
				List<JSValue> ar2 = new List<JSValue>();
				for (int i = 0; i < ar.Count; i++)
				{
					KeyValuePair<string, PropWrapper> p = ar[i];
					if (p.Value.Enumerable)
					{
						ar2.Add(p.Key);
					}
				}
				return new JSArray(ar2.ToArray());
			}, 1), true, false, true);
			this.ObjectPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return "[object " + ThisObj.ClassString + "]";
			}), true, false, true);
			this.ObjectPrototype.SetDataProp("toLocaleString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return ((JSFunctionBase)ThisObj.ToJSObject()["toString"]).Call(Scope, ThisObj, args);
			}), true, false, true);
			this.ObjectPrototype.SetDataProp("valueOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return ThisObj;
			}), true, false, true);
			this.ObjectPrototype.SetDataProp("hasOwnProperty", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return ThisObj.HasOwnProperty(args[0].StringValue());
			}, 1), true, false, true);
			this.ObjectPrototype.SetDataProp("isPrototypeOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSValue v = args[0];
				while (true)
				{
					v = v.Prototype;
					if (v == null)
					{
						return JSBool.False;
					}
					if (v == ThisObj)
					{
						return JSBool.True;
					}
				}
			}, 1), true, false, true);
			this.ObjectPrototype.SetDataProp("propertyIsEnumerable", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				string v = args[0].StringValue();
				PropWrapper r = ThisObj.ToJSObject().GetOwnPropertyRef(v);
				if (r == null)
				{
					return JSBool.False;
				}
				return r.Enumerable;
			}, 1), true, false, true);
		}

		private static void UpdatePropertyDescriptor(JSObject O, string P, JSObject desc)
		{
			JSValue tmp;
			JSValue value = JSUndefined.Instance;
			JSFunctionBase getter = null;
			JSFunctionBase setter = null;
			bool enumerable = true;
			bool configurable = true;
			bool writable = true;
			bool hasValue = false;
			bool hasGet = false;
			bool hasSet = false;
			bool hasEnumerable = false;
			bool hasConfigurable = false;
			bool hasWritable = false;
			if (desc.TryGetPropertyValue("enumerable", out tmp))
			{
				enumerable = tmp.BoolValue();
				hasEnumerable = true;
			}
			if (desc.TryGetPropertyValue("configurable", out tmp))
			{
				configurable = tmp.BoolValue();
				hasConfigurable = true;
			}
			if (desc.TryGetPropertyValue("value", out tmp))
			{
				value = tmp;
				hasValue = true;
			}
			if (desc.TryGetPropertyValue("writable", out tmp))
			{
				writable = tmp.BoolValue();
				hasWritable = true;
			}
			if (desc.TryGetPropertyValue("get", out tmp))
			{
				if (tmp is JSUndefined)
				{
					getter = null;
				}
				else
				{
					if (!(tmp is JSFunctionBase))
					{
						throw new JSRuntimeException("TypeError", "invalid 'get' property in property descriptor");
					}
					getter = (JSFunctionBase)tmp;
				}
				hasGet = true;
			}
			if (desc.TryGetPropertyValue("set", out tmp))
			{
				if (tmp is JSUndefined)
				{
					setter = null;
				}
				else
				{
					if (!(tmp is JSFunctionBase))
					{
						throw new JSRuntimeException("TypeError", "invalid 'set' property in property descriptor");
					}
					setter = (JSFunctionBase)tmp;
				}
				hasSet = true;
			}
			if (hasValue || hasGet || hasSet || hasEnumerable || hasConfigurable || hasWritable)
			{
				PropWrapper newProp;
				bool bIsAccessor;
				if (!(hasGet || hasSet))
				{
					bIsAccessor = false;
				}
				else
				{
					if (hasValue || hasWritable)
					{
						throw new JSRuntimeException("TypeError", "property descriptor contained values for both data and accessor");
					}
					bIsAccessor = true;
				}
				PropWrapper oldProp = O.GetOwnPropertyRef(P);
				if (oldProp == null)
				{
					if (!O.IsExtensible)
					{
						throw new JSRuntimeException("TypeError", "object is not extensible");
					}
					if (bIsAccessor)
					{
						newProp = new AccessorProperty(getter, setter, writable, enumerable, configurable);
					}
					else
					{
						newProp = new DataProperty(value, writable, enumerable, configurable);
					}
				}
				else
				{
					if (oldProp is DataProperty)
					{
						DataProperty _o = oldProp as DataProperty;
						if ((((!hasValue || JSValue.JSEqualsExact(value, _o.Value)) && (!hasEnumerable || (writable == oldProp.Writable))) && (!hasConfigurable || (enumerable == oldProp.Enumerable))) && (!hasWritable || (configurable == oldProp.Configurable)))
						{
							return;
						}
					}
					else if (oldProp is AccessorProperty)
					{
						AccessorProperty _o = oldProp as AccessorProperty;
						if ((((!hasEnumerable || (writable == oldProp.Writable)) && (!hasConfigurable || (enumerable == oldProp.Enumerable))) && (!hasGet || (getter == _o.Getter))) && (!hasSet || (setter == _o.Setter)))
						{
							return;
						}
					}
					if (!oldProp.Configurable)
					{
						throw new JSRuntimeException("TypeError", "property is not configurable");
					}
					if ((bIsAccessor && (oldProp is AccessorProperty)) || (!bIsAccessor && (oldProp is DataProperty)))
					{
						newProp = oldProp;
					}
					else if (bIsAccessor)
					{
						newProp = new AccessorProperty(getter, setter);
					}
					else
					{
						newProp = new DataProperty(value);
					}
					if (hasConfigurable)
					{
						newProp.Configurable = configurable;
					}
					if (hasEnumerable)
					{
						newProp.Enumerable = enumerable;
					}
					if (bIsAccessor)
					{
						if (hasGet)
						{
							((AccessorProperty)newProp).Getter = getter;
						}
						if (hasSet)
						{
							((AccessorProperty)newProp).Setter = setter;
						}
					}
					else
					{
						if (hasWritable)
						{
							((DataProperty)newProp).Value = value;
						}
						if (hasValue)
						{
							newProp.Set(O, value);
						}
					}
				}
				O.SetProp(P, newProp);
			}
		}
	}

	public class JSObject : JSValue
	{
		private bool _extensible;
		private Dictionary<string, PropWrapper> _members;
		private JSValue _prototype;

		public JSObject() : this(JSContext.CurrentGlobalContext.ObjectPrototype, null)
		{
		}

		public JSObject(JSValue Prototype) : this(Prototype, null)
		{
		}

		public JSObject(JSValue Prototype, JSValue Constructor)
		{
			this._extensible = true;
			this._members = new Dictionary<string, PropWrapper>();
			this._prototype = Prototype;
			if (Constructor != null)
			{
				this.SetDataProp("constructor", Constructor, true, false, true);
			}
		}

		internal override IEnumerable<string> _EnumerateProps()
		{
			return this.Members
				.Where(x => x.Value.Enumerable)
				.Select(x => x.Key)
				.Union(base._EnumerateProps());
		}

		public override bool BoolValue()
		{
			return true;
		}

		public override bool DeleteProperty(string Key, bool Throw)
		{
			PropWrapper r;
			if (this.Members.TryGetValue(Key, out r))
			{
				if (!r.Configurable)
				{
					if (Throw)
					{
						throw new Exception();
					}
					return false;
				}
				this.Members.Remove(Key);
			}
			return true;
		}

		public override IList<KeyValuePair<string, PropWrapper>> GetOwnProperties()
		{
			List<KeyValuePair<string, PropWrapper>> l = new List<KeyValuePair<string, PropWrapper>>();
			foreach (KeyValuePair<string, PropWrapper> p in this.Members)
			{
				if (p.Value.Enumerable)
				{
					l.Add(p);
				}
			}
			return l;
		}

		internal override PropWrapper GetOwnPropertyRef(string ind)
		{
			PropWrapper r;
			if (this.Members.TryGetValue(ind, out r))
			{
				return r;
			}
			return base.GetOwnPropertyRef(ind);
		}

		public override bool HasOwnProperty(string key)
		{
			return this.Members.ContainsKey(key);
		}

		public override bool HasProperty(string key)
		{
			return (this.Members.ContainsKey(key) || base.HasProperty(key));
		}

		public override double NumberValue()
		{
			return this.ToPrimitive(false).NumberValue();
		}

		internal void SetDataProp(string key, JSValue val, bool Writable, bool Enumerable, bool Configurable)
		{
			if (this.Members.ContainsKey(key))
			{
				this.Members.Remove(key);
			}
			this.Members.Add(key, new DataProperty(val, Writable, Enumerable, Configurable));
		}

		public void SetProp(string ind, PropWrapper v)
		{
			if (this.Members.ContainsKey(ind))
			{
				this.Members[ind] = v;
			}
			else
			{
				this.Members.Add(ind, v);
			}
		}

		public override string StringValue()
		{
			return this.ToPrimitive(true).StringValue();
		}

		public override JSObject ToJSObject()
		{
			return this;
		}

		public override JSValue ToPrimitive(bool AsString)
		{
			JSFunctionBase fnc;
			JSValue v;
			if (AsString)
			{
				fnc = this["toString"] as JSFunctionBase;
				if (fnc != null)
				{
					v = fnc.Call(JSContext.CurrentContext, this, new JSArgs(fnc, new JSValue[0]));
					if (v is JSPrimitive)
					{
						return v;
					}
				}
				fnc = this["valueOf"] as JSFunctionBase;
				if (fnc != null)
				{
					v = fnc.Call(JSContext.CurrentContext, this, new JSArgs(fnc, new JSValue[0]));
					if (v is JSPrimitive)
					{
						return v;
					}
				}
			}
			else
			{
				fnc = this["valueOf"] as JSFunctionBase;
				if (fnc != null)
				{
					v = fnc.Call(JSContext.CurrentContext, this, new JSArgs(fnc, new JSValue[0]));
					if (v is JSPrimitive)
					{
						return v;
					}
				}
				fnc = this["toString"] as JSFunctionBase;
				if (fnc != null)
				{
					v = fnc.Call(JSContext.CurrentContext, this, new JSArgs(fnc, new JSValue[0]));
					if (v is JSPrimitive)
					{
						return v;
					}
				}
			}
			throw new JSRuntimeException("TypeError", "cannot convert value to primitive");
		}

		internal bool TryGetPropertyValue(string Key, out JSValue prop)
		{
			PropWrapper r;
			if (this.Members.TryGetValue(Key, out r))
			{
				prop = r.Get(this);
				return true;
			}
			prop = JSUndefined.Instance;
			return false;
		}

		public override string ClassString
		{
			get
			{
				return "Object";
			}
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Object;
			}
		}

		public override bool IsExtensible
		{
			get
			{
				return this._extensible;
			}
			set
			{
				this._extensible = value;
			}
		}

		public override JSValue this[string ind]
		{
			get
			{
				return base[ind];
			}
			set
			{
				PropWrapper w;
				if (this.Members.TryGetValue(ind, out w))
				{
					w.Set(this, value);
				}
				else if (this.IsExtensible)
				{
					this.Members.Add(ind, new DataProperty(value));
				}
			}
		}

		internal virtual Dictionary<string, PropWrapper> Members
		{
			get
			{
				return this._members;
			}
		}

		public override JSType ObjectType
		{
			get
			{
				return JSType.Object;
			}
		}

		public override JSValue Prototype
		{
			get
			{
				return this._prototype;
			}
		}

		public override string TypeOf
		{
			get
			{
				return "object";
			}
		}
	}
}

