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
using Antlr.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal class ForInStatement : StatementNode
{
	public ForInStatement(IToken o) : base(o)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		string varName;
		MethodInfo UndefInst = typeof(JSUndefined).GetMethod("get_Instance", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static, null, new Type[0], null);
		MethodInfo SetRet = typeof(JSContext).GetMethod("set_ReturnValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(JSValue) }, null);
		ConstructorInfo ObjCtor = typeof(JSObject).GetConstructor(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo EnumerateProps = typeof(JSValue).GetMethod("EnumeratePropNames", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo GetEnumerator = typeof(IEnumerable<>).MakeGenericType(new Type[] { typeof(string) }).GetMethod("GetEnumerator", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo get_Current = typeof(IEnumerator<>).MakeGenericType(new Type[] { typeof(string) }).GetMethod("get_Current", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo get_Item = typeof(JSValue).GetMethod("get_Item", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[] { typeof(string) }, null);
		MethodInfo MoveNext = typeof(IEnumerator).GetMethod("MoveNext", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo Dispose = typeof(IDisposable).GetMethod("Dispose", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		MethodInfo grv = typeof(JSContext).GetMethod("get_ReturnValue", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance, null, new Type[0], null);
		LocalBuilder lObj = compileContext.gen.DeclareLocal(typeof(JSValue));
		LocalBuilder lItem = compileContext.gen.DeclareLocal(typeof(string));
		LocalBuilder enumerator = compileContext.gen.DeclareLocal(typeof(IEnumerator<>).MakeGenericType(new Type[] { typeof(string) }));
		base.continuedest = compileContext.gen.DefineLabel();
		Label lblIterate = compileContext.gen.DefineLabel();
		Label lblSkipDispose = compileContext.gen.DefineLabel();
		if (base.Children[0] is VarDeclStatement)
		{
			varName = ((VarDeclStatement) base.Children[0]).varNames[0];
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldstr, varName);
			compileContext.gen.EmitCallV( CompileContext.mi_CreateMutableBinding);
		}
		((ExpressionNode) base.Children[1]).GenCode(compileContext);
		compileContext.gen.Emit(OpCodes.Stloc, lObj.LocalIndex);
		compileContext.gen.Emit(OpCodes.Ldloc, lObj.LocalIndex);
		compileContext.gen.EmitCallV( EnumerateProps);
		compileContext.gen.EmitCallV( GetEnumerator);
		compileContext.gen.Emit(OpCodes.Stloc, enumerator.LocalIndex);
		compileContext.gen.BeginExceptionBlock();
		base.TryCatchLevels++;
		compileContext.gen.Emit(OpCodes.Br, base.continuedest);
		compileContext.gen.MarkLabel(lblIterate);
		compileContext.gen.Emit(OpCodes.Ldloc, enumerator.LocalIndex);
		compileContext.gen.EmitCallV( get_Current);
		compileContext.gen.Emit(OpCodes.Stloc, lItem.LocalIndex);
		if (base.Children[0] is TermBuilderNode)
		{
			TermBuilderNode DestVar = (TermBuilderNode) base.Children[0];
			DestVar.GenBaseCode(compileContext);
			DestVar.GenRefCode(compileContext);
			compileContext.gen.Emit(OpCodes.Ldloc, lItem.LocalIndex);
			compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
			DestVar.GenAssignCode(compileContext);
		}
		else if (base.Children[0] is VarDeclStatement)
		{
			varName = ((VarDeclStatement) base.Children[0]).varNames[0];
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldstr, varName);
			compileContext.gen.Emit(OpCodes.Ldloc, lItem.LocalIndex);
			compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
			compileContext.gen.EmitCallV( CompileContext.mi_SetMutableBinding);
		}
		((StatementNode) base.Children[2]).GenCode(compileContext);
		compileContext.gen.MarkLabel(base.continuedest);
		compileContext.gen.Emit(OpCodes.Ldloc, enumerator.LocalIndex);
		compileContext.gen.EmitCallV( MoveNext);
		compileContext.gen.Emit(OpCodes.Brtrue, lblIterate);
		compileContext.gen.Emit(OpCodes.Leave, base.breakdest);
		base.TryCatchLevels--;
		compileContext.gen.BeginFinallyBlock();
		compileContext.gen.Emit(OpCodes.Ldloc, enumerator.LocalIndex);
		compileContext.gen.Emit(OpCodes.Ldnull);
		compileContext.gen.Emit(OpCodes.Ceq);
		compileContext.gen.Emit(OpCodes.Brtrue, lblSkipDispose);
		compileContext.gen.Emit(OpCodes.Ldloc, enumerator.LocalIndex);
		compileContext.gen.EmitCallV( Dispose);
		compileContext.gen.MarkLabel(lblSkipDispose);
		compileContext.gen.Emit(OpCodes.Endfinally);
		compileContext.gen.EndExceptionBlock();
	}

	internal override bool AllowContinue
	{
		get
		{
			return true;
		}
	}

	internal override bool AllowUnlabledBreak
	{
		get
		{
			return true;
		}
	}
}

