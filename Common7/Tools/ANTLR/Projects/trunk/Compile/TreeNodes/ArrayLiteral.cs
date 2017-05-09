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

internal class ArrayLiteral : ExpressionNode
{
	public ArrayLiteral(IToken x) : base(x)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		int RealChildCount = this.ChildCount;
		if ((RealChildCount != 0) && (((baseNode) base.Children[RealChildCount - 1]).ChildCount == 0))
		{
			RealChildCount--;
		}
		compileContext.gen.Emit(OpCodes.Ldc_I4, RealChildCount);
		compileContext.gen.Emit(OpCodes.Newarr, typeof(JSValue));
		for (int i = 0; i < RealChildCount; i++)
		{
			compileContext.gen.Emit(OpCodes.Dup);
			compileContext.gen.Emit(OpCodes.Ldc_I4, i);
			baseNode n = (baseNode) base.Children[i];
			if (n.ChildCount == 0)
			{
				compileContext.gen.EmitCallV( CompileContext.mi_JSUndefined_Instance);
			}
			else
			{
				((ExpressionNode) n.Children[0]).GenCode(compileContext);
			}
			compileContext.gen.Emit(OpCodes.Stelem_Ref);
		}
		compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSArray_ctor);
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.Array;
		}
	}
}

