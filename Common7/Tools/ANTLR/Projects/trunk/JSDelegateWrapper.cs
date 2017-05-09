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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Zinj
{
	public class JSDelegateWrapper : JSFunctionBase
	{
		public DeligateType _delegate;
		private static JSValue _undef_ref = JSUndefined.Instance;
		private static FieldInfo fi_undef_ref = typeof(JSDelegateWrapper).GetField("_undef_ref", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
		private static FieldInfo fi_wrapped = typeof(JSDelegateWrapper).GetField("_wrapped", BindingFlags.NonPublic | BindingFlags.Instance);
		private static MethodInfo mi_get_Item = typeof(JSArgs).GetMethod("get_Item", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(int) }, null);
		private static MethodInfo mi_get_StringValue = typeof(JSValue).GetMethod("get_StringValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		private static MethodInfo mi_get_Wrapped = typeof(JSExternWrapper).GetMethod("get_Wrapped", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		private ParameterList paramlist;

		public JSDelegateWrapper(DeligateType Delegate) : this(Delegate, 0)
		{
		}

		public JSDelegateWrapper(MethodInfo mi)
		{
			this.paramlist = new ParameterList();
			DynamicMethod method = new DynamicMethod("TestMethod", typeof(JSValue), new Type[] { typeof(JSContext), typeof(JSValue), typeof(JSArgs), typeof(bool) }, typeof(JSDelegateWrapper), true);
			ILGenerator gen = method.GetILGenerator();
			gen.Emit(OpCodes.Ldarg_1);
			gen.Emit(OpCodes.Castclass, typeof(JSExternWrapper));
			gen.EmitCallV( mi_get_Wrapped);
			gen.Emit(OpCodes.Castclass, mi.DeclaringType);
			int i = 0;
			foreach (ParameterInfo p in mi.GetParameters())
			{
				gen.Emit(OpCodes.Ldarg_2);
				gen.Emit(OpCodes.Ldc_I4, i);
				gen.EmitCallV( mi_get_Item);
				if (p.ParameterType == typeof(JSValue)) { /* do nothing */ }
				else if (p.ParameterType == typeof(string))
				{
					gen.EmitCallV( CompileContext.mi_JSValue_StringValue);
				}
				else if (p.ParameterType == typeof(double))
				{
					gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
				}
				else if (p.ParameterType == typeof(float))
				{
					gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
					gen.Emit(OpCodes.Conv_R4);
				}
				else if (p.ParameterType == typeof(int))
				{
					gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
					gen.Emit(OpCodes.Conv_I4);
				}
				else if (p.ParameterType == typeof(bool))
					gen.EmitCallV( CompileContext.mi_JSValue_BoolValue);
				else
					throw new Exception();
				gen.EmitCallV( mi);
				i++;
			}
			gen.Emit(OpCodes.Ldsfld, fi_undef_ref);
			gen.Emit(OpCodes.Ret);
			this._delegate = (DeligateType) method.CreateDelegate(typeof(DeligateType));
		}

		public JSDelegateWrapper(DeligateType Delegate, int length)
		{
			this._delegate = Delegate;
			base.SetDataProp("length", (double) length, false, false, false);
		}

		public override JSValue Call(JSContext Scope, JSValue ThisObj, JSArgs Args)
		{
			if (ThisObj.CheckCoercible())
			{
				ThisObj = ThisObj.ToJSObject();
			}
			else
			{
				ThisObj = JSContext.CurrentGlobalContext.Global;
			}
			return this._delegate(Scope, ThisObj, Args, false);
		}

		public override JSValue Construct(JSContext Scope, JSArgs Args)
		{
			return this._delegate(Scope, this, Args, true);
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Function;
			}
		}

		public string Name { get; private set; }

		public override JSType ObjectType
		{
			get
			{
				return JSType.Function;
			}
		}

		public override JSValue Prototype
		{
			get
			{
				return JSContext.CurrentGlobalContext.FunctionPrototype;
			}
		}

		public delegate JSValue DeligateType(JSContext Scope, JSValue ThisObj, JSArgs args, bool AsConstructor);
	}
}

