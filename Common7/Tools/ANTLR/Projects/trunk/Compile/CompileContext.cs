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
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zinj
{
	internal abstract class CompileContext
	{
		public Label BreakDest;
		public Label ContinueDest;
		public static MethodInfo fnc_Sys_String_Concat = typeof(string).GetMethod("Concat", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string), typeof(string) }, null);
		public static MethodInfo fnc_Sys_String_Equals = typeof(string).GetMethod("op_Equality", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(string), typeof(string) }, null);
		public static MethodInfo fnc_Utilities_DirectEvalCall = typeof(InternalUtilities).GetMethod("DirectEvalCall", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSFunctionBase), typeof(JSContext), typeof(JSValue), typeof(JSArgs) }, null);
		public static MethodInfo fnc_Utilities_JSFunctionCast = typeof(InternalUtilities).GetMethod("JSFunctionCast", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue) }, null);
		public static MethodInfo fnc_Utilities_JSToInt32 = typeof(Utilities).GetMethod("JSToInt32", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(double) }, null);
		public static MethodInfo fnc_Utilities_JSToUInt32 = typeof(Utilities).GetMethod("JSToUInt32", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(double) }, null);
		public static ConstructorInfo JSArgs_ctor = typeof(JSArgs).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue), typeof(JSValue[]) }, null);
		public static ConstructorInfo JSArray_ctor = typeof(JSArray).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue[]) }, null);
		public static ConstructorInfo JSNumber_ctor = typeof(JSNumber).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(double) }, null);
		public static ConstructorInfo JSObject_ctor = typeof(JSObject).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static ConstructorInfo JSObject_Prototyped_ctor = typeof(JSObject).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSObject) }, null);
		public static ConstructorInfo JSRuntimeException_ctor = typeof(JSRuntimeException).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue) }, null);
		public static ConstructorInfo JSString_ctor = typeof(JSString).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo mi_CreateMutableBinding = typeof(JSContext).GetMethod("CreateMutableBinding", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo mi_ExplicitThis = typeof(JSContext).GetProperty("ExplicitThis", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetGetMethod(true);
		public static MethodInfo mi_Get_Returnval = typeof(JSContext).GetProperty("ReturnValue", BindingFlags.Public | BindingFlags.Instance).GetGetMethod();
		public static MethodInfo mi_GetBindingValue = typeof(JSContext).GetMethod("GetBindingValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo mi_GetFunctionReference = typeof(JSContext).GetMethod("GetFunctionReference", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(int) }, null);
		public static MethodInfo mi_GetFunctionWithThis = typeof(JSContext).GetMethod("GetFunctionWithThis", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string), Type.GetType("Zinj.JSValue&") }, null);
		public static MethodInfo mi_HandleError = typeof(JSContext).GetMethod("HandleError", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(int), typeof(JSRuntimeException) }, null);
		public static MethodInfo mi_ImplicitThis = typeof(JSContext).GetProperty("ImplicitThis", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetGetMethod(true);
		public static MethodInfo mi_JSBase_DeleteProperty = typeof(JSBase).GetMethod("DeleteProperty", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string), typeof(bool) }, null);
		public static MethodInfo mi_JSBase_GetBindingType = typeof(JSBase).GetMethod("GetBindingType", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo mi_JSBool_False = typeof(JSBool).GetProperty("False", BindingFlags.Public | BindingFlags.Static).GetGetMethod();
		public static MethodInfo mi_JSBool_True = typeof(JSBool).GetProperty("True", BindingFlags.Public | BindingFlags.Static).GetGetMethod();
		public static MethodInfo mi_JSContext_Parent = typeof(JSContext).GetProperty("Parent", BindingFlags.Public | BindingFlags.Instance).GetGetMethod();
		public static MethodInfo mi_JSFunctionBase_Call = typeof(JSFunctionBase).GetMethod("Call", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSContext), typeof(JSValue), typeof(JSArgs) }, null);
		public static MethodInfo mi_JSFunctionBase_Construct = typeof(JSFunctionBase).GetMethod("Construct", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSContext), typeof(JSArgs) }, null);
		public static MethodInfo mi_JSFunctionBase_HasInstance = typeof(JSFunctionBase).GetMethod("HasInstance", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue) }, null);
		public static MethodInfo mi_JSNull_Instance = typeof(JSNull).GetProperty("Instance", BindingFlags.Public | BindingFlags.Static).GetGetMethod();
		public static MethodInfo mi_JSScope_CreateCatchScope = typeof(JSContext).GetMethod("CreateCatchScope", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSRuntimeException), typeof(string) }, null);
		public static MethodInfo mi_JSScope_CreateWithScope = typeof(JSContext).GetMethod("CreateWithScope", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue) }, null);
		public static MethodInfo mi_JSUndefined_Instance = typeof(JSUndefined).GetProperty("Instance", BindingFlags.Public | BindingFlags.Static).GetGetMethod();
		public static MethodInfo mi_JSValue_BoolValue = typeof(JSValue).GetMethod("BoolValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static MethodInfo mi_JSValue_HasProperty_in = typeof(JSValue).GetMethod("HasProperty_in", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo mi_JSValue_JSEquals = typeof(JSValue).GetMethod("JSEquals", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo mi_JSValue_JSEqualsExact = typeof(JSValue).GetMethod("JSEqualsExact", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo mi_JSValue_NumberValue = typeof(JSValue).GetMethod("NumberValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static MethodInfo mi_JSValue_StringValue = typeof(JSValue).GetMethod("StringValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static MethodInfo mi_JSValue_ToJSObject = typeof(JSValue).GetMethod("ToJSObject", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static MethodInfo mi_JSValue_ToPrimitive = typeof(JSValue).GetMethod("ToJSNumber", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, Type.EmptyTypes, null);
		public static MethodInfo mi_JSValue_TypeOf = typeof(JSValue).GetProperty("TypeOf", BindingFlags.Public | BindingFlags.Instance).GetGetMethod();
		public static MethodInfo mi_Set_Returnval = typeof(JSContext).GetProperty("ReturnValue", BindingFlags.Public | BindingFlags.Instance).GetSetMethod();
		public static MethodInfo mi_SetMutableBinding = typeof(JSContext).GetMethod("SetMutableBinding", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string), typeof(JSValue) }, null);
		public static MethodInfo mi_SetVarBinding = typeof(JSContext).GetMethod("SetVarBinding", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string), typeof(JSValue) }, null);
		public static MethodInfo op_JSBool_Implicit = typeof(JSBool).GetMethod("op_Implicit", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(bool) }, null);
		public static MethodInfo op_JSValue_Addition = typeof(JSValue).GetMethod("op_Addition", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_Division = typeof(JSValue).GetMethod("op_Division", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_GetItem = typeof(JSValue).GetMethod("get_Item", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		public static MethodInfo op_JSValue_GT = typeof(JSValue).GetMethod("op_GreaterThan", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_GTE = typeof(JSValue).GetMethod("op_GreaterThanOrEqual", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_LogAnd = typeof(JSValue).GetMethod("LogAnd", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_LogOr = typeof(JSValue).GetMethod("LogOr", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_LT = typeof(JSValue).GetMethod("op_LessThan", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_LTE = typeof(JSValue).GetMethod("op_LessThanOrEqual", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_Modulus = typeof(JSValue).GetMethod("op_Modulus", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_Multiply = typeof(JSValue).GetMethod("op_Multiply", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_SetItem = typeof(JSValue).GetMethod("set_Item", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string), typeof(JSValue) }, null);
		public static MethodInfo op_JSValue_Subtraction = typeof(JSValue).GetMethod("op_Subtraction", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSValue), typeof(JSValue) }, null);
		internal ScriptSource Source;
		public bool TrackImplicitReturnValue;

		protected CompileContext() : this(null)
		{
		}

		public CompileContext(ILGenerator gen)
		{
			this.TrackImplicitReturnValue = true;
			this.fncData = new LocalFunctionData(gen);
			this.DebugMode = JSContext.DebugOutput;
		}

		internal static string EscapeIdentifier(string s)
		{
			if (s.IndexOf('\\') == -1)
			{
				return s;
			}
			StringBuilder b = new StringBuilder();
			int l = s.Length;
			for (int i = 0; i < l; i++)
			{
				char c = s[i];
				if (c != '\\')
				{
					b.Append(c);
				}
				else
				{
					i++;
					if (s[i] != 'u')
					{
						throw new Exception();
					}
					b.Append((char) int.Parse(s.Substring(i + 1, 4), NumberStyles.AllowHexSpecifier));
					i += 4;
				}
			}
			return b.ToString();
		}

		private void GenerateCode(StatementNode r)
		{
			r.GenCode(this);
		}

		public abstract int GenerateFunction(functionExpressionNode node, string name, StatementNode r, out FunctionDelegate _delegate);
		protected void GenerateFunctionBody(StatementNode r, ILGenerator gen)
		{
			LocalFunctionData oldData = this.fncData;
			try
			{
				this.fncData = new LocalFunctionData(gen, gen.DefineLabel(), gen.DeclareLocal(typeof(JSValue)));
				r.GenCode(this);
				gen.EmitCallV(mi_JSUndefined_Instance);
				gen.Emit(OpCodes.Stloc, this.fncData.return_local);
				gen.MarkLabel(this.fncData.return_label);
				gen.Emit(OpCodes.Ldloc, this.fncData.return_local);
				gen.Emit(OpCodes.Ret);
			}
			finally
			{
				this.fncData = oldData;
			}
		}

		internal void GenerateGlobalCode(StatementNode r)
		{
			this.gen.Emit(OpCodes.Ldarg_0);
			this.gen.EmitCallV( mi_JSUndefined_Instance);
			this.gen.EmitCallV( mi_Set_Returnval);
			this.GenerateCode(r);
			this.gen.Emit(OpCodes.Ldarg_0);
			this.gen.EmitCallV( mi_Get_Returnval);
			this.gen.Emit(OpCodes.Ret);
		}

		internal void GenFunctionRef(int FunctionID)
		{
			this.gen.Emit(OpCodes.Ldc_I4, FunctionID);
		}

		public bool DebugMode { get; set; }

		public LocalFunctionData fncData { get; protected set; }

		public ILGenerator gen
		{
			get
			{
				return this.fncData.gen;
			}
		}

		public class LocalFunctionData
		{

			public LocalFunctionData(ILGenerator gen)
			{
				this.gen = gen;
			}

			public LocalFunctionData(ILGenerator gen, Label return_label, LocalBuilder return_local) : this(gen)
			{
				this.return_label = return_label;
				this.return_local = return_local;
			}

			public ILGenerator gen { get; private set; }

			public Label return_label { get; private set; }

			public LocalBuilder return_local { get; private set; }
		}
	}
}

