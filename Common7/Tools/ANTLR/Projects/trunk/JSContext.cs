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
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Zinj
{
	public class JSContext : JSBase
	{
		private static Stack<JSContext> ContextStack = new Stack<JSContext>();
		public static JSContext CurrentContext;
		public static JSGlobalContext CurrentGlobalContext;
		public static bool DebugOutput;
		public static bool OutputAssembly;
		public static bool EnableDebug;
		private static Stack<JSGlobalContext> GlobalContextStack = new Stack<JSGlobalContext>();
		public JSEnvRec LexicalEnv;
		internal ScriptSource Source;
		public JSEnvRec VariableEnv;

		public JSContext() : this(null)
		{
		}

		public JSContext(JSContext Parent)
		{
			this.Parent = Parent;
			if (Parent != null)
			{
				this.LexicalEnv = Parent.LexicalEnv;
				this.VariableEnv = Parent.VariableEnv;
			}
		}

		internal JSContext CreateCatchScope(JSRuntimeException ex, string varname)
		{
			JSContext ctx = new JSContext(this);
			JSEnvRec r = new JSDeclScope(this.LexicalEnv);
			r.CreateMutableBinding(varname);
			r.SetMutableBinding(varname, ex.value);
			ctx.LexicalEnv = r;
			return ctx;
		}

		public void CreateMutableBinding(string key)
		{
			this.VariableEnv.CreateMutableBinding(key);
		}

		internal JSContext CreateWithScope(JSValue v)
		{
			JSObject obj = v.ToJSObject();
			JSContext ctx = new JSContext(this);
			JSEnvRec r = new JSWithScope(this.LexicalEnv, obj);
			ctx.LexicalEnv = r;
			return ctx;
		}

		public override bool DeleteProperty(string Key, bool Throw)
		{
			for (JSEnvRec l = this.LexicalEnv; l != null; l = l.Parent)
			{
				if (l.HasBinding(Key))
				{
					return l.DeleteBinding(Key, Throw);
				}
			}
			return true;
		}

		public JSValue GetBindingValue(string key)
		{
			for (JSEnvRec lex = this.LexicalEnv; lex != null; lex = lex.Parent)
			{
				JSValue r;
				if (lex.TryGetBindingValue(key, out r))
				{
					return r;
				}
			}
			throw new JSRuntimeException("ReferenceError", key + " is not defined");
		}

		internal virtual JSValue GetFunctionReference(int key)
		{
			return this.GetFunctionReference(key, this.LexicalEnv);
		}

		protected internal virtual JSValue GetFunctionReference(int key, JSEnvRec r)
		{
			JSContext ctx = this;
			if (ctx.Source == null)
			{
				return this.Parent.GetFunctionReference(key, r);
			}
			functionExpressionNode fncNode = ctx.Source.FunctionList[key];
			JSFunctionObject fnc = new JSFunctionObject(fncNode, r);
			fnc.SetDataProp("length", (double) fncNode.ParameterList.Names.Length, false, false, false);
			return fnc;
		}

		internal virtual JSValue GetFunctionWithThis(string key, out JSValue lThisObj)
		{
			for (JSEnvRec lex = this.LexicalEnv; lex != null; lex = lex.Parent)
			{
				JSValue r;
				if (lex.TryGetBindingValue(key, out r))
				{
					if (lex is JSObjectScope)
					{
						lThisObj = ((JSObjectScope) lex).ScopeObject;
						return r;
					}
					lThisObj = JSUndefined.Instance;
					return r;
				}
			}
			throw new JSRuntimeException("ReferenceError", key + " is not defined");
		}

		internal bool HandleError(int line, JSRuntimeException ex)
		{
			DebugWrapper Debugger = this.Debugger;
			if (ex.Line == -1)
			{
				ex.Line = line;
			}
			if (Debugger == null)
			{
				return false;
			}
			return Debugger.HandleError(line, ex);
		}

		public bool HasBinding(string key)
		{
			for (JSEnvRec lex = this.LexicalEnv; lex != null; lex = lex.Parent)
			{
				if (lex.HasBinding(key))
				{
					return true;
				}
			}
			return false;
		}

		internal static void PopContext()
		{
			if (CurrentContext is JSGlobalContext)
			{
				CurrentGlobalContext = GlobalContextStack.Pop();
			}
			CurrentContext = ContextStack.Pop();
		}

		internal static void PushContext(JSContext Context)
		{
			if (Context is JSGlobalContext)
			{
				GlobalContextStack.Push(CurrentGlobalContext);
				CurrentGlobalContext = (JSGlobalContext) Context;
			}
			ContextStack.Push(CurrentContext);
			CurrentContext = Context;
		}

		public void SetMutableBinding(string key, JSValue value)
		{
			if (!this.LexicalEnv.TrySetBindingValue(key, value))
			{
				throw new Exception();
			}
		}

		public void SetVarBinding(string key, JSValue value)
		{
			if (!this.VariableEnv.TrySetBindingValue(key, value))
			{
				throw new Exception();
			}
		}

		public override string GetBindingType(string Key)
		{
			if (!this.HasBinding(Key))
			{
				return "undefined";
			}
			return this.GetBindingValue(Key).TypeOf;
		}

		internal virtual DebugWrapper Debugger
		{
			get
			{
				return this.Parent.Debugger;
			}
			set
			{
				this.Parent.Debugger = value;
			}
		}

		internal virtual JSValue ExplicitThis
		{
			get
			{
				if (this.Parent != null)
				{
					return this.Parent.ExplicitThis;
				}
				return CurrentGlobalContext.Global;
			}
		}

		public virtual JSObject Global
		{
			get
			{
				return this.Parent.Global;
			}
		}

		internal JSValue ImplicitThis
		{
			get
			{
				return this.LexicalEnv.ImplicitThis;
			}
		}

		public JSContext Parent { get; private set; }

		public virtual JSValue ReturnValue
		{
			get
			{
				return this.Parent.ReturnValue;
			}
			set
			{
				this.Parent.ReturnValue = value;
			}
		}
	}
}

