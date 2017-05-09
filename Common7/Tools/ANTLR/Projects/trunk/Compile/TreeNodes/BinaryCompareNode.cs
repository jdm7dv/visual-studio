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

internal abstract class BinaryCompareNode : BinaryOpNode
{
	public BinaryCompareNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		this.GenTyped(compileContext);
		compileContext.gen.EmitCallV( CompileContext.op_JSBool_Implicit);
	}

	protected override void GenOp(CompileContext compileContext)
	{
		this.GenUntypedOp(compileContext);
	}

	public override void GenTyped(CompileContext compileContext)
	{
		ExpressionNode n1 = (ExpressionNode) base.Children[0];
		JSType t1 = n1.TreeType;
		ExpressionNode n2 = (ExpressionNode) base.Children[1];
		JSType t2 = n2.TreeType;
		if ((t1 == JSType.Number) && (t2 == JSType.Number))
		{
			((ExpressionNode) base.Children[0]).GenTyped(compileContext, JSType.Number);
			((ExpressionNode) base.Children[1]).GenTyped(compileContext, JSType.Number);
			this.GenTypedOp(compileContext);
		}
		else
		{
			((ExpressionNode) base.Children[0]).GenCode(compileContext);
			((ExpressionNode) base.Children[1]).GenCode(compileContext);
			this.GenUntypedOp(compileContext);
		}
	}

	protected abstract void GenTypedOp(CompileContext compileContext);
	protected virtual void GenUntypedOp(CompileContext compileContext)
	{
		compileContext.gen.EmitCallV( this.OpMethod);
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.Boolean;
		}
	}
}

