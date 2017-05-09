﻿/* 
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

internal class AssignmentNode : ExpressionNode
{
	public AssignmentNode(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		TermBuilderNode DestVar = base.Children[0] as TermBuilderNode;
		if (DestVar == null)
		{
			throw new JSRuntimeException("SyntaxError", string.Concat(new object[] { "line ", base.token.Line, ":", base.token.CharPositionInLine, " Invalid assignment" }));
		}
		((ExpressionNode) base.Children[1]).GenCode(compileContext);
		LocalBuilder loc = compileContext.gen.DeclareLocal(typeof(JSValue));
		compileContext.gen.Emit(OpCodes.Stloc, loc.LocalIndex);
		DestVar.GenBaseCode(compileContext);
		DestVar.GenRefCode(compileContext);
		compileContext.gen.Emit(OpCodes.Ldloc, loc.LocalIndex);
		DestVar.GenAssignCode(compileContext);
		compileContext.gen.Emit(OpCodes.Ldloc, loc.LocalIndex);
	}
}

