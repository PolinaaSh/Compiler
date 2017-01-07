// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-01-07 13:25:37

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
	public const int T__67=67;
	public const int T__68=68;
	public const int T__69=69;
	public const int T__70=70;
	public const int T__71=71;
	public const int T__72=72;
	public const int T__73=73;
	public const int T__74=74;
	public const int T__75=75;
	public const int T__76=76;
	public const int T__77=77;
	public const int T__78=78;
	public const int T__79=79;
	public const int T__80=80;
	public const int TRUE=4;
	public const int FALSE=5;
	public const int AND=6;
	public const int OR=7;
	public const int UNKNOWN=8;
	public const int SCOPEBLOCK=9;
	public const int BLOCK=10;
	public const int PROGRAM=11;
	public const int CONVERT=12;
	public const int INDEX=13;
	public const int IF=14;
	public const int THEN=15;
	public const int ELSE=16;
	public const int ELSIF=17;
	public const int DIV=18;
	public const int MOD=19;
	public const int FOR=20;
	public const int TO=21;
	public const int DOWNTO=22;
	public const int DO=23;
	public const int WHILE=24;
	public const int REPEAT=25;
	public const int UNTIL=26;
	public const int INT=27;
	public const int REAL=28;
	public const int CHAR=29;
	public const int BOOL=30;
	public const int CALL=31;
	public const int PARAMS=32;
	public const int VAR=33;
	public const int BEGIN=34;
	public const int END=35;
	public const int WRITE=36;
	public const int WRITELN=37;
	public const int INPUT=38;
	public const int ARRAY=39;
	public const int OF=40;
	public const int CONST_=41;
	public const int FUNC=42;
	public const int PROC=43;
	public const int WS=44;
	public const int SL_COMMENT=45;
	public const int ML_COMMENT=46;
	public const int NUMBER=47;
	public const int IDENT=48;
	public const int ADD=49;
	public const int SUB=50;
	public const int MUL=51;
	public const int DIVIDE=52;
	public const int ASSIGN=53;
	public const int GE=54;
	public const int LE=55;
	public const int NEQUALS=56;
	public const int EQUALS=57;
	public const int GT=58;
	public const int LT=59;

    // delegates
    // delegators

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_TRUE();
	partial void Leave_TRUE();

	// $ANTLR start "TRUE"
	[GrammarRule("TRUE")]
	private void mTRUE()
	{
		Enter_TRUE();
		EnterRule("TRUE", 1);
		TraceIn("TRUE", 1);
		try
		{
			int _type = TRUE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:6: ( 'true' )
			DebugEnterAlt(1);
			// MathLang.g:9:8: 'true'
			{
			DebugLocation(9, 8);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TRUE", 1);
			LeaveRule("TRUE", 1);
			Leave_TRUE();
		}
	}
	// $ANTLR end "TRUE"

	partial void Enter_FALSE();
	partial void Leave_FALSE();

	// $ANTLR start "FALSE"
	[GrammarRule("FALSE")]
	private void mFALSE()
	{
		Enter_FALSE();
		EnterRule("FALSE", 2);
		TraceIn("FALSE", 2);
		try
		{
			int _type = FALSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:7: ( 'false' )
			DebugEnterAlt(1);
			// MathLang.g:10:9: 'false'
			{
			DebugLocation(10, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FALSE", 2);
			LeaveRule("FALSE", 2);
			Leave_FALSE();
		}
	}
	// $ANTLR end "FALSE"

	partial void Enter_AND();
	partial void Leave_AND();

	// $ANTLR start "AND"
	[GrammarRule("AND")]
	private void mAND()
	{
		Enter_AND();
		EnterRule("AND", 3);
		TraceIn("AND", 3);
		try
		{
			int _type = AND;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:5: ( 'and' )
			DebugEnterAlt(1);
			// MathLang.g:11:7: 'and'
			{
			DebugLocation(11, 7);
			Match("and"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("AND", 3);
			LeaveRule("AND", 3);
			Leave_AND();
		}
	}
	// $ANTLR end "AND"

	partial void Enter_OR();
	partial void Leave_OR();

	// $ANTLR start "OR"
	[GrammarRule("OR")]
	private void mOR()
	{
		Enter_OR();
		EnterRule("OR", 4);
		TraceIn("OR", 4);
		try
		{
			int _type = OR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:4: ( 'or ' )
			DebugEnterAlt(1);
			// MathLang.g:12:6: 'or '
			{
			DebugLocation(12, 6);
			Match("or "); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OR", 4);
			LeaveRule("OR", 4);
			Leave_OR();
		}
	}
	// $ANTLR end "OR"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 5);
		TraceIn("IF", 5);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:13:6: 'if'
			{
			DebugLocation(13, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 5);
			LeaveRule("IF", 5);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_THEN();
	partial void Leave_THEN();

	// $ANTLR start "THEN"
	[GrammarRule("THEN")]
	private void mTHEN()
	{
		Enter_THEN();
		EnterRule("THEN", 6);
		TraceIn("THEN", 6);
		try
		{
			int _type = THEN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:6: ( 'then' )
			DebugEnterAlt(1);
			// MathLang.g:14:8: 'then'
			{
			DebugLocation(14, 8);
			Match("then"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("THEN", 6);
			LeaveRule("THEN", 6);
			Leave_THEN();
		}
	}
	// $ANTLR end "THEN"

	partial void Enter_ELSE();
	partial void Leave_ELSE();

	// $ANTLR start "ELSE"
	[GrammarRule("ELSE")]
	private void mELSE()
	{
		Enter_ELSE();
		EnterRule("ELSE", 7);
		TraceIn("ELSE", 7);
		try
		{
			int _type = ELSE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:6: ( 'else' )
			DebugEnterAlt(1);
			// MathLang.g:15:8: 'else'
			{
			DebugLocation(15, 8);
			Match("else"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSE", 7);
			LeaveRule("ELSE", 7);
			Leave_ELSE();
		}
	}
	// $ANTLR end "ELSE"

	partial void Enter_ELSIF();
	partial void Leave_ELSIF();

	// $ANTLR start "ELSIF"
	[GrammarRule("ELSIF")]
	private void mELSIF()
	{
		Enter_ELSIF();
		EnterRule("ELSIF", 8);
		TraceIn("ELSIF", 8);
		try
		{
			int _type = ELSIF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( 'elsif' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: 'elsif'
			{
			DebugLocation(16, 9);
			Match("elsif"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ELSIF", 8);
			LeaveRule("ELSIF", 8);
			Leave_ELSIF();
		}
	}
	// $ANTLR end "ELSIF"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 9);
		TraceIn("DIV", 9);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:5: ( 'div' )
			DebugEnterAlt(1);
			// MathLang.g:17:7: 'div'
			{
			DebugLocation(17, 7);
			Match("div"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 9);
			LeaveRule("DIV", 9);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_MOD();
	partial void Leave_MOD();

	// $ANTLR start "MOD"
	[GrammarRule("MOD")]
	private void mMOD()
	{
		Enter_MOD();
		EnterRule("MOD", 10);
		TraceIn("MOD", 10);
		try
		{
			int _type = MOD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:5: ( 'mod' )
			DebugEnterAlt(1);
			// MathLang.g:18:7: 'mod'
			{
			DebugLocation(18, 7);
			Match("mod"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MOD", 10);
			LeaveRule("MOD", 10);
			Leave_MOD();
		}
	}
	// $ANTLR end "MOD"

	partial void Enter_FOR();
	partial void Leave_FOR();

	// $ANTLR start "FOR"
	[GrammarRule("FOR")]
	private void mFOR()
	{
		Enter_FOR();
		EnterRule("FOR", 11);
		TraceIn("FOR", 11);
		try
		{
			int _type = FOR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:5: ( 'for' )
			DebugEnterAlt(1);
			// MathLang.g:19:7: 'for'
			{
			DebugLocation(19, 7);
			Match("for"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FOR", 11);
			LeaveRule("FOR", 11);
			Leave_FOR();
		}
	}
	// $ANTLR end "FOR"

	partial void Enter_TO();
	partial void Leave_TO();

	// $ANTLR start "TO"
	[GrammarRule("TO")]
	private void mTO()
	{
		Enter_TO();
		EnterRule("TO", 12);
		TraceIn("TO", 12);
		try
		{
			int _type = TO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:4: ( 'to' )
			DebugEnterAlt(1);
			// MathLang.g:20:6: 'to'
			{
			DebugLocation(20, 6);
			Match("to"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("TO", 12);
			LeaveRule("TO", 12);
			Leave_TO();
		}
	}
	// $ANTLR end "TO"

	partial void Enter_DOWNTO();
	partial void Leave_DOWNTO();

	// $ANTLR start "DOWNTO"
	[GrammarRule("DOWNTO")]
	private void mDOWNTO()
	{
		Enter_DOWNTO();
		EnterRule("DOWNTO", 13);
		TraceIn("DOWNTO", 13);
		try
		{
			int _type = DOWNTO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:8: ( 'downto' )
			DebugEnterAlt(1);
			// MathLang.g:21:10: 'downto'
			{
			DebugLocation(21, 10);
			Match("downto"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOWNTO", 13);
			LeaveRule("DOWNTO", 13);
			Leave_DOWNTO();
		}
	}
	// $ANTLR end "DOWNTO"

	partial void Enter_DO();
	partial void Leave_DO();

	// $ANTLR start "DO"
	[GrammarRule("DO")]
	private void mDO()
	{
		Enter_DO();
		EnterRule("DO", 14);
		TraceIn("DO", 14);
		try
		{
			int _type = DO;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:4: ( 'do' )
			DebugEnterAlt(1);
			// MathLang.g:22:6: 'do'
			{
			DebugLocation(22, 6);
			Match("do"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DO", 14);
			LeaveRule("DO", 14);
			Leave_DO();
		}
	}
	// $ANTLR end "DO"

	partial void Enter_WHILE();
	partial void Leave_WHILE();

	// $ANTLR start "WHILE"
	[GrammarRule("WHILE")]
	private void mWHILE()
	{
		Enter_WHILE();
		EnterRule("WHILE", 15);
		TraceIn("WHILE", 15);
		try
		{
			int _type = WHILE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:23:7: ( 'while' )
			DebugEnterAlt(1);
			// MathLang.g:23:9: 'while'
			{
			DebugLocation(23, 9);
			Match("while"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WHILE", 15);
			LeaveRule("WHILE", 15);
			Leave_WHILE();
		}
	}
	// $ANTLR end "WHILE"

	partial void Enter_REPEAT();
	partial void Leave_REPEAT();

	// $ANTLR start "REPEAT"
	[GrammarRule("REPEAT")]
	private void mREPEAT()
	{
		Enter_REPEAT();
		EnterRule("REPEAT", 16);
		TraceIn("REPEAT", 16);
		try
		{
			int _type = REPEAT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:24:8: ( 'repeat' )
			DebugEnterAlt(1);
			// MathLang.g:24:10: 'repeat'
			{
			DebugLocation(24, 10);
			Match("repeat"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REPEAT", 16);
			LeaveRule("REPEAT", 16);
			Leave_REPEAT();
		}
	}
	// $ANTLR end "REPEAT"

	partial void Enter_UNTIL();
	partial void Leave_UNTIL();

	// $ANTLR start "UNTIL"
	[GrammarRule("UNTIL")]
	private void mUNTIL()
	{
		Enter_UNTIL();
		EnterRule("UNTIL", 17);
		TraceIn("UNTIL", 17);
		try
		{
			int _type = UNTIL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:25:7: ( 'until' )
			DebugEnterAlt(1);
			// MathLang.g:25:9: 'until'
			{
			DebugLocation(25, 9);
			Match("until"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("UNTIL", 17);
			LeaveRule("UNTIL", 17);
			Leave_UNTIL();
		}
	}
	// $ANTLR end "UNTIL"

	partial void Enter_INT();
	partial void Leave_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		Enter_INT();
		EnterRule("INT", 18);
		TraceIn("INT", 18);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:26:5: ( 'integer' )
			DebugEnterAlt(1);
			// MathLang.g:26:7: 'integer'
			{
			DebugLocation(26, 7);
			Match("integer"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 18);
			LeaveRule("INT", 18);
			Leave_INT();
		}
	}
	// $ANTLR end "INT"

	partial void Enter_REAL();
	partial void Leave_REAL();

	// $ANTLR start "REAL"
	[GrammarRule("REAL")]
	private void mREAL()
	{
		Enter_REAL();
		EnterRule("REAL", 19);
		TraceIn("REAL", 19);
		try
		{
			int _type = REAL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:27:6: ( 'real' )
			DebugEnterAlt(1);
			// MathLang.g:27:8: 'real'
			{
			DebugLocation(27, 8);
			Match("real"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REAL", 19);
			LeaveRule("REAL", 19);
			Leave_REAL();
		}
	}
	// $ANTLR end "REAL"

	partial void Enter_CHAR();
	partial void Leave_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		Enter_CHAR();
		EnterRule("CHAR", 20);
		TraceIn("CHAR", 20);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:28:6: ( 'char' )
			DebugEnterAlt(1);
			// MathLang.g:28:8: 'char'
			{
			DebugLocation(28, 8);
			Match("char"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 20);
			LeaveRule("CHAR", 20);
			Leave_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	partial void Enter_BOOL();
	partial void Leave_BOOL();

	// $ANTLR start "BOOL"
	[GrammarRule("BOOL")]
	private void mBOOL()
	{
		Enter_BOOL();
		EnterRule("BOOL", 21);
		TraceIn("BOOL", 21);
		try
		{
			int _type = BOOL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:29:6: ( 'boolean' )
			DebugEnterAlt(1);
			// MathLang.g:29:8: 'boolean'
			{
			DebugLocation(29, 8);
			Match("boolean"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BOOL", 21);
			LeaveRule("BOOL", 21);
			Leave_BOOL();
		}
	}
	// $ANTLR end "BOOL"

	partial void Enter_VAR();
	partial void Leave_VAR();

	// $ANTLR start "VAR"
	[GrammarRule("VAR")]
	private void mVAR()
	{
		Enter_VAR();
		EnterRule("VAR", 22);
		TraceIn("VAR", 22);
		try
		{
			int _type = VAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:30:5: ( 'var' )
			DebugEnterAlt(1);
			// MathLang.g:30:7: 'var'
			{
			DebugLocation(30, 7);
			Match("var"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VAR", 22);
			LeaveRule("VAR", 22);
			Leave_VAR();
		}
	}
	// $ANTLR end "VAR"

	partial void Enter_BEGIN();
	partial void Leave_BEGIN();

	// $ANTLR start "BEGIN"
	[GrammarRule("BEGIN")]
	private void mBEGIN()
	{
		Enter_BEGIN();
		EnterRule("BEGIN", 23);
		TraceIn("BEGIN", 23);
		try
		{
			int _type = BEGIN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:31:7: ( 'begin' )
			DebugEnterAlt(1);
			// MathLang.g:31:9: 'begin'
			{
			DebugLocation(31, 9);
			Match("begin"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("BEGIN", 23);
			LeaveRule("BEGIN", 23);
			Leave_BEGIN();
		}
	}
	// $ANTLR end "BEGIN"

	partial void Enter_END();
	partial void Leave_END();

	// $ANTLR start "END"
	[GrammarRule("END")]
	private void mEND()
	{
		Enter_END();
		EnterRule("END", 24);
		TraceIn("END", 24);
		try
		{
			int _type = END;
			int _channel = DefaultTokenChannel;
			// MathLang.g:32:5: ( 'end' )
			DebugEnterAlt(1);
			// MathLang.g:32:7: 'end'
			{
			DebugLocation(32, 7);
			Match("end"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("END", 24);
			LeaveRule("END", 24);
			Leave_END();
		}
	}
	// $ANTLR end "END"

	partial void Enter_WRITE();
	partial void Leave_WRITE();

	// $ANTLR start "WRITE"
	[GrammarRule("WRITE")]
	private void mWRITE()
	{
		Enter_WRITE();
		EnterRule("WRITE", 25);
		TraceIn("WRITE", 25);
		try
		{
			int _type = WRITE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:33:7: ( 'write' )
			DebugEnterAlt(1);
			// MathLang.g:33:9: 'write'
			{
			DebugLocation(33, 9);
			Match("write"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WRITE", 25);
			LeaveRule("WRITE", 25);
			Leave_WRITE();
		}
	}
	// $ANTLR end "WRITE"

	partial void Enter_WRITELN();
	partial void Leave_WRITELN();

	// $ANTLR start "WRITELN"
	[GrammarRule("WRITELN")]
	private void mWRITELN()
	{
		Enter_WRITELN();
		EnterRule("WRITELN", 26);
		TraceIn("WRITELN", 26);
		try
		{
			int _type = WRITELN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:34:9: ( 'writeln' )
			DebugEnterAlt(1);
			// MathLang.g:34:11: 'writeln'
			{
			DebugLocation(34, 11);
			Match("writeln"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WRITELN", 26);
			LeaveRule("WRITELN", 26);
			Leave_WRITELN();
		}
	}
	// $ANTLR end "WRITELN"

	partial void Enter_INPUT();
	partial void Leave_INPUT();

	// $ANTLR start "INPUT"
	[GrammarRule("INPUT")]
	private void mINPUT()
	{
		Enter_INPUT();
		EnterRule("INPUT", 27);
		TraceIn("INPUT", 27);
		try
		{
			int _type = INPUT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:35:7: ( 'input' )
			DebugEnterAlt(1);
			// MathLang.g:35:9: 'input'
			{
			DebugLocation(35, 9);
			Match("input"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INPUT", 27);
			LeaveRule("INPUT", 27);
			Leave_INPUT();
		}
	}
	// $ANTLR end "INPUT"

	partial void Enter_ARRAY();
	partial void Leave_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		Enter_ARRAY();
		EnterRule("ARRAY", 28);
		TraceIn("ARRAY", 28);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MathLang.g:36:7: ( 'array' )
			DebugEnterAlt(1);
			// MathLang.g:36:9: 'array'
			{
			DebugLocation(36, 9);
			Match("array"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 28);
			LeaveRule("ARRAY", 28);
			Leave_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void Enter_OF();
	partial void Leave_OF();

	// $ANTLR start "OF"
	[GrammarRule("OF")]
	private void mOF()
	{
		Enter_OF();
		EnterRule("OF", 29);
		TraceIn("OF", 29);
		try
		{
			int _type = OF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:37:4: ( 'of' )
			DebugEnterAlt(1);
			// MathLang.g:37:6: 'of'
			{
			DebugLocation(37, 6);
			Match("of"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("OF", 29);
			LeaveRule("OF", 29);
			Leave_OF();
		}
	}
	// $ANTLR end "OF"

	partial void Enter_CONST_();
	partial void Leave_CONST_();

	// $ANTLR start "CONST_"
	[GrammarRule("CONST_")]
	private void mCONST_()
	{
		Enter_CONST_();
		EnterRule("CONST_", 30);
		TraceIn("CONST_", 30);
		try
		{
			int _type = CONST_;
			int _channel = DefaultTokenChannel;
			// MathLang.g:38:8: ( 'const' )
			DebugEnterAlt(1);
			// MathLang.g:38:10: 'const'
			{
			DebugLocation(38, 10);
			Match("const"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONST_", 30);
			LeaveRule("CONST_", 30);
			Leave_CONST_();
		}
	}
	// $ANTLR end "CONST_"

	partial void Enter_FUNC();
	partial void Leave_FUNC();

	// $ANTLR start "FUNC"
	[GrammarRule("FUNC")]
	private void mFUNC()
	{
		Enter_FUNC();
		EnterRule("FUNC", 31);
		TraceIn("FUNC", 31);
		try
		{
			int _type = FUNC;
			int _channel = DefaultTokenChannel;
			// MathLang.g:39:6: ( 'function' )
			DebugEnterAlt(1);
			// MathLang.g:39:8: 'function'
			{
			DebugLocation(39, 8);
			Match("function"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("FUNC", 31);
			LeaveRule("FUNC", 31);
			Leave_FUNC();
		}
	}
	// $ANTLR end "FUNC"

	partial void Enter_PROC();
	partial void Leave_PROC();

	// $ANTLR start "PROC"
	[GrammarRule("PROC")]
	private void mPROC()
	{
		Enter_PROC();
		EnterRule("PROC", 32);
		TraceIn("PROC", 32);
		try
		{
			int _type = PROC;
			int _channel = DefaultTokenChannel;
			// MathLang.g:40:6: ( 'procedure' )
			DebugEnterAlt(1);
			// MathLang.g:40:8: 'procedure'
			{
			DebugLocation(40, 8);
			Match("procedure"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PROC", 32);
			LeaveRule("PROC", 32);
			Leave_PROC();
		}
	}
	// $ANTLR end "PROC"

	partial void Enter_T__60();
	partial void Leave_T__60();

	// $ANTLR start "T__60"
	[GrammarRule("T__60")]
	private void mT__60()
	{
		Enter_T__60();
		EnterRule("T__60", 33);
		TraceIn("T__60", 33);
		try
		{
			int _type = T__60;
			int _channel = DefaultTokenChannel;
			// MathLang.g:41:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:41:9: '('
			{
			DebugLocation(41, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__60", 33);
			LeaveRule("T__60", 33);
			Leave_T__60();
		}
	}
	// $ANTLR end "T__60"

	partial void Enter_T__61();
	partial void Leave_T__61();

	// $ANTLR start "T__61"
	[GrammarRule("T__61")]
	private void mT__61()
	{
		Enter_T__61();
		EnterRule("T__61", 34);
		TraceIn("T__61", 34);
		try
		{
			int _type = T__61;
			int _channel = DefaultTokenChannel;
			// MathLang.g:42:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:42:9: ')'
			{
			DebugLocation(42, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__61", 34);
			LeaveRule("T__61", 34);
			Leave_T__61();
		}
	}
	// $ANTLR end "T__61"

	partial void Enter_T__62();
	partial void Leave_T__62();

	// $ANTLR start "T__62"
	[GrammarRule("T__62")]
	private void mT__62()
	{
		Enter_T__62();
		EnterRule("T__62", 35);
		TraceIn("T__62", 35);
		try
		{
			int _type = T__62;
			int _channel = DefaultTokenChannel;
			// MathLang.g:43:7: ( '[' )
			DebugEnterAlt(1);
			// MathLang.g:43:9: '['
			{
			DebugLocation(43, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__62", 35);
			LeaveRule("T__62", 35);
			Leave_T__62();
		}
	}
	// $ANTLR end "T__62"

	partial void Enter_T__63();
	partial void Leave_T__63();

	// $ANTLR start "T__63"
	[GrammarRule("T__63")]
	private void mT__63()
	{
		Enter_T__63();
		EnterRule("T__63", 36);
		TraceIn("T__63", 36);
		try
		{
			int _type = T__63;
			int _channel = DefaultTokenChannel;
			// MathLang.g:44:7: ( ']' )
			DebugEnterAlt(1);
			// MathLang.g:44:9: ']'
			{
			DebugLocation(44, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__63", 36);
			LeaveRule("T__63", 36);
			Leave_T__63();
		}
	}
	// $ANTLR end "T__63"

	partial void Enter_T__64();
	partial void Leave_T__64();

	// $ANTLR start "T__64"
	[GrammarRule("T__64")]
	private void mT__64()
	{
		Enter_T__64();
		EnterRule("T__64", 37);
		TraceIn("T__64", 37);
		try
		{
			int _type = T__64;
			int _channel = DefaultTokenChannel;
			// MathLang.g:45:7: ( '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:45:9: '\\''
			{
			DebugLocation(45, 9);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__64", 37);
			LeaveRule("T__64", 37);
			Leave_T__64();
		}
	}
	// $ANTLR end "T__64"

	partial void Enter_T__65();
	partial void Leave_T__65();

	// $ANTLR start "T__65"
	[GrammarRule("T__65")]
	private void mT__65()
	{
		Enter_T__65();
		EnterRule("T__65", 38);
		TraceIn("T__65", 38);
		try
		{
			int _type = T__65;
			int _channel = DefaultTokenChannel;
			// MathLang.g:46:7: ( '!' )
			DebugEnterAlt(1);
			// MathLang.g:46:9: '!'
			{
			DebugLocation(46, 9);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__65", 38);
			LeaveRule("T__65", 38);
			Leave_T__65();
		}
	}
	// $ANTLR end "T__65"

	partial void Enter_T__66();
	partial void Leave_T__66();

	// $ANTLR start "T__66"
	[GrammarRule("T__66")]
	private void mT__66()
	{
		Enter_T__66();
		EnterRule("T__66", 39);
		TraceIn("T__66", 39);
		try
		{
			int _type = T__66;
			int _channel = DefaultTokenChannel;
			// MathLang.g:47:7: ( '?' )
			DebugEnterAlt(1);
			// MathLang.g:47:9: '?'
			{
			DebugLocation(47, 9);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__66", 39);
			LeaveRule("T__66", 39);
			Leave_T__66();
		}
	}
	// $ANTLR end "T__66"

	partial void Enter_T__67();
	partial void Leave_T__67();

	// $ANTLR start "T__67"
	[GrammarRule("T__67")]
	private void mT__67()
	{
		Enter_T__67();
		EnterRule("T__67", 40);
		TraceIn("T__67", 40);
		try
		{
			int _type = T__67;
			int _channel = DefaultTokenChannel;
			// MathLang.g:48:7: ( '@' )
			DebugEnterAlt(1);
			// MathLang.g:48:9: '@'
			{
			DebugLocation(48, 9);
			Match('@'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__67", 40);
			LeaveRule("T__67", 40);
			Leave_T__67();
		}
	}
	// $ANTLR end "T__67"

	partial void Enter_T__68();
	partial void Leave_T__68();

	// $ANTLR start "T__68"
	[GrammarRule("T__68")]
	private void mT__68()
	{
		Enter_T__68();
		EnterRule("T__68", 41);
		TraceIn("T__68", 41);
		try
		{
			int _type = T__68;
			int _channel = DefaultTokenChannel;
			// MathLang.g:49:7: ( ':' )
			DebugEnterAlt(1);
			// MathLang.g:49:9: ':'
			{
			DebugLocation(49, 9);
			Match(':'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__68", 41);
			LeaveRule("T__68", 41);
			Leave_T__68();
		}
	}
	// $ANTLR end "T__68"

	partial void Enter_T__69();
	partial void Leave_T__69();

	// $ANTLR start "T__69"
	[GrammarRule("T__69")]
	private void mT__69()
	{
		Enter_T__69();
		EnterRule("T__69", 42);
		TraceIn("T__69", 42);
		try
		{
			int _type = T__69;
			int _channel = DefaultTokenChannel;
			// MathLang.g:50:7: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:50:9: ';'
			{
			DebugLocation(50, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__69", 42);
			LeaveRule("T__69", 42);
			Leave_T__69();
		}
	}
	// $ANTLR end "T__69"

	partial void Enter_T__70();
	partial void Leave_T__70();

	// $ANTLR start "T__70"
	[GrammarRule("T__70")]
	private void mT__70()
	{
		Enter_T__70();
		EnterRule("T__70", 43);
		TraceIn("T__70", 43);
		try
		{
			int _type = T__70;
			int _channel = DefaultTokenChannel;
			// MathLang.g:51:7: ( '#' )
			DebugEnterAlt(1);
			// MathLang.g:51:9: '#'
			{
			DebugLocation(51, 9);
			Match('#'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__70", 43);
			LeaveRule("T__70", 43);
			Leave_T__70();
		}
	}
	// $ANTLR end "T__70"

	partial void Enter_T__71();
	partial void Leave_T__71();

	// $ANTLR start "T__71"
	[GrammarRule("T__71")]
	private void mT__71()
	{
		Enter_T__71();
		EnterRule("T__71", 44);
		TraceIn("T__71", 44);
		try
		{
			int _type = T__71;
			int _channel = DefaultTokenChannel;
			// MathLang.g:52:7: ( '$' )
			DebugEnterAlt(1);
			// MathLang.g:52:9: '$'
			{
			DebugLocation(52, 9);
			Match('$'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__71", 44);
			LeaveRule("T__71", 44);
			Leave_T__71();
		}
	}
	// $ANTLR end "T__71"

	partial void Enter_T__72();
	partial void Leave_T__72();

	// $ANTLR start "T__72"
	[GrammarRule("T__72")]
	private void mT__72()
	{
		Enter_T__72();
		EnterRule("T__72", 45);
		TraceIn("T__72", 45);
		try
		{
			int _type = T__72;
			int _channel = DefaultTokenChannel;
			// MathLang.g:53:7: ( '%' )
			DebugEnterAlt(1);
			// MathLang.g:53:9: '%'
			{
			DebugLocation(53, 9);
			Match('%'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__72", 45);
			LeaveRule("T__72", 45);
			Leave_T__72();
		}
	}
	// $ANTLR end "T__72"

	partial void Enter_T__73();
	partial void Leave_T__73();

	// $ANTLR start "T__73"
	[GrammarRule("T__73")]
	private void mT__73()
	{
		Enter_T__73();
		EnterRule("T__73", 46);
		TraceIn("T__73", 46);
		try
		{
			int _type = T__73;
			int _channel = DefaultTokenChannel;
			// MathLang.g:54:7: ( '^' )
			DebugEnterAlt(1);
			// MathLang.g:54:9: '^'
			{
			DebugLocation(54, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__73", 46);
			LeaveRule("T__73", 46);
			Leave_T__73();
		}
	}
	// $ANTLR end "T__73"

	partial void Enter_T__74();
	partial void Leave_T__74();

	// $ANTLR start "T__74"
	[GrammarRule("T__74")]
	private void mT__74()
	{
		Enter_T__74();
		EnterRule("T__74", 47);
		TraceIn("T__74", 47);
		try
		{
			int _type = T__74;
			int _channel = DefaultTokenChannel;
			// MathLang.g:55:7: ( '&' )
			DebugEnterAlt(1);
			// MathLang.g:55:9: '&'
			{
			DebugLocation(55, 9);
			Match('&'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__74", 47);
			LeaveRule("T__74", 47);
			Leave_T__74();
		}
	}
	// $ANTLR end "T__74"

	partial void Enter_T__75();
	partial void Leave_T__75();

	// $ANTLR start "T__75"
	[GrammarRule("T__75")]
	private void mT__75()
	{
		Enter_T__75();
		EnterRule("T__75", 48);
		TraceIn("T__75", 48);
		try
		{
			int _type = T__75;
			int _channel = DefaultTokenChannel;
			// MathLang.g:56:7: ( '{' )
			DebugEnterAlt(1);
			// MathLang.g:56:9: '{'
			{
			DebugLocation(56, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__75", 48);
			LeaveRule("T__75", 48);
			Leave_T__75();
		}
	}
	// $ANTLR end "T__75"

	partial void Enter_T__76();
	partial void Leave_T__76();

	// $ANTLR start "T__76"
	[GrammarRule("T__76")]
	private void mT__76()
	{
		Enter_T__76();
		EnterRule("T__76", 49);
		TraceIn("T__76", 49);
		try
		{
			int _type = T__76;
			int _channel = DefaultTokenChannel;
			// MathLang.g:57:7: ( '}' )
			DebugEnterAlt(1);
			// MathLang.g:57:9: '}'
			{
			DebugLocation(57, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__76", 49);
			LeaveRule("T__76", 49);
			Leave_T__76();
		}
	}
	// $ANTLR end "T__76"

	partial void Enter_T__77();
	partial void Leave_T__77();

	// $ANTLR start "T__77"
	[GrammarRule("T__77")]
	private void mT__77()
	{
		Enter_T__77();
		EnterRule("T__77", 50);
		TraceIn("T__77", 50);
		try
		{
			int _type = T__77;
			int _channel = DefaultTokenChannel;
			// MathLang.g:58:7: ( '~' )
			DebugEnterAlt(1);
			// MathLang.g:58:9: '~'
			{
			DebugLocation(58, 9);
			Match('~'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__77", 50);
			LeaveRule("T__77", 50);
			Leave_T__77();
		}
	}
	// $ANTLR end "T__77"

	partial void Enter_T__78();
	partial void Leave_T__78();

	// $ANTLR start "T__78"
	[GrammarRule("T__78")]
	private void mT__78()
	{
		Enter_T__78();
		EnterRule("T__78", 51);
		TraceIn("T__78", 51);
		try
		{
			int _type = T__78;
			int _channel = DefaultTokenChannel;
			// MathLang.g:59:7: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:59:9: '.'
			{
			DebugLocation(59, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__78", 51);
			LeaveRule("T__78", 51);
			Leave_T__78();
		}
	}
	// $ANTLR end "T__78"

	partial void Enter_T__79();
	partial void Leave_T__79();

	// $ANTLR start "T__79"
	[GrammarRule("T__79")]
	private void mT__79()
	{
		Enter_T__79();
		EnterRule("T__79", 52);
		TraceIn("T__79", 52);
		try
		{
			int _type = T__79;
			int _channel = DefaultTokenChannel;
			// MathLang.g:60:7: ( ',' )
			DebugEnterAlt(1);
			// MathLang.g:60:9: ','
			{
			DebugLocation(60, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__79", 52);
			LeaveRule("T__79", 52);
			Leave_T__79();
		}
	}
	// $ANTLR end "T__79"

	partial void Enter_T__80();
	partial void Leave_T__80();

	// $ANTLR start "T__80"
	[GrammarRule("T__80")]
	private void mT__80()
	{
		Enter_T__80();
		EnterRule("T__80", 53);
		TraceIn("T__80", 53);
		try
		{
			int _type = T__80;
			int _channel = DefaultTokenChannel;
			// MathLang.g:61:7: ( '_' )
			DebugEnterAlt(1);
			// MathLang.g:61:9: '_'
			{
			DebugLocation(61, 9);
			Match('_'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__80", 53);
			LeaveRule("T__80", 53);
			Leave_T__80();
		}
	}
	// $ANTLR end "T__80"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 54);
		TraceIn("WS", 54);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:57:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:58:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(58, 3);
			// MathLang.g:58:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(58, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(58, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 54);
			LeaveRule("WS", 54);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 55);
		TraceIn("SL_COMMENT", 55);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:63:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:64:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(64, 3);
			Match("//"); 

			DebugLocation(64, 8);
			// MathLang.g:64:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:64:36: .
					{
					DebugLocation(64, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(64, 40);
			// MathLang.g:64:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:64:40: '\\r'
				{
				DebugLocation(64, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(64, 46);
			Match('\n'); 
			DebugLocation(64, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 55);
			LeaveRule("SL_COMMENT", 55);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 56);
		TraceIn("ML_COMMENT", 56);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:68:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:69:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(69, 3);
			Match("/*"); 

			DebugLocation(69, 8);
			// MathLang.g:69:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:69:36: .
					{
					DebugLocation(69, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(69, 40);
			Match("*/"); 

			DebugLocation(69, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 56);
			LeaveRule("ML_COMMENT", 56);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_NUMBER();
	partial void Leave_NUMBER();

	// $ANTLR start "NUMBER"
	[GrammarRule("NUMBER")]
	private void mNUMBER()
	{
		Enter_NUMBER();
		EnterRule("NUMBER", 57);
		TraceIn("NUMBER", 57);
		try
		{
			int _type = NUMBER;
			int _channel = DefaultTokenChannel;
			// MathLang.g:75:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:75:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(75, 9);
			// MathLang.g:75:9: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:75:10: '0' .. '9'
					{
					DebugLocation(75, 10);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(75, 21);
			// MathLang.g:75:21: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:75:22: '.' ( '0' .. '9' )+
				{
				DebugLocation(75, 22);
				Match('.'); 
				DebugLocation(75, 26);
				// MathLang.g:75:26: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:75:27: '0' .. '9'
						{
						DebugLocation(75, 27);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NUMBER", 57);
			LeaveRule("NUMBER", 57);
			Leave_NUMBER();
		}
	}
	// $ANTLR end "NUMBER"

	partial void Enter_IDENT();
	partial void Leave_IDENT();

	// $ANTLR start "IDENT"
	[GrammarRule("IDENT")]
	private void mIDENT()
	{
		Enter_IDENT();
		EnterRule("IDENT", 58);
		TraceIn("IDENT", 58);
		try
		{
			int _type = IDENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:77:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
			DebugEnterAlt(1);
			// MathLang.g:77:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			{
			DebugLocation(77, 9);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();

			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;}

			DebugLocation(78, 9);
			// MathLang.g:78:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>='0' && LA8_0<='9')||(LA8_0>='A' && LA8_0<='Z')||LA8_0=='_'||(LA8_0>='a' && LA8_0<='z')))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(78, 9);
					if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENT", 58);
			LeaveRule("IDENT", 58);
			Leave_IDENT();
		}
	}
	// $ANTLR end "IDENT"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 59);
		TraceIn("ADD", 59);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:82:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:82:9: '+'
			{
			DebugLocation(82, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 59);
			LeaveRule("ADD", 59);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 60);
		TraceIn("SUB", 60);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:83:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:83:9: '-'
			{
			DebugLocation(83, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 60);
			LeaveRule("SUB", 60);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 61);
		TraceIn("MUL", 61);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:84:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:84:9: '*'
			{
			DebugLocation(84, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 61);
			LeaveRule("MUL", 61);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIVIDE();
	partial void Leave_DIVIDE();

	// $ANTLR start "DIVIDE"
	[GrammarRule("DIVIDE")]
	private void mDIVIDE()
	{
		Enter_DIVIDE();
		EnterRule("DIVIDE", 62);
		TraceIn("DIVIDE", 62);
		try
		{
			int _type = DIVIDE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:85:7: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:85:9: '/'
			{
			DebugLocation(85, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIVIDE", 62);
			LeaveRule("DIVIDE", 62);
			Leave_DIVIDE();
		}
	}
	// $ANTLR end "DIVIDE"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 63);
		TraceIn("ASSIGN", 63);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:86:7: ( ':=' )
			DebugEnterAlt(1);
			// MathLang.g:86:9: ':='
			{
			DebugLocation(86, 9);
			Match(":="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 63);
			LeaveRule("ASSIGN", 63);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 64);
		TraceIn("GE", 64);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:87:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:87:9: '>='
			{
			DebugLocation(87, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 64);
			LeaveRule("GE", 64);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 65);
		TraceIn("LE", 65);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:88:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:88:9: '<='
			{
			DebugLocation(88, 9);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 65);
			LeaveRule("LE", 65);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NEQUALS();
	partial void Leave_NEQUALS();

	// $ANTLR start "NEQUALS"
	[GrammarRule("NEQUALS")]
	private void mNEQUALS()
	{
		Enter_NEQUALS();
		EnterRule("NEQUALS", 66);
		TraceIn("NEQUALS", 66);
		try
		{
			int _type = NEQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:89:8: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:89:9: '<>'
			{
			DebugLocation(89, 9);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUALS", 66);
			LeaveRule("NEQUALS", 66);
			Leave_NEQUALS();
		}
	}
	// $ANTLR end "NEQUALS"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 67);
		TraceIn("EQUALS", 67);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:90:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:90:9: '='
			{
			DebugLocation(90, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 67);
			LeaveRule("EQUALS", 67);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 68);
		TraceIn("GT", 68);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:91:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:91:9: '>'
			{
			DebugLocation(91, 9);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 68);
			LeaveRule("GT", 68);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 69);
		TraceIn("LT", 69);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:92:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:92:9: '<'
			{
			DebugLocation(92, 9);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 69);
			LeaveRule("LT", 69);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( TRUE | FALSE | AND | OR | IF | THEN | ELSE | ELSIF | DIV | MOD | FOR | TO | DOWNTO | DO | WHILE | REPEAT | UNTIL | INT | REAL | CHAR | BOOL | VAR | BEGIN | END | WRITE | WRITELN | INPUT | ARRAY | OF | CONST_ | FUNC | PROC | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIVIDE | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT )
		int alt9=69;
		try { DebugEnterDecision(9, decisionCanBacktrack[9]);
		try
		{
			alt9 = dfa9.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: TRUE
			{
			DebugLocation(1, 10);
			mTRUE(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:15: FALSE
			{
			DebugLocation(1, 15);
			mFALSE(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:21: AND
			{
			DebugLocation(1, 21);
			mAND(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:25: OR
			{
			DebugLocation(1, 25);
			mOR(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:28: IF
			{
			DebugLocation(1, 28);
			mIF(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:31: THEN
			{
			DebugLocation(1, 31);
			mTHEN(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:36: ELSE
			{
			DebugLocation(1, 36);
			mELSE(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:41: ELSIF
			{
			DebugLocation(1, 41);
			mELSIF(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:47: DIV
			{
			DebugLocation(1, 47);
			mDIV(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:51: MOD
			{
			DebugLocation(1, 51);
			mMOD(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:55: FOR
			{
			DebugLocation(1, 55);
			mFOR(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:59: TO
			{
			DebugLocation(1, 59);
			mTO(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:62: DOWNTO
			{
			DebugLocation(1, 62);
			mDOWNTO(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:69: DO
			{
			DebugLocation(1, 69);
			mDO(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:72: WHILE
			{
			DebugLocation(1, 72);
			mWHILE(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:78: REPEAT
			{
			DebugLocation(1, 78);
			mREPEAT(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:85: UNTIL
			{
			DebugLocation(1, 85);
			mUNTIL(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:91: INT
			{
			DebugLocation(1, 91);
			mINT(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:95: REAL
			{
			DebugLocation(1, 95);
			mREAL(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:100: CHAR
			{
			DebugLocation(1, 100);
			mCHAR(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:105: BOOL
			{
			DebugLocation(1, 105);
			mBOOL(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:110: VAR
			{
			DebugLocation(1, 110);
			mVAR(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:114: BEGIN
			{
			DebugLocation(1, 114);
			mBEGIN(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:120: END
			{
			DebugLocation(1, 120);
			mEND(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:124: WRITE
			{
			DebugLocation(1, 124);
			mWRITE(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:130: WRITELN
			{
			DebugLocation(1, 130);
			mWRITELN(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:138: INPUT
			{
			DebugLocation(1, 138);
			mINPUT(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:144: ARRAY
			{
			DebugLocation(1, 144);
			mARRAY(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:150: OF
			{
			DebugLocation(1, 150);
			mOF(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:153: CONST_
			{
			DebugLocation(1, 153);
			mCONST_(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:160: FUNC
			{
			DebugLocation(1, 160);
			mFUNC(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// MathLang.g:1:165: PROC
			{
			DebugLocation(1, 165);
			mPROC(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// MathLang.g:1:170: T__60
			{
			DebugLocation(1, 170);
			mT__60(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// MathLang.g:1:176: T__61
			{
			DebugLocation(1, 176);
			mT__61(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// MathLang.g:1:182: T__62
			{
			DebugLocation(1, 182);
			mT__62(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// MathLang.g:1:188: T__63
			{
			DebugLocation(1, 188);
			mT__63(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// MathLang.g:1:194: T__64
			{
			DebugLocation(1, 194);
			mT__64(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// MathLang.g:1:200: T__65
			{
			DebugLocation(1, 200);
			mT__65(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// MathLang.g:1:206: T__66
			{
			DebugLocation(1, 206);
			mT__66(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// MathLang.g:1:212: T__67
			{
			DebugLocation(1, 212);
			mT__67(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// MathLang.g:1:218: T__68
			{
			DebugLocation(1, 218);
			mT__68(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// MathLang.g:1:224: T__69
			{
			DebugLocation(1, 224);
			mT__69(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// MathLang.g:1:230: T__70
			{
			DebugLocation(1, 230);
			mT__70(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// MathLang.g:1:236: T__71
			{
			DebugLocation(1, 236);
			mT__71(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// MathLang.g:1:242: T__72
			{
			DebugLocation(1, 242);
			mT__72(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// MathLang.g:1:248: T__73
			{
			DebugLocation(1, 248);
			mT__73(); 

			}
			break;
		case 47:
			DebugEnterAlt(47);
			// MathLang.g:1:254: T__74
			{
			DebugLocation(1, 254);
			mT__74(); 

			}
			break;
		case 48:
			DebugEnterAlt(48);
			// MathLang.g:1:260: T__75
			{
			DebugLocation(1, 260);
			mT__75(); 

			}
			break;
		case 49:
			DebugEnterAlt(49);
			// MathLang.g:1:266: T__76
			{
			DebugLocation(1, 266);
			mT__76(); 

			}
			break;
		case 50:
			DebugEnterAlt(50);
			// MathLang.g:1:272: T__77
			{
			DebugLocation(1, 272);
			mT__77(); 

			}
			break;
		case 51:
			DebugEnterAlt(51);
			// MathLang.g:1:278: T__78
			{
			DebugLocation(1, 278);
			mT__78(); 

			}
			break;
		case 52:
			DebugEnterAlt(52);
			// MathLang.g:1:284: T__79
			{
			DebugLocation(1, 284);
			mT__79(); 

			}
			break;
		case 53:
			DebugEnterAlt(53);
			// MathLang.g:1:290: T__80
			{
			DebugLocation(1, 290);
			mT__80(); 

			}
			break;
		case 54:
			DebugEnterAlt(54);
			// MathLang.g:1:296: WS
			{
			DebugLocation(1, 296);
			mWS(); 

			}
			break;
		case 55:
			DebugEnterAlt(55);
			// MathLang.g:1:299: SL_COMMENT
			{
			DebugLocation(1, 299);
			mSL_COMMENT(); 

			}
			break;
		case 56:
			DebugEnterAlt(56);
			// MathLang.g:1:310: ML_COMMENT
			{
			DebugLocation(1, 310);
			mML_COMMENT(); 

			}
			break;
		case 57:
			DebugEnterAlt(57);
			// MathLang.g:1:321: NUMBER
			{
			DebugLocation(1, 321);
			mNUMBER(); 

			}
			break;
		case 58:
			DebugEnterAlt(58);
			// MathLang.g:1:328: IDENT
			{
			DebugLocation(1, 328);
			mIDENT(); 

			}
			break;
		case 59:
			DebugEnterAlt(59);
			// MathLang.g:1:334: ADD
			{
			DebugLocation(1, 334);
			mADD(); 

			}
			break;
		case 60:
			DebugEnterAlt(60);
			// MathLang.g:1:338: SUB
			{
			DebugLocation(1, 338);
			mSUB(); 

			}
			break;
		case 61:
			DebugEnterAlt(61);
			// MathLang.g:1:342: MUL
			{
			DebugLocation(1, 342);
			mMUL(); 

			}
			break;
		case 62:
			DebugEnterAlt(62);
			// MathLang.g:1:346: DIVIDE
			{
			DebugLocation(1, 346);
			mDIVIDE(); 

			}
			break;
		case 63:
			DebugEnterAlt(63);
			// MathLang.g:1:353: ASSIGN
			{
			DebugLocation(1, 353);
			mASSIGN(); 

			}
			break;
		case 64:
			DebugEnterAlt(64);
			// MathLang.g:1:360: GE
			{
			DebugLocation(1, 360);
			mGE(); 

			}
			break;
		case 65:
			DebugEnterAlt(65);
			// MathLang.g:1:363: LE
			{
			DebugLocation(1, 363);
			mLE(); 

			}
			break;
		case 66:
			DebugEnterAlt(66);
			// MathLang.g:1:366: NEQUALS
			{
			DebugLocation(1, 366);
			mNEQUALS(); 

			}
			break;
		case 67:
			DebugEnterAlt(67);
			// MathLang.g:1:374: EQUALS
			{
			DebugLocation(1, 374);
			mEQUALS(); 

			}
			break;
		case 68:
			DebugEnterAlt(68);
			// MathLang.g:1:381: GT
			{
			DebugLocation(1, 381);
			mGT(); 

			}
			break;
		case 69:
			DebugEnterAlt(69);
			// MathLang.g:1:384: LT
			{
			DebugLocation(1, 384);
			mLT(); 

			}
			break;

		}

	}


	#region DFA
	DFA9 dfa9;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa9 = new DFA9(this);
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1\xFFFF\xF\x28\x8\xFFFF\x1\x4B\xB\xFFFF\x1\x4C\x1\xFFFF\x1\x4F\x5"+
			"\xFFFF\x1\x51\x1\x54\x1\xFFFF\x2\x28\x1\x57\x6\x28\x1\x5E\x1\x5F\x4\x28"+
			"\x1\x66\xB\x28\xB\xFFFF\x2\x28\x1\xFFFF\x1\x28\x1\x76\x1\x28\x1\x78\x1"+
			"\x28\x3\xFFFF\x3\x28\x1\x7E\x1\x7F\x1\x28\x1\xFFFF\x1\x81\x9\x28\x1\x8B"+
			"\x1\x28\x1\x8D\x1\x8E\x1\x28\x1\xFFFF\x1\x28\x1\xFFFF\x3\x28\x1\x94\x1"+
			"\x28\x2\xFFFF\x1\x28\x1\xFFFF\x3\x28\x1\x9A\x1\x28\x1\x9C\x3\x28\x1\xFFFF"+
			"\x1\x28\x2\xFFFF\x1\xA1\x1\x28\x1\xA3\x1\x28\x1\xA5\x1\xFFFF\x1\xA6\x1"+
			"\x28\x1\xA8\x1\xAA\x1\x28\x1\xFFFF\x1\xAC\x1\xFFFF\x1\xAD\x1\x28\x1\xAF"+
			"\x1\x28\x1\xFFFF\x1\x28\x1\xFFFF\x1\x28\x2\xFFFF\x1\xB3\x1\xFFFF\x1\x28"+
			"\x1\xFFFF\x1\xB5\x2\xFFFF\x1\x28\x1\xFFFF\x2\x28\x1\xB9\x1\xFFFF\x1\xBA"+
			"\x1\xFFFF\x1\xBB\x1\x28\x1\xBD\x3\xFFFF\x1\x28\x1\xFFFF\x1\xBF\x1\xFFFF";
		private const string DFA9_eofS =
			"\xC0\xFFFF";
		private const string DFA9_minS =
			"\x1\x9\x1\x68\x1\x61\x1\x6E\x2\x66\x1\x6C\x1\x69\x1\x6F\x1\x68\x1\x65"+
			"\x1\x6E\x1\x68\x1\x65\x1\x61\x1\x72\x8\xFFFF\x1\x3D\xB\xFFFF\x1\x30\x1"+
			"\xFFFF\x1\x2A\x5\xFFFF\x2\x3D\x1\xFFFF\x1\x75\x1\x65\x1\x30\x1\x6C\x1"+
			"\x72\x1\x6E\x1\x64\x1\x72\x1\x20\x2\x30\x1\x70\x1\x73\x1\x64\x1\x76\x1"+
			"\x30\x1\x64\x2\x69\x1\x61\x1\x74\x1\x61\x1\x6E\x1\x6F\x1\x67\x1\x72\x1"+
			"\x6F\xB\xFFFF\x1\x65\x1\x6E\x1\xFFFF\x1\x73\x1\x30\x1\x63\x1\x30\x1\x61"+
			"\x3\xFFFF\x1\x65\x1\x75\x1\x65\x2\x30\x1\x6E\x1\xFFFF\x1\x30\x1\x6C\x1"+
			"\x74\x1\x65\x1\x6C\x1\x69\x1\x72\x1\x73\x1\x6C\x1\x69\x1\x30\x1\x63\x2"+
			"\x30\x1\x65\x1\xFFFF\x1\x74\x1\xFFFF\x1\x79\x1\x67\x1\x74\x1\x30\x1\x66"+
			"\x2\xFFFF\x1\x74\x1\xFFFF\x2\x65\x1\x61\x1\x30\x1\x6C\x1\x30\x1\x74\x1"+
			"\x65\x1\x6E\x1\xFFFF\x1\x65\x2\xFFFF\x1\x30\x1\x69\x1\x30\x1\x65\x1\x30"+
			"\x1\xFFFF\x1\x30\x1\x6F\x2\x30\x1\x74\x1\xFFFF\x1\x30\x1\xFFFF\x1\x30"+
			"\x1\x61\x1\x30\x1\x64\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x72\x2\xFFFF\x1\x30"+
			"\x1\xFFFF\x1\x6E\x1\xFFFF\x1\x30\x2\xFFFF\x1\x6E\x1\xFFFF\x1\x75\x1\x6E"+
			"\x1\x30\x1\xFFFF\x1\x30\x1\xFFFF\x1\x30\x1\x72\x1\x30\x3\xFFFF\x1\x65"+
			"\x1\xFFFF\x1\x30\x1\xFFFF";
		private const string DFA9_maxS =
			"\x1\x7E\x1\x72\x1\x75\x2\x72\x2\x6E\x2\x6F\x1\x72\x1\x65\x1\x6E\x2\x6F"+
			"\x1\x61\x1\x72\x8\xFFFF\x1\x3D\xB\xFFFF\x1\x7A\x1\xFFFF\x1\x2F\x5\xFFFF"+
			"\x1\x3D\x1\x3E\x1\xFFFF\x1\x75\x1\x65\x1\x7A\x1\x6C\x1\x72\x1\x6E\x1"+
			"\x64\x1\x72\x1\x20\x2\x7A\x1\x74\x1\x73\x1\x64\x1\x76\x1\x7A\x1\x64\x2"+
			"\x69\x1\x70\x1\x74\x1\x61\x1\x6E\x1\x6F\x1\x67\x1\x72\x1\x6F\xB\xFFFF"+
			"\x1\x65\x1\x6E\x1\xFFFF\x1\x73\x1\x7A\x1\x63\x1\x7A\x1\x61\x3\xFFFF\x1"+
			"\x65\x1\x75\x1\x69\x2\x7A\x1\x6E\x1\xFFFF\x1\x7A\x1\x6C\x1\x74\x1\x65"+
			"\x1\x6C\x1\x69\x1\x72\x1\x73\x1\x6C\x1\x69\x1\x7A\x1\x63\x2\x7A\x1\x65"+
			"\x1\xFFFF\x1\x74\x1\xFFFF\x1\x79\x1\x67\x1\x74\x1\x7A\x1\x66\x2\xFFFF"+
			"\x1\x74\x1\xFFFF\x2\x65\x1\x61\x1\x7A\x1\x6C\x1\x7A\x1\x74\x1\x65\x1"+
			"\x6E\x1\xFFFF\x1\x65\x2\xFFFF\x1\x7A\x1\x69\x1\x7A\x1\x65\x1\x7A\x1\xFFFF"+
			"\x1\x7A\x1\x6F\x2\x7A\x1\x74\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x1\x61\x1"+
			"\x7A\x1\x64\x1\xFFFF\x1\x6F\x1\xFFFF\x1\x72\x2\xFFFF\x1\x7A\x1\xFFFF"+
			"\x1\x6E\x1\xFFFF\x1\x7A\x2\xFFFF\x1\x6E\x1\xFFFF\x1\x75\x1\x6E\x1\x7A"+
			"\x1\xFFFF\x1\x7A\x1\xFFFF\x1\x7A\x1\x72\x1\x7A\x3\xFFFF\x1\x65\x1\xFFFF"+
			"\x1\x7A\x1\xFFFF";
		private const string DFA9_acceptS =
			"\x10\xFFFF\x1\x21\x1\x22\x1\x23\x1\x24\x1\x25\x1\x26\x1\x27\x1\x28\x1"+
			"\xFFFF\x1\x2A\x1\x2B\x1\x2C\x1\x2D\x1\x2E\x1\x2F\x1\x30\x1\x31\x1\x32"+
			"\x1\x33\x1\x34\x1\xFFFF\x1\x36\x1\xFFFF\x1\x39\x1\x3A\x1\x3B\x1\x3C\x1"+
			"\x3D\x2\xFFFF\x1\x43\x1B\xFFFF\x1\x3F\x1\x29\x1\x35\x1\x37\x1\x38\x1"+
			"\x3E\x1\x40\x1\x44\x1\x41\x1\x42\x1\x45\x2\xFFFF\x1\xC\x5\xFFFF\x1\x4"+
			"\x1\x1D\x1\x5\x6\xFFFF\x1\xE\xF\xFFFF\x1\xB\x1\xFFFF\x1\x3\x5\xFFFF\x1"+
			"\x18\x1\x9\x1\xFFFF\x1\xA\x9\xFFFF\x1\x16\x1\xFFFF\x1\x1\x1\x6\x5\xFFFF"+
			"\x1\x7\x5\xFFFF\x1\x13\x1\xFFFF\x1\x14\x4\xFFFF\x1\x2\x1\xFFFF\x1\x1C"+
			"\x1\xFFFF\x1\x1B\x1\x8\x1\xFFFF\x1\xF\x1\xFFFF\x1\x19\x1\xFFFF\x1\x11"+
			"\x1\x1E\x1\xFFFF\x1\x17\x3\xFFFF\x1\xD\x1\xFFFF\x1\x10\x3\xFFFF\x1\x12"+
			"\x1\x1A\x1\x15\x1\xFFFF\x1\x1F\x1\xFFFF\x1\x20";
		private const string DFA9_specialS =
			"\xC0\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x2\x25\x1\xFFFF\x2\x25\x12\xFFFF\x1\x25\x1\x15\x1\xFFFF\x1\x1A\x1"+
				"\x1B\x1\x1C\x1\x1E\x1\x14\x1\x10\x1\x11\x1\x2B\x1\x29\x1\x23\x1\x2A"+
				"\x1\x22\x1\x26\xA\x27\x1\x18\x1\x19\x1\x2D\x1\x2E\x1\x2C\x1\x16\x1\x17"+
				"\x1A\x28\x1\x12\x1\xFFFF\x1\x13\x1\x1D\x1\x24\x1\xFFFF\x1\x3\x1\xD\x1"+
				"\xC\x1\x7\x1\x6\x1\x2\x2\x28\x1\x5\x3\x28\x1\x8\x1\x28\x1\x4\x1\xF\x1"+
				"\x28\x1\xA\x1\x28\x1\x1\x1\xB\x1\xE\x1\x9\x3\x28\x1\x1F\x1\xFFFF\x1"+
				"\x20\x1\x21",
				"\x1\x30\x6\xFFFF\x1\x31\x2\xFFFF\x1\x2F",
				"\x1\x32\xD\xFFFF\x1\x33\x5\xFFFF\x1\x34",
				"\x1\x35\x3\xFFFF\x1\x36",
				"\x1\x38\xB\xFFFF\x1\x37",
				"\x1\x39\x7\xFFFF\x1\x3A",
				"\x1\x3B\x1\xFFFF\x1\x3C",
				"\x1\x3D\x5\xFFFF\x1\x3E",
				"\x1\x3F",
				"\x1\x40\x9\xFFFF\x1\x41",
				"\x1\x42",
				"\x1\x43",
				"\x1\x44\x6\xFFFF\x1\x45",
				"\x1\x47\x9\xFFFF\x1\x46",
				"\x1\x48",
				"\x1\x49",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x4A",
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
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\x1\x4E\x4\xFFFF\x1\x4D",
				"",
				"",
				"",
				"",
				"",
				"\x1\x50",
				"\x1\x52\x1\x53",
				"",
				"\x1\x55",
				"\x1\x56",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x58",
				"\x1\x59",
				"\x1\x5A",
				"\x1\x5B",
				"\x1\x5C",
				"\x1\x5D",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x61\x3\xFFFF\x1\x60",
				"\x1\x62",
				"\x1\x63",
				"\x1\x64",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x16\x28\x1\x65\x3"+
				"\x28",
				"\x1\x67",
				"\x1\x68",
				"\x1\x69",
				"\x1\x6B\xE\xFFFF\x1\x6A",
				"\x1\x6C",
				"\x1\x6D",
				"\x1\x6E",
				"\x1\x6F",
				"\x1\x70",
				"\x1\x71",
				"\x1\x72",
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
				"\x1\x73",
				"\x1\x74",
				"",
				"\x1\x75",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x77",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x79",
				"",
				"",
				"",
				"\x1\x7A",
				"\x1\x7B",
				"\x1\x7C\x3\xFFFF\x1\x7D",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x80",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x82",
				"\x1\x83",
				"\x1\x84",
				"\x1\x85",
				"\x1\x86",
				"\x1\x87",
				"\x1\x88",
				"\x1\x89",
				"\x1\x8A",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x8C",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x8F",
				"",
				"\x1\x90",
				"",
				"\x1\x91",
				"\x1\x92",
				"\x1\x93",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x95",
				"",
				"",
				"\x1\x96",
				"",
				"\x1\x97",
				"\x1\x98",
				"\x1\x99",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x9B",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\x9D",
				"\x1\x9E",
				"\x1\x9F",
				"",
				"\x1\xA0",
				"",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xA2",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xA4",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xA7",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\xB\x28\x1\xA9\xE"+
				"\x28",
				"\x1\xAB",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xAE",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xB0",
				"",
				"\x1\xB1",
				"",
				"\x1\xB2",
				"",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\x1\xB4",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"",
				"\x1\xB6",
				"",
				"\x1\xB7",
				"\x1\xB8",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"\x1\xBC",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				"",
				"",
				"",
				"\x1\xBE",
				"",
				"\xA\x28\x7\xFFFF\x1A\x28\x4\xFFFF\x1\x28\x1\xFFFF\x1A\x28",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( TRUE | FALSE | AND | OR | IF | THEN | ELSE | ELSIF | DIV | MOD | FOR | TO | DOWNTO | DO | WHILE | REPEAT | UNTIL | INT | REAL | CHAR | BOOL | VAR | BEGIN | END | WRITE | WRITELN | INPUT | ARRAY | OF | CONST_ | FUNC | PROC | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | WS | SL_COMMENT | ML_COMMENT | NUMBER | IDENT | ADD | SUB | MUL | DIVIDE | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
