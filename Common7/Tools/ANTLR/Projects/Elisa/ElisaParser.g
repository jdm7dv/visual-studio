////////////////////////////////////////////////////////////////////////////////
//
//  ANTLR Lexer/Parser for Elisa
//
//  Author:  Neil Johnson
//
//  Build:
//      java antlr.Tool ElisaParser.g
//      csc /lib:<path to ANTLR runtime> /r:antlr.runtime.dll *.cs
//
// Note: For ROTOR on Unix you need a sym-link to the directory where the
//       antlr.runtime.dll file is located, since at startup the ANTLR
//       code will search for this file (if not, you'll get an exception
//       when the application starts up).
//
// History
//
// 0.1      17-Apr-2004     First version.
//
//////////////////////////////////////////////////////////////////////////////// 

header
{
    using System.IO;
    using System.Collections;
}

options {
	language = "CSharp";
}

////////////////////////////////////////////////////////////////////////////////
//  Parser
////////////////////////////////////////////////////////////////////////////////

class ElisaParser extends Parser;
options {
	buildAST = true;	// uses CommonAST by default

    k = 2;
}

////////////////////////////////////////////////////////////////////////////////
// Pseudo tokens used during construction of ASTs.
////////////////////////////////////////////////////////////////////////////////

tokens {
    PROGRAM;

    DECLARATION;
    FUNCTION_DECL;
    DECL;
    PARAMETER_LIST;
    STMT_BLOCK;
    STATEMENT;
    
    ARRAY;
    FUNCTION;
    
    INDIR;
    
    IF_STMT;
    IF_ELSE_STMT;
    
    NULL_STMT;
}

////////////////////////////////////////////////////////////////////////////////
//  A program is a list of declarations
////////////////////////////////////////////////////////////////////////////////

