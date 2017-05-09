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
using System;
using System.Reflection.Emit;

internal class ExpressionStatement : StatementNode
{
	public ExpressionStatement(int x)
	{
	}

	private void GenStatementCode(CompileContext compileContext)
	{
		if (compileContext.TrackImplicitReturnValue)
		{
			compileContext.gen.Emit(OpCodes.Ldarg_0);
		}
		((ExpressionNode) base.Children[0]).GenCode(compileContext);
		if (compileContext.TrackImplicitReturnValue)
		{
			compileContext.gen.EmitCallV( CompileContext.mi_Set_Returnval);
		}
		else
		{
			compileContext.gen.Emit(OpCodes.Pop);
		}
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		if (bGenDebug)
		{
			base.GenDebugWrap(compileContext, new Action<CompileContext>(this.GenStatementCode));
		}
		else
		{
			this.GenStatementCode(compileContext);
		}
	}
}

