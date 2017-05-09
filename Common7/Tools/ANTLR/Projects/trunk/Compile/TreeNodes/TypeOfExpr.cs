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

internal class TypeOfExpr : ExpressionNode
{
	public TypeOfExpr(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		this.GenTyped(compileContext);
		compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSString_ctor);
	}

	public override void GenTyped(CompileContext compileContext)
	{
		TermBuilderNode TB = base.Children[0] as TermBuilderNode;
		if (!((TB == null) || (TB is ThisRef)))
		{
			TB.GenBaseCode(compileContext);
			TB.GenRefCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.mi_JSBase_GetBindingType);
		}
		else
		{
			((ExpressionNode) base.Children[0]).GenCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.mi_JSValue_TypeOf);
		}
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.String;
		}
	}
}

