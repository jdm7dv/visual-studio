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

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Zinj
{
	public class CompiledScript
	{
		private GlobalCodeDelegate _delegate;
		internal ScriptSource Source;

		internal CompiledScript(GlobalCodeDelegate Delegate)
		{
			this._delegate = Delegate;
		}

		public static CompiledScript Compile(string script)
		{
			return Compile(script, true);
		}

		internal static CompiledScript Compile(string script, bool isGlobal)
		{
			CommonTokenStream tokens = new CommonTokenStream();
			JavaScriptLexer lexer = new JavaScriptLexer(new ANTLRStringStream(script));
			tokens.TokenSource = lexer;
			ScriptSource Source = new ScriptSource(script);
			JavaScriptParser parser = new JavaScriptParser(tokens);
			TopStatementList r = (TopStatementList) parser.program().Tree;
			r.ConstructionComplete();
			if (JSContext.DebugOutput)
			{
				DumpTree(r, 0);
			}
			if (JSContext.OutputAssembly && isGlobal)
			{
				GenerateExternalAssembly(r);
				r.Reset();
			}
			return GenerateMethod(r, Source);
		}

		private static void DumpTree(CommonTree r, int ind)
		{
			Console.Write(new string('\t', ind));
			Console.WriteLine(r.ToString());
			if (r.Children != null)
			{
				foreach (CommonTree t in r.Children)
				{
					DumpTree(t, ind + 1);
				}
			}
		}

		private static void GenerateExternalAssembly(StatementNode r)
		{
			ASMCompileContext ctx = new ASMCompileContext();
			ctx.GenerateAB(r).Save("DynamicAssemblyExample.dll");
		}

		private static CompiledScript GenerateMethod(StatementNode r, ScriptSource Source)
		{
			DynamicMethod method = new DynamicMethod("GlobalCode", MethodAttributes.Static | MethodAttributes.Public, CallingConventions.Standard, typeof(JSValue), new Type[] { typeof(JSContext) }, typeof(JSContext), false);
			DMCompileContext ctx = new DMCompileContext(method.GetILGenerator());
			ctx.Source = Source;
			ctx.GenerateGlobalCode(r);
			GlobalCodeDelegate _delegate = (GlobalCodeDelegate) method.CreateDelegate(typeof(GlobalCodeDelegate));
			CompiledScript cs = new CompiledScript(_delegate);
			cs.Source = Source;
			return cs;
		}

		public JSValue Run()
		{
			JSContext ctx = new JSContext(JSContext.CurrentContext);
			ctx.Source = this.Source;
			JSContext.PushContext(ctx);
			try
			{
				return this._delegate(JSContext.CurrentContext);
			}
			finally
			{
				JSContext.PopContext();
			}
		}
	}
}

