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
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class VarDeclStatement : StatementNode
{
	private ExpressionNode[] varInitializers;

	public VarDeclStatement(IToken o) : base(o)
	{
	}

	internal override void ConstructionComplete()
	{
		this.varNames = new string[this.ChildCount];
		this.varInitializers = new ExpressionNode[this.ChildCount];
		for (int i = 0; i < this.ChildCount; i++)
		{
			CommonTree n = (CommonTree) base.Children[i];
			this.varNames[i] = CompileContext.EscapeIdentifier(((CommonTree) n.Children[0]).Text);
			if (n.ChildCount > 1)
			{
				this.varInitializers[i] = (ExpressionNode) n.Children[1];
			}
		}
		if (this.ChildCount > 0)
		{
			base.Children.Clear();
			foreach (ExpressionNode x in this.varInitializers.Where<ExpressionNode>(delegate (ExpressionNode x) {
				return x != null;
			}))
			{
				base.Children.Add(x);
			}
		}
		base.ConstructionComplete();
	}

	internal void GenCreate(CompileContext compileContext)
	{
		for (int i = 0; i < this.varNames.Length; i++)
		{
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldstr, this.varNames[i]);
			compileContext.gen.EmitCallV( CompileContext.mi_CreateMutableBinding);
		}
	}

	private void GenStatementCode(CompileContext compileContext)
	{
		for (int i = 0; i < this.varNames.Length; i++)
		{
			if (this.varInitializers[i] != null)
			{
				compileContext.gen.Emit(OpCodes.Ldarg_0);
				compileContext.gen.Emit(OpCodes.Ldstr, this.varNames[i]);
				this.varInitializers[i].GenCode(compileContext);
				compileContext.gen.EmitCallV( CompileContext.mi_SetMutableBinding);
			}
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

	public string[] varNames { get; private set; }
}

