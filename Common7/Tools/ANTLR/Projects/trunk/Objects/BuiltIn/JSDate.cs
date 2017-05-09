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
	public partial class JSGlobalContext : JSContext
	{
		internal JSDelegateWrapper DateCtor;
		internal JSObject DatePrototype;

		private void AddDate()
		{
			this.DateCtor = new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!AsConstructor)
				{
					return DateTime.UtcNow.ToString("F");
				}
				return new JSDate(this.DatePrototype, this.DateCtor, args);
			});
			this.DatePrototype = new JSObject(this.ObjectPrototype, this.DateCtor);
			this.DateCtor.SetDataProp("prototype", this.DatePrototype, false, false, false);
		}

		private void AddDateProperties()
		{
			this.Global.SetDataProp("Date", this.DateCtor, false, false, false);
			this.DateCtor.SetDataProp("parse", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return new JSDate(DateTime.Parse(args[0].StringValue()));
			}), true, false, true);
			this.DateCtor.SetDataProp("UTC", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return new JSDate(JSDate.UTC(args));
			}), true, false, true);
			this.DateCtor.SetDataProp("now", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				return new JSDate(DateTime.UtcNow);
			}), true, false, true);
			this.DatePrototype.SetDataProp("toString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("F");
			}), true, false, true);
			this.DatePrototype.SetDataProp("toDateString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toDateString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("D");
			}), true, false, true);
			this.DatePrototype.SetDataProp("toTimeString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toTimeString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("T");
			}), true, false, true);
			this.DatePrototype.SetDataProp("toLocaleString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toLocaleString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("F") + " GMT" + v.ToString("zzz") + " (" + (TimeZone.CurrentTimeZone.IsDaylightSavingTime(v) ? TimeZone.CurrentTimeZone.DaylightName : TimeZone.CurrentTimeZone.StandardName) + ")";
			}), true, false, true);
			this.DatePrototype.SetDataProp("toLocaleDateString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toLocaleDateString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("D");
			}), true, false, true);
			this.DatePrototype.SetDataProp("toLocaleTimeString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toLocaleTimeString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToLocalTime().ToString("T") + " GMT" + v.ToString("zzz") + " (" + (TimeZone.CurrentTimeZone.IsDaylightSavingTime(v) ? TimeZone.CurrentTimeZone.DaylightName : TimeZone.CurrentTimeZone.StandardName) + ")";
			}), true, false, true);
			this.DatePrototype.SetDataProp("valueOf", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.valueOf called on non-date type");
				}
				return ((JSDate)ThisObj).ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("getTime", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getTime called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return ((double)(v.Ticks - 0x89f7ff5f7b58000L)) / 10000.0;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getFullYear", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getFullYear called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Year;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCFullYear", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCFullYear called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Year;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getMonth", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getMonth called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)(v.ToLocalTime().Month - 1);
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCMonth", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCMonth called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)(v.Month - 1);
			}), true, false, true);
			this.DatePrototype.SetDataProp("getDate", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getDate called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Day;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCDate", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCDate called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Day;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getDay", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getDay called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (double)v.ToLocalTime().DayOfWeek;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCDay", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCDay called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (double)v.DayOfWeek;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getHours", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getHours called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Hour;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCHours", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCHours called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Hour;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getMinutes", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getMinutes called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Minute;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCMinutes", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCMinutes called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Minute;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getSeconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getSeconds called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Second;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCSeconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCSeconds called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Second;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getMilliseconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getMilliseconds called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.ToLocalTime().Millisecond;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getUTCMilliseconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getUTCMilliseconds called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)v.Millisecond;
			}), true, false, true);
			this.DatePrototype.SetDataProp("getTimezoneOffset", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.getTimezoneOffset called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return ((v - v.ToLocalTime())).TotalMinutes;
			}), true, false, true);
			this.DatePrototype.SetDataProp("setTime", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setTime called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double v = JSDate.TimeClip(args[0].NumberValue());
				d.CLRDate = JSDate.FromNumber(v);
				return v;
			}), true, false, true);
			this.DatePrototype.SetDataProp("setMilliseconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMilliseconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMilliseconds(ms - d.CLRDate.Millisecond);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCMilliseconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setUTCMilliseconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMilliseconds(ms - d.CLRDate.Millisecond);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setSeconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setSeconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromSeconds(ms - d.CLRDate.Second);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCSeconds", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setUTCSeconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromSeconds(ms - d.CLRDate.Second);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setMinutes", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMinutes called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMinutes(ms - d.CLRDate.Minute);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCMinutes", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setUTCMinutes called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMinutes(ms - d.CLRDate.Minute);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setHours", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setHours called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromHours(ms - d.CLRDate.Hour);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCHours", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setUTCHours called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromHours(ms - d.CLRDate.Hour);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setDate", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setDate called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromDays(ms - d.CLRDate.Day);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCDate", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setDate called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromDays(ms - d.CLRDate.Day);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setMonth", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMonths called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				DateTime x = new DateTime(d.CLRDate.Year, (int)ms, 0);
				x += TimeSpan.FromDays((double)d.CLRDate.Day);
				x += d.CLRDate.TimeOfDay;
				d.CLRDate = x;
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCMonth", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMilliseconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMilliseconds(ms - d.CLRDate.Millisecond);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setFullYear", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMilliseconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMilliseconds(ms - d.CLRDate.Millisecond);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("setUTCFullYear", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.setMilliseconds called on non-date type");
				}
				JSDate d = (JSDate)ThisObj;
				double ms = args[0].NumberValue().JSToInteger();
				d.CLRDate += TimeSpan.FromMilliseconds(ms - d.CLRDate.Millisecond);
				return d.ToDouble();
			}), true, false, true);
			this.DatePrototype.SetDataProp("toUTCString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toUTCString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToString("F") + " GMT";
			}), true, false, true);
			this.DatePrototype.SetDataProp("toISOString", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toISOString called on non-date type");
				}
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return "Invalid Date";
				}
				return v.ToString("yyyy-MM-ddTHH:mm:ss.FFFZ");
			}), true, false, true);
			this.DatePrototype.SetDataProp("toJSON", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				if (!(ThisObj is JSDate))
				{
					throw new JSRuntimeException("TypeError", "Date.toJSON called on non-date type");
				}
				JSObject O = ThisObj.ToJSObject();
				JSValue p = O.ToPrimitive(false);
				if (!(!(p is JSNumber) || p.NumberValue().IsFinite()))
				{
					return JSNull.Instance;
				}
				JSFunctionBase toISO = O["toISOString"] as JSFunctionBase;
				if (toISO == null)
				{
					throw new JSRuntimeException("TypeError", "Date.toJSON called on object without toISOString");
				}
				return toISO.Call(Scope, O, new JSArgs(toISO, new JSValue[0]));
			}), true, false, true);
			this.DatePrototype.SetDataProp("getYear", new JSDelegateWrapper(delegate(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor)
			{
				DateTime v = ((JSDate)ThisObj).CLRDate;
				if (v == DateTime.MinValue)
				{
					return JSNumber.NaN;
				}
				return (JSValue)(v.ToLocalTime().Year - 0x76c);
			}), true, false, true);
		}
	}

	public class JSDate : JSObject
	{
		public const long BASE_TIME_TICKS = 0x89f7ff5f7b58000L;
		internal static readonly double DoubleDateMax = ((DateTime.MaxValue.Ticks - 0x89f7ff5f7b58000L) / 0x2710L);
		internal static readonly double DoubleDateMin = ((DateTime.MinValue.Ticks - 0x89f7ff5f7b58000L) / 0x2710L);

		public JSDate(DateTime d) : base(JSContext.CurrentGlobalContext.DatePrototype, JSContext.CurrentGlobalContext.DateCtor)
		{
			this.CLRDate = d;
			if (this.CLRDate.Kind == DateTimeKind.Local)
			{
				this.CLRDate = this.CLRDate.ToUniversalTime();
			}
		}

		public JSDate(JSValue Prototype, JSValue Constructor, JSArgs args) : base(Prototype, Constructor)
		{
			if (args.Count == 0)
			{
				this.CLRDate = DateTime.Now;
			}
			else if (args.Count == 1)
			{
				JSValue v = args[0].ToPrimitive();
				if (v is JSString)
				{
					this.CLRDate = DateTime.Parse(v.StringValue());
				}
				else
				{
					this.CLRDate = FromNumber(TimeClip(v.NumberValue()));
				}
			}
			else
			{
				this.CLRDate = UTC(args);
			}
		}

		internal static DateTime FromNumber(double p)
		{
			if (double.IsNaN(p))
			{
				return DateTime.MinValue;
			}
			return (new DateTime(0x89f7ff5f7b58000L + ((long) (p * 10000.0)), DateTimeKind.Utc)).ToUniversalTime();
		}

		internal static double TimeClip(double p)
		{
			p = Math.Truncate(p);
			if (p < DoubleDateMin)
			{
				p = double.NaN;
			}
			if (p > DoubleDateMax)
			{
				p = double.NaN;
			}
			return p;
		}

		public double ToDouble()
		{
			if (this.CLRDate == DateTime.MinValue)
			{
				return double.NaN;
			}
			return (((double) (this.CLRDate.Ticks - 0x89f7ff5f7b58000L)) / 10000.0);
		}

		public override JSValue ToPrimitive()
		{
			return this.ToPrimitive(true);
		}

		internal static DateTime UTC(JSArgs args)
		{
			double y = args[0].NumberValue();
			double m = args[1].NumberValue();
			double date = (args.Count >= 3) ? args[2].NumberValue() : 1.0;
			double hours = (args.Count >= 4) ? args[2].NumberValue() : 0.0;
			double minutes = (args.Count >= 5) ? args[2].NumberValue() : 0.0;
			double seconds = (args.Count >= 6) ? args[2].NumberValue() : 0.0;
			double ms = (args.Count >= 7) ? args[2].NumberValue() : 0.0;
			if ((!double.IsNaN(y) && (y >= 0.0)) && (y <= 99.0))
			{
				y = 1900.0 + Math.Floor(y);
			}
			else
			{
				y = Math.Floor(y);
			}
			return (new DateTime((int) y, ((int) m) + 1, (int) date, (int) hours, (int) minutes, (int) seconds, (int) ms, DateTimeKind.Local)).ToUniversalTime();
		}

		public DateTime CLRDate { get; set; }
	}
}

