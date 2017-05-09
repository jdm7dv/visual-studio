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

internal class AddNode : BinaryMathNode
{
	public AddNode(IToken o) : base(o)
	{
	}

	protected override void GenTypedOp(CompileContext compileContext)
	{
		if (this.TreeType == JSType.String)
		{
			compileContext.gen.EmitCallV( CompileContext.fnc_Sys_String_Concat);
		}
		else
		{
			compileContext.gen.Emit(OpCodes.Add);
		}
	}

	protected override MethodInfo OpMethod
	{
		get
		{
			return CompileContext.op_JSValue_Addition;
		}
	}

	public override JSType TreeType
	{
		get
		{
			JSType t1 = ((ExpressionNode) base.Children[0]).TreeType;
			if (t1 == JSType.Unknown)
			{
				return JSType.Unknown;
			}
			JSType t2 = ((ExpressionNode) base.Children[0]).TreeType;
			if (t2 == JSType.Unknown)
			{
				return JSType.Unknown;
			}
			if ((t1 == JSType.String) || (t2 == JSType.String))
			{
				return JSType.String;
			}
			return JSType.Number;
		}
	}
}