program
    : ( declaration )+
        { #program = #([PROGRAM, "program"], #program); }
    ;
        
////////////////////////////////////////////////////////////////////////////////
// A declaration is a declarator terminated with a semicolon, unlike a function
//  definition. 
////////////////////////////////////////////////////////////////////////////////

declaration
    : declarator (
        ( ( SEMI! )
            { #declaration = #([DECLARATION, "declaration"], #declaration); } )
        | 
        ( ( LPAREN! ( parameter_list )? RPAREN! stmt_block ) )
            { #declaration = #([FUNCTION_DECL, "function_decl"], #declaration); } )
    ;

////////////////////////////////////////////////////////////////////////////////
// A declarator gives a type and an identifier and optionally array dimention
////////////////////////////////////////////////////////////////////////////////

declarator
    : KW_INT IDENT ( arraydecl )? 
        { #declarator = #([DECL, "declarator"], #declarator ); }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Array declarations start with '[', an optional dimension, and a ']'.
// If the dimension is not specified, then we force a 0 into the AST.
////////////////////////////////////////////////////////////////////////////////

arraydecl
    : LBRACKET! INTEGER RBRACKET!
    |! LBRACKET! RBRACKET! { #arraydecl = #([INTEGER, "0"]); }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// A parameter list is a comma-separated list of declarators:
//   decl1 , decl2 , decl3, ...  
////////////////////////////////////////////////////////////////////////////////

parameter_list
    : declarator ( COMMA! declarator )*
        { #parameter_list = #([PARAMETER_LIST, "parameter_list"], #parameter_list); }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// A statement block, be it the body of a function or nested within a statement
//  itself, has zero or more declarations followed by zero or more statements.
////////////////////////////////////////////////////////////////////////////////

stmt_block
    : LCURLY! ( declarator SEMI! )* ( statement )* RCURLY!
        { #stmt_block = #([STMT_BLOCK, "stmt_block"], #stmt_block); }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Where each statement can be an expression, an IF, a WHILE, a RETURN or a
//  nested statement block. 
////////////////////////////////////////////////////////////////////////////////

statement
    : expression SEMI!
    | if_stmt
    | while_stmt
    | return_stmt
    | stmt_block
    | SEMI!
        { #statement = #([NULL_STMT, "null_stmt"]); }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Traditional if..then..else, with optional else-part.  We also tell ANTLR to 
//  not worry about ambiguity, since an LL(k) parser naturally handles the
//  dangling-else in the way that we want.
// We construct slightly different trees for IF statements with and without
//  else clauses; this simplifies the later code generator and helps avoid
//  redundant branches and labels for very little effort in the compiler.  
////////////////////////////////////////////////////////////////////////////////

if_stmt
{ bool isIfElse = false; }
    : KW_IF! LPAREN! expression RPAREN! statement 
        ( options { warnWhenFollowAmbig = false; } : KW_ELSE! statement { isIfElse = true; } )?
    {
        if ( isIfElse )
            #if_stmt = #([IF_ELSE_STMT, "ifelse" ], #if_stmt );
        else
            #if_stmt = #([IF_STMT, "if"], #if_stmt );
    }  
    ;
    
////////////////////////////////////////////////////////////////////////////////
// While statement iterates statement while expression evaluates to non-zero.  
////////////////////////////////////////////////////////////////////////////////

while_stmt
    : KW_WHILE^ LPAREN! expression RPAREN! statement
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Return statement evaluates expression, then returns it to the caller.  
////////////////////////////////////////////////////////////////////////////////

return_stmt
    : KW_RETURN^ expression SEMI!
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Expressions
// Precedence is described explicitly in the grammar, although a tad coarsely
//  a few places :-)  Assignments are special in that we must strip off the
//  INDIR node for lvalue assignments.
////////////////////////////////////////////////////////////////////////////////

expression!
{
    bool isassign = false;
}
    : lexpr:or_expr ( {isassign=true;} ASSIGN^ rexpr:expression )? {
            if(isassign)
            {
                if ( #lexpr.Type != INDIR )
                {
                    Console.Error.WriteLine( "Error: invalid lvalue" );
                    throw new System.Exception();
                }
                
                // Strip off the INDIR for assignment tree
                #expression = #([ASSIGN, "assign"], lexpr_AST.getFirstChild(), #rexpr);                
            }
            else
                #expression = #lexpr;
    }
    ;
    
////////////////////////////////////////////////////////////////////////////////
// Each operator (or class of operators) gets its own rule, which also enforces
//  the operator precedence rules in the grammar rather than frigging with
//  %prec or similar.  
////////////////////////////////////////////////////////////////////////////////

or_expr
    : and_expr ( OR^ and_expr )*
    ;
    
and_expr
    : bor_expr ( AND^ bor_expr )*
    ;
    
bor_expr
    : bxor_expr ( BOR^ bxor_expr )*
    ;
    
bxor_expr
    : band_expr ( BXOR^ band_expr )*
    ;
   
band_expr
    : eq_expr ( BAND^ eq_expr )*
    ;
     
eq_expr
    : rel_expr ( ( EQ^ | NE^ ) rel_expr )*
    ;
    
rel_expr
    : shift_expr ( ( LTHAN^ | GTHAN^ ) shift_expr )*
    ;
    
shift_expr
    : plus_expr ( ( SHL^ | SHR^ ) plus_expr )*
    ;
    
plus_expr
    : mult_expr ( ( PLUS^ | MINUS^ ) mult_expr )*
    ;
    
mult_expr
    : unary_expr ( ( TIMES^ | DIVIDE^ | MOD^ ) unary_expr )*
    ;
    
unary_expr
    : ( NOT^ | COMP^ | MINUS^ )? primary_expr
    ;
    
primary_expr
    : INTEGER
    | CHAR
    | IDENT { #primary_expr = #([INDIR, "indir"], #primary_expr ) ; }
    |! aid:IDENT LBRACKET! idx:expression RBRACKET!
                { #primary_expr = #([INDIR, "indir"], #([ARRAY, "array"], #([INDIR, "indir"], #aid ), #idx ) ); }
    | IDENT LPAREN! ( expression ( COMMA! expression )*  )? RPAREN! 
                { #primary_expr = #([FUNCTION, "function"], #primary_expr) ; }
    | LPAREN! expression RPAREN!
    ;



    
////////////////////////////////////////////////////////////////////////////////
// Lexer
////////////////////////////////////////////////////////////////////////////////

class ElisaLexer extends Lexer;
options
{
    k = 3;
    
	charVocabulary = '\3'..'\377';

    caseSensitive = true;           // lower and upper case is significant
    caseSensitiveLiterals = true;   // literals are case sensitive
    testLiterals = false;           // do not check the tokens table by default
}

tokens
{
	KW_RETURN  = "return";
	KW_IF      = "if";
	KW_ELSE    = "else";
	KW_WHILE   = "while";

	KW_INT     = "int";
}

LPAREN:     '('  ;
RPAREN:     ')'  ;
COMMA:      ','  ;
SEMI:       ';'  ;
LBRACKET:   '['  ;
RBRACKET:   ']'  ;
LCURLY:     '{'  ;
RCURLY:     '}'  ;

BAND:       '&'  ;
BOR:        '|'  ;
BXOR:       '^'  ;

SHL:        "<<" ;
SHR:        ">>" ;

ASSIGN:     '='  ;
NOT:        '!'  ;
AND:        "&&" ;
OR:         "||" ;
EQ:         "==" ;
NE:         "!=" ;
LTHAN:      "<"  ;
GTHAN:      ">"  ;

PLUS:       '+'  ;
MINUS:      '-'  ;
TIMES:      '*'  ;
DIVIDE:     '/'  ;
MOD:        '%'  ;
COMP:       '~'  ;

INTEGER
    : (DIGIT)+
    ;
    
CHAR
    : '\'' ( ESC | ~'\'' ) '\''
    ;
      
protected 
ESC
    : '\\' ( 'n' | '\'' | '"' )
    ;
    
IDENT
options
{
	testLiterals = true;
}
    : ( LOWER | UPPER | SPECIAL ) ( LOWER | UPPER | DIGIT | SPECIAL )*
    ;

protected
DIGIT : ( '0' .. '9' ) ;

protected
LOWER : ( 'a' .. 'z' ) ;

protected
UPPER : ( 'A' .. 'Z' ) ;

protected
SPECIAL : '_' ;

////////////////////////////////////////////////////////////////////////////////
// Whitespace includes newlines and single-line C#-style comments  
////////////////////////////////////////////////////////////////////////////////

WS	: ( ' '
	|   '\t'
	|   '\f'
	|   '\n'
	|   '\r'
	) { _ttype = Token.SKIP; }
	;

SL_COMMENT
    : "//" (~'\n')* '\n' { _ttype = Token.SKIP; }
    ; 
	
////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////////////////////////
// Code Generator
//
// Walks over the program AST emitting instructions into whatever target code
//  generator we are given when initialised.
//
////////////////////////////////////////////////////////////////////////////////

class ElisaCodeGenerator extends TreeParser;
{
    private Symboltable     symtab;
    private ArrayList       locals;
    private ArrayList       globals;
    private uint            label;
    private bool            Fverbose;
    private uint            exitlabel;
    private bool            needsReturn;
    
    private CodeGen         target;
    
    public CodeGen Target {
        set { target = value; }
    }
    
    public bool Verbose {
        set { Fverbose = value; }
    }
        
    public static int max( int a, int b ) { return ( a > b ? a : b ); }
    
    // The C# answer to function pointers is the "delegate".  So here is one:   
    
    public delegate void relOp( uint l );

    // We use it here to simplify the code for relational operators
        
    public void doRelational( relOp op, relOp invop, uint tlab, uint flab )
    {
        if ( tlab > 0 )
        {
            op( tlab );
            if ( flab > 0 )
                target.emit_branch( flab );
        }
        else if ( flab > 0 )
        {
            invop( flab );
            if ( tlab > 0 )
                target.emit_branch( tlab );
        }
        else
        {
            tlab = label++;
            flab = label++;
            
            op( tlab );

            target.emit_iconst( 0 );
            target.emit_branch( flab );            
            target.emit_label( tlab );
            target.emit_iconst( 1 );            
            target.emit_label( flab );
        }
    }
    
    // After arithmetic operators we optionally convert them
    //  into booleans (0 = false, 1 = true) with this method:
    
    public void mkPredicate( uint tlab, uint flab )
    {
        if ( tlab > 0 )
        {
            target.emit_brnz( tlab );
            if ( flab > 0 )
                target.emit_branch( flab );
        }
        else if ( flab > 0 )
        {
            target.emit_brz( flab );
            if ( tlab > 0 )
                target.emit_branch( tlab );
        }
    }
    
    // Sometimes we want logical ops to compute
    //  values, and not jump somewhere.  This function does
    //  just that.
    
    public void mkBool( uint tlab, uint flab )
    {
        uint endlab = label++;
                
        target.emit_label( flab );
        target.emit_iconst( 0 );
        target.emit_branch( endlab );
        target.emit_label( tlab );
        target.emit_iconst( 1 );
        target.emit_label( endlab );
    }
    
    // Sometimes, a constant is actually a jump.
    
    public void doConst( int ival, uint tlab, uint flab )
    {
        if ( flab == 0 && tlab == 0 )
            target.emit_iconst( ival );
        else if ( tlab > 0 && ival != 0 )
            target.emit_branch( tlab );
        else if ( flab > 0 && ival == 0 )
            target.emit_branch( flab );
    }
}

////////////////////////////////////////////////////////////////////////////////
//
// Top level walker opens target file and emits boilerplate ready for emitting
//   global declarations (vars and functions).
//
////////////////////////////////////////////////////////////////////////////////

program 
        {    
            target.Open();
            
            symtab  = new Symboltable();   // Open up global symbol table
            locals  = null;
            globals = new ArrayList();
            
            // Add built-in functions to global symbol table
            symtab.add( new Symbol( "put", new Type( Type.T.FUNC, 1, new Type( Type.T.INT, 1, null ) ) ) );
            symtab.add( new Symbol( "get", new Type( Type.T.FUNC, 1, new Type( Type.T.INT, 1, null ) ) ) );
       }
    : #(PROGRAM (declaration)+ ) 
        {   
            target.Globals( globals );
            target.Close();   
        }
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// Declarations are the most fun, since we deal with both global variables (easy)
//  and functions (difficult).  As the AST is traversed, we add all local variables
//  to a list for later.  They are then emitted into the target file when we have
//  finished with everything else.
//
////////////////////////////////////////////////////////////////////////////////
    
declaration
{
    Symbol s;
    ArrayList plist = null;
} 
    : #(DECLARATION s=declarator { 
            globals.Add( s );
            s.xName = "EL_" + s.Name;
    } )
    | #(FUNCTION_DECL s=declarator {
            if ( s.Type.Ty != Type.T.INT )
            {
                Console.Error.WriteLine( "Bad type for function '" + s.Name + "', must be int." );
                throw new System.Exception();
            }
    
            // Prepend FUNC type onto type list
            s.Type = new Type( Type.T.FUNC, 0, s.Type );
            
            if ( Fverbose )
            {
                Console.Write( "Function " + s.Name + "() has type '" );
                s.Type.dump();
                Console.WriteLine("'");
            }
            
            // Every function other than Main gets decorated with the prefix 'EL_'
            if ( s.Name == "Main" )
                s.xName = s.Name;
            else
                s.xName = "EL_" + s.Name;
            
            // Create symbol table for function parameters
            symtab = new Symboltable( symtab );
            
    } ( plist=parameter_list )? {
    
            target.openFunction( s, plist );
                                    
            locals      = new ArrayList();                        
            exitlabel   = label++;
            needsReturn = true;
            
            if ( Fverbose )
                symtab.dump();
            
    } stmt_block { 
            if ( needsReturn )
            {
                Console.Error.WriteLine( "Warning: missing return in function " + s.Name + "(), return 0 assumed." );
                target.emit_iconst( 0 );
            }
            
            target.emit_label( exitlabel );
            target.emit_ret();            
            target.closeFunction( locals );
            
            symtab = symtab.Parent;                   // remove parameter table
    } )
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// Consume declarators, adding ARRAY dimensions as necessary.
//
////////////////////////////////////////////////////////////////////////////////

declarator returns [Symbol s]
{
    s = null;
}
    : #(DECL KW_INT id:IDENT { 
            s = new Symbol( id.getText(), new Type() ); 
            symtab.add( s ); 
    } ( i:INTEGER { 
            s.Type = new Type( Type.T.ARRAY, 
                                 System.Convert.ToInt32(i.getText()), 
                                 s.Type );
    } )? )
    ;
        
////////////////////////////////////////////////////////////////////////////////
//
// Walk along a list of parameters, adding them to the parameter symbol table
//
////////////////////////////////////////////////////////////////////////////////

parameter_list returns [ ArrayList plist ]
{
    Symbol s;
    uint argnum = 0;
    plist = new ArrayList();
}
    : #(PARAMETER_LIST ( s=declarator { 
            s.Offset = argnum++; 
            s.Param = true;
            plist.Add( s );
    } )+ )
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// Statement blocks have zero or more declarations, followed by zero or more
//  statements (which may also include statement blocks).
//
////////////////////////////////////////////////////////////////////////////////

stmt_block
{
    Symbol s;
}
    : #(STMT_BLOCK { 
            symtab = new Symboltable( symtab );
    } ( s=declarator { 
            locals.Add(s);
            target.announceLocal( s );
    } )* { if ( Fverbose ) symtab.dump(); } ( statement )* { symtab = symtab.Parent; } )
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// Top-level statement, from which all the specific statements then get called.
// About the only interesting thing here is to set the needsReturn flag on
//  every statment _except_ return.
//
////////////////////////////////////////////////////////////////////////////////

statement
{
    Type ty;
}
    : ty=expression[0,0]  { target.emit_pop(); needsReturn = true; }
    | if_stmt                   { needsReturn = true; }
    | while_stmt                { needsReturn = true; }
    | stmt_block                { needsReturn = true; }
    | return_stmt               { needsReturn = false; }
    | #(NULL_STMT {;})
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// IF statement has two contructions, one without an ELSE clause, and one with.
//  We use two rules to generate better code, avoiding redundant branches to
//  end labels when there is no ELSE clause.
//
////////////////////////////////////////////////////////////////////////////////

if_stmt
{
    Type ty;
    uint flab   = label++;
    uint endlab = label++;
}
    : #(IF_STMT ty=expression[0,endlab] statement {
            target.emit_label( endlab );
    } )
    
    | #(IF_ELSE_STMT ty=expression[0,flab] statement {
            target.emit_branch( endlab );
            target.emit_label( flab );            
    } statement {
            target.emit_label( endlab );
    } )
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// WHILE statement iterates over the statement body while the expression is true.
//
////////////////////////////////////////////////////////////////////////////////

