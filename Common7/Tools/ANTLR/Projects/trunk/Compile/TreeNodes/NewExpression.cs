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

internal class NewExpression : ExpressionNode
{
	public NewExpression(IToken o) : base(o)
	{
	}

	internal override void GenCode(CompileContext compileContext)
	{
		ExpressionNode Constructor = (ExpressionNode) base.Children[0];
		CommonTree args = null;
		LocalBuilder lfnc = compileContext.gen.DeclareLocal(typeof(JSValue));
		int ArgCount = 0;
		if (this.ChildCount > 1)
		{
			args = (CommonTree) base.Children[1];
			ArgCount = args.ChildCount;
		}
		Constructor.GenCode(compileContext);
		compileContext.gen.Emit(OpCodes.Stloc, lfnc.LocalIndex);
		compileContext.gen.Emit(OpCodes.Ldloc, lfnc.LocalIndex);
		compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSFunctionCast);
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		compileContext.gen.Emit(OpCodes.Ldloc, lfnc.LocalIndex);
		compileContext.gen.Emit(OpCodes.Ldc_I4, ArgCount);
		compileContext.gen.Emit(OpCodes.Newarr, typeof(JSValue));
		int i = 0;
		if (ArgCount != 0)
		{
			foreach (ExpressionNode arg in args.Children)
			{
				compileContext.gen.Emit(OpCodes.Dup);
				compileContext.gen.Emit(OpCodes.Ldc_I4, i++);
				arg.GenCode(compileContext);
				compileContext.gen.Emit(OpCodes.Stelem_Ref);
			}
		}
		compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSArgs_ctor);
		compileContext.gen.EmitCallV( CompileContext.mi_JSFunctionBase_Construct);
	}
}

