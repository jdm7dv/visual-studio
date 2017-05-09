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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Zinj;
using Antlr.Runtime.Tree;

public partial class JavaScriptLexer
{
	private int LastTokenType = -1;
	private bool hadNewline = true;
	public override IToken Emit()
	{
		IToken t = base.Emit();
		if (t.Channel == 99)
		{
		}
		if (t.Channel == 0)
		{
			if (t.Type == JavaScriptLexer.LT)
			{
				hadNewline = true;
			}
			else
			{
				LastTokenType = t.Type;
				hadNewline = false;
			}
		}
		return t;
	}

	private bool CanBeRegex() {
		if (LastTokenType == T__41 && !hadNewline) return false;
		if (LastTokenType == -1 || !DividePrecedingTokens.Contains(LastTokenType)) return true;
		return false;
	}

	private static HashSet<int> DividePrecedingTokens = new HashSet<int>();
	static JavaScriptLexer()
	{
		DividePrecedingTokens.Add(JavaScriptLexer.Identifier);
		DividePrecedingTokens.Add(JavaScriptLexer.NumericLiteral);
		DividePrecedingTokens.Add(JavaScriptLexer.StringLiteral);
		DividePrecedingTokens.Add(JavaScriptLexer.RegexLiteral);
		AddDynamicTokens();
	}

	public override void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
	{
		string hdr = GetErrorHeader(e);
		string msg = GetErrorMessage(e, tokenNames);
		throw new JSRuntimeException("SyntaxError", hdr + " " + msg);
	}
}
public partial class JavaScriptParser
{
	private static string ProcessEscapedString(string s)
	{
		StringBuilder b = new StringBuilder();
		int l = s.Length - 1;
		try
		{
			for (int i = 1; i < l; i++)
			{
				char c = s[i];
				if (c != '\\')
				{
					b.Append(c);
					continue;
				}
				i++;
				switch (s[i])
				{
					case 'b': b.Append('\b'); break;
					case 'f': b.Append('\f'); break;
					case 'n': b.Append('\n'); break;
					case 'r': b.Append('\r'); break;
					case 't': b.Append('\t'); break;
					case 'v': b.Append('\v'); break;

					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						break;

					case 'x':
						b.Append((char)int.Parse(s.Substring(i + 1, 2), System.Globalization.NumberStyles.AllowHexSpecifier));
						i += 2;
						continue;
					case 'u':
						b.Append((char)int.Parse(s.Substring(i + 1, 4), System.Globalization.NumberStyles.AllowHexSpecifier));
						i += 4;
						continue;
					case '0':
						b.Append('\0');
						break;
					case '\'':
					case '"':
					case '\\':
						b.Append(s[i]);
						break;
					default:
						throw new Exception("Bad escape sequence");
				}
			}
		}
		catch (Exception ex)
		{
			throw new JSRuntimeException("SyntaxError", ex.Message);
		}
		return b.ToString();
	}

	public override void DisplayRecognitionError(string[] tokenNames, RecognitionException e)
	{
		string hdr = GetErrorHeader(e);
		string msg = GetErrorMessage(e, tokenNames);
		throw new JSRuntimeException("SyntaxError", hdr + " " + msg);
	}
}
