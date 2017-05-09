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

internal class LogicalOrNode : BinaryOpNode
{
	public LogicalOrNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		Label lblSkip = compileContext.gen.DefineLabel();
		((ExpressionNode) base.Children[0]).GenCode(compileContext);
		compileContext.gen.Emit(OpCodes.Dup);
		compileContext.gen.EmitCallV( CompileContext.mi_JSValue_BoolValue);
		compileContext.gen.Emit(OpCodes.Brtrue, lblSkip);
		compileContext.gen.Emit(OpCodes.Pop);
		((ExpressionNode) base.Children[1]).GenCode(compileContext);
		compileContext.gen.MarkLabel(lblSkip);
	}

	internal override void GenLazyEval(CompileContext compileContext, Label lblTrue, Label lblFalse)
	{
		Label lblPartTwo = compileContext.gen.DefineLabel();
		((ExpressionNode) base.Children[0]).GenLazyEval(compileContext, lblTrue, lblPartTwo);
		compileContext.gen.MarkLabel(lblPartTwo);
		((ExpressionNode) base.Children[1]).GenLazyEval(compileContext, lblTrue, lblFalse);
	}
}

