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
using System.Reflection.Emit;

internal abstract class StatementNode : baseNode
{
	internal Label breakdest;
	internal Label continuedest;
	internal HashSet<string> Labels;

	public StatementNode()
	{
	}

	public StatementNode(IToken o) : base(o)
	{
	}

	internal void AddLabel(string p)
	{
		for (ITree t = this; t != null; t = t.Parent)
		{
			StatementNode l = t as StatementNode;
			if ((l != null) && l.HasLabel(p))
			{
				throw new JSRuntimeException("SyntaxError", "duplicate label");
			}
		}
		if (this.Labels == null)
		{
			this.Labels = new HashSet<string>();
		}
		this.Labels.Add(p);
	}

	internal void GenCode(CompileContext compileContext)
	{
		this.breakdest = compileContext.gen.DefineLabel();
		this.GenStatementCode(compileContext, true);
		compileContext.gen.MarkLabel(this.breakdest);
	}

	protected void GenDebugWrap(CompileContext compileContext, Action<CompileContext> _act)
	{
		if (JSContext.EnableDebug)
		{
			Label StartLbl = compileContext.gen.DefineLabel();
			compileContext.gen.MarkLabel(StartLbl);
			Label exTryCatchFinally = compileContext.gen.BeginExceptionBlock();
			base.TryCatchLevels++;
			_act(compileContext);
			base.TryCatchLevels--;
			compileContext.gen.BeginCatchBlock(typeof(JSRuntimeException));
			LocalBuilder thrownException = compileContext.gen.DeclareLocal(typeof(JSRuntimeException));
			compileContext.gen.Emit(OpCodes.Stloc, thrownException);
			compileContext.gen.Emit(OpCodes.Ldarg_0);
			compileContext.gen.Emit(OpCodes.Ldc_I4, this.GetLine());
			compileContext.gen.Emit(OpCodes.Ldloc, thrownException);
			compileContext.gen.EmitCallV(CompileContext.mi_HandleError);
			compileContext.gen.Emit(OpCodes.Brtrue, StartLbl);
			compileContext.gen.Emit(OpCodes.Ldloc, thrownException);
			compileContext.gen.Emit(OpCodes.Throw);
			compileContext.gen.EndExceptionBlock();
		}
		else
		{
			_act(compileContext);
		}
	}

	internal abstract void GenStatementCode(CompileContext compileContext, bool bGenDebug);
	private int GetLine()
	{
		return this.Line;
	}

	internal bool HasLabel(string l)
	{
		if (this.Labels == null)
		{
			return false;
		}
		return this.Labels.Contains(l);
	}

	internal virtual bool AllowContinue
	{
		get
		{
			return false;
		}
	}

	internal virtual bool AllowUnlabledBreak
	{
		get
		{
			return false;
		}
	}
}

