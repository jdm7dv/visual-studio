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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Zinj
{
	public class DebugWrapper
	{
		private JSValue _retVal;
		private object _sync = new object();
		private Thread _thread;
		private CompiledScript script;

		public DebugWrapper(CompiledScript script)
		{
			this.script = script;
		}

		private void Go()
		{
			this.state = State.Running;
			try
			{
				this._retVal = this.script.Run();
				this.state = State.Complete;
			}
			catch (JSRuntimeException ex)
			{
				this.state = State.Failed;
				this.Error = ex;
			}
			catch (_ExWrapper)
			{
			}
			finally
			{
				this._thread = null;
			}
			lock (this._sync)
			{
				Monitor.Pulse(this._sync);
			}
		}

		internal bool HandleError(int line, JSRuntimeException ex)
		{
			this.BreakLine = line;
			lock (this._sync)
			{
				this.Error = ex;
				this.state = State.Paused;
				Monitor.Pulse(this._sync);
				Monitor.Wait(this._sync);
			}
			if (this.state == State.Running)
			{
				return true;
			}
			this.state = State.Failed;
			throw new _ExWrapper(ex);
		}

		public bool Run()
		{
			JSValue dummy;
			return this.Run(out dummy);
		}

		public bool Run(out JSValue result)
		{
			JSContext.CurrentGlobalContext.Debugger = this;
			lock (this._sync)
			{
				if (this.state == State.Paused)
				{
					this.state = State.Running;
					Monitor.Pulse(this._sync);
				}
				else
				{
					this._thread = new Thread(new ThreadStart(this.Go));
					this._thread.Start();
				}
				Monitor.Wait(this._sync);
			}
			if (this.state == State.Failed)
			{
				throw this.Error;
			}
			if (this.state == State.Complete)
			{
				result = this._retVal;
				return true;
			}
			result = null;
			return false;
		}

		public void Terminate()
		{
			this.state = State.Failed;
			if (this._thread != null)
			{
				this._thread.Abort();
				lock (this._sync)
				{
					Monitor.Pulse(this._sync);
				}
			}
		}

		public int BreakLine { get; private set; }

		public JSRuntimeException Error { get; private set; }

		public State state { get; private set; }

		private class _ExWrapper : Exception
		{
			public _ExWrapper(JSRuntimeException ex) : base("", ex)
			{
			}
		}

		public enum State
		{
			Stopped,
			Running,
			Paused,
			Failed,
			Complete
		}
	}
}

