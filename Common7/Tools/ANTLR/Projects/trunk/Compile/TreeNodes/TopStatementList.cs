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
using System;
using System.Collections.Generic;

internal class TopStatementList : StatementList
{
	public TopStatementList(int x) : base(x)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		Stack<baseNode> st = new Stack<baseNode>();
		st.Push(this);
		while (st.Count > 0)
		{
			baseNode t = st.Pop();
			for (int i = t.ChildCount - 1; i >= 0; i--)
			{
				baseNode c = (baseNode) t.Children[i];
				if (!(c is TopStatementList))
				{
					st.Push(c);
				}
			}
			if (t is VarDeclStatement)
			{
				((VarDeclStatement) t).GenCreate(compileContext);
			}
		}
		if (this.ChildCount != 0)
		{
			foreach (StatementNode n in base.Children)
			{
				if (n is functionDeclarationNode)
				{
					((functionDeclarationNode) n).GenCode(compileContext);
				}
			}
			foreach (StatementNode n in base.Children)
			{
				if (!(n is functionDeclarationNode))
				{
					n.GenCode(compileContext);
				}
			}
		}
	}
}

