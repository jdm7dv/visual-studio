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

internal class EqualsNode : BinaryOpNode
{
	public EqualsNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		this.GenTyped(compileContext);
		compileContext.gen.EmitCallV( CompileContext.op_JSBool_Implicit);
	}

	public override void GenTyped(CompileContext compileContext)
	{
		ExpressionNode n1 = (ExpressionNode) base.Children[0];
		JSType t1 = n1.TreeType;
		ExpressionNode n2 = (ExpressionNode) base.Children[1];
		JSType t2 = n2.TreeType;
		if ((t1 == t2) && (((t1 == JSType.String) || (t1 == JSType.Boolean)) || (t1 == JSType.Number)))
		{
			((ExpressionNode) base.Children[0]).GenTyped(compileContext, t1);
			((ExpressionNode) base.Children[1]).GenTyped(compileContext, t1);
			this.GenTypedOp(compileContext);
		}
		else
		{
			((ExpressionNode) base.Children[0]).GenCode(compileContext);
			((ExpressionNode) base.Children[1]).GenCode(compileContext);
			this.GenUntypedOp(compileContext);
		}
	}

	protected virtual void GenTypedOp(CompileContext compileContext)
	{
		if (((ExpressionNode) base.Children[0]).TreeType == JSType.String)
		{
			compileContext.gen.EmitCallV( CompileContext.fnc_Sys_String_Equals);
		}
		else
		{
			compileContext.gen.Emit(OpCodes.Ceq);
		}
	}

	protected virtual void GenUntypedOp(CompileContext compileContext)
	{
		compileContext.gen.EmitCallV( this.OpMethod);
	}

	protected override MethodInfo OpMethod
	{
		get
		{
			return CompileContext.mi_JSValue_JSEquals;
		}
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.Boolean;
		}
	}
}

