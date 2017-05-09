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
using System.Linq;
using System.Runtime.CompilerServices;
using Antlr.Runtime.Tree;

internal class ParameterList : baseNode
{
	public ParameterList()
	{
	}

	public ParameterList(IToken o) : base(o)
	{
	}

	public ParameterList(string[] names)
	{
		this.Names = names;
	}

	internal override void ConstructionComplete()
	{
		if (this.ChildCount == 0)
		{
			this.Names = new string[0];
		}
		else
		{
			this.Names = base.Children.Cast<CommonTree>().Select<CommonTree, string>(delegate (CommonTree x) {
				return CompileContext.EscapeIdentifier(x.Text);
			}).ToArray<string>();
			base.Children.Clear();
		}
		base.ConstructionComplete();
	}

	public string[] Names { get; private set; }
}

