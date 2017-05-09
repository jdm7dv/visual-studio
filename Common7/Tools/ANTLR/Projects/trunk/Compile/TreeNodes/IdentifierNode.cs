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
using System.Runtime.CompilerServices;

internal class IdentifierNode : TermBuilderNode
{
	public IdentifierNode(IToken t) : base(t)
	{
		this.Value = CompileContext.EscapeIdentifier(t.Text);
	}

	internal override void GenAssignCode(CompileContext compileContext)
	{
		compileContext.gen.EmitCallV( CompileContext.mi_SetMutableBinding);
	}

	internal override void GenFetchCode(CompileContext compileContext)
	{
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		compileContext.gen.Emit(OpCodes.Ldstr, this.Value);
		compileContext.gen.EmitCallV( CompileContext.mi_GetBindingValue);
	}

	internal override void GenRefCode(CompileContext compileContext)
	{
		compileContext.gen.Emit(OpCodes.Ldarg_0);
		compileContext.gen.Emit(OpCodes.Ldstr, this.Value);
	}

	public string Value { get; private set; }
}

