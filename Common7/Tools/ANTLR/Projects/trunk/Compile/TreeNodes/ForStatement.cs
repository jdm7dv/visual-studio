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
using Antlr.Runtime.Tree;
using System;
using System.Reflection.Emit;

internal class ForStatement : StatementNode
{
	public ForStatement(IToken o) : base(o)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		Label lblTop = compileContext.gen.DefineLabel();
		base.continuedest = compileContext.gen.DefineLabel();
		Label lblBody = compileContext.gen.DefineLabel();
		StatementNode A = (((CommonTree) base.Children[0]).ChildCount != 0) ? ((StatementNode) ((CommonTree) base.Children[0]).Children[0]) : null;
		if(A != null)
			foreach (baseNode n in A.EnumerateAll())
				if (n is InNode) throw new JSRuntimeException("SyntaxError", "Invalid for/in");
		ExpressionNode B = (((CommonTree) base.Children[1]).ChildCount != 0) ? ((ExpressionNode) ((CommonTree) base.Children[1]).Children[0]) : null;
		StatementNode C = (((CommonTree) base.Children[2]).ChildCount != 0) ? ((StatementNode) ((CommonTree) base.Children[2]).Children[0]) : null;
		StatementNode D = (StatementNode) ((CommonTree) base.Children[3]);
		bool _track = compileContext.TrackImplicitReturnValue;
		if (A != null)
		{
			compileContext.TrackImplicitReturnValue = false;
			A.GenCode(compileContext);
			compileContext.TrackImplicitReturnValue = _track;
		}
		compileContext.gen.MarkLabel(lblTop);
		if (B != null)
		{
			B.GenLazyEval(compileContext, lblBody, base.breakdest);
		}
		compileContext.gen.MarkLabel(lblBody);
		D.GenCode(compileContext);
		compileContext.gen.MarkLabel(base.continuedest);
		if (C != null)
		{
			compileContext.TrackImplicitReturnValue = false;
			C.GenCode(compileContext);
			compileContext.TrackImplicitReturnValue = _track;
		}
		compileContext.gen.Emit(OpCodes.Br, lblTop);
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

