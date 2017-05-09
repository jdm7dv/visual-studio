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

internal class functionDeclarationNode : StatementNode
{
	public functionDeclarationNode(int x, IToken f) : base(f)
	{
	}

	internal void GenCreate(CompileContext compileContext)
	{
		throw new NotImplementedException();
	}

	private void GenStatementCode(CompileContext compileContext)
	{
		functionExpressionNode fnc = (functionExpressionNode) base.Children[0];
		string fncName = fnc.Name;
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		compileContext.gen.Emit(OpCodes.Ldstr, fncName);
		compileContext.gen.EmitCallV( CompileContext.mi_CreateMutableBinding);
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		compileContext.gen.Emit(OpCodes.Ldstr, fncName);
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		fnc.GenFunctionRef(compileContext);
		compileContext.gen.EmitCallV( CompileContext.mi_GetFunctionReference);
		compileContext.gen.EmitCallV( CompileContext.mi_SetVarBinding);
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		if (bGenDebug)
		{
			base.GenDebugWrap(compileContext, new Action<CompileContext>(this.GenStatementCode));
		}
		else
		{
			this.GenStatementCode(compileContext);
		}
	}
}

