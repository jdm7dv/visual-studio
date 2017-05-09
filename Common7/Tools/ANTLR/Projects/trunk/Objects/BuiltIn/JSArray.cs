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
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

namespace Zinj
{
	public partial class JSGlobalContext : JSContext
	{
		internal JSDelegateWrapper ArrayCtor;
		internal JSObject ArrayPrototype;

		private void AddArray()
		{
			this.ArrayCtor = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs Args, bool AsConstructor)
			{
				if ((Args.Count == 1) && (Args[0] is JSNumber))
				{
					double n = Args[0].NumberValue();
					uint i = n.JSToUInt32();
					if (n != i)
					{
						throw new JSRuntimeException("RangeError", "invalid array length");
					}
					return new JSArray(i);
				}
				return new JSArray(Args.ArgValues);
			}, 1);
			this.ArrayPrototype = new JSArray(this.ObjectPrototype, this.ArrayCtor);
			this.ArrayCtor.SetDataProp("prototype", this.ArrayPrototype, false, false, false);
		}

		private void AddArrayProperties()
		{
			this.Global.SetDataProp("Array", this.ArrayCtor, false, false, false);
			this.ArrayPrototype.SetDataProp("length", 0.0, true, false, true);
			this.ArrayCtor.SetDataProp("isArray", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return args[0] is JSArray;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("toString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor) throw new JSRuntimeException("TypeError", "Array.toString cannot be used as a constructor");
				JSObject array = ThisObj.ToJSObject();
				JSFunctionBase fnc = ThisObj["join"] as JSFunctionBase;
				if (fnc != null)
				{
					return fnc.Call(Scope, ThisObj, new JSArgs(fnc, new JSValue[0]));
				}
				return "[object " + ThisObj.ClassString + "]";
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("toLocaleString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				JSObject elementObj;
				JSFunctionBase func;
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.toLocaleString called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (len == 0)
				{
					return string.Empty;
				}
				JSValue firstElement = O["0"];
				StringBuilder R = new StringBuilder();
				if (firstElement.CheckCoercible())
				{
					elementObj = firstElement.ToJSObject();
					func = InternalUtilities.JSFunctionCast(elementObj["toLocaleString"]);
					R.Append(func.Call(Scope, elementObj, new JSArgs(func, new JSValue[0])).StringValue());
				}
				for (uint k = 1; k < len; k++)
				{
					R.Append(",");
					JSValue nextElement = O[k.ToString()];
					if (nextElement.CheckCoercible())
					{
						elementObj = nextElement.ToJSObject();
						func = InternalUtilities.JSFunctionCast(elementObj["toLocaleString"]);
						R.Append(func.Call(Scope, elementObj, new JSArgs(func, new JSValue[0])).StringValue());
					}
				}
				return R.ToString();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("concat", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.concat called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				JSArray A = new JSArray(new JSValue[0]);
				int n = 0;
				_concat_append(A, ref n, O);
				foreach (JSValue E in args.ArgValues)
				{
					_concat_append(A, ref n, E);
				}
				return A;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("join", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				string sep;
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.join called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (args[0] is JSUndefined)
				{
					sep = ",";
				}
				else
				{
					sep = args[0].StringValue();
				}
				if (len == 0)
				{
					return string.Empty;
				}
				JSValue element0 = O["0"];
				StringBuilder R = new StringBuilder();
				if (element0.CheckCoercible())
				{
					R.Append(element0.StringValue());
				}
				for (int k = 1; k < len; k++)
				{
					R.Append(sep);
					JSValue element = O[k.ToString()];
					if (element.CheckCoercible())
					{
						R.Append(element.StringValue());
					}
				}
				return R.ToString();
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("pop", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.pop called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (len == 0)
				{
					O["length"] = 0.0;
					return JSUndefined.Instance;
				}
				string indx = (len - 1).ToString();
				JSValue element = O[indx];
				O.DeleteProperty(indx, true);
				O["length"] = (JSValue)(len - 1);
				return element;
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("push", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.push called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				double n = O["length"].NumberValue().JSToUInt32();
				foreach (JSValue E in args.ArgValues)
				{
					O[n.ToString()] = E;
					n++;
				}
				O["length"] = n;
				return n;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("reverse", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.reverse called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				uint middle = len / 2;
				for (uint lower = 0; lower != middle; lower++)
				{
					string upperP = ((len - lower) - 1).ToString();
					string lowerP = lower.ToString();
					JSValue lowerValue = O[lowerP];
					JSValue upperValue = O[upperP];
					bool lowerExists = O.HasProperty(lowerP);
					bool upperExists = O.HasProperty(upperP);
					if (lowerExists && upperExists)
					{
						O[lowerP] = upperValue;
						O[upperP] = lowerValue;
					}
					else if (!(lowerExists || !upperExists))
					{
						O[lowerP] = upperValue;
						O.DeleteProperty(upperP, true);
					}
					else if (!(!lowerExists || upperExists))
					{
						O.DeleteProperty(lowerP, true);
						O[upperP] = lowerValue;
					}
				}
				return O;
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("shift", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.shift called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				double len = O["length"].NumberValue().JSToUInt32();
				if (len == 0.0)
				{
					O["length"] = 0.0;
					return JSUndefined.Instance;
				}
				JSValue first = O["0"];
				for (int k = 1; k < len; k++)
				{
					string from = k.ToString();
					string to = (k - 1).ToString();
					if (O.HasProperty(from))
					{
						JSValue fromVal = O[from];
						O[to] = fromVal;
					}
					else
					{
						O.DeleteProperty(to, true);
					}
				}
				O.DeleteProperty((len - 1.0).ToString(), true);
				O["length"] = len - 1.0;
				return first;
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("slice", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double k;
				double relativeEnd;
				double final;
	
				if (AsConstructor) throw new JSRuntimeException("TypeError", "Array.slice called as constructor");

				JSObject O = ThisObj.ToJSObject();
				JSArray A = new JSArray(new JSValue[0]);
				uint len = O["length"].NumberValue().JSToUInt32();
				double relativeStart = args[0].NumberValue().JSToInteger();
				
				if (relativeStart < 0.0)
					k = Math.Max((double)(len + relativeStart), (double)0.0);
				else
					k = Math.Min(relativeStart, (double)len);
				
				if (args[1] is JSUndefined)
					relativeEnd = len;
				else
					relativeEnd = args[1].NumberValue().JSToInteger();
				
				if (relativeEnd < 0.0)
					final = Math.Max((double)(len + relativeEnd), (double)0.0);
				else
					final = Math.Min(relativeEnd, (double)len);
				
				uint ik = (uint)k;
				uint ifinal = (uint)final;
				for (int n = 0; ik < ifinal; n++)
				{
					string Pk = ik.ToString();
					if (O.HasProperty(Pk))
					{
						JSValue kValue = O[Pk];
						A[n.ToString()] = kValue;
					}
					ik++;
				}
				return A;
			}, 2), true, false, true);
			this.ArrayPrototype.SetDataProp("sort", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.sort called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (len != 0)
				{
					int i;
					IEnumerable<JSValue> a2;
					int nUnset = 0;
					int nUndef = 0;
					List<JSValue> a1 = new List<JSValue>();
					for (i = 0; i < len; i++)
					{
						JSValue v;
						if (!O.TryGetPropertyValue(i.ToString(), out v))
						{
							nUnset++;
						}
						else if (v is JSUndefined)
						{
							nUndef++;
						}
						else
						{
							a1.Add(v);
						}
					}
					if (args[0] is JSUndefined)
					{
						a2 = a1.OrderBy<JSValue, string>(x => x.StringValue(), StringComparer.Ordinal);
					}
					else
					{
						_sortHelper h = new _sortHelper(InternalUtilities.JSFunctionCast(args[0]), Scope);
						a2 = a1.OrderBy<JSValue, JSValue>(x => x, h);
					}
					i = 0;
					foreach (JSValue v in a2)
					{
						O[i.ToString()] = v;
						i++;
					}
					while (nUndef-- != 0)
					{
						O[i.ToString()] = JSUndefined.Instance;
						i++;
					}
					while (nUnset-- != 0)
					{
						string s = i.ToString();
						if (O.HasOwnProperty(s))
						{
							O.DeleteProperty(s, false);
						}
						i++;
					}
				}
				return O;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("splice", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				double actualStart;
				uint k;
				string from;
				JSValue fromValue;
				JSValue[] items;
				string to;
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.splice called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				JSArray A = new JSArray(new JSValue[0]);
				uint len = O["length"].NumberValue().JSToUInt32();
				double relativeStart = args[0].NumberValue().JSToInteger();
				if (relativeStart < 0.0)
				{
					actualStart = Math.Max((double)(len + relativeStart), (double)0.0);
				}
				else
				{
					actualStart = Math.Min(relativeStart, (double)len);
				}
				double actualDeleteCount = Math.Min(Math.Max(args[1].NumberValue().JSToInteger(), 0.0), len - actualStart);
				uint iactualStart = (uint)actualStart;
				uint iactualDeleteCount = (uint)actualDeleteCount;
				for (k = 0; k < iactualDeleteCount; k++)
				{
					from = (iactualStart + k).ToString();
					if (O.HasProperty(from))
					{
						fromValue = O[from];
						A[k.ToString()] = fromValue;
					}
				}
				if (args.Count <= 2)
				{
					items = new JSValue[0];
				}
				else
				{
					items = args.ArgValues.Skip<JSValue>(2).ToArray<JSValue>();
				}
				int itemCount = items.Length;
				if (itemCount < iactualDeleteCount)
				{
					for (k = iactualStart; k < (len - iactualDeleteCount); k++)
					{
						from = (k + iactualDeleteCount).ToString();
						to = (k + itemCount).ToString();
						if (O.HasProperty(from))
						{
							fromValue = O[from];
							O[to] = fromValue;
						}
						else
						{
							O.DeleteProperty(to, true);
						}
					}
					for (k = len; k > ((len - iactualDeleteCount) + itemCount); k--)
					{
						O.DeleteProperty((k - 1).ToString(), true);
					}
				}
				else if (itemCount > iactualDeleteCount)
				{
					for (k = len - iactualDeleteCount; k > iactualStart; k--)
					{
						from = ((k + iactualDeleteCount) - 1).ToString();
						to = ((k + itemCount) - 1L).ToString();
						if (O.HasProperty(from))
						{
							fromValue = O[from];
							O[to] = fromValue;
						}
						else
						{
							O.DeleteProperty(to, true);
						}
					}
				}
				k = iactualStart;
				foreach (JSValue E in items)
				{
					O[k.ToString()] = E;
					k++;
				}
				O["length"] = (JSValue)((len - iactualDeleteCount) + itemCount);
				return A;
			}, 2), true, false, true);
			this.ArrayPrototype.SetDataProp("unshift", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.unshift called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				double len = O["length"].NumberValue().JSToUInt32();
				for (double k = len; k > 0.0; k--)
				{
					string from = (k - 1.0).ToString();
					string to = ((k + args.Count) - 1.0).ToString();
					if (O.HasProperty(from))
					{
						JSValue fromValue = O[from];
						O[to] = fromValue;
					}
					else
					{
						O.DeleteProperty(to, true);
					}
				}
				int j = 0;
				foreach (JSValue E in args.ArgValues)
				{
					O[j.ToString()] = E;
					j++;
				}
				O["length"] = len + args.Count;
				return len + args.Count;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("indexOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.indexOf called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (len != 0)
				{
					double n;
					uint k;
					if (args.Count >= 2)
					{
						n = args[1].NumberValue();
					}
					else
					{
						n = 0.0;
					}
					if (n >= len)
					{
						return -1.0;
					}
					if (n >= 0.0)
					{
						k = (uint)n;
					}
					else
					{
						k = len - ((uint)-n);
						if (k < 0)
						{
							k = 0;
						}
					}
					while (k < len)
					{
						if (O.HasProperty(k.ToString()))
						{
							JSValue elementK = O[k.ToString()];
							if (JSValue.JSEqualsExact(args[0], elementK))
							{
								return (double)k;
							}
						}
						k++;
					}
				}
				return -1.0;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("lastIndexOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (AsConstructor)
				{
					throw new JSRuntimeException("TypeError", "Array.lastIndexOf called as constructor");
				}
				JSObject O = ThisObj.ToJSObject();
				uint len = O["length"].NumberValue().JSToUInt32();
				if (len != 0)
				{
					double n;
					uint k;
					if (args.Count >= 2)
					{
						n = args[1].NumberValue();
					}
					else
					{
						n = len;
					}
					if (n >= 0.0)
					{
						k = Math.Min((uint)n, len - 1);
					}
					else
					{
						k = len - ((uint)-n);
					}
					while (k >= 0)
					{
						if (O.HasProperty(k.ToString()))
						{
							JSValue elementK = O[k.ToString()];
							if (JSValue.JSEqualsExact(args[0], elementK))
							{
								return (double)k;
							}
						}
						k--;
					}
				}
				return -1.0;
			}, 1), true, false, true);
			this.ArrayPrototype.SetDataProp("every", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("some", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("forEach", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("map", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("filter", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("reduce", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
			this.ArrayPrototype.SetDataProp("reduceRight", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				throw new Exception();
			}), true, false, true);
		}
	}

	public class JSArray : JSObject
	{
		internal uint _length;

		public JSArray(uint initialLength) : this(JSContext.CurrentGlobalContext.ArrayPrototype, JSContext.CurrentGlobalContext.ArrayCtor)
		{
			this._length = initialLength;
		}

		public JSArray(params JSValue[] Args) : this(JSContext.CurrentGlobalContext.ArrayPrototype, JSContext.CurrentGlobalContext.ArrayCtor)
		{
			for (int i = 0; i < Args.Length; i++)
			{
				this[i.ToString()] = Args[i];
			}
			this._length = (uint) Args.Length;
		}

		public JSArray(JSValue Prototype, JSValue Constructor) : base(Prototype, Constructor)
		{
			base.SetProp("length", new JSDelegateProperty(delegate (JSValue ThisObj) {
				return (double) ((JSArray) ThisObj)._length;
			}, delegate (JSValue ThisObj, JSValue val) {
				double n = val.NumberValue();
				uint i = n.JSToUInt32();
				if (n != i)
				{
					throw new JSRuntimeException("RangeError", "invalid array length");
				}
				JSArray ar = ThisObj as JSArray;
				UpdateLen(i, ar);
			}, true, false, false));
		}

		private static bool _intCheck(string s)
		{
			for (int i = s.Length - 1; i >= 0; i--)
			{
				if ((s[i] < '0') || (s[i] > '9'))
				{
					return false;
				}
			}
			return true;
		}

		private static void UpdateLen(uint i, JSArray ar)
		{
			uint ol = ar._length;
			if ((ol != 0) && (ol > i))
			{
				if ((ol - i) <= ar.Members.Count)
				{
					while (ol-- > i)
					{
						string s = ol.ToString();
						if (ar.HasOwnProperty(s))
						{
							ar.DeleteProperty(s, false);
						}
					}
				}
				else
				{
					foreach (string v in ar.EnumeratePropNames().Where<string>(delegate (string x) {
						return _intCheck(x);
					}))
					{
						uint ix;
						if ((uint.TryParse(v, NumberStyles.None, null, out ix) && (ix >= i)) && (ix < ol))
						{
							ar.DeleteProperty(v, false);
						}
					}
				}
			}
			ar._length = i;
		}

		public override string ClassString
		{
			get
			{
				return "Array";
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
				uint i;
				base[ind] = value;
				if ((uint.TryParse(ind, NumberStyles.None, null, out i) && (i != uint.MaxValue)) && (i >= this._length))
				{
					try
					{
						this._length = i + 1;
					}
					catch (OverflowException)
					{
						throw new JSRuntimeException("RangeError", "Array.length UInt32 overflow");
					}
				}
			}
		}

		public override JSType ObjectType
		{
			get
			{
				return JSType.Array;
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

