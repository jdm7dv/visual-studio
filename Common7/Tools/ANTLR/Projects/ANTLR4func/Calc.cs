////////////////////////////////////////////////////////////////////////////////
//
//  ANTLR Lexer/Parser/Evaluator for 4-function Calculator
//
//  Written by: Neil Johnson
//
//  File: Main application 
//
//  Build:
//      java antlr.Tool calc.g
//      csc /lib:<path to ANTLR runtime> /r:antlr.runtime.dll *.cs
//
// Note: For ROTOR on Unix you need a sym-link to the directory where the
//       antlr.runtime.dll file is located, since at startup the ANTLR
//       code will search for this file (if not, you'll get an exception
//       when the application starts up).
//
////////////////////////////////////////////////////////////////////////////////

using System;

// Set up access to antlr components

using CommonAST				= antlr.CommonAST;
using AST					= antlr.collections.AST;
using CharBuffer			= antlr.CharBuffer;
using RecognitionException	= antlr.RecognitionException;
using TokenStreamException	= antlr.TokenStreamException;

// Main application class

class Calc 
{
	public static void Main(string[] args) 
	{
		try 
		{
			CalcLexer lexer = new CalcLexer(new CharBuffer(Console.In));
			lexer.setFilename("<stdin>");
			CalcParser parser = new CalcParser(lexer);
			parser.setFilename("<stdin>");

			// Parse the input expression
			parser.expr();
			CommonAST t = (CommonAST)parser.getAST();
			
			// Print the resulting tree out in LISP notation
			Console.Out.WriteLine(t.ToStringTree());
			CalcTreeWalker walker = new CalcTreeWalker();
			
			// Traverse the tree created by the parser
			float r = walker.expr(t);
			Console.Out.WriteLine("value is "+r);
		}
		catch(TokenStreamException e) 
		{
			Console.Error.WriteLine("exception: "+e);
		}
		catch(RecognitionException e) 
		{
			Console.Error.WriteLine("exception: "+e);
		}
	}  
}

////////////////////////////////////////////////////////////////////////////////
