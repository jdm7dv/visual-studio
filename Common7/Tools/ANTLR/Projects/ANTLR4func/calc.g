////////////////////////////////////////////////////////////////////////////////
//
//  ANTLR Lexer/Parser/Evaluator for 4-function Calculator
//
//  Written by: Neil Johnson
//
//  File: ANTLR grammar file
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

options {
	language = "CSharp";
}

////////////////////////////////////////////////////////////////////////////////
//  Parser
////////////////////////////////////////////////////////////////////////////////

class CalcParser extends Parser;
options {
	buildAST = true;	// uses CommonAST by default
}

expr
    :   subexpr SEMI!
    ;

subexpr
    :   addexpr (MINUS^ addexpr)*
    ;

addexpr
	:	mulexpr (PLUS^ mulexpr)*
	;

mulexpr
    :   divexpr (STAR^ divexpr)*
    ;

divexpr
	:	atom (DIVIDE^ atom)*
	;

atom:	INT
    |   LPAREN! subexpr RPAREN!
	;

////////////////////////////////////////////////////////////////////////////////
// Lexer
////////////////////////////////////////////////////////////////////////////////

class CalcLexer extends Lexer;

WS	:	(' '
	|	'\t'
	|	'\n'
	|	'\r')
		{ _ttype = Token.SKIP; }
	;

LPAREN:	'('
	;

RPAREN:	')'
	;

STAR:	'*'
	;

DIVIDE: '/'
    ;

PLUS:	'+'
	;
	
MINUS:  '-'
    ;

SEMI:	';'
	;

protected
DIGIT
	:	'0'..'9'
	;

INT	:	(DIGIT)+
	;

////////////////////////////////////////////////////////////////////////////////
// Evaluator (tree walker
////////////////////////////////////////////////////////////////////////////////

class CalcTreeWalker extends TreeParser;

expr returns [float r]
{
	float a,b;
	r=0;
}
	:	#(PLUS   a=expr b=expr)	{r = a+b;}
	|   #(MINUS  a=expr b=expr) {r = a-b;}
	|	#(STAR   a=expr b=expr)	{r = a*b;}
	|   #(DIVIDE a=expr b=expr) {r = a/b;}
	|   #(LPAREN a=expr RPAREN) {r = a;}
	|	i:INT			{r = Convert.ToSingle(i.getText());}
	;
	
////////////////////////////////////////////////////////////////////////////////
