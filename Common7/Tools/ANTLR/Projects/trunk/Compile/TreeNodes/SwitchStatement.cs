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

internal class SwitchStatement : StatementNode
{
	public SwitchStatement(IToken o) : base(o)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		baseCase c;
		LocalBuilder lInput = compileContext.gen.DeclareLocal(typeof(JSValue));
		((ExpressionNode) base.Children[0]).GenCode(compileContext);
		compileContext.gen.Emit(OpCodes.Stloc, lInput.LocalIndex);
		bool bNeedSkipLabel = false;
		Label SkipEvalLabel = new Label();
		int i = 1;
		while (i < this.ChildCount)
		{
			c = (baseCase) base.Children[i];
			if (c is DefaultClause)
			{
				break;
			}
			compileContext.gen.Emit(OpCodes.Ldloc, lInput.LocalIndex);
			c.Selector.GenCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.mi_JSValue_JSEqualsExact);
			Label SkipStatement = compileContext.gen.DefineLabel();
			compileContext.gen.Emit(OpCodes.Brfalse, SkipStatement);
			if (bNeedSkipLabel)
			{
				compileContext.gen.MarkLabel(SkipEvalLabel);
			}
			c.Statement.GenCode(compileContext);
			SkipEvalLabel = compileContext.gen.DefineLabel();
			compileContext.gen.Emit(OpCodes.Br, SkipEvalLabel);
			bNeedSkipLabel = true;
			compileContext.gen.MarkLabel(SkipStatement);
			i++;
		}
		if (i < this.ChildCount)
		{
			baseCase d = (baseCase) base.Children[i];
			int j = i + 1;
			Label[] CaseLabels = new Label[this.ChildCount - j];
			for (int k = 0; k < CaseLabels.Length; k++)
			{
				CaseLabels[k] = compileContext.gen.DefineLabel();
			}
			for (i = j; i < this.ChildCount; i++)
			{
				c = (baseCase) base.Children[i];
				compileContext.gen.Emit(OpCodes.Ldloc, lInput.LocalIndex);
				c.Selector.GenCode(compileContext);
				compileContext.gen.EmitCallV( CompileContext.mi_JSValue_JSEqualsExact);
				compileContext.gen.Emit(OpCodes.Brtrue, CaseLabels[i - j]);
			}
			if (bNeedSkipLabel)
			{
				compileContext.gen.MarkLabel(SkipEvalLabel);
			}
			bNeedSkipLabel = false;
			d.Statement.GenCode(compileContext);
			for (i = j; i < this.ChildCount; i++)
			{
				c = (baseCase) base.Children[i];
				compileContext.gen.MarkLabel(CaseLabels[i - j]);
				c.Statement.GenCode(compileContext);
			}
		}
		if (bNeedSkipLabel)
		{
			compileContext.gen.MarkLabel(SkipEvalLabel);
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