while_stmt
{
    Type ty;
    uint toplab = label++;
    uint btmlab = label++;
}
    : #(KW_WHILE { target.emit_label( toplab ); } ty=expression[0,btmlab] statement )
    {
            target.emit_branch( toplab );
            target.emit_label( btmlab );
    }
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// RETURN computes expression, which leaves the return value at the top of the stack,
//   then branch to the exit label.
//
////////////////////////////////////////////////////////////////////////////////

return_stmt
{
    Type ty;
}
    : #(KW_RETURN ty=expression[0,0] )
    { 
            target.emit_branch( exitlabel );
    }
    ;
    
////////////////////////////////////////////////////////////////////////////////
//
// Expressions are interesting creatures.  They can be lvalues or rvalues,
//  and sometimes we're not interested in the value itself, only whether it
//  it is false (== 0) or true (!= 0).
//
// The tricks we employ here are quite simple:
//
//   "tlab" and "flab" are true and false labels respectively.  If both are
//   0 then we want a value.  If at least one of of them is non-zero then we do
//   a conditional branch on the result of the expression.
//
////////////////////////////////////////////////////////////////////////////////

expression [ uint tlab, uint flab ] returns [ Type exprty ]
{
    Type   lty, rty;
    Symbol s;
    uint   midlab;
    bool   mkbool;
    
    lty = rty = exprty = new Type( Type.T.INT, 1, null );
}
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ASSIGN
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    : #(ASSIGN lty = lid:expression[0,0] rty = rid:expression[0,0]
    {
            target.emit_dup();
            
            if ( lid.Type == ARRAY )
            {
                target.emit_stelem();
            }
            else if ( lid.Type == IDENT )
            {
                s = symtab.find( lid.getText() );
                
                if ( s.Scope == 0 )
                {
                    String addr = "int32";
                    
                    if ( s.Type.Ty == Type.T.ARRAY )
                        addr += "[]";
                        
                    target.emit_stglobal( addr + " " + target.BaseName + "::" + s.xName );
                }
                else if ( s.Scope == 1 )
                    target.emit_starg( s.Offset );
                else
                    target.emit_stloc( s.Offset );
            }
            else
            {
                Console.Error.WriteLine( "Error: bad lvalue" );
                throw new System.Exception();            
            }

            exprty = rty;
    } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  LOGICAL OR
    //  
    ////////////////////////////////////////////////////////////////////////////

    | #(OR  { mkbool = false;
              midlab = label++;
            if ( flab == 0 && tlab == 0 )
            {
                mkbool = true;
                flab   = label++;
                tlab   = label++;
            }
    }     
    lty=expression[tlab,midlab] 
    {
            target.emit_label( midlab );
    }    
    rty=expression[tlab,flab] )
    {
            if ( mkbool )
                mkBool( tlab, flab );

            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  LOGICAL AND
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(AND { mkbool = false;
              midlab = label++;
            if ( flab == 0 && tlab == 0 )
            {
                mkbool = true;
                flab   = label++;
                tlab   = label++;
            }
    }     
    lty=expression[midlab,flab] 
    {
            target.emit_label( midlab );
    }    
    rty=expression[tlab,flab] )
    {
            if ( mkbool )
                mkBool( tlab, flab );

            exprty = lty;
    }

    ////////////////////////////////////////////////////////////////////////////
    //
    //  LOGICAL inversion
    //
    //  The logical inversion is done by swapping tlab and flab for the
    //    subexpression.
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(NOT { mkbool = false;
            if ( flab == 0 && tlab == 0 )
            {
                mkbool = true;
                flab   = label++;
                tlab   = label++;
            }
    }
    lty=expression[flab,tlab] )
    {
            if ( mkbool )
                mkBool( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  BITWISE OR
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(BOR lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_bor();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  BITWISE XOR
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(BXOR lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_bxor();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  BITWISE AND
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(BAND lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_band();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  BITWISE inversion (complement)
    //
    ////////////////////////////////////////////////////////////////////////////
    
    | #(COMP lty=expression[0,0] )
    {
            target.emit_not(); 
            mkPredicate( tlab, flab );                
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  RELATIONAL ==
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(EQ lty=expression[0,0] rty=expression[0,0] )
    { 
            doRelational( new relOp( target.emit_beq ), new relOp( target.emit_bne ), tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  RELATIONAL !=
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(NE lty=expression[0,0] rty=expression[0,0] )
    {
            doRelational( new relOp( target.emit_bne ), new relOp( target.emit_beq ), tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  RELATIONAL <
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(LTHAN lty=expression[0,0] rty=expression[0,0] )
    {
            doRelational( new relOp( target.emit_blt ), new relOp( target.emit_bge ), tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  RELATIONAL >
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(GTHAN  lty=expression[0,0] rty=expression[0,0] )
    {
            doRelational( new relOp( target.emit_bgt ), new relOp( target.emit_ble ), tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  SHIFT <<
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(SHL lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_shl();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  SHIFT >>
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(SHR lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_shr();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARITHMETIC +
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(PLUS lty=expression[0,0] rty=expression[0,0] )
    { 
            target.emit_add();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARITHMETIC - (both unary and binary)
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(MINUS { bool isunary = true; } lty=expression[0,0] 
        ( rty=expression[0,0] { isunary = false; } )? )
    {
            if ( isunary )
                target.emit_neg();
            else
                target.emit_sub();
                
            mkPredicate( tlab, flab );
            exprty = lty;
    }

    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARITHMETIC multiply
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(TIMES lty=expression[tlab,flab] rty=expression[tlab,flab] )
    { 
            target.emit_mul();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARITHMETIC divide
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(DIVIDE lty=expression[tlab,flab] rty=expression[tlab,flab] )
    { 
            target.emit_div();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARITHMETIC modulo
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(MOD lty=expression[tlab,flab] rty=expression[tlab,flab] )
    { 
            target.emit_mod();
            mkPredicate( tlab, flab );
            exprty = lty;
    }
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  INTEGER
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(Li:INTEGER
    {
            doConst( Convert.ToInt32( Li.getText() ), tlab, flab );
            exprty = new Type( Type.T.INT, 1, null );
    } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  CHAR (including some escaped char codes as well)
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(Lc:CHAR 
    {
            int cval;
            
            if ( Lc.getText()[1] != '\\' )
                cval = Convert.ToInt32( Lc.getText()[1] );
            else
            {
                if ( Lc.getText()[2] == 'n' )
                    cval = 0x0a;
                else if ( Lc.getText()[2] == '\'' )
                    cval = 0x27;
                else if ( Lc.getText()[2] == '\"' )
                    cval = 0x22;
                else
                {
                    Console.Error.WriteLine( "Invalid char sequence " + Lc.getText() );
                    throw new System.Exception();
                }
            }
            
            doConst( cval, tlab, flab );
            exprty = new Type( Type.T.INT, 1, null );
    } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  IDENTIFIER
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #( Lid:IDENT { exprty = symtab.find( Lid.getText() ).Type; } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  INDIR
    //
    ////////////////////////////////////////////////////////////////////////////
    
    | #(INDIR lty = iid:expression[0,0] { 
            if ( iid.Type == ARRAY )
            {
                // Load from array and strip off ARRAY from result type
                target.emit_ldelem();
                lty = lty.Of;
            }
            else if ( iid.Type == IDENT )
            {
                s = symtab.find( iid.getText() );
                
                if ( s.Scope == 0 )
                {
                    String addr = "int32";
                    
                    if ( s.Type.Ty == Type.T.ARRAY )
                        addr += "[]";
                        
                    target.emit_ldglobal( addr + " " + target.BaseName + "::" + s.xName );
                }
                else if ( s.Scope == 1 )
                    target.emit_ldarg( s.Offset );
                else
                    target.emit_ldloc( s.Offset );
            }
            else
            {
                Console.Error.WriteLine( "Error: bad rvalue" );
                throw new System.Exception();            
            }
            
            mkPredicate( tlab, flab );    
            exprty = lty; 
    } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  ARRAY
    //  
    ////////////////////////////////////////////////////////////////////////////
    
    | #(ARRAY lty=expression[0,0] {
            if ( lty.Ty != Type.T.ARRAY )
            {
                Console.WriteLine( "Error: array index mismatch" );
                throw new System.Exception();            
            }            
    } rty=expression[0,0] {
            exprty = lty;
    } )
    
    ////////////////////////////////////////////////////////////////////////////
    //
    //  FUNCTION CALL
    //  
    ////////////////////////////////////////////////////////////////////////////

    | #(FUNCTION fid:IDENT { 
            ArrayList arglist = new ArrayList(); 
    } ( rty=expression[0,0] { 
            arglist.Add(rty); 
    } )* ) {
            Symbol fs = symtab.find( fid.getText() );
            
            // Catch special cases
            if ( fid.getText() == "put" )
            {
                target.PUT();
            }
            else if ( fid.getText() == "get" )
            {
                target.GET();
            }
            else
            {   
                target.emit_call( "int32 " + target.BaseName + "::" + fs.xName, arglist );
            }
            
            mkPredicate( tlab, flab );
            exprty = fs.Type.Of;
    }    
    ;

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

