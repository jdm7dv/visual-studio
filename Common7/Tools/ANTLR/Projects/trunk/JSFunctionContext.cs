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

using System;

namespace Zinj
{
	internal class JSFunctionContext : JSContext
	{
		private JSArgs Args;
		private ParameterList parameterList;
		private JSValue ThisObj;

		public JSFunctionContext(JSValue ThisObj, JSArgs Args, ParameterList parameterList, JSContext context, JSEnvRec Scope) : base(context)
		{
			if (!((ThisObj is JSNull) || (ThisObj is JSUndefined)))
			{
				this.ThisObj = ThisObj;
			}
			this.Args = Args;
			this.parameterList = parameterList;
			base.LexicalEnv = new JSDeclScope(Scope);
			base.VariableEnv = base.LexicalEnv;
			base.CreateMutableBinding("arguments");
			base.SetMutableBinding("arguments", Args);
			int m = parameterList.Names.Length;
			for (int i = 0; i < m; i++)
			{
				base.CreateMutableBinding(parameterList.Names[i]);
				base.SetMutableBinding(parameterList.Names[i], Args[i]);
			}
		}

		internal override JSValue ExplicitThis
		{
			get
			{
				if (this.ThisObj != null)
				{
					return this.ThisObj;
				}
				return base.ExplicitThis;
			}
		}
	}
}

