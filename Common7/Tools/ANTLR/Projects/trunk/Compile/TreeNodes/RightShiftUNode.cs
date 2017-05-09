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

internal class RightShiftUNode : ShiftNode
{
	public RightShiftUNode(IToken o) : base(o)
	{
	}

	public override void GenTyped(CompileContext compileContext)
	{
		((ExpressionNode) base.Children[0]).GenTyped(compileContext, JSType.Number);
		compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSToUInt32);
		((ExpressionNode) base.Children[1]).GenTyped(compileContext, JSType.Number);
		compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSToInt32);
		compileContext.gen.Emit(OpCodes.Ldc_I4_S, 0x1f);
		compileContext.gen.Emit(OpCodes.And);
		compileContext.gen.Emit(OpCodes.Shr_Un);
		compileContext.gen.Emit(OpCodes.Conv_R_Un);
		compileContext.gen.Emit(OpCodes.Conv_R8);
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.Number;
		}
	}
}

