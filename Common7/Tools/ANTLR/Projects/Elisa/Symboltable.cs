
using System;
using System.Collections;

////////////////////////////////////////////////////////////////////////////////
//
// CLASS: Type
//
// Implements type objects
//
////////////////////////////////////////////////////////////////////////////////

public class Type
{
    public enum T {
        INT, ARRAY, FUNC
    }
    
    T      ty;    
    int    size;
    Type   of;
    
    // default constructor
    public Type ()
    {
        ty   = T.INT;
        size = 1;
        of   = null;
    }
    
    // Custom contructor intialises all fields
    public Type( Type.T t, int s, Type o )
    {
        ty   = t;
        size = s;
        of   = o;
    }
    
    // get...() methods
    
    public Type Of {
        get { return of; }
    }
    
    public T Ty {
        get { return ty; }
    }
    
    public int Size {
        get { return size; }
    }
    
    // dump()
    // Dumps out type information
    public void dump()
    {
        if ( ty == T.INT )
            Console.Write( "INT" );
        else if ( ty == T.ARRAY )
        {
            Console.Write( "ARRAY " + size + " OF " );
            of.dump();
        }
        else if ( ty == T.FUNC )
        {
            Console.Write( "FUNC RETURNING " );
            of.dump();
        }
        else
        {
            Console.Error.WriteLine( "*** UNKNOWN INTERNAL TYPE ***" );
        } 
    }
    
    // Equals()
    // Implements "l == r ?"
    // For compound types (arrays and functions) we pairwise walk
    //   along the type list.
    public bool Equal( Type r )
    {
        if ( r == null )
            return false;       // just in case...
            
        if ( ty != r.ty )       // types must be same
            return false;
            
        if ( size != r.size )
            return false;       // sizes must be same
            
        if ( of != null )
            return of.Equals( r.of );  // walk type list
            
        if ( r.of != null )
            return false;       // type list mismatch
            
        return true;            // otherwise, share the joy
    }
}

////////////////////////////////////////////////////////////////////////////////
//
//  CLASS: Symbol 
//
//  Implements symbols within the compiler.
//
////////////////////////////////////////////////////////////////////////////////

public class Symbol
{
    private string name;
    private string xname;       // decorated name for target code
    private uint   offset;
    private Type   type;
    private uint   scope;
    private bool   param;
    
    // Constructor
    // Takes name and type and creates a symbol object.
    public Symbol( string n, Type t )
    {
        name   = n;
        type   = t;
        offset = 0;
        scope  = 0;
        param  = false;
    }
    
    public Type Type {
        get { return type; }
        set { type = value; }
    }
    
    public string Name {
        get { return name; }
    }

    public string xName {
        get { return xname; }
        set { xname = value; }
    }
    
    public uint Offset {
        get { return offset; }
        set { offset = value; }
    }

    public uint Scope {
        get { return scope; }
        set { scope = value; }
    }

    public bool Param {
        get { return param; }
        set { param = value; }
    }
    
    // dump()
    // Dumps the symbol information
    public void dump()
    {
        if ( scope == 0 )
            Console.Write( "Global        " );
        else if ( scope == 1 )
            Console.Write( " Paramater.{0,-2} ", offset );
        else
            Console.Write( "  Local.{0,-2}    ", offset );
        
        Console.Write( "has type '" );
        type.dump();
        Console.WriteLine( "' ({0})", name );
    }
}

////////////////////////////////////////////////////////////////////////////////
//
//  CLASS: SymbolTable
//
//  Implements the symbol table management functionality.
//
////////////////////////////////////////////////////////////////////////////////

public class Symboltable
{
    private Symboltable parent;
    private uint        scope;
    private Hashtable   table;

    // Constructor
    // Creates a new hash table
    public Symboltable()
    {
        parent = null;
        scope  = 0;        
        table  = new Hashtable();
    }    
    
    // Descending constructor
    // Creates hashtable and appends the outer symbol table to our
    //   parent field.
    public Symboltable( Symboltable outer )
    {
        parent = outer;
        scope  = parent.Scope + 1;
        
        table = new Hashtable();
    }
    
    public uint Scope {
        get { return scope; }
    }
    
    public Symboltable Parent {
        get { return parent; }
    }
    
    // Adds a symbol into the symbol table.
    // Fatal error if the symbol already exists in this scope!!!
    public void add( Symbol s )
    {
        if ( table.Contains( s.Name ) )
        {
            Console.Error.WriteLine( "Redefinition of '" + s.Name + "'" );
            throw new System.Exception();
        }
        
        s.Scope = scope;
        table.Add( s.Name, s ); 
    }
    
    // find()
    // Recursivels scans each symbol table, walking up the scope list
    // until either a symbol is found, or we throw an exception.
    public Symbol find( string n )
    {
        if ( table.Contains(n) )
            return (Symbol)table[n];
        else if ( scope > 0 )
            return parent.find(n);
        else
        {
            Console.Error.WriteLine( "Undeclared symbol '" + n + "'" );
            throw new System.Exception();
        }
    }
    
    // dump()
    // Dumps out the contents of the symbol table.
    public void dump()
    {
        foreach( Symbol s in table.Values )
            s.dump();
    }
}

////////////////////////////////////////////////////////////////////////////////
