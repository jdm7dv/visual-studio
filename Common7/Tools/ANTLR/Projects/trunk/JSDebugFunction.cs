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

namespace Zinj
{
	internal class JSDebugFunction : JSFunctionBase
	{
		public JSDebugFunctionDef def;

		public JSDebugFunction(JSDebugFunctionDef def, JSEnvRec Scope) : base(JSContext.CurrentGlobalContext.FunctionPrototype, JSContext.CurrentGlobalContext.FunctionCtor)
		{
			this.def = def;
			base.SetDataProp("prototype", new JSObject(), true, false, false);
			this.Scope = Scope;
			base.SetDataProp("length", (double) def.param_names.Length, false, false, false);
		}

		public override JSValue Call(JSContext Scope, JSValue ThisObj, JSArgs Args)
		{
			if (ThisObj.CheckCoercible())
			{
				ThisObj = ThisObj.ToJSObject();
			}
			else
			{
				ThisObj = JSContext.CurrentGlobalContext.Global;
			}
			JSFunctionContext ctx = new JSFunctionContext(ThisObj, Args, new ParameterList(this.def.param_names), Scope, this.Scope);
			return this.def.del(ctx);
		}

		public override JSType DataType
		{
			get
			{
				return JSType.Function;
			}
		}

		public override JSType ObjectType
		{
			get
			{
				return JSType.Function;
			}
		}

		public JSEnvRec Scope { get; set; }
	}
}

