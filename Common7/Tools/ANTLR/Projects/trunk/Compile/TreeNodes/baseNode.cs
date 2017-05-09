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
using System.Runtime.InteropServices;

internal class baseNode : CommonTree
{
	internal int TryCatchLevels;

	public baseNode()
	{
		this.TryCatchLevels = 0;
	}

	public baseNode(IToken o) : base(o)
	{
		this.TryCatchLevels = 0;
	}

	public baseNode(int o)
	{
		this.TryCatchLevels = 0;
	}

	private static void _reset(CommonTree n)
	{
		if (n.ChildCount != 0)
		{
			foreach (CommonTree o in n.Children)
			{
				if (o is baseNode)
				{
					((baseNode) o).Reset();
				}
				else
				{
					_reset(o);
				}
			}
		}
	}

	internal virtual void ConstructionComplete()
	{
		if (this.ChildCount != 0)
		{
			foreach (baseNode o in base.Children)
			{
				o.ConstructionComplete();
			}
		}
	}

	internal System.Collections.Generic.IEnumerable<baseNode> EnumerateAll()
	{
		yield return this;
		if (this.ChildCount != 0)
			foreach (baseNode o in base.Children)
				yield return o;
	}

	protected void GenInterStatementBreak(CompileContext compileContext, Label lbl)
	{
		this.GenInterStatementBreak(compileContext, lbl, null);
	}

	protected void GenInterStatementBreak(CompileContext compileContext, Label lbl, baseNode destNode)
	{
		tryStatementNode FinallyNode;
		bool bNeedLeave = this.NeedLeave(destNode, out FinallyNode);
		if (FinallyNode != null)
		{
			FinallyNode.GenFinallyForward(compileContext, lbl, destNode, bNeedLeave);
		}
		else
		{
			compileContext.gen.Emit(bNeedLeave ? OpCodes.Leave : OpCodes.Br, lbl);
		}
	}

	protected bool NeedLeave(baseNode destNode, out tryStatementNode FinallyNode)
	{
		FinallyNode = null;
		bool need = false;
		for (baseNode n = base.parent as baseNode; !(n is TopStatementList); n = n.parent as baseNode)
		{
			if (n.TryCatchLevels > 0)
			{
				need = true;
			}
			if (n is tryStatementNode)
			{
				FinallyNode = (tryStatementNode) n;
				return need;
			}
			if (n == destNode)
			{
				return need;
			}
		}
		return need;
	}

	public virtual void Reset()
	{
		_reset(this);
	}

	public override string ToString()
	{
		if (this.Token != null)
		{
			return base.ToString();
		}
		return base.GetType().Name;
	}

	public override bool IsNil
	{
		get
		{
			return false;
		}
	}
}

