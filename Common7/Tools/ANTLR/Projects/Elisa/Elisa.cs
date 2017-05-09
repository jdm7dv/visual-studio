////////////////////////////////////////////////////////////////////////////////
//
//  ANTLR Lexer/Parser for Elisa
//
//  Written by: Neil Johnson
//
//  File: Main application 
//
//  Build:
//      csc /lib:<path to ANTLR runtime> /r:antlr.runtime.dll *.cs
//
// Note: For ROTOR on Unix you need a sym-link to the directory where the
//       antlr.runtime.dll file is located, since at startup the ANTLR
//       code will search for this file (if not, you'll get an exception
//       when the application starts up).
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;

// Set up access to antlr components

using CommonAST				= antlr.CommonAST;
using AST					= antlr.collections.AST;
using CharBuffer			= antlr.CharBuffer;
using RecognitionException	= antlr.RecognitionException;
using TokenStreamException	= antlr.TokenStreamException;

// Main application class

class Elisa 
{
	public static void Main(string[] args) 
	{
	   bool FdumpAST = false;
	   bool Fverbose = false;
	   
        if ( args.Length > 0 )
        {
            // Parse optional command line flags
            for ( int i = 1; i < args.Length; i++ )
            {
                if ( args[i] == "--dumpAST" )
                    FdumpAST = true;
                else if ( args[i] == "--verbose" || args[i] == "-v" )
                    Fverbose = true;
                else
                    Console.Error.WriteLine( "Ignoring unknown flag '" + args[i] + "'" );
            }        
        
           try 
            {
                FileInfo srcFile = new FileInfo( args[0] );
                
                if ( srcFile.Extension == ".el" )
                {
                    ElisaLexer lexer = new ElisaLexer( new CharBuffer( srcFile.OpenText() ) );
                    lexer.setFilename( args[0] );
                    
                    ElisaParser parser = new ElisaParser( lexer );
                    parser.setFilename( args[0] );
        
                    // Parse the input expression
                    parser.program();
                    CommonAST t = (CommonAST)parser.getAST();
                    
                    string objFile  = srcFile.FullName.Substring( 0, srcFile.FullName.LastIndexOf( srcFile.Extension ) );
                    string basename = srcFile.Name.Substring( 0, srcFile.Name.LastIndexOf( srcFile.Extension ) ); 
                    
                    Console.WriteLine( "-- Elisa Experimental Compiler --" );
                    Console.WriteLine( "Source: {0}", srcFile.FullName );
                                
                    if ( FdumpAST )
                    {                       
                        // Print the resulting tree out in LISP notation
                        Console.Out.WriteLine(t.ToStringTree());
                    }
                  
                    // Traverse the tree created by the parser and generate target code for the
                    //  chosen target (only DotNet so far).
                    
                    ElisaCodeGenerator codegen = new ElisaCodeGenerator();
                    codegen.Target  = new DotNetCodeGen( srcFile );
                    codegen.Verbose = Fverbose;
                    codegen.program( t );
                }
                else
                {
                    Console.Error.WriteLine("Compilation failed: source filename must have '.el' extension.");
                }
            }
            catch(TokenStreamException e) 
            {
                Console.Error.WriteLine("exception: "+e);
            }
            catch(RecognitionException e) 
            {
                Console.Error.WriteLine("exception: "+e);
            }
            catch(Exception e)
            {
                Console.Error.WriteLine( "Compilation aborted." + e );
            }
        }
        else
            Console.Error.WriteLine( "Usage: Elisa.exe src (must have extension '.el') [flags...]" );
	}  
}

////////////////////////////////////////////////////////////////////////////////
