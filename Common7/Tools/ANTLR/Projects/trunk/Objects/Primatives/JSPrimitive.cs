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
using System.Reflection.Emit;

namespace Zinj
{
	public abstract class JSPrimitive : JSValue
	{
		protected JSPrimitive()
		{
		}

		internal abstract void GenCode(ILGenerator gen);
		internal abstract void GenTyped(ILGenerator gen);
		public override JSValue ToPrimitive()
		{
			return this;
		}

		public override JSValue ToPrimitive(bool AsString)
		{
			return this;
		}
	}
}

