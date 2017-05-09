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

internal class ConditionalExpression : ExpressionNode
{
	public ConditionalExpression(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		Label lblTrue = compileContext.gen.DefineLabel();
		Label lblFalse = compileContext.gen.DefineLabel();
		Label lblEnd = compileContext.gen.DefineLabel();
		((ExpressionNode) base.Children[0]).GenLazyEval(compileContext, lblTrue, lblFalse);
		compileContext.gen.MarkLabel(lblFalse);
		((ExpressionNode) base.Children[2]).GenCode(compileContext);
		compileContext.gen.Emit(OpCodes.Br, lblEnd);
		compileContext.gen.MarkLabel(lblTrue);
		((ExpressionNode) base.Children[1]).GenCode(compileContext);
		compileContext.gen.MarkLabel(lblEnd);
	}

	public override void GenTyped(CompileContext compileContext)
	{
		Label lblTrue = compileContext.gen.DefineLabel();
		Label lblFalse = compileContext.gen.DefineLabel();
		Label lblEnd = compileContext.gen.DefineLabel();
		((ExpressionNode) base.Children[0]).GenLazyEval(compileContext, lblTrue, lblFalse);
		compileContext.gen.MarkLabel(lblFalse);
		((ExpressionNode) base.Children[2]).GenTyped(compileContext);
		compileContext.gen.Emit(OpCodes.Br, lblEnd);
		compileContext.gen.MarkLabel(lblTrue);
		((ExpressionNode) base.Children[1]).GenTyped(compileContext);
		compileContext.gen.MarkLabel(lblEnd);
	}

	public override JSType TreeType
	{
		get
		{
			JSType t1 = ((ExpressionNode) base.Children[1]).TreeType;
			if (t1 == JSType.Unknown)
			{
				return JSType.Unknown;
			}
			JSType t2 = ((ExpressionNode) base.Children[2]).TreeType;
			if (t2 == JSType.Unknown)
			{
				return JSType.Unknown;
			}
			if (t1 != t2)
			{
				return JSType.Unknown;
			}
			return t1;
		}
	}
}

