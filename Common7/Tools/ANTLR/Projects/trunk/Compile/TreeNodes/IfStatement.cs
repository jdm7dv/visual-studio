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

internal class IfStatement : StatementNode
{
	public IfStatement(IToken o) : base(o)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		Label lblFalse;
		bool HasElse = this.ChildCount == 3;
		Label lblTrue = compileContext.gen.DefineLabel();
		Label lblEnd = base.breakdest;
		if (HasElse)
		{
			lblFalse = compileContext.gen.DefineLabel();
		}
		else
		{
			lblFalse = lblEnd;
		}
		if (bGenDebug)
		{
			Label lblTrue2 = compileContext.gen.DefineLabel();
			Label lblFalse2 = compileContext.gen.DefineLabel();
			base.GenDebugWrap(compileContext, delegate (CompileContext x) {
				((ExpressionNode) this.Children[0]).GenLazyEval(compileContext, lblTrue2, lblFalse2);
			});
			compileContext.gen.MarkLabel(lblTrue2);
			compileContext.gen.Emit(OpCodes.Leave, lblTrue);
			compileContext.gen.MarkLabel(lblFalse2);
			compileContext.gen.Emit(OpCodes.Leave, lblFalse);
		}
		else
		{
			((ExpressionNode) base.Children[0]).GenLazyEval(compileContext, lblTrue, lblFalse);
		}
		compileContext.gen.MarkLabel(lblTrue);
		((StatementNode) base.Children[1]).GenCode(compileContext);
		if (HasElse)
		{
			compileContext.gen.Emit(OpCodes.Br, lblEnd);
			compileContext.gen.MarkLabel(lblFalse);
			((StatementNode) base.Children[2]).GenCode(compileContext);
		}
	}
}

