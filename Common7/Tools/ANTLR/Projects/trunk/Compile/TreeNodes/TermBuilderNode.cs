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
using System.Runtime.CompilerServices;

internal abstract class TermBuilderNode : ExpressionNode
{

	public TermBuilderNode()
	{
	}

	public TermBuilderNode(IToken t) : base(t)
	{
	}

	internal virtual void GenAssignCode(CompileContext compileContext)
	{
		throw new NotSupportedException();
	}

	internal virtual void GenBaseCode(CompileContext compileContext)
	{
		if (this.LeftTree != null)
		{
			this.LeftTree.GenCode(compileContext);
		}
	}

	internal override void GenCode(CompileContext compileContext)
	{
		this.GenBaseCode(compileContext);
		this.GenFetchCode(compileContext);
	}

	internal virtual void GenDupeBaseCode(CompileContext compileContext)
	{
		if (this.LeftTree != null)
		{
			compileContext.gen.Emit(OpCodes.Dup);
		}
	}

	internal abstract void GenFetchCode(CompileContext compileContext);
	internal virtual void GenRefCode(CompileContext compileContext)
	{
		throw new NotSupportedException();
	}

	public virtual bool HasBase
	{
		get
		{
			return (this.LeftTree != null);
		}
	}

	public ExpressionNode LeftTree { get; protected set; }
}

