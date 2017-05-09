//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.1 Language\\Group.g3 2013-06-14 09:39:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace Antlr3.ST.Language
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5.0.1")]
[System.CLSCompliant(false)]
public partial class GroupLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int ANONYMOUS_TEMPLATE=4;
	public const int ASSIGN=5;
	public const int AT=6;
	public const int BIGSTRING=7;
	public const int COLON=8;
	public const int COMMA=9;
	public const int DEFINED_TO_BE=10;
	public const int DOT=11;
	public const int ID=12;
	public const int KWDEFAULT=13;
	public const int KWGROUP=14;
	public const int KWIMPLEMENTS=15;
	public const int LBRACK=16;
	public const int LPAREN=17;
	public const int ML_COMMENT=18;
	public const int OPTIONAL=19;
	public const int PLUS=20;
	public const int RBRACK=21;
	public const int RPAREN=22;
	public const int SEMI=23;
	public const int SL_COMMENT=24;
	public const int STAR=25;
	public const int STRING=26;
	public const int WS=27;

	// delegates
	// delegators

	public GroupLexer()
	{
		OnCreated();
	}

	public GroupLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public GroupLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "Language\\Group.g3"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_KWDEFAULT();
	partial void LeaveRule_KWDEFAULT();

	// $ANTLR start "KWDEFAULT"
	[GrammarRule("KWDEFAULT")]
	private void mKWDEFAULT()
	{
		EnterRule_KWDEFAULT();
		EnterRule("KWDEFAULT", 1);
		TraceIn("KWDEFAULT", 1);
		try
		{
			int _type = KWDEFAULT;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:9:11: ( 'default' )
			DebugEnterAlt(1);
			// Language\\Group.g3:9:13: 'default'
			{
			DebugLocation(9, 13);
			Match("default"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KWDEFAULT", 1);
			LeaveRule("KWDEFAULT", 1);
			LeaveRule_KWDEFAULT();
		}
	}
	// $ANTLR end "KWDEFAULT"

	partial void EnterRule_KWGROUP();
	partial void LeaveRule_KWGROUP();

	// $ANTLR start "KWGROUP"
	[GrammarRule("KWGROUP")]
	private void mKWGROUP()
	{
		EnterRule_KWGROUP();
		EnterRule("KWGROUP", 2);
		TraceIn("KWGROUP", 2);
		try
		{
			int _type = KWGROUP;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:10:9: ( 'group' )
			DebugEnterAlt(1);
			// Language\\Group.g3:10:11: 'group'
			{
			DebugLocation(10, 11);
			Match("group"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KWGROUP", 2);
			LeaveRule("KWGROUP", 2);
			LeaveRule_KWGROUP();
		}
	}
	// $ANTLR end "KWGROUP"

	partial void EnterRule_KWIMPLEMENTS();
	partial void LeaveRule_KWIMPLEMENTS();

	// $ANTLR start "KWIMPLEMENTS"
	[GrammarRule("KWIMPLEMENTS")]
	private void mKWIMPLEMENTS()
	{
		EnterRule_KWIMPLEMENTS();
		EnterRule("KWIMPLEMENTS", 3);
		TraceIn("KWIMPLEMENTS", 3);
		try
		{
			int _type = KWIMPLEMENTS;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:11:14: ( 'implements' )
			DebugEnterAlt(1);
			// Language\\Group.g3:11:16: 'implements'
			{
			DebugLocation(11, 16);
			Match("implements"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("KWIMPLEMENTS", 3);
			LeaveRule("KWIMPLEMENTS", 3);
			LeaveRule_KWIMPLEMENTS();
		}
	}
	// $ANTLR end "KWIMPLEMENTS"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 4);
		TraceIn("ID", 4);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:215:2: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '-' | '_' )* )
			DebugEnterAlt(1);
			// Language\\Group.g3:215:4: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '-' | '_' )*
			{
			DebugLocation(215, 4);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(215, 28);
			// Language\\Group.g3:215:28: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '-' | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if ((LA1_1=='-'||(LA1_1>='0' && LA1_1<='9')||(LA1_1>='A' && LA1_1<='Z')||LA1_1=='_'||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:
					{
					DebugLocation(215, 28);
					input.Consume();


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 4);
			LeaveRule("ID", 4);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_STRING();
	partial void LeaveRule_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		EnterRule_STRING();
		EnterRule("STRING", 5);
		TraceIn("STRING", 5);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			int ch = 0;


				System.Text.StringBuilder builder = new System.Text.StringBuilder();

			// Language\\Group.g3:223:2: ( '\"' ( '\\\\' ( '\"' |ch=~ '\"' ) |ch=~ ( '\\\\' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// Language\\Group.g3:223:4: '\"' ( '\\\\' ( '\"' |ch=~ '\"' ) |ch=~ ( '\\\\' | '\"' ) )* '\"'
			{
			DebugLocation(223, 4);
			Match('\"'); 
			DebugLocation(224, 3);
			// Language\\Group.g3:224:3: ( '\\\\' ( '\"' |ch=~ '\"' ) |ch=~ ( '\\\\' | '\"' ) )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1=='\\'))
				{
					alt3 = 1;
				}
				else if (((LA3_1>='\u0000' && LA3_1<='!')||(LA3_1>='#' && LA3_1<='[')||(LA3_1>=']' && LA3_1<='\uFFFF')))
				{
					alt3 = 2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:224:5: '\\\\' ( '\"' |ch=~ '\"' )
					{
					DebugLocation(224, 5);
					Match('\\'); 
					DebugLocation(225, 4);
					// Language\\Group.g3:225:4: ( '\"' |ch=~ '\"' )
					int alt2=2;
					try { DebugEnterSubRule(2);
					try { DebugEnterDecision(2, false);
					int LA2_1 = input.LA(1);

					if ((LA2_1=='\"'))
					{
						alt2 = 1;
					}
					else if (((LA2_1>='\u0000' && LA2_1<='!')||(LA2_1>='#' && LA2_1<='\uFFFF')))
					{
						alt2 = 2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(2); }
					switch (alt2)
					{
					case 1:
						DebugEnterAlt(1);
						// Language\\Group.g3:225:6: '\"'
						{
						DebugLocation(225, 6);
						Match('\"'); 
						DebugLocation(225, 11);
						builder.Append('"');

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// Language\\Group.g3:226:6: ch=~ '\"'
						{
						DebugLocation(226, 8);
						ch= input.LA(1);
						input.Consume();

						DebugLocation(226, 14);
						builder.Append("\\" + (char)ch);

						}
						break;

					}
					} finally { DebugExitSubRule(2); }


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// Language\\Group.g3:228:5: ch=~ ( '\\\\' | '\"' )
					{
					DebugLocation(228, 7);
					ch= input.LA(1);
					input.Consume();

					DebugLocation(228, 20);
					builder.Append((char)ch);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(230, 3);
			Match('\"'); 
			DebugLocation(231, 3);

						Text = builder.ToString();
					

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 5);
			LeaveRule("STRING", 5);
			LeaveRule_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void EnterRule_BIGSTRING();
	partial void LeaveRule_BIGSTRING();

	// $ANTLR start "BIGSTRING"
	[GrammarRule("BIGSTRING")]
	private void mBIGSTRING()
	{
		EnterRule_BIGSTRING();
		EnterRule("BIGSTRING", 6);
		TraceIn("BIGSTRING", 6);
		try
		{
			int _type = BIGSTRING;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:237:2: ( '<<' ( '\\\\>' | '\\\\' ~ '>' | '>' ~ '>' |~ ( '\\\\' | '>' ) )* '>>' )
			DebugEnterAlt(1);
			// Language\\Group.g3:237:4: '<<' ( '\\\\>' | '\\\\' ~ '>' | '>' ~ '>' |~ ( '\\\\' | '>' ) )* '>>'
			{
			DebugLocation(237, 4);
			Match("<<"); 

			DebugLocation(237, 9);
			// Language\\Group.g3:237:9: ( '\\\\>' | '\\\\' ~ '>' | '>' ~ '>' |~ ( '\\\\' | '>' ) )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=5;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='>'))
				{
					int LA4_2 = input.LA(2);

					if (((LA4_2>='\u0000' && LA4_2<='=')||(LA4_2>='?' && LA4_2<='\uFFFF')))
					{
						alt4 = 3;
					}


				}
				else if ((LA4_1=='\\'))
				{
					int LA4_2 = input.LA(2);

					if ((LA4_2=='>'))
					{
						alt4 = 1;
					}
					else if (((LA4_2>='\u0000' && LA4_2<='=')||(LA4_2>='?' && LA4_2<='\uFFFF')))
					{
						alt4 = 2;
					}


				}
				else if (((LA4_1>='\u0000' && LA4_1<='=')||(LA4_1>='?' && LA4_1<='[')||(LA4_1>=']' && LA4_1<='\uFFFF')))
				{
					alt4 = 4;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:237:10: '\\\\>'
					{
					DebugLocation(237, 10);
					Match("\\>"); 


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// Language\\Group.g3:237:18: '\\\\' ~ '>'
					{
					DebugLocation(237, 18);
					Match('\\'); 
					DebugLocation(237, 23);
					input.Consume();


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// Language\\Group.g3:237:30: '>' ~ '>'
					{
					DebugLocation(237, 30);
					Match('>'); 
					DebugLocation(237, 34);
					input.Consume();


					}
					break;
				case 4:
					DebugEnterAlt(4);
					// Language\\Group.g3:237:41: ~ ( '\\\\' | '>' )
					{
					DebugLocation(237, 41);
					input.Consume();


					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(237, 55);
			Match(">>"); 

			DebugLocation(238, 3);

						System.Text.StringBuilder builder = new System.Text.StringBuilder( input.Substring( state.tokenStartCharIndex + 2, CharIndex - 3 - state.tokenStartCharIndex - 2 + 1 ) );
						Text = ProcessBigString( builder );
					

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BIGSTRING", 6);
			LeaveRule("BIGSTRING", 6);
			LeaveRule_BIGSTRING();
		}
	}
	// $ANTLR end "BIGSTRING"

	partial void EnterRule_ANONYMOUS_TEMPLATE();
	partial void LeaveRule_ANONYMOUS_TEMPLATE();

	// $ANTLR start "ANONYMOUS_TEMPLATE"
	[GrammarRule("ANONYMOUS_TEMPLATE")]
	private void mANONYMOUS_TEMPLATE()
	{
		EnterRule_ANONYMOUS_TEMPLATE();
		EnterRule("ANONYMOUS_TEMPLATE", 7);
		TraceIn("ANONYMOUS_TEMPLATE", 7);
		try
		{
			int _type = ANONYMOUS_TEMPLATE;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:245:2: ( '{' ( '\\\\}' | '\\\\' ~ '}' |~ ( '\\\\' | '}' ) )* '}' )
			DebugEnterAlt(1);
			// Language\\Group.g3:245:4: '{' ( '\\\\}' | '\\\\' ~ '}' |~ ( '\\\\' | '}' ) )* '}'
			{
			DebugLocation(245, 4);
			Match('{'); 
			DebugLocation(246, 3);
			// Language\\Group.g3:246:3: ( '\\\\}' | '\\\\' ~ '}' |~ ( '\\\\' | '}' ) )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=4;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='\\'))
				{
					int LA5_2 = input.LA(2);

					if ((LA5_2=='}'))
					{
						alt5 = 1;
					}
					else if (((LA5_2>='\u0000' && LA5_2<='|')||(LA5_2>='~' && LA5_2<='\uFFFF')))
					{
						alt5 = 2;
					}


				}
				else if (((LA5_1>='\u0000' && LA5_1<='[')||(LA5_1>=']' && LA5_1<='|')||(LA5_1>='~' && LA5_1<='\uFFFF')))
				{
					alt5 = 3;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:246:5: '\\\\}'
					{
					DebugLocation(246, 5);
					Match("\\}"); 


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// Language\\Group.g3:247:5: '\\\\' ~ '}'
					{
					DebugLocation(247, 5);
					Match('\\'); 
					DebugLocation(247, 10);
					input.Consume();


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// Language\\Group.g3:248:5: ~ ( '\\\\' | '}' )
					{
					DebugLocation(248, 5);
					input.Consume();


					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(250, 3);
			Match('}'); 
			DebugLocation(251, 3);

						System.Text.StringBuilder builder = new System.Text.StringBuilder( input.Substring( state.tokenStartCharIndex + 1, CharIndex - 2 - state.tokenStartCharIndex - 1 + 1 ) );
						Text = ProcessAnonymousTemplate( builder );
					

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ANONYMOUS_TEMPLATE", 7);
			LeaveRule("ANONYMOUS_TEMPLATE", 7);
			LeaveRule_ANONYMOUS_TEMPLATE();
		}
	}
	// $ANTLR end "ANONYMOUS_TEMPLATE"

	partial void EnterRule_AT();
	partial void LeaveRule_AT();

	// $ANTLR start "AT"
	[GrammarRule("AT")]
	private void mAT()
	{
		EnterRule_AT();
		EnterRule("AT", 8);
		TraceIn("AT", 8);
		try
		{
			int _type = AT;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:257:4: ( '@' )
			DebugEnterAlt(1);
			// Language\\Group.g3:257:6: '@'
			{
			DebugLocation(257, 6);
			Match('@'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AT", 8);
			LeaveRule("AT", 8);
			LeaveRule_AT();
		}
	}
	// $ANTLR end "AT"

	partial void EnterRule_LPAREN();
	partial void LeaveRule_LPAREN();

	// $ANTLR start "LPAREN"
	[GrammarRule("LPAREN")]
	private void mLPAREN()
	{
		EnterRule_LPAREN();
		EnterRule("LPAREN", 9);
		TraceIn("LPAREN", 9);
		try
		{
			int _type = LPAREN;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:258:7: ( '(' )
			DebugEnterAlt(1);
			// Language\\Group.g3:258:9: '('
			{
			DebugLocation(258, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LPAREN", 9);
			LeaveRule("LPAREN", 9);
			LeaveRule_LPAREN();
		}
	}
	// $ANTLR end "LPAREN"

	partial void EnterRule_RPAREN();
	partial void LeaveRule_RPAREN();

	// $ANTLR start "RPAREN"
	[GrammarRule("RPAREN")]
	private void mRPAREN()
	{
		EnterRule_RPAREN();
		EnterRule("RPAREN", 10);
		TraceIn("RPAREN", 10);
		try
		{
			int _type = RPAREN;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:259:7: ( ')' )
			DebugEnterAlt(1);
			// Language\\Group.g3:259:9: ')'
			{
			DebugLocation(259, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RPAREN", 10);
			LeaveRule("RPAREN", 10);
			LeaveRule_RPAREN();
		}
	}
	// $ANTLR end "RPAREN"

	partial void EnterRule_LBRACK();
	partial void LeaveRule_LBRACK();

	// $ANTLR start "LBRACK"
	[GrammarRule("LBRACK")]
	private void mLBRACK()
	{
		EnterRule_LBRACK();
		EnterRule("LBRACK", 11);
		TraceIn("LBRACK", 11);
		try
		{
			int _type = LBRACK;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:260:7: ( '[' )
			DebugEnterAlt(1);
			// Language\\Group.g3:260:9: '['
			{
			DebugLocation(260, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LBRACK", 11);
			LeaveRule("LBRACK", 11);
			LeaveRule_LBRACK();
		}
	}
	// $ANTLR end "LBRACK"

	partial void EnterRule_RBRACK();
	partial void LeaveRule_RBRACK();

	// $ANTLR start "RBRACK"
	[GrammarRule("RBRACK")]
	private void mRBRACK()
	{
		EnterRule_RBRACK();
		EnterRule("RBRACK", 12);
		TraceIn("RBRACK", 12);
		try
		{
			int _type = RBRACK;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:261:7: ( ']' )
			DebugEnterAlt(1);
			// Language\\Group.g3:261:9: ']'
			{
			DebugLocation(261, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("RBRACK", 12);
			LeaveRule("RBRACK", 12);
			LeaveRule_RBRACK();
		}
	}
	// $ANTLR end "RBRACK"

	partial void EnterRule_COMMA();
	partial void LeaveRule_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		EnterRule_COMMA();
		EnterRule("COMMA", 13);
		TraceIn("COMMA", 13);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:262:6: ( ',' )
			DebugEnterAlt(1);
			// Language\\Group.g3:262:9: ','
			{
			DebugLocation(262, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 13);
			LeaveRule("COMMA", 13);
			LeaveRule_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void EnterRule_DOT();
	partial void LeaveRule_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		EnterRule_DOT();
		EnterRule("DOT", 14);
		TraceIn("DOT", 14);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:263:4: ( '.' )
			DebugEnterAlt(1);
			// Language\\Group.g3:263:7: '.'
			{
			DebugLocation(263, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 14);
			LeaveRule("DOT", 14);
			LeaveRule_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void EnterRule_DEFINED_TO_BE();
	partial void LeaveRule_DEFINED_TO_BE();

	// $ANTLR start "DEFINED_TO_BE"
	[GrammarRule("DEFINED_TO_BE")]
	private void mDEFINED_TO_BE()
	{
		EnterRule_DEFINED_TO_BE();
		EnterRule("DEFINED_TO_BE", 15);
		TraceIn("DEFINED_TO_BE", 15);
		try
		{
			int _type = DEFINED_TO_BE;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:264:14: ( '::=' )
			DebugEnterAlt(1);
			// Language\\Group.g3:264:17: '::='
			{
			DebugLocation(264, 17);
			Match("::="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DEFINED_TO_BE", 15);
			LeaveRule("DEFINED_TO_BE", 15);
			LeaveRule_DEFINED_TO_BE();
		}
	}
	// $ANTLR end "DEFINED_TO_BE"

	partial void EnterRule_SEMI();
	partial void LeaveRule_SEMI();

	// $ANTLR start "SEMI"
	[GrammarRule("SEMI")]
	private void mSEMI()
	{
		EnterRule_SEMI();
		EnterRule("SEMI", 16);
		TraceIn("SEMI", 16);
		try
		{
			int _type = SEMI;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:265:5: ( ';' )
			DebugEnterAlt(1);
			// Language\\Group.g3:265:9: ';'
			{
			DebugLocation(265, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SEMI", 16);
			LeaveRule("SEMI", 16);
			LeaveRule_SEMI();
		}
	}
	// $ANTLR end "SEMI"

	partial void EnterRule_COLON();
	partial void LeaveRule_COLON();

	// $ANTLR start "COLON"
	[GrammarRule("COLON")]
	private void mCOLON()
	{
		EnterRule_COLON();
		EnterRule("COLON", 17);
		TraceIn("COLON", 17);
		try
		{
			int _type = COLON;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:266:6: ( ':' )
			DebugEnterAlt(1);
			// Language\\Group.g3:266:9: ':'
			{
			DebugLocation(266, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COLON", 17);
			LeaveRule("COLON", 17);
			LeaveRule_COLON();
		}
	}
	// $ANTLR end "COLON"

	partial void EnterRule_STAR();
	partial void LeaveRule_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		EnterRule_STAR();
		EnterRule("STAR", 18);
		TraceIn("STAR", 18);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:267:5: ( '*' )
			DebugEnterAlt(1);
			// Language\\Group.g3:267:9: '*'
			{
			DebugLocation(267, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 18);
			LeaveRule("STAR", 18);
			LeaveRule_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void EnterRule_PLUS();
	partial void LeaveRule_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		EnterRule_PLUS();
		EnterRule("PLUS", 19);
		TraceIn("PLUS", 19);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:268:5: ( '+' )
			DebugEnterAlt(1);
			// Language\\Group.g3:268:9: '+'
			{
			DebugLocation(268, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 19);
			LeaveRule("PLUS", 19);
			LeaveRule_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void EnterRule_ASSIGN();
	partial void LeaveRule_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		EnterRule_ASSIGN();
		EnterRule("ASSIGN", 20);
		TraceIn("ASSIGN", 20);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:269:7: ( '=' )
			DebugEnterAlt(1);
			// Language\\Group.g3:269:11: '='
			{
			DebugLocation(269, 11);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 20);
			LeaveRule("ASSIGN", 20);
			LeaveRule_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void EnterRule_OPTIONAL();
	partial void LeaveRule_OPTIONAL();

	// $ANTLR start "OPTIONAL"
	[GrammarRule("OPTIONAL")]
	private void mOPTIONAL()
	{
		EnterRule_OPTIONAL();
		EnterRule("OPTIONAL", 21);
		TraceIn("OPTIONAL", 21);
		try
		{
			int _type = OPTIONAL;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:270:10: ( '?' )
			DebugEnterAlt(1);
			// Language\\Group.g3:270:12: '?'
			{
			DebugLocation(270, 12);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OPTIONAL", 21);
			LeaveRule("OPTIONAL", 21);
			LeaveRule_OPTIONAL();
		}
	}
	// $ANTLR end "OPTIONAL"

	partial void EnterRule_SL_COMMENT();
	partial void LeaveRule_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		EnterRule_SL_COMMENT();
		EnterRule("SL_COMMENT", 22);
		TraceIn("SL_COMMENT", 22);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:274:2: ( '//' (~ ( '\\n' | '\\r' ) )* ( ( '\\r' )? '\\n' )? )
			DebugEnterAlt(1);
			// Language\\Group.g3:274:4: '//' (~ ( '\\n' | '\\r' ) )* ( ( '\\r' )? '\\n' )?
			{
			DebugLocation(274, 4);
			Match("//"); 

			DebugLocation(275, 3);
			// Language\\Group.g3:275:3: (~ ( '\\n' | '\\r' ) )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, false);
				int LA6_1 = input.LA(1);

				if (((LA6_1>='\u0000' && LA6_1<='\t')||(LA6_1>='\u000B' && LA6_1<='\f')||(LA6_1>='\u000E' && LA6_1<='\uFFFF')))
				{
					alt6 = 1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:
					{
					DebugLocation(275, 3);
					input.Consume();


					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }

			DebugLocation(275, 19);
			// Language\\Group.g3:275:19: ( ( '\\r' )? '\\n' )?
			int alt8=2;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, false);
			int LA8_1 = input.LA(1);

			if ((LA8_1=='\n'||LA8_1=='\r'))
			{
				alt8 = 1;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// Language\\Group.g3:275:20: ( '\\r' )? '\\n'
				{
				DebugLocation(275, 20);
				// Language\\Group.g3:275:20: ( '\\r' )?
				int alt7=2;
				try { DebugEnterSubRule(7);
				try { DebugEnterDecision(7, false);
				int LA7_1 = input.LA(1);

				if ((LA7_1=='\r'))
				{
					alt7 = 1;
				}
				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:275:21: '\\r'
					{
					DebugLocation(275, 21);
					Match('\r'); 

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(275, 28);
				Match('\n'); 

				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(276, 3);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 22);
			LeaveRule("SL_COMMENT", 22);
			LeaveRule_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void EnterRule_ML_COMMENT();
	partial void LeaveRule_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		EnterRule_ML_COMMENT();
		EnterRule("ML_COMMENT", 23);
		TraceIn("ML_COMMENT", 23);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:281:2: ( '/*' ( . )* '*/' )
			DebugEnterAlt(1);
			// Language\\Group.g3:281:4: '/*' ( . )* '*/'
			{
			DebugLocation(281, 4);
			Match("/*"); 

			DebugLocation(281, 9);
			// Language\\Group.g3:281:9: ( . )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, false);
				int LA9_1 = input.LA(1);

				if ((LA9_1=='*'))
				{
					int LA9_2 = input.LA(2);

					if ((LA9_2=='/'))
					{
						alt9 = 2;
					}
					else if (((LA9_2>='\u0000' && LA9_2<='.')||(LA9_2>='0' && LA9_2<='\uFFFF')))
					{
						alt9 = 1;
					}


				}
				else if (((LA9_1>='\u0000' && LA9_1<=')')||(LA9_1>='+' && LA9_1<='\uFFFF')))
				{
					alt9 = 1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:281:9: .
					{
					DebugLocation(281, 9);
					MatchAny(); 

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(281, 12);
			Match("*/"); 

			DebugLocation(282, 3);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 23);
			LeaveRule("ML_COMMENT", 23);
			LeaveRule_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 24);
		TraceIn("WS", 24);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// Language\\Group.g3:286:5: ( ( ' ' | '\\t' | '\\f' | ( '\\r' )? '\\n' )+ )
			DebugEnterAlt(1);
			// Language\\Group.g3:286:9: ( ' ' | '\\t' | '\\f' | ( '\\r' )? '\\n' )+
			{
			DebugLocation(286, 9);
			// Language\\Group.g3:286:9: ( ' ' | '\\t' | '\\f' | ( '\\r' )? '\\n' )+
			int cnt11=0;
			try { DebugEnterSubRule(11);
			while (true)
			{
				int alt11=5;
				try { DebugEnterDecision(11, false);
				switch (input.LA(1))
				{
				case ' ':
					{
					alt11 = 1;
					}
					break;
				case '\t':
					{
					alt11 = 2;
					}
					break;
				case '\f':
					{
					alt11 = 3;
					}
					break;
				case '\n':
				case '\r':
					{
					alt11 = 4;
					}
					break;
				}

				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// Language\\Group.g3:286:13: ' '
					{
					DebugLocation(286, 13);
					Match(' '); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// Language\\Group.g3:287:13: '\\t'
					{
					DebugLocation(287, 13);
					Match('\t'); 

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// Language\\Group.g3:288:13: '\\f'
					{
					DebugLocation(288, 13);
					Match('\f'); 

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// Language\\Group.g3:289:13: ( '\\r' )? '\\n'
					{
					DebugLocation(289, 13);
					// Language\\Group.g3:289:13: ( '\\r' )?
					int alt10=2;
					try { DebugEnterSubRule(10);
					try { DebugEnterDecision(10, false);
					int LA10_1 = input.LA(1);

					if ((LA10_1=='\r'))
					{
						alt10 = 1;
					}
					} finally { DebugExitDecision(10); }
					switch (alt10)
					{
					case 1:
						DebugEnterAlt(1);
						// Language\\Group.g3:289:14: '\\r'
						{
						DebugLocation(289, 14);
						Match('\r'); 

						}
						break;

					}
					} finally { DebugExitSubRule(10); }

					DebugLocation(289, 21);
					Match('\n'); 

					}
					break;

				default:
					if (cnt11 >= 1)
						goto loop11;

					EarlyExitException eee11 = new EarlyExitException( 11, input );
					DebugRecognitionException(eee11);
					throw eee11;
				}
				cnt11++;
			}
			loop11:
				;

			} finally { DebugExitSubRule(11); }

			DebugLocation(291, 9);
			 _channel = Hidden; 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 24);
			LeaveRule("WS", 24);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// Language\\Group.g3:1:8: ( KWDEFAULT | KWGROUP | KWIMPLEMENTS | ID | STRING | BIGSTRING | ANONYMOUS_TEMPLATE | AT | LPAREN | RPAREN | LBRACK | RBRACK | COMMA | DOT | DEFINED_TO_BE | SEMI | COLON | STAR | PLUS | ASSIGN | OPTIONAL | SL_COMMENT | ML_COMMENT | WS )
		int alt12=24;
		try { DebugEnterDecision(12, false);
		switch (input.LA(1))
		{
		case 'd':
			{
			int LA12_2 = input.LA(2);

			if ((LA12_2=='e'))
			{
				int LA12_3 = input.LA(3);

				if ((LA12_3=='f'))
				{
					int LA12_4 = input.LA(4);

					if ((LA12_4=='a'))
					{
						int LA12_5 = input.LA(5);

						if ((LA12_5=='u'))
						{
							int LA12_6 = input.LA(6);

							if ((LA12_6=='l'))
							{
								int LA12_7 = input.LA(7);

								if ((LA12_7=='t'))
								{
									int LA12_8 = input.LA(8);

									if ((LA12_8=='-'||(LA12_8>='0' && LA12_8<='9')||(LA12_8>='A' && LA12_8<='Z')||LA12_8=='_'||(LA12_8>='a' && LA12_8<='z')))
									{
										alt12 = 4;
									}
									else
									{
										alt12 = 1;
									}
								}
								else
								{
									alt12 = 4;
								}
							}
							else
							{
								alt12 = 4;
							}
						}
						else
						{
							alt12 = 4;
						}
					}
					else
					{
						alt12 = 4;
					}
				}
				else
				{
					alt12 = 4;
				}
			}
			else
			{
				alt12 = 4;
			}
			}
			break;
		case 'g':
			{
			int LA12_2 = input.LA(2);

			if ((LA12_2=='r'))
			{
				int LA12_3 = input.LA(3);

				if ((LA12_3=='o'))
				{
					int LA12_4 = input.LA(4);

					if ((LA12_4=='u'))
					{
						int LA12_5 = input.LA(5);

						if ((LA12_5=='p'))
						{
							int LA12_6 = input.LA(6);

							if ((LA12_6=='-'||(LA12_6>='0' && LA12_6<='9')||(LA12_6>='A' && LA12_6<='Z')||LA12_6=='_'||(LA12_6>='a' && LA12_6<='z')))
							{
								alt12 = 4;
							}
							else
							{
								alt12 = 2;
							}
						}
						else
						{
							alt12 = 4;
						}
					}
					else
					{
						alt12 = 4;
					}
				}
				else
				{
					alt12 = 4;
				}
			}
			else
			{
				alt12 = 4;
			}
			}
			break;
		case 'i':
			{
			int LA12_2 = input.LA(2);

			if ((LA12_2=='m'))
			{
				int LA12_3 = input.LA(3);

				if ((LA12_3=='p'))
				{
					int LA12_4 = input.LA(4);

					if ((LA12_4=='l'))
					{
						int LA12_5 = input.LA(5);

						if ((LA12_5=='e'))
						{
							int LA12_6 = input.LA(6);

							if ((LA12_6=='m'))
							{
								int LA12_7 = input.LA(7);

								if ((LA12_7=='e'))
								{
									int LA12_8 = input.LA(8);

									if ((LA12_8=='n'))
									{
										int LA12_9 = input.LA(9);

										if ((LA12_9=='t'))
										{
											int LA12_10 = input.LA(10);

											if ((LA12_10=='s'))
											{
												int LA12_11 = input.LA(11);

												if ((LA12_11=='-'||(LA12_11>='0' && LA12_11<='9')||(LA12_11>='A' && LA12_11<='Z')||LA12_11=='_'||(LA12_11>='a' && LA12_11<='z')))
												{
													alt12 = 4;
												}
												else
												{
													alt12 = 3;
												}
											}
											else
											{
												alt12 = 4;
											}
										}
										else
										{
											alt12 = 4;
										}
									}
									else
									{
										alt12 = 4;
									}
								}
								else
								{
									alt12 = 4;
								}
							}
							else
							{
								alt12 = 4;
							}
						}
						else
						{
							alt12 = 4;
						}
					}
					else
					{
						alt12 = 4;
					}
				}
				else
				{
					alt12 = 4;
				}
			}
			else
			{
				alt12 = 4;
			}
			}
			break;
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'G':
		case 'H':
		case 'I':
		case 'J':
		case 'K':
		case 'L':
		case 'M':
		case 'N':
		case 'O':
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
		case 'T':
		case 'U':
		case 'V':
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
		case '_':
		case 'a':
		case 'b':
		case 'c':
		case 'e':
		case 'f':
		case 'h':
		case 'j':
		case 'k':
		case 'l':
		case 'm':
		case 'n':
		case 'o':
		case 'p':
		case 'q':
		case 'r':
		case 's':
		case 't':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
			{
			alt12 = 4;
			}
			break;
		case '\"':
			{
			alt12 = 5;
			}
			break;
		case '<':
			{
			alt12 = 6;
			}
			break;
		case '{':
			{
			alt12 = 7;
			}
			break;
		case '@':
			{
			alt12 = 8;
			}
			break;
		case '(':
			{
			alt12 = 9;
			}
			break;
		case ')':
			{
			alt12 = 10;
			}
			break;
		case '[':
			{
			alt12 = 11;
			}
			break;
		case ']':
			{
			alt12 = 12;
			}
			break;
		case ',':
			{
			alt12 = 13;
			}
			break;
		case '.':
			{
			alt12 = 14;
			}
			break;
		case ':':
			{
			int LA12_2 = input.LA(2);

			if ((LA12_2==':'))
			{
				alt12 = 15;
			}
			else
			{
				alt12 = 17;
			}
			}
			break;
		case ';':
			{
			alt12 = 16;
			}
			break;
		case '*':
			{
			alt12 = 18;
			}
			break;
		case '+':
			{
			alt12 = 19;
			}
			break;
		case '=':
			{
			alt12 = 20;
			}
			break;
		case '?':
			{
			alt12 = 21;
			}
			break;
		case '/':
			{
			int LA12_2 = input.LA(2);

			if ((LA12_2=='/'))
			{
				alt12 = 22;
			}
			else if ((LA12_2=='*'))
			{
				alt12 = 23;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 12, 21, input, 2);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			}
			break;
		case '\t':
		case '\n':
		case '\f':
		case '\r':
		case ' ':
			{
			alt12 = 24;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 12, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(12); }
		switch (alt12)
		{
		case 1:
			DebugEnterAlt(1);
			// Language\\Group.g3:1:10: KWDEFAULT
			{
			DebugLocation(1, 10);
			mKWDEFAULT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// Language\\Group.g3:1:20: KWGROUP
			{
			DebugLocation(1, 20);
			mKWGROUP(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// Language\\Group.g3:1:28: KWIMPLEMENTS
			{
			DebugLocation(1, 28);
			mKWIMPLEMENTS(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// Language\\Group.g3:1:41: ID
			{
			DebugLocation(1, 41);
			mID(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// Language\\Group.g3:1:44: STRING
			{
			DebugLocation(1, 44);
			mSTRING(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// Language\\Group.g3:1:51: BIGSTRING
			{
			DebugLocation(1, 51);
			mBIGSTRING(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// Language\\Group.g3:1:61: ANONYMOUS_TEMPLATE
			{
			DebugLocation(1, 61);
			mANONYMOUS_TEMPLATE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// Language\\Group.g3:1:80: AT
			{
			DebugLocation(1, 80);
			mAT(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// Language\\Group.g3:1:83: LPAREN
			{
			DebugLocation(1, 83);
			mLPAREN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// Language\\Group.g3:1:90: RPAREN
			{
			DebugLocation(1, 90);
			mRPAREN(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// Language\\Group.g3:1:97: LBRACK
			{
			DebugLocation(1, 97);
			mLBRACK(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// Language\\Group.g3:1:104: RBRACK
			{
			DebugLocation(1, 104);
			mRBRACK(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// Language\\Group.g3:1:111: COMMA
			{
			DebugLocation(1, 111);
			mCOMMA(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// Language\\Group.g3:1:117: DOT
			{
			DebugLocation(1, 117);
			mDOT(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// Language\\Group.g3:1:121: DEFINED_TO_BE
			{
			DebugLocation(1, 121);
			mDEFINED_TO_BE(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// Language\\Group.g3:1:135: SEMI
			{
			DebugLocation(1, 135);
			mSEMI(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// Language\\Group.g3:1:140: COLON
			{
			DebugLocation(1, 140);
			mCOLON(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// Language\\Group.g3:1:146: STAR
			{
			DebugLocation(1, 146);
			mSTAR(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// Language\\Group.g3:1:151: PLUS
			{
			DebugLocation(1, 151);
			mPLUS(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// Language\\Group.g3:1:156: ASSIGN
			{
			DebugLocation(1, 156);
			mASSIGN(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// Language\\Group.g3:1:163: OPTIONAL
			{
			DebugLocation(1, 163);
			mOPTIONAL(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// Language\\Group.g3:1:172: SL_COMMENT
			{
			DebugLocation(1, 172);
			mSL_COMMENT(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// Language\\Group.g3:1:183: ML_COMMENT
			{
			DebugLocation(1, 183);
			mML_COMMENT(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// Language\\Group.g3:1:194: WS
			{
			DebugLocation(1, 194);
			mWS(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

	#endregion

}

} // namespace Antlr3.ST.Language
