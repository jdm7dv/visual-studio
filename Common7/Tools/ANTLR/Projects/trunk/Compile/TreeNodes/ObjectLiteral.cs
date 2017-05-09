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

internal class ObjectLiteral : ExpressionNode
{
	private static KeyValuePair<string, ExpressionNode>[] _emptyitems = new KeyValuePair<string, ExpressionNode>[0];
	private KeyValuePair<string, ExpressionNode>[] _items;

	public ObjectLiteral(IToken x) : base(x)
	{
	}

	internal override void ConstructionComplete()
	{
		if (this.ChildCount == 0)
		{
			this._items = _emptyitems;
		}
		else
		{
			this._items = base.Children.Cast<CommonTree>().Select<CommonTree, KeyValuePair<string, ExpressionNode>>(delegate (CommonTree x) {
				return new KeyValuePair<string, ExpressionNode>(GetItemName(x), (ExpressionNode) x.Children[1]);
			}).ToArray<KeyValuePair<string, ExpressionNode>>();
			base.Children.Clear();
			foreach (KeyValuePair<string, ExpressionNode> v in this._items)
			{
				base.Children.Add(v.Value);
			}
		}
		base.ConstructionComplete();
	}

	internal override void GenCode(CompileContext compileContext)
	{
		compileContext.gen.Emit(OpCodes.Newobj, CompileContext.JSObject_ctor);
		foreach (KeyValuePair<string, ExpressionNode> v in this._items)
		{
			compileContext.gen.Emit(OpCodes.Dup);
			compileContext.gen.Emit(OpCodes.Ldstr, v.Key);
			v.Value.GenCode(compileContext);
			compileContext.gen.EmitCallV( CompileContext.op_JSValue_SetItem);
		}
	}

	private static string GetItemName(CommonTree x)
	{
		return ((((CommonTree) x.Children[0]) is LiteralNode) ? ((LiteralNode) ((CommonTree) x.Children[0])).Value.StringValue() : CompileContext.EscapeIdentifier(((CommonTree) x.Children[0]).Text));
	}

	public override JSType TreeType
	{
		get
		{
			return JSType.Array;
		}
	}
}

