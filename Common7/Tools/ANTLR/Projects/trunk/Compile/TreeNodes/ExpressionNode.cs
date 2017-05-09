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

internal abstract class ExpressionNode : baseNode
{
	public ExpressionNode()
	{
	}

	public ExpressionNode(IToken o) : base(o)
	{
	}

	internal abstract void GenCode(CompileContext compileContext);
	internal virtual void GenLazyEval(CompileContext compileContext, Label lblTrue, Label lblFalse)
	{
		this.GenTyped(compileContext, JSType.Boolean);
		compileContext.gen.Emit(OpCodes.Brtrue, lblTrue);
		compileContext.gen.Emit(OpCodes.Br, lblFalse);
	}

	public virtual void GenTyped(CompileContext compileContext)
	{
		this.GenTypedBase(compileContext, this.TreeType);
	}

	internal void GenTyped(CompileContext compileContext, JSType aJType)
	{
		if (this.TreeType == aJType)
		{
			this.GenTyped(compileContext);
		}
		else
		{
			this.GenTypedBase(compileContext, aJType);
		}
	}

	private void GenTypedBase(CompileContext compileContext, JSType aJType)
	{
		this.GenCode(compileContext);
		switch (aJType)
		{
			case JSType.Number:
				compileContext.gen.EmitCallV( CompileContext.mi_JSValue_NumberValue);
				break;

			case JSType.String:
				compileContext.gen.EmitCallV( CompileContext.mi_JSValue_StringValue);
				break;

			case JSType.Boolean:
				compileContext.gen.EmitCallV( CompileContext.mi_JSValue_BoolValue);
				break;

			default:
				throw new Exception();
		}
	}

	public virtual bool IsConst
	{
		get
		{
			return false;
		}
	}

	public virtual JSType TreeType
	{
		get
		{
			return JSType.Unknown;
		}
	}
}

