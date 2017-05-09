////////////////////////////////////////////////////////////////////////////////
//
// Abstract API for Target Code Generator for Elisa Compiler
//
// Author:  Neil Johnson, University of Cambridge Computer Laboratory
//          email: me@njohnson.co.uk
//
// Notes:   This abstract base class defines the API of the CodeGen class, so make sure
//           _all_ methods are overridden.
//          This is/was the first code generator, so there are bound to be some
//           .Net infuences on the code gen. API.  But I don't think it will
//           take too much effort to port to, say, JVM bytecodes.
//
// History
//
// 0.1      17-Apr-2004     First version
//
////////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections;

abstract public class CodeGen
{
    protected string          cgFileName;
    protected string          cgBaseName;
    protected StreamWriter    cgStream;
        
    public CodeGen( FileInfo srcFile )
    {
        cgFileName = srcFile.FullName.Substring( 0, srcFile.FullName.LastIndexOf( srcFile.Extension ) );
        cgBaseName = srcFile.Name.Substring( 0, srcFile.Name.LastIndexOf( srcFile.Extension ) );
    }
    
    abstract public string BaseName { get; }

    abstract public void Open();
    abstract public void Close();
    
    abstract public void Globals( ArrayList g );    
    abstract public void announceLocal( Symbol s );
    
    abstract public void openFunction( Symbol s, ArrayList plist );
    abstract public void closeFunction( ArrayList llist );

    // Directives
    
    abstract public void emit_label( uint l );
    abstract public void directive( uint d, string s );
    abstract public void comment( string s );

    // Instructions
    
    abstract public void emit_brnz( uint l );
    abstract public void emit_brz( uint l );
    abstract public void emit_branch( uint l );
    
    abstract public void emit_mul();
    abstract public void emit_add();
    abstract public void emit_div();
    abstract public void emit_mod();
    abstract public void emit_not();
    abstract public void emit_sub();
    abstract public void emit_neg();
    
    abstract public void emit_bor();
    abstract public void emit_bxor();
    abstract public void emit_band();
    
    abstract public void emit_shl();
    abstract public void emit_shr();
    
    abstract public void emit_beq( uint l );
    abstract public void emit_bne( uint l );
    abstract public void emit_bgt( uint l );
    abstract public void emit_bge( uint l );
    abstract public void emit_blt( uint l );
    abstract public void emit_ble( uint l );
    
    abstract public void emit_iconst( int c );
    
    abstract public void emit_pop();
    abstract public void emit_dup();
    
    abstract public void emit_stglobal( string s );
    abstract public void emit_ldglobal( string s );
    
    abstract public void emit_ldarg( uint i );
    abstract public void emit_starg( uint i );
    
    abstract public void emit_stloc( uint i );
    abstract public void emit_ldloc( uint i );
    
    abstract public void emit_ldelem();
    abstract public void emit_stelem();
    
    abstract public void emit_call( string t, ArrayList args );
    abstract public void emit_ret();
    
    // Built-In functions for simple I/O interfacing.

    abstract public void PUT();
    abstract public void GET();
}
