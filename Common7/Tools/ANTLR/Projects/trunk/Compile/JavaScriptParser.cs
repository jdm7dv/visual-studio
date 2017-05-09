// $ANTLR 3.2 Sep 23, 2009 12:02:23 JavaScript.g 2012-10-24 03:02:09

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

 
	using Zinj; 


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

public partial class JavaScriptParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"STATEMENTLIST", 
		"EXPRESSIONSTATEMENT", 
		"VARDECL", 
		"CALL", 
		"FUNCTIONDECL", 
		"FUNCTIONEXPR", 
		"NIL", 
		"LT", 
		"Identifier", 
		"StringLiteral", 
		"NumericLiteral", 
		"RegexLiteral", 
		"Comment", 
		"LineComment", 
		"DoubleStringCharacter", 
		"SingleStringCharacter", 
		"EscapeSequence", 
		"CharacterEscapeSequence", 
		"HexEscapeSequence", 
		"UnicodeEscapeSequence", 
		"SingleEscapeCharacter", 
		"NonEscapeCharacter", 
		"EscapeCharacter", 
		"DecimalDigit", 
		"HexDigit", 
		"DecimalLiteral", 
		"HexIntegerLiteral", 
		"ExponentPart", 
		"IdentifierStart", 
		"IdentifierPart", 
		"UnicodeLetter", 
		"UnicodeDigit", 
		"UnicodeConnectorPunctuation", 
		"UnicodeCombiningMark", 
		"WhiteSpace", 
		"'function'", 
		"'{'", 
		"'}'", 
		"'('", 
		"','", 
		"')'", 
		"'var'", 
		"'='", 
		"';'", 
		"'if'", 
		"'else'", 
		"'do'", 
		"'while'", 
		"'for'", 
		"'in'", 
		"'continue'", 
		"'break'", 
		"'return'", 
		"'with'", 
		"':'", 
		"'switch'", 
		"'case'", 
		"'default'", 
		"'throw'", 
		"'try'", 
		"'catch'", 
		"'finally'", 
		"'new'", 
		"'['", 
		"']'", 
		"'.'", 
		"'*='", 
		"'/='", 
		"'%='", 
		"'+='", 
		"'-='", 
		"'<<='", 
		"'>>='", 
		"'>>>='", 
		"'&='", 
		"'^='", 
		"'|='", 
		"'?'", 
		"'||'", 
		"'&&'", 
		"'|'", 
		"'^'", 
		"'&'", 
		"'=='", 
		"'!='", 
		"'==='", 
		"'!=='", 
		"'<'", 
		"'>'", 
		"'<='", 
		"'>='", 
		"'instanceof'", 
		"'<<'", 
		"'>>'", 
		"'>>>'", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'delete'", 
		"'void'", 
		"'typeof'", 
		"'++'", 
		"'--'", 
		"'~'", 
		"'!'", 
		"'this'", 
		"'null'", 
		"'true'", 
		"'false'"
    };

    public const int LT = 11;
    public const int FUNCTIONEXPR = 9;
    public const int DecimalDigit = 27;
    public const int EOF = -1;
    public const int Identifier = 12;
    public const int SingleStringCharacter = 19;
    public const int T__93 = 93;
    public const int T__94 = 94;
    public const int T__91 = 91;
    public const int T__92 = 92;
    public const int T__90 = 90;
    public const int Comment = 16;
    public const int SingleEscapeCharacter = 24;
    public const int UnicodeLetter = 34;
    public const int ExponentPart = 31;
    public const int WhiteSpace = 38;
    public const int T__99 = 99;
    public const int T__98 = 98;
    public const int T__97 = 97;
    public const int T__96 = 96;
    public const int UnicodeCombiningMark = 37;
    public const int T__95 = 95;
    public const int UnicodeDigit = 35;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int NumericLiteral = 14;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int EXPRESSIONSTATEMENT = 5;
    public const int IdentifierStart = 32;
    public const int DoubleStringCharacter = 18;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int T__88 = 88;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int NIL = 10;
    public const int T__70 = 70;
    public const int CALL = 7;
    public const int CharacterEscapeSequence = 21;
    public const int RegexLiteral = 15;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int EscapeSequence = 20;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int FUNCTIONDECL = 8;
    public const int UnicodeConnectorPunctuation = 36;
    public const int T__78 = 78;
    public const int T__77 = 77;
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int HexEscapeSequence = 22;
    public const int T__63 = 63;
    public const int T__114 = 114;
    public const int LineComment = 17;
    public const int VARDECL = 6;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int HexDigit = 28;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int T__107 = 107;
    public const int T__108 = 108;
    public const int T__109 = 109;
    public const int T__59 = 59;
    public const int T__103 = 103;
    public const int T__104 = 104;
    public const int T__105 = 105;
    public const int T__106 = 106;
    public const int T__111 = 111;
    public const int T__110 = 110;
    public const int T__113 = 113;
    public const int EscapeCharacter = 26;
    public const int T__112 = 112;
    public const int T__50 = 50;
    public const int IdentifierPart = 33;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int UnicodeEscapeSequence = 23;
    public const int T__102 = 102;
    public const int T__101 = 101;
    public const int T__100 = 100;
    public const int DecimalLiteral = 29;
    public const int STATEMENTLIST = 4;
    public const int StringLiteral = 13;
    public const int T__39 = 39;
    public const int HexIntegerLiteral = 30;
    public const int NonEscapeCharacter = 25;

    // delegates
    // delegators



        public JavaScriptParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public JavaScriptParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return JavaScriptParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "JavaScript.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // JavaScript.g:24:1: program : ( LT )* ( sourceElements ( LT )* | ) EOF ;
    public JavaScriptParser.program_return program() // throws RecognitionException [1]
    {   
        JavaScriptParser.program_return retval = new JavaScriptParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT1 = null;
        IToken LT3 = null;
        IToken EOF4 = null;
        JavaScriptParser.sourceElements_return sourceElements2 = default(JavaScriptParser.sourceElements_return);


        object LT1_tree=null;
        object LT3_tree=null;
        object EOF4_tree=null;

        try 
    	{
            // JavaScript.g:25:2: ( ( LT )* ( sourceElements ( LT )* | ) EOF )
            // JavaScript.g:25:4: ( LT )* ( sourceElements ( LT )* | ) EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// JavaScript.g:25:6: ( LT )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == LT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // JavaScript.g:25:6: LT
            			    {
            			    	LT1=(IToken)Match(input,LT,FOLLOW_LT_in_program67); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// JavaScript.g:25:9: ( sourceElements ( LT )* | )
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( ((LA3_0 >= Identifier && LA3_0 <= RegexLiteral) || (LA3_0 >= 39 && LA3_0 <= 40) || LA3_0 == 42 || LA3_0 == 45 || (LA3_0 >= 47 && LA3_0 <= 48) || (LA3_0 >= 50 && LA3_0 <= 52) || (LA3_0 >= 54 && LA3_0 <= 57) || LA3_0 == 59 || (LA3_0 >= 62 && LA3_0 <= 63) || (LA3_0 >= 66 && LA3_0 <= 67) || (LA3_0 >= 99 && LA3_0 <= 100) || (LA3_0 >= 104 && LA3_0 <= 114)) )
            	{
            	    alt3 = 1;
            	}
            	else if ( (LA3_0 == EOF) )
            	{
            	    alt3 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // JavaScript.g:25:10: sourceElements ( LT )*
            	        {
            	        	PushFollow(FOLLOW_sourceElements_in_program72);
            	        	sourceElements2 = sourceElements();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sourceElements2.Tree);
            	        	// JavaScript.g:25:27: ( LT )*
            	        	do 
            	        	{
            	        	    int alt2 = 2;
            	        	    int LA2_0 = input.LA(1);

            	        	    if ( (LA2_0 == LT) )
            	        	    {
            	        	        alt2 = 1;
            	        	    }


            	        	    switch (alt2) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:25:27: LT
            	        			    {
            	        			    	LT3=(IToken)Match(input,LT,FOLLOW_LT_in_program74); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop2;
            	        	    }
            	        	} while (true);

            	        	loop2:
            	        		;	// Stops C# compiler whining that label 'loop2' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:25:41: 
            	        {
            	        }
            	        break;

            	}

            	EOF4=(IToken)Match(input,EOF,FOLLOW_EOF_in_program83); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class sourceElements_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sourceElements"
    // JavaScript.g:28:1: sourceElements : statement ( ( LT )* statement )* -> ^( STATEMENTLIST ( statement )* ) ;
    public JavaScriptParser.sourceElements_return sourceElements() // throws RecognitionException [1]
    {   
        JavaScriptParser.sourceElements_return retval = new JavaScriptParser.sourceElements_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT6 = null;
        JavaScriptParser.statement_return statement5 = default(JavaScriptParser.statement_return);

        JavaScriptParser.statement_return statement7 = default(JavaScriptParser.statement_return);


        object LT6_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // JavaScript.g:29:2: ( statement ( ( LT )* statement )* -> ^( STATEMENTLIST ( statement )* ) )
            // JavaScript.g:29:4: statement ( ( LT )* statement )*
            {
            	PushFollow(FOLLOW_statement_in_sourceElements96);
            	statement5 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statement.Add(statement5.Tree);
            	// JavaScript.g:29:14: ( ( LT )* statement )*
            	do 
            	{
            	    int alt5 = 2;
            	    alt5 = dfa5.Predict(input);
            	    switch (alt5) 
            		{
            			case 1 :
            			    // JavaScript.g:29:15: ( LT )* statement
            			    {
            			    	// JavaScript.g:29:15: ( LT )*
            			    	do 
            			    	{
            			    	    int alt4 = 2;
            			    	    int LA4_0 = input.LA(1);

            			    	    if ( (LA4_0 == LT) )
            			    	    {
            			    	        alt4 = 1;
            			    	    }


            			    	    switch (alt4) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:29:15: LT
            			    			    {
            			    			    	LT6=(IToken)Match(input,LT,FOLLOW_LT_in_sourceElements99); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT6);


            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop4;
            			    	    }
            			    	} while (true);

            			    	loop4:
            			    		;	// Stops C# compiler whining that label 'loop4' has no statements

            			    	PushFollow(FOLLOW_statement_in_sourceElements102);
            			    	statement7 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement7.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 29:31: -> ^( STATEMENTLIST ( statement )* )
            	{
            	    // JavaScript.g:29:34: ^( STATEMENTLIST ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new TopStatementList(STATEMENTLIST), root_1);

            	    // JavaScript.g:29:68: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sourceElements"

    public class functionDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionDeclaration"
    // JavaScript.g:32:1: functionDeclaration : f= 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}' -> ^( FUNCTIONDECL[$f] ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) Identifier ) ) ;
    public JavaScriptParser.functionDeclaration_return functionDeclaration() // throws RecognitionException [1]
    {   
        JavaScriptParser.functionDeclaration_return retval = new JavaScriptParser.functionDeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken f = null;
        IToken e = null;
        IToken LT8 = null;
        IToken Identifier9 = null;
        IToken LT10 = null;
        IToken LT12 = null;
        IToken char_literal13 = null;
        IToken LT14 = null;
        IToken LT16 = null;
        IToken LT18 = null;
        JavaScriptParser.formalParameterList_return formalParameterList11 = default(JavaScriptParser.formalParameterList_return);

        JavaScriptParser.statement_return statement15 = default(JavaScriptParser.statement_return);

        JavaScriptParser.statement_return statement17 = default(JavaScriptParser.statement_return);


        object f_tree=null;
        object e_tree=null;
        object LT8_tree=null;
        object Identifier9_tree=null;
        object LT10_tree=null;
        object LT12_tree=null;
        object char_literal13_tree=null;
        object LT14_tree=null;
        object LT16_tree=null;
        object LT18_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_formalParameterList = new RewriteRuleSubtreeStream(adaptor,"rule formalParameterList");
        try 
    	{
            // JavaScript.g:33:2: (f= 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}' -> ^( FUNCTIONDECL[$f] ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) Identifier ) ) )
            // JavaScript.g:33:4: f= 'function' ( LT )* Identifier ( LT )* formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}'
            {
            	f=(IToken)Match(input,39,FOLLOW_39_in_functionDeclaration129); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(f);

            	// JavaScript.g:33:17: ( LT )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == LT) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // JavaScript.g:33:17: LT
            			    {
            			    	LT8=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration131); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT8);


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	Identifier9=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDeclaration134); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier9);

            	// JavaScript.g:33:32: ( LT )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == LT) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // JavaScript.g:33:32: LT
            			    {
            			    	LT10=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration136); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT10);


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	PushFollow(FOLLOW_formalParameterList_in_functionDeclaration139);
            	formalParameterList11 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_formalParameterList.Add(formalParameterList11.Tree);
            	// JavaScript.g:33:56: ( LT )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == LT) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // JavaScript.g:33:56: LT
            			    {
            			    	LT12=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration141); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT12);


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	char_literal13=(IToken)Match(input,40,FOLLOW_40_in_functionDeclaration144); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal13);

            	// JavaScript.g:33:64: ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* )
            	int alt12 = 2;
            	alt12 = dfa12.Predict(input);
            	switch (alt12) 
            	{
            	    case 1 :
            	        // JavaScript.g:33:65: ( ( LT )* '}' )=> ()
            	        {
            	        	// JavaScript.g:33:76: ()
            	        	// JavaScript.g:33:77: 
            	        	{
            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:33:81: ( LT )* statement ( ( LT )* statement )*
            	        {
            	        	// JavaScript.g:33:81: ( LT )*
            	        	do 
            	        	{
            	        	    int alt9 = 2;
            	        	    int LA9_0 = input.LA(1);

            	        	    if ( (LA9_0 == LT) )
            	        	    {
            	        	        alt9 = 1;
            	        	    }


            	        	    switch (alt9) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:33:81: LT
            	        			    {
            	        			    	LT14=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration159); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT14);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop9;
            	        	    }
            	        	} while (true);

            	        	loop9:
            	        		;	// Stops C# compiler whining that label 'loop9' has no statements

            	        	PushFollow(FOLLOW_statement_in_functionDeclaration162);
            	        	statement15 = statement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_statement.Add(statement15.Tree);
            	        	// JavaScript.g:33:95: ( ( LT )* statement )*
            	        	do 
            	        	{
            	        	    int alt11 = 2;
            	        	    alt11 = dfa11.Predict(input);
            	        	    switch (alt11) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:33:96: ( LT )* statement
            	        			    {
            	        			    	// JavaScript.g:33:96: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt10 = 2;
            	        			    	    int LA10_0 = input.LA(1);

            	        			    	    if ( (LA10_0 == LT) )
            	        			    	    {
            	        			    	        alt10 = 1;
            	        			    	    }


            	        			    	    switch (alt10) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:33:96: LT
            	        			    			    {
            	        			    			    	LT16=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration165); if (state.failed) return retval; 
            	        			    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT16);


            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop10;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop10:
            	        			    		;	// Stops C# compiler whining that label 'loop10' has no statements

            	        			    	PushFollow(FOLLOW_statement_in_functionDeclaration168);
            	        			    	statement17 = statement();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_statement.Add(statement17.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop11;
            	        	    }
            	        	} while (true);

            	        	loop11:
            	        		;	// Stops C# compiler whining that label 'loop11' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:33:113: ( LT )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == LT) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // JavaScript.g:33:113: LT
            			    {
            			    	LT18=(IToken)Match(input,LT,FOLLOW_LT_in_functionDeclaration173); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT18);


            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements

            	e=(IToken)Match(input,41,FOLLOW_41_in_functionDeclaration178); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(e);



            	// AST REWRITE
            	// elements:          Identifier, statement, formalParameterList
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 34:2: -> ^( FUNCTIONDECL[$f] ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) Identifier ) )
            	{
            	    // JavaScript.g:34:5: ^( FUNCTIONDECL[$f] ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) Identifier ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new functionDeclarationNode(FUNCTIONDECL, f), root_1);

            	    // JavaScript.g:34:49: ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) Identifier )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new functionExpressionNode(FUNCTIONEXPR, f, e), root_2);

            	    adaptor.AddChild(root_2, stream_formalParameterList.NextTree());
            	    // JavaScript.g:34:115: ^( STATEMENTLIST ( statement )* )
            	    {
            	    object root_3 = (object)adaptor.GetNilNode();
            	    root_3 = (object)adaptor.BecomeRoot(new TopStatementList(STATEMENTLIST), root_3);

            	    // JavaScript.g:34:149: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_3, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_2, root_3);
            	    }
            	    adaptor.AddChild(root_2, stream_Identifier.NextNode());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionDeclaration"

    public class functionExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionExpression"
    // JavaScript.g:37:1: functionExpression : f= 'function' ( LT )* ( Identifier ( LT )* | ) formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}' -> ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) ( Identifier )? ) ;
    public JavaScriptParser.functionExpression_return functionExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.functionExpression_return retval = new JavaScriptParser.functionExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken f = null;
        IToken e = null;
        IToken LT19 = null;
        IToken Identifier20 = null;
        IToken LT21 = null;
        IToken LT23 = null;
        IToken char_literal24 = null;
        IToken LT25 = null;
        IToken LT27 = null;
        IToken LT29 = null;
        JavaScriptParser.formalParameterList_return formalParameterList22 = default(JavaScriptParser.formalParameterList_return);

        JavaScriptParser.statement_return statement26 = default(JavaScriptParser.statement_return);

        JavaScriptParser.statement_return statement28 = default(JavaScriptParser.statement_return);


        object f_tree=null;
        object e_tree=null;
        object LT19_tree=null;
        object Identifier20_tree=null;
        object LT21_tree=null;
        object LT23_tree=null;
        object char_literal24_tree=null;
        object LT25_tree=null;
        object LT27_tree=null;
        object LT29_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_formalParameterList = new RewriteRuleSubtreeStream(adaptor,"rule formalParameterList");
        try 
    	{
            // JavaScript.g:38:2: (f= 'function' ( LT )* ( Identifier ( LT )* | ) formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}' -> ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) ( Identifier )? ) )
            // JavaScript.g:38:4: f= 'function' ( LT )* ( Identifier ( LT )* | ) formalParameterList ( LT )* '{' ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* ) ( LT )* e= '}'
            {
            	f=(IToken)Match(input,39,FOLLOW_39_in_functionExpression225); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_39.Add(f);

            	// JavaScript.g:38:17: ( LT )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == LT) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // JavaScript.g:38:17: LT
            			    {
            			    	LT19=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression227); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT19);


            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	// JavaScript.g:38:21: ( Identifier ( LT )* | )
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == Identifier) )
            	{
            	    alt16 = 1;
            	}
            	else if ( (LA16_0 == 42) )
            	{
            	    alt16 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // JavaScript.g:38:22: Identifier ( LT )*
            	        {
            	        	Identifier20=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionExpression231); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier20);

            	        	// JavaScript.g:38:33: ( LT )*
            	        	do 
            	        	{
            	        	    int alt15 = 2;
            	        	    int LA15_0 = input.LA(1);

            	        	    if ( (LA15_0 == LT) )
            	        	    {
            	        	        alt15 = 1;
            	        	    }


            	        	    switch (alt15) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:38:33: LT
            	        			    {
            	        			    	LT21=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression233); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT21);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop15;
            	        	    }
            	        	} while (true);

            	        	loop15:
            	        		;	// Stops C# compiler whining that label 'loop15' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:38:48: 
            	        {
            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_formalParameterList_in_functionExpression241);
            	formalParameterList22 = formalParameterList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_formalParameterList.Add(formalParameterList22.Tree);
            	// JavaScript.g:38:70: ( LT )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == LT) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // JavaScript.g:38:70: LT
            			    {
            			    	LT23=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression243); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT23);


            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	char_literal24=(IToken)Match(input,40,FOLLOW_40_in_functionExpression246); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_40.Add(char_literal24);

            	// JavaScript.g:38:78: ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* )
            	int alt21 = 2;
            	alt21 = dfa21.Predict(input);
            	switch (alt21) 
            	{
            	    case 1 :
            	        // JavaScript.g:38:79: ( ( LT )* '}' )=> ()
            	        {
            	        	// JavaScript.g:38:90: ()
            	        	// JavaScript.g:38:91: 
            	        	{
            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:38:95: ( LT )* statement ( ( LT )* statement )*
            	        {
            	        	// JavaScript.g:38:95: ( LT )*
            	        	do 
            	        	{
            	        	    int alt18 = 2;
            	        	    int LA18_0 = input.LA(1);

            	        	    if ( (LA18_0 == LT) )
            	        	    {
            	        	        alt18 = 1;
            	        	    }


            	        	    switch (alt18) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:38:95: LT
            	        			    {
            	        			    	LT25=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression261); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT25);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop18;
            	        	    }
            	        	} while (true);

            	        	loop18:
            	        		;	// Stops C# compiler whining that label 'loop18' has no statements

            	        	PushFollow(FOLLOW_statement_in_functionExpression264);
            	        	statement26 = statement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_statement.Add(statement26.Tree);
            	        	// JavaScript.g:38:109: ( ( LT )* statement )*
            	        	do 
            	        	{
            	        	    int alt20 = 2;
            	        	    alt20 = dfa20.Predict(input);
            	        	    switch (alt20) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:38:110: ( LT )* statement
            	        			    {
            	        			    	// JavaScript.g:38:110: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt19 = 2;
            	        			    	    int LA19_0 = input.LA(1);

            	        			    	    if ( (LA19_0 == LT) )
            	        			    	    {
            	        			    	        alt19 = 1;
            	        			    	    }


            	        			    	    switch (alt19) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:38:110: LT
            	        			    			    {
            	        			    			    	LT27=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression267); if (state.failed) return retval; 
            	        			    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT27);


            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop19;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop19:
            	        			    		;	// Stops C# compiler whining that label 'loop19' has no statements

            	        			    	PushFollow(FOLLOW_statement_in_functionExpression270);
            	        			    	statement28 = statement();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_statement.Add(statement28.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop20;
            	        	    }
            	        	} while (true);

            	        	loop20:
            	        		;	// Stops C# compiler whining that label 'loop20' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:38:127: ( LT )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == LT) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // JavaScript.g:38:127: LT
            			    {
            			    	LT29=(IToken)Match(input,LT,FOLLOW_LT_in_functionExpression275); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT29);


            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements

            	e=(IToken)Match(input,41,FOLLOW_41_in_functionExpression280); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_41.Add(e);



            	// AST REWRITE
            	// elements:          formalParameterList, Identifier, statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 39:2: -> ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) ( Identifier )? )
            	{
            	    // JavaScript.g:39:5: ^( FUNCTIONEXPR[$f,$e] formalParameterList ^( STATEMENTLIST ( statement )* ) ( Identifier )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new functionExpressionNode(FUNCTIONEXPR, f, e), root_1);

            	    adaptor.AddChild(root_1, stream_formalParameterList.NextTree());
            	    // JavaScript.g:39:71: ^( STATEMENTLIST ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new TopStatementList(STATEMENTLIST), root_2);

            	    // JavaScript.g:39:105: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // JavaScript.g:39:117: ( Identifier )?
            	    if ( stream_Identifier.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    }
            	    stream_Identifier.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "functionExpression"

    public class formalParameterList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "formalParameterList"
    // JavaScript.g:42:1: formalParameterList : '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' ;
    public JavaScriptParser.formalParameterList_return formalParameterList() // throws RecognitionException [1]
    {   
        JavaScriptParser.formalParameterList_return retval = new JavaScriptParser.formalParameterList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal30 = null;
        IToken LT31 = null;
        IToken Identifier32 = null;
        IToken LT33 = null;
        IToken char_literal34 = null;
        IToken LT35 = null;
        IToken Identifier36 = null;
        IToken LT37 = null;
        IToken char_literal38 = null;

        object char_literal30_tree=null;
        object LT31_tree=null;
        object Identifier32_tree=null;
        object LT33_tree=null;
        object char_literal34_tree=null;
        object LT35_tree=null;
        object Identifier36_tree=null;
        object LT37_tree=null;
        object char_literal38_tree=null;

        try 
    	{
            // JavaScript.g:43:2: ( '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')' )
            // JavaScript.g:43:4: '(' ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )? ( LT )* ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal30=(IToken)Match(input,42,FOLLOW_42_in_formalParameterList319); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal30_tree = new ParameterList(char_literal30) ;
            		root_0 = (object)adaptor.BecomeRoot(char_literal30_tree, root_0);
            	}
            	// JavaScript.g:44:4: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?
            	int alt27 = 2;
            	alt27 = dfa27.Predict(input);
            	switch (alt27) 
            	{
            	    case 1 :
            	        // JavaScript.g:45:6: ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )*
            	        {
            	        	// JavaScript.g:45:8: ( LT )*
            	        	do 
            	        	{
            	        	    int alt23 = 2;
            	        	    int LA23_0 = input.LA(1);

            	        	    if ( (LA23_0 == LT) )
            	        	    {
            	        	        alt23 = 1;
            	        	    }


            	        	    switch (alt23) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:45:8: LT
            	        			    {
            	        			    	LT31=(IToken)Match(input,LT,FOLLOW_LT_in_formalParameterList336); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop23;
            	        	    }
            	        	} while (true);

            	        	loop23:
            	        		;	// Stops C# compiler whining that label 'loop23' has no statements

            	        	Identifier32=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList340); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier32_tree = (object)adaptor.Create(Identifier32);
            	        		adaptor.AddChild(root_0, Identifier32_tree);
            	        	}
            	        	// JavaScript.g:46:6: ( ( LT )* ',' ( LT )* Identifier )*
            	        	do 
            	        	{
            	        	    int alt26 = 2;
            	        	    alt26 = dfa26.Predict(input);
            	        	    switch (alt26) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:46:7: ( LT )* ',' ( LT )* Identifier
            	        			    {
            	        			    	// JavaScript.g:46:9: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt24 = 2;
            	        			    	    int LA24_0 = input.LA(1);

            	        			    	    if ( (LA24_0 == LT) )
            	        			    	    {
            	        			    	        alt24 = 1;
            	        			    	    }


            	        			    	    switch (alt24) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:46:9: LT
            	        			    			    {
            	        			    			    	LT33=(IToken)Match(input,LT,FOLLOW_LT_in_formalParameterList349); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop24;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop24:
            	        			    		;	// Stops C# compiler whining that label 'loop24' has no statements

            	        			    	char_literal34=(IToken)Match(input,43,FOLLOW_43_in_formalParameterList353); if (state.failed) return retval;
            	        			    	// JavaScript.g:46:19: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt25 = 2;
            	        			    	    int LA25_0 = input.LA(1);

            	        			    	    if ( (LA25_0 == LT) )
            	        			    	    {
            	        			    	        alt25 = 1;
            	        			    	    }


            	        			    	    switch (alt25) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:46:19: LT
            	        			    			    {
            	        			    			    	LT35=(IToken)Match(input,LT,FOLLOW_LT_in_formalParameterList356); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop25;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop25:
            	        			    		;	// Stops C# compiler whining that label 'loop25' has no statements

            	        			    	Identifier36=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_formalParameterList360); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{Identifier36_tree = (object)adaptor.Create(Identifier36);
            	        			    		adaptor.AddChild(root_0, Identifier36_tree);
            	        			    	}

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop26;
            	        	    }
            	        	} while (true);

            	        	loop26:
            	        		;	// Stops C# compiler whining that label 'loop26' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:47:9: ( LT )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == LT) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // JavaScript.g:47:9: LT
            			    {
            			    	LT37=(IToken)Match(input,LT,FOLLOW_LT_in_formalParameterList370); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements

            	char_literal38=(IToken)Match(input,44,FOLLOW_44_in_formalParameterList378); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "formalParameterList"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // JavaScript.g:52:1: statement : ( ( 'function' ( LT )* Identifier )=> functionDeclaration | ( Identifier ( LT )* ':' )=> labelledStatement | ( '{' )=> statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | switchStatement | throwStatement | tryStatement );
    public JavaScriptParser.statement_return statement() // throws RecognitionException [1]
    {   
        JavaScriptParser.statement_return retval = new JavaScriptParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        JavaScriptParser.functionDeclaration_return functionDeclaration39 = default(JavaScriptParser.functionDeclaration_return);

        JavaScriptParser.labelledStatement_return labelledStatement40 = default(JavaScriptParser.labelledStatement_return);

        JavaScriptParser.statementBlock_return statementBlock41 = default(JavaScriptParser.statementBlock_return);

        JavaScriptParser.variableStatement_return variableStatement42 = default(JavaScriptParser.variableStatement_return);

        JavaScriptParser.emptyStatement_return emptyStatement43 = default(JavaScriptParser.emptyStatement_return);

        JavaScriptParser.expressionStatement_return expressionStatement44 = default(JavaScriptParser.expressionStatement_return);

        JavaScriptParser.ifStatement_return ifStatement45 = default(JavaScriptParser.ifStatement_return);

        JavaScriptParser.iterationStatement_return iterationStatement46 = default(JavaScriptParser.iterationStatement_return);

        JavaScriptParser.continueStatement_return continueStatement47 = default(JavaScriptParser.continueStatement_return);

        JavaScriptParser.breakStatement_return breakStatement48 = default(JavaScriptParser.breakStatement_return);

        JavaScriptParser.returnStatement_return returnStatement49 = default(JavaScriptParser.returnStatement_return);

        JavaScriptParser.withStatement_return withStatement50 = default(JavaScriptParser.withStatement_return);

        JavaScriptParser.switchStatement_return switchStatement51 = default(JavaScriptParser.switchStatement_return);

        JavaScriptParser.throwStatement_return throwStatement52 = default(JavaScriptParser.throwStatement_return);

        JavaScriptParser.tryStatement_return tryStatement53 = default(JavaScriptParser.tryStatement_return);



        try 
    	{
            // JavaScript.g:53:2: ( ( 'function' ( LT )* Identifier )=> functionDeclaration | ( Identifier ( LT )* ':' )=> labelledStatement | ( '{' )=> statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | switchStatement | throwStatement | tryStatement )
            int alt29 = 15;
            alt29 = dfa29.Predict(input);
            switch (alt29) 
            {
                case 1 :
                    // JavaScript.g:53:4: ( 'function' ( LT )* Identifier )=> functionDeclaration
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionDeclaration_in_statement404);
                    	functionDeclaration39 = functionDeclaration();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionDeclaration39.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:54:4: ( Identifier ( LT )* ':' )=> labelledStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_labelledStatement_in_statement420);
                    	labelledStatement40 = labelledStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, labelledStatement40.Tree);

                    }
                    break;
                case 3 :
                    // JavaScript.g:55:4: ( '{' )=> statementBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statementBlock_in_statement432);
                    	statementBlock41 = statementBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock41.Tree);

                    }
                    break;
                case 4 :
                    // JavaScript.g:56:4: variableStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableStatement_in_statement439);
                    	variableStatement42 = variableStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableStatement42.Tree);

                    }
                    break;
                case 5 :
                    // JavaScript.g:57:4: emptyStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_emptyStatement_in_statement445);
                    	emptyStatement43 = emptyStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, emptyStatement43.Tree);

                    }
                    break;
                case 6 :
                    // JavaScript.g:58:4: expressionStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expressionStatement_in_statement451);
                    	expressionStatement44 = expressionStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expressionStatement44.Tree);

                    }
                    break;
                case 7 :
                    // JavaScript.g:59:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement457);
                    	ifStatement45 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement45.Tree);

                    }
                    break;
                case 8 :
                    // JavaScript.g:60:4: iterationStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_iterationStatement_in_statement463);
                    	iterationStatement46 = iterationStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, iterationStatement46.Tree);

                    }
                    break;
                case 9 :
                    // JavaScript.g:61:4: continueStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_continueStatement_in_statement469);
                    	continueStatement47 = continueStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, continueStatement47.Tree);

                    }
                    break;
                case 10 :
                    // JavaScript.g:62:4: breakStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_breakStatement_in_statement475);
                    	breakStatement48 = breakStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStatement48.Tree);

                    }
                    break;
                case 11 :
                    // JavaScript.g:63:4: returnStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_returnStatement_in_statement481);
                    	returnStatement49 = returnStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStatement49.Tree);

                    }
                    break;
                case 12 :
                    // JavaScript.g:64:4: withStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_withStatement_in_statement487);
                    	withStatement50 = withStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, withStatement50.Tree);

                    }
                    break;
                case 13 :
                    // JavaScript.g:65:4: switchStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_switchStatement_in_statement493);
                    	switchStatement51 = switchStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, switchStatement51.Tree);

                    }
                    break;
                case 14 :
                    // JavaScript.g:66:4: throwStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_throwStatement_in_statement499);
                    	throwStatement52 = throwStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, throwStatement52.Tree);

                    }
                    break;
                case 15 :
                    // JavaScript.g:67:4: tryStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tryStatement_in_statement505);
                    	tryStatement53 = tryStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tryStatement53.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class statementBlock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statementBlock"
    // JavaScript.g:70:1: statementBlock : '{' ( ( ( LT )* '}' )=> ( LT )* | ( LT )* statementList ( LT )* ) '}' ;
    public JavaScriptParser.statementBlock_return statementBlock() // throws RecognitionException [1]
    {   
        JavaScriptParser.statementBlock_return retval = new JavaScriptParser.statementBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal54 = null;
        IToken LT55 = null;
        IToken LT56 = null;
        IToken LT58 = null;
        IToken char_literal59 = null;
        JavaScriptParser.statementList_return statementList57 = default(JavaScriptParser.statementList_return);


        object char_literal54_tree=null;
        object LT55_tree=null;
        object LT56_tree=null;
        object LT58_tree=null;
        object char_literal59_tree=null;

        try 
    	{
            // JavaScript.g:71:2: ( '{' ( ( ( LT )* '}' )=> ( LT )* | ( LT )* statementList ( LT )* ) '}' )
            // JavaScript.g:71:4: '{' ( ( ( LT )* '}' )=> ( LT )* | ( LT )* statementList ( LT )* ) '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal54=(IToken)Match(input,40,FOLLOW_40_in_statementBlock518); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal54_tree = (object)adaptor.Create(char_literal54);
            		adaptor.AddChild(root_0, char_literal54_tree);
            	}
            	// JavaScript.g:71:8: ( ( ( LT )* '}' )=> ( LT )* | ( LT )* statementList ( LT )* )
            	int alt33 = 2;
            	alt33 = dfa33.Predict(input);
            	switch (alt33) 
            	{
            	    case 1 :
            	        // JavaScript.g:72:6: ( ( LT )* '}' )=> ( LT )*
            	        {
            	        	// JavaScript.g:72:21: ( LT )*
            	        	do 
            	        	{
            	        	    int alt30 = 2;
            	        	    int LA30_0 = input.LA(1);

            	        	    if ( (LA30_0 == LT) )
            	        	    {
            	        	        alt30 = 1;
            	        	    }


            	        	    switch (alt30) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:72:21: LT
            	        			    {
            	        			    	LT55=(IToken)Match(input,LT,FOLLOW_LT_in_statementBlock536); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop30;
            	        	    }
            	        	} while (true);

            	        	loop30:
            	        		;	// Stops C# compiler whining that label 'loop30' has no statements


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:73:6: ( LT )* statementList ( LT )*
            	        {
            	        	// JavaScript.g:73:8: ( LT )*
            	        	do 
            	        	{
            	        	    int alt31 = 2;
            	        	    int LA31_0 = input.LA(1);

            	        	    if ( (LA31_0 == LT) )
            	        	    {
            	        	        alt31 = 1;
            	        	    }


            	        	    switch (alt31) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:73:8: LT
            	        			    {
            	        			    	LT56=(IToken)Match(input,LT,FOLLOW_LT_in_statementBlock545); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop31;
            	        	    }
            	        	} while (true);

            	        	loop31:
            	        		;	// Stops C# compiler whining that label 'loop31' has no statements

            	        	PushFollow(FOLLOW_statementList_in_statementBlock549);
            	        	statementList57 = statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList57.Tree);
            	        	// JavaScript.g:73:27: ( LT )*
            	        	do 
            	        	{
            	        	    int alt32 = 2;
            	        	    int LA32_0 = input.LA(1);

            	        	    if ( (LA32_0 == LT) )
            	        	    {
            	        	        alt32 = 1;
            	        	    }


            	        	    switch (alt32) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:73:27: LT
            	        			    {
            	        			    	LT58=(IToken)Match(input,LT,FOLLOW_LT_in_statementBlock551); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop32;
            	        	    }
            	        	} while (true);

            	        	loop32:
            	        		;	// Stops C# compiler whining that label 'loop32' has no statements


            	        }
            	        break;

            	}

            	char_literal59=(IToken)Match(input,41,FOLLOW_41_in_statementBlock558); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statementBlock"

    public class statementList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statementList"
    // JavaScript.g:77:1: statementList : statement ( ( LT )* statement )* -> ^( STATEMENTLIST ( statement )* ) ;
    public JavaScriptParser.statementList_return statementList() // throws RecognitionException [1]
    {   
        JavaScriptParser.statementList_return retval = new JavaScriptParser.statementList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT61 = null;
        JavaScriptParser.statement_return statement60 = default(JavaScriptParser.statement_return);

        JavaScriptParser.statement_return statement62 = default(JavaScriptParser.statement_return);


        object LT61_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // JavaScript.g:78:2: ( statement ( ( LT )* statement )* -> ^( STATEMENTLIST ( statement )* ) )
            // JavaScript.g:78:4: statement ( ( LT )* statement )*
            {
            	PushFollow(FOLLOW_statement_in_statementList571);
            	statement60 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statement.Add(statement60.Tree);
            	// JavaScript.g:78:14: ( ( LT )* statement )*
            	do 
            	{
            	    int alt35 = 2;
            	    alt35 = dfa35.Predict(input);
            	    switch (alt35) 
            		{
            			case 1 :
            			    // JavaScript.g:78:15: ( LT )* statement
            			    {
            			    	// JavaScript.g:78:15: ( LT )*
            			    	do 
            			    	{
            			    	    int alt34 = 2;
            			    	    int LA34_0 = input.LA(1);

            			    	    if ( (LA34_0 == LT) )
            			    	    {
            			    	        alt34 = 1;
            			    	    }


            			    	    switch (alt34) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:78:15: LT
            			    			    {
            			    			    	LT61=(IToken)Match(input,LT,FOLLOW_LT_in_statementList574); if (state.failed) return retval; 
            			    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT61);


            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop34;
            			    	    }
            			    	} while (true);

            			    	loop34:
            			    		;	// Stops C# compiler whining that label 'loop34' has no statements

            			    	PushFollow(FOLLOW_statement_in_statementList577);
            			    	statement62 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 79:2: -> ^( STATEMENTLIST ( statement )* )
            	{
            	    // JavaScript.g:79:5: ^( STATEMENTLIST ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new StatementList(STATEMENTLIST), root_1);

            	    // JavaScript.g:79:36: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statementList"

    public class variableStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableStatement"
    // JavaScript.g:82:1: variableStatement : 'var' ( LT )* variableDeclarationList statementEnd ;
    public JavaScriptParser.variableStatement_return variableStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.variableStatement_return retval = new JavaScriptParser.variableStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal63 = null;
        IToken LT64 = null;
        JavaScriptParser.variableDeclarationList_return variableDeclarationList65 = default(JavaScriptParser.variableDeclarationList_return);

        JavaScriptParser.statementEnd_return statementEnd66 = default(JavaScriptParser.statementEnd_return);


        object string_literal63_tree=null;
        object LT64_tree=null;

        try 
    	{
            // JavaScript.g:83:2: ( 'var' ( LT )* variableDeclarationList statementEnd )
            // JavaScript.g:83:4: 'var' ( LT )* variableDeclarationList statementEnd
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal63=(IToken)Match(input,45,FOLLOW_45_in_variableStatement604); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal63_tree = new VarDeclStatement(string_literal63) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal63_tree, root_0);
            	}
            	// JavaScript.g:83:31: ( LT )*
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == LT) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // JavaScript.g:83:31: LT
            			    {
            			    	LT64=(IToken)Match(input,LT,FOLLOW_LT_in_variableStatement610); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop36;
            	    }
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	PushFollow(FOLLOW_variableDeclarationList_in_variableStatement614);
            	variableDeclarationList65 = variableDeclarationList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationList65.Tree);
            	PushFollow(FOLLOW_statementEnd_in_variableStatement616);
            	statementEnd66 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableStatement"

    public class variableDeclarationList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclarationList"
    // JavaScript.g:86:1: variableDeclarationList : variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* ;
    public JavaScriptParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        JavaScriptParser.variableDeclarationList_return retval = new JavaScriptParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT68 = null;
        IToken char_literal69 = null;
        IToken LT70 = null;
        JavaScriptParser.variableDeclaration_return variableDeclaration67 = default(JavaScriptParser.variableDeclaration_return);

        JavaScriptParser.variableDeclaration_return variableDeclaration71 = default(JavaScriptParser.variableDeclaration_return);


        object LT68_tree=null;
        object char_literal69_tree=null;
        object LT70_tree=null;

        try 
    	{
            // JavaScript.g:87:2: ( variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )* )
            // JavaScript.g:87:4: variableDeclaration ( ( LT )* ',' ( LT )* variableDeclaration )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaration_in_variableDeclarationList630);
            	variableDeclaration67 = variableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaration67.Tree);
            	// JavaScript.g:87:24: ( ( LT )* ',' ( LT )* variableDeclaration )*
            	do 
            	{
            	    int alt39 = 2;
            	    alt39 = dfa39.Predict(input);
            	    switch (alt39) 
            		{
            			case 1 :
            			    // JavaScript.g:87:25: ( LT )* ',' ( LT )* variableDeclaration
            			    {
            			    	// JavaScript.g:87:27: ( LT )*
            			    	do 
            			    	{
            			    	    int alt37 = 2;
            			    	    int LA37_0 = input.LA(1);

            			    	    if ( (LA37_0 == LT) )
            			    	    {
            			    	        alt37 = 1;
            			    	    }


            			    	    switch (alt37) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:87:27: LT
            			    			    {
            			    			    	LT68=(IToken)Match(input,LT,FOLLOW_LT_in_variableDeclarationList633); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop37;
            			    	    }
            			    	} while (true);

            			    	loop37:
            			    		;	// Stops C# compiler whining that label 'loop37' has no statements

            			    	char_literal69=(IToken)Match(input,43,FOLLOW_43_in_variableDeclarationList637); if (state.failed) return retval;
            			    	// JavaScript.g:87:37: ( LT )*
            			    	do 
            			    	{
            			    	    int alt38 = 2;
            			    	    int LA38_0 = input.LA(1);

            			    	    if ( (LA38_0 == LT) )
            			    	    {
            			    	        alt38 = 1;
            			    	    }


            			    	    switch (alt38) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:87:37: LT
            			    			    {
            			    			    	LT70=(IToken)Match(input,LT,FOLLOW_LT_in_variableDeclarationList640); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop38;
            			    	    }
            			    	} while (true);

            			    	loop38:
            			    		;	// Stops C# compiler whining that label 'loop38' has no statements

            			    	PushFollow(FOLLOW_variableDeclaration_in_variableDeclarationList644);
            			    	variableDeclaration71 = variableDeclaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclaration71.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclarationList"

    public class variableDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclaration"
    // JavaScript.g:90:1: variableDeclaration : Identifier ( ( LT )* initialiser )? -> ^( VARDECL Identifier ( initialiser )? ) ;
    public JavaScriptParser.variableDeclaration_return variableDeclaration() // throws RecognitionException [1]
    {   
        JavaScriptParser.variableDeclaration_return retval = new JavaScriptParser.variableDeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier72 = null;
        IToken LT73 = null;
        JavaScriptParser.initialiser_return initialiser74 = default(JavaScriptParser.initialiser_return);


        object Identifier72_tree=null;
        object LT73_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_initialiser = new RewriteRuleSubtreeStream(adaptor,"rule initialiser");
        try 
    	{
            // JavaScript.g:91:2: ( Identifier ( ( LT )* initialiser )? -> ^( VARDECL Identifier ( initialiser )? ) )
            // JavaScript.g:91:4: Identifier ( ( LT )* initialiser )?
            {
            	Identifier72=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableDeclaration659); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier72);

            	// JavaScript.g:91:15: ( ( LT )* initialiser )?
            	int alt41 = 2;
            	alt41 = dfa41.Predict(input);
            	switch (alt41) 
            	{
            	    case 1 :
            	        // JavaScript.g:91:16: ( LT )* initialiser
            	        {
            	        	// JavaScript.g:91:16: ( LT )*
            	        	do 
            	        	{
            	        	    int alt40 = 2;
            	        	    int LA40_0 = input.LA(1);

            	        	    if ( (LA40_0 == LT) )
            	        	    {
            	        	        alt40 = 1;
            	        	    }


            	        	    switch (alt40) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:91:16: LT
            	        			    {
            	        			    	LT73=(IToken)Match(input,LT,FOLLOW_LT_in_variableDeclaration662); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT73);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop40;
            	        	    }
            	        	} while (true);

            	        	loop40:
            	        		;	// Stops C# compiler whining that label 'loop40' has no statements

            	        	PushFollow(FOLLOW_initialiser_in_variableDeclaration665);
            	        	initialiser74 = initialiser();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_initialiser.Add(initialiser74.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          initialiser, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 91:34: -> ^( VARDECL Identifier ( initialiser )? )
            	{
            	    // JavaScript.g:91:37: ^( VARDECL Identifier ( initialiser )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new baseNode(VARDECL), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // JavaScript.g:91:68: ( initialiser )?
            	    if ( stream_initialiser.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_initialiser.NextTree());

            	    }
            	    stream_initialiser.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclaration"

    public class initialiser_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "initialiser"
    // JavaScript.g:94:1: initialiser : '=' ( LT )* assignmentExpression ;
    public JavaScriptParser.initialiser_return initialiser() // throws RecognitionException [1]
    {   
        JavaScriptParser.initialiser_return retval = new JavaScriptParser.initialiser_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal75 = null;
        IToken LT76 = null;
        JavaScriptParser.assignmentExpression_return assignmentExpression77 = default(JavaScriptParser.assignmentExpression_return);


        object char_literal75_tree=null;
        object LT76_tree=null;

        try 
    	{
            // JavaScript.g:95:2: ( '=' ( LT )* assignmentExpression )
            // JavaScript.g:95:4: '=' ( LT )* assignmentExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal75=(IToken)Match(input,46,FOLLOW_46_in_initialiser693); if (state.failed) return retval;
            	// JavaScript.g:95:11: ( LT )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == LT) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // JavaScript.g:95:11: LT
            			    {
            			    	LT76=(IToken)Match(input,LT,FOLLOW_LT_in_initialiser696); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements

            	PushFollow(FOLLOW_assignmentExpression_in_initialiser700);
            	assignmentExpression77 = assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression77.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "initialiser"

    public class emptyStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "emptyStatement"
    // JavaScript.g:98:1: emptyStatement : ';' ;
    public JavaScriptParser.emptyStatement_return emptyStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.emptyStatement_return retval = new JavaScriptParser.emptyStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal78 = null;

        object char_literal78_tree=null;

        try 
    	{
            // JavaScript.g:99:2: ( ';' )
            // JavaScript.g:99:4: ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal78=(IToken)Match(input,47,FOLLOW_47_in_emptyStatement713); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal78_tree = new EmptyStatement(char_literal78) ;
            		adaptor.AddChild(root_0, char_literal78_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "emptyStatement"

    public class expressionStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionStatement"
    // JavaScript.g:102:1: expressionStatement : expression statementEnd -> ^( EXPRESSIONSTATEMENT expression ) ;
    public JavaScriptParser.expressionStatement_return expressionStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.expressionStatement_return retval = new JavaScriptParser.expressionStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        JavaScriptParser.expression_return expression79 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statementEnd_return statementEnd80 = default(JavaScriptParser.statementEnd_return);


        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_statementEnd = new RewriteRuleSubtreeStream(adaptor,"rule statementEnd");
        try 
    	{
            // JavaScript.g:103:2: ( expression statementEnd -> ^( EXPRESSIONSTATEMENT expression ) )
            // JavaScript.g:103:4: expression statementEnd
            {
            	PushFollow(FOLLOW_expression_in_expressionStatement728);
            	expression79 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression79.Tree);
            	PushFollow(FOLLOW_statementEnd_in_expressionStatement730);
            	statementEnd80 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementEnd.Add(statementEnd80.Tree);


            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 103:28: -> ^( EXPRESSIONSTATEMENT expression )
            	{
            	    // JavaScript.g:103:31: ^( EXPRESSIONSTATEMENT expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ExpressionStatement(EXPRESSIONSTATEMENT), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionStatement"

    public class statementEnd_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statementEnd"
    // JavaScript.g:106:1: statementEnd : ( LT | ';' | ( '}' | EOF )=> () ) ;
    public JavaScriptParser.statementEnd_return statementEnd() // throws RecognitionException [1]
    {   
        JavaScriptParser.statementEnd_return retval = new JavaScriptParser.statementEnd_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT81 = null;
        IToken char_literal82 = null;

        object LT81_tree=null;
        object char_literal82_tree=null;

        try 
    	{
            // JavaScript.g:107:2: ( ( LT | ';' | ( '}' | EOF )=> () ) )
            // JavaScript.g:107:4: ( LT | ';' | ( '}' | EOF )=> () )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// JavaScript.g:107:4: ( LT | ';' | ( '}' | EOF )=> () )
            	int alt43 = 3;
            	alt43 = dfa43.Predict(input);
            	switch (alt43) 
            	{
            	    case 1 :
            	        // JavaScript.g:107:5: LT
            	        {
            	        	LT81=(IToken)Match(input,LT,FOLLOW_LT_in_statementEnd753); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LT81_tree = (object)adaptor.Create(LT81);
            	        		adaptor.AddChild(root_0, LT81_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:107:10: ';'
            	        {
            	        	char_literal82=(IToken)Match(input,47,FOLLOW_47_in_statementEnd757); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal82_tree = (object)adaptor.Create(char_literal82);
            	        		adaptor.AddChild(root_0, char_literal82_tree);
            	        	}

            	        }
            	        break;
            	    case 3 :
            	        // JavaScript.g:107:16: ( '}' | EOF )=> ()
            	        {
            	        	// JavaScript.g:107:31: ()
            	        	// JavaScript.g:107:32: 
            	        	{
            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statementEnd"

    public class ifStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // JavaScript.g:110:1: ifStatement : 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( ( LT )* 'else' )=> ( LT )* 'else' ( LT )* statement | ) ;
    public JavaScriptParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.ifStatement_return retval = new JavaScriptParser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal83 = null;
        IToken LT84 = null;
        IToken char_literal85 = null;
        IToken LT86 = null;
        IToken LT88 = null;
        IToken char_literal89 = null;
        IToken LT90 = null;
        IToken LT92 = null;
        IToken string_literal93 = null;
        IToken LT94 = null;
        JavaScriptParser.expression_return expression87 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statement_return statement91 = default(JavaScriptParser.statement_return);

        JavaScriptParser.statement_return statement95 = default(JavaScriptParser.statement_return);


        object string_literal83_tree=null;
        object LT84_tree=null;
        object char_literal85_tree=null;
        object LT86_tree=null;
        object LT88_tree=null;
        object char_literal89_tree=null;
        object LT90_tree=null;
        object LT92_tree=null;
        object string_literal93_tree=null;
        object LT94_tree=null;

        try 
    	{
            // JavaScript.g:111:2: ( 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( ( LT )* 'else' )=> ( LT )* 'else' ( LT )* statement | ) )
            // JavaScript.g:111:4: 'if' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ( ( ( LT )* 'else' )=> ( LT )* 'else' ( LT )* statement | )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal83=(IToken)Match(input,48,FOLLOW_48_in_ifStatement786); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal83_tree = new IfStatement(string_literal83) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal83_tree, root_0);
            	}
            	// JavaScript.g:111:25: ( LT )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == LT) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // JavaScript.g:111:25: LT
            			    {
            			    	LT84=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement792); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements

            	char_literal85=(IToken)Match(input,42,FOLLOW_42_in_ifStatement796); if (state.failed) return retval;
            	// JavaScript.g:111:35: ( LT )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == LT) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // JavaScript.g:111:35: LT
            			    {
            			    	LT86=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement799); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	PushFollow(FOLLOW_expression_in_ifStatement803);
            	expression87 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression87.Tree);
            	// JavaScript.g:111:51: ( LT )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( (LA46_0 == LT) )
            	    {
            	        alt46 = 1;
            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // JavaScript.g:111:51: LT
            			    {
            			    	LT88=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement805); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	char_literal89=(IToken)Match(input,44,FOLLOW_44_in_ifStatement809); if (state.failed) return retval;
            	// JavaScript.g:111:61: ( LT )*
            	do 
            	{
            	    int alt47 = 2;
            	    int LA47_0 = input.LA(1);

            	    if ( (LA47_0 == LT) )
            	    {
            	        alt47 = 1;
            	    }


            	    switch (alt47) 
            		{
            			case 1 :
            			    // JavaScript.g:111:61: LT
            			    {
            			    	LT90=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement812); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop47;
            	    }
            	} while (true);

            	loop47:
            		;	// Stops C# compiler whining that label 'loop47' has no statements

            	PushFollow(FOLLOW_statement_in_ifStatement816);
            	statement91 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement91.Tree);
            	// JavaScript.g:112:2: ( ( ( LT )* 'else' )=> ( LT )* 'else' ( LT )* statement | )
            	int alt50 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case LT:
            		{
            	    int LA50_1 = input.LA(2);

            	    if ( (synpred8_JavaScript()) )
            	    {
            	        alt50 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt50 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d50s1 =
            	            new NoViableAltException("", 50, 1, input);

            	        throw nvae_d50s1;
            	    }
            	    }
            	    break;
            	case 49:
            		{
            	    int LA50_2 = input.LA(2);

            	    if ( (synpred8_JavaScript()) )
            	    {
            	        alt50 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt50 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d50s2 =
            	            new NoViableAltException("", 50, 2, input);

            	        throw nvae_d50s2;
            	    }
            	    }
            	    break;
            	case EOF:
            	case Identifier:
            	case StringLiteral:
            	case NumericLiteral:
            	case RegexLiteral:
            	case 39:
            	case 40:
            	case 41:
            	case 42:
            	case 45:
            	case 47:
            	case 48:
            	case 50:
            	case 51:
            	case 52:
            	case 54:
            	case 55:
            	case 56:
            	case 57:
            	case 59:
            	case 60:
            	case 61:
            	case 62:
            	case 63:
            	case 66:
            	case 67:
            	case 99:
            	case 100:
            	case 104:
            	case 105:
            	case 106:
            	case 107:
            	case 108:
            	case 109:
            	case 110:
            	case 111:
            	case 112:
            	case 113:
            	case 114:
            		{
            	    alt50 = 2;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d50s0 =
            		        new NoViableAltException("", 50, 0, input);

            		    throw nvae_d50s0;
            	}

            	switch (alt50) 
            	{
            	    case 1 :
            	        // JavaScript.g:113:3: ( ( LT )* 'else' )=> ( LT )* 'else' ( LT )* statement
            	        {
            	        	// JavaScript.g:113:21: ( LT )*
            	        	do 
            	        	{
            	        	    int alt48 = 2;
            	        	    int LA48_0 = input.LA(1);

            	        	    if ( (LA48_0 == LT) )
            	        	    {
            	        	        alt48 = 1;
            	        	    }


            	        	    switch (alt48) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:113:21: LT
            	        			    {
            	        			    	LT92=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement833); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop48;
            	        	    }
            	        	} while (true);

            	        	loop48:
            	        		;	// Stops C# compiler whining that label 'loop48' has no statements

            	        	string_literal93=(IToken)Match(input,49,FOLLOW_49_in_ifStatement837); if (state.failed) return retval;
            	        	// JavaScript.g:113:34: ( LT )*
            	        	do 
            	        	{
            	        	    int alt49 = 2;
            	        	    int LA49_0 = input.LA(1);

            	        	    if ( (LA49_0 == LT) )
            	        	    {
            	        	        alt49 = 1;
            	        	    }


            	        	    switch (alt49) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:113:34: LT
            	        			    {
            	        			    	LT94=(IToken)Match(input,LT,FOLLOW_LT_in_ifStatement840); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop49;
            	        	    }
            	        	} while (true);

            	        	loop49:
            	        		;	// Stops C# compiler whining that label 'loop49' has no statements

            	        	PushFollow(FOLLOW_statement_in_ifStatement844);
            	        	statement95 = statement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement95.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:115:2: 
            	        {
            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "ifStatement"

    public class iterationStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "iterationStatement"
    // JavaScript.g:118:1: iterationStatement : ( doWhileStatement | whileStatement | ( 'for' ( LT )* '(' )=> forStatement | forInStatement );
    public JavaScriptParser.iterationStatement_return iterationStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.iterationStatement_return retval = new JavaScriptParser.iterationStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        JavaScriptParser.doWhileStatement_return doWhileStatement96 = default(JavaScriptParser.doWhileStatement_return);

        JavaScriptParser.whileStatement_return whileStatement97 = default(JavaScriptParser.whileStatement_return);

        JavaScriptParser.forStatement_return forStatement98 = default(JavaScriptParser.forStatement_return);

        JavaScriptParser.forInStatement_return forInStatement99 = default(JavaScriptParser.forInStatement_return);



        try 
    	{
            // JavaScript.g:119:2: ( doWhileStatement | whileStatement | ( 'for' ( LT )* '(' )=> forStatement | forInStatement )
            int alt51 = 4;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt51 = 1;
                }
                break;
            case 51:
            	{
                alt51 = 2;
                }
                break;
            case 52:
            	{
                int LA51_3 = input.LA(2);

                if ( (synpred9_JavaScript()) )
                {
                    alt51 = 3;
                }
                else if ( (true) )
                {
                    alt51 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d51s3 =
                        new NoViableAltException("", 51, 3, input);

                    throw nvae_d51s3;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d51s0 =
            	        new NoViableAltException("", 51, 0, input);

            	    throw nvae_d51s0;
            }

            switch (alt51) 
            {
                case 1 :
                    // JavaScript.g:119:4: doWhileStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_doWhileStatement_in_iterationStatement866);
                    	doWhileStatement96 = doWhileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, doWhileStatement96.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:120:4: whileStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileStatement_in_iterationStatement872);
                    	whileStatement97 = whileStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileStatement97.Tree);

                    }
                    break;
                case 3 :
                    // JavaScript.g:121:4: ( 'for' ( LT )* '(' )=> forStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forStatement_in_iterationStatement888);
                    	forStatement98 = forStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forStatement98.Tree);

                    }
                    break;
                case 4 :
                    // JavaScript.g:122:4: forInStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forInStatement_in_iterationStatement893);
                    	forInStatement99 = forInStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInStatement99.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "iterationStatement"

    public class doWhileStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "doWhileStatement"
    // JavaScript.g:125:1: doWhileStatement : 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ;
    public JavaScriptParser.doWhileStatement_return doWhileStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.doWhileStatement_return retval = new JavaScriptParser.doWhileStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal100 = null;
        IToken LT101 = null;
        IToken LT103 = null;
        IToken string_literal104 = null;
        IToken LT105 = null;
        IToken char_literal106 = null;
        IToken LT107 = null;
        IToken LT109 = null;
        IToken char_literal110 = null;
        JavaScriptParser.statement_return statement102 = default(JavaScriptParser.statement_return);

        JavaScriptParser.expression_return expression108 = default(JavaScriptParser.expression_return);


        object string_literal100_tree=null;
        object LT101_tree=null;
        object LT103_tree=null;
        object string_literal104_tree=null;
        object LT105_tree=null;
        object char_literal106_tree=null;
        object LT107_tree=null;
        object LT109_tree=null;
        object char_literal110_tree=null;

        try 
    	{
            // JavaScript.g:126:2: ( 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' )
            // JavaScript.g:126:4: 'do' ( LT )* statement ( LT )* 'while' ( LT )* '(' ( LT )* expression ( LT )* ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal100=(IToken)Match(input,50,FOLLOW_50_in_doWhileStatement905); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal100_tree = new DoWhileStatement(string_literal100) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal100_tree, root_0);
            	}
            	// JavaScript.g:126:30: ( LT )*
            	do 
            	{
            	    int alt52 = 2;
            	    int LA52_0 = input.LA(1);

            	    if ( (LA52_0 == LT) )
            	    {
            	        alt52 = 1;
            	    }


            	    switch (alt52) 
            		{
            			case 1 :
            			    // JavaScript.g:126:30: LT
            			    {
            			    	LT101=(IToken)Match(input,LT,FOLLOW_LT_in_doWhileStatement911); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop52;
            	    }
            	} while (true);

            	loop52:
            		;	// Stops C# compiler whining that label 'loop52' has no statements

            	PushFollow(FOLLOW_statement_in_doWhileStatement915);
            	statement102 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement102.Tree);
            	// JavaScript.g:126:45: ( LT )*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( (LA53_0 == LT) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // JavaScript.g:126:45: LT
            			    {
            			    	LT103=(IToken)Match(input,LT,FOLLOW_LT_in_doWhileStatement917); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements

            	string_literal104=(IToken)Match(input,51,FOLLOW_51_in_doWhileStatement921); if (state.failed) return retval;
            	// JavaScript.g:126:59: ( LT )*
            	do 
            	{
            	    int alt54 = 2;
            	    int LA54_0 = input.LA(1);

            	    if ( (LA54_0 == LT) )
            	    {
            	        alt54 = 1;
            	    }


            	    switch (alt54) 
            		{
            			case 1 :
            			    // JavaScript.g:126:59: LT
            			    {
            			    	LT105=(IToken)Match(input,LT,FOLLOW_LT_in_doWhileStatement924); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop54;
            	    }
            	} while (true);

            	loop54:
            		;	// Stops C# compiler whining that label 'loop54' has no statements

            	char_literal106=(IToken)Match(input,42,FOLLOW_42_in_doWhileStatement928); if (state.failed) return retval;
            	// JavaScript.g:126:69: ( LT )*
            	do 
            	{
            	    int alt55 = 2;
            	    int LA55_0 = input.LA(1);

            	    if ( (LA55_0 == LT) )
            	    {
            	        alt55 = 1;
            	    }


            	    switch (alt55) 
            		{
            			case 1 :
            			    // JavaScript.g:126:69: LT
            			    {
            			    	LT107=(IToken)Match(input,LT,FOLLOW_LT_in_doWhileStatement931); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop55;
            	    }
            	} while (true);

            	loop55:
            		;	// Stops C# compiler whining that label 'loop55' has no statements

            	PushFollow(FOLLOW_expression_in_doWhileStatement935);
            	expression108 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression108.Tree);
            	// JavaScript.g:126:85: ( LT )*
            	do 
            	{
            	    int alt56 = 2;
            	    int LA56_0 = input.LA(1);

            	    if ( (LA56_0 == LT) )
            	    {
            	        alt56 = 1;
            	    }


            	    switch (alt56) 
            		{
            			case 1 :
            			    // JavaScript.g:126:85: LT
            			    {
            			    	LT109=(IToken)Match(input,LT,FOLLOW_LT_in_doWhileStatement937); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop56;
            	    }
            	} while (true);

            	loop56:
            		;	// Stops C# compiler whining that label 'loop56' has no statements

            	char_literal110=(IToken)Match(input,44,FOLLOW_44_in_doWhileStatement941); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doWhileStatement"

    public class whileStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "whileStatement"
    // JavaScript.g:129:1: whileStatement : 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public JavaScriptParser.whileStatement_return whileStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.whileStatement_return retval = new JavaScriptParser.whileStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal111 = null;
        IToken LT112 = null;
        IToken char_literal113 = null;
        IToken LT114 = null;
        IToken LT116 = null;
        IToken char_literal117 = null;
        IToken LT118 = null;
        JavaScriptParser.expression_return expression115 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statement_return statement119 = default(JavaScriptParser.statement_return);


        object string_literal111_tree=null;
        object LT112_tree=null;
        object char_literal113_tree=null;
        object LT114_tree=null;
        object LT116_tree=null;
        object char_literal117_tree=null;
        object LT118_tree=null;

        try 
    	{
            // JavaScript.g:130:2: ( 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:130:4: 'while' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal111=(IToken)Match(input,51,FOLLOW_51_in_whileStatement954); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal111_tree = new WhileStatement(string_literal111) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal111_tree, root_0);
            	}
            	// JavaScript.g:130:31: ( LT )*
            	do 
            	{
            	    int alt57 = 2;
            	    int LA57_0 = input.LA(1);

            	    if ( (LA57_0 == LT) )
            	    {
            	        alt57 = 1;
            	    }


            	    switch (alt57) 
            		{
            			case 1 :
            			    // JavaScript.g:130:31: LT
            			    {
            			    	LT112=(IToken)Match(input,LT,FOLLOW_LT_in_whileStatement960); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop57;
            	    }
            	} while (true);

            	loop57:
            		;	// Stops C# compiler whining that label 'loop57' has no statements

            	char_literal113=(IToken)Match(input,42,FOLLOW_42_in_whileStatement964); if (state.failed) return retval;
            	// JavaScript.g:130:41: ( LT )*
            	do 
            	{
            	    int alt58 = 2;
            	    int LA58_0 = input.LA(1);

            	    if ( (LA58_0 == LT) )
            	    {
            	        alt58 = 1;
            	    }


            	    switch (alt58) 
            		{
            			case 1 :
            			    // JavaScript.g:130:41: LT
            			    {
            			    	LT114=(IToken)Match(input,LT,FOLLOW_LT_in_whileStatement967); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop58;
            	    }
            	} while (true);

            	loop58:
            		;	// Stops C# compiler whining that label 'loop58' has no statements

            	PushFollow(FOLLOW_expression_in_whileStatement971);
            	expression115 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression115.Tree);
            	// JavaScript.g:130:57: ( LT )*
            	do 
            	{
            	    int alt59 = 2;
            	    int LA59_0 = input.LA(1);

            	    if ( (LA59_0 == LT) )
            	    {
            	        alt59 = 1;
            	    }


            	    switch (alt59) 
            		{
            			case 1 :
            			    // JavaScript.g:130:57: LT
            			    {
            			    	LT116=(IToken)Match(input,LT,FOLLOW_LT_in_whileStatement973); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop59;
            	    }
            	} while (true);

            	loop59:
            		;	// Stops C# compiler whining that label 'loop59' has no statements

            	char_literal117=(IToken)Match(input,44,FOLLOW_44_in_whileStatement977); if (state.failed) return retval;
            	// JavaScript.g:130:67: ( LT )*
            	do 
            	{
            	    int alt60 = 2;
            	    int LA60_0 = input.LA(1);

            	    if ( (LA60_0 == LT) )
            	    {
            	        alt60 = 1;
            	    }


            	    switch (alt60) 
            		{
            			case 1 :
            			    // JavaScript.g:130:67: LT
            			    {
            			    	LT118=(IToken)Match(input,LT,FOLLOW_LT_in_whileStatement980); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop60;
            	    }
            	} while (true);

            	loop60:
            		;	// Stops C# compiler whining that label 'loop60' has no statements

            	PushFollow(FOLLOW_statement_in_whileStatement984);
            	statement119 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement119.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "whileStatement"

    public class forStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forStatement"
    // JavaScript.g:133:1: forStatement : 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* a= expression )? ( LT )* ';' ( ( LT )* b= expression )? ( LT )* ')' ( LT )* statement -> ^( 'for' ^( NIL ( forStatementInitialiserPart )? ) ^( NIL ( $a)? ) ^( NIL ( ^( EXPRESSIONSTATEMENT $b) )? ) statement ) ;
    public JavaScriptParser.forStatement_return forStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.forStatement_return retval = new JavaScriptParser.forStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal120 = null;
        IToken LT121 = null;
        IToken char_literal122 = null;
        IToken LT123 = null;
        IToken LT125 = null;
        IToken char_literal126 = null;
        IToken LT127 = null;
        IToken LT128 = null;
        IToken char_literal129 = null;
        IToken LT130 = null;
        IToken LT131 = null;
        IToken char_literal132 = null;
        IToken LT133 = null;
        JavaScriptParser.expression_return a = default(JavaScriptParser.expression_return);

        JavaScriptParser.expression_return b = default(JavaScriptParser.expression_return);

        JavaScriptParser.forStatementInitialiserPart_return forStatementInitialiserPart124 = default(JavaScriptParser.forStatementInitialiserPart_return);

        JavaScriptParser.statement_return statement134 = default(JavaScriptParser.statement_return);


        object string_literal120_tree=null;
        object LT121_tree=null;
        object char_literal122_tree=null;
        object LT123_tree=null;
        object LT125_tree=null;
        object char_literal126_tree=null;
        object LT127_tree=null;
        object LT128_tree=null;
        object char_literal129_tree=null;
        object LT130_tree=null;
        object LT131_tree=null;
        object char_literal132_tree=null;
        object LT133_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_forStatementInitialiserPart = new RewriteRuleSubtreeStream(adaptor,"rule forStatementInitialiserPart");
        try 
    	{
            // JavaScript.g:134:2: ( 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* a= expression )? ( LT )* ';' ( ( LT )* b= expression )? ( LT )* ')' ( LT )* statement -> ^( 'for' ^( NIL ( forStatementInitialiserPart )? ) ^( NIL ( $a)? ) ^( NIL ( ^( EXPRESSIONSTATEMENT $b) )? ) statement ) )
            // JavaScript.g:134:4: 'for' ( LT )* '(' ( ( LT )* forStatementInitialiserPart )? ( LT )* ';' ( ( LT )* a= expression )? ( LT )* ';' ( ( LT )* b= expression )? ( LT )* ')' ( LT )* statement
            {
            	string_literal120=(IToken)Match(input,52,FOLLOW_52_in_forStatement997); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(string_literal120);

            	// JavaScript.g:134:10: ( LT )*
            	do 
            	{
            	    int alt61 = 2;
            	    int LA61_0 = input.LA(1);

            	    if ( (LA61_0 == LT) )
            	    {
            	        alt61 = 1;
            	    }


            	    switch (alt61) 
            		{
            			case 1 :
            			    // JavaScript.g:134:10: LT
            			    {
            			    	LT121=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement999); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT121);


            			    }
            			    break;

            			default:
            			    goto loop61;
            	    }
            	} while (true);

            	loop61:
            		;	// Stops C# compiler whining that label 'loop61' has no statements

            	char_literal122=(IToken)Match(input,42,FOLLOW_42_in_forStatement1002); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_42.Add(char_literal122);

            	// JavaScript.g:134:18: ( ( LT )* forStatementInitialiserPart )?
            	int alt63 = 2;
            	alt63 = dfa63.Predict(input);
            	switch (alt63) 
            	{
            	    case 1 :
            	        // JavaScript.g:134:19: ( LT )* forStatementInitialiserPart
            	        {
            	        	// JavaScript.g:134:19: ( LT )*
            	        	do 
            	        	{
            	        	    int alt62 = 2;
            	        	    int LA62_0 = input.LA(1);

            	        	    if ( (LA62_0 == LT) )
            	        	    {
            	        	        alt62 = 1;
            	        	    }


            	        	    switch (alt62) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:134:19: LT
            	        			    {
            	        			    	LT123=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1005); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT123);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop62;
            	        	    }
            	        	} while (true);

            	        	loop62:
            	        		;	// Stops C# compiler whining that label 'loop62' has no statements

            	        	PushFollow(FOLLOW_forStatementInitialiserPart_in_forStatement1008);
            	        	forStatementInitialiserPart124 = forStatementInitialiserPart();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_forStatementInitialiserPart.Add(forStatementInitialiserPart124.Tree);

            	        }
            	        break;

            	}

            	// JavaScript.g:134:53: ( LT )*
            	do 
            	{
            	    int alt64 = 2;
            	    int LA64_0 = input.LA(1);

            	    if ( (LA64_0 == LT) )
            	    {
            	        alt64 = 1;
            	    }


            	    switch (alt64) 
            		{
            			case 1 :
            			    // JavaScript.g:134:53: LT
            			    {
            			    	LT125=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1012); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT125);


            			    }
            			    break;

            			default:
            			    goto loop64;
            	    }
            	} while (true);

            	loop64:
            		;	// Stops C# compiler whining that label 'loop64' has no statements

            	char_literal126=(IToken)Match(input,47,FOLLOW_47_in_forStatement1015); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal126);

            	// JavaScript.g:134:61: ( ( LT )* a= expression )?
            	int alt66 = 2;
            	alt66 = dfa66.Predict(input);
            	switch (alt66) 
            	{
            	    case 1 :
            	        // JavaScript.g:134:62: ( LT )* a= expression
            	        {
            	        	// JavaScript.g:134:62: ( LT )*
            	        	do 
            	        	{
            	        	    int alt65 = 2;
            	        	    int LA65_0 = input.LA(1);

            	        	    if ( (LA65_0 == LT) )
            	        	    {
            	        	        alt65 = 1;
            	        	    }


            	        	    switch (alt65) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:134:62: LT
            	        			    {
            	        			    	LT127=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1018); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT127);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop65;
            	        	    }
            	        	} while (true);

            	        	loop65:
            	        		;	// Stops C# compiler whining that label 'loop65' has no statements

            	        	PushFollow(FOLLOW_expression_in_forStatement1023);
            	        	a = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(a.Tree);

            	        }
            	        break;

            	}

            	// JavaScript.g:134:81: ( LT )*
            	do 
            	{
            	    int alt67 = 2;
            	    int LA67_0 = input.LA(1);

            	    if ( (LA67_0 == LT) )
            	    {
            	        alt67 = 1;
            	    }


            	    switch (alt67) 
            		{
            			case 1 :
            			    // JavaScript.g:134:81: LT
            			    {
            			    	LT128=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1027); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT128);


            			    }
            			    break;

            			default:
            			    goto loop67;
            	    }
            	} while (true);

            	loop67:
            		;	// Stops C# compiler whining that label 'loop67' has no statements

            	char_literal129=(IToken)Match(input,47,FOLLOW_47_in_forStatement1030); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_47.Add(char_literal129);

            	// JavaScript.g:134:89: ( ( LT )* b= expression )?
            	int alt69 = 2;
            	alt69 = dfa69.Predict(input);
            	switch (alt69) 
            	{
            	    case 1 :
            	        // JavaScript.g:134:90: ( LT )* b= expression
            	        {
            	        	// JavaScript.g:134:90: ( LT )*
            	        	do 
            	        	{
            	        	    int alt68 = 2;
            	        	    int LA68_0 = input.LA(1);

            	        	    if ( (LA68_0 == LT) )
            	        	    {
            	        	        alt68 = 1;
            	        	    }


            	        	    switch (alt68) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:134:90: LT
            	        			    {
            	        			    	LT130=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1033); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT130);


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop68;
            	        	    }
            	        	} while (true);

            	        	loop68:
            	        		;	// Stops C# compiler whining that label 'loop68' has no statements

            	        	PushFollow(FOLLOW_expression_in_forStatement1038);
            	        	b = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(b.Tree);

            	        }
            	        break;

            	}

            	// JavaScript.g:134:109: ( LT )*
            	do 
            	{
            	    int alt70 = 2;
            	    int LA70_0 = input.LA(1);

            	    if ( (LA70_0 == LT) )
            	    {
            	        alt70 = 1;
            	    }


            	    switch (alt70) 
            		{
            			case 1 :
            			    // JavaScript.g:134:109: LT
            			    {
            			    	LT131=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1042); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT131);


            			    }
            			    break;

            			default:
            			    goto loop70;
            	    }
            	} while (true);

            	loop70:
            		;	// Stops C# compiler whining that label 'loop70' has no statements

            	char_literal132=(IToken)Match(input,44,FOLLOW_44_in_forStatement1045); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_44.Add(char_literal132);

            	// JavaScript.g:134:117: ( LT )*
            	do 
            	{
            	    int alt71 = 2;
            	    int LA71_0 = input.LA(1);

            	    if ( (LA71_0 == LT) )
            	    {
            	        alt71 = 1;
            	    }


            	    switch (alt71) 
            		{
            			case 1 :
            			    // JavaScript.g:134:117: LT
            			    {
            			    	LT133=(IToken)Match(input,LT,FOLLOW_LT_in_forStatement1047); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT133);


            			    }
            			    break;

            			default:
            			    goto loop71;
            	    }
            	} while (true);

            	loop71:
            		;	// Stops C# compiler whining that label 'loop71' has no statements

            	PushFollow(FOLLOW_statement_in_forStatement1050);
            	statement134 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statement.Add(statement134.Tree);


            	// AST REWRITE
            	// elements:          statement, 52, forStatementInitialiserPart, a, b
            	// token labels:      
            	// rule labels:       retval, b, a
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_b = new RewriteRuleSubtreeStream(adaptor, "rule b", b!=null ? b.Tree : null);
            	RewriteRuleSubtreeStream stream_a = new RewriteRuleSubtreeStream(adaptor, "rule a", a!=null ? a.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 135:2: -> ^( 'for' ^( NIL ( forStatementInitialiserPart )? ) ^( NIL ( $a)? ) ^( NIL ( ^( EXPRESSIONSTATEMENT $b) )? ) statement )
            	{
            	    // JavaScript.g:135:5: ^( 'for' ^( NIL ( forStatementInitialiserPart )? ) ^( NIL ( $a)? ) ^( NIL ( ^( EXPRESSIONSTATEMENT $b) )? ) statement )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new ForStatement(stream_52.NextToken()), root_1);

            	    // JavaScript.g:135:27: ^( NIL ( forStatementInitialiserPart )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_2);

            	    // JavaScript.g:135:43: ( forStatementInitialiserPart )?
            	    if ( stream_forStatementInitialiserPart.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_forStatementInitialiserPart.NextTree());

            	    }
            	    stream_forStatementInitialiserPart.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // JavaScript.g:135:73: ^( NIL ( $a)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_2);

            	    // JavaScript.g:135:89: ( $a)?
            	    if ( stream_a.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_a.NextTree());

            	    }
            	    stream_a.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // JavaScript.g:135:94: ^( NIL ( ^( EXPRESSIONSTATEMENT $b) )? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_2);

            	    // JavaScript.g:135:110: ( ^( EXPRESSIONSTATEMENT $b) )?
            	    if ( stream_b.HasNext() )
            	    {
            	        // JavaScript.g:135:110: ^( EXPRESSIONSTATEMENT $b)
            	        {
            	        object root_3 = (object)adaptor.GetNilNode();
            	        root_3 = (object)adaptor.BecomeRoot(new ExpressionStatement(EXPRESSIONSTATEMENT), root_3);

            	        adaptor.AddChild(root_3, stream_b.NextTree());

            	        adaptor.AddChild(root_2, root_3);
            	        }

            	    }
            	    stream_b.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_statement.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forStatement"

    public class forStatementInitialiserPart_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forStatementInitialiserPart"
    // JavaScript.g:138:1: forStatementInitialiserPart : ( expression -> ^( EXPRESSIONSTATEMENT expression ) | 'var' ( LT )* variableDeclarationList );
    public JavaScriptParser.forStatementInitialiserPart_return forStatementInitialiserPart() // throws RecognitionException [1]
    {   
        JavaScriptParser.forStatementInitialiserPart_return retval = new JavaScriptParser.forStatementInitialiserPart_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal136 = null;
        IToken LT137 = null;
        JavaScriptParser.expression_return expression135 = default(JavaScriptParser.expression_return);

        JavaScriptParser.variableDeclarationList_return variableDeclarationList138 = default(JavaScriptParser.variableDeclarationList_return);


        object string_literal136_tree=null;
        object LT137_tree=null;
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // JavaScript.g:139:2: ( expression -> ^( EXPRESSIONSTATEMENT expression ) | 'var' ( LT )* variableDeclarationList )
            int alt73 = 2;
            int LA73_0 = input.LA(1);

            if ( ((LA73_0 >= Identifier && LA73_0 <= RegexLiteral) || (LA73_0 >= 39 && LA73_0 <= 40) || LA73_0 == 42 || (LA73_0 >= 66 && LA73_0 <= 67) || (LA73_0 >= 99 && LA73_0 <= 100) || (LA73_0 >= 104 && LA73_0 <= 114)) )
            {
                alt73 = 1;
            }
            else if ( (LA73_0 == 45) )
            {
                alt73 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d73s0 =
                    new NoViableAltException("", 73, 0, input);

                throw nvae_d73s0;
            }
            switch (alt73) 
            {
                case 1 :
                    // JavaScript.g:139:4: expression
                    {
                    	PushFollow(FOLLOW_expression_in_forStatementInitialiserPart1113);
                    	expression135 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression135.Tree);


                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 139:16: -> ^( EXPRESSIONSTATEMENT expression )
                    	{
                    	    // JavaScript.g:139:19: ^( EXPRESSIONSTATEMENT expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new ExpressionStatement(EXPRESSIONSTATEMENT), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // JavaScript.g:140:4: 'var' ( LT )* variableDeclarationList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal136=(IToken)Match(input,45,FOLLOW_45_in_forStatementInitialiserPart1130); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal136_tree = new VarDeclStatement(string_literal136) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal136_tree, root_0);
                    	}
                    	// JavaScript.g:140:31: ( LT )*
                    	do 
                    	{
                    	    int alt72 = 2;
                    	    int LA72_0 = input.LA(1);

                    	    if ( (LA72_0 == LT) )
                    	    {
                    	        alt72 = 1;
                    	    }


                    	    switch (alt72) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:140:31: LT
                    			    {
                    			    	LT137=(IToken)Match(input,LT,FOLLOW_LT_in_forStatementInitialiserPart1136); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop72;
                    	    }
                    	} while (true);

                    	loop72:
                    		;	// Stops C# compiler whining that label 'loop72' has no statements

                    	PushFollow(FOLLOW_variableDeclarationList_in_forStatementInitialiserPart1140);
                    	variableDeclarationList138 = variableDeclarationList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableDeclarationList138.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forStatementInitialiserPart"

    public class forInStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forInStatement"
    // JavaScript.g:143:1: forInStatement : 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public JavaScriptParser.forInStatement_return forInStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.forInStatement_return retval = new JavaScriptParser.forInStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal139 = null;
        IToken LT140 = null;
        IToken char_literal141 = null;
        IToken LT142 = null;
        IToken LT144 = null;
        IToken string_literal145 = null;
        IToken LT146 = null;
        IToken LT148 = null;
        IToken char_literal149 = null;
        IToken LT150 = null;
        JavaScriptParser.forInStatementInitialiserPart_return forInStatementInitialiserPart143 = default(JavaScriptParser.forInStatementInitialiserPart_return);

        JavaScriptParser.expression_return expression147 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statement_return statement151 = default(JavaScriptParser.statement_return);


        object string_literal139_tree=null;
        object LT140_tree=null;
        object char_literal141_tree=null;
        object LT142_tree=null;
        object LT144_tree=null;
        object string_literal145_tree=null;
        object LT146_tree=null;
        object LT148_tree=null;
        object char_literal149_tree=null;
        object LT150_tree=null;

        try 
    	{
            // JavaScript.g:144:2: ( 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:144:4: 'for' ( LT )* '(' ( LT )* forInStatementInitialiserPart ( LT )* 'in' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal139=(IToken)Match(input,52,FOLLOW_52_in_forInStatement1152); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal139_tree = new ForInStatement(string_literal139) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal139_tree, root_0);
            	}
            	// JavaScript.g:144:29: ( LT )*
            	do 
            	{
            	    int alt74 = 2;
            	    int LA74_0 = input.LA(1);

            	    if ( (LA74_0 == LT) )
            	    {
            	        alt74 = 1;
            	    }


            	    switch (alt74) 
            		{
            			case 1 :
            			    // JavaScript.g:144:29: LT
            			    {
            			    	LT140=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1158); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop74;
            	    }
            	} while (true);

            	loop74:
            		;	// Stops C# compiler whining that label 'loop74' has no statements

            	char_literal141=(IToken)Match(input,42,FOLLOW_42_in_forInStatement1162); if (state.failed) return retval;
            	// JavaScript.g:144:39: ( LT )*
            	do 
            	{
            	    int alt75 = 2;
            	    int LA75_0 = input.LA(1);

            	    if ( (LA75_0 == LT) )
            	    {
            	        alt75 = 1;
            	    }


            	    switch (alt75) 
            		{
            			case 1 :
            			    // JavaScript.g:144:39: LT
            			    {
            			    	LT142=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1165); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop75;
            	    }
            	} while (true);

            	loop75:
            		;	// Stops C# compiler whining that label 'loop75' has no statements

            	PushFollow(FOLLOW_forInStatementInitialiserPart_in_forInStatement1169);
            	forInStatementInitialiserPart143 = forInStatementInitialiserPart();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forInStatementInitialiserPart143.Tree);
            	// JavaScript.g:144:74: ( LT )*
            	do 
            	{
            	    int alt76 = 2;
            	    int LA76_0 = input.LA(1);

            	    if ( (LA76_0 == LT) )
            	    {
            	        alt76 = 1;
            	    }


            	    switch (alt76) 
            		{
            			case 1 :
            			    // JavaScript.g:144:74: LT
            			    {
            			    	LT144=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1171); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop76;
            	    }
            	} while (true);

            	loop76:
            		;	// Stops C# compiler whining that label 'loop76' has no statements

            	string_literal145=(IToken)Match(input,53,FOLLOW_53_in_forInStatement1175); if (state.failed) return retval;
            	// JavaScript.g:144:85: ( LT )*
            	do 
            	{
            	    int alt77 = 2;
            	    int LA77_0 = input.LA(1);

            	    if ( (LA77_0 == LT) )
            	    {
            	        alt77 = 1;
            	    }


            	    switch (alt77) 
            		{
            			case 1 :
            			    // JavaScript.g:144:85: LT
            			    {
            			    	LT146=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1178); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop77;
            	    }
            	} while (true);

            	loop77:
            		;	// Stops C# compiler whining that label 'loop77' has no statements

            	PushFollow(FOLLOW_expression_in_forInStatement1182);
            	expression147 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression147.Tree);
            	// JavaScript.g:144:101: ( LT )*
            	do 
            	{
            	    int alt78 = 2;
            	    int LA78_0 = input.LA(1);

            	    if ( (LA78_0 == LT) )
            	    {
            	        alt78 = 1;
            	    }


            	    switch (alt78) 
            		{
            			case 1 :
            			    // JavaScript.g:144:101: LT
            			    {
            			    	LT148=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1184); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop78;
            	    }
            	} while (true);

            	loop78:
            		;	// Stops C# compiler whining that label 'loop78' has no statements

            	char_literal149=(IToken)Match(input,44,FOLLOW_44_in_forInStatement1188); if (state.failed) return retval;
            	// JavaScript.g:144:111: ( LT )*
            	do 
            	{
            	    int alt79 = 2;
            	    int LA79_0 = input.LA(1);

            	    if ( (LA79_0 == LT) )
            	    {
            	        alt79 = 1;
            	    }


            	    switch (alt79) 
            		{
            			case 1 :
            			    // JavaScript.g:144:111: LT
            			    {
            			    	LT150=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatement1191); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop79;
            	    }
            	} while (true);

            	loop79:
            		;	// Stops C# compiler whining that label 'loop79' has no statements

            	PushFollow(FOLLOW_statement_in_forInStatement1195);
            	statement151 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement151.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forInStatement"

    public class forInStatementInitialiserPart_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forInStatementInitialiserPart"
    // JavaScript.g:147:1: forInStatementInitialiserPart : ( leftHandSideExpression | 'var' ( LT )* Identifier );
    public JavaScriptParser.forInStatementInitialiserPart_return forInStatementInitialiserPart() // throws RecognitionException [1]
    {   
        JavaScriptParser.forInStatementInitialiserPart_return retval = new JavaScriptParser.forInStatementInitialiserPart_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal153 = null;
        IToken LT154 = null;
        IToken Identifier155 = null;
        JavaScriptParser.leftHandSideExpression_return leftHandSideExpression152 = default(JavaScriptParser.leftHandSideExpression_return);


        object string_literal153_tree=null;
        object LT154_tree=null;
        object Identifier155_tree=null;

        try 
    	{
            // JavaScript.g:148:2: ( leftHandSideExpression | 'var' ( LT )* Identifier )
            int alt81 = 2;
            int LA81_0 = input.LA(1);

            if ( ((LA81_0 >= Identifier && LA81_0 <= RegexLiteral) || (LA81_0 >= 39 && LA81_0 <= 40) || LA81_0 == 42 || (LA81_0 >= 66 && LA81_0 <= 67) || (LA81_0 >= 111 && LA81_0 <= 114)) )
            {
                alt81 = 1;
            }
            else if ( (LA81_0 == 45) )
            {
                alt81 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d81s0 =
                    new NoViableAltException("", 81, 0, input);

                throw nvae_d81s0;
            }
            switch (alt81) 
            {
                case 1 :
                    // JavaScript.g:148:4: leftHandSideExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftHandSideExpression_in_forInStatementInitialiserPart1208);
                    	leftHandSideExpression152 = leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression152.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:149:4: 'var' ( LT )* Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal153=(IToken)Match(input,45,FOLLOW_45_in_forInStatementInitialiserPart1213); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal153_tree = (object)adaptor.Create(string_literal153);
                    		adaptor.AddChild(root_0, string_literal153_tree);
                    	}
                    	// JavaScript.g:149:12: ( LT )*
                    	do 
                    	{
                    	    int alt80 = 2;
                    	    int LA80_0 = input.LA(1);

                    	    if ( (LA80_0 == LT) )
                    	    {
                    	        alt80 = 1;
                    	    }


                    	    switch (alt80) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:149:12: LT
                    			    {
                    			    	LT154=(IToken)Match(input,LT,FOLLOW_LT_in_forInStatementInitialiserPart1215); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop80;
                    	    }
                    	} while (true);

                    	loop80:
                    		;	// Stops C# compiler whining that label 'loop80' has no statements

                    	Identifier155=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_forInStatementInitialiserPart1219); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Identifier155_tree = (object)adaptor.Create(Identifier155);
                    		root_0 = (object)adaptor.BecomeRoot(Identifier155_tree, root_0);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "forInStatementInitialiserPart"

    public class continueStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "continueStatement"
    // JavaScript.g:152:1: continueStatement : 'continue' ( ( Identifier )=> Identifier | ) statementEnd ;
    public JavaScriptParser.continueStatement_return continueStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.continueStatement_return retval = new JavaScriptParser.continueStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal156 = null;
        IToken Identifier157 = null;
        JavaScriptParser.statementEnd_return statementEnd158 = default(JavaScriptParser.statementEnd_return);


        object string_literal156_tree=null;
        object Identifier157_tree=null;

        try 
    	{
            // JavaScript.g:153:2: ( 'continue' ( ( Identifier )=> Identifier | ) statementEnd )
            // JavaScript.g:153:4: 'continue' ( ( Identifier )=> Identifier | ) statementEnd
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal156=(IToken)Match(input,54,FOLLOW_54_in_continueStatement1231); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal156_tree = new ContinueNode(string_literal156) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal156_tree, root_0);
            	}
            	// JavaScript.g:153:30: ( ( Identifier )=> Identifier | )
            	int alt82 = 2;
            	int LA82_0 = input.LA(1);

            	if ( (LA82_0 == Identifier) )
            	{
            	    int LA82_1 = input.LA(2);

            	    if ( (synpred10_JavaScript()) )
            	    {
            	        alt82 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt82 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d82s1 =
            	            new NoViableAltException("", 82, 1, input);

            	        throw nvae_d82s1;
            	    }
            	}
            	else if ( (LA82_0 == EOF || LA82_0 == LT || (LA82_0 >= StringLiteral && LA82_0 <= RegexLiteral) || (LA82_0 >= 39 && LA82_0 <= 42) || LA82_0 == 45 || (LA82_0 >= 47 && LA82_0 <= 52) || (LA82_0 >= 54 && LA82_0 <= 57) || (LA82_0 >= 59 && LA82_0 <= 63) || (LA82_0 >= 66 && LA82_0 <= 67) || (LA82_0 >= 99 && LA82_0 <= 100) || (LA82_0 >= 104 && LA82_0 <= 114)) )
            	{
            	    alt82 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d82s0 =
            	        new NoViableAltException("", 82, 0, input);

            	    throw nvae_d82s0;
            	}
            	switch (alt82) 
            	{
            	    case 1 :
            	        // JavaScript.g:153:31: ( Identifier )=> Identifier
            	        {
            	        	Identifier157=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_continueStatement1244); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier157_tree = (object)adaptor.Create(Identifier157);
            	        		adaptor.AddChild(root_0, Identifier157_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:153:64: 
            	        {
            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statementEnd_in_continueStatement1251);
            	statementEnd158 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "continueStatement"

    public class breakStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "breakStatement"
    // JavaScript.g:156:1: breakStatement : 'break' ( ( Identifier )=> Identifier | ) statementEnd ;
    public JavaScriptParser.breakStatement_return breakStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.breakStatement_return retval = new JavaScriptParser.breakStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal159 = null;
        IToken Identifier160 = null;
        JavaScriptParser.statementEnd_return statementEnd161 = default(JavaScriptParser.statementEnd_return);


        object string_literal159_tree=null;
        object Identifier160_tree=null;

        try 
    	{
            // JavaScript.g:157:2: ( 'break' ( ( Identifier )=> Identifier | ) statementEnd )
            // JavaScript.g:157:4: 'break' ( ( Identifier )=> Identifier | ) statementEnd
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal159=(IToken)Match(input,55,FOLLOW_55_in_breakStatement1264); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal159_tree = new BreakNode(string_literal159) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal159_tree, root_0);
            	}
            	// JavaScript.g:157:24: ( ( Identifier )=> Identifier | )
            	int alt83 = 2;
            	int LA83_0 = input.LA(1);

            	if ( (LA83_0 == Identifier) )
            	{
            	    int LA83_1 = input.LA(2);

            	    if ( (synpred11_JavaScript()) )
            	    {
            	        alt83 = 1;
            	    }
            	    else if ( (true) )
            	    {
            	        alt83 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d83s1 =
            	            new NoViableAltException("", 83, 1, input);

            	        throw nvae_d83s1;
            	    }
            	}
            	else if ( (LA83_0 == EOF || LA83_0 == LT || (LA83_0 >= StringLiteral && LA83_0 <= RegexLiteral) || (LA83_0 >= 39 && LA83_0 <= 42) || LA83_0 == 45 || (LA83_0 >= 47 && LA83_0 <= 52) || (LA83_0 >= 54 && LA83_0 <= 57) || (LA83_0 >= 59 && LA83_0 <= 63) || (LA83_0 >= 66 && LA83_0 <= 67) || (LA83_0 >= 99 && LA83_0 <= 100) || (LA83_0 >= 104 && LA83_0 <= 114)) )
            	{
            	    alt83 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d83s0 =
            	        new NoViableAltException("", 83, 0, input);

            	    throw nvae_d83s0;
            	}
            	switch (alt83) 
            	{
            	    case 1 :
            	        // JavaScript.g:157:25: ( Identifier )=> Identifier
            	        {
            	        	Identifier160=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_breakStatement1277); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{Identifier160_tree = (object)adaptor.Create(Identifier160);
            	        		adaptor.AddChild(root_0, Identifier160_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:157:58: 
            	        {
            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statementEnd_in_breakStatement1284);
            	statementEnd161 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "breakStatement"

    public class returnStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "returnStatement"
    // JavaScript.g:160:1: returnStatement : 'return' ( ( statementEnd )=> () | expression ) statementEnd ;
    public JavaScriptParser.returnStatement_return returnStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.returnStatement_return retval = new JavaScriptParser.returnStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal162 = null;
        JavaScriptParser.expression_return expression163 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statementEnd_return statementEnd164 = default(JavaScriptParser.statementEnd_return);


        object string_literal162_tree=null;

        try 
    	{
            // JavaScript.g:161:2: ( 'return' ( ( statementEnd )=> () | expression ) statementEnd )
            // JavaScript.g:161:4: 'return' ( ( statementEnd )=> () | expression ) statementEnd
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal162=(IToken)Match(input,56,FOLLOW_56_in_returnStatement1297); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal162_tree = new returnStatement(string_literal162) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal162_tree, root_0);
            	}
            	// JavaScript.g:161:31: ( ( statementEnd )=> () | expression )
            	int alt84 = 2;
            	alt84 = dfa84.Predict(input);
            	switch (alt84) 
            	{
            	    case 1 :
            	        // JavaScript.g:161:32: ( statementEnd )=> ()
            	        {
            	        	// JavaScript.g:161:50: ()
            	        	// JavaScript.g:161:51: 
            	        	{
            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:161:54: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_returnStatement1314);
            	        	expression163 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression163.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_statementEnd_in_returnStatement1317);
            	statementEnd164 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "returnStatement"

    public class withStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "withStatement"
    // JavaScript.g:164:1: withStatement : 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement ;
    public JavaScriptParser.withStatement_return withStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.withStatement_return retval = new JavaScriptParser.withStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal165 = null;
        IToken LT166 = null;
        IToken char_literal167 = null;
        IToken LT168 = null;
        IToken LT170 = null;
        IToken char_literal171 = null;
        IToken LT172 = null;
        JavaScriptParser.expression_return expression169 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statement_return statement173 = default(JavaScriptParser.statement_return);


        object string_literal165_tree=null;
        object LT166_tree=null;
        object char_literal167_tree=null;
        object LT168_tree=null;
        object LT170_tree=null;
        object char_literal171_tree=null;
        object LT172_tree=null;

        try 
    	{
            // JavaScript.g:165:2: ( 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement )
            // JavaScript.g:165:4: 'with' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal165=(IToken)Match(input,57,FOLLOW_57_in_withStatement1331); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal165_tree = new WithStatement(string_literal165) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal165_tree, root_0);
            	}
            	// JavaScript.g:165:29: ( LT )*
            	do 
            	{
            	    int alt85 = 2;
            	    int LA85_0 = input.LA(1);

            	    if ( (LA85_0 == LT) )
            	    {
            	        alt85 = 1;
            	    }


            	    switch (alt85) 
            		{
            			case 1 :
            			    // JavaScript.g:165:29: LT
            			    {
            			    	LT166=(IToken)Match(input,LT,FOLLOW_LT_in_withStatement1337); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop85;
            	    }
            	} while (true);

            	loop85:
            		;	// Stops C# compiler whining that label 'loop85' has no statements

            	char_literal167=(IToken)Match(input,42,FOLLOW_42_in_withStatement1341); if (state.failed) return retval;
            	// JavaScript.g:165:39: ( LT )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( (LA86_0 == LT) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // JavaScript.g:165:39: LT
            			    {
            			    	LT168=(IToken)Match(input,LT,FOLLOW_LT_in_withStatement1344); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	PushFollow(FOLLOW_expression_in_withStatement1348);
            	expression169 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression169.Tree);
            	// JavaScript.g:165:55: ( LT )*
            	do 
            	{
            	    int alt87 = 2;
            	    int LA87_0 = input.LA(1);

            	    if ( (LA87_0 == LT) )
            	    {
            	        alt87 = 1;
            	    }


            	    switch (alt87) 
            		{
            			case 1 :
            			    // JavaScript.g:165:55: LT
            			    {
            			    	LT170=(IToken)Match(input,LT,FOLLOW_LT_in_withStatement1350); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop87;
            	    }
            	} while (true);

            	loop87:
            		;	// Stops C# compiler whining that label 'loop87' has no statements

            	char_literal171=(IToken)Match(input,44,FOLLOW_44_in_withStatement1354); if (state.failed) return retval;
            	// JavaScript.g:165:65: ( LT )*
            	do 
            	{
            	    int alt88 = 2;
            	    int LA88_0 = input.LA(1);

            	    if ( (LA88_0 == LT) )
            	    {
            	        alt88 = 1;
            	    }


            	    switch (alt88) 
            		{
            			case 1 :
            			    // JavaScript.g:165:65: LT
            			    {
            			    	LT172=(IToken)Match(input,LT,FOLLOW_LT_in_withStatement1357); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop88;
            	    }
            	} while (true);

            	loop88:
            		;	// Stops C# compiler whining that label 'loop88' has no statements

            	PushFollow(FOLLOW_statement_in_withStatement1361);
            	statement173 = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement173.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "withStatement"

    public class labelledStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "labelledStatement"
    // JavaScript.g:168:1: labelledStatement : Identifier ( LT )* ':' ( LT )* st= statement -> statement ;
    public JavaScriptParser.labelledStatement_return labelledStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.labelledStatement_return retval = new JavaScriptParser.labelledStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier174 = null;
        IToken LT175 = null;
        IToken char_literal176 = null;
        IToken LT177 = null;
        JavaScriptParser.statement_return st = default(JavaScriptParser.statement_return);


        object Identifier174_tree=null;
        object LT175_tree=null;
        object char_literal176_tree=null;
        object LT177_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // JavaScript.g:169:2: ( Identifier ( LT )* ':' ( LT )* st= statement -> statement )
            // JavaScript.g:169:4: Identifier ( LT )* ':' ( LT )* st= statement
            {
            	Identifier174=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_labelledStatement1373); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier174);

            	// JavaScript.g:169:15: ( LT )*
            	do 
            	{
            	    int alt89 = 2;
            	    int LA89_0 = input.LA(1);

            	    if ( (LA89_0 == LT) )
            	    {
            	        alt89 = 1;
            	    }


            	    switch (alt89) 
            		{
            			case 1 :
            			    // JavaScript.g:169:15: LT
            			    {
            			    	LT175=(IToken)Match(input,LT,FOLLOW_LT_in_labelledStatement1375); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT175);


            			    }
            			    break;

            			default:
            			    goto loop89;
            	    }
            	} while (true);

            	loop89:
            		;	// Stops C# compiler whining that label 'loop89' has no statements

            	char_literal176=(IToken)Match(input,58,FOLLOW_58_in_labelledStatement1378); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal176);

            	// JavaScript.g:169:23: ( LT )*
            	do 
            	{
            	    int alt90 = 2;
            	    int LA90_0 = input.LA(1);

            	    if ( (LA90_0 == LT) )
            	    {
            	        alt90 = 1;
            	    }


            	    switch (alt90) 
            		{
            			case 1 :
            			    // JavaScript.g:169:23: LT
            			    {
            			    	LT177=(IToken)Match(input,LT,FOLLOW_LT_in_labelledStatement1380); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT177);


            			    }
            			    break;

            			default:
            			    goto loop90;
            	    }
            	} while (true);

            	loop90:
            		;	// Stops C# compiler whining that label 'loop90' has no statements

            	PushFollow(FOLLOW_statement_in_labelledStatement1385);
            	st = statement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statement.Add(st.Tree);
            	if ( (state.backtracking==0) )
            	{
            	  ((StatementNode)st.Tree).AddLabel(Identifier174.Text);
            	}


            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 169:95: -> statement
            	{
            	    adaptor.AddChild(root_0, stream_statement.NextTree());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "labelledStatement"

    public class switchStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "switchStatement"
    // JavaScript.g:172:1: switchStatement : 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock ;
    public JavaScriptParser.switchStatement_return switchStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.switchStatement_return retval = new JavaScriptParser.switchStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal178 = null;
        IToken LT179 = null;
        IToken char_literal180 = null;
        IToken LT181 = null;
        IToken LT183 = null;
        IToken char_literal184 = null;
        IToken LT185 = null;
        JavaScriptParser.expression_return expression182 = default(JavaScriptParser.expression_return);

        JavaScriptParser.caseBlock_return caseBlock186 = default(JavaScriptParser.caseBlock_return);


        object string_literal178_tree=null;
        object LT179_tree=null;
        object char_literal180_tree=null;
        object LT181_tree=null;
        object LT183_tree=null;
        object char_literal184_tree=null;
        object LT185_tree=null;

        try 
    	{
            // JavaScript.g:173:2: ( 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock )
            // JavaScript.g:173:4: 'switch' ( LT )* '(' ( LT )* expression ( LT )* ')' ( LT )* caseBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal178=(IToken)Match(input,59,FOLLOW_59_in_switchStatement1404); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal178_tree = new SwitchStatement(string_literal178) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal178_tree, root_0);
            	}
            	// JavaScript.g:173:33: ( LT )*
            	do 
            	{
            	    int alt91 = 2;
            	    int LA91_0 = input.LA(1);

            	    if ( (LA91_0 == LT) )
            	    {
            	        alt91 = 1;
            	    }


            	    switch (alt91) 
            		{
            			case 1 :
            			    // JavaScript.g:173:33: LT
            			    {
            			    	LT179=(IToken)Match(input,LT,FOLLOW_LT_in_switchStatement1410); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop91;
            	    }
            	} while (true);

            	loop91:
            		;	// Stops C# compiler whining that label 'loop91' has no statements

            	char_literal180=(IToken)Match(input,42,FOLLOW_42_in_switchStatement1414); if (state.failed) return retval;
            	// JavaScript.g:173:43: ( LT )*
            	do 
            	{
            	    int alt92 = 2;
            	    int LA92_0 = input.LA(1);

            	    if ( (LA92_0 == LT) )
            	    {
            	        alt92 = 1;
            	    }


            	    switch (alt92) 
            		{
            			case 1 :
            			    // JavaScript.g:173:43: LT
            			    {
            			    	LT181=(IToken)Match(input,LT,FOLLOW_LT_in_switchStatement1417); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop92;
            	    }
            	} while (true);

            	loop92:
            		;	// Stops C# compiler whining that label 'loop92' has no statements

            	PushFollow(FOLLOW_expression_in_switchStatement1421);
            	expression182 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression182.Tree);
            	// JavaScript.g:173:59: ( LT )*
            	do 
            	{
            	    int alt93 = 2;
            	    int LA93_0 = input.LA(1);

            	    if ( (LA93_0 == LT) )
            	    {
            	        alt93 = 1;
            	    }


            	    switch (alt93) 
            		{
            			case 1 :
            			    // JavaScript.g:173:59: LT
            			    {
            			    	LT183=(IToken)Match(input,LT,FOLLOW_LT_in_switchStatement1423); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop93;
            	    }
            	} while (true);

            	loop93:
            		;	// Stops C# compiler whining that label 'loop93' has no statements

            	char_literal184=(IToken)Match(input,44,FOLLOW_44_in_switchStatement1427); if (state.failed) return retval;
            	// JavaScript.g:173:69: ( LT )*
            	do 
            	{
            	    int alt94 = 2;
            	    int LA94_0 = input.LA(1);

            	    if ( (LA94_0 == LT) )
            	    {
            	        alt94 = 1;
            	    }


            	    switch (alt94) 
            		{
            			case 1 :
            			    // JavaScript.g:173:69: LT
            			    {
            			    	LT185=(IToken)Match(input,LT,FOLLOW_LT_in_switchStatement1430); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop94;
            	    }
            	} while (true);

            	loop94:
            		;	// Stops C# compiler whining that label 'loop94' has no statements

            	PushFollow(FOLLOW_caseBlock_in_switchStatement1434);
            	caseBlock186 = caseBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseBlock186.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "switchStatement"

    public class caseBlock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "caseBlock"
    // JavaScript.g:176:1: caseBlock : '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' ;
    public JavaScriptParser.caseBlock_return caseBlock() // throws RecognitionException [1]
    {   
        JavaScriptParser.caseBlock_return retval = new JavaScriptParser.caseBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal187 = null;
        IToken LT188 = null;
        IToken LT190 = null;
        IToken LT192 = null;
        IToken LT194 = null;
        IToken char_literal195 = null;
        JavaScriptParser.caseClause_return caseClause189 = default(JavaScriptParser.caseClause_return);

        JavaScriptParser.defaultClause_return defaultClause191 = default(JavaScriptParser.defaultClause_return);

        JavaScriptParser.caseClause_return caseClause193 = default(JavaScriptParser.caseClause_return);


        object char_literal187_tree=null;
        object LT188_tree=null;
        object LT190_tree=null;
        object LT192_tree=null;
        object LT194_tree=null;
        object char_literal195_tree=null;

        try 
    	{
            // JavaScript.g:177:2: ( '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}' )
            // JavaScript.g:177:4: '{' ( ( LT )* caseClause )* ( ( LT )* defaultClause ( ( LT )* caseClause )* )? ( LT )* '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal187=(IToken)Match(input,40,FOLLOW_40_in_caseBlock1447); if (state.failed) return retval;
            	// JavaScript.g:177:9: ( ( LT )* caseClause )*
            	do 
            	{
            	    int alt96 = 2;
            	    alt96 = dfa96.Predict(input);
            	    switch (alt96) 
            		{
            			case 1 :
            			    // JavaScript.g:177:10: ( LT )* caseClause
            			    {
            			    	// JavaScript.g:177:12: ( LT )*
            			    	do 
            			    	{
            			    	    int alt95 = 2;
            			    	    int LA95_0 = input.LA(1);

            			    	    if ( (LA95_0 == LT) )
            			    	    {
            			    	        alt95 = 1;
            			    	    }


            			    	    switch (alt95) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:177:12: LT
            			    			    {
            			    			    	LT188=(IToken)Match(input,LT,FOLLOW_LT_in_caseBlock1451); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop95;
            			    	    }
            			    	} while (true);

            			    	loop95:
            			    		;	// Stops C# compiler whining that label 'loop95' has no statements

            			    	PushFollow(FOLLOW_caseClause_in_caseBlock1455);
            			    	caseClause189 = caseClause();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseClause189.Tree);

            			    }
            			    break;

            			default:
            			    goto loop96;
            	    }
            	} while (true);

            	loop96:
            		;	// Stops C# compiler whining that label 'loop96' has no statements

            	// JavaScript.g:177:28: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?
            	int alt100 = 2;
            	alt100 = dfa100.Predict(input);
            	switch (alt100) 
            	{
            	    case 1 :
            	        // JavaScript.g:177:29: ( LT )* defaultClause ( ( LT )* caseClause )*
            	        {
            	        	// JavaScript.g:177:31: ( LT )*
            	        	do 
            	        	{
            	        	    int alt97 = 2;
            	        	    int LA97_0 = input.LA(1);

            	        	    if ( (LA97_0 == LT) )
            	        	    {
            	        	        alt97 = 1;
            	        	    }


            	        	    switch (alt97) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:177:31: LT
            	        			    {
            	        			    	LT190=(IToken)Match(input,LT,FOLLOW_LT_in_caseBlock1460); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop97;
            	        	    }
            	        	} while (true);

            	        	loop97:
            	        		;	// Stops C# compiler whining that label 'loop97' has no statements

            	        	PushFollow(FOLLOW_defaultClause_in_caseBlock1464);
            	        	defaultClause191 = defaultClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defaultClause191.Tree);
            	        	// JavaScript.g:177:48: ( ( LT )* caseClause )*
            	        	do 
            	        	{
            	        	    int alt99 = 2;
            	        	    alt99 = dfa99.Predict(input);
            	        	    switch (alt99) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:177:49: ( LT )* caseClause
            	        			    {
            	        			    	// JavaScript.g:177:51: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt98 = 2;
            	        			    	    int LA98_0 = input.LA(1);

            	        			    	    if ( (LA98_0 == LT) )
            	        			    	    {
            	        			    	        alt98 = 1;
            	        			    	    }


            	        			    	    switch (alt98) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:177:51: LT
            	        			    			    {
            	        			    			    	LT192=(IToken)Match(input,LT,FOLLOW_LT_in_caseBlock1467); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop98;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop98:
            	        			    		;	// Stops C# compiler whining that label 'loop98' has no statements

            	        			    	PushFollow(FOLLOW_caseClause_in_caseBlock1471);
            	        			    	caseClause193 = caseClause();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, caseClause193.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop99;
            	        	    }
            	        	} while (true);

            	        	loop99:
            	        		;	// Stops C# compiler whining that label 'loop99' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:177:71: ( LT )*
            	do 
            	{
            	    int alt101 = 2;
            	    int LA101_0 = input.LA(1);

            	    if ( (LA101_0 == LT) )
            	    {
            	        alt101 = 1;
            	    }


            	    switch (alt101) 
            		{
            			case 1 :
            			    // JavaScript.g:177:71: LT
            			    {
            			    	LT194=(IToken)Match(input,LT,FOLLOW_LT_in_caseBlock1477); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop101;
            	    }
            	} while (true);

            	loop101:
            		;	// Stops C# compiler whining that label 'loop101' has no statements

            	char_literal195=(IToken)Match(input,41,FOLLOW_41_in_caseBlock1481); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseBlock"

    public class caseClause_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "caseClause"
    // JavaScript.g:180:1: caseClause : 'case' ( LT )* expression ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList ) ;
    public JavaScriptParser.caseClause_return caseClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.caseClause_return retval = new JavaScriptParser.caseClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal196 = null;
        IToken LT197 = null;
        IToken LT199 = null;
        IToken char_literal200 = null;
        IToken LT201 = null;
        JavaScriptParser.expression_return expression198 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statementList_return statementList202 = default(JavaScriptParser.statementList_return);


        object string_literal196_tree=null;
        object LT197_tree=null;
        object LT199_tree=null;
        object char_literal200_tree=null;
        object LT201_tree=null;

        try 
    	{
            // JavaScript.g:181:2: ( 'case' ( LT )* expression ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList ) )
            // JavaScript.g:181:4: 'case' ( LT )* expression ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal196=(IToken)Match(input,60,FOLLOW_60_in_caseClause1493); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal196_tree = new CaseClause(string_literal196) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal196_tree, root_0);
            	}
            	// JavaScript.g:181:26: ( LT )*
            	do 
            	{
            	    int alt102 = 2;
            	    int LA102_0 = input.LA(1);

            	    if ( (LA102_0 == LT) )
            	    {
            	        alt102 = 1;
            	    }


            	    switch (alt102) 
            		{
            			case 1 :
            			    // JavaScript.g:181:26: LT
            			    {
            			    	LT197=(IToken)Match(input,LT,FOLLOW_LT_in_caseClause1499); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop102;
            	    }
            	} while (true);

            	loop102:
            		;	// Stops C# compiler whining that label 'loop102' has no statements

            	PushFollow(FOLLOW_expression_in_caseClause1503);
            	expression198 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression198.Tree);
            	// JavaScript.g:181:42: ( LT )*
            	do 
            	{
            	    int alt103 = 2;
            	    int LA103_0 = input.LA(1);

            	    if ( (LA103_0 == LT) )
            	    {
            	        alt103 = 1;
            	    }


            	    switch (alt103) 
            		{
            			case 1 :
            			    // JavaScript.g:181:42: LT
            			    {
            			    	LT199=(IToken)Match(input,LT,FOLLOW_LT_in_caseClause1505); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop103;
            	    }
            	} while (true);

            	loop103:
            		;	// Stops C# compiler whining that label 'loop103' has no statements

            	char_literal200=(IToken)Match(input,58,FOLLOW_58_in_caseClause1509); if (state.failed) return retval;
            	// JavaScript.g:181:50: ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )
            	int alt105 = 2;
            	alt105 = dfa105.Predict(input);
            	switch (alt105) 
            	{
            	    case 1 :
            	        // JavaScript.g:181:51: ( 'case' | 'default' | '}' )=> ()
            	        {
            	        	// JavaScript.g:181:75: ()
            	        	// JavaScript.g:181:76: 
            	        	{
            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:181:79: ( LT )* statementList
            	        {
            	        	// JavaScript.g:181:81: ( LT )*
            	        	do 
            	        	{
            	        	    int alt104 = 2;
            	        	    int LA104_0 = input.LA(1);

            	        	    if ( (LA104_0 == LT) )
            	        	    {
            	        	        alt104 = 1;
            	        	    }


            	        	    switch (alt104) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:181:81: LT
            	        			    {
            	        			    	LT201=(IToken)Match(input,LT,FOLLOW_LT_in_caseClause1525); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop104;
            	        	    }
            	        	} while (true);

            	        	loop104:
            	        		;	// Stops C# compiler whining that label 'loop104' has no statements

            	        	PushFollow(FOLLOW_statementList_in_caseClause1529);
            	        	statementList202 = statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList202.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "caseClause"

    public class defaultClause_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "defaultClause"
    // JavaScript.g:184:1: defaultClause : 'default' ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList ) ;
    public JavaScriptParser.defaultClause_return defaultClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.defaultClause_return retval = new JavaScriptParser.defaultClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal203 = null;
        IToken LT204 = null;
        IToken char_literal205 = null;
        IToken LT206 = null;
        JavaScriptParser.statementList_return statementList207 = default(JavaScriptParser.statementList_return);


        object string_literal203_tree=null;
        object LT204_tree=null;
        object char_literal205_tree=null;
        object LT206_tree=null;

        try 
    	{
            // JavaScript.g:185:2: ( 'default' ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList ) )
            // JavaScript.g:185:4: 'default' ( LT )* ':' ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal203=(IToken)Match(input,61,FOLLOW_61_in_defaultClause1542); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal203_tree = new DefaultClause(string_literal203) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal203_tree, root_0);
            	}
            	// JavaScript.g:185:32: ( LT )*
            	do 
            	{
            	    int alt106 = 2;
            	    int LA106_0 = input.LA(1);

            	    if ( (LA106_0 == LT) )
            	    {
            	        alt106 = 1;
            	    }


            	    switch (alt106) 
            		{
            			case 1 :
            			    // JavaScript.g:185:32: LT
            			    {
            			    	LT204=(IToken)Match(input,LT,FOLLOW_LT_in_defaultClause1548); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop106;
            	    }
            	} while (true);

            	loop106:
            		;	// Stops C# compiler whining that label 'loop106' has no statements

            	char_literal205=(IToken)Match(input,58,FOLLOW_58_in_defaultClause1552); if (state.failed) return retval;
            	// JavaScript.g:185:40: ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )
            	int alt108 = 2;
            	alt108 = dfa108.Predict(input);
            	switch (alt108) 
            	{
            	    case 1 :
            	        // JavaScript.g:185:41: ( 'case' | 'default' | '}' )=> ()
            	        {
            	        	// JavaScript.g:185:65: ()
            	        	// JavaScript.g:185:66: 
            	        	{
            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:185:69: ( LT )* statementList
            	        {
            	        	// JavaScript.g:185:71: ( LT )*
            	        	do 
            	        	{
            	        	    int alt107 = 2;
            	        	    int LA107_0 = input.LA(1);

            	        	    if ( (LA107_0 == LT) )
            	        	    {
            	        	        alt107 = 1;
            	        	    }


            	        	    switch (alt107) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:185:71: LT
            	        			    {
            	        			    	LT206=(IToken)Match(input,LT,FOLLOW_LT_in_defaultClause1568); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop107;
            	        	    }
            	        	} while (true);

            	        	loop107:
            	        		;	// Stops C# compiler whining that label 'loop107' has no statements

            	        	PushFollow(FOLLOW_statementList_in_defaultClause1572);
            	        	statementList207 = statementList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementList207.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defaultClause"

    public class throwStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "throwStatement"
    // JavaScript.g:188:1: throwStatement : 'throw' expression statementEnd ;
    public JavaScriptParser.throwStatement_return throwStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.throwStatement_return retval = new JavaScriptParser.throwStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal208 = null;
        JavaScriptParser.expression_return expression209 = default(JavaScriptParser.expression_return);

        JavaScriptParser.statementEnd_return statementEnd210 = default(JavaScriptParser.statementEnd_return);


        object string_literal208_tree=null;

        try 
    	{
            // JavaScript.g:189:2: ( 'throw' expression statementEnd )
            // JavaScript.g:189:4: 'throw' expression statementEnd
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal208=(IToken)Match(input,62,FOLLOW_62_in_throwStatement1585); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal208_tree = new ThrowStatement(string_literal208) ;
            		root_0 = (object)adaptor.BecomeRoot(string_literal208_tree, root_0);
            	}
            	PushFollow(FOLLOW_expression_in_throwStatement1591);
            	expression209 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression209.Tree);
            	PushFollow(FOLLOW_statementEnd_in_throwStatement1593);
            	statementEnd210 = statementEnd();
            	state.followingStackPointer--;
            	if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "throwStatement"

    public class tryStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tryStatement"
    // JavaScript.g:192:1: tryStatement : 'try' ( LT )* statementBlock ( LT )* (f= finallyClause | c= catchClause ( ( LT )* f= finallyClause )? ) -> ^( 'try' statementBlock ^( NIL ( $c)? ) ^( NIL ( $f)? ) ) ;
    public JavaScriptParser.tryStatement_return tryStatement() // throws RecognitionException [1]
    {   
        JavaScriptParser.tryStatement_return retval = new JavaScriptParser.tryStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal211 = null;
        IToken LT212 = null;
        IToken LT214 = null;
        IToken LT215 = null;
        JavaScriptParser.finallyClause_return f = default(JavaScriptParser.finallyClause_return);

        JavaScriptParser.catchClause_return c = default(JavaScriptParser.catchClause_return);

        JavaScriptParser.statementBlock_return statementBlock213 = default(JavaScriptParser.statementBlock_return);


        object string_literal211_tree=null;
        object LT212_tree=null;
        object LT214_tree=null;
        object LT215_tree=null;
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_finallyClause = new RewriteRuleSubtreeStream(adaptor,"rule finallyClause");
        RewriteRuleSubtreeStream stream_catchClause = new RewriteRuleSubtreeStream(adaptor,"rule catchClause");
        RewriteRuleSubtreeStream stream_statementBlock = new RewriteRuleSubtreeStream(adaptor,"rule statementBlock");
        try 
    	{
            // JavaScript.g:193:2: ( 'try' ( LT )* statementBlock ( LT )* (f= finallyClause | c= catchClause ( ( LT )* f= finallyClause )? ) -> ^( 'try' statementBlock ^( NIL ( $c)? ) ^( NIL ( $f)? ) ) )
            // JavaScript.g:193:4: 'try' ( LT )* statementBlock ( LT )* (f= finallyClause | c= catchClause ( ( LT )* f= finallyClause )? )
            {
            	string_literal211=(IToken)Match(input,63,FOLLOW_63_in_tryStatement1606); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_63.Add(string_literal211);

            	// JavaScript.g:193:10: ( LT )*
            	do 
            	{
            	    int alt109 = 2;
            	    int LA109_0 = input.LA(1);

            	    if ( (LA109_0 == LT) )
            	    {
            	        alt109 = 1;
            	    }


            	    switch (alt109) 
            		{
            			case 1 :
            			    // JavaScript.g:193:10: LT
            			    {
            			    	LT212=(IToken)Match(input,LT,FOLLOW_LT_in_tryStatement1608); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT212);


            			    }
            			    break;

            			default:
            			    goto loop109;
            	    }
            	} while (true);

            	loop109:
            		;	// Stops C# compiler whining that label 'loop109' has no statements

            	PushFollow(FOLLOW_statementBlock_in_tryStatement1611);
            	statementBlock213 = statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_statementBlock.Add(statementBlock213.Tree);
            	// JavaScript.g:193:29: ( LT )*
            	do 
            	{
            	    int alt110 = 2;
            	    int LA110_0 = input.LA(1);

            	    if ( (LA110_0 == LT) )
            	    {
            	        alt110 = 1;
            	    }


            	    switch (alt110) 
            		{
            			case 1 :
            			    // JavaScript.g:193:29: LT
            			    {
            			    	LT214=(IToken)Match(input,LT,FOLLOW_LT_in_tryStatement1613); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_LT.Add(LT214);


            			    }
            			    break;

            			default:
            			    goto loop110;
            	    }
            	} while (true);

            	loop110:
            		;	// Stops C# compiler whining that label 'loop110' has no statements

            	// JavaScript.g:193:33: (f= finallyClause | c= catchClause ( ( LT )* f= finallyClause )? )
            	int alt113 = 2;
            	int LA113_0 = input.LA(1);

            	if ( (LA113_0 == 65) )
            	{
            	    alt113 = 1;
            	}
            	else if ( (LA113_0 == 64) )
            	{
            	    alt113 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d113s0 =
            	        new NoViableAltException("", 113, 0, input);

            	    throw nvae_d113s0;
            	}
            	switch (alt113) 
            	{
            	    case 1 :
            	        // JavaScript.g:193:34: f= finallyClause
            	        {
            	        	PushFollow(FOLLOW_finallyClause_in_tryStatement1619);
            	        	f = finallyClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_finallyClause.Add(f.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:193:52: c= catchClause ( ( LT )* f= finallyClause )?
            	        {
            	        	PushFollow(FOLLOW_catchClause_in_tryStatement1625);
            	        	c = catchClause();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_catchClause.Add(c.Tree);
            	        	// JavaScript.g:193:66: ( ( LT )* f= finallyClause )?
            	        	int alt112 = 2;
            	        	alt112 = dfa112.Predict(input);
            	        	switch (alt112) 
            	        	{
            	        	    case 1 :
            	        	        // JavaScript.g:193:67: ( LT )* f= finallyClause
            	        	        {
            	        	        	// JavaScript.g:193:67: ( LT )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt111 = 2;
            	        	        	    int LA111_0 = input.LA(1);

            	        	        	    if ( (LA111_0 == LT) )
            	        	        	    {
            	        	        	        alt111 = 1;
            	        	        	    }


            	        	        	    switch (alt111) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // JavaScript.g:193:67: LT
            	        	        			    {
            	        	        			    	LT215=(IToken)Match(input,LT,FOLLOW_LT_in_tryStatement1628); if (state.failed) return retval; 
            	        	        			    	if ( (state.backtracking==0) ) stream_LT.Add(LT215);


            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop111;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop111:
            	        	        		;	// Stops C# compiler whining that label 'loop111' has no statements

            	        	        	PushFollow(FOLLOW_finallyClause_in_tryStatement1633);
            	        	        	f = finallyClause();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_finallyClause.Add(f.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          statementBlock, 63, c, f
            	// token labels:      
            	// rule labels:       f, retval, c
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_f = new RewriteRuleSubtreeStream(adaptor, "rule f", f!=null ? f.Tree : null);
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_c = new RewriteRuleSubtreeStream(adaptor, "rule c", c!=null ? c.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 194:2: -> ^( 'try' statementBlock ^( NIL ( $c)? ) ^( NIL ( $f)? ) )
            	{
            	    // JavaScript.g:194:5: ^( 'try' statementBlock ^( NIL ( $c)? ) ^( NIL ( $f)? ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new tryStatementNode(stream_63.NextToken()), root_1);

            	    adaptor.AddChild(root_1, stream_statementBlock.NextTree());
            	    // JavaScript.g:194:46: ^( NIL ( $c)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_2);

            	    // JavaScript.g:194:62: ( $c)?
            	    if ( stream_c.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_c.NextTree());

            	    }
            	    stream_c.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // JavaScript.g:194:67: ^( NIL ( $f)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_2);

            	    // JavaScript.g:194:83: ( $f)?
            	    if ( stream_f.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_f.NextTree());

            	    }
            	    stream_f.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tryStatement"

    public class catchClause_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "catchClause"
    // JavaScript.g:197:1: catchClause : 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock ;
    public JavaScriptParser.catchClause_return catchClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.catchClause_return retval = new JavaScriptParser.catchClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal216 = null;
        IToken LT217 = null;
        IToken char_literal218 = null;
        IToken LT219 = null;
        IToken Identifier220 = null;
        IToken LT221 = null;
        IToken char_literal222 = null;
        IToken LT223 = null;
        JavaScriptParser.statementBlock_return statementBlock224 = default(JavaScriptParser.statementBlock_return);


        object string_literal216_tree=null;
        object LT217_tree=null;
        object char_literal218_tree=null;
        object LT219_tree=null;
        object Identifier220_tree=null;
        object LT221_tree=null;
        object char_literal222_tree=null;
        object LT223_tree=null;

        try 
    	{
            // JavaScript.g:198:2: ( 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock )
            // JavaScript.g:198:4: 'catch' ( LT )* '(' ( LT )* Identifier ( LT )* ')' ( LT )* statementBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal216=(IToken)Match(input,64,FOLLOW_64_in_catchClause1689); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal216_tree = (object)adaptor.Create(string_literal216);
            		root_0 = (object)adaptor.BecomeRoot(string_literal216_tree, root_0);
            	}
            	// JavaScript.g:198:15: ( LT )*
            	do 
            	{
            	    int alt114 = 2;
            	    int LA114_0 = input.LA(1);

            	    if ( (LA114_0 == LT) )
            	    {
            	        alt114 = 1;
            	    }


            	    switch (alt114) 
            		{
            			case 1 :
            			    // JavaScript.g:198:15: LT
            			    {
            			    	LT217=(IToken)Match(input,LT,FOLLOW_LT_in_catchClause1692); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop114;
            	    }
            	} while (true);

            	loop114:
            		;	// Stops C# compiler whining that label 'loop114' has no statements

            	char_literal218=(IToken)Match(input,42,FOLLOW_42_in_catchClause1696); if (state.failed) return retval;
            	// JavaScript.g:198:25: ( LT )*
            	do 
            	{
            	    int alt115 = 2;
            	    int LA115_0 = input.LA(1);

            	    if ( (LA115_0 == LT) )
            	    {
            	        alt115 = 1;
            	    }


            	    switch (alt115) 
            		{
            			case 1 :
            			    // JavaScript.g:198:25: LT
            			    {
            			    	LT219=(IToken)Match(input,LT,FOLLOW_LT_in_catchClause1699); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop115;
            	    }
            	} while (true);

            	loop115:
            		;	// Stops C# compiler whining that label 'loop115' has no statements

            	Identifier220=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_catchClause1703); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier220_tree = (object)adaptor.Create(Identifier220);
            		adaptor.AddChild(root_0, Identifier220_tree);
            	}
            	// JavaScript.g:198:41: ( LT )*
            	do 
            	{
            	    int alt116 = 2;
            	    int LA116_0 = input.LA(1);

            	    if ( (LA116_0 == LT) )
            	    {
            	        alt116 = 1;
            	    }


            	    switch (alt116) 
            		{
            			case 1 :
            			    // JavaScript.g:198:41: LT
            			    {
            			    	LT221=(IToken)Match(input,LT,FOLLOW_LT_in_catchClause1705); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop116;
            	    }
            	} while (true);

            	loop116:
            		;	// Stops C# compiler whining that label 'loop116' has no statements

            	char_literal222=(IToken)Match(input,44,FOLLOW_44_in_catchClause1709); if (state.failed) return retval;
            	// JavaScript.g:198:51: ( LT )*
            	do 
            	{
            	    int alt117 = 2;
            	    int LA117_0 = input.LA(1);

            	    if ( (LA117_0 == LT) )
            	    {
            	        alt117 = 1;
            	    }


            	    switch (alt117) 
            		{
            			case 1 :
            			    // JavaScript.g:198:51: LT
            			    {
            			    	LT223=(IToken)Match(input,LT,FOLLOW_LT_in_catchClause1712); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop117;
            	    }
            	} while (true);

            	loop117:
            		;	// Stops C# compiler whining that label 'loop117' has no statements

            	PushFollow(FOLLOW_statementBlock_in_catchClause1716);
            	statementBlock224 = statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock224.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "catchClause"

    public class finallyClause_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "finallyClause"
    // JavaScript.g:201:1: finallyClause : 'finally' ( LT )* statementBlock ;
    public JavaScriptParser.finallyClause_return finallyClause() // throws RecognitionException [1]
    {   
        JavaScriptParser.finallyClause_return retval = new JavaScriptParser.finallyClause_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal225 = null;
        IToken LT226 = null;
        JavaScriptParser.statementBlock_return statementBlock227 = default(JavaScriptParser.statementBlock_return);


        object string_literal225_tree=null;
        object LT226_tree=null;

        try 
    	{
            // JavaScript.g:202:2: ( 'finally' ( LT )* statementBlock )
            // JavaScript.g:202:4: 'finally' ( LT )* statementBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal225=(IToken)Match(input,65,FOLLOW_65_in_finallyClause1729); if (state.failed) return retval;
            	// JavaScript.g:202:17: ( LT )*
            	do 
            	{
            	    int alt118 = 2;
            	    int LA118_0 = input.LA(1);

            	    if ( (LA118_0 == LT) )
            	    {
            	        alt118 = 1;
            	    }


            	    switch (alt118) 
            		{
            			case 1 :
            			    // JavaScript.g:202:17: LT
            			    {
            			    	LT226=(IToken)Match(input,LT,FOLLOW_LT_in_finallyClause1732); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop118;
            	    }
            	} while (true);

            	loop118:
            		;	// Stops C# compiler whining that label 'loop118' has no statements

            	PushFollow(FOLLOW_statementBlock_in_finallyClause1736);
            	statementBlock227 = statementBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statementBlock227.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "finallyClause"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // JavaScript.g:206:1: expression : n= assignmentExpression ( ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )* )? ;
    public JavaScriptParser.expression_return expression() // throws RecognitionException [1]
    {   
        JavaScriptParser.expression_return retval = new JavaScriptParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT228 = null;
        IToken char_literal229 = null;
        IToken LT230 = null;
        IToken LT232 = null;
        IToken char_literal233 = null;
        IToken LT234 = null;
        JavaScriptParser.assignmentExpression_return n = default(JavaScriptParser.assignmentExpression_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression231 = default(JavaScriptParser.assignmentExpression_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression235 = default(JavaScriptParser.assignmentExpression_return);


        object LT228_tree=null;
        object char_literal229_tree=null;
        object LT230_tree=null;
        object LT232_tree=null;
        object char_literal233_tree=null;
        object LT234_tree=null;

        try 
    	{
            // JavaScript.g:207:2: (n= assignmentExpression ( ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )* )? )
            // JavaScript.g:207:4: n= assignmentExpression ( ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )* )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignmentExpression_in_expression1751);
            	n = assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, n.Tree);
            	// JavaScript.g:207:27: ( ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )* )?
            	int alt124 = 2;
            	alt124 = dfa124.Predict(input);
            	switch (alt124) 
            	{
            	    case 1 :
            	        // JavaScript.g:207:28: ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        {
            	        	// JavaScript.g:207:28: ( ( LT )* ',' ( LT )* assignmentExpression )
            	        	// JavaScript.g:207:29: ( LT )* ',' ( LT )* assignmentExpression
            	        	{
            	        		// JavaScript.g:207:31: ( LT )*
            	        		do 
            	        		{
            	        		    int alt119 = 2;
            	        		    int LA119_0 = input.LA(1);

            	        		    if ( (LA119_0 == LT) )
            	        		    {
            	        		        alt119 = 1;
            	        		    }


            	        		    switch (alt119) 
            	        			{
            	        				case 1 :
            	        				    // JavaScript.g:207:31: LT
            	        				    {
            	        				    	LT228=(IToken)Match(input,LT,FOLLOW_LT_in_expression1755); if (state.failed) return retval;

            	        				    }
            	        				    break;

            	        				default:
            	        				    goto loop119;
            	        		    }
            	        		} while (true);

            	        		loop119:
            	        			;	// Stops C# compiler whining that label 'loop119' has no statements

            	        		char_literal229=(IToken)Match(input,43,FOLLOW_43_in_expression1759); if (state.failed) return retval;
            	        		if ( state.backtracking == 0 )
            	        		{char_literal229_tree = new CommaExpression(char_literal229) ;
            	        			root_0 = (object)adaptor.BecomeRoot(char_literal229_tree, root_0);
            	        		}
            	        		// JavaScript.g:207:58: ( LT )*
            	        		do 
            	        		{
            	        		    int alt120 = 2;
            	        		    int LA120_0 = input.LA(1);

            	        		    if ( (LA120_0 == LT) )
            	        		    {
            	        		        alt120 = 1;
            	        		    }


            	        		    switch (alt120) 
            	        			{
            	        				case 1 :
            	        				    // JavaScript.g:207:58: LT
            	        				    {
            	        				    	LT230=(IToken)Match(input,LT,FOLLOW_LT_in_expression1765); if (state.failed) return retval;

            	        				    }
            	        				    break;

            	        				default:
            	        				    goto loop120;
            	        		    }
            	        		} while (true);

            	        		loop120:
            	        			;	// Stops C# compiler whining that label 'loop120' has no statements

            	        		PushFollow(FOLLOW_assignmentExpression_in_expression1769);
            	        		assignmentExpression231 = assignmentExpression();
            	        		state.followingStackPointer--;
            	        		if (state.failed) return retval;
            	        		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression231.Tree);

            	        	}

            	        	// JavaScript.g:207:83: ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        	do 
            	        	{
            	        	    int alt123 = 2;
            	        	    alt123 = dfa123.Predict(input);
            	        	    switch (alt123) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:207:84: ( LT )* ',' ( LT )* assignmentExpression
            	        			    {
            	        			    	// JavaScript.g:207:86: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt121 = 2;
            	        			    	    int LA121_0 = input.LA(1);

            	        			    	    if ( (LA121_0 == LT) )
            	        			    	    {
            	        			    	        alt121 = 1;
            	        			    	    }


            	        			    	    switch (alt121) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:207:86: LT
            	        			    			    {
            	        			    			    	LT232=(IToken)Match(input,LT,FOLLOW_LT_in_expression1773); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop121;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop121:
            	        			    		;	// Stops C# compiler whining that label 'loop121' has no statements

            	        			    	char_literal233=(IToken)Match(input,43,FOLLOW_43_in_expression1777); if (state.failed) return retval;
            	        			    	// JavaScript.g:207:96: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt122 = 2;
            	        			    	    int LA122_0 = input.LA(1);

            	        			    	    if ( (LA122_0 == LT) )
            	        			    	    {
            	        			    	        alt122 = 1;
            	        			    	    }


            	        			    	    switch (alt122) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:207:96: LT
            	        			    			    {
            	        			    			    	LT234=(IToken)Match(input,LT,FOLLOW_LT_in_expression1780); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop122;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop122:
            	        			    		;	// Stops C# compiler whining that label 'loop122' has no statements

            	        			    	PushFollow(FOLLOW_assignmentExpression_in_expression1784);
            	        			    	assignmentExpression235 = assignmentExpression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression235.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop123;
            	        	    }
            	        	} while (true);

            	        	loop123:
            	        		;	// Stops C# compiler whining that label 'loop123' has no statements


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class assignmentExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentExpression"
    // JavaScript.g:210:1: assignmentExpression : ( ( leftHandSideExpression ( LT )* assignmentOperator )=> leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression | n= conditionalExpression );
    public JavaScriptParser.assignmentExpression_return assignmentExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.assignmentExpression_return retval = new JavaScriptParser.assignmentExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT237 = null;
        IToken LT239 = null;
        JavaScriptParser.conditionalExpression_return n = default(JavaScriptParser.conditionalExpression_return);

        JavaScriptParser.leftHandSideExpression_return leftHandSideExpression236 = default(JavaScriptParser.leftHandSideExpression_return);

        JavaScriptParser.assignmentOperator_return assignmentOperator238 = default(JavaScriptParser.assignmentOperator_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression240 = default(JavaScriptParser.assignmentExpression_return);


        object LT237_tree=null;
        object LT239_tree=null;

        try 
    	{
            // JavaScript.g:211:2: ( ( leftHandSideExpression ( LT )* assignmentOperator )=> leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression | n= conditionalExpression )
            int alt127 = 2;
            alt127 = dfa127.Predict(input);
            switch (alt127) 
            {
                case 1 :
                    // JavaScript.g:211:4: ( leftHandSideExpression ( LT )* assignmentOperator )=> leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_leftHandSideExpression_in_assignmentExpression1814);
                    	leftHandSideExpression236 = leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression236.Tree);
                    	// JavaScript.g:212:32: ( LT )*
                    	do 
                    	{
                    	    int alt125 = 2;
                    	    int LA125_0 = input.LA(1);

                    	    if ( (LA125_0 == LT) )
                    	    {
                    	        alt125 = 1;
                    	    }


                    	    switch (alt125) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:212:32: LT
                    			    {
                    			    	LT237=(IToken)Match(input,LT,FOLLOW_LT_in_assignmentExpression1816); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop125;
                    	    }
                    	} while (true);

                    	loop125:
                    		;	// Stops C# compiler whining that label 'loop125' has no statements

                    	PushFollow(FOLLOW_assignmentOperator_in_assignmentExpression1820);
                    	assignmentOperator238 = assignmentOperator();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(assignmentOperator238.Tree, root_0);
                    	// JavaScript.g:212:57: ( LT )*
                    	do 
                    	{
                    	    int alt126 = 2;
                    	    int LA126_0 = input.LA(1);

                    	    if ( (LA126_0 == LT) )
                    	    {
                    	        alt126 = 1;
                    	    }


                    	    switch (alt126) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:212:57: LT
                    			    {
                    			    	LT239=(IToken)Match(input,LT,FOLLOW_LT_in_assignmentExpression1823); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop126;
                    	    }
                    	} while (true);

                    	loop126:
                    		;	// Stops C# compiler whining that label 'loop126' has no statements

                    	PushFollow(FOLLOW_assignmentExpression_in_assignmentExpression1827);
                    	assignmentExpression240 = assignmentExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression240.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:213:4: n= conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_assignmentExpression1835);
                    	n = conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, n.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentExpression"

    public class leftHandSideExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "leftHandSideExpression"
    // JavaScript.g:216:1: leftHandSideExpression : ( ( 'new' )=> 'new' ( LT )* leftHandSideExpression | ( 'function' )=> functionExpression | primaryExpression ( ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix )* );
    public JavaScriptParser.leftHandSideExpression_return leftHandSideExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.leftHandSideExpression_return retval = new JavaScriptParser.leftHandSideExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal241 = null;
        IToken LT242 = null;
        IToken LT246 = null;
        JavaScriptParser.leftHandSideExpression_return leftHandSideExpression243 = default(JavaScriptParser.leftHandSideExpression_return);

        JavaScriptParser.functionExpression_return functionExpression244 = default(JavaScriptParser.functionExpression_return);

        JavaScriptParser.primaryExpression_return primaryExpression245 = default(JavaScriptParser.primaryExpression_return);

        JavaScriptParser.expressionSuffix_return expressionSuffix247 = default(JavaScriptParser.expressionSuffix_return);


        object string_literal241_tree=null;
        object LT242_tree=null;
        object LT246_tree=null;

        try 
    	{
            // JavaScript.g:217:2: ( ( 'new' )=> 'new' ( LT )* leftHandSideExpression | ( 'function' )=> functionExpression | primaryExpression ( ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix )* )
            int alt131 = 3;
            int LA131_0 = input.LA(1);

            if ( (LA131_0 == 66) && (synpred16_JavaScript()) )
            {
                alt131 = 1;
            }
            else if ( (LA131_0 == 39) && (synpred17_JavaScript()) )
            {
                alt131 = 2;
            }
            else if ( ((LA131_0 >= Identifier && LA131_0 <= RegexLiteral) || LA131_0 == 40 || LA131_0 == 42 || LA131_0 == 67 || (LA131_0 >= 111 && LA131_0 <= 114)) )
            {
                alt131 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d131s0 =
                    new NoViableAltException("", 131, 0, input);

                throw nvae_d131s0;
            }
            switch (alt131) 
            {
                case 1 :
                    // JavaScript.g:217:4: ( 'new' )=> 'new' ( LT )* leftHandSideExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal241=(IToken)Match(input,66,FOLLOW_66_in_leftHandSideExpression1853); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal241_tree = new NewExpression(string_literal241) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal241_tree, root_0);
                    	}
                    	// JavaScript.g:217:39: ( LT )*
                    	do 
                    	{
                    	    int alt128 = 2;
                    	    int LA128_0 = input.LA(1);

                    	    if ( (LA128_0 == LT) )
                    	    {
                    	        alt128 = 1;
                    	    }


                    	    switch (alt128) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:217:39: LT
                    			    {
                    			    	LT242=(IToken)Match(input,LT,FOLLOW_LT_in_leftHandSideExpression1859); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop128;
                    	    }
                    	} while (true);

                    	loop128:
                    		;	// Stops C# compiler whining that label 'loop128' has no statements

                    	PushFollow(FOLLOW_leftHandSideExpression_in_leftHandSideExpression1863);
                    	leftHandSideExpression243 = leftHandSideExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, leftHandSideExpression243.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:218:4: ( 'function' )=> functionExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionExpression_in_leftHandSideExpression1874);
                    	functionExpression244 = functionExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, functionExpression244.Tree);

                    }
                    break;
                case 3 :
                    // JavaScript.g:219:4: primaryExpression ( ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_primaryExpression_in_leftHandSideExpression1879);
                    	primaryExpression245 = primaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, primaryExpression245.Tree);
                    	// JavaScript.g:219:22: ( ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix )*
                    	do 
                    	{
                    	    int alt130 = 2;
                    	    alt130 = dfa130.Predict(input);
                    	    switch (alt130) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:219:23: ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix
                    			    {
                    			    	// JavaScript.g:219:52: ( LT )*
                    			    	do 
                    			    	{
                    			    	    int alt129 = 2;
                    			    	    int LA129_0 = input.LA(1);

                    			    	    if ( (LA129_0 == LT) )
                    			    	    {
                    			    	        alt129 = 1;
                    			    	    }


                    			    	    switch (alt129) 
                    			    		{
                    			    			case 1 :
                    			    			    // JavaScript.g:219:52: LT
                    			    			    {
                    			    			    	LT246=(IToken)Match(input,LT,FOLLOW_LT_in_leftHandSideExpression1901); if (state.failed) return retval;

                    			    			    }
                    			    			    break;

                    			    			default:
                    			    			    goto loop129;
                    			    	    }
                    			    	} while (true);

                    			    	loop129:
                    			    		;	// Stops C# compiler whining that label 'loop129' has no statements

                    			    	PushFollow(FOLLOW_expressionSuffix_in_leftHandSideExpression1905);
                    			    	expressionSuffix247 = expressionSuffix();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(expressionSuffix247.Tree, root_0);

                    			    }
                    			    break;

                    			default:
                    			    goto loop130;
                    	    }
                    	} while (true);

                    	loop130:
                    		;	// Stops C# compiler whining that label 'loop130' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "leftHandSideExpression"

    public class expressionSuffix_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionSuffix"
    // JavaScript.g:222:1: expressionSuffix : ( ( '(' )=> arguments -> ^( CALL arguments ) | ( '[' )=> '[' ( LT )* expression ( LT )* ']' -> ^( '[' expression ) | '.' ( LT )* Identifier -> ^( '.' Identifier ) );
    public JavaScriptParser.expressionSuffix_return expressionSuffix() // throws RecognitionException [1]
    {   
        JavaScriptParser.expressionSuffix_return retval = new JavaScriptParser.expressionSuffix_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal249 = null;
        IToken LT250 = null;
        IToken LT252 = null;
        IToken char_literal253 = null;
        IToken char_literal254 = null;
        IToken LT255 = null;
        IToken Identifier256 = null;
        JavaScriptParser.arguments_return arguments248 = default(JavaScriptParser.arguments_return);

        JavaScriptParser.expression_return expression251 = default(JavaScriptParser.expression_return);


        object char_literal249_tree=null;
        object LT250_tree=null;
        object LT252_tree=null;
        object char_literal253_tree=null;
        object char_literal254_tree=null;
        object LT255_tree=null;
        object Identifier256_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_LT = new RewriteRuleTokenStream(adaptor,"token LT");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // JavaScript.g:223:2: ( ( '(' )=> arguments -> ^( CALL arguments ) | ( '[' )=> '[' ( LT )* expression ( LT )* ']' -> ^( '[' expression ) | '.' ( LT )* Identifier -> ^( '.' Identifier ) )
            int alt135 = 3;
            int LA135_0 = input.LA(1);

            if ( (LA135_0 == 42) && (synpred19_JavaScript()) )
            {
                alt135 = 1;
            }
            else if ( (LA135_0 == 67) && (synpred20_JavaScript()) )
            {
                alt135 = 2;
            }
            else if ( (LA135_0 == 69) )
            {
                alt135 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d135s0 =
                    new NoViableAltException("", 135, 0, input);

                throw nvae_d135s0;
            }
            switch (alt135) 
            {
                case 1 :
                    // JavaScript.g:223:4: ( '(' )=> arguments
                    {
                    	PushFollow(FOLLOW_arguments_in_expressionSuffix1925);
                    	arguments248 = arguments();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_arguments.Add(arguments248.Tree);


                    	// AST REWRITE
                    	// elements:          arguments
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 223:23: -> ^( CALL arguments )
                    	{
                    	    // JavaScript.g:223:26: ^( CALL arguments )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new FunctionCallNode(CALL), root_1);

                    	    adaptor.AddChild(root_1, stream_arguments.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // JavaScript.g:224:4: ( '[' )=> '[' ( LT )* expression ( LT )* ']'
                    {
                    	char_literal249=(IToken)Match(input,67,FOLLOW_67_in_expressionSuffix1947); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_67.Add(char_literal249);

                    	// JavaScript.g:224:17: ( LT )*
                    	do 
                    	{
                    	    int alt132 = 2;
                    	    int LA132_0 = input.LA(1);

                    	    if ( (LA132_0 == LT) )
                    	    {
                    	        alt132 = 1;
                    	    }


                    	    switch (alt132) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:224:17: LT
                    			    {
                    			    	LT250=(IToken)Match(input,LT,FOLLOW_LT_in_expressionSuffix1949); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT250);


                    			    }
                    			    break;

                    			default:
                    			    goto loop132;
                    	    }
                    	} while (true);

                    	loop132:
                    		;	// Stops C# compiler whining that label 'loop132' has no statements

                    	PushFollow(FOLLOW_expression_in_expressionSuffix1952);
                    	expression251 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_expression.Add(expression251.Tree);
                    	// JavaScript.g:224:32: ( LT )*
                    	do 
                    	{
                    	    int alt133 = 2;
                    	    int LA133_0 = input.LA(1);

                    	    if ( (LA133_0 == LT) )
                    	    {
                    	        alt133 = 1;
                    	    }


                    	    switch (alt133) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:224:32: LT
                    			    {
                    			    	LT252=(IToken)Match(input,LT,FOLLOW_LT_in_expressionSuffix1954); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT252);


                    			    }
                    			    break;

                    			default:
                    			    goto loop133;
                    	    }
                    	} while (true);

                    	loop133:
                    		;	// Stops C# compiler whining that label 'loop133' has no statements

                    	char_literal253=(IToken)Match(input,68,FOLLOW_68_in_expressionSuffix1957); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_68.Add(char_literal253);



                    	// AST REWRITE
                    	// elements:          67, expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 224:40: -> ^( '[' expression )
                    	{
                    	    // JavaScript.g:224:43: ^( '[' expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new IndexNode(stream_67.NextToken()), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // JavaScript.g:225:4: '.' ( LT )* Identifier
                    {
                    	char_literal254=(IToken)Match(input,69,FOLLOW_69_in_expressionSuffix1973); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_69.Add(char_literal254);

                    	// JavaScript.g:225:8: ( LT )*
                    	do 
                    	{
                    	    int alt134 = 2;
                    	    int LA134_0 = input.LA(1);

                    	    if ( (LA134_0 == LT) )
                    	    {
                    	        alt134 = 1;
                    	    }


                    	    switch (alt134) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:225:8: LT
                    			    {
                    			    	LT255=(IToken)Match(input,LT,FOLLOW_LT_in_expressionSuffix1975); if (state.failed) return retval; 
                    			    	if ( (state.backtracking==0) ) stream_LT.Add(LT255);


                    			    }
                    			    break;

                    			default:
                    			    goto loop134;
                    	    }
                    	} while (true);

                    	loop134:
                    		;	// Stops C# compiler whining that label 'loop134' has no statements

                    	Identifier256=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_expressionSuffix1978); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier256);



                    	// AST REWRITE
                    	// elements:          69, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 225:23: -> ^( '.' Identifier )
                    	{
                    	    // JavaScript.g:225:26: ^( '.' Identifier )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(new PropertyRefNode(stream_69.NextToken()), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionSuffix"

    public class arguments_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // JavaScript.g:228:1: arguments : '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' ;
    public JavaScriptParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        JavaScriptParser.arguments_return retval = new JavaScriptParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal257 = null;
        IToken LT258 = null;
        IToken LT260 = null;
        IToken char_literal261 = null;
        IToken LT262 = null;
        IToken LT264 = null;
        IToken char_literal265 = null;
        JavaScriptParser.assignmentExpression_return assignmentExpression259 = default(JavaScriptParser.assignmentExpression_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression263 = default(JavaScriptParser.assignmentExpression_return);


        object char_literal257_tree=null;
        object LT258_tree=null;
        object LT260_tree=null;
        object char_literal261_tree=null;
        object LT262_tree=null;
        object LT264_tree=null;
        object char_literal265_tree=null;

        try 
    	{
            // JavaScript.g:229:2: ( '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')' )
            // JavaScript.g:229:4: '(' ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )? ( LT )* ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal257=(IToken)Match(input,42,FOLLOW_42_in_arguments2001); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal257_tree = new baseNode(char_literal257) ;
            		root_0 = (object)adaptor.BecomeRoot(char_literal257_tree, root_0);
            	}
            	// JavaScript.g:229:19: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?
            	int alt140 = 2;
            	alt140 = dfa140.Predict(input);
            	switch (alt140) 
            	{
            	    case 1 :
            	        // JavaScript.g:229:20: ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        {
            	        	// JavaScript.g:229:22: ( LT )*
            	        	do 
            	        	{
            	        	    int alt136 = 2;
            	        	    int LA136_0 = input.LA(1);

            	        	    if ( (LA136_0 == LT) )
            	        	    {
            	        	        alt136 = 1;
            	        	    }


            	        	    switch (alt136) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:229:22: LT
            	        			    {
            	        			    	LT258=(IToken)Match(input,LT,FOLLOW_LT_in_arguments2008); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop136;
            	        	    }
            	        	} while (true);

            	        	loop136:
            	        		;	// Stops C# compiler whining that label 'loop136' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_arguments2012);
            	        	assignmentExpression259 = assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression259.Tree);
            	        	// JavaScript.g:229:46: ( ( LT )* ',' ( LT )* assignmentExpression )*
            	        	do 
            	        	{
            	        	    int alt139 = 2;
            	        	    alt139 = dfa139.Predict(input);
            	        	    switch (alt139) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:229:47: ( LT )* ',' ( LT )* assignmentExpression
            	        			    {
            	        			    	// JavaScript.g:229:49: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt137 = 2;
            	        			    	    int LA137_0 = input.LA(1);

            	        			    	    if ( (LA137_0 == LT) )
            	        			    	    {
            	        			    	        alt137 = 1;
            	        			    	    }


            	        			    	    switch (alt137) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:229:49: LT
            	        			    			    {
            	        			    			    	LT260=(IToken)Match(input,LT,FOLLOW_LT_in_arguments2015); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop137;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop137:
            	        			    		;	// Stops C# compiler whining that label 'loop137' has no statements

            	        			    	char_literal261=(IToken)Match(input,43,FOLLOW_43_in_arguments2019); if (state.failed) return retval;
            	        			    	// JavaScript.g:229:59: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt138 = 2;
            	        			    	    int LA138_0 = input.LA(1);

            	        			    	    if ( (LA138_0 == LT) )
            	        			    	    {
            	        			    	        alt138 = 1;
            	        			    	    }


            	        			    	    switch (alt138) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:229:59: LT
            	        			    			    {
            	        			    			    	LT262=(IToken)Match(input,LT,FOLLOW_LT_in_arguments2022); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop138;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop138:
            	        			    		;	// Stops C# compiler whining that label 'loop138' has no statements

            	        			    	PushFollow(FOLLOW_assignmentExpression_in_arguments2026);
            	        			    	assignmentExpression263 = assignmentExpression();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression263.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop139;
            	        	    }
            	        	} while (true);

            	        	loop139:
            	        		;	// Stops C# compiler whining that label 'loop139' has no statements


            	        }
            	        break;

            	}

            	// JavaScript.g:229:89: ( LT )*
            	do 
            	{
            	    int alt141 = 2;
            	    int LA141_0 = input.LA(1);

            	    if ( (LA141_0 == LT) )
            	    {
            	        alt141 = 1;
            	    }


            	    switch (alt141) 
            		{
            			case 1 :
            			    // JavaScript.g:229:89: LT
            			    {
            			    	LT264=(IToken)Match(input,LT,FOLLOW_LT_in_arguments2032); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop141;
            	    }
            	} while (true);

            	loop141:
            		;	// Stops C# compiler whining that label 'loop141' has no statements

            	char_literal265=(IToken)Match(input,44,FOLLOW_44_in_arguments2036); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class assignmentOperator_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentOperator"
    // JavaScript.g:232:1: assignmentOperator : ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' );
    public JavaScriptParser.assignmentOperator_return assignmentOperator() // throws RecognitionException [1]
    {   
        JavaScriptParser.assignmentOperator_return retval = new JavaScriptParser.assignmentOperator_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal266 = null;
        IToken string_literal267 = null;
        IToken string_literal268 = null;
        IToken string_literal269 = null;
        IToken string_literal270 = null;
        IToken string_literal271 = null;
        IToken string_literal272 = null;
        IToken string_literal273 = null;
        IToken string_literal274 = null;
        IToken string_literal275 = null;
        IToken string_literal276 = null;
        IToken string_literal277 = null;

        object char_literal266_tree=null;
        object string_literal267_tree=null;
        object string_literal268_tree=null;
        object string_literal269_tree=null;
        object string_literal270_tree=null;
        object string_literal271_tree=null;
        object string_literal272_tree=null;
        object string_literal273_tree=null;
        object string_literal274_tree=null;
        object string_literal275_tree=null;
        object string_literal276_tree=null;
        object string_literal277_tree=null;

        try 
    	{
            // JavaScript.g:233:2: ( '=' | '*=' | '/=' | '%=' | '+=' | '-=' | '<<=' | '>>=' | '>>>=' | '&=' | '^=' | '|=' )
            int alt142 = 12;
            switch ( input.LA(1) ) 
            {
            case 46:
            	{
                alt142 = 1;
                }
                break;
            case 70:
            	{
                alt142 = 2;
                }
                break;
            case 71:
            	{
                alt142 = 3;
                }
                break;
            case 72:
            	{
                alt142 = 4;
                }
                break;
            case 73:
            	{
                alt142 = 5;
                }
                break;
            case 74:
            	{
                alt142 = 6;
                }
                break;
            case 75:
            	{
                alt142 = 7;
                }
                break;
            case 76:
            	{
                alt142 = 8;
                }
                break;
            case 77:
            	{
                alt142 = 9;
                }
                break;
            case 78:
            	{
                alt142 = 10;
                }
                break;
            case 79:
            	{
                alt142 = 11;
                }
                break;
            case 80:
            	{
                alt142 = 12;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d142s0 =
            	        new NoViableAltException("", 142, 0, input);

            	    throw nvae_d142s0;
            }

            switch (alt142) 
            {
                case 1 :
                    // JavaScript.g:233:4: '='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal266=(IToken)Match(input,46,FOLLOW_46_in_assignmentOperator2050); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal266_tree = new AssignmentNode(char_literal266) ;
                    		root_0 = (object)adaptor.BecomeRoot(char_literal266_tree, root_0);
                    	}

                    }
                    break;
                case 2 :
                    // JavaScript.g:234:4: '*='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal267=(IToken)Match(input,70,FOLLOW_70_in_assignmentOperator2061); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal267_tree = new CompoundMultNode(string_literal267) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal267_tree, root_0);
                    	}

                    }
                    break;
                case 3 :
                    // JavaScript.g:235:4: '/='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal268=(IToken)Match(input,71,FOLLOW_71_in_assignmentOperator2071); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal268_tree = new CompoundDivNode(string_literal268) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal268_tree, root_0);
                    	}

                    }
                    break;
                case 4 :
                    // JavaScript.g:236:4: '%='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal269=(IToken)Match(input,72,FOLLOW_72_in_assignmentOperator2081); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal269_tree = new CompoundModNode(string_literal269) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal269_tree, root_0);
                    	}

                    }
                    break;
                case 5 :
                    // JavaScript.g:237:4: '+='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal270=(IToken)Match(input,73,FOLLOW_73_in_assignmentOperator2091); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal270_tree = new CompoundAddNode(string_literal270) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal270_tree, root_0);
                    	}

                    }
                    break;
                case 6 :
                    // JavaScript.g:238:4: '-='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal271=(IToken)Match(input,74,FOLLOW_74_in_assignmentOperator2101); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal271_tree = new CompoundSubNode(string_literal271) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal271_tree, root_0);
                    	}

                    }
                    break;
                case 7 :
                    // JavaScript.g:239:4: '<<='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal272=(IToken)Match(input,75,FOLLOW_75_in_assignmentOperator2111); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal272_tree = new CompoundLShiftNode(string_literal272) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal272_tree, root_0);
                    	}

                    }
                    break;
                case 8 :
                    // JavaScript.g:240:4: '>>='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal273=(IToken)Match(input,76,FOLLOW_76_in_assignmentOperator2121); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal273_tree = new CompoundRShiftNode(string_literal273) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal273_tree, root_0);
                    	}

                    }
                    break;
                case 9 :
                    // JavaScript.g:241:4: '>>>='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal274=(IToken)Match(input,77,FOLLOW_77_in_assignmentOperator2131); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal274_tree = new CompoundRUShiftNode(string_literal274) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal274_tree, root_0);
                    	}

                    }
                    break;
                case 10 :
                    // JavaScript.g:242:4: '&='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal275=(IToken)Match(input,78,FOLLOW_78_in_assignmentOperator2141); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal275_tree = new CompoundAndNode(string_literal275) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal275_tree, root_0);
                    	}

                    }
                    break;
                case 11 :
                    // JavaScript.g:243:4: '^='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal276=(IToken)Match(input,79,FOLLOW_79_in_assignmentOperator2151); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal276_tree = new CompoundXOrNode(string_literal276) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal276_tree, root_0);
                    	}

                    }
                    break;
                case 12 :
                    // JavaScript.g:244:4: '|='
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal277=(IToken)Match(input,80,FOLLOW_80_in_assignmentOperator2161); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal277_tree = new CompoundOrNode(string_literal277) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal277_tree, root_0);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignmentOperator"

    public class conditionalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalExpression"
    // JavaScript.g:247:1: conditionalExpression : logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? ;
    public JavaScriptParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.conditionalExpression_return retval = new JavaScriptParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT279 = null;
        IToken char_literal280 = null;
        IToken LT281 = null;
        IToken LT283 = null;
        IToken char_literal284 = null;
        IToken LT285 = null;
        JavaScriptParser.logicalORExpression_return logicalORExpression278 = default(JavaScriptParser.logicalORExpression_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression282 = default(JavaScriptParser.assignmentExpression_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression286 = default(JavaScriptParser.assignmentExpression_return);


        object LT279_tree=null;
        object char_literal280_tree=null;
        object LT281_tree=null;
        object LT283_tree=null;
        object char_literal284_tree=null;
        object LT285_tree=null;

        try 
    	{
            // JavaScript.g:248:2: ( logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )? )
            // JavaScript.g:248:4: logicalORExpression ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalORExpression_in_conditionalExpression2177);
            	logicalORExpression278 = logicalORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalORExpression278.Tree);
            	// JavaScript.g:248:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?
            	int alt147 = 2;
            	alt147 = dfa147.Predict(input);
            	switch (alt147) 
            	{
            	    case 1 :
            	        // JavaScript.g:248:25: ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression
            	        {
            	        	// JavaScript.g:248:27: ( LT )*
            	        	do 
            	        	{
            	        	    int alt143 = 2;
            	        	    int LA143_0 = input.LA(1);

            	        	    if ( (LA143_0 == LT) )
            	        	    {
            	        	        alt143 = 1;
            	        	    }


            	        	    switch (alt143) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:248:27: LT
            	        			    {
            	        			    	LT279=(IToken)Match(input,LT,FOLLOW_LT_in_conditionalExpression2180); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop143;
            	        	    }
            	        	} while (true);

            	        	loop143:
            	        		;	// Stops C# compiler whining that label 'loop143' has no statements

            	        	char_literal280=(IToken)Match(input,81,FOLLOW_81_in_conditionalExpression2184); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal280_tree = new ConditionalExpression(char_literal280) ;
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal280_tree, root_0);
            	        	}
            	        	// JavaScript.g:248:60: ( LT )*
            	        	do 
            	        	{
            	        	    int alt144 = 2;
            	        	    int LA144_0 = input.LA(1);

            	        	    if ( (LA144_0 == LT) )
            	        	    {
            	        	        alt144 = 1;
            	        	    }


            	        	    switch (alt144) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:248:60: LT
            	        			    {
            	        			    	LT281=(IToken)Match(input,LT,FOLLOW_LT_in_conditionalExpression2190); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop144;
            	        	    }
            	        	} while (true);

            	        	loop144:
            	        		;	// Stops C# compiler whining that label 'loop144' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression2194);
            	        	assignmentExpression282 = assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression282.Tree);
            	        	// JavaScript.g:248:86: ( LT )*
            	        	do 
            	        	{
            	        	    int alt145 = 2;
            	        	    int LA145_0 = input.LA(1);

            	        	    if ( (LA145_0 == LT) )
            	        	    {
            	        	        alt145 = 1;
            	        	    }


            	        	    switch (alt145) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:248:86: LT
            	        			    {
            	        			    	LT283=(IToken)Match(input,LT,FOLLOW_LT_in_conditionalExpression2196); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop145;
            	        	    }
            	        	} while (true);

            	        	loop145:
            	        		;	// Stops C# compiler whining that label 'loop145' has no statements

            	        	char_literal284=(IToken)Match(input,58,FOLLOW_58_in_conditionalExpression2200); if (state.failed) return retval;
            	        	// JavaScript.g:248:96: ( LT )*
            	        	do 
            	        	{
            	        	    int alt146 = 2;
            	        	    int LA146_0 = input.LA(1);

            	        	    if ( (LA146_0 == LT) )
            	        	    {
            	        	        alt146 = 1;
            	        	    }


            	        	    switch (alt146) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:248:96: LT
            	        			    {
            	        			    	LT285=(IToken)Match(input,LT,FOLLOW_LT_in_conditionalExpression2203); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop146;
            	        	    }
            	        	} while (true);

            	        	loop146:
            	        		;	// Stops C# compiler whining that label 'loop146' has no statements

            	        	PushFollow(FOLLOW_assignmentExpression_in_conditionalExpression2207);
            	        	assignmentExpression286 = assignmentExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression286.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public class logicalORExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalORExpression"
    // JavaScript.g:251:1: logicalORExpression : logicalANDExpression ( ( LT )* ( '||' ( LT )* n= logicalANDExpression ) )* ;
    public JavaScriptParser.logicalORExpression_return logicalORExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.logicalORExpression_return retval = new JavaScriptParser.logicalORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT288 = null;
        IToken string_literal289 = null;
        IToken LT290 = null;
        JavaScriptParser.logicalANDExpression_return n = default(JavaScriptParser.logicalANDExpression_return);

        JavaScriptParser.logicalANDExpression_return logicalANDExpression287 = default(JavaScriptParser.logicalANDExpression_return);


        object LT288_tree=null;
        object string_literal289_tree=null;
        object LT290_tree=null;

        try 
    	{
            // JavaScript.g:252:2: ( logicalANDExpression ( ( LT )* ( '||' ( LT )* n= logicalANDExpression ) )* )
            // JavaScript.g:252:4: logicalANDExpression ( ( LT )* ( '||' ( LT )* n= logicalANDExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression2221);
            	logicalANDExpression287 = logicalANDExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logicalANDExpression287.Tree);
            	// JavaScript.g:252:25: ( ( LT )* ( '||' ( LT )* n= logicalANDExpression ) )*
            	do 
            	{
            	    int alt150 = 2;
            	    alt150 = dfa150.Predict(input);
            	    switch (alt150) 
            		{
            			case 1 :
            			    // JavaScript.g:252:26: ( LT )* ( '||' ( LT )* n= logicalANDExpression )
            			    {
            			    	// JavaScript.g:252:28: ( LT )*
            			    	do 
            			    	{
            			    	    int alt148 = 2;
            			    	    int LA148_0 = input.LA(1);

            			    	    if ( (LA148_0 == LT) )
            			    	    {
            			    	        alt148 = 1;
            			    	    }


            			    	    switch (alt148) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:252:28: LT
            			    			    {
            			    			    	LT288=(IToken)Match(input,LT,FOLLOW_LT_in_logicalORExpression2224); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop148;
            			    	    }
            			    	} while (true);

            			    	loop148:
            			    		;	// Stops C# compiler whining that label 'loop148' has no statements

            			    	// JavaScript.g:252:31: ( '||' ( LT )* n= logicalANDExpression )
            			    	// JavaScript.g:252:33: '||' ( LT )* n= logicalANDExpression
            			    	{
            			    		string_literal289=(IToken)Match(input,82,FOLLOW_82_in_logicalORExpression2230); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal289_tree = new LogicalOrNode(string_literal289) ;
            			    			root_0 = (object)adaptor.BecomeRoot(string_literal289_tree, root_0);
            			    		}
            			    		// JavaScript.g:252:56: ( LT )*
            			    		do 
            			    		{
            			    		    int alt149 = 2;
            			    		    int LA149_0 = input.LA(1);

            			    		    if ( (LA149_0 == LT) )
            			    		    {
            			    		        alt149 = 1;
            			    		    }


            			    		    switch (alt149) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:252:56: LT
            			    				    {
            			    				    	LT290=(IToken)Match(input,LT,FOLLOW_LT_in_logicalORExpression2236); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop149;
            			    		    }
            			    		} while (true);

            			    		loop149:
            			    			;	// Stops C# compiler whining that label 'loop149' has no statements

            			    		PushFollow(FOLLOW_logicalANDExpression_in_logicalORExpression2242);
            			    		n = logicalANDExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, n.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop150;
            	    }
            	} while (true);

            	loop150:
            		;	// Stops C# compiler whining that label 'loop150' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalORExpression"

    public class logicalANDExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "logicalANDExpression"
    // JavaScript.g:255:1: logicalANDExpression : bitwiseORExpression ( ( LT )* ( '&&' ( LT )* bitwiseORExpression ) )* ;
    public JavaScriptParser.logicalANDExpression_return logicalANDExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.logicalANDExpression_return retval = new JavaScriptParser.logicalANDExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT292 = null;
        IToken string_literal293 = null;
        IToken LT294 = null;
        JavaScriptParser.bitwiseORExpression_return bitwiseORExpression291 = default(JavaScriptParser.bitwiseORExpression_return);

        JavaScriptParser.bitwiseORExpression_return bitwiseORExpression295 = default(JavaScriptParser.bitwiseORExpression_return);


        object LT292_tree=null;
        object string_literal293_tree=null;
        object LT294_tree=null;

        try 
    	{
            // JavaScript.g:256:2: ( bitwiseORExpression ( ( LT )* ( '&&' ( LT )* bitwiseORExpression ) )* )
            // JavaScript.g:256:4: bitwiseORExpression ( ( LT )* ( '&&' ( LT )* bitwiseORExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression2258);
            	bitwiseORExpression291 = bitwiseORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpression291.Tree);
            	// JavaScript.g:256:24: ( ( LT )* ( '&&' ( LT )* bitwiseORExpression ) )*
            	do 
            	{
            	    int alt153 = 2;
            	    alt153 = dfa153.Predict(input);
            	    switch (alt153) 
            		{
            			case 1 :
            			    // JavaScript.g:256:25: ( LT )* ( '&&' ( LT )* bitwiseORExpression )
            			    {
            			    	// JavaScript.g:256:27: ( LT )*
            			    	do 
            			    	{
            			    	    int alt151 = 2;
            			    	    int LA151_0 = input.LA(1);

            			    	    if ( (LA151_0 == LT) )
            			    	    {
            			    	        alt151 = 1;
            			    	    }


            			    	    switch (alt151) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:256:27: LT
            			    			    {
            			    			    	LT292=(IToken)Match(input,LT,FOLLOW_LT_in_logicalANDExpression2261); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop151;
            			    	    }
            			    	} while (true);

            			    	loop151:
            			    		;	// Stops C# compiler whining that label 'loop151' has no statements

            			    	// JavaScript.g:256:30: ( '&&' ( LT )* bitwiseORExpression )
            			    	// JavaScript.g:256:32: '&&' ( LT )* bitwiseORExpression
            			    	{
            			    		string_literal293=(IToken)Match(input,83,FOLLOW_83_in_logicalANDExpression2267); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{string_literal293_tree = new LogicalAndNode(string_literal293) ;
            			    			root_0 = (object)adaptor.BecomeRoot(string_literal293_tree, root_0);
            			    		}
            			    		// JavaScript.g:256:56: ( LT )*
            			    		do 
            			    		{
            			    		    int alt152 = 2;
            			    		    int LA152_0 = input.LA(1);

            			    		    if ( (LA152_0 == LT) )
            			    		    {
            			    		        alt152 = 1;
            			    		    }


            			    		    switch (alt152) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:256:56: LT
            			    				    {
            			    				    	LT294=(IToken)Match(input,LT,FOLLOW_LT_in_logicalANDExpression2273); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop152;
            			    		    }
            			    		} while (true);

            			    		loop152:
            			    			;	// Stops C# compiler whining that label 'loop152' has no statements

            			    		PushFollow(FOLLOW_bitwiseORExpression_in_logicalANDExpression2277);
            			    		bitwiseORExpression295 = bitwiseORExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseORExpression295.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop153;
            	    }
            	} while (true);

            	loop153:
            		;	// Stops C# compiler whining that label 'loop153' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalANDExpression"

    public class bitwiseORExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseORExpression"
    // JavaScript.g:259:1: bitwiseORExpression : bitwiseXORExpression ( ( LT )* ( '|' ( LT )* bitwiseXORExpression ) )* ;
    public JavaScriptParser.bitwiseORExpression_return bitwiseORExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.bitwiseORExpression_return retval = new JavaScriptParser.bitwiseORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT297 = null;
        IToken char_literal298 = null;
        IToken LT299 = null;
        JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression296 = default(JavaScriptParser.bitwiseXORExpression_return);

        JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression300 = default(JavaScriptParser.bitwiseXORExpression_return);


        object LT297_tree=null;
        object char_literal298_tree=null;
        object LT299_tree=null;

        try 
    	{
            // JavaScript.g:260:2: ( bitwiseXORExpression ( ( LT )* ( '|' ( LT )* bitwiseXORExpression ) )* )
            // JavaScript.g:260:4: bitwiseXORExpression ( ( LT )* ( '|' ( LT )* bitwiseXORExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression2293);
            	bitwiseXORExpression296 = bitwiseXORExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpression296.Tree);
            	// JavaScript.g:260:25: ( ( LT )* ( '|' ( LT )* bitwiseXORExpression ) )*
            	do 
            	{
            	    int alt156 = 2;
            	    alt156 = dfa156.Predict(input);
            	    switch (alt156) 
            		{
            			case 1 :
            			    // JavaScript.g:260:26: ( LT )* ( '|' ( LT )* bitwiseXORExpression )
            			    {
            			    	// JavaScript.g:260:28: ( LT )*
            			    	do 
            			    	{
            			    	    int alt154 = 2;
            			    	    int LA154_0 = input.LA(1);

            			    	    if ( (LA154_0 == LT) )
            			    	    {
            			    	        alt154 = 1;
            			    	    }


            			    	    switch (alt154) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:260:28: LT
            			    			    {
            			    			    	LT297=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseORExpression2296); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop154;
            			    	    }
            			    	} while (true);

            			    	loop154:
            			    		;	// Stops C# compiler whining that label 'loop154' has no statements

            			    	// JavaScript.g:260:31: ( '|' ( LT )* bitwiseXORExpression )
            			    	// JavaScript.g:260:33: '|' ( LT )* bitwiseXORExpression
            			    	{
            			    		char_literal298=(IToken)Match(input,84,FOLLOW_84_in_bitwiseORExpression2302); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal298_tree = new BitwiseORExpression(char_literal298) ;
            			    			root_0 = (object)adaptor.BecomeRoot(char_literal298_tree, root_0);
            			    		}
            			    		// JavaScript.g:260:61: ( LT )*
            			    		do 
            			    		{
            			    		    int alt155 = 2;
            			    		    int LA155_0 = input.LA(1);

            			    		    if ( (LA155_0 == LT) )
            			    		    {
            			    		        alt155 = 1;
            			    		    }


            			    		    switch (alt155) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:260:61: LT
            			    				    {
            			    				    	LT299=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseORExpression2308); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop155;
            			    		    }
            			    		} while (true);

            			    		loop155:
            			    			;	// Stops C# compiler whining that label 'loop155' has no statements

            			    		PushFollow(FOLLOW_bitwiseXORExpression_in_bitwiseORExpression2312);
            			    		bitwiseXORExpression300 = bitwiseXORExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseXORExpression300.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop156;
            	    }
            	} while (true);

            	loop156:
            		;	// Stops C# compiler whining that label 'loop156' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseORExpression"

    public class bitwiseXORExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseXORExpression"
    // JavaScript.g:263:1: bitwiseXORExpression : bitwiseANDExpression ( ( LT )* ( '^' ( LT )* bitwiseANDExpression ) )* ;
    public JavaScriptParser.bitwiseXORExpression_return bitwiseXORExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.bitwiseXORExpression_return retval = new JavaScriptParser.bitwiseXORExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT302 = null;
        IToken char_literal303 = null;
        IToken LT304 = null;
        JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression301 = default(JavaScriptParser.bitwiseANDExpression_return);

        JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression305 = default(JavaScriptParser.bitwiseANDExpression_return);


        object LT302_tree=null;
        object char_literal303_tree=null;
        object LT304_tree=null;

        try 
    	{
            // JavaScript.g:264:2: ( bitwiseANDExpression ( ( LT )* ( '^' ( LT )* bitwiseANDExpression ) )* )
            // JavaScript.g:264:4: bitwiseANDExpression ( ( LT )* ( '^' ( LT )* bitwiseANDExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression2328);
            	bitwiseANDExpression301 = bitwiseANDExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpression301.Tree);
            	// JavaScript.g:264:25: ( ( LT )* ( '^' ( LT )* bitwiseANDExpression ) )*
            	do 
            	{
            	    int alt159 = 2;
            	    alt159 = dfa159.Predict(input);
            	    switch (alt159) 
            		{
            			case 1 :
            			    // JavaScript.g:264:26: ( LT )* ( '^' ( LT )* bitwiseANDExpression )
            			    {
            			    	// JavaScript.g:264:28: ( LT )*
            			    	do 
            			    	{
            			    	    int alt157 = 2;
            			    	    int LA157_0 = input.LA(1);

            			    	    if ( (LA157_0 == LT) )
            			    	    {
            			    	        alt157 = 1;
            			    	    }


            			    	    switch (alt157) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:264:28: LT
            			    			    {
            			    			    	LT302=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseXORExpression2331); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop157;
            			    	    }
            			    	} while (true);

            			    	loop157:
            			    		;	// Stops C# compiler whining that label 'loop157' has no statements

            			    	// JavaScript.g:264:31: ( '^' ( LT )* bitwiseANDExpression )
            			    	// JavaScript.g:264:33: '^' ( LT )* bitwiseANDExpression
            			    	{
            			    		char_literal303=(IToken)Match(input,85,FOLLOW_85_in_bitwiseXORExpression2337); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal303_tree = new BitwiseXORExpression(char_literal303) ;
            			    			root_0 = (object)adaptor.BecomeRoot(char_literal303_tree, root_0);
            			    		}
            			    		// JavaScript.g:264:62: ( LT )*
            			    		do 
            			    		{
            			    		    int alt158 = 2;
            			    		    int LA158_0 = input.LA(1);

            			    		    if ( (LA158_0 == LT) )
            			    		    {
            			    		        alt158 = 1;
            			    		    }


            			    		    switch (alt158) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:264:62: LT
            			    				    {
            			    				    	LT304=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseXORExpression2343); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop158;
            			    		    }
            			    		} while (true);

            			    		loop158:
            			    			;	// Stops C# compiler whining that label 'loop158' has no statements

            			    		PushFollow(FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression2347);
            			    		bitwiseANDExpression305 = bitwiseANDExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bitwiseANDExpression305.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop159;
            	    }
            	} while (true);

            	loop159:
            		;	// Stops C# compiler whining that label 'loop159' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseXORExpression"

    public class bitwiseANDExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bitwiseANDExpression"
    // JavaScript.g:267:1: bitwiseANDExpression : equalityExpression ( ( LT )* ( '&' ( LT )* equalityExpression ) )* ;
    public JavaScriptParser.bitwiseANDExpression_return bitwiseANDExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.bitwiseANDExpression_return retval = new JavaScriptParser.bitwiseANDExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT307 = null;
        IToken char_literal308 = null;
        IToken LT309 = null;
        JavaScriptParser.equalityExpression_return equalityExpression306 = default(JavaScriptParser.equalityExpression_return);

        JavaScriptParser.equalityExpression_return equalityExpression310 = default(JavaScriptParser.equalityExpression_return);


        object LT307_tree=null;
        object char_literal308_tree=null;
        object LT309_tree=null;

        try 
    	{
            // JavaScript.g:268:2: ( equalityExpression ( ( LT )* ( '&' ( LT )* equalityExpression ) )* )
            // JavaScript.g:268:4: equalityExpression ( ( LT )* ( '&' ( LT )* equalityExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression2364);
            	equalityExpression306 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression306.Tree);
            	// JavaScript.g:268:23: ( ( LT )* ( '&' ( LT )* equalityExpression ) )*
            	do 
            	{
            	    int alt162 = 2;
            	    alt162 = dfa162.Predict(input);
            	    switch (alt162) 
            		{
            			case 1 :
            			    // JavaScript.g:268:24: ( LT )* ( '&' ( LT )* equalityExpression )
            			    {
            			    	// JavaScript.g:268:26: ( LT )*
            			    	do 
            			    	{
            			    	    int alt160 = 2;
            			    	    int LA160_0 = input.LA(1);

            			    	    if ( (LA160_0 == LT) )
            			    	    {
            			    	        alt160 = 1;
            			    	    }


            			    	    switch (alt160) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:268:26: LT
            			    			    {
            			    			    	LT307=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseANDExpression2367); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop160;
            			    	    }
            			    	} while (true);

            			    	loop160:
            			    		;	// Stops C# compiler whining that label 'loop160' has no statements

            			    	// JavaScript.g:268:29: ( '&' ( LT )* equalityExpression )
            			    	// JavaScript.g:268:31: '&' ( LT )* equalityExpression
            			    	{
            			    		char_literal308=(IToken)Match(input,86,FOLLOW_86_in_bitwiseANDExpression2373); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{char_literal308_tree = new BitwiseANDExpression(char_literal308) ;
            			    			root_0 = (object)adaptor.BecomeRoot(char_literal308_tree, root_0);
            			    		}
            			    		// JavaScript.g:268:60: ( LT )*
            			    		do 
            			    		{
            			    		    int alt161 = 2;
            			    		    int LA161_0 = input.LA(1);

            			    		    if ( (LA161_0 == LT) )
            			    		    {
            			    		        alt161 = 1;
            			    		    }


            			    		    switch (alt161) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:268:60: LT
            			    				    {
            			    				    	LT309=(IToken)Match(input,LT,FOLLOW_LT_in_bitwiseANDExpression2379); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop161;
            			    		    }
            			    		} while (true);

            			    		loop161:
            			    			;	// Stops C# compiler whining that label 'loop161' has no statements

            			    		PushFollow(FOLLOW_equalityExpression_in_bitwiseANDExpression2383);
            			    		equalityExpression310 = equalityExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression310.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop162;
            	    }
            	} while (true);

            	loop162:
            		;	// Stops C# compiler whining that label 'loop162' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bitwiseANDExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // JavaScript.g:271:1: equalityExpression : relationalExpression ( ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression ) )* ;
    public JavaScriptParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.equalityExpression_return retval = new JavaScriptParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT312 = null;
        IToken string_literal313 = null;
        IToken LT314 = null;
        IToken string_literal316 = null;
        IToken LT317 = null;
        IToken string_literal319 = null;
        IToken LT320 = null;
        IToken string_literal322 = null;
        IToken LT323 = null;
        JavaScriptParser.relationalExpression_return relationalExpression311 = default(JavaScriptParser.relationalExpression_return);

        JavaScriptParser.relationalExpression_return relationalExpression315 = default(JavaScriptParser.relationalExpression_return);

        JavaScriptParser.relationalExpression_return relationalExpression318 = default(JavaScriptParser.relationalExpression_return);

        JavaScriptParser.relationalExpression_return relationalExpression321 = default(JavaScriptParser.relationalExpression_return);

        JavaScriptParser.relationalExpression_return relationalExpression324 = default(JavaScriptParser.relationalExpression_return);


        object LT312_tree=null;
        object string_literal313_tree=null;
        object LT314_tree=null;
        object string_literal316_tree=null;
        object LT317_tree=null;
        object string_literal319_tree=null;
        object LT320_tree=null;
        object string_literal322_tree=null;
        object LT323_tree=null;

        try 
    	{
            // JavaScript.g:272:2: ( relationalExpression ( ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression ) )* )
            // JavaScript.g:272:4: relationalExpression ( ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression2399);
            	relationalExpression311 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression311.Tree);
            	// JavaScript.g:273:4: ( ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression ) )*
            	do 
            	{
            	    int alt169 = 2;
            	    alt169 = dfa169.Predict(input);
            	    switch (alt169) 
            		{
            			case 1 :
            			    // JavaScript.g:273:5: ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression )
            			    {
            			    	// JavaScript.g:273:7: ( LT )*
            			    	do 
            			    	{
            			    	    int alt163 = 2;
            			    	    int LA163_0 = input.LA(1);

            			    	    if ( (LA163_0 == LT) )
            			    	    {
            			    	        alt163 = 1;
            			    	    }


            			    	    switch (alt163) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:273:7: LT
            			    			    {
            			    			    	LT312=(IToken)Match(input,LT,FOLLOW_LT_in_equalityExpression2406); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop163;
            			    	    }
            			    	} while (true);

            			    	loop163:
            			    		;	// Stops C# compiler whining that label 'loop163' has no statements

            			    	// JavaScript.g:273:10: ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression )
            			    	int alt168 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 87:
            			    		{
            			    	    alt168 = 1;
            			    	    }
            			    	    break;
            			    	case 88:
            			    		{
            			    	    alt168 = 2;
            			    	    }
            			    	    break;
            			    	case 89:
            			    		{
            			    	    alt168 = 3;
            			    	    }
            			    	    break;
            			    	case 90:
            			    		{
            			    	    alt168 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d168s0 =
            			    		        new NoViableAltException("", 168, 0, input);

            			    		    throw nvae_d168s0;
            			    	}

            			    	switch (alt168) 
            			    	{
            			    	    case 1 :
            			    	        // JavaScript.g:274:6: '==' ( LT )* relationalExpression
            			    	        {
            			    	        	string_literal313=(IToken)Match(input,87,FOLLOW_87_in_equalityExpression2417); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal313_tree = new EqualsNode(string_literal313) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal313_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:274:26: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt164 = 2;
            			    	        	    int LA164_0 = input.LA(1);

            			    	        	    if ( (LA164_0 == LT) )
            			    	        	    {
            			    	        	        alt164 = 1;
            			    	        	    }


            			    	        	    switch (alt164) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:274:26: LT
            			    	        			    {
            			    	        			    	LT314=(IToken)Match(input,LT,FOLLOW_LT_in_equalityExpression2423); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop164;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop164:
            			    	        		;	// Stops C# compiler whining that label 'loop164' has no statements

            			    	        	PushFollow(FOLLOW_relationalExpression_in_equalityExpression2427);
            			    	        	relationalExpression315 = relationalExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression315.Tree);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // JavaScript.g:275:6: '!=' ( LT )* relationalExpression
            			    	        {
            			    	        	string_literal316=(IToken)Match(input,88,FOLLOW_88_in_equalityExpression2435); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal316_tree = new NotEqualsNode(string_literal316) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal316_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:275:29: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt165 = 2;
            			    	        	    int LA165_0 = input.LA(1);

            			    	        	    if ( (LA165_0 == LT) )
            			    	        	    {
            			    	        	        alt165 = 1;
            			    	        	    }


            			    	        	    switch (alt165) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:275:29: LT
            			    	        			    {
            			    	        			    	LT317=(IToken)Match(input,LT,FOLLOW_LT_in_equalityExpression2441); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop165;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop165:
            			    	        		;	// Stops C# compiler whining that label 'loop165' has no statements

            			    	        	PushFollow(FOLLOW_relationalExpression_in_equalityExpression2445);
            			    	        	relationalExpression318 = relationalExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression318.Tree);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // JavaScript.g:276:6: '===' ( LT )* relationalExpression
            			    	        {
            			    	        	string_literal319=(IToken)Match(input,89,FOLLOW_89_in_equalityExpression2453); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal319_tree = new EqualsNodeEx(string_literal319) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal319_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:276:29: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt166 = 2;
            			    	        	    int LA166_0 = input.LA(1);

            			    	        	    if ( (LA166_0 == LT) )
            			    	        	    {
            			    	        	        alt166 = 1;
            			    	        	    }


            			    	        	    switch (alt166) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:276:29: LT
            			    	        			    {
            			    	        			    	LT320=(IToken)Match(input,LT,FOLLOW_LT_in_equalityExpression2459); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop166;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop166:
            			    	        		;	// Stops C# compiler whining that label 'loop166' has no statements

            			    	        	PushFollow(FOLLOW_relationalExpression_in_equalityExpression2463);
            			    	        	relationalExpression321 = relationalExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression321.Tree);

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // JavaScript.g:277:6: '!==' ( LT )* relationalExpression
            			    	        {
            			    	        	string_literal322=(IToken)Match(input,90,FOLLOW_90_in_equalityExpression2471); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal322_tree = new NotEqualsNodeEx(string_literal322) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal322_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:277:32: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt167 = 2;
            			    	        	    int LA167_0 = input.LA(1);

            			    	        	    if ( (LA167_0 == LT) )
            			    	        	    {
            			    	        	        alt167 = 1;
            			    	        	    }


            			    	        	    switch (alt167) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:277:32: LT
            			    	        			    {
            			    	        			    	LT323=(IToken)Match(input,LT,FOLLOW_LT_in_equalityExpression2477); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop167;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop167:
            			    	        		;	// Stops C# compiler whining that label 'loop167' has no statements

            			    	        	PushFollow(FOLLOW_relationalExpression_in_equalityExpression2481);
            			    	        	relationalExpression324 = relationalExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression324.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop169;
            	    }
            	} while (true);

            	loop169:
            		;	// Stops C# compiler whining that label 'loop169' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // JavaScript.g:281:1: relationalExpression : shiftExpression ( ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression ) )* ;
    public JavaScriptParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.relationalExpression_return retval = new JavaScriptParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT326 = null;
        IToken char_literal327 = null;
        IToken LT328 = null;
        IToken char_literal330 = null;
        IToken LT331 = null;
        IToken string_literal333 = null;
        IToken LT334 = null;
        IToken string_literal336 = null;
        IToken LT337 = null;
        IToken string_literal339 = null;
        IToken LT340 = null;
        IToken string_literal342 = null;
        IToken LT343 = null;
        JavaScriptParser.shiftExpression_return shiftExpression325 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression329 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression332 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression335 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression338 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression341 = default(JavaScriptParser.shiftExpression_return);

        JavaScriptParser.shiftExpression_return shiftExpression344 = default(JavaScriptParser.shiftExpression_return);


        object LT326_tree=null;
        object char_literal327_tree=null;
        object LT328_tree=null;
        object char_literal330_tree=null;
        object LT331_tree=null;
        object string_literal333_tree=null;
        object LT334_tree=null;
        object string_literal336_tree=null;
        object LT337_tree=null;
        object string_literal339_tree=null;
        object LT340_tree=null;
        object string_literal342_tree=null;
        object LT343_tree=null;

        try 
    	{
            // JavaScript.g:282:2: ( shiftExpression ( ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression ) )* )
            // JavaScript.g:282:4: shiftExpression ( ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2501);
            	shiftExpression325 = shiftExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression325.Tree);
            	// JavaScript.g:283:4: ( ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression ) )*
            	do 
            	{
            	    int alt178 = 2;
            	    alt178 = dfa178.Predict(input);
            	    switch (alt178) 
            		{
            			case 1 :
            			    // JavaScript.g:283:5: ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression )
            			    {
            			    	// JavaScript.g:283:7: ( LT )*
            			    	do 
            			    	{
            			    	    int alt170 = 2;
            			    	    int LA170_0 = input.LA(1);

            			    	    if ( (LA170_0 == LT) )
            			    	    {
            			    	        alt170 = 1;
            			    	    }


            			    	    switch (alt170) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:283:7: LT
            			    			    {
            			    			    	LT326=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2509); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop170;
            			    	    }
            			    	} while (true);

            			    	loop170:
            			    		;	// Stops C# compiler whining that label 'loop170' has no statements

            			    	// JavaScript.g:283:10: ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression )
            			    	int alt177 = 6;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 91:
            			    		{
            			    	    alt177 = 1;
            			    	    }
            			    	    break;
            			    	case 92:
            			    		{
            			    	    alt177 = 2;
            			    	    }
            			    	    break;
            			    	case 93:
            			    		{
            			    	    alt177 = 3;
            			    	    }
            			    	    break;
            			    	case 94:
            			    		{
            			    	    alt177 = 4;
            			    	    }
            			    	    break;
            			    	case 95:
            			    		{
            			    	    alt177 = 5;
            			    	    }
            			    	    break;
            			    	case 53:
            			    		{
            			    	    alt177 = 6;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d177s0 =
            			    		        new NoViableAltException("", 177, 0, input);

            			    		    throw nvae_d177s0;
            			    	}

            			    	switch (alt177) 
            			    	{
            			    	    case 1 :
            			    	        // JavaScript.g:284:6: '<' ( LT )* shiftExpression
            			    	        {
            			    	        	char_literal327=(IToken)Match(input,91,FOLLOW_91_in_relationalExpression2520); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal327_tree = new LessThanNode(char_literal327) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal327_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:284:27: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt171 = 2;
            			    	        	    int LA171_0 = input.LA(1);

            			    	        	    if ( (LA171_0 == LT) )
            			    	        	    {
            			    	        	        alt171 = 1;
            			    	        	    }


            			    	        	    switch (alt171) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:284:27: LT
            			    	        			    {
            			    	        			    	LT328=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2526); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop171;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop171:
            			    	        		;	// Stops C# compiler whining that label 'loop171' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2530);
            			    	        	shiftExpression329 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression329.Tree);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // JavaScript.g:285:6: '>' ( LT )* shiftExpression
            			    	        {
            			    	        	char_literal330=(IToken)Match(input,92,FOLLOW_92_in_relationalExpression2538); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal330_tree = new GreaterThanNode(char_literal330) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal330_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:285:30: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt172 = 2;
            			    	        	    int LA172_0 = input.LA(1);

            			    	        	    if ( (LA172_0 == LT) )
            			    	        	    {
            			    	        	        alt172 = 1;
            			    	        	    }


            			    	        	    switch (alt172) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:285:30: LT
            			    	        			    {
            			    	        			    	LT331=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2544); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop172;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop172:
            			    	        		;	// Stops C# compiler whining that label 'loop172' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2548);
            			    	        	shiftExpression332 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression332.Tree);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // JavaScript.g:286:6: '<=' ( LT )* shiftExpression
            			    	        {
            			    	        	string_literal333=(IToken)Match(input,93,FOLLOW_93_in_relationalExpression2556); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal333_tree = new LessThanEqNode(string_literal333) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal333_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:286:30: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt173 = 2;
            			    	        	    int LA173_0 = input.LA(1);

            			    	        	    if ( (LA173_0 == LT) )
            			    	        	    {
            			    	        	        alt173 = 1;
            			    	        	    }


            			    	        	    switch (alt173) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:286:30: LT
            			    	        			    {
            			    	        			    	LT334=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2562); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop173;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop173:
            			    	        		;	// Stops C# compiler whining that label 'loop173' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2566);
            			    	        	shiftExpression335 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression335.Tree);

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // JavaScript.g:287:6: '>=' ( LT )* shiftExpression
            			    	        {
            			    	        	string_literal336=(IToken)Match(input,94,FOLLOW_94_in_relationalExpression2574); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal336_tree = new GreaterThanEqNode(string_literal336) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal336_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:287:33: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt174 = 2;
            			    	        	    int LA174_0 = input.LA(1);

            			    	        	    if ( (LA174_0 == LT) )
            			    	        	    {
            			    	        	        alt174 = 1;
            			    	        	    }


            			    	        	    switch (alt174) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:287:33: LT
            			    	        			    {
            			    	        			    	LT337=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2580); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop174;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop174:
            			    	        		;	// Stops C# compiler whining that label 'loop174' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2584);
            			    	        	shiftExpression338 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression338.Tree);

            			    	        }
            			    	        break;
            			    	    case 5 :
            			    	        // JavaScript.g:288:6: 'instanceof' ( LT )* shiftExpression
            			    	        {
            			    	        	string_literal339=(IToken)Match(input,95,FOLLOW_95_in_relationalExpression2592); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal339_tree = new InstanceOfNode(string_literal339) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal339_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:288:38: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt175 = 2;
            			    	        	    int LA175_0 = input.LA(1);

            			    	        	    if ( (LA175_0 == LT) )
            			    	        	    {
            			    	        	        alt175 = 1;
            			    	        	    }


            			    	        	    switch (alt175) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:288:38: LT
            			    	        			    {
            			    	        			    	LT340=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2598); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop175;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop175:
            			    	        		;	// Stops C# compiler whining that label 'loop175' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2602);
            			    	        	shiftExpression341 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression341.Tree);

            			    	        }
            			    	        break;
            			    	    case 6 :
            			    	        // JavaScript.g:289:6: 'in' ( LT )* shiftExpression
            			    	        {
            			    	        	string_literal342=(IToken)Match(input,53,FOLLOW_53_in_relationalExpression2610); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal342_tree = new InNode(string_literal342) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal342_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:289:22: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt176 = 2;
            			    	        	    int LA176_0 = input.LA(1);

            			    	        	    if ( (LA176_0 == LT) )
            			    	        	    {
            			    	        	        alt176 = 1;
            			    	        	    }


            			    	        	    switch (alt176) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:289:22: LT
            			    	        			    {
            			    	        			    	LT343=(IToken)Match(input,LT,FOLLOW_LT_in_relationalExpression2616); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop176;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop176:
            			    	        		;	// Stops C# compiler whining that label 'loop176' has no statements

            			    	        	PushFollow(FOLLOW_shiftExpression_in_relationalExpression2620);
            			    	        	shiftExpression344 = shiftExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, shiftExpression344.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop178;
            	    }
            	} while (true);

            	loop178:
            		;	// Stops C# compiler whining that label 'loop178' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class shiftExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "shiftExpression"
    // JavaScript.g:293:1: shiftExpression : additiveExpression ( ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression ) )* ;
    public JavaScriptParser.shiftExpression_return shiftExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.shiftExpression_return retval = new JavaScriptParser.shiftExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT346 = null;
        IToken string_literal347 = null;
        IToken LT348 = null;
        IToken string_literal350 = null;
        IToken LT351 = null;
        IToken string_literal353 = null;
        IToken LT354 = null;
        JavaScriptParser.additiveExpression_return additiveExpression345 = default(JavaScriptParser.additiveExpression_return);

        JavaScriptParser.additiveExpression_return additiveExpression349 = default(JavaScriptParser.additiveExpression_return);

        JavaScriptParser.additiveExpression_return additiveExpression352 = default(JavaScriptParser.additiveExpression_return);

        JavaScriptParser.additiveExpression_return additiveExpression355 = default(JavaScriptParser.additiveExpression_return);


        object LT346_tree=null;
        object string_literal347_tree=null;
        object LT348_tree=null;
        object string_literal350_tree=null;
        object LT351_tree=null;
        object string_literal353_tree=null;
        object LT354_tree=null;

        try 
    	{
            // JavaScript.g:294:2: ( additiveExpression ( ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression ) )* )
            // JavaScript.g:294:4: additiveExpression ( ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2640);
            	additiveExpression345 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression345.Tree);
            	// JavaScript.g:295:4: ( ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression ) )*
            	do 
            	{
            	    int alt184 = 2;
            	    alt184 = dfa184.Predict(input);
            	    switch (alt184) 
            		{
            			case 1 :
            			    // JavaScript.g:295:5: ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression )
            			    {
            			    	// JavaScript.g:295:7: ( LT )*
            			    	do 
            			    	{
            			    	    int alt179 = 2;
            			    	    int LA179_0 = input.LA(1);

            			    	    if ( (LA179_0 == LT) )
            			    	    {
            			    	        alt179 = 1;
            			    	    }


            			    	    switch (alt179) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:295:7: LT
            			    			    {
            			    			    	LT346=(IToken)Match(input,LT,FOLLOW_LT_in_shiftExpression2648); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop179;
            			    	    }
            			    	} while (true);

            			    	loop179:
            			    		;	// Stops C# compiler whining that label 'loop179' has no statements

            			    	// JavaScript.g:295:10: ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression )
            			    	int alt183 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 96:
            			    		{
            			    	    alt183 = 1;
            			    	    }
            			    	    break;
            			    	case 97:
            			    		{
            			    	    alt183 = 2;
            			    	    }
            			    	    break;
            			    	case 98:
            			    		{
            			    	    alt183 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d183s0 =
            			    		        new NoViableAltException("", 183, 0, input);

            			    		    throw nvae_d183s0;
            			    	}

            			    	switch (alt183) 
            			    	{
            			    	    case 1 :
            			    	        // JavaScript.g:296:6: '<<' ( LT )* additiveExpression
            			    	        {
            			    	        	string_literal347=(IToken)Match(input,96,FOLLOW_96_in_shiftExpression2659); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal347_tree = new LeftShiftNode(string_literal347) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal347_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:296:29: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt180 = 2;
            			    	        	    int LA180_0 = input.LA(1);

            			    	        	    if ( (LA180_0 == LT) )
            			    	        	    {
            			    	        	        alt180 = 1;
            			    	        	    }


            			    	        	    switch (alt180) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:296:29: LT
            			    	        			    {
            			    	        			    	LT348=(IToken)Match(input,LT,FOLLOW_LT_in_shiftExpression2665); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop180;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop180:
            			    	        		;	// Stops C# compiler whining that label 'loop180' has no statements

            			    	        	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2669);
            			    	        	additiveExpression349 = additiveExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression349.Tree);

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // JavaScript.g:297:6: '>>' ( LT )* additiveExpression
            			    	        {
            			    	        	string_literal350=(IToken)Match(input,97,FOLLOW_97_in_shiftExpression2677); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal350_tree = new RightShiftNode(string_literal350) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal350_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:297:30: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt181 = 2;
            			    	        	    int LA181_0 = input.LA(1);

            			    	        	    if ( (LA181_0 == LT) )
            			    	        	    {
            			    	        	        alt181 = 1;
            			    	        	    }


            			    	        	    switch (alt181) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:297:30: LT
            			    	        			    {
            			    	        			    	LT351=(IToken)Match(input,LT,FOLLOW_LT_in_shiftExpression2683); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop181;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop181:
            			    	        		;	// Stops C# compiler whining that label 'loop181' has no statements

            			    	        	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2687);
            			    	        	additiveExpression352 = additiveExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression352.Tree);

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // JavaScript.g:298:6: '>>>' ( LT )* additiveExpression
            			    	        {
            			    	        	string_literal353=(IToken)Match(input,98,FOLLOW_98_in_shiftExpression2695); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal353_tree = new RightShiftUNode(string_literal353) ;
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal353_tree, root_0);
            			    	        	}
            			    	        	// JavaScript.g:298:32: ( LT )*
            			    	        	do 
            			    	        	{
            			    	        	    int alt182 = 2;
            			    	        	    int LA182_0 = input.LA(1);

            			    	        	    if ( (LA182_0 == LT) )
            			    	        	    {
            			    	        	        alt182 = 1;
            			    	        	    }


            			    	        	    switch (alt182) 
            			    	        		{
            			    	        			case 1 :
            			    	        			    // JavaScript.g:298:32: LT
            			    	        			    {
            			    	        			    	LT354=(IToken)Match(input,LT,FOLLOW_LT_in_shiftExpression2701); if (state.failed) return retval;

            			    	        			    }
            			    	        			    break;

            			    	        			default:
            			    	        			    goto loop182;
            			    	        	    }
            			    	        	} while (true);

            			    	        	loop182:
            			    	        		;	// Stops C# compiler whining that label 'loop182' has no statements

            			    	        	PushFollow(FOLLOW_additiveExpression_in_shiftExpression2705);
            			    	        	additiveExpression355 = additiveExpression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression355.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop184;
            	    }
            	} while (true);

            	loop184:
            		;	// Stops C# compiler whining that label 'loop184' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "shiftExpression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // JavaScript.g:302:1: additiveExpression : multiplicativeExpression ( ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression | ) ;
    public JavaScriptParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.additiveExpression_return retval = new JavaScriptParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT357 = null;
        IToken char_literal358 = null;
        IToken char_literal359 = null;
        JavaScriptParser.multiplicativeExpression_return multiplicativeExpression356 = default(JavaScriptParser.multiplicativeExpression_return);

        JavaScriptParser.additiveExpression_return additiveExpression360 = default(JavaScriptParser.additiveExpression_return);


        object LT357_tree=null;
        object char_literal358_tree=null;
        object char_literal359_tree=null;

        try 
    	{
            // JavaScript.g:303:2: ( multiplicativeExpression ( ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression | ) )
            // JavaScript.g:303:4: multiplicativeExpression ( ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression | )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression2725);
            	multiplicativeExpression356 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression356.Tree);
            	// JavaScript.g:303:29: ( ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression | )
            	int alt187 = 2;
            	alt187 = dfa187.Predict(input);
            	switch (alt187) 
            	{
            	    case 1 :
            	        // JavaScript.g:304:3: ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression
            	        {
            	        	// JavaScript.g:304:44: ( LT )*
            	        	do 
            	        	{
            	        	    int alt185 = 2;
            	        	    int LA185_0 = input.LA(1);

            	        	    if ( (LA185_0 == LT) )
            	        	    {
            	        	        alt185 = 1;
            	        	    }


            	        	    switch (alt185) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:304:44: LT
            	        			    {
            	        			    	LT357=(IToken)Match(input,LT,FOLLOW_LT_in_additiveExpression2747); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop185;
            	        	    }
            	        	} while (true);

            	        	loop185:
            	        		;	// Stops C# compiler whining that label 'loop185' has no statements

            	        	// JavaScript.g:304:47: ( '+' | '-' )
            	        	int alt186 = 2;
            	        	int LA186_0 = input.LA(1);

            	        	if ( (LA186_0 == 99) )
            	        	{
            	        	    alt186 = 1;
            	        	}
            	        	else if ( (LA186_0 == 100) )
            	        	{
            	        	    alt186 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    NoViableAltException nvae_d186s0 =
            	        	        new NoViableAltException("", 186, 0, input);

            	        	    throw nvae_d186s0;
            	        	}
            	        	switch (alt186) 
            	        	{
            	        	    case 1 :
            	        	        // JavaScript.g:304:48: '+'
            	        	        {
            	        	        	char_literal358=(IToken)Match(input,99,FOLLOW_99_in_additiveExpression2752); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal358_tree = new AddNode(char_literal358) ;
            	        	        		root_0 = (object)adaptor.BecomeRoot(char_literal358_tree, root_0);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // JavaScript.g:304:64: '-'
            	        	        {
            	        	        	char_literal359=(IToken)Match(input,100,FOLLOW_100_in_additiveExpression2760); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal359_tree = new SubNode(char_literal359) ;
            	        	        		root_0 = (object)adaptor.BecomeRoot(char_literal359_tree, root_0);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_additiveExpression_in_additiveExpression2767);
            	        	additiveExpression360 = additiveExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression360.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:306:2: 
            	        {
            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // JavaScript.g:309:1: multiplicativeExpression : unaryExpression ( ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression ) )* ;
    public JavaScriptParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.multiplicativeExpression_return retval = new JavaScriptParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT362 = null;
        IToken char_literal363 = null;
        IToken char_literal364 = null;
        IToken char_literal365 = null;
        IToken LT366 = null;
        JavaScriptParser.unaryExpression_return unaryExpression361 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression367 = default(JavaScriptParser.unaryExpression_return);


        object LT362_tree=null;
        object char_literal363_tree=null;
        object char_literal364_tree=null;
        object char_literal365_tree=null;
        object LT366_tree=null;

        try 
    	{
            // JavaScript.g:310:2: ( unaryExpression ( ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression ) )* )
            // JavaScript.g:310:4: unaryExpression ( ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression2787);
            	unaryExpression361 = unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression361.Tree);
            	// JavaScript.g:310:20: ( ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression ) )*
            	do 
            	{
            	    int alt191 = 2;
            	    alt191 = dfa191.Predict(input);
            	    switch (alt191) 
            		{
            			case 1 :
            			    // JavaScript.g:310:21: ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression )
            			    {
            			    	// JavaScript.g:310:23: ( LT )*
            			    	do 
            			    	{
            			    	    int alt188 = 2;
            			    	    int LA188_0 = input.LA(1);

            			    	    if ( (LA188_0 == LT) )
            			    	    {
            			    	        alt188 = 1;
            			    	    }


            			    	    switch (alt188) 
            			    		{
            			    			case 1 :
            			    			    // JavaScript.g:310:23: LT
            			    			    {
            			    			    	LT362=(IToken)Match(input,LT,FOLLOW_LT_in_multiplicativeExpression2790); if (state.failed) return retval;

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop188;
            			    	    }
            			    	} while (true);

            			    	loop188:
            			    		;	// Stops C# compiler whining that label 'loop188' has no statements

            			    	// JavaScript.g:310:25: ( ( '*' | '/' | '%' ) ( LT )* unaryExpression )
            			    	// JavaScript.g:310:26: ( '*' | '/' | '%' ) ( LT )* unaryExpression
            			    	{
            			    		// JavaScript.g:310:26: ( '*' | '/' | '%' )
            			    		int alt189 = 3;
            			    		switch ( input.LA(1) ) 
            			    		{
            			    		case 101:
            			    			{
            			    		    alt189 = 1;
            			    		    }
            			    		    break;
            			    		case 102:
            			    			{
            			    		    alt189 = 2;
            			    		    }
            			    		    break;
            			    		case 103:
            			    			{
            			    		    alt189 = 3;
            			    		    }
            			    		    break;
            			    			default:
            			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    			    NoViableAltException nvae_d189s0 =
            			    			        new NoViableAltException("", 189, 0, input);

            			    			    throw nvae_d189s0;
            			    		}

            			    		switch (alt189) 
            			    		{
            			    		    case 1 :
            			    		        // JavaScript.g:310:27: '*'
            			    		        {
            			    		        	char_literal363=(IToken)Match(input,101,FOLLOW_101_in_multiplicativeExpression2795); if (state.failed) return retval;
            			    		        	if ( state.backtracking == 0 )
            			    		        	{char_literal363_tree = new MultiplyNode(char_literal363) ;
            			    		        		root_0 = (object)adaptor.BecomeRoot(char_literal363_tree, root_0);
            			    		        	}

            			    		        }
            			    		        break;
            			    		    case 2 :
            			    		        // JavaScript.g:310:48: '/'
            			    		        {
            			    		        	char_literal364=(IToken)Match(input,102,FOLLOW_102_in_multiplicativeExpression2803); if (state.failed) return retval;
            			    		        	if ( state.backtracking == 0 )
            			    		        	{char_literal364_tree = new DivideNode(char_literal364) ;
            			    		        		root_0 = (object)adaptor.BecomeRoot(char_literal364_tree, root_0);
            			    		        	}

            			    		        }
            			    		        break;
            			    		    case 3 :
            			    		        // JavaScript.g:310:67: '%'
            			    		        {
            			    		        	char_literal365=(IToken)Match(input,103,FOLLOW_103_in_multiplicativeExpression2811); if (state.failed) return retval;
            			    		        	if ( state.backtracking == 0 )
            			    		        	{char_literal365_tree = new ModuloNode(char_literal365) ;
            			    		        		root_0 = (object)adaptor.BecomeRoot(char_literal365_tree, root_0);
            			    		        	}

            			    		        }
            			    		        break;

            			    		}

            			    		// JavaScript.g:310:87: ( LT )*
            			    		do 
            			    		{
            			    		    int alt190 = 2;
            			    		    int LA190_0 = input.LA(1);

            			    		    if ( (LA190_0 == LT) )
            			    		    {
            			    		        alt190 = 1;
            			    		    }


            			    		    switch (alt190) 
            			    			{
            			    				case 1 :
            			    				    // JavaScript.g:310:87: LT
            			    				    {
            			    				    	LT366=(IToken)Match(input,LT,FOLLOW_LT_in_multiplicativeExpression2818); if (state.failed) return retval;

            			    				    }
            			    				    break;

            			    				default:
            			    				    goto loop190;
            			    		    }
            			    		} while (true);

            			    		loop190:
            			    			;	// Stops C# compiler whining that label 'loop190' has no statements

            			    		PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression2822);
            			    		unaryExpression367 = unaryExpression();
            			    		state.followingStackPointer--;
            			    		if (state.failed) return retval;
            			    		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression367.Tree);

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop191;
            	    }
            	} while (true);

            	loop191:
            		;	// Stops C# compiler whining that label 'loop191' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // JavaScript.g:313:1: unaryExpression : ( postfixExpression | 'delete' ( LT )* unaryExpression | 'void' ( LT )* unaryExpression | 'typeof' ( LT )* unaryExpression | '++' unaryExpression | '--' unaryExpression | '+' ( LT )* unaryExpression | '-' ( LT )* unaryExpression | '~' ( LT )* unaryExpression | '!' ( LT )* unaryExpression );
    public JavaScriptParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.unaryExpression_return retval = new JavaScriptParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal369 = null;
        IToken LT370 = null;
        IToken string_literal372 = null;
        IToken LT373 = null;
        IToken string_literal375 = null;
        IToken LT376 = null;
        IToken string_literal378 = null;
        IToken string_literal380 = null;
        IToken char_literal382 = null;
        IToken LT383 = null;
        IToken char_literal385 = null;
        IToken LT386 = null;
        IToken char_literal388 = null;
        IToken LT389 = null;
        IToken char_literal391 = null;
        IToken LT392 = null;
        JavaScriptParser.postfixExpression_return postfixExpression368 = default(JavaScriptParser.postfixExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression371 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression374 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression377 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression379 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression381 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression384 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression387 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression390 = default(JavaScriptParser.unaryExpression_return);

        JavaScriptParser.unaryExpression_return unaryExpression393 = default(JavaScriptParser.unaryExpression_return);


        object string_literal369_tree=null;
        object LT370_tree=null;
        object string_literal372_tree=null;
        object LT373_tree=null;
        object string_literal375_tree=null;
        object LT376_tree=null;
        object string_literal378_tree=null;
        object string_literal380_tree=null;
        object char_literal382_tree=null;
        object LT383_tree=null;
        object char_literal385_tree=null;
        object LT386_tree=null;
        object char_literal388_tree=null;
        object LT389_tree=null;
        object char_literal391_tree=null;
        object LT392_tree=null;

        try 
    	{
            // JavaScript.g:314:2: ( postfixExpression | 'delete' ( LT )* unaryExpression | 'void' ( LT )* unaryExpression | 'typeof' ( LT )* unaryExpression | '++' unaryExpression | '--' unaryExpression | '+' ( LT )* unaryExpression | '-' ( LT )* unaryExpression | '~' ( LT )* unaryExpression | '!' ( LT )* unaryExpression )
            int alt199 = 10;
            alt199 = dfa199.Predict(input);
            switch (alt199) 
            {
                case 1 :
                    // JavaScript.g:314:4: postfixExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_postfixExpression_in_unaryExpression2837);
                    	postfixExpression368 = postfixExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, postfixExpression368.Tree);

                    }
                    break;
                case 2 :
                    // JavaScript.g:315:4: 'delete' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal369=(IToken)Match(input,104,FOLLOW_104_in_unaryExpression2843); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal369_tree = new DeleteNode(string_literal369) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal369_tree, root_0);
                    	}
                    	// JavaScript.g:315:28: ( LT )*
                    	do 
                    	{
                    	    int alt192 = 2;
                    	    int LA192_0 = input.LA(1);

                    	    if ( (LA192_0 == LT) )
                    	    {
                    	        alt192 = 1;
                    	    }


                    	    switch (alt192) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:315:28: LT
                    			    {
                    			    	LT370=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2849); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop192;
                    	    }
                    	} while (true);

                    	loop192:
                    		;	// Stops C# compiler whining that label 'loop192' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2853);
                    	unaryExpression371 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression371.Tree);

                    }
                    break;
                case 3 :
                    // JavaScript.g:316:4: 'void' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal372=(IToken)Match(input,105,FOLLOW_105_in_unaryExpression2859); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal372_tree = new VoidNode(string_literal372) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal372_tree, root_0);
                    	}
                    	// JavaScript.g:316:24: ( LT )*
                    	do 
                    	{
                    	    int alt193 = 2;
                    	    int LA193_0 = input.LA(1);

                    	    if ( (LA193_0 == LT) )
                    	    {
                    	        alt193 = 1;
                    	    }


                    	    switch (alt193) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:316:24: LT
                    			    {
                    			    	LT373=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2865); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop193;
                    	    }
                    	} while (true);

                    	loop193:
                    		;	// Stops C# compiler whining that label 'loop193' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2869);
                    	unaryExpression374 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression374.Tree);

                    }
                    break;
                case 4 :
                    // JavaScript.g:317:4: 'typeof' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal375=(IToken)Match(input,106,FOLLOW_106_in_unaryExpression2875); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal375_tree = new TypeOfExpr(string_literal375) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal375_tree, root_0);
                    	}
                    	// JavaScript.g:317:28: ( LT )*
                    	do 
                    	{
                    	    int alt194 = 2;
                    	    int LA194_0 = input.LA(1);

                    	    if ( (LA194_0 == LT) )
                    	    {
                    	        alt194 = 1;
                    	    }


                    	    switch (alt194) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:317:28: LT
                    			    {
                    			    	LT376=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2881); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop194;
                    	    }
                    	} while (true);

                    	loop194:
                    		;	// Stops C# compiler whining that label 'loop194' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2885);
                    	unaryExpression377 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression377.Tree);

                    }
                    break;
                case 5 :
                    // JavaScript.g:318:4: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal378=(IToken)Match(input,107,FOLLOW_107_in_unaryExpression2891); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal378_tree = new preIncExpr(string_literal378) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal378_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2897);
                    	unaryExpression379 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression379.Tree);

                    }
                    break;
                case 6 :
                    // JavaScript.g:319:4: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal380=(IToken)Match(input,108,FOLLOW_108_in_unaryExpression2903); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal380_tree = new preDecExpr(string_literal380) ;
                    		root_0 = (object)adaptor.BecomeRoot(string_literal380_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2909);
                    	unaryExpression381 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression381.Tree);

                    }
                    break;
                case 7 :
                    // JavaScript.g:320:4: '+' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal382=(IToken)Match(input,99,FOLLOW_99_in_unaryExpression2915); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal382_tree = new PosNode(char_literal382) ;
                    		root_0 = (object)adaptor.BecomeRoot(char_literal382_tree, root_0);
                    	}
                    	// JavaScript.g:320:20: ( LT )*
                    	do 
                    	{
                    	    int alt195 = 2;
                    	    int LA195_0 = input.LA(1);

                    	    if ( (LA195_0 == LT) )
                    	    {
                    	        alt195 = 1;
                    	    }


                    	    switch (alt195) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:320:20: LT
                    			    {
                    			    	LT383=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2921); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop195;
                    	    }
                    	} while (true);

                    	loop195:
                    		;	// Stops C# compiler whining that label 'loop195' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2925);
                    	unaryExpression384 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression384.Tree);

                    }
                    break;
                case 8 :
                    // JavaScript.g:321:4: '-' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal385=(IToken)Match(input,100,FOLLOW_100_in_unaryExpression2931); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal385_tree = new NegNode(char_literal385) ;
                    		root_0 = (object)adaptor.BecomeRoot(char_literal385_tree, root_0);
                    	}
                    	// JavaScript.g:321:20: ( LT )*
                    	do 
                    	{
                    	    int alt196 = 2;
                    	    int LA196_0 = input.LA(1);

                    	    if ( (LA196_0 == LT) )
                    	    {
                    	        alt196 = 1;
                    	    }


                    	    switch (alt196) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:321:20: LT
                    			    {
                    			    	LT386=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2937); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop196;
                    	    }
                    	} while (true);

                    	loop196:
                    		;	// Stops C# compiler whining that label 'loop196' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2941);
                    	unaryExpression387 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression387.Tree);

                    }
                    break;
                case 9 :
                    // JavaScript.g:322:4: '~' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal388=(IToken)Match(input,109,FOLLOW_109_in_unaryExpression2947); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal388_tree = new BinaryNotNode(char_literal388) ;
                    		root_0 = (object)adaptor.BecomeRoot(char_literal388_tree, root_0);
                    	}
                    	// JavaScript.g:322:26: ( LT )*
                    	do 
                    	{
                    	    int alt197 = 2;
                    	    int LA197_0 = input.LA(1);

                    	    if ( (LA197_0 == LT) )
                    	    {
                    	        alt197 = 1;
                    	    }


                    	    switch (alt197) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:322:26: LT
                    			    {
                    			    	LT389=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2953); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop197;
                    	    }
                    	} while (true);

                    	loop197:
                    		;	// Stops C# compiler whining that label 'loop197' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2957);
                    	unaryExpression390 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression390.Tree);

                    }
                    break;
                case 10 :
                    // JavaScript.g:323:4: '!' ( LT )* unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal391=(IToken)Match(input,110,FOLLOW_110_in_unaryExpression2963); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{char_literal391_tree = new LogicalNotNode(char_literal391) ;
                    		root_0 = (object)adaptor.BecomeRoot(char_literal391_tree, root_0);
                    	}
                    	// JavaScript.g:323:27: ( LT )*
                    	do 
                    	{
                    	    int alt198 = 2;
                    	    int LA198_0 = input.LA(1);

                    	    if ( (LA198_0 == LT) )
                    	    {
                    	        alt198 = 1;
                    	    }


                    	    switch (alt198) 
                    		{
                    			case 1 :
                    			    // JavaScript.g:323:27: LT
                    			    {
                    			    	LT392=(IToken)Match(input,LT,FOLLOW_LT_in_unaryExpression2969); if (state.failed) return retval;

                    			    }
                    			    break;

                    			default:
                    			    goto loop198;
                    	    }
                    	} while (true);

                    	loop198:
                    		;	// Stops C# compiler whining that label 'loop198' has no statements

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression2973);
                    	unaryExpression393 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression393.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class postfixExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "postfixExpression"
    // JavaScript.g:326:1: postfixExpression : n= leftHandSideExpression ( '++' | '--' )? ;
    public JavaScriptParser.postfixExpression_return postfixExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.postfixExpression_return retval = new JavaScriptParser.postfixExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal394 = null;
        IToken string_literal395 = null;
        JavaScriptParser.leftHandSideExpression_return n = default(JavaScriptParser.leftHandSideExpression_return);


        object string_literal394_tree=null;
        object string_literal395_tree=null;

        try 
    	{
            // JavaScript.g:327:2: (n= leftHandSideExpression ( '++' | '--' )? )
            // JavaScript.g:327:4: n= leftHandSideExpression ( '++' | '--' )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_leftHandSideExpression_in_postfixExpression2988);
            	n = leftHandSideExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, n.Tree);
            	// JavaScript.g:327:29: ( '++' | '--' )?
            	int alt200 = 3;
            	alt200 = dfa200.Predict(input);
            	switch (alt200) 
            	{
            	    case 1 :
            	        // JavaScript.g:327:30: '++'
            	        {
            	        	string_literal394=(IToken)Match(input,107,FOLLOW_107_in_postfixExpression2991); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal394_tree = new postIncExpr(string_literal394) ;
            	        		root_0 = (object)adaptor.BecomeRoot(string_literal394_tree, root_0);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // JavaScript.g:327:51: '--'
            	        {
            	        	string_literal395=(IToken)Match(input,108,FOLLOW_108_in_postfixExpression2999); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal395_tree = new postDecExpr(string_literal395) ;
            	        		root_0 = (object)adaptor.BecomeRoot(string_literal395_tree, root_0);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "postfixExpression"

    public class primaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "primaryExpression"
    // JavaScript.g:330:1: primaryExpression : ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' expression ')' );
    public JavaScriptParser.primaryExpression_return primaryExpression() // throws RecognitionException [1]
    {   
        JavaScriptParser.primaryExpression_return retval = new JavaScriptParser.primaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal396 = null;
        IToken Identifier397 = null;
        IToken char_literal401 = null;
        IToken char_literal403 = null;
        JavaScriptParser.literal_return literal398 = default(JavaScriptParser.literal_return);

        JavaScriptParser.arrayLiteral_return arrayLiteral399 = default(JavaScriptParser.arrayLiteral_return);

        JavaScriptParser.objectLiteral_return objectLiteral400 = default(JavaScriptParser.objectLiteral_return);

        JavaScriptParser.expression_return expression402 = default(JavaScriptParser.expression_return);


        object string_literal396_tree=null;
        object Identifier397_tree=null;
        object char_literal401_tree=null;
        object char_literal403_tree=null;

        try 
    	{
            // JavaScript.g:331:2: ( 'this' | Identifier | literal | arrayLiteral | objectLiteral | '(' expression ')' )
            int alt201 = 6;
            switch ( input.LA(1) ) 
            {
            case 111:
            	{
                alt201 = 1;
                }
                break;
            case Identifier:
            	{
                alt201 = 2;
                }
                break;
            case StringLiteral:
            case NumericLiteral:
            case RegexLiteral:
            case 112:
            case 113:
            case 114:
            	{
                alt201 = 3;
                }
                break;
            case 67:
            	{
                alt201 = 4;
                }
                break;
            case 40:
            	{
                alt201 = 5;
                }
                break;
            case 42:
            	{
                alt201 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d201s0 =
            	        new NoViableAltException("", 201, 0, input);

            	    throw nvae_d201s0;
            }

            switch (alt201) 
            {
                case 1 :
                    // JavaScript.g:331:4: 'this'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal396=(IToken)Match(input,111,FOLLOW_111_in_primaryExpression3017); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal396_tree = new ThisRef(string_literal396) ;
                    		adaptor.AddChild(root_0, string_literal396_tree);
                    	}

                    }
                    break;
                case 2 :
                    // JavaScript.g:332:4: Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Identifier397=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_primaryExpression3026); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Identifier397_tree = new IdentifierNode(Identifier397) ;
                    		adaptor.AddChild(root_0, Identifier397_tree);
                    	}

                    }
                    break;
                case 3 :
                    // JavaScript.g:333:4: literal
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_literal_in_primaryExpression3034);
                    	literal398 = literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, literal398.Tree);

                    }
                    break;
                case 4 :
                    // JavaScript.g:334:4: arrayLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_arrayLiteral_in_primaryExpression3040);
                    	arrayLiteral399 = arrayLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, arrayLiteral399.Tree);

                    }
                    break;
                case 5 :
                    // JavaScript.g:335:4: objectLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectLiteral_in_primaryExpression3046);
                    	objectLiteral400 = objectLiteral();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectLiteral400.Tree);

                    }
                    break;
                case 6 :
                    // JavaScript.g:336:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal401=(IToken)Match(input,42,FOLLOW_42_in_primaryExpression3052); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_primaryExpression3055);
                    	expression402 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression402.Tree);
                    	char_literal403=(IToken)Match(input,44,FOLLOW_44_in_primaryExpression3057); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "primaryExpression"

    public class arrayLiteral_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arrayLiteral"
    // JavaScript.g:340:1: arrayLiteral : '[' ( LT )* ( elision ( ',' elision )* ( ',' )? )? ']' ;
    public JavaScriptParser.arrayLiteral_return arrayLiteral() // throws RecognitionException [1]
    {   
        JavaScriptParser.arrayLiteral_return retval = new JavaScriptParser.arrayLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal404 = null;
        IToken LT405 = null;
        IToken char_literal407 = null;
        IToken char_literal409 = null;
        IToken char_literal410 = null;
        JavaScriptParser.elision_return elision406 = default(JavaScriptParser.elision_return);

        JavaScriptParser.elision_return elision408 = default(JavaScriptParser.elision_return);


        object char_literal404_tree=null;
        object LT405_tree=null;
        object char_literal407_tree=null;
        object char_literal409_tree=null;
        object char_literal410_tree=null;

        try 
    	{
            // JavaScript.g:341:2: ( '[' ( LT )* ( elision ( ',' elision )* ( ',' )? )? ']' )
            // JavaScript.g:341:4: '[' ( LT )* ( elision ( ',' elision )* ( ',' )? )? ']'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal404=(IToken)Match(input,67,FOLLOW_67_in_arrayLiteral3070); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal404_tree = new ArrayLiteral(char_literal404) ;
            		root_0 = (object)adaptor.BecomeRoot(char_literal404_tree, root_0);
            	}
            	// JavaScript.g:341:25: ( LT )*
            	do 
            	{
            	    int alt202 = 2;
            	    int LA202_0 = input.LA(1);

            	    if ( (LA202_0 == LT) )
            	    {
            	        alt202 = 1;
            	    }


            	    switch (alt202) 
            		{
            			case 1 :
            			    // JavaScript.g:341:25: LT
            			    {
            			    	LT405=(IToken)Match(input,LT,FOLLOW_LT_in_arrayLiteral3076); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop202;
            	    }
            	} while (true);

            	loop202:
            		;	// Stops C# compiler whining that label 'loop202' has no statements

            	// JavaScript.g:341:28: ( elision ( ',' elision )* ( ',' )? )?
            	int alt205 = 2;
            	int LA205_0 = input.LA(1);

            	if ( ((LA205_0 >= Identifier && LA205_0 <= RegexLiteral) || (LA205_0 >= 39 && LA205_0 <= 40) || LA205_0 == 42 || (LA205_0 >= 66 && LA205_0 <= 67) || (LA205_0 >= 99 && LA205_0 <= 100) || (LA205_0 >= 104 && LA205_0 <= 114)) )
            	{
            	    alt205 = 1;
            	}
            	switch (alt205) 
            	{
            	    case 1 :
            	        // JavaScript.g:341:30: elision ( ',' elision )* ( ',' )?
            	        {
            	        	PushFollow(FOLLOW_elision_in_arrayLiteral3082);
            	        	elision406 = elision();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elision406.Tree);
            	        	// JavaScript.g:341:38: ( ',' elision )*
            	        	do 
            	        	{
            	        	    int alt203 = 2;
            	        	    int LA203_0 = input.LA(1);

            	        	    if ( (LA203_0 == 43) )
            	        	    {
            	        	        int LA203_1 = input.LA(2);

            	        	        if ( ((LA203_1 >= Identifier && LA203_1 <= RegexLiteral) || (LA203_1 >= 39 && LA203_1 <= 40) || LA203_1 == 42 || (LA203_1 >= 66 && LA203_1 <= 67) || (LA203_1 >= 99 && LA203_1 <= 100) || (LA203_1 >= 104 && LA203_1 <= 114)) )
            	        	        {
            	        	            alt203 = 1;
            	        	        }


            	        	    }


            	        	    switch (alt203) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:341:39: ',' elision
            	        			    {
            	        			    	char_literal407=(IToken)Match(input,43,FOLLOW_43_in_arrayLiteral3085); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{char_literal407_tree = (object)adaptor.Create(char_literal407);
            	        			    		adaptor.AddChild(root_0, char_literal407_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_elision_in_arrayLiteral3087);
            	        			    	elision408 = elision();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elision408.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop203;
            	        	    }
            	        	} while (true);

            	        	loop203:
            	        		;	// Stops C# compiler whining that label 'loop203' has no statements

            	        	// JavaScript.g:341:53: ( ',' )?
            	        	int alt204 = 2;
            	        	int LA204_0 = input.LA(1);

            	        	if ( (LA204_0 == 43) )
            	        	{
            	        	    alt204 = 1;
            	        	}
            	        	switch (alt204) 
            	        	{
            	        	    case 1 :
            	        	        // JavaScript.g:341:53: ','
            	        	        {
            	        	        	char_literal409=(IToken)Match(input,43,FOLLOW_43_in_arrayLiteral3091); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{char_literal409_tree = (object)adaptor.Create(char_literal409);
            	        	        		adaptor.AddChild(root_0, char_literal409_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	char_literal410=(IToken)Match(input,68,FOLLOW_68_in_arrayLiteral3097); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arrayLiteral"

    public class elision_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elision"
    // JavaScript.g:344:1: elision : assignmentExpression -> ^( NIL assignmentExpression ) ;
    public JavaScriptParser.elision_return elision() // throws RecognitionException [1]
    {   
        JavaScriptParser.elision_return retval = new JavaScriptParser.elision_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        JavaScriptParser.assignmentExpression_return assignmentExpression411 = default(JavaScriptParser.assignmentExpression_return);


        RewriteRuleSubtreeStream stream_assignmentExpression = new RewriteRuleSubtreeStream(adaptor,"rule assignmentExpression");
        try 
    	{
            // JavaScript.g:345:2: ( assignmentExpression -> ^( NIL assignmentExpression ) )
            // JavaScript.g:345:4: assignmentExpression
            {
            	PushFollow(FOLLOW_assignmentExpression_in_elision3117);
            	assignmentExpression411 = assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_assignmentExpression.Add(assignmentExpression411.Tree);


            	// AST REWRITE
            	// elements:          assignmentExpression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 345:25: -> ^( NIL assignmentExpression )
            	{
            	    // JavaScript.g:345:28: ^( NIL assignmentExpression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(new baseNode(NIL), root_1);

            	    adaptor.AddChild(root_1, stream_assignmentExpression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elision"

    public class objectLiteral_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectLiteral"
    // JavaScript.g:349:1: objectLiteral : '{' ( LT )* ( propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( ',' )? ( LT )* )? '}' ;
    public JavaScriptParser.objectLiteral_return objectLiteral() // throws RecognitionException [1]
    {   
        JavaScriptParser.objectLiteral_return retval = new JavaScriptParser.objectLiteral_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal412 = null;
        IToken LT413 = null;
        IToken LT415 = null;
        IToken char_literal416 = null;
        IToken LT417 = null;
        IToken char_literal419 = null;
        IToken LT420 = null;
        IToken char_literal421 = null;
        JavaScriptParser.propertyNameAndValue_return propertyNameAndValue414 = default(JavaScriptParser.propertyNameAndValue_return);

        JavaScriptParser.propertyNameAndValue_return propertyNameAndValue418 = default(JavaScriptParser.propertyNameAndValue_return);


        object char_literal412_tree=null;
        object LT413_tree=null;
        object LT415_tree=null;
        object char_literal416_tree=null;
        object LT417_tree=null;
        object char_literal419_tree=null;
        object LT420_tree=null;
        object char_literal421_tree=null;

        try 
    	{
            // JavaScript.g:350:2: ( '{' ( LT )* ( propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( ',' )? ( LT )* )? '}' )
            // JavaScript.g:350:4: '{' ( LT )* ( propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( ',' )? ( LT )* )? '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal412=(IToken)Match(input,40,FOLLOW_40_in_objectLiteral3140); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal412_tree = new ObjectLiteral(char_literal412) ;
            		root_0 = (object)adaptor.BecomeRoot(char_literal412_tree, root_0);
            	}
            	// JavaScript.g:350:26: ( LT )*
            	do 
            	{
            	    int alt206 = 2;
            	    int LA206_0 = input.LA(1);

            	    if ( (LA206_0 == LT) )
            	    {
            	        alt206 = 1;
            	    }


            	    switch (alt206) 
            		{
            			case 1 :
            			    // JavaScript.g:350:26: LT
            			    {
            			    	LT413=(IToken)Match(input,LT,FOLLOW_LT_in_objectLiteral3146); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop206;
            	    }
            	} while (true);

            	loop206:
            		;	// Stops C# compiler whining that label 'loop206' has no statements

            	// JavaScript.g:350:29: ( propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( ',' )? ( LT )* )?
            	int alt212 = 2;
            	int LA212_0 = input.LA(1);

            	if ( ((LA212_0 >= Identifier && LA212_0 <= NumericLiteral)) )
            	{
            	    alt212 = 1;
            	}
            	switch (alt212) 
            	{
            	    case 1 :
            	        // JavaScript.g:350:30: propertyNameAndValue ( ( LT )* ',' ( LT )* propertyNameAndValue )* ( ',' )? ( LT )*
            	        {
            	        	PushFollow(FOLLOW_propertyNameAndValue_in_objectLiteral3151);
            	        	propertyNameAndValue414 = propertyNameAndValue();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyNameAndValue414.Tree);
            	        	// JavaScript.g:350:51: ( ( LT )* ',' ( LT )* propertyNameAndValue )*
            	        	do 
            	        	{
            	        	    int alt209 = 2;
            	        	    alt209 = dfa209.Predict(input);
            	        	    switch (alt209) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:350:52: ( LT )* ',' ( LT )* propertyNameAndValue
            	        			    {
            	        			    	// JavaScript.g:350:54: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt207 = 2;
            	        			    	    int LA207_0 = input.LA(1);

            	        			    	    if ( (LA207_0 == LT) )
            	        			    	    {
            	        			    	        alt207 = 1;
            	        			    	    }


            	        			    	    switch (alt207) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:350:54: LT
            	        			    			    {
            	        			    			    	LT415=(IToken)Match(input,LT,FOLLOW_LT_in_objectLiteral3154); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop207;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop207:
            	        			    		;	// Stops C# compiler whining that label 'loop207' has no statements

            	        			    	char_literal416=(IToken)Match(input,43,FOLLOW_43_in_objectLiteral3158); if (state.failed) return retval;
            	        			    	// JavaScript.g:350:64: ( LT )*
            	        			    	do 
            	        			    	{
            	        			    	    int alt208 = 2;
            	        			    	    int LA208_0 = input.LA(1);

            	        			    	    if ( (LA208_0 == LT) )
            	        			    	    {
            	        			    	        alt208 = 1;
            	        			    	    }


            	        			    	    switch (alt208) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // JavaScript.g:350:64: LT
            	        			    			    {
            	        			    			    	LT417=(IToken)Match(input,LT,FOLLOW_LT_in_objectLiteral3161); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    goto loop208;
            	        			    	    }
            	        			    	} while (true);

            	        			    	loop208:
            	        			    		;	// Stops C# compiler whining that label 'loop208' has no statements

            	        			    	PushFollow(FOLLOW_propertyNameAndValue_in_objectLiteral3165);
            	        			    	propertyNameAndValue418 = propertyNameAndValue();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyNameAndValue418.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop209;
            	        	    }
            	        	} while (true);

            	        	loop209:
            	        		;	// Stops C# compiler whining that label 'loop209' has no statements

            	        	// JavaScript.g:350:90: ( ',' )?
            	        	int alt210 = 2;
            	        	int LA210_0 = input.LA(1);

            	        	if ( (LA210_0 == 43) )
            	        	{
            	        	    alt210 = 1;
            	        	}
            	        	switch (alt210) 
            	        	{
            	        	    case 1 :
            	        	        // JavaScript.g:350:91: ','
            	        	        {
            	        	        	char_literal419=(IToken)Match(input,43,FOLLOW_43_in_objectLiteral3170); if (state.failed) return retval;

            	        	        }
            	        	        break;

            	        	}

            	        	// JavaScript.g:350:100: ( LT )*
            	        	do 
            	        	{
            	        	    int alt211 = 2;
            	        	    int LA211_0 = input.LA(1);

            	        	    if ( (LA211_0 == LT) )
            	        	    {
            	        	        alt211 = 1;
            	        	    }


            	        	    switch (alt211) 
            	        		{
            	        			case 1 :
            	        			    // JavaScript.g:350:100: LT
            	        			    {
            	        			    	LT420=(IToken)Match(input,LT,FOLLOW_LT_in_objectLiteral3175); if (state.failed) return retval;

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop211;
            	        	    }
            	        	} while (true);

            	        	loop211:
            	        		;	// Stops C# compiler whining that label 'loop211' has no statements


            	        }
            	        break;

            	}

            	char_literal421=(IToken)Match(input,41,FOLLOW_41_in_objectLiteral3181); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectLiteral"

    public class propertyNameAndValue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "propertyNameAndValue"
    // JavaScript.g:353:1: propertyNameAndValue : propertyName ( LT )* ':' ( LT )* assignmentExpression ;
    public JavaScriptParser.propertyNameAndValue_return propertyNameAndValue() // throws RecognitionException [1]
    {   
        JavaScriptParser.propertyNameAndValue_return retval = new JavaScriptParser.propertyNameAndValue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LT423 = null;
        IToken char_literal424 = null;
        IToken LT425 = null;
        JavaScriptParser.propertyName_return propertyName422 = default(JavaScriptParser.propertyName_return);

        JavaScriptParser.assignmentExpression_return assignmentExpression426 = default(JavaScriptParser.assignmentExpression_return);


        object LT423_tree=null;
        object char_literal424_tree=null;
        object LT425_tree=null;

        try 
    	{
            // JavaScript.g:354:2: ( propertyName ( LT )* ':' ( LT )* assignmentExpression )
            // JavaScript.g:354:4: propertyName ( LT )* ':' ( LT )* assignmentExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_propertyName_in_propertyNameAndValue3195);
            	propertyName422 = propertyName();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, propertyName422.Tree);
            	// JavaScript.g:354:19: ( LT )*
            	do 
            	{
            	    int alt213 = 2;
            	    int LA213_0 = input.LA(1);

            	    if ( (LA213_0 == LT) )
            	    {
            	        alt213 = 1;
            	    }


            	    switch (alt213) 
            		{
            			case 1 :
            			    // JavaScript.g:354:19: LT
            			    {
            			    	LT423=(IToken)Match(input,LT,FOLLOW_LT_in_propertyNameAndValue3197); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop213;
            	    }
            	} while (true);

            	loop213:
            		;	// Stops C# compiler whining that label 'loop213' has no statements

            	char_literal424=(IToken)Match(input,58,FOLLOW_58_in_propertyNameAndValue3201); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal424_tree = (object)adaptor.Create(char_literal424);
            		root_0 = (object)adaptor.BecomeRoot(char_literal424_tree, root_0);
            	}
            	// JavaScript.g:354:29: ( LT )*
            	do 
            	{
            	    int alt214 = 2;
            	    int LA214_0 = input.LA(1);

            	    if ( (LA214_0 == LT) )
            	    {
            	        alt214 = 1;
            	    }


            	    switch (alt214) 
            		{
            			case 1 :
            			    // JavaScript.g:354:29: LT
            			    {
            			    	LT425=(IToken)Match(input,LT,FOLLOW_LT_in_propertyNameAndValue3204); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop214;
            	    }
            	} while (true);

            	loop214:
            		;	// Stops C# compiler whining that label 'loop214' has no statements

            	PushFollow(FOLLOW_assignmentExpression_in_propertyNameAndValue3208);
            	assignmentExpression426 = assignmentExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentExpression426.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyNameAndValue"

    public class propertyName_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "propertyName"
    // JavaScript.g:357:1: propertyName : ( Identifier | StringLiteral -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))] | NumericLiteral -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())] );
    public JavaScriptParser.propertyName_return propertyName() // throws RecognitionException [1]
    {   
        JavaScriptParser.propertyName_return retval = new JavaScriptParser.propertyName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier427 = null;
        IToken StringLiteral428 = null;
        IToken NumericLiteral429 = null;

        object Identifier427_tree=null;
        object StringLiteral428_tree=null;
        object NumericLiteral429_tree=null;
        RewriteRuleTokenStream stream_StringLiteral = new RewriteRuleTokenStream(adaptor,"token StringLiteral");
        RewriteRuleTokenStream stream_NumericLiteral = new RewriteRuleTokenStream(adaptor,"token NumericLiteral");

        try 
    	{
            // JavaScript.g:358:2: ( Identifier | StringLiteral -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))] | NumericLiteral -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())] )
            int alt215 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            	{
                alt215 = 1;
                }
                break;
            case StringLiteral:
            	{
                alt215 = 2;
                }
                break;
            case NumericLiteral:
            	{
                alt215 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d215s0 =
            	        new NoViableAltException("", 215, 0, input);

            	    throw nvae_d215s0;
            }

            switch (alt215) 
            {
                case 1 :
                    // JavaScript.g:358:4: Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Identifier427=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_propertyName3219); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Identifier427_tree = (object)adaptor.Create(Identifier427);
                    		adaptor.AddChild(root_0, Identifier427_tree);
                    	}

                    }
                    break;
                case 2 :
                    // JavaScript.g:359:4: StringLiteral
                    {
                    	StringLiteral428=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_propertyName3225); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_StringLiteral.Add(StringLiteral428);



                    	// AST REWRITE
                    	// elements:          StringLiteral
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 359:18: -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))]
                    	{
                    	    adaptor.AddChild(root_0, new LiteralNode(StringLiteral, new JSString(ProcessEscapedString(StringLiteral428.Text))));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // JavaScript.g:360:4: NumericLiteral
                    {
                    	NumericLiteral429=(IToken)Match(input,NumericLiteral,FOLLOW_NumericLiteral_in_propertyName3238); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_NumericLiteral.Add(NumericLiteral429);



                    	// AST REWRITE
                    	// elements:          NumericLiteral
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 360:19: -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())]
                    	{
                    	    adaptor.AddChild(root_0, new LiteralNode(NumericLiteral, new JSNumber(NumericLiteral429.Text.ToJSNumber())));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "propertyName"

    public class literal_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "literal"
    // JavaScript.g:364:1: literal : ( 'null' | 'true' | 'false' | StringLiteral -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))] | NumericLiteral -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())] | RegexLiteral );
    public JavaScriptParser.literal_return literal() // throws RecognitionException [1]
    {   
        JavaScriptParser.literal_return retval = new JavaScriptParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal430 = null;
        IToken string_literal431 = null;
        IToken string_literal432 = null;
        IToken StringLiteral433 = null;
        IToken NumericLiteral434 = null;
        IToken RegexLiteral435 = null;

        object string_literal430_tree=null;
        object string_literal431_tree=null;
        object string_literal432_tree=null;
        object StringLiteral433_tree=null;
        object NumericLiteral434_tree=null;
        object RegexLiteral435_tree=null;
        RewriteRuleTokenStream stream_StringLiteral = new RewriteRuleTokenStream(adaptor,"token StringLiteral");
        RewriteRuleTokenStream stream_NumericLiteral = new RewriteRuleTokenStream(adaptor,"token NumericLiteral");

        try 
    	{
            // JavaScript.g:365:2: ( 'null' | 'true' | 'false' | StringLiteral -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))] | NumericLiteral -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())] | RegexLiteral )
            int alt216 = 6;
            switch ( input.LA(1) ) 
            {
            case 112:
            	{
                alt216 = 1;
                }
                break;
            case 113:
            	{
                alt216 = 2;
                }
                break;
            case 114:
            	{
                alt216 = 3;
                }
                break;
            case StringLiteral:
            	{
                alt216 = 4;
                }
                break;
            case NumericLiteral:
            	{
                alt216 = 5;
                }
                break;
            case RegexLiteral:
            	{
                alt216 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d216s0 =
            	        new NoViableAltException("", 216, 0, input);

            	    throw nvae_d216s0;
            }

            switch (alt216) 
            {
                case 1 :
                    // JavaScript.g:365:4: 'null'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal430=(IToken)Match(input,112,FOLLOW_112_in_literal3258); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal430_tree = new LiteralNull(string_literal430) ;
                    		adaptor.AddChild(root_0, string_literal430_tree);
                    	}

                    }
                    break;
                case 2 :
                    // JavaScript.g:366:4: 'true'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal431=(IToken)Match(input,113,FOLLOW_113_in_literal3266); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal431_tree = new LiteralTrue(string_literal431) ;
                    		adaptor.AddChild(root_0, string_literal431_tree);
                    	}

                    }
                    break;
                case 3 :
                    // JavaScript.g:367:4: 'false'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal432=(IToken)Match(input,114,FOLLOW_114_in_literal3274); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal432_tree = new LiteralFalse(string_literal432) ;
                    		adaptor.AddChild(root_0, string_literal432_tree);
                    	}

                    }
                    break;
                case 4 :
                    // JavaScript.g:368:4: StringLiteral
                    {
                    	StringLiteral433=(IToken)Match(input,StringLiteral,FOLLOW_StringLiteral_in_literal3282); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_StringLiteral.Add(StringLiteral433);



                    	// AST REWRITE
                    	// elements:          StringLiteral
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 368:18: -> StringLiteral[new JSString(ProcessEscapedString($StringLiteral.Text))]
                    	{
                    	    adaptor.AddChild(root_0, new LiteralNode(StringLiteral, new JSString(ProcessEscapedString(StringLiteral433.Text))));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 5 :
                    // JavaScript.g:369:4: NumericLiteral
                    {
                    	NumericLiteral434=(IToken)Match(input,NumericLiteral,FOLLOW_NumericLiteral_in_literal3295); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_NumericLiteral.Add(NumericLiteral434);



                    	// AST REWRITE
                    	// elements:          NumericLiteral
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 369:19: -> NumericLiteral[new JSNumber($NumericLiteral.Text.ToJSNumber())]
                    	{
                    	    adaptor.AddChild(root_0, new LiteralNode(NumericLiteral, new JSNumber(NumericLiteral434.Text.ToJSNumber())));

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // JavaScript.g:370:4: RegexLiteral
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	RegexLiteral435=(IToken)Match(input,RegexLiteral,FOLLOW_RegexLiteral_in_literal3308); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{RegexLiteral435_tree = new LiteralRegex(RegexLiteral435) ;
                    		adaptor.AddChild(root_0, RegexLiteral435_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    // $ANTLR start "synpred1_JavaScript"
    public void synpred1_JavaScript_fragment() {
        // JavaScript.g:33:65: ( ( LT )* '}' )
        // JavaScript.g:33:66: ( LT )* '}'
        {
        	// JavaScript.g:33:66: ( LT )*
        	do 
        	{
        	    int alt217 = 2;
        	    int LA217_0 = input.LA(1);

        	    if ( (LA217_0 == LT) )
        	    {
        	        alt217 = 1;
        	    }


        	    switch (alt217) 
        		{
        			case 1 :
        			    // JavaScript.g:33:66: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred1_JavaScript148); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop217;
        	    }
        	} while (true);

        	loop217:
        		;	// Stops C# compiler whining that label 'loop217' has no statements

        	Match(input,41,FOLLOW_41_in_synpred1_JavaScript151); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_JavaScript"

    // $ANTLR start "synpred2_JavaScript"
    public void synpred2_JavaScript_fragment() {
        // JavaScript.g:38:79: ( ( LT )* '}' )
        // JavaScript.g:38:80: ( LT )* '}'
        {
        	// JavaScript.g:38:80: ( LT )*
        	do 
        	{
        	    int alt218 = 2;
        	    int LA218_0 = input.LA(1);

        	    if ( (LA218_0 == LT) )
        	    {
        	        alt218 = 1;
        	    }


        	    switch (alt218) 
        		{
        			case 1 :
        			    // JavaScript.g:38:80: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred2_JavaScript250); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop218;
        	    }
        	} while (true);

        	loop218:
        		;	// Stops C# compiler whining that label 'loop218' has no statements

        	Match(input,41,FOLLOW_41_in_synpred2_JavaScript253); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_JavaScript"

    // $ANTLR start "synpred3_JavaScript"
    public void synpred3_JavaScript_fragment() {
        // JavaScript.g:53:4: ( 'function' ( LT )* Identifier )
        // JavaScript.g:53:5: 'function' ( LT )* Identifier
        {
        	Match(input,39,FOLLOW_39_in_synpred3_JavaScript394); if (state.failed) return ;
        	// JavaScript.g:53:16: ( LT )*
        	do 
        	{
        	    int alt219 = 2;
        	    int LA219_0 = input.LA(1);

        	    if ( (LA219_0 == LT) )
        	    {
        	        alt219 = 1;
        	    }


        	    switch (alt219) 
        		{
        			case 1 :
        			    // JavaScript.g:53:16: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred3_JavaScript396); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop219;
        	    }
        	} while (true);

        	loop219:
        		;	// Stops C# compiler whining that label 'loop219' has no statements

        	Match(input,Identifier,FOLLOW_Identifier_in_synpred3_JavaScript399); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_JavaScript"

    // $ANTLR start "synpred4_JavaScript"
    public void synpred4_JavaScript_fragment() {
        // JavaScript.g:54:4: ( Identifier ( LT )* ':' )
        // JavaScript.g:54:5: Identifier ( LT )* ':'
        {
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred4_JavaScript410); if (state.failed) return ;
        	// JavaScript.g:54:16: ( LT )*
        	do 
        	{
        	    int alt220 = 2;
        	    int LA220_0 = input.LA(1);

        	    if ( (LA220_0 == LT) )
        	    {
        	        alt220 = 1;
        	    }


        	    switch (alt220) 
        		{
        			case 1 :
        			    // JavaScript.g:54:16: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred4_JavaScript412); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop220;
        	    }
        	} while (true);

        	loop220:
        		;	// Stops C# compiler whining that label 'loop220' has no statements

        	Match(input,58,FOLLOW_58_in_synpred4_JavaScript415); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_JavaScript"

    // $ANTLR start "synpred5_JavaScript"
    public void synpred5_JavaScript_fragment() {
        // JavaScript.g:55:4: ( '{' )
        // JavaScript.g:55:5: '{'
        {
        	Match(input,40,FOLLOW_40_in_synpred5_JavaScript427); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_JavaScript"

    // $ANTLR start "synpred6_JavaScript"
    public void synpred6_JavaScript_fragment() {
        // JavaScript.g:72:6: ( ( LT )* '}' )
        // JavaScript.g:72:7: ( LT )* '}'
        {
        	// JavaScript.g:72:7: ( LT )*
        	do 
        	{
        	    int alt221 = 2;
        	    int LA221_0 = input.LA(1);

        	    if ( (LA221_0 == LT) )
        	    {
        	        alt221 = 1;
        	    }


        	    switch (alt221) 
        		{
        			case 1 :
        			    // JavaScript.g:72:7: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred6_JavaScript528); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop221;
        	    }
        	} while (true);

        	loop221:
        		;	// Stops C# compiler whining that label 'loop221' has no statements

        	Match(input,41,FOLLOW_41_in_synpred6_JavaScript531); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_JavaScript"

    // $ANTLR start "synpred7_JavaScript"
    public void synpred7_JavaScript_fragment() {
        // JavaScript.g:107:16: ( '}' | EOF )
        // JavaScript.g:
        {
        	if ( input.LA(1) == EOF || input.LA(1) == 41 ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred7_JavaScript"

    // $ANTLR start "synpred8_JavaScript"
    public void synpred8_JavaScript_fragment() {
        // JavaScript.g:113:3: ( ( LT )* 'else' )
        // JavaScript.g:113:4: ( LT )* 'else'
        {
        	// JavaScript.g:113:4: ( LT )*
        	do 
        	{
        	    int alt222 = 2;
        	    int LA222_0 = input.LA(1);

        	    if ( (LA222_0 == LT) )
        	    {
        	        alt222 = 1;
        	    }


        	    switch (alt222) 
        		{
        			case 1 :
        			    // JavaScript.g:113:4: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred8_JavaScript825); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop222;
        	    }
        	} while (true);

        	loop222:
        		;	// Stops C# compiler whining that label 'loop222' has no statements

        	Match(input,49,FOLLOW_49_in_synpred8_JavaScript828); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_JavaScript"

    // $ANTLR start "synpred9_JavaScript"
    public void synpred9_JavaScript_fragment() {
        // JavaScript.g:121:4: ( 'for' ( LT )* '(' )
        // JavaScript.g:121:5: 'for' ( LT )* '('
        {
        	Match(input,52,FOLLOW_52_in_synpred9_JavaScript878); if (state.failed) return ;
        	// JavaScript.g:121:11: ( LT )*
        	do 
        	{
        	    int alt223 = 2;
        	    int LA223_0 = input.LA(1);

        	    if ( (LA223_0 == LT) )
        	    {
        	        alt223 = 1;
        	    }


        	    switch (alt223) 
        		{
        			case 1 :
        			    // JavaScript.g:121:11: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred9_JavaScript880); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop223;
        	    }
        	} while (true);

        	loop223:
        		;	// Stops C# compiler whining that label 'loop223' has no statements

        	Match(input,42,FOLLOW_42_in_synpred9_JavaScript883); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_JavaScript"

    // $ANTLR start "synpred10_JavaScript"
    public void synpred10_JavaScript_fragment() {
        // JavaScript.g:153:31: ( Identifier )
        // JavaScript.g:153:32: Identifier
        {
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred10_JavaScript1239); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_JavaScript"

    // $ANTLR start "synpred11_JavaScript"
    public void synpred11_JavaScript_fragment() {
        // JavaScript.g:157:25: ( Identifier )
        // JavaScript.g:157:26: Identifier
        {
        	Match(input,Identifier,FOLLOW_Identifier_in_synpred11_JavaScript1272); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_JavaScript"

    // $ANTLR start "synpred12_JavaScript"
    public void synpred12_JavaScript_fragment() {
        // JavaScript.g:161:32: ( statementEnd )
        // JavaScript.g:161:33: statementEnd
        {
        	PushFollow(FOLLOW_statementEnd_in_synpred12_JavaScript1305);
        	statementEnd();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_JavaScript"

    // $ANTLR start "synpred13_JavaScript"
    public void synpred13_JavaScript_fragment() {
        // JavaScript.g:181:51: ( 'case' | 'default' | '}' )
        // JavaScript.g:
        {
        	if ( input.LA(1) == 41 || (input.LA(1) >= 60 && input.LA(1) <= 61) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred13_JavaScript"

    // $ANTLR start "synpred14_JavaScript"
    public void synpred14_JavaScript_fragment() {
        // JavaScript.g:185:41: ( 'case' | 'default' | '}' )
        // JavaScript.g:
        {
        	if ( input.LA(1) == 41 || (input.LA(1) >= 60 && input.LA(1) <= 61) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred14_JavaScript"

    // $ANTLR start "synpred15_JavaScript"
    public void synpred15_JavaScript_fragment() {
        // JavaScript.g:211:4: ( leftHandSideExpression ( LT )* assignmentOperator )
        // JavaScript.g:211:5: leftHandSideExpression ( LT )* assignmentOperator
        {
        	PushFollow(FOLLOW_leftHandSideExpression_in_synpred15_JavaScript1801);
        	leftHandSideExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// JavaScript.g:211:28: ( LT )*
        	do 
        	{
        	    int alt224 = 2;
        	    int LA224_0 = input.LA(1);

        	    if ( (LA224_0 == LT) )
        	    {
        	        alt224 = 1;
        	    }


        	    switch (alt224) 
        		{
        			case 1 :
        			    // JavaScript.g:211:28: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred15_JavaScript1803); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop224;
        	    }
        	} while (true);

        	loop224:
        		;	// Stops C# compiler whining that label 'loop224' has no statements

        	PushFollow(FOLLOW_assignmentOperator_in_synpred15_JavaScript1806);
        	assignmentOperator();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_JavaScript"

    // $ANTLR start "synpred16_JavaScript"
    public void synpred16_JavaScript_fragment() {
        // JavaScript.g:217:4: ( 'new' )
        // JavaScript.g:217:5: 'new'
        {
        	Match(input,66,FOLLOW_66_in_synpred16_JavaScript1848); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_JavaScript"

    // $ANTLR start "synpred17_JavaScript"
    public void synpred17_JavaScript_fragment() {
        // JavaScript.g:218:4: ( 'function' )
        // JavaScript.g:218:5: 'function'
        {
        	Match(input,39,FOLLOW_39_in_synpred17_JavaScript1869); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_JavaScript"

    // $ANTLR start "synpred18_JavaScript"
    public void synpred18_JavaScript_fragment() {
        // JavaScript.g:219:23: ( ( LT )* ( '(' | '[' | '.' ) )
        // JavaScript.g:219:24: ( LT )* ( '(' | '[' | '.' )
        {
        	// JavaScript.g:219:24: ( LT )*
        	do 
        	{
        	    int alt225 = 2;
        	    int LA225_0 = input.LA(1);

        	    if ( (LA225_0 == LT) )
        	    {
        	        alt225 = 1;
        	    }


        	    switch (alt225) 
        		{
        			case 1 :
        			    // JavaScript.g:219:24: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred18_JavaScript1883); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop225;
        	    }
        	} while (true);

        	loop225:
        		;	// Stops C# compiler whining that label 'loop225' has no statements

        	if ( input.LA(1) == 42 || input.LA(1) == 67 || input.LA(1) == 69 ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred18_JavaScript"

    // $ANTLR start "synpred19_JavaScript"
    public void synpred19_JavaScript_fragment() {
        // JavaScript.g:223:4: ( '(' )
        // JavaScript.g:223:5: '('
        {
        	Match(input,42,FOLLOW_42_in_synpred19_JavaScript1920); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_JavaScript"

    // $ANTLR start "synpred20_JavaScript"
    public void synpred20_JavaScript_fragment() {
        // JavaScript.g:224:4: ( '[' )
        // JavaScript.g:224:5: '['
        {
        	Match(input,67,FOLLOW_67_in_synpred20_JavaScript1942); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_JavaScript"

    // $ANTLR start "synpred21_JavaScript"
    public void synpred21_JavaScript_fragment() {
        // JavaScript.g:304:3: ( ( LT )* ( '+' | '-' ) additiveExpression )
        // JavaScript.g:304:4: ( LT )* ( '+' | '-' ) additiveExpression
        {
        	// JavaScript.g:304:4: ( LT )*
        	do 
        	{
        	    int alt226 = 2;
        	    int LA226_0 = input.LA(1);

        	    if ( (LA226_0 == LT) )
        	    {
        	        alt226 = 1;
        	    }


        	    switch (alt226) 
        		{
        			case 1 :
        			    // JavaScript.g:304:4: LT
        			    {
        			    	Match(input,LT,FOLLOW_LT_in_synpred21_JavaScript2732); if (state.failed) return ;

        			    }
        			    break;

        			default:
        			    goto loop226;
        	    }
        	} while (true);

        	loop226:
        		;	// Stops C# compiler whining that label 'loop226' has no statements

        	if ( (input.LA(1) >= 99 && input.LA(1) <= 100) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}

        	PushFollow(FOLLOW_additiveExpression_in_synpred21_JavaScript2741);
        	additiveExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_JavaScript"

    // Delegated rules

   	public bool synpred7_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred19_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred20_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred13_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred21_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred18_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred10_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_JavaScript() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_JavaScript_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA5 dfa5;
   	protected DFA12 dfa12;
   	protected DFA11 dfa11;
   	protected DFA21 dfa21;
   	protected DFA20 dfa20;
   	protected DFA27 dfa27;
   	protected DFA26 dfa26;
   	protected DFA29 dfa29;
   	protected DFA33 dfa33;
   	protected DFA35 dfa35;
   	protected DFA39 dfa39;
   	protected DFA41 dfa41;
   	protected DFA43 dfa43;
   	protected DFA63 dfa63;
   	protected DFA66 dfa66;
   	protected DFA69 dfa69;
   	protected DFA84 dfa84;
   	protected DFA96 dfa96;
   	protected DFA100 dfa100;
   	protected DFA99 dfa99;
   	protected DFA105 dfa105;
   	protected DFA108 dfa108;
   	protected DFA112 dfa112;
   	protected DFA124 dfa124;
   	protected DFA123 dfa123;
   	protected DFA127 dfa127;
   	protected DFA130 dfa130;
   	protected DFA140 dfa140;
   	protected DFA139 dfa139;
   	protected DFA147 dfa147;
   	protected DFA150 dfa150;
   	protected DFA153 dfa153;
   	protected DFA156 dfa156;
   	protected DFA159 dfa159;
   	protected DFA162 dfa162;
   	protected DFA169 dfa169;
   	protected DFA178 dfa178;
   	protected DFA184 dfa184;
   	protected DFA187 dfa187;
   	protected DFA191 dfa191;
   	protected DFA199 dfa199;
   	protected DFA200 dfa200;
   	protected DFA209 dfa209;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
    	this.dfa12 = new DFA12(this);
    	this.dfa11 = new DFA11(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa20 = new DFA20(this);
    	this.dfa27 = new DFA27(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa29 = new DFA29(this);
    	this.dfa33 = new DFA33(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa39 = new DFA39(this);
    	this.dfa41 = new DFA41(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa63 = new DFA63(this);
    	this.dfa66 = new DFA66(this);
    	this.dfa69 = new DFA69(this);
    	this.dfa84 = new DFA84(this);
    	this.dfa96 = new DFA96(this);
    	this.dfa100 = new DFA100(this);
    	this.dfa99 = new DFA99(this);
    	this.dfa105 = new DFA105(this);
    	this.dfa108 = new DFA108(this);
    	this.dfa112 = new DFA112(this);
    	this.dfa124 = new DFA124(this);
    	this.dfa123 = new DFA123(this);
    	this.dfa127 = new DFA127(this);
    	this.dfa130 = new DFA130(this);
    	this.dfa140 = new DFA140(this);
    	this.dfa139 = new DFA139(this);
    	this.dfa147 = new DFA147(this);
    	this.dfa150 = new DFA150(this);
    	this.dfa153 = new DFA153(this);
    	this.dfa156 = new DFA156(this);
    	this.dfa159 = new DFA159(this);
    	this.dfa162 = new DFA162(this);
    	this.dfa169 = new DFA169(this);
    	this.dfa178 = new DFA178(this);
    	this.dfa184 = new DFA184(this);
    	this.dfa187 = new DFA187(this);
    	this.dfa191 = new DFA191(this);
    	this.dfa199 = new DFA199(this);
    	this.dfa200 = new DFA200(this);
    	this.dfa209 = new DFA209(this);
	    this.dfa12.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA12_SpecialStateTransition);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);
	    this.dfa29.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA29_SpecialStateTransition);
	    this.dfa33.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA33_SpecialStateTransition);
	    this.dfa43.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA43_SpecialStateTransition);
	    this.dfa84.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA84_SpecialStateTransition);
	    this.dfa105.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA105_SpecialStateTransition);
	    this.dfa108.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA108_SpecialStateTransition);
	    this.dfa127.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA127_SpecialStateTransition);
	    this.dfa130.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA130_SpecialStateTransition);
	    this.dfa187.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA187_SpecialStateTransition);
	}

    const string DFA5_eotS =
        "\x04\uffff";
    const string DFA5_eofS =
        "\x02\x02\x02\uffff";
    const string DFA5_minS =
        "\x02\x0b\x02\uffff";
    const string DFA5_maxS =
        "\x02\x72\x02\uffff";
    const string DFA5_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA5_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\uffff\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\uffff\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 29:14: ( ( LT )* statement )*"; }
        }

    }

    const string DFA12_eotS =
        "\x04\uffff";
    const string DFA12_eofS =
        "\x04\uffff";
    const string DFA12_minS =
        "\x02\x0b\x02\uffff";
    const string DFA12_maxS =
        "\x02\x72\x02\uffff";
    const string DFA12_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA12_specialS =
        "\x01\x00\x01\x01\x02\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "33:64: ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* )"; }
        }

    }


    protected internal int DFA12_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA12_0 = input.LA(1);

                   	 
                   	int index12_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA12_0 == LT) ) { s = 1; }

                   	else if ( (LA12_0 == 41) && (synpred1_JavaScript()) ) { s = 2; }

                   	else if ( ((LA12_0 >= Identifier && LA12_0 <= RegexLiteral) || (LA12_0 >= 39 && LA12_0 <= 40) || LA12_0 == 42 || LA12_0 == 45 || (LA12_0 >= 47 && LA12_0 <= 48) || (LA12_0 >= 50 && LA12_0 <= 52) || (LA12_0 >= 54 && LA12_0 <= 57) || LA12_0 == 59 || (LA12_0 >= 62 && LA12_0 <= 63) || (LA12_0 >= 66 && LA12_0 <= 67) || (LA12_0 >= 99 && LA12_0 <= 100) || (LA12_0 >= 104 && LA12_0 <= 114)) ) { s = 3; }

                   	 
                   	input.Seek(index12_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA12_1 = input.LA(1);

                   	 
                   	int index12_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA12_1 >= Identifier && LA12_1 <= RegexLiteral) || (LA12_1 >= 39 && LA12_1 <= 40) || LA12_1 == 42 || LA12_1 == 45 || (LA12_1 >= 47 && LA12_1 <= 48) || (LA12_1 >= 50 && LA12_1 <= 52) || (LA12_1 >= 54 && LA12_1 <= 57) || LA12_1 == 59 || (LA12_1 >= 62 && LA12_1 <= 63) || (LA12_1 >= 66 && LA12_1 <= 67) || (LA12_1 >= 99 && LA12_1 <= 100) || (LA12_1 >= 104 && LA12_1 <= 114)) ) { s = 3; }

                   	else if ( (LA12_1 == LT) ) { s = 1; }

                   	else if ( (LA12_1 == 41) && (synpred1_JavaScript()) ) { s = 2; }

                   	 
                   	input.Seek(index12_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae12 =
            new NoViableAltException(dfa.Description, 12, _s, input);
        dfa.Error(nvae12);
        throw nvae12;
    }
    const string DFA11_eotS =
        "\x04\uffff";
    const string DFA11_eofS =
        "\x04\uffff";
    const string DFA11_minS =
        "\x02\x0b\x02\uffff";
    const string DFA11_maxS =
        "\x02\x72\x02\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA11_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 33:95: ( ( LT )* statement )*"; }
        }

    }

    const string DFA21_eotS =
        "\x04\uffff";
    const string DFA21_eofS =
        "\x04\uffff";
    const string DFA21_minS =
        "\x02\x0b\x02\uffff";
    const string DFA21_maxS =
        "\x02\x72\x02\uffff";
    const string DFA21_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA21_specialS =
        "\x01\x00\x01\x01\x02\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "38:78: ( ( ( LT )* '}' )=> () | ( LT )* statement ( ( LT )* statement )* )"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_0 = input.LA(1);

                   	 
                   	int index21_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA21_0 == LT) ) { s = 1; }

                   	else if ( (LA21_0 == 41) && (synpred2_JavaScript()) ) { s = 2; }

                   	else if ( ((LA21_0 >= Identifier && LA21_0 <= RegexLiteral) || (LA21_0 >= 39 && LA21_0 <= 40) || LA21_0 == 42 || LA21_0 == 45 || (LA21_0 >= 47 && LA21_0 <= 48) || (LA21_0 >= 50 && LA21_0 <= 52) || (LA21_0 >= 54 && LA21_0 <= 57) || LA21_0 == 59 || (LA21_0 >= 62 && LA21_0 <= 63) || (LA21_0 >= 66 && LA21_0 <= 67) || (LA21_0 >= 99 && LA21_0 <= 100) || (LA21_0 >= 104 && LA21_0 <= 114)) ) { s = 3; }

                   	 
                   	input.Seek(index21_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA21_1 = input.LA(1);

                   	 
                   	int index21_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA21_1 >= Identifier && LA21_1 <= RegexLiteral) || (LA21_1 >= 39 && LA21_1 <= 40) || LA21_1 == 42 || LA21_1 == 45 || (LA21_1 >= 47 && LA21_1 <= 48) || (LA21_1 >= 50 && LA21_1 <= 52) || (LA21_1 >= 54 && LA21_1 <= 57) || LA21_1 == 59 || (LA21_1 >= 62 && LA21_1 <= 63) || (LA21_1 >= 66 && LA21_1 <= 67) || (LA21_1 >= 99 && LA21_1 <= 100) || (LA21_1 >= 104 && LA21_1 <= 114)) ) { s = 3; }

                   	else if ( (LA21_1 == LT) ) { s = 1; }

                   	else if ( (LA21_1 == 41) && (synpred2_JavaScript()) ) { s = 2; }

                   	 
                   	input.Seek(index21_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
    const string DFA20_eotS =
        "\x04\uffff";
    const string DFA20_eofS =
        "\x04\uffff";
    const string DFA20_minS =
        "\x02\x0b\x02\uffff";
    const string DFA20_maxS =
        "\x02\x72\x02\uffff";
    const string DFA20_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA20_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA20_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
    static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
    static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
    static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
    static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
    static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
    static readonly short[][] DFA20_transition = DFA.UnpackEncodedStringArray(DFA20_transitionS);

    protected class DFA20 : DFA
    {
        public DFA20(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 20;
            this.eot = DFA20_eot;
            this.eof = DFA20_eof;
            this.min = DFA20_min;
            this.max = DFA20_max;
            this.accept = DFA20_accept;
            this.special = DFA20_special;
            this.transition = DFA20_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 38:109: ( ( LT )* statement )*"; }
        }

    }

    const string DFA27_eotS =
        "\x04\uffff";
    const string DFA27_eofS =
        "\x04\uffff";
    const string DFA27_minS =
        "\x02\x0b\x02\uffff";
    const string DFA27_maxS =
        "\x02\x2c\x02\uffff";
    const string DFA27_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA27_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA27_transitionS = {
            "\x01\x01\x01\x02\x1f\uffff\x01\x03",
            "\x01\x01\x01\x02\x1f\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA27_eot = DFA.UnpackEncodedString(DFA27_eotS);
    static readonly short[] DFA27_eof = DFA.UnpackEncodedString(DFA27_eofS);
    static readonly char[] DFA27_min = DFA.UnpackEncodedStringToUnsignedChars(DFA27_minS);
    static readonly char[] DFA27_max = DFA.UnpackEncodedStringToUnsignedChars(DFA27_maxS);
    static readonly short[] DFA27_accept = DFA.UnpackEncodedString(DFA27_acceptS);
    static readonly short[] DFA27_special = DFA.UnpackEncodedString(DFA27_specialS);
    static readonly short[][] DFA27_transition = DFA.UnpackEncodedStringArray(DFA27_transitionS);

    protected class DFA27 : DFA
    {
        public DFA27(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 27;
            this.eot = DFA27_eot;
            this.eof = DFA27_eof;
            this.min = DFA27_min;
            this.max = DFA27_max;
            this.accept = DFA27_accept;
            this.special = DFA27_special;
            this.transition = DFA27_transition;

        }

        override public string Description
        {
            get { return "44:4: ( ( LT )* Identifier ( ( LT )* ',' ( LT )* Identifier )* )?"; }
        }

    }

    const string DFA26_eotS =
        "\x04\uffff";
    const string DFA26_eofS =
        "\x04\uffff";
    const string DFA26_minS =
        "\x02\x0b\x02\uffff";
    const string DFA26_maxS =
        "\x02\x2c\x02\uffff";
    const string DFA26_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA26_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x01\x1f\uffff\x01\x03\x01\x02",
            "\x01\x01\x1f\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 46:6: ( ( LT )* ',' ( LT )* Identifier )*"; }
        }

    }

    const string DFA29_eotS =
        "\x27\uffff";
    const string DFA29_eofS =
        "\x27\uffff";
    const string DFA29_minS =
        "\x01\x0c\x03\x00\x23\uffff";
    const string DFA29_maxS =
        "\x01\x72\x03\x00\x23\uffff";
    const string DFA29_acceptS =
        "\x04\uffff\x01\x04\x01\x05\x01\x06\x12\uffff\x01\x07\x01\x08\x02"+
        "\uffff\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01\x0f\x01"+
        "\x01\x01\x02\x01\x03";
    const string DFA29_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x23\uffff}>";
    static readonly string[] DFA29_transitionS = {
            "\x01\x02\x03\x06\x17\uffff\x01\x01\x01\x03\x01\uffff\x01\x06"+
            "\x02\uffff\x01\x04\x01\uffff\x01\x05\x01\x19\x01\uffff\x03\x1a"+
            "\x01\uffff\x01\x1d\x01\x1e\x01\x1f\x01\x20\x01\uffff\x01\x21"+
            "\x02\uffff\x01\x22\x01\x23\x02\uffff\x02\x06\x1f\uffff\x02\x06"+
            "\x03\uffff\x0b\x06",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA29_eot = DFA.UnpackEncodedString(DFA29_eotS);
    static readonly short[] DFA29_eof = DFA.UnpackEncodedString(DFA29_eofS);
    static readonly char[] DFA29_min = DFA.UnpackEncodedStringToUnsignedChars(DFA29_minS);
    static readonly char[] DFA29_max = DFA.UnpackEncodedStringToUnsignedChars(DFA29_maxS);
    static readonly short[] DFA29_accept = DFA.UnpackEncodedString(DFA29_acceptS);
    static readonly short[] DFA29_special = DFA.UnpackEncodedString(DFA29_specialS);
    static readonly short[][] DFA29_transition = DFA.UnpackEncodedStringArray(DFA29_transitionS);

    protected class DFA29 : DFA
    {
        public DFA29(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 29;
            this.eot = DFA29_eot;
            this.eof = DFA29_eof;
            this.min = DFA29_min;
            this.max = DFA29_max;
            this.accept = DFA29_accept;
            this.special = DFA29_special;
            this.transition = DFA29_transition;

        }

        override public string Description
        {
            get { return "52:1: statement : ( ( 'function' ( LT )* Identifier )=> functionDeclaration | ( Identifier ( LT )* ':' )=> labelledStatement | ( '{' )=> statementBlock | variableStatement | emptyStatement | expressionStatement | ifStatement | iterationStatement | continueStatement | breakStatement | returnStatement | withStatement | switchStatement | throwStatement | tryStatement );"; }
        }

    }


    protected internal int DFA29_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA29_1 = input.LA(1);

                   	 
                   	int index29_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred3_JavaScript()) ) { s = 36; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index29_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA29_2 = input.LA(1);

                   	 
                   	int index29_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred4_JavaScript()) ) { s = 37; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index29_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA29_3 = input.LA(1);

                   	 
                   	int index29_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred5_JavaScript()) ) { s = 38; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index29_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae29 =
            new NoViableAltException(dfa.Description, 29, _s, input);
        dfa.Error(nvae29);
        throw nvae29;
    }
    const string DFA33_eotS =
        "\x04\uffff";
    const string DFA33_eofS =
        "\x04\uffff";
    const string DFA33_minS =
        "\x02\x0b\x02\uffff";
    const string DFA33_maxS =
        "\x02\x72\x02\uffff";
    const string DFA33_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA33_specialS =
        "\x01\x01\x01\x00\x02\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\uffff\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
    static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
    static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
    static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
    static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
    static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
    static readonly short[][] DFA33_transition = DFA.UnpackEncodedStringArray(DFA33_transitionS);

    protected class DFA33 : DFA
    {
        public DFA33(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;

        }

        override public string Description
        {
            get { return "71:8: ( ( ( LT )* '}' )=> ( LT )* | ( LT )* statementList ( LT )* )"; }
        }

    }


    protected internal int DFA33_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA33_1 = input.LA(1);

                   	 
                   	int index33_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA33_1 == 41) && (synpred6_JavaScript()) ) { s = 2; }

                   	else if ( (LA33_1 == LT) ) { s = 1; }

                   	else if ( ((LA33_1 >= Identifier && LA33_1 <= RegexLiteral) || (LA33_1 >= 39 && LA33_1 <= 40) || LA33_1 == 42 || LA33_1 == 45 || (LA33_1 >= 47 && LA33_1 <= 48) || (LA33_1 >= 50 && LA33_1 <= 52) || (LA33_1 >= 54 && LA33_1 <= 57) || LA33_1 == 59 || (LA33_1 >= 62 && LA33_1 <= 63) || (LA33_1 >= 66 && LA33_1 <= 67) || (LA33_1 >= 99 && LA33_1 <= 100) || (LA33_1 >= 104 && LA33_1 <= 114)) ) { s = 3; }

                   	 
                   	input.Seek(index33_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA33_0 = input.LA(1);

                   	 
                   	int index33_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA33_0 == LT) ) { s = 1; }

                   	else if ( (LA33_0 == 41) && (synpred6_JavaScript()) ) { s = 2; }

                   	else if ( ((LA33_0 >= Identifier && LA33_0 <= RegexLiteral) || (LA33_0 >= 39 && LA33_0 <= 40) || LA33_0 == 42 || LA33_0 == 45 || (LA33_0 >= 47 && LA33_0 <= 48) || (LA33_0 >= 50 && LA33_0 <= 52) || (LA33_0 >= 54 && LA33_0 <= 57) || LA33_0 == 59 || (LA33_0 >= 62 && LA33_0 <= 63) || (LA33_0 >= 66 && LA33_0 <= 67) || (LA33_0 >= 99 && LA33_0 <= 100) || (LA33_0 >= 104 && LA33_0 <= 114)) ) { s = 3; }

                   	 
                   	input.Seek(index33_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae33 =
            new NoViableAltException(dfa.Description, 33, _s, input);
        dfa.Error(nvae33);
        throw nvae33;
    }
    const string DFA35_eotS =
        "\x04\uffff";
    const string DFA35_eofS =
        "\x04\uffff";
    const string DFA35_minS =
        "\x02\x0b\x02\uffff";
    const string DFA35_maxS =
        "\x02\x72\x02\uffff";
    const string DFA35_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA35_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\x02\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x02\x03\x01\x02\x01\x03\x02\uffff"+
            "\x01\x03\x01\uffff\x02\x03\x01\uffff\x03\x03\x01\uffff\x04\x03"+
            "\x01\uffff\x01\x03\x02\x02\x02\x03\x02\uffff\x02\x03\x1f\uffff"+
            "\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 78:14: ( ( LT )* statement )*"; }
        }

    }

    const string DFA39_eotS =
        "\x05\uffff";
    const string DFA39_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA39_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA39_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA39_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA39_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA39_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x04\x02\x01\x03\x01\uffff\x01\x02"+
            "\x01\uffff\x06\x02\x01\uffff\x04\x02\x01\uffff\x05\x02\x02\uffff"+
            "\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x04\x02\x01\x03\x01\uffff\x01\x02"+
            "\x01\uffff\x06\x02\x01\uffff\x04\x02\x01\uffff\x05\x02\x02\uffff"+
            "\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x04\x02\x01\x03\x01\uffff\x01\x02"+
            "\x01\uffff\x06\x02\x01\uffff\x04\x02\x01\uffff\x05\x02\x02\uffff"+
            "\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
    static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
    static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
    static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
    static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
    static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
    static readonly short[][] DFA39_transition = DFA.UnpackEncodedStringArray(DFA39_transitionS);

    protected class DFA39 : DFA
    {
        public DFA39(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 39;
            this.eot = DFA39_eot;
            this.eof = DFA39_eof;
            this.min = DFA39_min;
            this.max = DFA39_max;
            this.accept = DFA39_accept;
            this.special = DFA39_special;
            this.transition = DFA39_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 87:24: ( ( LT )* ',' ( LT )* variableDeclaration )*"; }
        }

    }

    const string DFA41_eotS =
        "\x05\uffff";
    const string DFA41_eofS =
        "\x02\x03\x02\uffff\x01\x03";
    const string DFA41_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA41_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA41_acceptS =
        "\x02\uffff\x01\x01\x01\x02\x01\uffff";
    const string DFA41_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA41_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x05\x03\x01\uffff\x01\x03\x01\x02"+
            "\x06\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x02\uffff\x02\x03"+
            "\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "\x01\x04\x04\x03\x17\uffff\x05\x03\x01\uffff\x01\x03\x01\x02"+
            "\x06\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x02\uffff\x02\x03"+
            "\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "",
            "",
            "\x01\x04\x04\x03\x17\uffff\x05\x03\x01\uffff\x01\x03\x01\x02"+
            "\x06\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x02\uffff\x02\x03"+
            "\x1f\uffff\x02\x03\x03\uffff\x0b\x03"
    };

    static readonly short[] DFA41_eot = DFA.UnpackEncodedString(DFA41_eotS);
    static readonly short[] DFA41_eof = DFA.UnpackEncodedString(DFA41_eofS);
    static readonly char[] DFA41_min = DFA.UnpackEncodedStringToUnsignedChars(DFA41_minS);
    static readonly char[] DFA41_max = DFA.UnpackEncodedStringToUnsignedChars(DFA41_maxS);
    static readonly short[] DFA41_accept = DFA.UnpackEncodedString(DFA41_acceptS);
    static readonly short[] DFA41_special = DFA.UnpackEncodedString(DFA41_specialS);
    static readonly short[][] DFA41_transition = DFA.UnpackEncodedStringArray(DFA41_transitionS);

    protected class DFA41 : DFA
    {
        public DFA41(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 41;
            this.eot = DFA41_eot;
            this.eof = DFA41_eof;
            this.min = DFA41_min;
            this.max = DFA41_max;
            this.accept = DFA41_accept;
            this.special = DFA41_special;
            this.transition = DFA41_transition;

        }

        override public string Description
        {
            get { return "91:15: ( ( LT )* initialiser )?"; }
        }

    }

    const string DFA43_eotS =
        "\x2c\uffff";
    const string DFA43_eofS =
        "\x01\x25\x2b\uffff";
    const string DFA43_minS =
        "\x01\x0b\x02\x00\x29\uffff";
    const string DFA43_maxS =
        "\x01\x72\x02\x00\x29\uffff";
    const string DFA43_acceptS =
        "\x03\uffff\x27\x03\x01\x01\x01\x02";
    const string DFA43_specialS =
        "\x01\x00\x01\x02\x01\x01\x29\uffff}>";
    static readonly string[] DFA43_transitionS = {
            "\x01\x01\x01\x04\x01\x0c\x01\x0d\x01\x0e\x17\uffff\x01\x03"+
            "\x01\x05\x01\x26\x01\x10\x02\uffff\x01\x06\x01\uffff\x01\x02"+
            "\x01\x1a\x01\x29\x01\x1b\x01\x1c\x01\x1d\x01\uffff\x01\x1e\x01"+
            "\x1f\x01\x20\x01\x21\x01\uffff\x01\x22\x01\x28\x01\x27\x01\x23"+
            "\x01\x24\x02\uffff\x01\x07\x01\x0f\x1f\uffff\x01\x16\x01\x17"+
            "\x03\uffff\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x18\x01"+
            "\x19\x01\x08\x01\x09\x01\x0a\x01\x0b",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "107:4: ( LT | ';' | ( '}' | EOF )=> () )"; }
        }

    }


    protected internal int DFA43_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA43_0 = input.LA(1);

                   	 
                   	int index43_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA43_0 == LT) ) { s = 1; }

                   	else if ( (LA43_0 == 47) ) { s = 2; }

                   	else if ( (LA43_0 == 39) && (synpred7_JavaScript()) ) { s = 3; }

                   	else if ( (LA43_0 == Identifier) && (synpred7_JavaScript()) ) { s = 4; }

                   	else if ( (LA43_0 == 40) && (synpred7_JavaScript()) ) { s = 5; }

                   	else if ( (LA43_0 == 45) && (synpred7_JavaScript()) ) { s = 6; }

                   	else if ( (LA43_0 == 66) && (synpred7_JavaScript()) ) { s = 7; }

                   	else if ( (LA43_0 == 111) && (synpred7_JavaScript()) ) { s = 8; }

                   	else if ( (LA43_0 == 112) && (synpred7_JavaScript()) ) { s = 9; }

                   	else if ( (LA43_0 == 113) && (synpred7_JavaScript()) ) { s = 10; }

                   	else if ( (LA43_0 == 114) && (synpred7_JavaScript()) ) { s = 11; }

                   	else if ( (LA43_0 == StringLiteral) && (synpred7_JavaScript()) ) { s = 12; }

                   	else if ( (LA43_0 == NumericLiteral) && (synpred7_JavaScript()) ) { s = 13; }

                   	else if ( (LA43_0 == RegexLiteral) && (synpred7_JavaScript()) ) { s = 14; }

                   	else if ( (LA43_0 == 67) && (synpred7_JavaScript()) ) { s = 15; }

                   	else if ( (LA43_0 == 42) && (synpred7_JavaScript()) ) { s = 16; }

                   	else if ( (LA43_0 == 104) && (synpred7_JavaScript()) ) { s = 17; }

                   	else if ( (LA43_0 == 105) && (synpred7_JavaScript()) ) { s = 18; }

                   	else if ( (LA43_0 == 106) && (synpred7_JavaScript()) ) { s = 19; }

                   	else if ( (LA43_0 == 107) && (synpred7_JavaScript()) ) { s = 20; }

                   	else if ( (LA43_0 == 108) && (synpred7_JavaScript()) ) { s = 21; }

                   	else if ( (LA43_0 == 99) && (synpred7_JavaScript()) ) { s = 22; }

                   	else if ( (LA43_0 == 100) && (synpred7_JavaScript()) ) { s = 23; }

                   	else if ( (LA43_0 == 109) && (synpred7_JavaScript()) ) { s = 24; }

                   	else if ( (LA43_0 == 110) && (synpred7_JavaScript()) ) { s = 25; }

                   	else if ( (LA43_0 == 48) && (synpred7_JavaScript()) ) { s = 26; }

                   	else if ( (LA43_0 == 50) && (synpred7_JavaScript()) ) { s = 27; }

                   	else if ( (LA43_0 == 51) && (synpred7_JavaScript()) ) { s = 28; }

                   	else if ( (LA43_0 == 52) && (synpred7_JavaScript()) ) { s = 29; }

                   	else if ( (LA43_0 == 54) && (synpred7_JavaScript()) ) { s = 30; }

                   	else if ( (LA43_0 == 55) && (synpred7_JavaScript()) ) { s = 31; }

                   	else if ( (LA43_0 == 56) && (synpred7_JavaScript()) ) { s = 32; }

                   	else if ( (LA43_0 == 57) && (synpred7_JavaScript()) ) { s = 33; }

                   	else if ( (LA43_0 == 59) && (synpred7_JavaScript()) ) { s = 34; }

                   	else if ( (LA43_0 == 62) && (synpred7_JavaScript()) ) { s = 35; }

                   	else if ( (LA43_0 == 63) && (synpred7_JavaScript()) ) { s = 36; }

                   	else if ( (LA43_0 == EOF) && (synpred7_JavaScript()) ) { s = 37; }

                   	else if ( (LA43_0 == 41) && (synpred7_JavaScript()) ) { s = 38; }

                   	else if ( (LA43_0 == 61) && (synpred7_JavaScript()) ) { s = 39; }

                   	else if ( (LA43_0 == 60) && (synpred7_JavaScript()) ) { s = 40; }

                   	else if ( (LA43_0 == 49) && (synpred7_JavaScript()) ) { s = 41; }

                   	 
                   	input.Seek(index43_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA43_2 = input.LA(1);

                   	 
                   	int index43_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (true) ) { s = 43; }

                   	else if ( (synpred7_JavaScript()) ) { s = 41; }

                   	 
                   	input.Seek(index43_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA43_1 = input.LA(1);

                   	 
                   	int index43_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (true) ) { s = 42; }

                   	else if ( (synpred7_JavaScript()) ) { s = 41; }

                   	 
                   	input.Seek(index43_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae43 =
            new NoViableAltException(dfa.Description, 43, _s, input);
        dfa.Error(nvae43);
        throw nvae43;
    }
    const string DFA63_eotS =
        "\x04\uffff";
    const string DFA63_eofS =
        "\x04\uffff";
    const string DFA63_minS =
        "\x02\x0b\x02\uffff";
    const string DFA63_maxS =
        "\x02\x72\x02\uffff";
    const string DFA63_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA63_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA63_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x02\uffff"+
            "\x01\x02\x01\uffff\x01\x03\x12\uffff\x02\x02\x1f\uffff\x02\x02"+
            "\x03\uffff\x0b\x02",
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x02\uffff"+
            "\x01\x02\x01\uffff\x01\x03\x12\uffff\x02\x02\x1f\uffff\x02\x02"+
            "\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA63_eot = DFA.UnpackEncodedString(DFA63_eotS);
    static readonly short[] DFA63_eof = DFA.UnpackEncodedString(DFA63_eofS);
    static readonly char[] DFA63_min = DFA.UnpackEncodedStringToUnsignedChars(DFA63_minS);
    static readonly char[] DFA63_max = DFA.UnpackEncodedStringToUnsignedChars(DFA63_maxS);
    static readonly short[] DFA63_accept = DFA.UnpackEncodedString(DFA63_acceptS);
    static readonly short[] DFA63_special = DFA.UnpackEncodedString(DFA63_specialS);
    static readonly short[][] DFA63_transition = DFA.UnpackEncodedStringArray(DFA63_transitionS);

    protected class DFA63 : DFA
    {
        public DFA63(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 63;
            this.eot = DFA63_eot;
            this.eof = DFA63_eof;
            this.min = DFA63_min;
            this.max = DFA63_max;
            this.accept = DFA63_accept;
            this.special = DFA63_special;
            this.transition = DFA63_transition;

        }

        override public string Description
        {
            get { return "134:18: ( ( LT )* forStatementInitialiserPart )?"; }
        }

    }

    const string DFA66_eotS =
        "\x04\uffff";
    const string DFA66_eofS =
        "\x04\uffff";
    const string DFA66_minS =
        "\x02\x0b\x02\uffff";
    const string DFA66_maxS =
        "\x02\x72\x02\uffff";
    const string DFA66_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA66_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA66_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x04\uffff"+
            "\x01\x03\x12\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x04\uffff"+
            "\x01\x03\x12\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA66_eot = DFA.UnpackEncodedString(DFA66_eotS);
    static readonly short[] DFA66_eof = DFA.UnpackEncodedString(DFA66_eofS);
    static readonly char[] DFA66_min = DFA.UnpackEncodedStringToUnsignedChars(DFA66_minS);
    static readonly char[] DFA66_max = DFA.UnpackEncodedStringToUnsignedChars(DFA66_maxS);
    static readonly short[] DFA66_accept = DFA.UnpackEncodedString(DFA66_acceptS);
    static readonly short[] DFA66_special = DFA.UnpackEncodedString(DFA66_specialS);
    static readonly short[][] DFA66_transition = DFA.UnpackEncodedStringArray(DFA66_transitionS);

    protected class DFA66 : DFA
    {
        public DFA66(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 66;
            this.eot = DFA66_eot;
            this.eof = DFA66_eof;
            this.min = DFA66_min;
            this.max = DFA66_max;
            this.accept = DFA66_accept;
            this.special = DFA66_special;
            this.transition = DFA66_transition;

        }

        override public string Description
        {
            get { return "134:61: ( ( LT )* a= expression )?"; }
        }

    }

    const string DFA69_eotS =
        "\x04\uffff";
    const string DFA69_eofS =
        "\x04\uffff";
    const string DFA69_minS =
        "\x02\x0b\x02\uffff";
    const string DFA69_maxS =
        "\x02\x72\x02\uffff";
    const string DFA69_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA69_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA69_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x01\x03\x15\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x01\x03\x15\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA69_eot = DFA.UnpackEncodedString(DFA69_eotS);
    static readonly short[] DFA69_eof = DFA.UnpackEncodedString(DFA69_eofS);
    static readonly char[] DFA69_min = DFA.UnpackEncodedStringToUnsignedChars(DFA69_minS);
    static readonly char[] DFA69_max = DFA.UnpackEncodedStringToUnsignedChars(DFA69_maxS);
    static readonly short[] DFA69_accept = DFA.UnpackEncodedString(DFA69_acceptS);
    static readonly short[] DFA69_special = DFA.UnpackEncodedString(DFA69_specialS);
    static readonly short[][] DFA69_transition = DFA.UnpackEncodedStringArray(DFA69_transitionS);

    protected class DFA69 : DFA
    {
        public DFA69(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 69;
            this.eot = DFA69_eot;
            this.eof = DFA69_eof;
            this.min = DFA69_min;
            this.max = DFA69_max;
            this.accept = DFA69_accept;
            this.special = DFA69_special;
            this.transition = DFA69_transition;

        }

        override public string Description
        {
            get { return "134:89: ( ( LT )* b= expression )?"; }
        }

    }

    const string DFA84_eotS =
        "\x2b\uffff";
    const string DFA84_eofS =
        "\x01\x25\x2a\uffff";
    const string DFA84_minS =
        "\x01\x0b\x02\uffff\x03\x00\x01\uffff\x13\x00\x11\uffff";
    const string DFA84_maxS =
        "\x01\x72\x02\uffff\x03\x00\x01\uffff\x13\x00\x11\uffff";
    const string DFA84_acceptS =
        "\x01\uffff\x02\x01\x03\uffff\x01\x01\x13\uffff\x10\x01\x01\x02";
    const string DFA84_specialS =
        "\x01\x00\x02\uffff\x01\x01\x01\x02\x01\x03\x01\uffff\x01\x04\x01"+
        "\x05\x01\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01"+
        "\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\x14\x01"+
        "\x15\x01\x16\x11\uffff}>";
    static readonly string[] DFA84_transitionS = {
            "\x01\x01\x01\x04\x01\x0c\x01\x0d\x01\x0e\x17\uffff\x01\x03"+
            "\x01\x05\x01\x26\x01\x10\x02\uffff\x01\x06\x01\uffff\x01\x02"+
            "\x01\x1a\x01\x29\x01\x1b\x01\x1c\x01\x1d\x01\uffff\x01\x1e\x01"+
            "\x1f\x01\x20\x01\x21\x01\uffff\x01\x22\x01\x28\x01\x27\x01\x23"+
            "\x01\x24\x02\uffff\x01\x07\x01\x0f\x1f\uffff\x01\x16\x01\x17"+
            "\x03\uffff\x01\x11\x01\x12\x01\x13\x01\x14\x01\x15\x01\x18\x01"+
            "\x19\x01\x08\x01\x09\x01\x0a\x01\x0b",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA84_eot = DFA.UnpackEncodedString(DFA84_eotS);
    static readonly short[] DFA84_eof = DFA.UnpackEncodedString(DFA84_eofS);
    static readonly char[] DFA84_min = DFA.UnpackEncodedStringToUnsignedChars(DFA84_minS);
    static readonly char[] DFA84_max = DFA.UnpackEncodedStringToUnsignedChars(DFA84_maxS);
    static readonly short[] DFA84_accept = DFA.UnpackEncodedString(DFA84_acceptS);
    static readonly short[] DFA84_special = DFA.UnpackEncodedString(DFA84_specialS);
    static readonly short[][] DFA84_transition = DFA.UnpackEncodedStringArray(DFA84_transitionS);

    protected class DFA84 : DFA
    {
        public DFA84(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 84;
            this.eot = DFA84_eot;
            this.eof = DFA84_eof;
            this.min = DFA84_min;
            this.max = DFA84_max;
            this.accept = DFA84_accept;
            this.special = DFA84_special;
            this.transition = DFA84_transition;

        }

        override public string Description
        {
            get { return "161:31: ( ( statementEnd )=> () | expression )"; }
        }

    }


    protected internal int DFA84_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA84_0 = input.LA(1);

                   	 
                   	int index84_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA84_0 == LT) && (synpred12_JavaScript()) ) { s = 1; }

                   	else if ( (LA84_0 == 47) && (synpred12_JavaScript()) ) { s = 2; }

                   	else if ( (LA84_0 == 39) ) { s = 3; }

                   	else if ( (LA84_0 == Identifier) ) { s = 4; }

                   	else if ( (LA84_0 == 40) ) { s = 5; }

                   	else if ( (LA84_0 == 45) && (synpred12_JavaScript()) ) { s = 6; }

                   	else if ( (LA84_0 == 66) ) { s = 7; }

                   	else if ( (LA84_0 == 111) ) { s = 8; }

                   	else if ( (LA84_0 == 112) ) { s = 9; }

                   	else if ( (LA84_0 == 113) ) { s = 10; }

                   	else if ( (LA84_0 == 114) ) { s = 11; }

                   	else if ( (LA84_0 == StringLiteral) ) { s = 12; }

                   	else if ( (LA84_0 == NumericLiteral) ) { s = 13; }

                   	else if ( (LA84_0 == RegexLiteral) ) { s = 14; }

                   	else if ( (LA84_0 == 67) ) { s = 15; }

                   	else if ( (LA84_0 == 42) ) { s = 16; }

                   	else if ( (LA84_0 == 104) ) { s = 17; }

                   	else if ( (LA84_0 == 105) ) { s = 18; }

                   	else if ( (LA84_0 == 106) ) { s = 19; }

                   	else if ( (LA84_0 == 107) ) { s = 20; }

                   	else if ( (LA84_0 == 108) ) { s = 21; }

                   	else if ( (LA84_0 == 99) ) { s = 22; }

                   	else if ( (LA84_0 == 100) ) { s = 23; }

                   	else if ( (LA84_0 == 109) ) { s = 24; }

                   	else if ( (LA84_0 == 110) ) { s = 25; }

                   	else if ( (LA84_0 == 48) && (synpred12_JavaScript()) ) { s = 26; }

                   	else if ( (LA84_0 == 50) && (synpred12_JavaScript()) ) { s = 27; }

                   	else if ( (LA84_0 == 51) && (synpred12_JavaScript()) ) { s = 28; }

                   	else if ( (LA84_0 == 52) && (synpred12_JavaScript()) ) { s = 29; }

                   	else if ( (LA84_0 == 54) && (synpred12_JavaScript()) ) { s = 30; }

                   	else if ( (LA84_0 == 55) && (synpred12_JavaScript()) ) { s = 31; }

                   	else if ( (LA84_0 == 56) && (synpred12_JavaScript()) ) { s = 32; }

                   	else if ( (LA84_0 == 57) && (synpred12_JavaScript()) ) { s = 33; }

                   	else if ( (LA84_0 == 59) && (synpred12_JavaScript()) ) { s = 34; }

                   	else if ( (LA84_0 == 62) && (synpred12_JavaScript()) ) { s = 35; }

                   	else if ( (LA84_0 == 63) && (synpred12_JavaScript()) ) { s = 36; }

                   	else if ( (LA84_0 == EOF) && (synpred12_JavaScript()) ) { s = 37; }

                   	else if ( (LA84_0 == 41) && (synpred12_JavaScript()) ) { s = 38; }

                   	else if ( (LA84_0 == 61) && (synpred12_JavaScript()) ) { s = 39; }

                   	else if ( (LA84_0 == 60) && (synpred12_JavaScript()) ) { s = 40; }

                   	else if ( (LA84_0 == 49) && (synpred12_JavaScript()) ) { s = 41; }

                   	 
                   	input.Seek(index84_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA84_3 = input.LA(1);

                   	 
                   	int index84_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA84_4 = input.LA(1);

                   	 
                   	int index84_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA84_5 = input.LA(1);

                   	 
                   	int index84_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA84_7 = input.LA(1);

                   	 
                   	int index84_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA84_8 = input.LA(1);

                   	 
                   	int index84_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA84_9 = input.LA(1);

                   	 
                   	int index84_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA84_10 = input.LA(1);

                   	 
                   	int index84_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA84_11 = input.LA(1);

                   	 
                   	int index84_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA84_12 = input.LA(1);

                   	 
                   	int index84_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA84_13 = input.LA(1);

                   	 
                   	int index84_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA84_14 = input.LA(1);

                   	 
                   	int index84_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA84_15 = input.LA(1);

                   	 
                   	int index84_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA84_16 = input.LA(1);

                   	 
                   	int index84_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA84_17 = input.LA(1);

                   	 
                   	int index84_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA84_18 = input.LA(1);

                   	 
                   	int index84_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA84_19 = input.LA(1);

                   	 
                   	int index84_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA84_20 = input.LA(1);

                   	 
                   	int index84_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA84_21 = input.LA(1);

                   	 
                   	int index84_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA84_22 = input.LA(1);

                   	 
                   	int index84_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA84_23 = input.LA(1);

                   	 
                   	int index84_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA84_24 = input.LA(1);

                   	 
                   	int index84_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA84_25 = input.LA(1);

                   	 
                   	int index84_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred12_JavaScript()) ) { s = 41; }

                   	else if ( (true) ) { s = 42; }

                   	 
                   	input.Seek(index84_25);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae84 =
            new NoViableAltException(dfa.Description, 84, _s, input);
        dfa.Error(nvae84);
        throw nvae84;
    }
    const string DFA96_eotS =
        "\x04\uffff";
    const string DFA96_eofS =
        "\x04\uffff";
    const string DFA96_minS =
        "\x02\x0b\x02\uffff";
    const string DFA96_maxS =
        "\x02\x3d\x02\uffff";
    const string DFA96_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA96_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA96_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02\x12\uffff\x01\x03\x01\x02",
            "\x01\x01\x1d\uffff\x01\x02\x12\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA96_eot = DFA.UnpackEncodedString(DFA96_eotS);
    static readonly short[] DFA96_eof = DFA.UnpackEncodedString(DFA96_eofS);
    static readonly char[] DFA96_min = DFA.UnpackEncodedStringToUnsignedChars(DFA96_minS);
    static readonly char[] DFA96_max = DFA.UnpackEncodedStringToUnsignedChars(DFA96_maxS);
    static readonly short[] DFA96_accept = DFA.UnpackEncodedString(DFA96_acceptS);
    static readonly short[] DFA96_special = DFA.UnpackEncodedString(DFA96_specialS);
    static readonly short[][] DFA96_transition = DFA.UnpackEncodedStringArray(DFA96_transitionS);

    protected class DFA96 : DFA
    {
        public DFA96(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 96;
            this.eot = DFA96_eot;
            this.eof = DFA96_eof;
            this.min = DFA96_min;
            this.max = DFA96_max;
            this.accept = DFA96_accept;
            this.special = DFA96_special;
            this.transition = DFA96_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 177:9: ( ( LT )* caseClause )*"; }
        }

    }

    const string DFA100_eotS =
        "\x04\uffff";
    const string DFA100_eofS =
        "\x04\uffff";
    const string DFA100_minS =
        "\x02\x0b\x02\uffff";
    const string DFA100_maxS =
        "\x02\x3d\x02\uffff";
    const string DFA100_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA100_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA100_transitionS = {
            "\x01\x01\x1d\uffff\x01\x03\x13\uffff\x01\x02",
            "\x01\x01\x1d\uffff\x01\x03\x13\uffff\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA100_eot = DFA.UnpackEncodedString(DFA100_eotS);
    static readonly short[] DFA100_eof = DFA.UnpackEncodedString(DFA100_eofS);
    static readonly char[] DFA100_min = DFA.UnpackEncodedStringToUnsignedChars(DFA100_minS);
    static readonly char[] DFA100_max = DFA.UnpackEncodedStringToUnsignedChars(DFA100_maxS);
    static readonly short[] DFA100_accept = DFA.UnpackEncodedString(DFA100_acceptS);
    static readonly short[] DFA100_special = DFA.UnpackEncodedString(DFA100_specialS);
    static readonly short[][] DFA100_transition = DFA.UnpackEncodedStringArray(DFA100_transitionS);

    protected class DFA100 : DFA
    {
        public DFA100(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 100;
            this.eot = DFA100_eot;
            this.eof = DFA100_eof;
            this.min = DFA100_min;
            this.max = DFA100_max;
            this.accept = DFA100_accept;
            this.special = DFA100_special;
            this.transition = DFA100_transition;

        }

        override public string Description
        {
            get { return "177:28: ( ( LT )* defaultClause ( ( LT )* caseClause )* )?"; }
        }

    }

    const string DFA99_eotS =
        "\x04\uffff";
    const string DFA99_eofS =
        "\x04\uffff";
    const string DFA99_minS =
        "\x02\x0b\x02\uffff";
    const string DFA99_maxS =
        "\x02\x3c\x02\uffff";
    const string DFA99_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA99_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA99_transitionS = {
            "\x01\x01\x1d\uffff\x01\x02\x12\uffff\x01\x03",
            "\x01\x01\x1d\uffff\x01\x02\x12\uffff\x01\x03",
            "",
            ""
    };

    static readonly short[] DFA99_eot = DFA.UnpackEncodedString(DFA99_eotS);
    static readonly short[] DFA99_eof = DFA.UnpackEncodedString(DFA99_eofS);
    static readonly char[] DFA99_min = DFA.UnpackEncodedStringToUnsignedChars(DFA99_minS);
    static readonly char[] DFA99_max = DFA.UnpackEncodedStringToUnsignedChars(DFA99_maxS);
    static readonly short[] DFA99_accept = DFA.UnpackEncodedString(DFA99_acceptS);
    static readonly short[] DFA99_special = DFA.UnpackEncodedString(DFA99_specialS);
    static readonly short[][] DFA99_transition = DFA.UnpackEncodedStringArray(DFA99_transitionS);

    protected class DFA99 : DFA
    {
        public DFA99(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 99;
            this.eot = DFA99_eot;
            this.eof = DFA99_eof;
            this.min = DFA99_min;
            this.max = DFA99_max;
            this.accept = DFA99_accept;
            this.special = DFA99_special;
            this.transition = DFA99_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 177:48: ( ( LT )* caseClause )*"; }
        }

    }

    const string DFA105_eotS =
        "\x06\uffff";
    const string DFA105_eofS =
        "\x06\uffff";
    const string DFA105_minS =
        "\x02\x0b\x04\uffff";
    const string DFA105_maxS =
        "\x02\x72\x04\uffff";
    const string DFA105_acceptS =
        "\x02\uffff\x03\x01\x01\x02";
    const string DFA105_specialS =
        "\x01\x00\x01\x01\x04\uffff}>";
    static readonly string[] DFA105_transitionS = {
            "\x01\x01\x04\x05\x17\uffff\x02\x05\x01\x03\x01\x05\x02\uffff"+
            "\x01\x05\x01\uffff\x02\x05\x01\uffff\x03\x05\x01\uffff\x04\x05"+
            "\x01\uffff\x01\x05\x01\x04\x01\x02\x02\x05\x02\uffff\x02\x05"+
            "\x1f\uffff\x02\x05\x03\uffff\x0b\x05",
            "\x01\x01\x04\x05\x17\uffff\x02\x05\x01\x03\x01\x05\x02\uffff"+
            "\x01\x05\x01\uffff\x02\x05\x01\uffff\x03\x05\x01\uffff\x04\x05"+
            "\x01\uffff\x01\x05\x01\x04\x01\x02\x02\x05\x02\uffff\x02\x05"+
            "\x1f\uffff\x02\x05\x03\uffff\x0b\x05",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA105_eot = DFA.UnpackEncodedString(DFA105_eotS);
    static readonly short[] DFA105_eof = DFA.UnpackEncodedString(DFA105_eofS);
    static readonly char[] DFA105_min = DFA.UnpackEncodedStringToUnsignedChars(DFA105_minS);
    static readonly char[] DFA105_max = DFA.UnpackEncodedStringToUnsignedChars(DFA105_maxS);
    static readonly short[] DFA105_accept = DFA.UnpackEncodedString(DFA105_acceptS);
    static readonly short[] DFA105_special = DFA.UnpackEncodedString(DFA105_specialS);
    static readonly short[][] DFA105_transition = DFA.UnpackEncodedStringArray(DFA105_transitionS);

    protected class DFA105 : DFA
    {
        public DFA105(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 105;
            this.eot = DFA105_eot;
            this.eof = DFA105_eof;
            this.min = DFA105_min;
            this.max = DFA105_max;
            this.accept = DFA105_accept;
            this.special = DFA105_special;
            this.transition = DFA105_transition;

        }

        override public string Description
        {
            get { return "181:50: ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )"; }
        }

    }


    protected internal int DFA105_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA105_0 = input.LA(1);

                   	 
                   	int index105_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_0 == LT) ) { s = 1; }

                   	else if ( (LA105_0 == 61) && (synpred13_JavaScript()) ) { s = 2; }

                   	else if ( (LA105_0 == 41) && (synpred13_JavaScript()) ) { s = 3; }

                   	else if ( (LA105_0 == 60) && (synpred13_JavaScript()) ) { s = 4; }

                   	else if ( ((LA105_0 >= Identifier && LA105_0 <= RegexLiteral) || (LA105_0 >= 39 && LA105_0 <= 40) || LA105_0 == 42 || LA105_0 == 45 || (LA105_0 >= 47 && LA105_0 <= 48) || (LA105_0 >= 50 && LA105_0 <= 52) || (LA105_0 >= 54 && LA105_0 <= 57) || LA105_0 == 59 || (LA105_0 >= 62 && LA105_0 <= 63) || (LA105_0 >= 66 && LA105_0 <= 67) || (LA105_0 >= 99 && LA105_0 <= 100) || (LA105_0 >= 104 && LA105_0 <= 114)) ) { s = 5; }

                   	 
                   	input.Seek(index105_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA105_1 = input.LA(1);

                   	 
                   	int index105_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_1 == 60) && (synpred13_JavaScript()) ) { s = 4; }

                   	else if ( (LA105_1 == LT) ) { s = 1; }

                   	else if ( (LA105_1 == 41) && (synpred13_JavaScript()) ) { s = 3; }

                   	else if ( ((LA105_1 >= Identifier && LA105_1 <= RegexLiteral) || (LA105_1 >= 39 && LA105_1 <= 40) || LA105_1 == 42 || LA105_1 == 45 || (LA105_1 >= 47 && LA105_1 <= 48) || (LA105_1 >= 50 && LA105_1 <= 52) || (LA105_1 >= 54 && LA105_1 <= 57) || LA105_1 == 59 || (LA105_1 >= 62 && LA105_1 <= 63) || (LA105_1 >= 66 && LA105_1 <= 67) || (LA105_1 >= 99 && LA105_1 <= 100) || (LA105_1 >= 104 && LA105_1 <= 114)) ) { s = 5; }

                   	else if ( (LA105_1 == 61) && (synpred13_JavaScript()) ) { s = 2; }

                   	 
                   	input.Seek(index105_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae105 =
            new NoViableAltException(dfa.Description, 105, _s, input);
        dfa.Error(nvae105);
        throw nvae105;
    }
    const string DFA108_eotS =
        "\x05\uffff";
    const string DFA108_eofS =
        "\x05\uffff";
    const string DFA108_minS =
        "\x02\x0b\x03\uffff";
    const string DFA108_maxS =
        "\x02\x72\x03\uffff";
    const string DFA108_acceptS =
        "\x02\uffff\x02\x01\x01\x02";
    const string DFA108_specialS =
        "\x01\x01\x01\x00\x03\uffff}>";
    static readonly string[] DFA108_transitionS = {
            "\x01\x01\x04\x04\x17\uffff\x02\x04\x01\x03\x01\x04\x02\uffff"+
            "\x01\x04\x01\uffff\x02\x04\x01\uffff\x03\x04\x01\uffff\x04\x04"+
            "\x01\uffff\x01\x04\x01\x02\x01\uffff\x02\x04\x02\uffff\x02\x04"+
            "\x1f\uffff\x02\x04\x03\uffff\x0b\x04",
            "\x01\x01\x04\x04\x17\uffff\x02\x04\x01\x03\x01\x04\x02\uffff"+
            "\x01\x04\x01\uffff\x02\x04\x01\uffff\x03\x04\x01\uffff\x04\x04"+
            "\x01\uffff\x01\x04\x01\x02\x01\uffff\x02\x04\x02\uffff\x02\x04"+
            "\x1f\uffff\x02\x04\x03\uffff\x0b\x04",
            "",
            "",
            ""
    };

    static readonly short[] DFA108_eot = DFA.UnpackEncodedString(DFA108_eotS);
    static readonly short[] DFA108_eof = DFA.UnpackEncodedString(DFA108_eofS);
    static readonly char[] DFA108_min = DFA.UnpackEncodedStringToUnsignedChars(DFA108_minS);
    static readonly char[] DFA108_max = DFA.UnpackEncodedStringToUnsignedChars(DFA108_maxS);
    static readonly short[] DFA108_accept = DFA.UnpackEncodedString(DFA108_acceptS);
    static readonly short[] DFA108_special = DFA.UnpackEncodedString(DFA108_specialS);
    static readonly short[][] DFA108_transition = DFA.UnpackEncodedStringArray(DFA108_transitionS);

    protected class DFA108 : DFA
    {
        public DFA108(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 108;
            this.eot = DFA108_eot;
            this.eof = DFA108_eof;
            this.min = DFA108_min;
            this.max = DFA108_max;
            this.accept = DFA108_accept;
            this.special = DFA108_special;
            this.transition = DFA108_transition;

        }

        override public string Description
        {
            get { return "185:40: ( ( 'case' | 'default' | '}' )=> () | ( LT )* statementList )"; }
        }

    }


    protected internal int DFA108_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA108_1 = input.LA(1);

                   	 
                   	int index108_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( ((LA108_1 >= Identifier && LA108_1 <= RegexLiteral) || (LA108_1 >= 39 && LA108_1 <= 40) || LA108_1 == 42 || LA108_1 == 45 || (LA108_1 >= 47 && LA108_1 <= 48) || (LA108_1 >= 50 && LA108_1 <= 52) || (LA108_1 >= 54 && LA108_1 <= 57) || LA108_1 == 59 || (LA108_1 >= 62 && LA108_1 <= 63) || (LA108_1 >= 66 && LA108_1 <= 67) || (LA108_1 >= 99 && LA108_1 <= 100) || (LA108_1 >= 104 && LA108_1 <= 114)) ) { s = 4; }

                   	else if ( (LA108_1 == LT) ) { s = 1; }

                   	else if ( (LA108_1 == 41) && (synpred14_JavaScript()) ) { s = 3; }

                   	else if ( (LA108_1 == 60) && (synpred14_JavaScript()) ) { s = 2; }

                   	 
                   	input.Seek(index108_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA108_0 = input.LA(1);

                   	 
                   	int index108_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA108_0 == LT) ) { s = 1; }

                   	else if ( (LA108_0 == 60) && (synpred14_JavaScript()) ) { s = 2; }

                   	else if ( (LA108_0 == 41) && (synpred14_JavaScript()) ) { s = 3; }

                   	else if ( ((LA108_0 >= Identifier && LA108_0 <= RegexLiteral) || (LA108_0 >= 39 && LA108_0 <= 40) || LA108_0 == 42 || LA108_0 == 45 || (LA108_0 >= 47 && LA108_0 <= 48) || (LA108_0 >= 50 && LA108_0 <= 52) || (LA108_0 >= 54 && LA108_0 <= 57) || LA108_0 == 59 || (LA108_0 >= 62 && LA108_0 <= 63) || (LA108_0 >= 66 && LA108_0 <= 67) || (LA108_0 >= 99 && LA108_0 <= 100) || (LA108_0 >= 104 && LA108_0 <= 114)) ) { s = 4; }

                   	 
                   	input.Seek(index108_0);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae108 =
            new NoViableAltException(dfa.Description, 108, _s, input);
        dfa.Error(nvae108);
        throw nvae108;
    }
    const string DFA112_eotS =
        "\x04\uffff";
    const string DFA112_eofS =
        "\x02\x03\x02\uffff";
    const string DFA112_minS =
        "\x02\x0b\x02\uffff";
    const string DFA112_maxS =
        "\x02\x72\x02\uffff";
    const string DFA112_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA112_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA112_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x04\x03\x02\uffff\x01\x03\x01\uffff"+
            "\x06\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x01\uffff\x01\x02"+
            "\x02\x03\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "\x01\x01\x04\x03\x17\uffff\x04\x03\x02\uffff\x01\x03\x01\uffff"+
            "\x06\x03\x01\uffff\x04\x03\x01\uffff\x05\x03\x01\uffff\x01\x02"+
            "\x02\x03\x1f\uffff\x02\x03\x03\uffff\x0b\x03",
            "",
            ""
    };

    static readonly short[] DFA112_eot = DFA.UnpackEncodedString(DFA112_eotS);
    static readonly short[] DFA112_eof = DFA.UnpackEncodedString(DFA112_eofS);
    static readonly char[] DFA112_min = DFA.UnpackEncodedStringToUnsignedChars(DFA112_minS);
    static readonly char[] DFA112_max = DFA.UnpackEncodedStringToUnsignedChars(DFA112_maxS);
    static readonly short[] DFA112_accept = DFA.UnpackEncodedString(DFA112_acceptS);
    static readonly short[] DFA112_special = DFA.UnpackEncodedString(DFA112_specialS);
    static readonly short[][] DFA112_transition = DFA.UnpackEncodedStringArray(DFA112_transitionS);

    protected class DFA112 : DFA
    {
        public DFA112(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 112;
            this.eot = DFA112_eot;
            this.eof = DFA112_eof;
            this.min = DFA112_min;
            this.max = DFA112_max;
            this.accept = DFA112_accept;
            this.special = DFA112_special;
            this.transition = DFA112_transition;

        }

        override public string Description
        {
            get { return "193:66: ( ( LT )* f= finallyClause )?"; }
        }

    }

    const string DFA124_eotS =
        "\x05\uffff";
    const string DFA124_eofS =
        "\x02\x03\x02\uffff\x01\x03";
    const string DFA124_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA124_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA124_acceptS =
        "\x02\uffff\x01\x01\x01\x02\x01\uffff";
    const string DFA124_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA124_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x04\x03\x01\x02\x02\x03\x01\uffff"+
            "\x06\x03\x01\uffff\x0a\x03\x02\uffff\x03\x03\x1e\uffff\x02\x03"+
            "\x03\uffff\x0b\x03",
            "\x01\x04\x04\x03\x17\uffff\x04\x03\x01\x02\x02\x03\x01\uffff"+
            "\x06\x03\x01\uffff\x0a\x03\x02\uffff\x03\x03\x1e\uffff\x02\x03"+
            "\x03\uffff\x0b\x03",
            "",
            "",
            "\x01\x04\x04\x03\x17\uffff\x04\x03\x01\x02\x02\x03\x01\uffff"+
            "\x06\x03\x01\uffff\x0a\x03\x02\uffff\x03\x03\x1e\uffff\x02\x03"+
            "\x03\uffff\x0b\x03"
    };

    static readonly short[] DFA124_eot = DFA.UnpackEncodedString(DFA124_eotS);
    static readonly short[] DFA124_eof = DFA.UnpackEncodedString(DFA124_eofS);
    static readonly char[] DFA124_min = DFA.UnpackEncodedStringToUnsignedChars(DFA124_minS);
    static readonly char[] DFA124_max = DFA.UnpackEncodedStringToUnsignedChars(DFA124_maxS);
    static readonly short[] DFA124_accept = DFA.UnpackEncodedString(DFA124_acceptS);
    static readonly short[] DFA124_special = DFA.UnpackEncodedString(DFA124_specialS);
    static readonly short[][] DFA124_transition = DFA.UnpackEncodedStringArray(DFA124_transitionS);

    protected class DFA124 : DFA
    {
        public DFA124(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 124;
            this.eot = DFA124_eot;
            this.eof = DFA124_eof;
            this.min = DFA124_min;
            this.max = DFA124_max;
            this.accept = DFA124_accept;
            this.special = DFA124_special;
            this.transition = DFA124_transition;

        }

        override public string Description
        {
            get { return "207:27: ( ( ( LT )* ',' ( LT )* assignmentExpression ) ( ( LT )* ',' ( LT )* assignmentExpression )* )?"; }
        }

    }

    const string DFA123_eotS =
        "\x05\uffff";
    const string DFA123_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA123_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA123_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA123_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA123_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA123_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x04\x02\x01\x03\x02\x02\x01\uffff"+
            "\x06\x02\x01\uffff\x0a\x02\x02\uffff\x03\x02\x1e\uffff\x02\x02"+
            "\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x04\x02\x01\x03\x02\x02\x01\uffff"+
            "\x06\x02\x01\uffff\x0a\x02\x02\uffff\x03\x02\x1e\uffff\x02\x02"+
            "\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x04\x02\x01\x03\x02\x02\x01\uffff"+
            "\x06\x02\x01\uffff\x0a\x02\x02\uffff\x03\x02\x1e\uffff\x02\x02"+
            "\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA123_eot = DFA.UnpackEncodedString(DFA123_eotS);
    static readonly short[] DFA123_eof = DFA.UnpackEncodedString(DFA123_eofS);
    static readonly char[] DFA123_min = DFA.UnpackEncodedStringToUnsignedChars(DFA123_minS);
    static readonly char[] DFA123_max = DFA.UnpackEncodedStringToUnsignedChars(DFA123_maxS);
    static readonly short[] DFA123_accept = DFA.UnpackEncodedString(DFA123_acceptS);
    static readonly short[] DFA123_special = DFA.UnpackEncodedString(DFA123_specialS);
    static readonly short[][] DFA123_transition = DFA.UnpackEncodedStringArray(DFA123_transitionS);

    protected class DFA123 : DFA
    {
        public DFA123(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 123;
            this.eot = DFA123_eot;
            this.eof = DFA123_eof;
            this.min = DFA123_min;
            this.max = DFA123_max;
            this.accept = DFA123_accept;
            this.special = DFA123_special;
            this.transition = DFA123_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 207:83: ( ( LT )* ',' ( LT )* assignmentExpression )*"; }
        }

    }

    const string DFA127_eotS =
        "\x18\uffff";
    const string DFA127_eofS =
        "\x18\uffff";
    const string DFA127_minS =
        "\x01\x0c\x0d\x00\x0a\uffff";
    const string DFA127_maxS =
        "\x01\x72\x0d\x00\x0a\uffff";
    const string DFA127_acceptS =
        "\x0e\uffff\x01\x02\x08\uffff\x01\x01";
    const string DFA127_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x0a\uffff}>";
    static readonly string[] DFA127_transitionS = {
            "\x01\x04\x01\x08\x01\x09\x01\x0a\x17\uffff\x01\x02\x01\x0c"+
            "\x01\uffff\x01\x0d\x17\uffff\x01\x01\x01\x0b\x1f\uffff\x02\x0e"+
            "\x03\uffff\x07\x0e\x01\x03\x01\x05\x01\x06\x01\x07",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA127_eot = DFA.UnpackEncodedString(DFA127_eotS);
    static readonly short[] DFA127_eof = DFA.UnpackEncodedString(DFA127_eofS);
    static readonly char[] DFA127_min = DFA.UnpackEncodedStringToUnsignedChars(DFA127_minS);
    static readonly char[] DFA127_max = DFA.UnpackEncodedStringToUnsignedChars(DFA127_maxS);
    static readonly short[] DFA127_accept = DFA.UnpackEncodedString(DFA127_acceptS);
    static readonly short[] DFA127_special = DFA.UnpackEncodedString(DFA127_specialS);
    static readonly short[][] DFA127_transition = DFA.UnpackEncodedStringArray(DFA127_transitionS);

    protected class DFA127 : DFA
    {
        public DFA127(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 127;
            this.eot = DFA127_eot;
            this.eof = DFA127_eof;
            this.min = DFA127_min;
            this.max = DFA127_max;
            this.accept = DFA127_accept;
            this.special = DFA127_special;
            this.transition = DFA127_transition;

        }

        override public string Description
        {
            get { return "210:1: assignmentExpression : ( ( leftHandSideExpression ( LT )* assignmentOperator )=> leftHandSideExpression ( LT )* assignmentOperator ( LT )* assignmentExpression | n= conditionalExpression );"; }
        }

    }


    protected internal int DFA127_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA127_1 = input.LA(1);

                   	 
                   	int index127_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA127_2 = input.LA(1);

                   	 
                   	int index127_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA127_3 = input.LA(1);

                   	 
                   	int index127_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA127_4 = input.LA(1);

                   	 
                   	int index127_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA127_5 = input.LA(1);

                   	 
                   	int index127_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA127_6 = input.LA(1);

                   	 
                   	int index127_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA127_7 = input.LA(1);

                   	 
                   	int index127_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA127_8 = input.LA(1);

                   	 
                   	int index127_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA127_9 = input.LA(1);

                   	 
                   	int index127_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA127_10 = input.LA(1);

                   	 
                   	int index127_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA127_11 = input.LA(1);

                   	 
                   	int index127_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA127_12 = input.LA(1);

                   	 
                   	int index127_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA127_13 = input.LA(1);

                   	 
                   	int index127_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred15_JavaScript()) ) { s = 23; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index127_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae127 =
            new NoViableAltException(dfa.Description, 127, _s, input);
        dfa.Error(nvae127);
        throw nvae127;
    }
    const string DFA130_eotS =
        "\x51\uffff";
    const string DFA130_eofS =
        "\x01\x02\x50\uffff";
    const string DFA130_minS =
        "\x01\x0b\x01\x00\x34\uffff\x02\x00\x19\uffff";
    const string DFA130_maxS =
        "\x01\x72\x01\x00\x34\uffff\x02\x00\x19\uffff";
    const string DFA130_acceptS =
        "\x02\uffff\x01\x02\x4d\uffff\x01\x01";
    const string DFA130_specialS =
        "\x01\x00\x01\x01\x34\uffff\x01\x02\x01\x03\x19\uffff}>";
    static readonly string[] DFA130_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x03\x02\x01\x37\x15\x02\x02\uffff"+
            "\x01\x02\x01\x36\x01\x02\x01\x50\x2d\x02",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA130_eot = DFA.UnpackEncodedString(DFA130_eotS);
    static readonly short[] DFA130_eof = DFA.UnpackEncodedString(DFA130_eofS);
    static readonly char[] DFA130_min = DFA.UnpackEncodedStringToUnsignedChars(DFA130_minS);
    static readonly char[] DFA130_max = DFA.UnpackEncodedStringToUnsignedChars(DFA130_maxS);
    static readonly short[] DFA130_accept = DFA.UnpackEncodedString(DFA130_acceptS);
    static readonly short[] DFA130_special = DFA.UnpackEncodedString(DFA130_specialS);
    static readonly short[][] DFA130_transition = DFA.UnpackEncodedStringArray(DFA130_transitionS);

    protected class DFA130 : DFA
    {
        public DFA130(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 130;
            this.eot = DFA130_eot;
            this.eof = DFA130_eof;
            this.min = DFA130_min;
            this.max = DFA130_max;
            this.accept = DFA130_accept;
            this.special = DFA130_special;
            this.transition = DFA130_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 219:22: ( ( ( LT )* ( '(' | '[' | '.' ) )=> ( LT )* expressionSuffix )*"; }
        }

    }


    protected internal int DFA130_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA130_0 = input.LA(1);

                   	 
                   	int index130_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA130_0 == LT) ) { s = 1; }

                   	else if ( (LA130_0 == EOF || (LA130_0 >= Identifier && LA130_0 <= RegexLiteral) || (LA130_0 >= 39 && LA130_0 <= 41) || (LA130_0 >= 43 && LA130_0 <= 63) || LA130_0 == 66 || LA130_0 == 68 || (LA130_0 >= 70 && LA130_0 <= 114)) ) { s = 2; }

                   	else if ( (LA130_0 == 67) ) { s = 54; }

                   	else if ( (LA130_0 == 42) ) { s = 55; }

                   	else if ( (LA130_0 == 69) && (synpred18_JavaScript()) ) { s = 80; }

                   	 
                   	input.Seek(index130_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA130_1 = input.LA(1);

                   	 
                   	int index130_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred18_JavaScript()) ) { s = 80; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA130_54 = input.LA(1);

                   	 
                   	int index130_54 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred18_JavaScript()) ) { s = 80; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_54);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA130_55 = input.LA(1);

                   	 
                   	int index130_55 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred18_JavaScript()) ) { s = 80; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index130_55);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae130 =
            new NoViableAltException(dfa.Description, 130, _s, input);
        dfa.Error(nvae130);
        throw nvae130;
    }
    const string DFA140_eotS =
        "\x04\uffff";
    const string DFA140_eofS =
        "\x04\uffff";
    const string DFA140_minS =
        "\x02\x0b\x02\uffff";
    const string DFA140_maxS =
        "\x02\x72\x02\uffff";
    const string DFA140_acceptS =
        "\x02\uffff\x01\x01\x01\x02";
    const string DFA140_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA140_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x01\x03\x15\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "\x01\x01\x04\x02\x17\uffff\x02\x02\x01\uffff\x01\x02\x01\uffff"+
            "\x01\x03\x15\uffff\x02\x02\x1f\uffff\x02\x02\x03\uffff\x0b\x02",
            "",
            ""
    };

    static readonly short[] DFA140_eot = DFA.UnpackEncodedString(DFA140_eotS);
    static readonly short[] DFA140_eof = DFA.UnpackEncodedString(DFA140_eofS);
    static readonly char[] DFA140_min = DFA.UnpackEncodedStringToUnsignedChars(DFA140_minS);
    static readonly char[] DFA140_max = DFA.UnpackEncodedStringToUnsignedChars(DFA140_maxS);
    static readonly short[] DFA140_accept = DFA.UnpackEncodedString(DFA140_acceptS);
    static readonly short[] DFA140_special = DFA.UnpackEncodedString(DFA140_specialS);
    static readonly short[][] DFA140_transition = DFA.UnpackEncodedStringArray(DFA140_transitionS);

    protected class DFA140 : DFA
    {
        public DFA140(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 140;
            this.eot = DFA140_eot;
            this.eof = DFA140_eof;
            this.min = DFA140_min;
            this.max = DFA140_max;
            this.accept = DFA140_accept;
            this.special = DFA140_special;
            this.transition = DFA140_transition;

        }

        override public string Description
        {
            get { return "229:19: ( ( LT )* assignmentExpression ( ( LT )* ',' ( LT )* assignmentExpression )* )?"; }
        }

    }

    const string DFA139_eotS =
        "\x04\uffff";
    const string DFA139_eofS =
        "\x04\uffff";
    const string DFA139_minS =
        "\x02\x0b\x02\uffff";
    const string DFA139_maxS =
        "\x02\x2c\x02\uffff";
    const string DFA139_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA139_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA139_transitionS = {
            "\x01\x01\x1f\uffff\x01\x03\x01\x02",
            "\x01\x01\x1f\uffff\x01\x03\x01\x02",
            "",
            ""
    };

    static readonly short[] DFA139_eot = DFA.UnpackEncodedString(DFA139_eotS);
    static readonly short[] DFA139_eof = DFA.UnpackEncodedString(DFA139_eofS);
    static readonly char[] DFA139_min = DFA.UnpackEncodedStringToUnsignedChars(DFA139_minS);
    static readonly char[] DFA139_max = DFA.UnpackEncodedStringToUnsignedChars(DFA139_maxS);
    static readonly short[] DFA139_accept = DFA.UnpackEncodedString(DFA139_acceptS);
    static readonly short[] DFA139_special = DFA.UnpackEncodedString(DFA139_specialS);
    static readonly short[][] DFA139_transition = DFA.UnpackEncodedStringArray(DFA139_transitionS);

    protected class DFA139 : DFA
    {
        public DFA139(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 139;
            this.eot = DFA139_eot;
            this.eof = DFA139_eof;
            this.min = DFA139_min;
            this.max = DFA139_max;
            this.accept = DFA139_accept;
            this.special = DFA139_special;
            this.transition = DFA139_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 229:46: ( ( LT )* ',' ( LT )* assignmentExpression )*"; }
        }

    }

    const string DFA147_eotS =
        "\x05\uffff";
    const string DFA147_eofS =
        "\x02\x03\x02\uffff\x01\x03";
    const string DFA147_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA147_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA147_acceptS =
        "\x02\uffff\x01\x01\x01\x02\x01\uffff";
    const string DFA147_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA147_transitionS = {
            "\x01\x01\x04\x03\x17\uffff\x07\x03\x01\uffff\x06\x03\x01\uffff"+
            "\x0a\x03\x02\uffff\x03\x03\x0c\uffff\x01\x02\x11\uffff\x02\x03"+
            "\x03\uffff\x0b\x03",
            "\x01\x04\x04\x03\x17\uffff\x07\x03\x01\uffff\x06\x03\x01\uffff"+
            "\x0a\x03\x02\uffff\x03\x03\x0c\uffff\x01\x02\x11\uffff\x02\x03"+
            "\x03\uffff\x0b\x03",
            "",
            "",
            "\x01\x04\x04\x03\x17\uffff\x07\x03\x01\uffff\x06\x03\x01\uffff"+
            "\x0a\x03\x02\uffff\x03\x03\x0c\uffff\x01\x02\x11\uffff\x02\x03"+
            "\x03\uffff\x0b\x03"
    };

    static readonly short[] DFA147_eot = DFA.UnpackEncodedString(DFA147_eotS);
    static readonly short[] DFA147_eof = DFA.UnpackEncodedString(DFA147_eofS);
    static readonly char[] DFA147_min = DFA.UnpackEncodedStringToUnsignedChars(DFA147_minS);
    static readonly char[] DFA147_max = DFA.UnpackEncodedStringToUnsignedChars(DFA147_maxS);
    static readonly short[] DFA147_accept = DFA.UnpackEncodedString(DFA147_acceptS);
    static readonly short[] DFA147_special = DFA.UnpackEncodedString(DFA147_specialS);
    static readonly short[][] DFA147_transition = DFA.UnpackEncodedStringArray(DFA147_transitionS);

    protected class DFA147 : DFA
    {
        public DFA147(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 147;
            this.eot = DFA147_eot;
            this.eof = DFA147_eof;
            this.min = DFA147_min;
            this.max = DFA147_max;
            this.accept = DFA147_accept;
            this.special = DFA147_special;
            this.transition = DFA147_transition;

        }

        override public string Description
        {
            get { return "248:24: ( ( LT )* '?' ( LT )* assignmentExpression ( LT )* ':' ( LT )* assignmentExpression )?"; }
        }

    }

    const string DFA150_eotS =
        "\x05\uffff";
    const string DFA150_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA150_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA150_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA150_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA150_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA150_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x01\x02\x01\x03\x10\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x01\x02\x01\x03\x10\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x01\x02\x01\x03\x10\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA150_eot = DFA.UnpackEncodedString(DFA150_eotS);
    static readonly short[] DFA150_eof = DFA.UnpackEncodedString(DFA150_eofS);
    static readonly char[] DFA150_min = DFA.UnpackEncodedStringToUnsignedChars(DFA150_minS);
    static readonly char[] DFA150_max = DFA.UnpackEncodedStringToUnsignedChars(DFA150_maxS);
    static readonly short[] DFA150_accept = DFA.UnpackEncodedString(DFA150_acceptS);
    static readonly short[] DFA150_special = DFA.UnpackEncodedString(DFA150_specialS);
    static readonly short[][] DFA150_transition = DFA.UnpackEncodedStringArray(DFA150_transitionS);

    protected class DFA150 : DFA
    {
        public DFA150(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 150;
            this.eot = DFA150_eot;
            this.eof = DFA150_eof;
            this.min = DFA150_min;
            this.max = DFA150_max;
            this.accept = DFA150_accept;
            this.special = DFA150_special;
            this.transition = DFA150_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 252:25: ( ( LT )* ( '||' ( LT )* n= logicalANDExpression ) )*"; }
        }

    }

    const string DFA153_eotS =
        "\x05\uffff";
    const string DFA153_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA153_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA153_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA153_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA153_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA153_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x02\x02\x01\x03\x0f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x02\x02\x01\x03\x0f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x02\x02\x01\x03\x0f\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA153_eot = DFA.UnpackEncodedString(DFA153_eotS);
    static readonly short[] DFA153_eof = DFA.UnpackEncodedString(DFA153_eofS);
    static readonly char[] DFA153_min = DFA.UnpackEncodedStringToUnsignedChars(DFA153_minS);
    static readonly char[] DFA153_max = DFA.UnpackEncodedStringToUnsignedChars(DFA153_maxS);
    static readonly short[] DFA153_accept = DFA.UnpackEncodedString(DFA153_acceptS);
    static readonly short[] DFA153_special = DFA.UnpackEncodedString(DFA153_specialS);
    static readonly short[][] DFA153_transition = DFA.UnpackEncodedStringArray(DFA153_transitionS);

    protected class DFA153 : DFA
    {
        public DFA153(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 153;
            this.eot = DFA153_eot;
            this.eof = DFA153_eof;
            this.min = DFA153_min;
            this.max = DFA153_max;
            this.accept = DFA153_accept;
            this.special = DFA153_special;
            this.transition = DFA153_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 256:24: ( ( LT )* ( '&&' ( LT )* bitwiseORExpression ) )*"; }
        }

    }

    const string DFA156_eotS =
        "\x05\uffff";
    const string DFA156_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA156_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA156_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA156_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA156_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA156_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x03\x02\x01\x03\x0e\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x03\x02\x01\x03\x0e\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x03\x02\x01\x03\x0e\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA156_eot = DFA.UnpackEncodedString(DFA156_eotS);
    static readonly short[] DFA156_eof = DFA.UnpackEncodedString(DFA156_eofS);
    static readonly char[] DFA156_min = DFA.UnpackEncodedStringToUnsignedChars(DFA156_minS);
    static readonly char[] DFA156_max = DFA.UnpackEncodedStringToUnsignedChars(DFA156_maxS);
    static readonly short[] DFA156_accept = DFA.UnpackEncodedString(DFA156_acceptS);
    static readonly short[] DFA156_special = DFA.UnpackEncodedString(DFA156_specialS);
    static readonly short[][] DFA156_transition = DFA.UnpackEncodedStringArray(DFA156_transitionS);

    protected class DFA156 : DFA
    {
        public DFA156(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 156;
            this.eot = DFA156_eot;
            this.eof = DFA156_eof;
            this.min = DFA156_min;
            this.max = DFA156_max;
            this.accept = DFA156_accept;
            this.special = DFA156_special;
            this.transition = DFA156_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 260:25: ( ( LT )* ( '|' ( LT )* bitwiseXORExpression ) )*"; }
        }

    }

    const string DFA159_eotS =
        "\x05\uffff";
    const string DFA159_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA159_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA159_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA159_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA159_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA159_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x04\x02\x01\x03\x0d\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x04\x02\x01\x03\x0d\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x04\x02\x01\x03\x0d\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA159_eot = DFA.UnpackEncodedString(DFA159_eotS);
    static readonly short[] DFA159_eof = DFA.UnpackEncodedString(DFA159_eofS);
    static readonly char[] DFA159_min = DFA.UnpackEncodedStringToUnsignedChars(DFA159_minS);
    static readonly char[] DFA159_max = DFA.UnpackEncodedStringToUnsignedChars(DFA159_maxS);
    static readonly short[] DFA159_accept = DFA.UnpackEncodedString(DFA159_acceptS);
    static readonly short[] DFA159_special = DFA.UnpackEncodedString(DFA159_specialS);
    static readonly short[][] DFA159_transition = DFA.UnpackEncodedStringArray(DFA159_transitionS);

    protected class DFA159 : DFA
    {
        public DFA159(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 159;
            this.eot = DFA159_eot;
            this.eof = DFA159_eof;
            this.min = DFA159_min;
            this.max = DFA159_max;
            this.accept = DFA159_accept;
            this.special = DFA159_special;
            this.transition = DFA159_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 264:25: ( ( LT )* ( '^' ( LT )* bitwiseANDExpression ) )*"; }
        }

    }

    const string DFA162_eotS =
        "\x05\uffff";
    const string DFA162_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA162_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA162_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA162_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA162_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA162_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x05\x02\x01\x03\x0c\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x05\x02\x01\x03\x0c\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x05\x02\x01\x03\x0c\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA162_eot = DFA.UnpackEncodedString(DFA162_eotS);
    static readonly short[] DFA162_eof = DFA.UnpackEncodedString(DFA162_eofS);
    static readonly char[] DFA162_min = DFA.UnpackEncodedStringToUnsignedChars(DFA162_minS);
    static readonly char[] DFA162_max = DFA.UnpackEncodedStringToUnsignedChars(DFA162_maxS);
    static readonly short[] DFA162_accept = DFA.UnpackEncodedString(DFA162_acceptS);
    static readonly short[] DFA162_special = DFA.UnpackEncodedString(DFA162_specialS);
    static readonly short[][] DFA162_transition = DFA.UnpackEncodedStringArray(DFA162_transitionS);

    protected class DFA162 : DFA
    {
        public DFA162(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 162;
            this.eot = DFA162_eot;
            this.eof = DFA162_eof;
            this.min = DFA162_min;
            this.max = DFA162_max;
            this.accept = DFA162_accept;
            this.special = DFA162_special;
            this.transition = DFA162_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 268:23: ( ( LT )* ( '&' ( LT )* equalityExpression ) )*"; }
        }

    }

    const string DFA169_eotS =
        "\x05\uffff";
    const string DFA169_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA169_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA169_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA169_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA169_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA169_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x06\x02\x04\x03\x08\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x06\x02\x04\x03\x08\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\uffff"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x06\x02\x04\x03\x08\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA169_eot = DFA.UnpackEncodedString(DFA169_eotS);
    static readonly short[] DFA169_eof = DFA.UnpackEncodedString(DFA169_eofS);
    static readonly char[] DFA169_min = DFA.UnpackEncodedStringToUnsignedChars(DFA169_minS);
    static readonly char[] DFA169_max = DFA.UnpackEncodedStringToUnsignedChars(DFA169_maxS);
    static readonly short[] DFA169_accept = DFA.UnpackEncodedString(DFA169_acceptS);
    static readonly short[] DFA169_special = DFA.UnpackEncodedString(DFA169_specialS);
    static readonly short[][] DFA169_transition = DFA.UnpackEncodedStringArray(DFA169_transitionS);

    protected class DFA169 : DFA
    {
        public DFA169(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 169;
            this.eot = DFA169_eot;
            this.eof = DFA169_eof;
            this.min = DFA169_min;
            this.max = DFA169_max;
            this.accept = DFA169_accept;
            this.special = DFA169_special;
            this.transition = DFA169_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 273:4: ( ( LT )* ( '==' ( LT )* relationalExpression | '!=' ( LT )* relationalExpression | '===' ( LT )* relationalExpression | '!==' ( LT )* relationalExpression ) )*"; }
        }

    }

    const string DFA178_eotS =
        "\x05\uffff";
    const string DFA178_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA178_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA178_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA178_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA178_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA178_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\x03"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x0a\x02\x05\x03\x03\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\x03"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x0a\x02\x05\x03\x03\uffff"+
            "\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x06\x02\x01\x03"+
            "\x0a\x02\x02\uffff\x03\x02\x0c\uffff\x0a\x02\x05\x03\x03\uffff"+
            "\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA178_eot = DFA.UnpackEncodedString(DFA178_eotS);
    static readonly short[] DFA178_eof = DFA.UnpackEncodedString(DFA178_eofS);
    static readonly char[] DFA178_min = DFA.UnpackEncodedStringToUnsignedChars(DFA178_minS);
    static readonly char[] DFA178_max = DFA.UnpackEncodedStringToUnsignedChars(DFA178_maxS);
    static readonly short[] DFA178_accept = DFA.UnpackEncodedString(DFA178_acceptS);
    static readonly short[] DFA178_special = DFA.UnpackEncodedString(DFA178_specialS);
    static readonly short[][] DFA178_transition = DFA.UnpackEncodedStringArray(DFA178_transitionS);

    protected class DFA178 : DFA
    {
        public DFA178(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 178;
            this.eot = DFA178_eot;
            this.eof = DFA178_eof;
            this.min = DFA178_min;
            this.max = DFA178_max;
            this.accept = DFA178_accept;
            this.special = DFA178_special;
            this.transition = DFA178_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 283:4: ( ( LT )* ( '<' ( LT )* shiftExpression | '>' ( LT )* shiftExpression | '<=' ( LT )* shiftExpression | '>=' ( LT )* shiftExpression | 'instanceof' ( LT )* shiftExpression | 'in' ( LT )* shiftExpression ) )*"; }
        }

    }

    const string DFA184_eotS =
        "\x05\uffff";
    const string DFA184_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA184_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA184_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA184_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA184_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA184_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x0f\x02\x03\x03\x02\x02\x03\uffff\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x0f\x02\x03\x03\x02\x02\x03\uffff\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x0f\x02\x03\x03\x02\x02\x03\uffff\x0b\x02"
    };

    static readonly short[] DFA184_eot = DFA.UnpackEncodedString(DFA184_eotS);
    static readonly short[] DFA184_eof = DFA.UnpackEncodedString(DFA184_eofS);
    static readonly char[] DFA184_min = DFA.UnpackEncodedStringToUnsignedChars(DFA184_minS);
    static readonly char[] DFA184_max = DFA.UnpackEncodedStringToUnsignedChars(DFA184_maxS);
    static readonly short[] DFA184_accept = DFA.UnpackEncodedString(DFA184_acceptS);
    static readonly short[] DFA184_special = DFA.UnpackEncodedString(DFA184_specialS);
    static readonly short[][] DFA184_transition = DFA.UnpackEncodedStringArray(DFA184_transitionS);

    protected class DFA184 : DFA
    {
        public DFA184(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 184;
            this.eot = DFA184_eot;
            this.eof = DFA184_eof;
            this.min = DFA184_min;
            this.max = DFA184_max;
            this.accept = DFA184_accept;
            this.special = DFA184_special;
            this.transition = DFA184_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 295:4: ( ( LT )* ( '<<' ( LT )* additiveExpression | '>>' ( LT )* additiveExpression | '>>>' ( LT )* additiveExpression ) )*"; }
        }

    }

    const string DFA187_eotS =
        "\x42\uffff";
    const string DFA187_eofS =
        "\x01\x04\x41\uffff";
    const string DFA187_minS =
        "\x01\x0b\x03\x00\x3e\uffff";
    const string DFA187_maxS =
        "\x01\x72\x03\x00\x3e\uffff";
    const string DFA187_acceptS =
        "\x04\uffff\x01\x02\x3c\uffff\x01\x01";
    const string DFA187_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x3e\uffff}>";
    static readonly string[] DFA187_transitionS = {
            "\x01\x01\x04\x04\x17\uffff\x07\x04\x01\uffff\x11\x04\x02\uffff"+
            "\x03\x04\x0c\uffff\x12\x04\x01\x02\x01\x03\x03\uffff\x0b\x04",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA187_eot = DFA.UnpackEncodedString(DFA187_eotS);
    static readonly short[] DFA187_eof = DFA.UnpackEncodedString(DFA187_eofS);
    static readonly char[] DFA187_min = DFA.UnpackEncodedStringToUnsignedChars(DFA187_minS);
    static readonly char[] DFA187_max = DFA.UnpackEncodedStringToUnsignedChars(DFA187_maxS);
    static readonly short[] DFA187_accept = DFA.UnpackEncodedString(DFA187_acceptS);
    static readonly short[] DFA187_special = DFA.UnpackEncodedString(DFA187_specialS);
    static readonly short[][] DFA187_transition = DFA.UnpackEncodedStringArray(DFA187_transitionS);

    protected class DFA187 : DFA
    {
        public DFA187(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 187;
            this.eot = DFA187_eot;
            this.eof = DFA187_eof;
            this.min = DFA187_min;
            this.max = DFA187_max;
            this.accept = DFA187_accept;
            this.special = DFA187_special;
            this.transition = DFA187_transition;

        }

        override public string Description
        {
            get { return "303:29: ( ( ( LT )* ( '+' | '-' ) additiveExpression )=> ( LT )* ( '+' | '-' ) additiveExpression | )"; }
        }

    }


    protected internal int DFA187_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA187_1 = input.LA(1);

                   	 
                   	int index187_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred21_JavaScript()) ) { s = 65; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index187_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA187_2 = input.LA(1);

                   	 
                   	int index187_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred21_JavaScript()) ) { s = 65; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index187_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA187_3 = input.LA(1);

                   	 
                   	int index187_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred21_JavaScript()) ) { s = 65; }

                   	else if ( (true) ) { s = 4; }

                   	 
                   	input.Seek(index187_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae187 =
            new NoViableAltException(dfa.Description, 187, _s, input);
        dfa.Error(nvae187);
        throw nvae187;
    }
    const string DFA191_eotS =
        "\x05\uffff";
    const string DFA191_eofS =
        "\x02\x02\x02\uffff\x01\x02";
    const string DFA191_minS =
        "\x02\x0b\x02\uffff\x01\x0b";
    const string DFA191_maxS =
        "\x02\x72\x02\uffff\x01\x72";
    const string DFA191_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\uffff";
    const string DFA191_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA191_transitionS = {
            "\x01\x01\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x14\x02\x03\x03\x0b\x02",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x14\x02\x03\x03\x0b\x02",
            "",
            "",
            "\x01\x04\x04\x02\x17\uffff\x07\x02\x01\uffff\x11\x02\x02\uffff"+
            "\x03\x02\x0c\uffff\x14\x02\x03\x03\x0b\x02"
    };

    static readonly short[] DFA191_eot = DFA.UnpackEncodedString(DFA191_eotS);
    static readonly short[] DFA191_eof = DFA.UnpackEncodedString(DFA191_eofS);
    static readonly char[] DFA191_min = DFA.UnpackEncodedStringToUnsignedChars(DFA191_minS);
    static readonly char[] DFA191_max = DFA.UnpackEncodedStringToUnsignedChars(DFA191_maxS);
    static readonly short[] DFA191_accept = DFA.UnpackEncodedString(DFA191_acceptS);
    static readonly short[] DFA191_special = DFA.UnpackEncodedString(DFA191_specialS);
    static readonly short[][] DFA191_transition = DFA.UnpackEncodedStringArray(DFA191_transitionS);

    protected class DFA191 : DFA
    {
        public DFA191(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 191;
            this.eot = DFA191_eot;
            this.eof = DFA191_eof;
            this.min = DFA191_min;
            this.max = DFA191_max;
            this.accept = DFA191_accept;
            this.special = DFA191_special;
            this.transition = DFA191_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 310:20: ( ( LT )* ( ( '*' | '/' | '%' ) ( LT )* unaryExpression ) )*"; }
        }

    }

    const string DFA199_eotS =
        "\x0b\uffff";
    const string DFA199_eofS =
        "\x0b\uffff";
    const string DFA199_minS =
        "\x01\x0c\x0a\uffff";
    const string DFA199_maxS =
        "\x01\x72\x0a\uffff";
    const string DFA199_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a";
    const string DFA199_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA199_transitionS = {
            "\x04\x01\x17\uffff\x02\x01\x01\uffff\x01\x01\x17\uffff\x02"+
            "\x01\x1f\uffff\x01\x07\x01\x08\x03\uffff\x01\x02\x01\x03\x01"+
            "\x04\x01\x05\x01\x06\x01\x09\x01\x0a\x04\x01",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA199_eot = DFA.UnpackEncodedString(DFA199_eotS);
    static readonly short[] DFA199_eof = DFA.UnpackEncodedString(DFA199_eofS);
    static readonly char[] DFA199_min = DFA.UnpackEncodedStringToUnsignedChars(DFA199_minS);
    static readonly char[] DFA199_max = DFA.UnpackEncodedStringToUnsignedChars(DFA199_maxS);
    static readonly short[] DFA199_accept = DFA.UnpackEncodedString(DFA199_acceptS);
    static readonly short[] DFA199_special = DFA.UnpackEncodedString(DFA199_specialS);
    static readonly short[][] DFA199_transition = DFA.UnpackEncodedStringArray(DFA199_transitionS);

    protected class DFA199 : DFA
    {
        public DFA199(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 199;
            this.eot = DFA199_eot;
            this.eof = DFA199_eof;
            this.min = DFA199_min;
            this.max = DFA199_max;
            this.accept = DFA199_accept;
            this.special = DFA199_special;
            this.transition = DFA199_transition;

        }

        override public string Description
        {
            get { return "313:1: unaryExpression : ( postfixExpression | 'delete' ( LT )* unaryExpression | 'void' ( LT )* unaryExpression | 'typeof' ( LT )* unaryExpression | '++' unaryExpression | '--' unaryExpression | '+' ( LT )* unaryExpression | '-' ( LT )* unaryExpression | '~' ( LT )* unaryExpression | '!' ( LT )* unaryExpression );"; }
        }

    }

    const string DFA200_eotS =
        "\x44\uffff";
    const string DFA200_eofS =
        "\x01\x03\x43\uffff";
    const string DFA200_minS =
        "\x01\x0b\x43\uffff";
    const string DFA200_maxS =
        "\x01\x72\x43\uffff";
    const string DFA200_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x40\uffff";
    const string DFA200_specialS =
        "\x44\uffff}>";
    static readonly string[] DFA200_transitionS = {
            "\x05\x03\x17\uffff\x07\x03\x01\uffff\x11\x03\x02\uffff\x03"+
            "\x03\x0c\uffff\x1a\x03\x01\x01\x01\x02\x06\x03",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA200_eot = DFA.UnpackEncodedString(DFA200_eotS);
    static readonly short[] DFA200_eof = DFA.UnpackEncodedString(DFA200_eofS);
    static readonly char[] DFA200_min = DFA.UnpackEncodedStringToUnsignedChars(DFA200_minS);
    static readonly char[] DFA200_max = DFA.UnpackEncodedStringToUnsignedChars(DFA200_maxS);
    static readonly short[] DFA200_accept = DFA.UnpackEncodedString(DFA200_acceptS);
    static readonly short[] DFA200_special = DFA.UnpackEncodedString(DFA200_specialS);
    static readonly short[][] DFA200_transition = DFA.UnpackEncodedStringArray(DFA200_transitionS);

    protected class DFA200 : DFA
    {
        public DFA200(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 200;
            this.eot = DFA200_eot;
            this.eof = DFA200_eof;
            this.min = DFA200_min;
            this.max = DFA200_max;
            this.accept = DFA200_accept;
            this.special = DFA200_special;
            this.transition = DFA200_transition;

        }

        override public string Description
        {
            get { return "327:29: ( '++' | '--' )?"; }
        }

    }

    const string DFA209_eotS =
        "\x06\uffff";
    const string DFA209_eofS =
        "\x06\uffff";
    const string DFA209_minS =
        "\x03\x0b\x01\uffff\x01\x0b\x01\uffff";
    const string DFA209_maxS =
        "\x01\x2b\x01\x29\x01\x2b\x01\uffff\x01\x29\x01\uffff";
    const string DFA209_acceptS =
        "\x03\uffff\x01\x02\x01\uffff\x01\x01";
    const string DFA209_specialS =
        "\x06\uffff}>";
    static readonly string[] DFA209_transitionS = {
            "\x01\x02\x1d\uffff\x01\x03\x01\uffff\x01\x01",
            "\x01\x04\x03\x05\x1a\uffff\x01\x03",
            "\x01\x02\x1d\uffff\x01\x03\x01\uffff\x01\x05",
            "",
            "\x01\x04\x03\x05\x1a\uffff\x01\x03",
            ""
    };

    static readonly short[] DFA209_eot = DFA.UnpackEncodedString(DFA209_eotS);
    static readonly short[] DFA209_eof = DFA.UnpackEncodedString(DFA209_eofS);
    static readonly char[] DFA209_min = DFA.UnpackEncodedStringToUnsignedChars(DFA209_minS);
    static readonly char[] DFA209_max = DFA.UnpackEncodedStringToUnsignedChars(DFA209_maxS);
    static readonly short[] DFA209_accept = DFA.UnpackEncodedString(DFA209_acceptS);
    static readonly short[] DFA209_special = DFA.UnpackEncodedString(DFA209_specialS);
    static readonly short[][] DFA209_transition = DFA.UnpackEncodedStringArray(DFA209_transitionS);

    protected class DFA209 : DFA
    {
        public DFA209(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 209;
            this.eot = DFA209_eot;
            this.eof = DFA209_eof;
            this.min = DFA209_min;
            this.max = DFA209_max;
            this.accept = DFA209_accept;
            this.special = DFA209_special;
            this.transition = DFA209_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 350:51: ( ( LT )* ',' ( LT )* propertyNameAndValue )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_LT_in_program67 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_sourceElements_in_program72 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_program74 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_EOF_in_program83 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_sourceElements96 = new BitSet(new ulong[]{0xCBDDA5800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_sourceElements99 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_sourceElements102 = new BitSet(new ulong[]{0xCBDDA5800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_39_in_functionDeclaration129 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration131 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDeclaration134 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration136 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionDeclaration139 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration141 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_40_in_functionDeclaration144 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration159 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_functionDeclaration162 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration165 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_functionDeclaration168 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionDeclaration173 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_functionDeclaration178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_functionExpression225 = new BitSet(new ulong[]{0x0000040000001800UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression227 = new BitSet(new ulong[]{0x0000040000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionExpression231 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression233 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_formalParameterList_in_functionExpression241 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression243 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_40_in_functionExpression246 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression261 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_functionExpression264 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression267 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_functionExpression270 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_functionExpression275 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_functionExpression280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_formalParameterList319 = new BitSet(new ulong[]{0x0000100000001800UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList336 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList340 = new BitSet(new ulong[]{0x0000180000000800UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList349 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_formalParameterList353 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList356 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_formalParameterList360 = new BitSet(new ulong[]{0x0000180000000800UL});
    public static readonly BitSet FOLLOW_LT_in_formalParameterList370 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_formalParameterList378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionDeclaration_in_statement404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_labelledStatement_in_statement420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statementBlock_in_statement432 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableStatement_in_statement439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_emptyStatement_in_statement445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionStatement_in_statement451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_iterationStatement_in_statement463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_continueStatement_in_statement469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStatement_in_statement475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStatement_in_statement481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_withStatement_in_statement487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_switchStatement_in_statement493 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_throwStatement_in_statement499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tryStatement_in_statement505 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_statementBlock518 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_statementBlock536 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_statementBlock545 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statementList_in_statementBlock549 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_statementBlock551 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_statementBlock558 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_statementList571 = new BitSet(new ulong[]{0xCBDDA5800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_statementList574 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_statementList577 = new BitSet(new ulong[]{0xCBDDA5800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_45_in_variableStatement604 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_variableStatement610 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_variableStatement614 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_variableStatement616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableDeclarationList630 = new BitSet(new ulong[]{0x0000080000000802UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationList633 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_variableDeclarationList637 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclarationList640 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableDeclarationList644 = new BitSet(new ulong[]{0x0000080000000802UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableDeclaration659 = new BitSet(new ulong[]{0x0000400000000802UL});
    public static readonly BitSet FOLLOW_LT_in_variableDeclaration662 = new BitSet(new ulong[]{0x0000400000000800UL});
    public static readonly BitSet FOLLOW_initialiser_in_variableDeclaration665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_initialiser693 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_initialiser696 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_initialiser700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_emptyStatement713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionStatement728 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_expressionStatement730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_statementEnd753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_statementEnd757 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_ifStatement786 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement792 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_ifStatement796 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement799 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement803 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement805 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_ifStatement809 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement812 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement816 = new BitSet(new ulong[]{0x0002000000000802UL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement833 = new BitSet(new ulong[]{0x0002000000000800UL});
    public static readonly BitSet FOLLOW_49_in_ifStatement837 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_ifStatement840 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_ifStatement844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_doWhileStatement_in_iterationStatement866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileStatement_in_iterationStatement872 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forStatement_in_iterationStatement888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forInStatement_in_iterationStatement893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_doWhileStatement905 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement911 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_doWhileStatement915 = new BitSet(new ulong[]{0x0008000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement917 = new BitSet(new ulong[]{0x0008000000000800UL});
    public static readonly BitSet FOLLOW_51_in_doWhileStatement921 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement924 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_doWhileStatement928 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement931 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_doWhileStatement935 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_doWhileStatement937 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_doWhileStatement941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_whileStatement954 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement960 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_whileStatement964 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement967 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_whileStatement971 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement973 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_whileStatement977 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_whileStatement980 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_whileStatement984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_forStatement997 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement999 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_forStatement1002 = new BitSet(new ulong[]{0x0000A5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1005 = new BitSet(new ulong[]{0x000025800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_forStatementInitialiserPart_in_forStatement1008 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1012 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_47_in_forStatement1015 = new BitSet(new ulong[]{0x000085800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1018 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_forStatement1023 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1027 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_47_in_forStatement1030 = new BitSet(new ulong[]{0x000015800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1033 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_forStatement1038 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1042 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_forStatement1045 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forStatement1047 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_forStatement1050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_forStatementInitialiserPart1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_forStatementInitialiserPart1130 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_forStatementInitialiserPart1136 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_forStatementInitialiserPart1140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_forInStatement1152 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1158 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_forInStatement1162 = new BitSet(new ulong[]{0x000025800000F800UL,0x000780000000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1165 = new BitSet(new ulong[]{0x000025800000F800UL,0x000780000000000CUL});
    public static readonly BitSet FOLLOW_forInStatementInitialiserPart_in_forInStatement1169 = new BitSet(new ulong[]{0x0020000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1171 = new BitSet(new ulong[]{0x0020000000000800UL});
    public static readonly BitSet FOLLOW_53_in_forInStatement1175 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1178 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_forInStatement1182 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1184 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_forInStatement1188 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_forInStatement1191 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_forInStatement1195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_forInStatementInitialiserPart1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_forInStatementInitialiserPart1213 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_forInStatementInitialiserPart1215 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_forInStatementInitialiserPart1219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_continueStatement1231 = new BitSet(new ulong[]{0x0000800000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_continueStatement1244 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_continueStatement1251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_breakStatement1264 = new BitSet(new ulong[]{0x0000800000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_breakStatement1277 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_breakStatement1284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_returnStatement1297 = new BitSet(new ulong[]{0x000085800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_returnStatement1314 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_returnStatement1317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_withStatement1331 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement1337 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_withStatement1341 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_withStatement1344 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_withStatement1348 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_withStatement1350 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_withStatement1354 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_withStatement1357 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_withStatement1361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_labelledStatement1373 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_labelledStatement1375 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_labelledStatement1378 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_labelledStatement1380 = new BitSet(new ulong[]{0xCBDDA5800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statement_in_labelledStatement1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_switchStatement1404 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement1410 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_switchStatement1414 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement1417 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_switchStatement1421 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement1423 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_switchStatement1427 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_switchStatement1430 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_caseBlock_in_switchStatement1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_caseBlock1447 = new BitSet(new ulong[]{0x3000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1451 = new BitSet(new ulong[]{0x1000000000000800UL});
    public static readonly BitSet FOLLOW_caseClause_in_caseBlock1455 = new BitSet(new ulong[]{0x3000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1460 = new BitSet(new ulong[]{0x2000000000000800UL});
    public static readonly BitSet FOLLOW_defaultClause_in_caseBlock1464 = new BitSet(new ulong[]{0x1000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1467 = new BitSet(new ulong[]{0x1000000000000800UL});
    public static readonly BitSet FOLLOW_caseClause_in_caseBlock1471 = new BitSet(new ulong[]{0x1000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_caseBlock1477 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_caseBlock1481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_caseClause1493 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1499 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_caseClause1503 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1505 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_caseClause1509 = new BitSet(new ulong[]{0xCBDDA7800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_caseClause1525 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statementList_in_caseClause1529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_defaultClause1542 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_defaultClause1548 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_defaultClause1552 = new BitSet(new ulong[]{0xCBDDA7800000F802UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_defaultClause1568 = new BitSet(new ulong[]{0xCBDDA7800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_statementList_in_defaultClause1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_throwStatement1585 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_throwStatement1591 = new BitSet(new ulong[]{0x0000800000000800UL});
    public static readonly BitSet FOLLOW_statementEnd_in_throwStatement1593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_tryStatement1606 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1608 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_statementBlock_in_tryStatement1611 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1613 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000000003UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement1619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_catchClause_in_tryStatement1625 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_tryStatement1628 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_finallyClause_in_tryStatement1633 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_catchClause1689 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1692 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_catchClause1696 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1699 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_catchClause1703 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1705 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_catchClause1709 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_catchClause1712 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_statementBlock_in_catchClause1716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_finallyClause1729 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_LT_in_finallyClause1732 = new BitSet(new ulong[]{0x0000010000000800UL});
    public static readonly BitSet FOLLOW_statementBlock_in_finallyClause1736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression1751 = new BitSet(new ulong[]{0x0000080000000802UL});
    public static readonly BitSet FOLLOW_LT_in_expression1755 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_expression1759 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_expression1765 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression1769 = new BitSet(new ulong[]{0x0000080000000802UL});
    public static readonly BitSet FOLLOW_LT_in_expression1773 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_expression1777 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_expression1780 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_expression1784 = new BitSet(new ulong[]{0x0000080000000802UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_assignmentExpression1814 = new BitSet(new ulong[]{0x0000400000000800UL,0x000000000001FFC0UL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpression1816 = new BitSet(new ulong[]{0x0000400000000800UL,0x000000000001FFC0UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_assignmentExpression1820 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_assignmentExpression1823 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_assignmentExpression1827 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_assignmentExpression1835 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_leftHandSideExpression1853 = new BitSet(new ulong[]{0x000005800000F800UL,0x000780000000000CUL});
    public static readonly BitSet FOLLOW_LT_in_leftHandSideExpression1859 = new BitSet(new ulong[]{0x000005800000F800UL,0x000780000000000CUL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_leftHandSideExpression1863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionExpression_in_leftHandSideExpression1874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primaryExpression_in_leftHandSideExpression1879 = new BitSet(new ulong[]{0x0000040000000802UL,0x0000000000000028UL});
    public static readonly BitSet FOLLOW_LT_in_leftHandSideExpression1901 = new BitSet(new ulong[]{0x0000040000000800UL,0x0000000000000028UL});
    public static readonly BitSet FOLLOW_expressionSuffix_in_leftHandSideExpression1905 = new BitSet(new ulong[]{0x0000040000000802UL,0x0000000000000028UL});
    public static readonly BitSet FOLLOW_arguments_in_expressionSuffix1925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_expressionSuffix1947 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_expressionSuffix1949 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_expressionSuffix1952 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_LT_in_expressionSuffix1954 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_expressionSuffix1957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_69_in_expressionSuffix1973 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_expressionSuffix1975 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_expressionSuffix1978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_arguments2001 = new BitSet(new ulong[]{0x000015800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_arguments2008 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments2012 = new BitSet(new ulong[]{0x0000180000000800UL});
    public static readonly BitSet FOLLOW_LT_in_arguments2015 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_arguments2019 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_arguments2022 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_arguments2026 = new BitSet(new ulong[]{0x0000180000000800UL});
    public static readonly BitSet FOLLOW_LT_in_arguments2032 = new BitSet(new ulong[]{0x0000100000000800UL});
    public static readonly BitSet FOLLOW_44_in_arguments2036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_assignmentOperator2050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_70_in_assignmentOperator2061 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_71_in_assignmentOperator2071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_72_in_assignmentOperator2081 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_assignmentOperator2091 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_assignmentOperator2101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_75_in_assignmentOperator2111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_assignmentOperator2121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_assignmentOperator2131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_assignmentOperator2141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_assignmentOperator2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_assignmentOperator2161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalORExpression_in_conditionalExpression2177 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression2180 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000020000UL});
    public static readonly BitSet FOLLOW_81_in_conditionalExpression2184 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression2190 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression2194 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression2196 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_conditionalExpression2200 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_conditionalExpression2203 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_conditionalExpression2207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression2221 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpression2224 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_logicalORExpression2230 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_logicalORExpression2236 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_logicalANDExpression_in_logicalORExpression2242 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression2258 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpression2261 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_83_in_logicalANDExpression2267 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_logicalANDExpression2273 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_bitwiseORExpression_in_logicalANDExpression2277 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression2293 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpression2296 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_84_in_bitwiseORExpression2302 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseORExpression2308 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_bitwiseXORExpression_in_bitwiseORExpression2312 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000100000UL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression2328 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpression2331 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_bitwiseXORExpression2337 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseXORExpression2343 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_bitwiseANDExpression_in_bitwiseXORExpression2347 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression2364 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpression2367 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_bitwiseANDExpression2373 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_bitwiseANDExpression2379 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_equalityExpression_in_bitwiseANDExpression2383 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression2399 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression2406 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_87_in_equalityExpression2417 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression2423 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression2427 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_88_in_equalityExpression2435 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression2441 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression2445 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_89_in_equalityExpression2453 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression2459 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression2463 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_90_in_equalityExpression2471 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_equalityExpression2477 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression2481 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000007800000UL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2501 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2509 = new BitSet(new ulong[]{0x0020000000000800UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_91_in_relationalExpression2520 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2526 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2530 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_92_in_relationalExpression2538 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2544 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2548 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_93_in_relationalExpression2556 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2562 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2566 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_94_in_relationalExpression2574 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2580 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2584 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_95_in_relationalExpression2592 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2598 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2602 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_53_in_relationalExpression2610 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_relationalExpression2616 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_shiftExpression_in_relationalExpression2620 = new BitSet(new ulong[]{0x0020000000000802UL,0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2640 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000700000000UL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2648 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000000700000000UL});
    public static readonly BitSet FOLLOW_96_in_shiftExpression2659 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2665 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2669 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000700000000UL});
    public static readonly BitSet FOLLOW_97_in_shiftExpression2677 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2683 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2687 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000700000000UL});
    public static readonly BitSet FOLLOW_98_in_shiftExpression2695 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_shiftExpression2701 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_shiftExpression2705 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000000700000000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression2725 = new BitSet(new ulong[]{0x0000000000000802UL,0x0000001800000000UL});
    public static readonly BitSet FOLLOW_LT_in_additiveExpression2747 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000001800000000UL});
    public static readonly BitSet FOLLOW_99_in_additiveExpression2752 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_100_in_additiveExpression2760 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_additiveExpression2767 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression2787 = new BitSet(new ulong[]{0x0000000000000802UL,0x000000E000000000UL});
    public static readonly BitSet FOLLOW_LT_in_multiplicativeExpression2790 = new BitSet(new ulong[]{0x0000000000000800UL,0x000000E000000000UL});
    public static readonly BitSet FOLLOW_101_in_multiplicativeExpression2795 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_102_in_multiplicativeExpression2803 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_103_in_multiplicativeExpression2811 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_multiplicativeExpression2818 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression2822 = new BitSet(new ulong[]{0x0000000000000802UL,0x000000E000000000UL});
    public static readonly BitSet FOLLOW_postfixExpression_in_unaryExpression2837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_104_in_unaryExpression2843 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2849 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_105_in_unaryExpression2859 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2865 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_106_in_unaryExpression2875 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2881 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2885 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_107_in_unaryExpression2891 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2897 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_108_in_unaryExpression2903 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2909 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_99_in_unaryExpression2915 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2921 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_100_in_unaryExpression2931 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2937 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_109_in_unaryExpression2947 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2953 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2957 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_110_in_unaryExpression2963 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_unaryExpression2969 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression2973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_postfixExpression2988 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000180000000000UL});
    public static readonly BitSet FOLLOW_107_in_postfixExpression2991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_108_in_postfixExpression2999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_111_in_primaryExpression3017 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_primaryExpression3026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primaryExpression3034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_arrayLiteral_in_primaryExpression3040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectLiteral_in_primaryExpression3046 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_primaryExpression3052 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_expression_in_primaryExpression3055 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_primaryExpression3057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_arrayLiteral3070 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000001CUL});
    public static readonly BitSet FOLLOW_LT_in_arrayLiteral3076 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000001CUL});
    public static readonly BitSet FOLLOW_elision_in_arrayLiteral3082 = new BitSet(new ulong[]{0x0000080000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_43_in_arrayLiteral3085 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_elision_in_arrayLiteral3087 = new BitSet(new ulong[]{0x0000080000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_43_in_arrayLiteral3091 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_arrayLiteral3097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_elision3117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_objectLiteral3140 = new BitSet(new ulong[]{0x0000020000007800UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral3146 = new BitSet(new ulong[]{0x0000020000007800UL});
    public static readonly BitSet FOLLOW_propertyNameAndValue_in_objectLiteral3151 = new BitSet(new ulong[]{0x00000A0000000800UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral3154 = new BitSet(new ulong[]{0x0000080000000800UL});
    public static readonly BitSet FOLLOW_43_in_objectLiteral3158 = new BitSet(new ulong[]{0x0000000000007800UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral3161 = new BitSet(new ulong[]{0x0000000000007800UL});
    public static readonly BitSet FOLLOW_propertyNameAndValue_in_objectLiteral3165 = new BitSet(new ulong[]{0x00000A0000000800UL});
    public static readonly BitSet FOLLOW_43_in_objectLiteral3170 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_LT_in_objectLiteral3175 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_objectLiteral3181 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_propertyName_in_propertyNameAndValue3195 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_propertyNameAndValue3197 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_propertyNameAndValue3201 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_LT_in_propertyNameAndValue3204 = new BitSet(new ulong[]{0x000005800000F800UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_assignmentExpression_in_propertyNameAndValue3208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_propertyName3219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_propertyName3225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NumericLiteral_in_propertyName3238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_112_in_literal3258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_113_in_literal3266 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_114_in_literal3274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringLiteral_in_literal3282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NumericLiteral_in_literal3295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RegexLiteral_in_literal3308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred1_JavaScript148 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_synpred1_JavaScript151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred2_JavaScript250 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_synpred2_JavaScript253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_synpred3_JavaScript394 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_LT_in_synpred3_JavaScript396 = new BitSet(new ulong[]{0x0000000000001800UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred3_JavaScript399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred4_JavaScript410 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_LT_in_synpred4_JavaScript412 = new BitSet(new ulong[]{0x0400000000000800UL});
    public static readonly BitSet FOLLOW_58_in_synpred4_JavaScript415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_synpred5_JavaScript427 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred6_JavaScript528 = new BitSet(new ulong[]{0x0000020000000800UL});
    public static readonly BitSet FOLLOW_41_in_synpred6_JavaScript531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred7_JavaScript761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred8_JavaScript825 = new BitSet(new ulong[]{0x0002000000000800UL});
    public static readonly BitSet FOLLOW_49_in_synpred8_JavaScript828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_synpred9_JavaScript878 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_LT_in_synpred9_JavaScript880 = new BitSet(new ulong[]{0x0000040000000800UL});
    public static readonly BitSet FOLLOW_42_in_synpred9_JavaScript883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred10_JavaScript1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_synpred11_JavaScript1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statementEnd_in_synpred12_JavaScript1305 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred13_JavaScript1513 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred14_JavaScript1556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_leftHandSideExpression_in_synpred15_JavaScript1801 = new BitSet(new ulong[]{0x0000400000000800UL,0x000000000001FFC0UL});
    public static readonly BitSet FOLLOW_LT_in_synpred15_JavaScript1803 = new BitSet(new ulong[]{0x0000400000000800UL,0x000000000001FFC0UL});
    public static readonly BitSet FOLLOW_assignmentOperator_in_synpred15_JavaScript1806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_synpred16_JavaScript1848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_synpred17_JavaScript1869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred18_JavaScript1883 = new BitSet(new ulong[]{0x0000040000000800UL,0x0000000000000028UL});
    public static readonly BitSet FOLLOW_set_in_synpred18_JavaScript1886 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_synpred19_JavaScript1920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_synpred20_JavaScript1942 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LT_in_synpred21_JavaScript2732 = new BitSet(new ulong[]{0x0000000000000800UL,0x0000001800000000UL});
    public static readonly BitSet FOLLOW_set_in_synpred21_JavaScript2735 = new BitSet(new ulong[]{0x000005800000F000UL,0x0007FF180000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_synpred21_JavaScript2741 = new BitSet(new ulong[]{0x0000000000000002UL});

}
