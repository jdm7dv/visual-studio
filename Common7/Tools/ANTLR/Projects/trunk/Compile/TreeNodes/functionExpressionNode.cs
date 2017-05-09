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
using System.Runtime.CompilerServices;

internal class functionExpressionNode : ExpressionNode
{
	private FunctionDelegate _delegate;
	private ParameterList _ParameterList;
	private int FunctionID;
	internal ScriptSource Source;
	private int srcEnd;

	public functionExpressionNode(int x, IToken t1, IToken t2) : base(t1)
	{
		this.FunctionID = -1;
		this.srcEnd = ((CommonToken) t2).StopIndex;
	}

	internal JSValue Call(JSContext Scope, JSValue ThisObj, JSValue fncObject, JSArgs Args)
	{
		JSFunctionContext ctx = new JSFunctionContext(ThisObj, Args, this.ParameterList, Scope, ((JSFunctionObject) fncObject).Scope);
		ctx.Source = this.Source;
		if (this.Name != "[function]")
		{
			ctx.LexicalEnv.CreateMutableBinding(this.Name);
			ctx.LexicalEnv.SetMutableBinding(this.Name, fncObject);
		}
		return this._delegate(ctx);
	}

	internal override void ConstructionComplete()
	{
		if (this.ChildCount == 3)
		{
			this.Name = CompileContext.EscapeIdentifier(((CommonTree) base.Children[2]).Text);
			base.Children.RemoveAt(2);
		}
		else
		{
			this.Name = "[function]";
		}
		base.ConstructionComplete();
		this._ParameterList = (ParameterList) base.Children[0];
	}

	internal override void GenCode(CompileContext compileContext)
	{
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		this.GenFunctionRef(compileContext);
		compileContext.gen.EmitCallV( CompileContext.mi_GetFunctionReference);
	}

	internal string GenerateString()
	{
		int start = ((CommonToken) base.token).StartIndex;
		return this.Source.Text.Substring(start, (this.srcEnd - start) + 1);
	}

	internal void GenFunctionRef(CompileContext compileContext)
	{
		if (this.FunctionID == -1)
		{
			if (compileContext.Source != null)
			{
				this.Source = compileContext.Source;
			}
			bool WasGlobal = compileContext.TrackImplicitReturnValue;
			compileContext.TrackImplicitReturnValue = false;
			this.FunctionID = compileContext.GenerateFunction(this, this.Name, (StatementNode) base.Children[1], out this._delegate);
			compileContext.TrackImplicitReturnValue = WasGlobal;
		}
		compileContext.GenFunctionRef(this.FunctionID);
	}

	public override void Reset()
	{
		this._delegate = null;
		this.FunctionID = -1;
		base.Reset();
	}

	public string Name { get; private set; }

	internal ParameterList ParameterList
	{
		get
		{
			return this._ParameterList;
		}
	}
}

