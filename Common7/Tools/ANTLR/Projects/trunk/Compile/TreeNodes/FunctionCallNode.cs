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
using Antlr.Runtime.Tree;
using System;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class FunctionCallNode : ExpressionNode
{
	public FunctionCallNode(int x)
	{
	}

	internal override void ConstructionComplete()
	{
		base.ConstructionComplete();
		IdentifierNode l = base.Children[1] as IdentifierNode;
		if (((l != null) && (l.LeftTree == null)) && (l.Value == "eval"))
		{
			this.IsDirectEval = true;
		}
	}

	internal override void GenCode(CompileContext compileContext)
	{
		CommonTree args = (CommonTree) base.Children[0];
		ExpressionNode Source = (ExpressionNode) base.Children[1];
		TermBuilderNode TBSource = Source as TermBuilderNode;
		LocalBuilder lThisObj = compileContext.gen.DeclareLocal(typeof(JSValue));
		LocalBuilder lFncObj = compileContext.gen.DeclareLocal(typeof(JSValue));
		if ((TBSource != null) && TBSource.HasBase)
		{
			TBSource.GenBaseCode(compileContext);
			compileContext.gen.Emit(OpCodes.Stloc, lThisObj.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, lThisObj.LocalIndex);
			TBSource.GenFetchCode(compileContext);
			compileContext.gen.Emit(OpCodes.Stloc, lFncObj.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, lFncObj.LocalIndex);
			compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSFunctionCast);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldloc, lThisObj.LocalIndex);
		}
		else if (TBSource is IdentifierNode)
		{
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldstr, ((IdentifierNode) TBSource).Value);
			compileContext.gen.Emit(OpCodes.Ldloca, lThisObj.LocalIndex);
			compileContext.gen.EmitCallV( CompileContext.mi_GetFunctionWithThis);
			compileContext.gen.Emit(OpCodes.Stloc, lFncObj.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, lFncObj.LocalIndex);
			compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSFunctionCast);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldloc, lThisObj.LocalIndex);
		}
		else
		{
			Source.GenCode(compileContext);
			compileContext.gen.Emit(OpCodes.Stloc, lFncObj.LocalIndex);
			compileContext.gen.Emit(OpCodes.Ldloc, lFncObj.LocalIndex);
			compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_JSFunctionCast);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.EmitCallV( CompileContext.mi_ImplicitThis);
		}
		compileContext.gen.Emit(OpCodes.Ldloc, lFncObj.LocalIndex);
		compileContext.gen.Emit(OpCodes.Ldc_I4, args.ChildCount);
		compileContext.gen.Emit(OpCodes.Newarr, typeof(JSValue));
		int i = 0;
		if (args.ChildCount != 0)
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
		if (this.IsDirectEval)
		{
			compileContext.gen.EmitCallV( CompileContext.fnc_Utilities_DirectEvalCall);
		}
		else
		{
			compileContext.gen.EmitCallV( CompileContext.mi_JSFunctionBase_Call);
		}
	}

	public bool IsDirectEval { get; private set; }
}

