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
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Zinj
{
	internal class ASMCompileContext : CompileContext
	{
		private AssemblyBuilder ab;
		private ConstructorBuilder ctor1;
		private FieldBuilder fncListField;
		private List<_FncInfo> FunctionList;
		private MethodBuilder GlobalMethod;
		private ModuleBuilder mb;
		private TypeBuilder tb;

		public ASMCompileContext() : base(null)
		{
			this.FunctionList = new List<_FncInfo>();
			AssemblyName aName = new AssemblyName("DynamicAssemblyExample");
			this.ab = AppDomain.CurrentDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.RunAndSave);
			this.mb = this.ab.DefineDynamicModule(aName.Name, aName.Name + ".dll");
			this.tb = this.mb.DefineType("MyDynamicType", TypeAttributes.Public, typeof(JSGlobalContext));
			this.fncListField = this.tb.DefineField("fnclist", typeof(JSDebugFunctionDef[]), FieldAttributes.Static | FieldAttributes.Private);
			this.ctor1 = this.tb.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, Type.EmptyTypes);
			ILGenerator ctor1IL = this.ctor1.GetILGenerator();
			ctor1IL.Emit(OpCodes.Ldarg_0);
			ctor1IL.Emit(OpCodes.Call, typeof(object).GetConstructor(Type.EmptyTypes));
			ctor1IL.Emit(OpCodes.Ret);
			this.GlobalMethod = this.tb.DefineMethod("GlobalCode", MethodAttributes.Static | MethodAttributes.Public, typeof(JSValue), new Type[] { typeof(JSContext) });
			this.GlobalMethod.DefineParameter(1, ParameterAttributes.None, "context");
			base.fncData = new CompileContext.LocalFunctionData(this.GlobalMethod.GetILGenerator());
		}

		internal AssemblyBuilder GenerateAB(StatementNode r)
		{
			base.GenerateGlobalCode(r);
			MethodInfo mi_PushContext = typeof(JSContext).GetMethod("PushContext", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[] { typeof(JSContext) }, null);
			MethodInfo mi_PopContext = typeof(JSContext).GetMethod("PopContext", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[0], null);
			ILGenerator gen = this.tb.DefineMethod("__Run", MethodAttributes.Public, typeof(JSValue), Type.EmptyTypes).GetILGenerator();
			LocalBuilder l_ctx = gen.DeclareLocal(typeof(JSContext));
			LocalBuilder value = gen.DeclareLocal(typeof(JSValue));
			Label label60 = gen.DefineLabel();
			gen.Emit(OpCodes.Newobj, this.ctor1);
			gen.Emit(OpCodes.Stloc, l_ctx.LocalIndex);
			gen.Emit(OpCodes.Ldloc, l_ctx.LocalIndex);
			gen.EmitCallV( mi_PushContext);
			gen.BeginExceptionBlock();
			gen.Emit(OpCodes.Ldloc, l_ctx.LocalIndex);
			gen.EmitCallV( this.GlobalMethod);
			gen.Emit(OpCodes.Stloc, value.LocalIndex);
			gen.Emit(OpCodes.Leave_S, label60);
			gen.BeginFinallyBlock();
			gen.EmitCallV( mi_PopContext);
			gen.Emit(OpCodes.Endfinally);
			gen.EndExceptionBlock();
			gen.MarkLabel(label60);
			gen.Emit(OpCodes.Ldloc, value.LocalIndex);
			gen.Emit(OpCodes.Ret);
			MethodBuilder method = this.tb.DefineMethod(".cctor", MethodAttributes.HideBySig | MethodAttributes.Static | MethodAttributes.Private);
			ConstructorInfo ctor2 = typeof(JSDebugFunctionDef).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
			FieldInfo param_names = typeof(JSDebugFunctionDef).GetField("param_names");
			ConstructorInfo ctor4 = typeof(Func<,>).MakeGenericType(new Type[] { typeof(JSContext), typeof(JSValue) }).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(object), typeof(IntPtr) }, null);
			MethodInfo set_del = typeof(JSDebugFunctionDef).GetMethod("set_del", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(Func<,>).MakeGenericType(new Type[] { typeof(JSContext), typeof(JSValue) }) }, null);
			method.SetReturnType(typeof(void));
			gen = method.GetILGenerator();
			LocalBuilder def = gen.DeclareLocal(typeof(JSDebugFunctionDef));
			LocalBuilder strarr = gen.DeclareLocal(typeof(string[]));
			LocalBuilder defArray = gen.DeclareLocal(typeof(JSDebugFunctionDef[]));
			gen.Emit(OpCodes.Nop);
			gen.Emit(OpCodes.Ldc_I4, this.FunctionList.Count);
			gen.Emit(OpCodes.Newarr, typeof(JSDebugFunctionDef));
			gen.Emit(OpCodes.Stloc, defArray.LocalIndex);
			for (int i = 0; i < this.FunctionList.Count; i++)
			{
				gen.Emit(OpCodes.Ldloc, defArray.LocalIndex);
				gen.Emit(OpCodes.Ldc_I4, i);
				gen.Emit(OpCodes.Newobj, ctor2);
				gen.Emit(OpCodes.Stloc, def.LocalIndex);
				gen.Emit(OpCodes.Ldloc, def.LocalIndex);
				string[] names = this.FunctionList[i].args;
				gen.Emit(OpCodes.Ldc_I4, names.Length);
				gen.Emit(OpCodes.Newarr, typeof(string));
				gen.Emit(OpCodes.Stloc, strarr.LocalIndex);
				for (int j = 0; j < names.Length; j++)
				{
					gen.Emit(OpCodes.Ldloc, strarr.LocalIndex);
					gen.Emit(OpCodes.Ldc_I4, j);
					gen.Emit(OpCodes.Ldstr, names[j]);
					gen.Emit(OpCodes.Stelem_Ref);
				}
				gen.Emit(OpCodes.Ldloc, strarr.LocalIndex);
				gen.Emit(OpCodes.Stfld, param_names);
				gen.Emit(OpCodes.Ldloc, def.LocalIndex);
				gen.Emit(OpCodes.Ldnull);
				gen.Emit(OpCodes.Ldftn, this.FunctionList[i].mb);
				gen.Emit(OpCodes.Newobj, ctor4);
				gen.EmitCallV( set_del);
				gen.Emit(OpCodes.Nop);
				gen.Emit(OpCodes.Ldloc, def.LocalIndex);
				gen.Emit(OpCodes.Stelem_Ref);
			}
			gen.Emit(OpCodes.Ldloc, defArray.LocalIndex);
			gen.Emit(OpCodes.Stsfld, this.fncListField);
			gen.Emit(OpCodes.Ret);
			method = this.tb.DefineMethod("GetFunctionReference", MethodAttributes.HideBySig | MethodAttributes.Virtual | MethodAttributes.Public);
			ConstructorInfo ctor3 = typeof(JSDebugFunction).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSDebugFunctionDef), typeof(JSEnvRec) }, null);
			method.SetReturnType(typeof(JSValue));
			method.SetParameters(new Type[] { typeof(int), typeof(JSEnvRec) });
			method.DefineParameter(1, ParameterAttributes.None, "key");
			method.DefineParameter(2, ParameterAttributes.None, "r");
			gen = method.GetILGenerator();
			LocalBuilder value2 = gen.DeclareLocal(typeof(JSValue));
			Label label17 = gen.DefineLabel();
			gen.Emit(OpCodes.Nop);
			gen.Emit(OpCodes.Ldsfld, this.fncListField);
			gen.Emit(OpCodes.Ldarg_1);
			gen.Emit(OpCodes.Ldelem_Ref);
			gen.Emit(OpCodes.Ldarg_2);
			gen.Emit(OpCodes.Newobj, ctor3);
			gen.Emit(OpCodes.Stloc_0);
			gen.Emit(OpCodes.Br_S, label17);
			gen.MarkLabel(label17);
			gen.Emit(OpCodes.Ldloc_0);
			gen.Emit(OpCodes.Ret);
			Type t = this.tb.CreateType();
			return this.ab;
		}

		public override int GenerateFunction(functionExpressionNode node, string name, StatementNode r, out FunctionDelegate _delegate)
		{
			int n = this.FunctionList.Count;
			MethodBuilder method = this.tb.DefineMethod(name + "_" + n, MethodAttributes.Static | MethodAttributes.Public, typeof(JSValue), new Type[] { typeof(JSContext) });
			method.DefineParameter(1, ParameterAttributes.None, "context");
			base.GenerateFunctionBody(r, method.GetILGenerator());
			this.FunctionList.Add(new _FncInfo() { args=node.ParameterList.Names, mb = method});
			_delegate = null;
			return n;
		}

		private class _FncInfo
		{
			public string[] args;
			public MethodBuilder mb;
		}
	}
}

