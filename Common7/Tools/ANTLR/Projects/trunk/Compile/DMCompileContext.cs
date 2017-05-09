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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Zinj
{
	internal class DMCompileContext : CompileContext
	{
		public DMCompileContext(ILGenerator gen) : base(gen)
		{
		}

		public override int GenerateFunction(functionExpressionNode node, string name, StatementNode r, out FunctionDelegate _delegate)
		{
			DynamicMethod method = new DynamicMethod(name, MethodAttributes.Static | MethodAttributes.Public, CallingConventions.Standard, typeof(JSValue), new Type[] { typeof(JSContext) }, typeof(JSContext), false);
			ILGenerator tmp = method.GetILGenerator();
			base.GenerateFunctionBody(r, tmp);
			_delegate = (FunctionDelegate) method.CreateDelegate(typeof(FunctionDelegate));
			base.Source.FunctionList.Add(node);
			return (base.Source.FunctionList.Count - 1);
		}
	}
}

