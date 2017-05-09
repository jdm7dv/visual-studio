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
using System.Reflection;
using System.Reflection.Emit;

internal abstract class BinaryOpNode : ExpressionNode
{
	public BinaryOpNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		((ExpressionNode) base.Children[0]).GenCode(compileContext);
		((ExpressionNode) base.Children[1]).GenCode(compileContext);
		this.GenOp(compileContext);
	}

	protected virtual void GenOp(CompileContext compileContext)
	{
		compileContext.gen.EmitCallV( this.OpMethod);
	}

	public override bool IsConst
	{
		get
		{
			return (((ExpressionNode) base.Children[0]).IsConst && ((ExpressionNode) base.Children[1]).IsConst);
		}
	}

	protected virtual MethodInfo OpMethod
	{
		get
		{
			throw new NotSupportedException();
		}
	}
}

