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
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

internal class tryStatementNode : StatementNode
{
	private string CatchId;
	private StatementNode CatchTree;
	private LocalBuilder FinallyFwdDest;
	private StatementNode FinallyTree;
	private Label FinEnd;
	private List<PostFinallyLabel> PostFinallyLabels;

	public tryStatementNode(IToken f) : base(f)
	{
		this.PostFinallyLabels = new List<PostFinallyLabel>();
	}

	internal override void ConstructionComplete()
	{
		CommonTree CatchTmp = (((CommonTree) base.Children[1]).ChildCount != 0) ? ((CommonTree) ((CommonTree) base.Children[1]).Children[0]) : null;
		if (CatchTmp != null)
		{
			this.CatchTree = (StatementNode) CatchTmp.Children[1];
			this.CatchId = CompileContext.EscapeIdentifier(((CommonTree) CatchTmp.Children[0]).Text);
		}
		this.FinallyTree = (((CommonTree) base.Children[2]).ChildCount != 0) ? ((StatementNode) ((CommonTree) base.Children[2]).Children[0]) : null;
		if (this.FinallyTree == null)
		{
			this.DeleteChild(2);
		}
		if (this.CatchTree == null)
		{
			this.DeleteChild(1);
		}
		else
		{
			this.ReplaceChildren(1, 1, this.CatchTree);
		}
		base.ConstructionComplete();
	}

	internal void GenFinallyForward(CompileContext compileContext, Label dest, baseNode destNode, bool bNeedLeave)
	{
		int n = this.PostFinallyLabels.Count;
		this.PostFinallyLabels.Add(new PostFinallyLabel() { destNode = destNode, lbl = dest, switchlabel = compileContext.gen.DefineLabel() });
		compileContext.gen.Emit(OpCodes.Ldc_I4, n);
		compileContext.gen.Emit(OpCodes.Stloc, this.FinallyFwdDest);
		compileContext.gen.Emit(bNeedLeave ? OpCodes.Leave : OpCodes.Br, this.FinEnd);
	}

	internal override void GenStatementCode(CompileContext compileContext, bool bGenDebug)
	{
		LocalBuilder thrownException = compileContext.gen.DeclareLocal(typeof(JSRuntimeException));
		Label exTryCatchFinally = compileContext.gen.BeginExceptionBlock();
		this.FinallyFwdDest = compileContext.gen.DeclareLocal(typeof(int));
		compileContext.gen.Emit(OpCodes.Ldc_I4_M1);
		compileContext.gen.Emit(OpCodes.Stloc, this.FinallyFwdDest);
		this.FinEnd = compileContext.gen.DefineLabel();
		((StatementNode) base.Children[0]).GenCode(compileContext);
		compileContext.gen.MarkLabel(this.FinEnd);
		if (this.CatchTree != null)
		{
			compileContext.gen.BeginCatchBlock(typeof(JSRuntimeException));
			compileContext.gen.Emit(OpCodes.Stloc, thrownException);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldloc, thrownException);
			compileContext.gen.Emit(OpCodes.Ldstr, this.CatchId);
			compileContext.gen.EmitCallV( CompileContext.mi_JSScope_CreateCatchScope);
			compileContext.gen.Emit(OpCodes.Starg, 0);
			Label InternalTry = compileContext.gen.BeginExceptionBlock();
			this.FinEnd = compileContext.gen.DefineLabel();
			this.CatchTree.GenCode(compileContext);
			compileContext.gen.MarkLabel(this.FinEnd);
			compileContext.gen.BeginFinallyBlock();
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.EmitCallV( CompileContext.mi_JSContext_Parent);
			compileContext.gen.Emit(OpCodes.Starg, 0);
			compileContext.gen.EndExceptionBlock();
		}
		else if (this.FinallyTree != null)
		{
			compileContext.gen.BeginCatchBlock(typeof(JSRuntimeException));
			compileContext.gen.Emit(OpCodes.Stloc, thrownException);
		}
		if (this.FinallyTree != null)
		{
			this.FinEnd = compileContext.gen.DefineLabel();
			compileContext.gen.BeginFinallyBlock();
			this.FinallyTree.GenCode(compileContext);
			compileContext.gen.MarkLabel(this.FinEnd);
		}
		compileContext.gen.EndExceptionBlock();
		bool bProcessRedirects = this.PostFinallyLabels.Count > 0;
		if (bProcessRedirects)
		{
			compileContext.gen.Emit(OpCodes.Ldloc, this.FinallyFwdDest);
			compileContext.gen.Emit(OpCodes.Switch, this.PostFinallyLabels.Select<PostFinallyLabel, Label>(delegate (PostFinallyLabel x) {
				return x.switchlabel;
			}).ToArray<Label>());
		}
		if ((this.CatchTree == null) && (this.FinallyTree != null))
		{
			compileContext.gen.Emit(OpCodes.Ldloc, thrownException);
			compileContext.gen.Emit(OpCodes.Brfalse, base.breakdest);
			compileContext.gen.Emit(OpCodes.Ldloc, thrownException);
			compileContext.gen.Emit(OpCodes.Throw);
		}
		else
		{
			compileContext.gen.Emit(OpCodes.Br, base.breakdest);
		}
		if (bProcessRedirects)
		{
			foreach (PostFinallyLabel pfl in this.PostFinallyLabels)
			{
				compileContext.gen.MarkLabel(pfl.switchlabel);
				base.GenInterStatementBreak(compileContext, pfl.lbl, pfl.destNode);
			}
		}
	}

	public override void Reset()
	{
		this.PostFinallyLabels.Clear();
		this.FinEnd = new Label();
		base.Reset();
	}

	private class PostFinallyLabel
	{
		public baseNode destNode;
		public Label lbl;
		public Label switchlabel;
	}
}

