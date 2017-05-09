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
using Antlr.Runtime.Tree;
using System;
using System.Reflection.Emit;

internal class returnStatement : StatementNode
{
	public returnStatement(IToken f) : base(f)
	{
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		CommonTree t = this;
		while (t != null)
		{
			if (t is TopStatementList)
			{
				break;
			}
			t = t.parent;
		}
		if (((TopStatementList) t).Parent == null)
		{
			throw new JSRuntimeException("SyntaxError", "return not in a function");
		}
		if (this.ChildCount == 0)
		{
			compileContext.gen.EmitCallV( CompileContext.mi_JSUndefined_Instance);
		}
		else if (!bGenDebug)
		{
			((ExpressionNode) base.Children[0]).GenCode(compileContext);
		}
		else
		{
			LocalBuilder l = compileContext.gen.DeclareLocal(typeof(JSValue));
			base.GenDebugWrap(compileContext, delegate (CompileContext x) {
				((ExpressionNode) this.Children[0]).GenCode(compileContext);
				compileContext.gen.Emit(OpCodes.Stloc, l.LocalIndex);
			});
			compileContext.gen.Emit(OpCodes.Ldloc, l.LocalIndex);
		}
		compileContext.gen.Emit(OpCodes.Stloc, compileContext.fncData.return_local);
		base.GenInterStatementBreak(compileContext, compileContext.fncData.return_label);
	}
}

