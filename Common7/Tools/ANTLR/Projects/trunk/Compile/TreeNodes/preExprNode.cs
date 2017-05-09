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
using System.Reflection.Emit;

internal abstract class preExprNode : ExpressionNode
{
	public preExprNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		LocalBuilder locVal;
		TermBuilderNode DestVar = base.Children[0] as TermBuilderNode;
		if (DestVar == null)
		{
			throw new JSRuntimeException("SyntaxError", string.Concat(new object[] { "line ", base.token.Line, ":", base.token.CharPositionInLine, " syntax error" }));
		}
		if (DestVar.HasBase)
		{
			LocalBuilder locBase = compileContext.gen.DeclareLocal(typeof(JSValue));
			locVal = compileContext.gen.DeclareLocal(typeof(JSValue));
			DestVar.GenBaseCode(compileContext);
			compileContext.gen.Emit(OpCodes.Stloc, locBase.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, locBase.LocalIndex);
			DestVar.GenFetchCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
			compileContext.gen.Emit(OpCodes.Ldc_R8, (double) 1.0);
			compileContext.gen.Emit(this._op);
			compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSNumber_ctor);
			compileContext.gen.Emit(OpCodes.Stloc, locVal.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, locBase.LocalIndex);
			DestVar.GenRefCode(compileContext);
			compileContext.gen.Emit(OpCodes.Ldloc, locVal.LocalIndex);
			DestVar.GenAssignCode(compileContext);
			compileContext.gen.Emit(OpCodes.Ldloc, locVal.LocalIndex);
		}
		else
		{
			locVal = compileContext.gen.DeclareLocal(typeof(JSValue));
			DestVar.GenFetchCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
			compileContext.gen.Emit(OpCodes.Ldc_R8, (double) 1.0);
			compileContext.gen.Emit(this._op);
			compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSNumber_ctor);
			compileContext.gen.Emit(OpCodes.Stloc, locVal.LocalIndex);
			DestVar.GenRefCode(compileContext);
			compileContext.gen.Emit(OpCodes.Ldloc, locVal.LocalIndex);
			DestVar.GenAssignCode(compileContext);
			compileContext.gen.Emit(OpCodes.Ldloc, locVal.LocalIndex);
		}
	}

	protected abstract OpCode _op { get; }

	public override JSType TreeType
	{
		get
		{
			return JSType.Number;
		}
	}
}

