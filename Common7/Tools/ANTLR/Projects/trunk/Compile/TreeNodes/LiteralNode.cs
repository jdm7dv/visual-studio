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
using System.Runtime.CompilerServices;

internal class LiteralNode : ExpressionNode
{
	public LiteralNode(int x, JSPrimitive value)
	{
		this.Value = value;
	}

	internal override void GenCode(CompileContext compileContext)
	{
		this.Value.GenCode(compileContext.gen);
	}

	public override void GenTyped(CompileContext compileContext)
	{
		this.Value.GenTyped(compileContext.gen);
	}

	public override string ToString()
	{
		return (base.ToString() + "(" + this.Value.ToString() + ")");
	}

	public override JSType TreeType
	{
		get
		{
			return this.Value.DataType;
		}
	}

	public JSPrimitive Value { get; private set; }
}

