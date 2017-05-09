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

internal class DoWhileStatement : StatementNode
{
	public DoWhileStatement(IToken o) : base(o)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		Label lblTop = compileContext.gen.DefineLabel();
		Label lblCond = base.continuedest = compileContext.gen.DefineLabel();
		compileContext.gen.MarkLabel(lblTop);
		((StatementNode) base.Children[0]).GenCode(compileContext);
		compileContext.gen.MarkLabel(lblCond);
		((ExpressionNode) base.Children[1]).GenLazyEval(compileContext, lblTop, base.breakdest);
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

