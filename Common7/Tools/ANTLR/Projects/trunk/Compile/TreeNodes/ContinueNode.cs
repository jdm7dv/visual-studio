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

internal class ContinueNode : StatementNode
{
	private string lbl;

	public ContinueNode(IToken x) : base(x)
	{
	}

	internal override void ConstructionComplete()
	{
		if (this.ChildCount > 0)
		{
			this.lbl = ((ITree) base.Children[0]).Text;
			base.Children.Clear();
		}
		base.ConstructionComplete();
	}

	private StatementNode FindContinueDest()
	{
		for (CommonTree t = this; t != null; t = t.Parent as CommonTree)
		{
			if (t is TopStatementList)
			{
				return null;
			}
			StatementNode dest = t as StatementNode;
			if ((dest != null) && (((this.lbl == null) && dest.AllowContinue) || dest.HasLabel(this.lbl)))
			{
				return dest;
			}
		}
		return null;
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		StatementNode dest = this.FindContinueDest();
		if ((this.lbl != null) && ((dest == null) || !dest.AllowContinue))
		{
			throw new JSRuntimeException("SyntaxError", "label not found");
		}
		if ((dest == null) || (0 != 0))
		{
			throw new JSRuntimeException("SyntaxError", "continue must be inside loop");
		}
		base.GenInterStatementBreak(compileContext, dest.continuedest, dest);
	}
}

