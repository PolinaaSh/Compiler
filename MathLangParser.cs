// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-01-05 15:11:52

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TRUE", "FALSE", "AND", "OR", "UNKNOWN", "SCOPEBLOCK", "BLOCK", "PROGRAM", "CONVERT", "INDEX", "IF", "THEN", "ELSE", "ELSIF", "DIV", "MOD", "FOR", "TO", "DOWNTO", "DO", "WHILE", "REPEAT", "UNTIL", "INT", "REAL", "CHAR", "BOOL", "CALL", "PARAMS", "VAR", "BEGIN", "END", "PRINT", "RINTSTR", "INPUT", "ARRAY", "OF", "CONST_", "FUNC", "PROC", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIDE", "ASSIGN", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "PRINTSTR", "'('", "')'", "'['", "']'", "'!'", "'?'", "'@'", "':'", "';'", "'#'", "'$'", "'%'", "'^'", "'&'", "'{'", "'}'", "'~'", "'.'", "','", "'_'", "'\\''"
	};
	public const int EOF=-1;
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
	public const int T__81=81;
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
	public const int PRINT=36;
	public const int RINTSTR=37;
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
	public const int PRINTSTR=60;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, true, true, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, true, false, true, false, 
				false, false, false, false, false, true, true, false, false, false, 
				false, false, true, false, false, false, , , , , , , , , , , , , , , 
				, , 
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:96:1: group : ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken NUMBER5=null;
		IToken IDENT6=null;
		IToken IDENT7=null;
		IToken char_literal8=null;
		IToken char_literal10=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);
		MathLangParser.logic_value_return logic_value4 = default(MathLangParser.logic_value_return);
		MathLangParser.index__return index_9 = default(MathLangParser.index__return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER5_tree=null;
		object IDENT6_tree=null;
		object IDENT7_tree=null;
		object char_literal8_tree=null;
		object char_literal10_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(96, 0);
		try
		{
			// MathLang.g:96:6: ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 61:
				{
				alt1=1;
				}
				break;
			case TRUE:
			case FALSE:
				{
				alt1=2;
				}
				break;
			case NUMBER:
				{
				alt1=3;
				}
				break;
			case IDENT:
				{
				int LA1_4 = input.LA(2);

				if ((LA1_4==63))
				{
					alt1=5;
				}
				else if ((LA1_4==EOF||(LA1_4>=AND && LA1_4<=OR)||(LA1_4>=IF && LA1_4<=TO)||(LA1_4>=DO && LA1_4<=UNTIL)||(LA1_4>=BEGIN && LA1_4<=PRINT)||(LA1_4>=FUNC && LA1_4<=PROC)||(LA1_4>=IDENT && LA1_4<=DIVIDE)||(LA1_4>=GE && LA1_4<=PRINTSTR)||LA1_4==62||LA1_4==64||LA1_4==69||(LA1_4>=78 && LA1_4<=79)))
				{
					alt1=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 4, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:97:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 6);
				char_literal1=(IToken)Match(input,61,Follow._61_in_group1058); if (state.failed) return retval;
				DebugLocation(97, 8);
				PushFollow(Follow._term_in_group1061);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(97, 16);
				char_literal3=(IToken)Match(input,62,Follow._62_in_group1063); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:98:3: logic_value
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(98, 3);
				PushFollow(Follow._logic_value_in_group1068);
				logic_value4=logic_value();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_value4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:99:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 3);
				NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group1072); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER5_tree = (object)adaptor.Create(NUMBER5);
				adaptor.AddChild(root_0, NUMBER5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:100:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(100, 3);
				IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_group1076); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT6_tree = (object)adaptor.Create(IDENT6);
				adaptor.AddChild(root_0, IDENT6_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:101:3: ( IDENT '[' index_ ']' )
				{
				DebugLocation(101, 3);
				// MathLang.g:101:3: ( IDENT '[' index_ ']' )
				DebugEnterAlt(1);
				// MathLang.g:101:4: IDENT '[' index_ ']'
				{
				DebugLocation(101, 4);
				IDENT7=(IToken)Match(input,IDENT,Follow._IDENT_in_group1081); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT7);

				DebugLocation(101, 10);
				char_literal8=(IToken)Match(input,63,Follow._63_in_group1083); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal8);

				DebugLocation(101, 14);
				PushFollow(Follow._index__in_group1085);
				index_9=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_9.Tree);
				DebugLocation(101, 20);
				char_literal10=(IToken)Match(input,64,Follow._64_in_group1086); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal10);


				}



				{
				// AST REWRITE
				// elements: IDENT, index_
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 101:25: -> ^( IDENT ^( INDEX index_ ) )
				{
					DebugLocation(101, 27);
					// MathLang.g:101:27: ^( IDENT ^( INDEX index_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(101, 29);
					root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

					DebugLocation(101, 35);
					// MathLang.g:101:35: ^( INDEX index_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(101, 37);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_2);

					DebugLocation(101, 43);
					adaptor.AddChild(root_2, stream_index_.NextTree());

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
		}
		DebugLocation(102, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:104:1: mult : group ( ( MUL | DIVIDE ) group )* ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 2);
		TraceIn("mult", 2);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set12=null;
		MathLangParser.group_return group11 = default(MathLangParser.group_return);
		MathLangParser.group_return group13 = default(MathLangParser.group_return);

		object set12_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(104, 42);
		try
		{
			// MathLang.g:104:5: ( group ( ( MUL | DIVIDE ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:104:7: group ( ( MUL | DIVIDE ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 7);
			PushFollow(Follow._group_in_mult1106);
			group11=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);
			DebugLocation(104, 13);
			// MathLang.g:104:13: ( ( MUL | DIVIDE ) group )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=MUL && LA2_0<=DIVIDE)))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:104:15: ( MUL | DIVIDE ) group
					{
					DebugLocation(104, 15);
					set12=(IToken)input.LT(1);
					set12=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIVIDE))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set12), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(104, 33);
					PushFollow(Follow._group_in_mult1121);
					group13=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group13.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 2);
			LeaveRule("mult", 2);
			Leave_mult();
		}
		DebugLocation(104, 42);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:105:1: add : mult ( ( ADD | SUB ) mult )* ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 3);
		TraceIn("add", 3);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set15=null;
		MathLangParser.mult_return mult14 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult16 = default(MathLangParser.mult_return);

		object set15_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(105, 39);
		try
		{
			// MathLang.g:105:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:105:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 7);
			PushFollow(Follow._mult_in_add1133);
			mult14=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);
			DebugLocation(105, 13);
			// MathLang.g:105:13: ( ( ADD | SUB ) mult )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=ADD && LA3_0<=SUB)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:105:15: ( ADD | SUB ) mult
					{
					DebugLocation(105, 15);
					set15=(IToken)input.LT(1);
					set15=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set15), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(105, 30);
					PushFollow(Follow._mult_in_add1149);
					mult16=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult16.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 3);
			LeaveRule("add", 3);
			Leave_add();
		}
		DebugLocation(105, 39);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:106:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 4);
		TraceIn("compare", 4);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set18=null;
		MathLangParser.add_return add17 = default(MathLangParser.add_return);
		MathLangParser.add_return add19 = default(MathLangParser.add_return);

		object set18_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(106, 61);
		try
		{
			// MathLang.g:106:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:106:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 10);
			PushFollow(Follow._add_in_compare1161);
			add17=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
			DebugLocation(106, 14);
			// MathLang.g:106:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			int alt4=2;
			try { DebugEnterSubRule(4);
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if (((LA4_0>=GE && LA4_0<=LT)))
			{
				alt4=1;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:106:15: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(106, 15);
				set18=(IToken)input.LT(1);
				set18=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set18), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(106, 57);
				PushFollow(Follow._add_in_compare1191);
				add19=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add19.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 4);
			LeaveRule("compare", 4);
			Leave_compare();
		}
		DebugLocation(106, 61);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class div_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_div();
	partial void Leave_div();

	// $ANTLR start "div"
	// MathLang.g:107:1: div : compare ( ( DIV | MOD ) compare )* ;
	[GrammarRule("div")]
	private MathLangParser.div_return div()
	{
		Enter_div();
		EnterRule("div", 5);
		TraceIn("div", 5);
		MathLangParser.div_return retval = new MathLangParser.div_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set21=null;
		MathLangParser.compare_return compare20 = default(MathLangParser.compare_return);
		MathLangParser.compare_return compare22 = default(MathLangParser.compare_return);

		object set21_tree=null;

		try { DebugEnterRule(GrammarFileName, "div");
		DebugLocation(107, 35);
		try
		{
			// MathLang.g:107:4: ( compare ( ( DIV | MOD ) compare )* )
			DebugEnterAlt(1);
			// MathLang.g:107:6: compare ( ( DIV | MOD ) compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 6);
			PushFollow(Follow._compare_in_div1199);
			compare20=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare20.Tree);
			DebugLocation(107, 13);
			// MathLang.g:107:13: ( ( DIV | MOD ) compare )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>=DIV && LA5_0<=MOD)))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:107:14: ( DIV | MOD ) compare
					{
					DebugLocation(107, 14);
					set21=(IToken)input.LT(1);
					set21=(IToken)input.LT(1);
					if ((input.LA(1)>=DIV && input.LA(1)<=MOD))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set21), root_0);
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(107, 27);
					PushFollow(Follow._compare_in_div1210);
					compare22=compare();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare22.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("div", 5);
			LeaveRule("div", 5);
			Leave_div();
		}
		DebugLocation(107, 35);
		} finally { DebugExitRule(GrammarFileName, "div"); }
		return retval;

	}
	// $ANTLR end "div"

	public class and_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_and_logic();
	partial void Leave_and_logic();

	// $ANTLR start "and_logic"
	// MathLang.g:108:1: and_logic : div ( AND div )* ;
	[GrammarRule("and_logic")]
	private MathLangParser.and_logic_return and_logic()
	{
		Enter_and_logic();
		EnterRule("and_logic", 6);
		TraceIn("and_logic", 6);
		MathLangParser.and_logic_return retval = new MathLangParser.and_logic_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken AND24=null;
		MathLangParser.div_return div23 = default(MathLangParser.div_return);
		MathLangParser.div_return div25 = default(MathLangParser.div_return);

		object AND24_tree=null;

		try { DebugEnterRule(GrammarFileName, "and_logic");
		DebugLocation(108, 25);
		try
		{
			// MathLang.g:108:10: ( div ( AND div )* )
			DebugEnterAlt(1);
			// MathLang.g:108:11: div ( AND div )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 11);
			PushFollow(Follow._div_in_and_logic1217);
			div23=div();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div23.Tree);
			DebugLocation(108, 15);
			// MathLang.g:108:15: ( AND div )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==AND))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:108:16: AND div
					{
					DebugLocation(108, 19);
					AND24=(IToken)Match(input,AND,Follow._AND_in_and_logic1220); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND24_tree = (object)adaptor.Create(AND24);
					root_0 = (object)adaptor.BecomeRoot(AND24_tree, root_0);
					}
					DebugLocation(108, 21);
					PushFollow(Follow._div_in_and_logic1223);
					div25=div();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div25.Tree);

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("and_logic", 6);
			LeaveRule("and_logic", 6);
			Leave_and_logic();
		}
		DebugLocation(108, 25);
		} finally { DebugExitRule(GrammarFileName, "and_logic"); }
		return retval;

	}
	// $ANTLR end "and_logic"

	public class or_logic_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_or_logic();
	partial void Leave_or_logic();

	// $ANTLR start "or_logic"
	// MathLang.g:109:1: or_logic : and_logic ( OR and_logic )* ;
	[GrammarRule("or_logic")]
	private MathLangParser.or_logic_return or_logic()
	{
		Enter_or_logic();
		EnterRule("or_logic", 7);
		TraceIn("or_logic", 7);
		MathLangParser.or_logic_return retval = new MathLangParser.or_logic_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken OR27=null;
		MathLangParser.and_logic_return and_logic26 = default(MathLangParser.and_logic_return);
		MathLangParser.and_logic_return and_logic28 = default(MathLangParser.and_logic_return);

		object OR27_tree=null;

		try { DebugEnterRule(GrammarFileName, "or_logic");
		DebugLocation(109, 36);
		try
		{
			// MathLang.g:109:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:109:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 11);
			PushFollow(Follow._and_logic_in_or_logic1231);
			and_logic26=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic26.Tree);
			DebugLocation(109, 21);
			// MathLang.g:109:21: ( OR and_logic )*
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, decisionCanBacktrack[7]);
				int LA7_0 = input.LA(1);

				if ((LA7_0==OR))
				{
					alt7=1;
				}


				} finally { DebugExitDecision(7); }
				switch ( alt7 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:109:22: OR and_logic
					{
					DebugLocation(109, 24);
					OR27=(IToken)Match(input,OR,Follow._OR_in_or_logic1234); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR27_tree = (object)adaptor.Create(OR27);
					root_0 = (object)adaptor.BecomeRoot(OR27_tree, root_0);
					}
					DebugLocation(109, 26);
					PushFollow(Follow._and_logic_in_or_logic1237);
					and_logic28=and_logic();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic28.Tree);

					}
					break;

				default:
					goto loop7;
				}
			}

			loop7:
				;

			} finally { DebugExitSubRule(7); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("or_logic", 7);
			LeaveRule("or_logic", 7);
			Leave_or_logic();
		}
		DebugLocation(109, 36);
		} finally { DebugExitRule(GrammarFileName, "or_logic"); }
		return retval;

	}
	// $ANTLR end "or_logic"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:110:1: term : or_logic ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 8);
		TraceIn("term", 8);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.or_logic_return or_logic29 = default(MathLangParser.or_logic_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(110, 14);
		try
		{
			// MathLang.g:110:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:110:7: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 7);
			PushFollow(Follow._or_logic_in_term1245);
			or_logic29=or_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic29.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 8);
			LeaveRule("term", 8);
			Leave_term();
		}
		DebugLocation(110, 14);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class logic_value_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logic_value();
	partial void Leave_logic_value();

	// $ANTLR start "logic_value"
	// MathLang.g:112:1: logic_value : ( TRUE | FALSE );
	[GrammarRule("logic_value")]
	private MathLangParser.logic_value_return logic_value()
	{
		Enter_logic_value();
		EnterRule("logic_value", 9);
		TraceIn("logic_value", 9);
		MathLangParser.logic_value_return retval = new MathLangParser.logic_value_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set30=null;

		object set30_tree=null;

		try { DebugEnterRule(GrammarFileName, "logic_value");
		DebugLocation(112, 24);
		try
		{
			// MathLang.g:112:12: ( TRUE | FALSE )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 12);
			set30=(IToken)input.LT(1);
			if ((input.LA(1)>=TRUE && input.LA(1)<=FALSE))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set30));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logic_value", 9);
			LeaveRule("logic_value", 9);
			Leave_logic_value();
		}
		DebugLocation(112, 24);
		} finally { DebugExitRule(GrammarFileName, "logic_value"); }
		return retval;

	}
	// $ANTLR end "logic_value"

	public class type_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type();
	partial void Leave_type();

	// $ANTLR start "type"
	// MathLang.g:114:1: type : ( INT | REAL | BOOL | CHAR );
	[GrammarRule("type")]
	private MathLangParser.type_return type()
	{
		Enter_type();
		EnterRule("type", 10);
		TraceIn("type", 10);
		MathLangParser.type_return retval = new MathLangParser.type_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set31=null;

		object set31_tree=null;

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(114, 0);
		try
		{
			// MathLang.g:114:5: ( INT | REAL | BOOL | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 5);
			set31=(IToken)input.LT(1);
			if ((input.LA(1)>=INT && input.LA(1)<=BOOL))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set31));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type", 10);
			LeaveRule("type", 10);
			Leave_type();
		}
		DebugLocation(115, 0);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"

	public class index__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_index_();
	partial void Leave_index_();

	// $ANTLR start "index_"
	// MathLang.g:117:1: index_ : term ;
	[GrammarRule("index_")]
	private MathLangParser.index__return index_()
	{
		Enter_index_();
		EnterRule("index_", 11);
		TraceIn("index_", 11);
		MathLangParser.index__return retval = new MathLangParser.index__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.term_return term32 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "index_");
		DebugLocation(117, 0);
		try
		{
			// MathLang.g:117:7: ( term )
			DebugEnterAlt(1);
			// MathLang.g:117:9: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(117, 9);
			PushFollow(Follow._term_in_index_1282);
			term32=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term32.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("index_", 11);
			LeaveRule("index_", 11);
			Leave_index_();
		}
		DebugLocation(118, 0);
		} finally { DebugExitRule(GrammarFileName, "index_"); }
		return retval;

	}
	// $ANTLR end "index_"

	public class charValue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_charValue();
	partial void Leave_charValue();

	// $ANTLR start "charValue"
	// MathLang.g:121:1: charValue : ( '+' | '-' | '*' | '/' | '!' | '?' | '@' | '<' | '>' | ':' | ';' | '#' | '$' | '%' | '^' | '&' | '(' | ')' | '{' | '}' | '[' | ']' | '~' | '.' | ',' | '_' );
	[GrammarRule("charValue")]
	private MathLangParser.charValue_return charValue()
	{
		Enter_charValue();
		EnterRule("charValue", 12);
		TraceIn("charValue", 12);
		MathLangParser.charValue_return retval = new MathLangParser.charValue_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set33=null;

		object set33_tree=null;

		try { DebugEnterRule(GrammarFileName, "charValue");
		DebugLocation(121, 0);
		try
		{
			// MathLang.g:121:10: ( '+' | '-' | '*' | '/' | '!' | '?' | '@' | '<' | '>' | ':' | ';' | '#' | '$' | '%' | '^' | '&' | '(' | ')' | '{' | '}' | '[' | ']' | '~' | '.' | ',' | '_' )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(121, 10);
			set33=(IToken)input.LT(1);
			if ((input.LA(1)>=ADD && input.LA(1)<=DIVIDE)||(input.LA(1)>=GT && input.LA(1)<=LT)||(input.LA(1)>=61 && input.LA(1)<=80))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set33));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("charValue", 12);
			LeaveRule("charValue", 12);
			Leave_charValue();
		}
		DebugLocation(123, 0);
		} finally { DebugExitRule(GrammarFileName, "charValue"); }
		return retval;

	}
	// $ANTLR end "charValue"

	public class simpleExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_simpleExpr();
	partial void Leave_simpleExpr();

	// $ANTLR start "simpleExpr"
	// MathLang.g:125:1: simpleExpr : ( IDENT ASSIGN term | IDENT ASSIGN '\\'' charValue '\\'' | PRINT term | PRINTSTR term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call );
	[GrammarRule("simpleExpr")]
	private MathLangParser.simpleExpr_return simpleExpr()
	{
		Enter_simpleExpr();
		EnterRule("simpleExpr", 13);
		TraceIn("simpleExpr", 13);
		MathLangParser.simpleExpr_return retval = new MathLangParser.simpleExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT34=null;
		IToken ASSIGN35=null;
		IToken IDENT37=null;
		IToken ASSIGN38=null;
		IToken char_literal39=null;
		IToken char_literal41=null;
		IToken PRINT42=null;
		IToken PRINTSTR44=null;
		IToken IDENT46=null;
		IToken char_literal47=null;
		IToken char_literal49=null;
		IToken ASSIGN50=null;
		MathLangParser.term_return term36 = default(MathLangParser.term_return);
		MathLangParser.charValue_return charValue40 = default(MathLangParser.charValue_return);
		MathLangParser.term_return term43 = default(MathLangParser.term_return);
		MathLangParser.term_return term45 = default(MathLangParser.term_return);
		MathLangParser.index__return index_48 = default(MathLangParser.index__return);
		MathLangParser.term_return term51 = default(MathLangParser.term_return);
		MathLangParser.call_return call52 = default(MathLangParser.call_return);

		object IDENT34_tree=null;
		object ASSIGN35_tree=null;
		object IDENT37_tree=null;
		object ASSIGN38_tree=null;
		object char_literal39_tree=null;
		object char_literal41_tree=null;
		object PRINT42_tree=null;
		object PRINTSTR44_tree=null;
		object IDENT46_tree=null;
		object char_literal47_tree=null;
		object char_literal49_tree=null;
		object ASSIGN50_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(125, 0);
		try
		{
			// MathLang.g:125:11: ( IDENT ASSIGN term | IDENT ASSIGN '\\'' charValue '\\'' | PRINT term | PRINTSTR term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call )
			int alt8=6;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			try
			{
				alt8 = dfa8.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:126:2: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 2);
				IDENT34=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1352); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT34_tree = (object)adaptor.Create(IDENT34);
				adaptor.AddChild(root_0, IDENT34_tree);
				}
				DebugLocation(126, 14);
				ASSIGN35=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1354); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN35_tree = (object)adaptor.Create(ASSIGN35);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN35_tree, root_0);
				}
				DebugLocation(126, 16);
				PushFollow(Follow._term_in_simpleExpr1357);
				term36=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term36.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:127:3: IDENT ASSIGN '\\'' charValue '\\''
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 3);
				IDENT37=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1361); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT37_tree = (object)adaptor.Create(IDENT37);
				adaptor.AddChild(root_0, IDENT37_tree);
				}
				DebugLocation(127, 15);
				ASSIGN38=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1363); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN38_tree = (object)adaptor.Create(ASSIGN38);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN38_tree, root_0);
				}
				DebugLocation(127, 17);
				char_literal39=(IToken)Match(input,81,Follow._81_in_simpleExpr1366); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal39_tree = (object)adaptor.Create(char_literal39);
				adaptor.AddChild(root_0, char_literal39_tree);
				}
				DebugLocation(127, 22);
				PushFollow(Follow._charValue_in_simpleExpr1368);
				charValue40=charValue();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, charValue40.Tree);
				DebugLocation(127, 32);
				char_literal41=(IToken)Match(input,81,Follow._81_in_simpleExpr1370); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal41_tree = (object)adaptor.Create(char_literal41);
				adaptor.AddChild(root_0, char_literal41_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:128:3: PRINT term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 8);
				PRINT42=(IToken)Match(input,PRINT,Follow._PRINT_in_simpleExpr1374); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINT42_tree = (object)adaptor.Create(PRINT42);
				root_0 = (object)adaptor.BecomeRoot(PRINT42_tree, root_0);
				}
				DebugLocation(128, 10);
				PushFollow(Follow._term_in_simpleExpr1377);
				term43=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term43.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:129:3: PRINTSTR term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 11);
				PRINTSTR44=(IToken)Match(input,PRINTSTR,Follow._PRINTSTR_in_simpleExpr1381); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINTSTR44_tree = (object)adaptor.Create(PRINTSTR44);
				root_0 = (object)adaptor.BecomeRoot(PRINTSTR44_tree, root_0);
				}
				DebugLocation(129, 13);
				PushFollow(Follow._term_in_simpleExpr1384);
				term45=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term45.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:130:2: ( IDENT '[' index_ ']' ASSIGN term )
				{
				DebugLocation(130, 2);
				// MathLang.g:130:2: ( IDENT '[' index_ ']' ASSIGN term )
				DebugEnterAlt(1);
				// MathLang.g:130:4: IDENT '[' index_ ']' ASSIGN term
				{
				DebugLocation(130, 4);
				IDENT46=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1389); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT46);

				DebugLocation(130, 10);
				char_literal47=(IToken)Match(input,63,Follow._63_in_simpleExpr1391); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal47);

				DebugLocation(130, 14);
				PushFollow(Follow._index__in_simpleExpr1393);
				index_48=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_48.Tree);
				DebugLocation(130, 20);
				char_literal49=(IToken)Match(input,64,Follow._64_in_simpleExpr1394); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal49);

				DebugLocation(130, 24);
				ASSIGN50=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1396); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN50);

				DebugLocation(130, 31);
				PushFollow(Follow._term_in_simpleExpr1398);
				term51=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(term51.Tree);

				}



				{
				// AST REWRITE
				// elements: index_, term, IDENT, ASSIGN
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 130:36: -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term )
				{
					DebugLocation(130, 39);
					// MathLang.g:130:39: ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(130, 41);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(130, 48);
					// MathLang.g:130:48: ^( IDENT ^( INDEX index_ ) )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(130, 51);
					root_2 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_2);

					DebugLocation(130, 57);
					// MathLang.g:130:57: ^( INDEX index_ )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(130, 59);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_3);

					DebugLocation(130, 66);
					adaptor.AddChild(root_3, stream_index_.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(130, 76);
					adaptor.AddChild(root_1, stream_term.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:131:3: call
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 3);
				PushFollow(Follow._call_in_simpleExpr1423);
				call52=call();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call52.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("simpleExpr", 13);
			LeaveRule("simpleExpr", 13);
			Leave_simpleExpr();
		}
		DebugLocation(132, 0);
		} finally { DebugExitRule(GrammarFileName, "simpleExpr"); }
		return retval;

	}
	// $ANTLR end "simpleExpr"

	public class groupExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_groupExpr();
	partial void Leave_groupExpr();

	// $ANTLR start "groupExpr"
	// MathLang.g:134:1: groupExpr : ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl );
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 14);
		TraceIn("groupExpr", 14);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF53=null;
		IToken char_literal54=null;
		IToken char_literal55=null;
		IToken THEN56=null;
		IToken ELSIF57=null;
		IToken THEN58=null;
		IToken ELSE59=null;
		IToken FOR60=null;
		IToken IDENT61=null;
		IToken ASSIGN62=null;
		IToken TO63=null;
		IToken DO64=null;
		IToken WHILE66=null;
		IToken char_literal67=null;
		IToken char_literal69=null;
		IToken DO70=null;
		IToken REPEAT72=null;
		IToken UNTIL74=null;
		IToken BEGIN76=null;
		IToken END78=null;
		IToken char_literal79=null;
		MathLangParser.term_return t1 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst = default(MathLangParser.exprList_return);
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList65 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term68 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList71 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList73 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term75 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList77 = default(MathLangParser.exprList_return);
		MathLangParser.func_decl_return func_decl80 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl81 = default(MathLangParser.proc_decl_return);

		object IF53_tree=null;
		object char_literal54_tree=null;
		object char_literal55_tree=null;
		object THEN56_tree=null;
		object ELSIF57_tree=null;
		object THEN58_tree=null;
		object ELSE59_tree=null;
		object FOR60_tree=null;
		object IDENT61_tree=null;
		object ASSIGN62_tree=null;
		object TO63_tree=null;
		object DO64_tree=null;
		object WHILE66_tree=null;
		object char_literal67_tree=null;
		object char_literal69_tree=null;
		object DO70_tree=null;
		object REPEAT72_tree=null;
		object UNTIL74_tree=null;
		object BEGIN76_tree=null;
		object END78_tree=null;
		object char_literal79_tree=null;
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_THEN=new RewriteRuleITokenStream(adaptor,"token THEN");
		RewriteRuleITokenStream stream_TO=new RewriteRuleITokenStream(adaptor,"token TO");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleITokenStream stream_ELSE=new RewriteRuleITokenStream(adaptor,"token ELSE");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_ELSIF=new RewriteRuleITokenStream(adaptor,"token ELSIF");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(134, 0);
		try
		{
			// MathLang.g:134:10: ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl )
			int alt13=7;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			switch (input.LA(1))
			{
			case IF:
				{
				alt13=1;
				}
				break;
			case FOR:
				{
				alt13=2;
				}
				break;
			case WHILE:
				{
				alt13=3;
				}
				break;
			case REPEAT:
				{
				alt13=4;
				}
				break;
			case BEGIN:
				{
				alt13=5;
				}
				break;
			case FUNC:
				{
				alt13=6;
				}
				break;
			case PROC:
				{
				alt13=7;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:135:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				{
				DebugLocation(135, 2);
				// MathLang.g:135:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				DebugEnterAlt(1);
				// MathLang.g:135:4: IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )?
				{
				DebugLocation(135, 4);
				IF53=(IToken)Match(input,IF,Follow._IF_in_groupExpr1434); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IF.Add(IF53);

				DebugLocation(135, 7);
				char_literal54=(IToken)Match(input,61,Follow._61_in_groupExpr1436); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal54);

				DebugLocation(135, 13);
				PushFollow(Follow._term_in_groupExpr1440);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(135, 19);
				char_literal55=(IToken)Match(input,62,Follow._62_in_groupExpr1442); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal55);

				DebugLocation(135, 23);
				THEN56=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1444); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_THEN.Add(THEN56);

				DebugLocation(135, 31);
				PushFollow(Follow._exprList_in_groupExpr1448);
				lst=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(lst.Tree);
				DebugLocation(135, 41);
				// MathLang.g:135:41: ( ELSIF t2= term THEN lst2= exprList )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==ELSIF))
					{
						int LA9_2 = input.LA(2);

						if ((EvaluatePredicate(synpred53_MathLang_fragment)))
						{
							alt9=1;
						}


					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:135:42: ELSIF t2= term THEN lst2= exprList
						{
						DebugLocation(135, 42);
						ELSIF57=(IToken)Match(input,ELSIF,Follow._ELSIF_in_groupExpr1451); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_ELSIF.Add(ELSIF57);

						DebugLocation(135, 50);
						PushFollow(Follow._term_in_groupExpr1455);
						t2=term();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
						DebugLocation(135, 56);
						THEN58=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1457); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_THEN.Add(THEN58);

						DebugLocation(135, 65);
						PushFollow(Follow._exprList_in_groupExpr1461);
						lst2=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_exprList.Add(lst2.Tree);

						}
						break;

					default:
						goto loop9;
					}
				}

				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(135, 77);
				// MathLang.g:135:77: ( ELSE lst3= exprList )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==ELSE))
				{
					int LA10_1 = input.LA(2);

					if ((EvaluatePredicate(synpred54_MathLang_fragment)))
					{
						alt10=1;
					}
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:135:78: ELSE lst3= exprList
					{
					DebugLocation(135, 78);
					ELSE59=(IToken)Match(input,ELSE,Follow._ELSE_in_groupExpr1466); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE59);

					DebugLocation(135, 87);
					PushFollow(Follow._exprList_in_groupExpr1470);
					lst3=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_exprList.Add(lst3.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(10); }


				}



				{
				// AST REWRITE
				// elements: lst2, IF, lst3, t2, ELSIF, ELSE, lst, t1
				// token labels: 
				// rule labels: lst3, t2, retval, t1, lst2, lst
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_lst3=new RewriteRuleSubtreeStream(adaptor,"rule lst3",lst3!=null?lst3.Tree:null);
				RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);
				RewriteRuleSubtreeStream stream_lst2=new RewriteRuleSubtreeStream(adaptor,"rule lst2",lst2!=null?lst2.Tree:null);
				RewriteRuleSubtreeStream stream_lst=new RewriteRuleSubtreeStream(adaptor,"rule lst",lst!=null?lst.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 135:99: -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
				{
					DebugLocation(135, 101);
					// MathLang.g:135:101: ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(135, 103);
					root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

					DebugLocation(135, 106);
					adaptor.AddChild(root_1, stream_t1.NextTree());
					DebugLocation(135, 110);
					adaptor.AddChild(root_1, stream_lst.NextTree());
					DebugLocation(135, 115);
					// MathLang.g:135:115: ( ^( ELSIF $t2 $lst2) )*
					while ( stream_lst2.HasNext||stream_t2.HasNext||stream_ELSIF.HasNext )
					{
						DebugLocation(135, 116);
						// MathLang.g:135:116: ^( ELSIF $t2 $lst2)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(135, 118);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSIF.NextNode(), root_2);

						DebugLocation(135, 124);
						adaptor.AddChild(root_2, stream_t2.NextTree());
						DebugLocation(135, 128);
						adaptor.AddChild(root_2, stream_lst2.NextTree());

						adaptor.AddChild(root_1, root_2);
						}

					}
					stream_lst2.Reset();
					stream_t2.Reset();
					stream_ELSIF.Reset();
					DebugLocation(135, 137);
					// MathLang.g:135:137: ( ^( ELSE $lst3) )?
					if ( stream_lst3.HasNext||stream_ELSE.HasNext )
					{
						DebugLocation(135, 138);
						// MathLang.g:135:138: ^( ELSE $lst3)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(135, 140);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_2);

						DebugLocation(135, 145);
						adaptor.AddChild(root_2, stream_lst3.NextTree());

						adaptor.AddChild(root_1, root_2);
						}

					}
					stream_lst3.Reset();
					stream_ELSE.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:136:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				{
				DebugLocation(136, 2);
				// MathLang.g:136:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				DebugEnterAlt(1);
				// MathLang.g:136:4: FOR IDENT ASSIGN t1= term TO t2= term DO exprList
				{
				DebugLocation(136, 4);
				FOR60=(IToken)Match(input,FOR,Follow._FOR_in_groupExpr1511); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR60);

				DebugLocation(136, 8);
				IDENT61=(IToken)Match(input,IDENT,Follow._IDENT_in_groupExpr1513); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT61);

				DebugLocation(136, 14);
				ASSIGN62=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_groupExpr1515); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN62);

				DebugLocation(136, 23);
				PushFollow(Follow._term_in_groupExpr1519);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(136, 29);
				TO63=(IToken)Match(input,TO,Follow._TO_in_groupExpr1521); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TO.Add(TO63);

				DebugLocation(136, 34);
				PushFollow(Follow._term_in_groupExpr1525);
				t2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
				DebugLocation(136, 40);
				DO64=(IToken)Match(input,DO,Follow._DO_in_groupExpr1527); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DO.Add(DO64);

				DebugLocation(136, 43);
				PushFollow(Follow._exprList_in_groupExpr1529);
				exprList65=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(exprList65.Tree);

				}



				{
				// AST REWRITE
				// elements: FOR, t1, ASSIGN, IDENT, IDENT, exprList, t2
				// token labels: 
				// rule labels: t2, retval, t1
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
				RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 136:52: -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList )
				{
					DebugLocation(136, 54);
					// MathLang.g:136:54: ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(136, 56);
					root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

					DebugLocation(136, 60);
					// MathLang.g:136:60: ^( ASSIGN IDENT $t1)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(136, 62);
					root_2 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

					DebugLocation(136, 69);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(136, 75);
					adaptor.AddChild(root_2, stream_t1.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(136, 80);
					// MathLang.g:136:80: ^( LT IDENT $t2)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(136, 82);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LT, "LT"), root_2);

					DebugLocation(136, 85);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(136, 91);
					adaptor.AddChild(root_2, stream_t2.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(136, 96);
					adaptor.AddChild(root_1, stream_exprList.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:137:3: WHILE '(' term ')' DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(137, 8);
				WHILE66=(IToken)Match(input,WHILE,Follow._WHILE_in_groupExpr1558); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE66_tree = (object)adaptor.Create(WHILE66);
				root_0 = (object)adaptor.BecomeRoot(WHILE66_tree, root_0);
				}
				DebugLocation(137, 13);
				char_literal67=(IToken)Match(input,61,Follow._61_in_groupExpr1561); if (state.failed) return retval;
				DebugLocation(137, 14);
				PushFollow(Follow._term_in_groupExpr1563);
				term68=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term68.Tree);
				DebugLocation(137, 21);
				char_literal69=(IToken)Match(input,62,Follow._62_in_groupExpr1564); if (state.failed) return retval;
				DebugLocation(137, 25);
				DO70=(IToken)Match(input,DO,Follow._DO_in_groupExpr1567); if (state.failed) return retval;
				DebugLocation(137, 27);
				PushFollow(Follow._exprList_in_groupExpr1570);
				exprList71=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList71.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:138:3: REPEAT ( exprList )+ UNTIL term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(138, 9);
				REPEAT72=(IToken)Match(input,REPEAT,Follow._REPEAT_in_groupExpr1574); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				REPEAT72_tree = (object)adaptor.Create(REPEAT72);
				root_0 = (object)adaptor.BecomeRoot(REPEAT72_tree, root_0);
				}
				DebugLocation(138, 11);
				// MathLang.g:138:11: ( exprList )+
				int cnt11=0;
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==IF||LA11_0==FOR||(LA11_0>=WHILE && LA11_0<=REPEAT)||LA11_0==BEGIN||LA11_0==PRINT||(LA11_0>=FUNC && LA11_0<=PROC)||LA11_0==IDENT||LA11_0==PRINTSTR))
					{
						alt11=1;
					}


					} finally { DebugExitDecision(11); }
					switch (alt11)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: exprList
						{
						DebugLocation(138, 11);
						PushFollow(Follow._exprList_in_groupExpr1577);
						exprList73=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList73.Tree);

						}
						break;

					default:
						if (cnt11 >= 1)
							goto loop11;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee11 = new EarlyExitException( 11, input );
						DebugRecognitionException(eee11);
						throw eee11;
					}
					cnt11++;
				}
				loop11:
					;

				} finally { DebugExitSubRule(11); }

				DebugLocation(138, 26);
				UNTIL74=(IToken)Match(input,UNTIL,Follow._UNTIL_in_groupExpr1580); if (state.failed) return retval;
				DebugLocation(138, 28);
				PushFollow(Follow._term_in_groupExpr1583);
				term75=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term75.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:139:3: BEGIN ( exprList )+ END ';'
				{
				DebugLocation(139, 3);
				BEGIN76=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1587); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN76);

				DebugLocation(139, 9);
				// MathLang.g:139:9: ( exprList )+
				int cnt12=0;
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==IF||LA12_0==FOR||(LA12_0>=WHILE && LA12_0<=REPEAT)||LA12_0==BEGIN||LA12_0==PRINT||(LA12_0>=FUNC && LA12_0<=PROC)||LA12_0==IDENT||LA12_0==PRINTSTR))
					{
						alt12=1;
					}


					} finally { DebugExitDecision(12); }
					switch (alt12)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: exprList
						{
						DebugLocation(139, 9);
						PushFollow(Follow._exprList_in_groupExpr1589);
						exprList77=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_exprList.Add(exprList77.Tree);

						}
						break;

					default:
						if (cnt12 >= 1)
							goto loop12;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee12 = new EarlyExitException( 12, input );
						DebugRecognitionException(eee12);
						throw eee12;
					}
					cnt12++;
				}
				loop12:
					;

				} finally { DebugExitSubRule(12); }

				DebugLocation(139, 19);
				END78=(IToken)Match(input,END,Follow._END_in_groupExpr1592); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END78);

				DebugLocation(139, 23);
				char_literal79=(IToken)Match(input,69,Follow._69_in_groupExpr1594); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_69.Add(char_literal79);



				{
				// AST REWRITE
				// elements: exprList
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 139:27: -> ^( BLOCK ( exprList )+ )
				{
					DebugLocation(139, 30);
					// MathLang.g:139:30: ^( BLOCK ( exprList )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(139, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(139, 38);
					if ( !(stream_exprList.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_exprList.HasNext )
					{
						DebugLocation(139, 38);
						adaptor.AddChild(root_1, stream_exprList.NextTree());

					}
					stream_exprList.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:140:2: func_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 2);
				PushFollow(Follow._func_decl_in_groupExpr1606);
				func_decl80=func_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl80.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:141:2: proc_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(141, 2);
				PushFollow(Follow._proc_decl_in_groupExpr1609);
				proc_decl81=proc_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl81.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("groupExpr", 14);
			LeaveRule("groupExpr", 14);
			Leave_groupExpr();
		}
		DebugLocation(142, 0);
		} finally { DebugExitRule(GrammarFileName, "groupExpr"); }
		return retval;

	}
	// $ANTLR end "groupExpr"

	public class const_decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_const_decl();
	partial void Leave_const_decl();

	// $ANTLR start "const_decl"
	// MathLang.g:145:1: const_decl : IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ ;
	[GrammarRule("const_decl")]
	private MathLangParser.const_decl_return const_decl()
	{
		Enter_const_decl();
		EnterRule("const_decl", 15);
		TraceIn("const_decl", 15);
		MathLangParser.const_decl_return retval = new MathLangParser.const_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT82=null;
		IToken EQUALS83=null;
		IToken set84=null;
		IToken char_literal85=null;

		object IDENT82_tree=null;
		object EQUALS83_tree=null;
		object set84_tree=null;
		object char_literal85_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_decl");
		DebugLocation(145, 0);
		try
		{
			// MathLang.g:145:11: ( IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:146:2: IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(146, 7);
			IDENT82=(IToken)Match(input,IDENT,Follow._IDENT_in_const_decl1619); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IDENT82_tree = (object)adaptor.Create(IDENT82);
			root_0 = (object)adaptor.BecomeRoot(IDENT82_tree, root_0);
			}
			DebugLocation(146, 15);
			EQUALS83=(IToken)Match(input,EQUALS,Follow._EQUALS_in_const_decl1622); if (state.failed) return retval;
			DebugLocation(146, 17);
			set84=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=IDENT))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set84));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(146, 32);
			// MathLang.g:146:32: ( ';' )+
			int cnt14=0;
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==69))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:146:33: ';'
					{
					DebugLocation(146, 36);
					char_literal85=(IToken)Match(input,69,Follow._69_in_const_decl1632); if (state.failed) return retval;

					}
					break;

				default:
					if (cnt14 >= 1)
						goto loop14;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee14 = new EarlyExitException( 14, input );
					DebugRecognitionException(eee14);
					throw eee14;
				}
				cnt14++;
			}
			loop14:
				;

			} finally { DebugExitSubRule(14); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("const_decl", 15);
			LeaveRule("const_decl", 15);
			Leave_const_decl();
		}
		DebugLocation(147, 0);
		} finally { DebugExitRule(GrammarFileName, "const_decl"); }
		return retval;

	}
	// $ANTLR end "const_decl"

	public class const__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_const_();
	partial void Leave_const_();

	// $ANTLR start "const_"
	// MathLang.g:148:1: const_ : CONST_ ( const_decl )+ ;
	[GrammarRule("const_")]
	private MathLangParser.const__return const_()
	{
		Enter_const_();
		EnterRule("const_", 16);
		TraceIn("const_", 16);
		MathLangParser.const__return retval = new MathLangParser.const__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONST_86=null;
		MathLangParser.const_decl_return const_decl87 = default(MathLangParser.const_decl_return);

		object CONST_86_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_");
		DebugLocation(148, 0);
		try
		{
			// MathLang.g:148:7: ( CONST_ ( const_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:149:1: CONST_ ( const_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 7);
			CONST_86=(IToken)Match(input,CONST_,Follow._CONST__in_const_1643); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_86_tree = (object)adaptor.Create(CONST_86);
			root_0 = (object)adaptor.BecomeRoot(CONST_86_tree, root_0);
			}
			DebugLocation(149, 9);
			// MathLang.g:149:9: ( const_decl )+
			int cnt15=0;
			try { DebugEnterSubRule(15);
			while (true)
			{
				int alt15=2;
				try { DebugEnterDecision(15, decisionCanBacktrack[15]);
				int LA15_0 = input.LA(1);

				if ((LA15_0==IDENT))
				{
					alt15=1;
				}


				} finally { DebugExitDecision(15); }
				switch (alt15)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_decl
					{
					DebugLocation(149, 9);
					PushFollow(Follow._const_decl_in_const_1646);
					const_decl87=const_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_decl87.Tree);

					}
					break;

				default:
					if (cnt15 >= 1)
						goto loop15;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee15 = new EarlyExitException( 15, input );
					DebugRecognitionException(eee15);
					throw eee15;
				}
				cnt15++;
			}
			loop15:
				;

			} finally { DebugExitSubRule(15); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("const_", 16);
			LeaveRule("const_", 16);
			Leave_const_();
		}
		DebugLocation(150, 0);
		} finally { DebugExitRule(GrammarFileName, "const_"); }
		return retval;

	}
	// $ANTLR end "const_"

	public class type_decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_type_decl();
	partial void Leave_type_decl();

	// $ANTLR start "type_decl"
	// MathLang.g:152:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );
	[GrammarRule("type_decl")]
	private MathLangParser.type_decl_return type_decl()
	{
		Enter_type_decl();
		EnterRule("type_decl", 17);
		TraceIn("type_decl", 17);
		MathLangParser.type_decl_return retval = new MathLangParser.type_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT88=null;
		IToken char_literal89=null;
		IToken IDENT90=null;
		IToken char_literal91=null;
		IToken IDENT93=null;
		IToken char_literal94=null;
		IToken IDENT95=null;
		IToken char_literal96=null;
		IToken ARRAY97=null;
		IToken char_literal98=null;
		IToken char_literal100=null;
		IToken char_literal101=null;
		IToken char_literal103=null;
		IToken OF104=null;
		MathLangParser.type_return type92 = default(MathLangParser.type_return);
		MathLangParser.group_return group99 = default(MathLangParser.group_return);
		MathLangParser.group_return group102 = default(MathLangParser.group_return);
		MathLangParser.type_return type105 = default(MathLangParser.type_return);

		object IDENT88_tree=null;
		object char_literal89_tree=null;
		object IDENT90_tree=null;
		object char_literal91_tree=null;
		object IDENT93_tree=null;
		object char_literal94_tree=null;
		object IDENT95_tree=null;
		object char_literal96_tree=null;
		object ARRAY97_tree=null;
		object char_literal98_tree=null;
		object char_literal100_tree=null;
		object char_literal101_tree=null;
		object char_literal103_tree=null;
		object OF104_tree=null;
		RewriteRuleITokenStream stream_79=new RewriteRuleITokenStream(adaptor,"token 79");
		RewriteRuleITokenStream stream_78=new RewriteRuleITokenStream(adaptor,"token 78");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type_decl");
		DebugLocation(152, 0);
		try
		{
			// MathLang.g:152:10: ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) )
			int alt19=2;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			try
			{
				alt19 = dfa19.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:153:2: ( ( IDENT ( ',' IDENT )* )+ ) ':' type
				{
				DebugLocation(153, 2);
				// MathLang.g:153:2: ( ( IDENT ( ',' IDENT )* )+ )
				DebugEnterAlt(1);
				// MathLang.g:153:4: ( IDENT ( ',' IDENT )* )+
				{
				DebugLocation(153, 4);
				// MathLang.g:153:4: ( IDENT ( ',' IDENT )* )+
				int cnt17=0;
				try { DebugEnterSubRule(17);
				while (true)
				{
					int alt17=2;
					try { DebugEnterDecision(17, decisionCanBacktrack[17]);
					int LA17_0 = input.LA(1);

					if ((LA17_0==IDENT))
					{
						alt17=1;
					}


					} finally { DebugExitDecision(17); }
					switch (alt17)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:153:5: IDENT ( ',' IDENT )*
						{
						DebugLocation(153, 5);
						IDENT88=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1659); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT88);

						DebugLocation(153, 11);
						// MathLang.g:153:11: ( ',' IDENT )*
						try { DebugEnterSubRule(16);
						while (true)
						{
							int alt16=2;
							try { DebugEnterDecision(16, decisionCanBacktrack[16]);
							int LA16_0 = input.LA(1);

							if ((LA16_0==79))
							{
								alt16=1;
							}


							} finally { DebugExitDecision(16); }
							switch ( alt16 )
							{
							case 1:
								DebugEnterAlt(1);
								// MathLang.g:153:12: ',' IDENT
								{
								DebugLocation(153, 12);
								char_literal89=(IToken)Match(input,79,Follow._79_in_type_decl1662); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_79.Add(char_literal89);

								DebugLocation(153, 16);
								IDENT90=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1664); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT90);


								}
								break;

							default:
								goto loop16;
							}
						}

						loop16:
							;

						} finally { DebugExitSubRule(16); }


						}
						break;

					default:
						if (cnt17 >= 1)
							goto loop17;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee17 = new EarlyExitException( 17, input );
						DebugRecognitionException(eee17);
						throw eee17;
					}
					cnt17++;
				}
				loop17:
					;

				} finally { DebugExitSubRule(17); }


				}

				DebugLocation(153, 26);
				char_literal91=(IToken)Match(input,68,Follow._68_in_type_decl1670); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal91);

				DebugLocation(153, 30);
				PushFollow(Follow._type_in_type_decl1672);
				type92=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type92.Tree);


				{
				// AST REWRITE
				// elements: type, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 153:34: -> ^( type ( IDENT )+ )
				{
					DebugLocation(153, 37);
					// MathLang.g:153:37: ^( type ( IDENT )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(153, 39);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(153, 44);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(153, 44);
						adaptor.AddChild(root_1, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:154:3: IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type
				{
				DebugLocation(154, 3);
				IDENT93=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1684); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT93);

				DebugLocation(154, 9);
				// MathLang.g:154:9: ( ',' IDENT )*
				try { DebugEnterSubRule(18);
				while (true)
				{
					int alt18=2;
					try { DebugEnterDecision(18, decisionCanBacktrack[18]);
					int LA18_0 = input.LA(1);

					if ((LA18_0==79))
					{
						alt18=1;
					}


					} finally { DebugExitDecision(18); }
					switch ( alt18 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:154:10: ',' IDENT
						{
						DebugLocation(154, 10);
						char_literal94=(IToken)Match(input,79,Follow._79_in_type_decl1687); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_79.Add(char_literal94);

						DebugLocation(154, 14);
						IDENT95=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1689); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT95);


						}
						break;

					default:
						goto loop18;
					}
				}

				loop18:
					;

				} finally { DebugExitSubRule(18); }

				DebugLocation(154, 21);
				char_literal96=(IToken)Match(input,68,Follow._68_in_type_decl1692); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal96);

				DebugLocation(154, 25);
				ARRAY97=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_decl1694); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY97);

				DebugLocation(154, 31);
				char_literal98=(IToken)Match(input,63,Follow._63_in_type_decl1696); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal98);

				DebugLocation(154, 35);
				PushFollow(Follow._group_in_type_decl1698);
				group99=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group99.Tree);
				DebugLocation(154, 41);
				char_literal100=(IToken)Match(input,78,Follow._78_in_type_decl1700); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_78.Add(char_literal100);

				DebugLocation(154, 44);
				char_literal101=(IToken)Match(input,78,Follow._78_in_type_decl1701); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_78.Add(char_literal101);

				DebugLocation(154, 47);
				PushFollow(Follow._group_in_type_decl1702);
				group102=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group102.Tree);
				DebugLocation(154, 53);
				char_literal103=(IToken)Match(input,64,Follow._64_in_type_decl1704); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal103);

				DebugLocation(154, 57);
				OF104=(IToken)Match(input,OF,Follow._OF_in_type_decl1706); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF104);

				DebugLocation(154, 60);
				PushFollow(Follow._type_in_type_decl1708);
				type105=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type105.Tree);


				{
				// AST REWRITE
				// elements: type, IDENT, group, ARRAY
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 154:65: -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
				{
					DebugLocation(154, 68);
					// MathLang.g:154:68: ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(154, 70);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(154, 75);
					// MathLang.g:154:75: ^( ARRAY ( IDENT )+ ( group )+ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(154, 77);
					root_2 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_2);

					DebugLocation(154, 83);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(154, 83);
						adaptor.AddChild(root_2, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();
					DebugLocation(154, 90);
					if ( !(stream_group.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_group.HasNext )
					{
						DebugLocation(154, 90);
						adaptor.AddChild(root_2, stream_group.NextTree());

					}
					stream_group.Reset();

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("type_decl", 17);
			LeaveRule("type_decl", 17);
			Leave_type_decl();
		}
		DebugLocation(155, 0);
		} finally { DebugExitRule(GrammarFileName, "type_decl"); }
		return retval;

	}
	// $ANTLR end "type_decl"

	public class vars_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_vars();
	partial void Leave_vars();

	// $ANTLR start "vars"
	// MathLang.g:157:1: vars : VAR ( type_decl ';' )+ ;
	[GrammarRule("vars")]
	private MathLangParser.vars_return vars()
	{
		Enter_vars();
		EnterRule("vars", 18);
		TraceIn("vars", 18);
		MathLangParser.vars_return retval = new MathLangParser.vars_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR106=null;
		IToken char_literal108=null;
		MathLangParser.type_decl_return type_decl107 = default(MathLangParser.type_decl_return);

		object VAR106_tree=null;
		object char_literal108_tree=null;

		try { DebugEnterRule(GrammarFileName, "vars");
		DebugLocation(157, 0);
		try
		{
			// MathLang.g:157:5: ( VAR ( type_decl ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:158:2: VAR ( type_decl ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(158, 5);
			VAR106=(IToken)Match(input,VAR,Follow._VAR_in_vars1733); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR106_tree = (object)adaptor.Create(VAR106);
			root_0 = (object)adaptor.BecomeRoot(VAR106_tree, root_0);
			}
			DebugLocation(158, 7);
			// MathLang.g:158:7: ( type_decl ';' )+
			int cnt20=0;
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==IDENT))
				{
					alt20=1;
				}


				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:158:8: type_decl ';'
					{
					DebugLocation(158, 8);
					PushFollow(Follow._type_decl_in_vars1737);
					type_decl107=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl107.Tree);
					DebugLocation(158, 21);
					char_literal108=(IToken)Match(input,69,Follow._69_in_vars1739); if (state.failed) return retval;

					}
					break;

				default:
					if (cnt20 >= 1)
						goto loop20;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee20 = new EarlyExitException( 20, input );
					DebugRecognitionException(eee20);
					throw eee20;
				}
				cnt20++;
			}
			loop20:
				;

			} finally { DebugExitSubRule(20); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("vars", 18);
			LeaveRule("vars", 18);
			Leave_vars();
		}
		DebugLocation(159, 0);
		} finally { DebugExitRule(GrammarFileName, "vars"); }
		return retval;

	}
	// $ANTLR end "vars"

	public class param_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_param();
	partial void Leave_param();

	// $ANTLR start "param"
	// MathLang.g:161:1: param : term ;
	[GrammarRule("param")]
	private MathLangParser.param_return param()
	{
		Enter_param();
		EnterRule("param", 19);
		TraceIn("param", 19);
		MathLangParser.param_return retval = new MathLangParser.param_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.term_return term109 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "param");
		DebugLocation(161, 0);
		try
		{
			// MathLang.g:161:6: ( term )
			DebugEnterAlt(1);
			// MathLang.g:161:8: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(161, 8);
			PushFollow(Follow._term_in_param1750);
			term109=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term109.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("param", 19);
			LeaveRule("param", 19);
			Leave_param();
		}
		DebugLocation(162, 0);
		} finally { DebugExitRule(GrammarFileName, "param"); }
		return retval;

	}
	// $ANTLR end "param"

	public class params__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_params_();
	partial void Leave_params_();

	// $ANTLR start "params_"
	// MathLang.g:164:1: params_ : ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) ;
	[GrammarRule("params_")]
	private MathLangParser.params__return params_()
	{
		Enter_params_();
		EnterRule("params_", 20);
		TraceIn("params_", 20);
		MathLangParser.params__return retval = new MathLangParser.params__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal111=null;
		MathLangParser.param_return param110 = default(MathLangParser.param_return);
		MathLangParser.param_return param112 = default(MathLangParser.param_return);

		object char_literal111_tree=null;
		RewriteRuleITokenStream stream_79=new RewriteRuleITokenStream(adaptor,"token 79");
		RewriteRuleSubtreeStream stream_param=new RewriteRuleSubtreeStream(adaptor,"rule param");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(164, 0);
		try
		{
			// MathLang.g:164:8: ( ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) )
			DebugEnterAlt(1);
			// MathLang.g:165:1: ( param ( ',' param )* )?
			{
			DebugLocation(165, 1);
			// MathLang.g:165:1: ( param ( ',' param )* )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if (((LA22_0>=TRUE && LA22_0<=FALSE)||(LA22_0>=NUMBER && LA22_0<=IDENT)||LA22_0==61))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:165:2: param ( ',' param )*
				{
				DebugLocation(165, 2);
				PushFollow(Follow._param_in_params_1759);
				param110=param();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_param.Add(param110.Tree);
				DebugLocation(165, 7);
				// MathLang.g:165:7: ( ',' param )*
				try { DebugEnterSubRule(21);
				while (true)
				{
					int alt21=2;
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==79))
					{
						alt21=1;
					}


					} finally { DebugExitDecision(21); }
					switch ( alt21 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:165:8: ',' param
						{
						DebugLocation(165, 8);
						char_literal111=(IToken)Match(input,79,Follow._79_in_params_1761); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_79.Add(char_literal111);

						DebugLocation(165, 12);
						PushFollow(Follow._param_in_params_1763);
						param112=param();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_param.Add(param112.Tree);

						}
						break;

					default:
						goto loop21;
					}
				}

				loop21:
					;

				} finally { DebugExitSubRule(21); }


				}
				break;

			}
			} finally { DebugExitSubRule(22); }



			{
			// AST REWRITE
			// elements: param
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 165:22: -> ^( PARAMS ( param )* )
			{
				DebugLocation(165, 25);
				// MathLang.g:165:25: ^( PARAMS ( param )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(165, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(165, 34);
				// MathLang.g:165:34: ( param )*
				while ( stream_param.HasNext )
				{
					DebugLocation(165, 34);
					adaptor.AddChild(root_1, stream_param.NextTree());

				}
				stream_param.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("params_", 20);
			LeaveRule("params_", 20);
			Leave_params_();
		}
		DebugLocation(166, 0);
		} finally { DebugExitRule(GrammarFileName, "params_"); }
		return retval;

	}
	// $ANTLR end "params_"

	public class func_sign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_func_sign();
	partial void Leave_func_sign();

	// $ANTLR start "func_sign"
	// MathLang.g:168:1: func_sign : ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) ;
	[GrammarRule("func_sign")]
	private MathLangParser.func_sign_return func_sign()
	{
		Enter_func_sign();
		EnterRule("func_sign", 21);
		TraceIn("func_sign", 21);
		MathLangParser.func_sign_return retval = new MathLangParser.func_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNC113=null;
		IToken IDENT114=null;
		IToken char_literal115=null;
		IToken char_literal116=null;
		IToken char_literal118=null;
		IToken VAR119=null;
		IToken char_literal120=null;
		IToken char_literal121=null;
		IToken char_literal123=null;
		MathLangParser.type_decl_return t1 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl117 = default(MathLangParser.type_decl_return);
		MathLangParser.type_return type122 = default(MathLangParser.type_return);

		object FUNC113_tree=null;
		object IDENT114_tree=null;
		object char_literal115_tree=null;
		object char_literal116_tree=null;
		object char_literal118_tree=null;
		object VAR119_tree=null;
		object char_literal120_tree=null;
		object char_literal121_tree=null;
		object char_literal123_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_FUNC=new RewriteRuleITokenStream(adaptor,"token FUNC");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "func_sign");
		DebugLocation(168, 0);
		try
		{
			// MathLang.g:168:10: ( ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:169:1: ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' )
			{
			DebugLocation(169, 1);
			// MathLang.g:169:1: ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' )
			DebugEnterAlt(1);
			// MathLang.g:169:2: FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';'
			{
			DebugLocation(169, 2);
			FUNC113=(IToken)Match(input,FUNC,Follow._FUNC_in_func_sign1785); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC.Add(FUNC113);

			DebugLocation(169, 7);
			IDENT114=(IToken)Match(input,IDENT,Follow._IDENT_in_func_sign1787); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT114);

			DebugLocation(169, 13);
			char_literal115=(IToken)Match(input,61,Follow._61_in_func_sign1789); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal115);

			DebugLocation(169, 16);
			// MathLang.g:169:16: (t1= type_decl ( ';' type_decl )* )*
			try { DebugEnterSubRule(24);
			while (true)
			{
				int alt24=2;
				try { DebugEnterDecision(24, decisionCanBacktrack[24]);
				int LA24_0 = input.LA(1);

				if ((LA24_0==IDENT))
				{
					alt24=1;
				}


				} finally { DebugExitDecision(24); }
				switch ( alt24 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:169:18: t1= type_decl ( ';' type_decl )*
					{
					DebugLocation(169, 21);
					PushFollow(Follow._type_decl_in_func_sign1795);
					t1=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(t1.Tree);
					DebugLocation(169, 32);
					// MathLang.g:169:32: ( ';' type_decl )*
					try { DebugEnterSubRule(23);
					while (true)
					{
						int alt23=2;
						try { DebugEnterDecision(23, decisionCanBacktrack[23]);
						int LA23_0 = input.LA(1);

						if ((LA23_0==69))
						{
							int LA23_1 = input.LA(2);

							if ((LA23_1==IDENT))
							{
								alt23=1;
							}


						}


						} finally { DebugExitDecision(23); }
						switch ( alt23 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:169:33: ';' type_decl
							{
							DebugLocation(169, 33);
							char_literal116=(IToken)Match(input,69,Follow._69_in_func_sign1798); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_69.Add(char_literal116);

							DebugLocation(169, 37);
							PushFollow(Follow._type_decl_in_func_sign1800);
							type_decl117=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl117.Tree);

							}
							break;

						default:
							goto loop23;
						}
					}

					loop23:
						;

					} finally { DebugExitSubRule(23); }


					}
					break;

				default:
					goto loop24;
				}
			}

			loop24:
				;

			} finally { DebugExitSubRule(24); }

			DebugLocation(169, 50);
			// MathLang.g:169:50: ( ';' VAR (t2= type_decl )* )*
			try { DebugEnterSubRule(26);
			while (true)
			{
				int alt26=2;
				try { DebugEnterDecision(26, decisionCanBacktrack[26]);
				int LA26_0 = input.LA(1);

				if ((LA26_0==69))
				{
					alt26=1;
				}


				} finally { DebugExitDecision(26); }
				switch ( alt26 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:169:51: ';' VAR (t2= type_decl )*
					{
					DebugLocation(169, 51);
					char_literal118=(IToken)Match(input,69,Follow._69_in_func_sign1806); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_69.Add(char_literal118);

					DebugLocation(169, 55);
					VAR119=(IToken)Match(input,VAR,Follow._VAR_in_func_sign1808); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_VAR.Add(VAR119);

					DebugLocation(169, 61);
					// MathLang.g:169:61: (t2= type_decl )*
					try { DebugEnterSubRule(25);
					while (true)
					{
						int alt25=2;
						try { DebugEnterDecision(25, decisionCanBacktrack[25]);
						int LA25_0 = input.LA(1);

						if ((LA25_0==IDENT))
						{
							alt25=1;
						}


						} finally { DebugExitDecision(25); }
						switch ( alt25 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:0:0: t2= type_decl
							{
							DebugLocation(169, 61);
							PushFollow(Follow._type_decl_in_func_sign1812);
							t2=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t2.Tree);

							}
							break;

						default:
							goto loop25;
						}
					}

					loop25:
						;

					} finally { DebugExitSubRule(25); }


					}
					break;

				default:
					goto loop26;
				}
			}

			loop26:
				;

			} finally { DebugExitSubRule(26); }

			DebugLocation(169, 74);
			char_literal120=(IToken)Match(input,62,Follow._62_in_func_sign1816); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal120);

			DebugLocation(169, 78);
			char_literal121=(IToken)Match(input,68,Follow._68_in_func_sign1818); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal121);

			DebugLocation(169, 82);
			PushFollow(Follow._type_in_func_sign1820);
			type122=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type122.Tree);
			DebugLocation(169, 87);
			char_literal123=(IToken)Match(input,69,Follow._69_in_func_sign1822); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal123);


			}



			{
			// AST REWRITE
			// elements: type, FUNC, VAR, t1, t2, IDENT
			// token labels: 
			// rule labels: t2, retval, t1
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 169:91: -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
			{
				DebugLocation(169, 94);
				// MathLang.g:169:94: ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(169, 96);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

				DebugLocation(169, 101);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(169, 106);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(169, 112);
				// MathLang.g:169:112: ^( PARAMS ( $t1)* ( ^( VAR $t2) )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(169, 114);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(169, 121);
				// MathLang.g:169:121: ( $t1)*
				while ( stream_t1.HasNext )
				{
					DebugLocation(169, 121);
					adaptor.AddChild(root_2, stream_t1.NextTree());

				}
				stream_t1.Reset();
				DebugLocation(169, 126);
				// MathLang.g:169:126: ( ^( VAR $t2) )*
				while ( stream_VAR.HasNext||stream_t2.HasNext )
				{
					DebugLocation(169, 126);
					// MathLang.g:169:126: ^( VAR $t2)
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(169, 128);
					root_3 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_3);

					DebugLocation(169, 132);
					adaptor.AddChild(root_3, stream_t2.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

				}
				stream_VAR.Reset();
				stream_t2.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("func_sign", 21);
			LeaveRule("func_sign", 21);
			Leave_func_sign();
		}
		DebugLocation(170, 0);
		} finally { DebugExitRule(GrammarFileName, "func_sign"); }
		return retval;

	}
	// $ANTLR end "func_sign"

	public class proc_sign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_proc_sign();
	partial void Leave_proc_sign();

	// $ANTLR start "proc_sign"
	// MathLang.g:172:1: proc_sign : ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) ;
	[GrammarRule("proc_sign")]
	private MathLangParser.proc_sign_return proc_sign()
	{
		Enter_proc_sign();
		EnterRule("proc_sign", 22);
		TraceIn("proc_sign", 22);
		MathLangParser.proc_sign_return retval = new MathLangParser.proc_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROC124=null;
		IToken IDENT125=null;
		IToken char_literal126=null;
		IToken char_literal127=null;
		IToken char_literal129=null;
		IToken VAR130=null;
		IToken char_literal131=null;
		IToken char_literal132=null;
		MathLangParser.type_decl_return t1 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl128 = default(MathLangParser.type_decl_return);

		object PROC124_tree=null;
		object IDENT125_tree=null;
		object char_literal126_tree=null;
		object char_literal127_tree=null;
		object char_literal129_tree=null;
		object VAR130_tree=null;
		object char_literal131_tree=null;
		object char_literal132_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_PROC=new RewriteRuleITokenStream(adaptor,"token PROC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		try { DebugEnterRule(GrammarFileName, "proc_sign");
		DebugLocation(172, 0);
		try
		{
			// MathLang.g:172:10: ( ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:173:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			{
			DebugLocation(173, 1);
			// MathLang.g:173:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:173:2: PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';'
			{
			DebugLocation(173, 2);
			PROC124=(IToken)Match(input,PROC,Follow._PROC_in_proc_sign1857); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC.Add(PROC124);

			DebugLocation(173, 7);
			IDENT125=(IToken)Match(input,IDENT,Follow._IDENT_in_proc_sign1859); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT125);

			DebugLocation(173, 13);
			char_literal126=(IToken)Match(input,61,Follow._61_in_proc_sign1861); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal126);

			DebugLocation(173, 16);
			// MathLang.g:173:16: ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==VAR||LA30_0==IDENT))
				{
					alt30=1;
				}


				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:173:17: (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )*
					{
					DebugLocation(173, 17);
					// MathLang.g:173:17: (t1= type_decl ( ';' type_decl )* ';' )*
					try { DebugEnterSubRule(28);
					while (true)
					{
						int alt28=2;
						try { DebugEnterDecision(28, decisionCanBacktrack[28]);
						int LA28_0 = input.LA(1);

						if ((LA28_0==IDENT))
						{
							alt28=1;
						}


						} finally { DebugExitDecision(28); }
						switch ( alt28 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:173:19: t1= type_decl ( ';' type_decl )* ';'
							{
							DebugLocation(173, 21);
							PushFollow(Follow._type_decl_in_proc_sign1867);
							t1=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t1.Tree);
							DebugLocation(173, 32);
							// MathLang.g:173:32: ( ';' type_decl )*
							try { DebugEnterSubRule(27);
							while (true)
							{
								int alt27=2;
								try { DebugEnterDecision(27, decisionCanBacktrack[27]);
								int LA27_0 = input.LA(1);

								if ((LA27_0==69))
								{
									int LA27_1 = input.LA(2);

									if ((EvaluatePredicate(synpred77_MathLang_fragment)))
									{
										alt27=1;
									}


								}


								} finally { DebugExitDecision(27); }
								switch ( alt27 )
								{
								case 1:
									DebugEnterAlt(1);
									// MathLang.g:173:33: ';' type_decl
									{
									DebugLocation(173, 33);
									char_literal127=(IToken)Match(input,69,Follow._69_in_proc_sign1870); if (state.failed) return retval; 
									if ( state.backtracking == 0 ) stream_69.Add(char_literal127);

									DebugLocation(173, 37);
									PushFollow(Follow._type_decl_in_proc_sign1872);
									type_decl128=type_decl();
									PopFollow();
									if (state.failed) return retval;
									if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl128.Tree);

									}
									break;

								default:
									goto loop27;
								}
							}

							loop27:
								;

							} finally { DebugExitSubRule(27); }

							DebugLocation(173, 49);
							char_literal129=(IToken)Match(input,69,Follow._69_in_proc_sign1876); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_69.Add(char_literal129);


							}
							break;

						default:
							goto loop28;
						}
					}

					loop28:
						;

					} finally { DebugExitSubRule(28); }

					DebugLocation(173, 55);
					VAR130=(IToken)Match(input,VAR,Follow._VAR_in_proc_sign1880); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_VAR.Add(VAR130);

					DebugLocation(173, 61);
					// MathLang.g:173:61: (t2= type_decl )*
					try { DebugEnterSubRule(29);
					while (true)
					{
						int alt29=2;
						try { DebugEnterDecision(29, decisionCanBacktrack[29]);
						int LA29_0 = input.LA(1);

						if ((LA29_0==IDENT))
						{
							int LA29_2 = input.LA(2);

							if ((EvaluatePredicate(synpred79_MathLang_fragment)))
							{
								alt29=1;
							}


						}


						} finally { DebugExitDecision(29); }
						switch ( alt29 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:0:0: t2= type_decl
							{
							DebugLocation(173, 61);
							PushFollow(Follow._type_decl_in_proc_sign1884);
							t2=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t2.Tree);

							}
							break;

						default:
							goto loop29;
						}
					}

					loop29:
						;

					} finally { DebugExitSubRule(29); }


					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }

			DebugLocation(173, 74);
			char_literal131=(IToken)Match(input,62,Follow._62_in_proc_sign1888); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal131);

			DebugLocation(173, 78);
			char_literal132=(IToken)Match(input,69,Follow._69_in_proc_sign1890); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal132);


			}



			{
			// AST REWRITE
			// elements: VAR, t2, IDENT, PROC, t1
			// token labels: 
			// rule labels: t2, retval, t1
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_t2=new RewriteRuleSubtreeStream(adaptor,"rule t2",t2!=null?t2.Tree:null);
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);
			RewriteRuleSubtreeStream stream_t1=new RewriteRuleSubtreeStream(adaptor,"rule t1",t1!=null?t1.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 173:82: -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
			{
				DebugLocation(173, 85);
				// MathLang.g:173:85: ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(173, 87);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC.NextNode(), root_1);

				DebugLocation(173, 92);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(173, 98);
				// MathLang.g:173:98: ^( PARAMS ( $t1)* ( ^( VAR $t2) )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(173, 100);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(173, 108);
				// MathLang.g:173:108: ( $t1)*
				while ( stream_t1.HasNext )
				{
					DebugLocation(173, 108);
					adaptor.AddChild(root_2, stream_t1.NextTree());

				}
				stream_t1.Reset();
				DebugLocation(173, 114);
				// MathLang.g:173:114: ( ^( VAR $t2) )*
				while ( stream_VAR.HasNext||stream_t2.HasNext )
				{
					DebugLocation(173, 114);
					// MathLang.g:173:114: ^( VAR $t2)
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(173, 116);
					root_3 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_3);

					DebugLocation(173, 120);
					adaptor.AddChild(root_3, stream_t2.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

				}
				stream_VAR.Reset();
				stream_t2.Reset();

				adaptor.AddChild(root_1, root_2);
				}

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("proc_sign", 22);
			LeaveRule("proc_sign", 22);
			Leave_proc_sign();
		}
		DebugLocation(174, 0);
		} finally { DebugExitRule(GrammarFileName, "proc_sign"); }
		return retval;

	}
	// $ANTLR end "proc_sign"

	public class func_decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_func_decl();
	partial void Leave_func_decl();

	// $ANTLR start "func_decl"
	// MathLang.g:176:1: func_decl : func_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("func_decl")]
	private MathLangParser.func_decl_return func_decl()
	{
		Enter_func_decl();
		EnterRule("func_decl", 23);
		TraceIn("func_decl", 23);
		MathLangParser.func_decl_return retval = new MathLangParser.func_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal134=null;
		IToken char_literal138=null;
		MathLangParser.func_sign_return func_sign133 = default(MathLangParser.func_sign_return);
		MathLangParser.const__return const_135 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars136 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr137 = default(MathLangParser.groupExpr_return);

		object char_literal134_tree=null;
		object char_literal138_tree=null;

		try { DebugEnterRule(GrammarFileName, "func_decl");
		DebugLocation(176, 0);
		try
		{
			// MathLang.g:176:10: ( func_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:177:1: func_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(177, 10);
			PushFollow(Follow._func_sign_in_func_decl1924);
			func_sign133=func_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(func_sign133.Tree, root_0);
			DebugLocation(177, 15);
			char_literal134=(IToken)Match(input,69,Follow._69_in_func_decl1927); if (state.failed) return retval;
			DebugLocation(177, 17);
			// MathLang.g:177:17: ( const_ )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==CONST_))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_
					{
					DebugLocation(177, 17);
					PushFollow(Follow._const__in_func_decl1930);
					const_135=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_135.Tree);

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }

			DebugLocation(177, 25);
			// MathLang.g:177:25: ( vars )*
			try { DebugEnterSubRule(32);
			while (true)
			{
				int alt32=2;
				try { DebugEnterDecision(32, decisionCanBacktrack[32]);
				int LA32_0 = input.LA(1);

				if ((LA32_0==VAR))
				{
					alt32=1;
				}


				} finally { DebugExitDecision(32); }
				switch ( alt32 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: vars
					{
					DebugLocation(177, 25);
					PushFollow(Follow._vars_in_func_decl1933);
					vars136=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars136.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }

			DebugLocation(177, 31);
			PushFollow(Follow._groupExpr_in_func_decl1936);
			groupExpr137=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr137.Tree);
			DebugLocation(177, 44);
			char_literal138=(IToken)Match(input,69,Follow._69_in_func_decl1938); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("func_decl", 23);
			LeaveRule("func_decl", 23);
			Leave_func_decl();
		}
		DebugLocation(178, 0);
		} finally { DebugExitRule(GrammarFileName, "func_decl"); }
		return retval;

	}
	// $ANTLR end "func_decl"

	public class proc_decl_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_proc_decl();
	partial void Leave_proc_decl();

	// $ANTLR start "proc_decl"
	// MathLang.g:180:1: proc_decl : proc_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("proc_decl")]
	private MathLangParser.proc_decl_return proc_decl()
	{
		Enter_proc_decl();
		EnterRule("proc_decl", 24);
		TraceIn("proc_decl", 24);
		MathLangParser.proc_decl_return retval = new MathLangParser.proc_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal140=null;
		IToken char_literal144=null;
		MathLangParser.proc_sign_return proc_sign139 = default(MathLangParser.proc_sign_return);
		MathLangParser.const__return const_141 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars142 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr143 = default(MathLangParser.groupExpr_return);

		object char_literal140_tree=null;
		object char_literal144_tree=null;

		try { DebugEnterRule(GrammarFileName, "proc_decl");
		DebugLocation(180, 0);
		try
		{
			// MathLang.g:180:10: ( proc_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:181:1: proc_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(181, 10);
			PushFollow(Follow._proc_sign_in_proc_decl1947);
			proc_sign139=proc_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(proc_sign139.Tree, root_0);
			DebugLocation(181, 15);
			char_literal140=(IToken)Match(input,69,Follow._69_in_proc_decl1950); if (state.failed) return retval;
			DebugLocation(181, 17);
			// MathLang.g:181:17: ( const_ )*
			try { DebugEnterSubRule(33);
			while (true)
			{
				int alt33=2;
				try { DebugEnterDecision(33, decisionCanBacktrack[33]);
				int LA33_0 = input.LA(1);

				if ((LA33_0==CONST_))
				{
					alt33=1;
				}


				} finally { DebugExitDecision(33); }
				switch ( alt33 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_
					{
					DebugLocation(181, 17);
					PushFollow(Follow._const__in_proc_decl1953);
					const_141=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_141.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }

			DebugLocation(181, 25);
			// MathLang.g:181:25: ( vars )*
			try { DebugEnterSubRule(34);
			while (true)
			{
				int alt34=2;
				try { DebugEnterDecision(34, decisionCanBacktrack[34]);
				int LA34_0 = input.LA(1);

				if ((LA34_0==VAR))
				{
					alt34=1;
				}


				} finally { DebugExitDecision(34); }
				switch ( alt34 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: vars
					{
					DebugLocation(181, 25);
					PushFollow(Follow._vars_in_proc_decl1956);
					vars142=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars142.Tree);

					}
					break;

				default:
					goto loop34;
				}
			}

			loop34:
				;

			} finally { DebugExitSubRule(34); }

			DebugLocation(181, 31);
			PushFollow(Follow._groupExpr_in_proc_decl1959);
			groupExpr143=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr143.Tree);
			DebugLocation(181, 44);
			char_literal144=(IToken)Match(input,69,Follow._69_in_proc_decl1961); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("proc_decl", 24);
			LeaveRule("proc_decl", 24);
			Leave_proc_decl();
		}
		DebugLocation(182, 0);
		} finally { DebugExitRule(GrammarFileName, "proc_decl"); }
		return retval;

	}
	// $ANTLR end "proc_decl"

	public class call_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_call();
	partial void Leave_call();

	// $ANTLR start "call"
	// MathLang.g:184:1: call : ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) );
	[GrammarRule("call")]
	private MathLangParser.call_return call()
	{
		Enter_call();
		EnterRule("call", 25);
		TraceIn("call", 25);
		MathLangParser.call_return retval = new MathLangParser.call_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken i1=null;
		IToken i2=null;
		IToken IDENT145=null;
		IToken char_literal146=null;
		IToken char_literal148=null;
		IToken ASSIGN149=null;
		IToken char_literal150=null;
		IToken char_literal152=null;
		MathLangParser.params__return params_147 = default(MathLangParser.params__return);
		MathLangParser.params__return params_151 = default(MathLangParser.params__return);

		object i1_tree=null;
		object i2_tree=null;
		object IDENT145_tree=null;
		object char_literal146_tree=null;
		object char_literal148_tree=null;
		object ASSIGN149_tree=null;
		object char_literal150_tree=null;
		object char_literal152_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "call");
		DebugLocation(184, 0);
		try
		{
			// MathLang.g:184:5: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) )
			int alt35=2;
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==IDENT))
			{
				int LA35_1 = input.LA(2);

				if ((LA35_1==61))
				{
					alt35=1;
				}
				else if ((LA35_1==ASSIGN))
				{
					alt35=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 35, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 35, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(35); }
			switch (alt35)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:185:1: IDENT '(' params_ ')'
				{
				DebugLocation(185, 1);
				IDENT145=(IToken)Match(input,IDENT,Follow._IDENT_in_call1970); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT145);

				DebugLocation(185, 7);
				char_literal146=(IToken)Match(input,61,Follow._61_in_call1972); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal146);

				DebugLocation(185, 11);
				PushFollow(Follow._params__in_call1974);
				params_147=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_147.Tree);
				DebugLocation(185, 19);
				char_literal148=(IToken)Match(input,62,Follow._62_in_call1976); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal148);



				{
				// AST REWRITE
				// elements: params_, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 185:23: -> ^( CALL IDENT params_ )
				{
					DebugLocation(185, 26);
					// MathLang.g:185:26: ^( CALL IDENT params_ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(185, 28);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

					DebugLocation(185, 33);
					adaptor.AddChild(root_1, stream_IDENT.NextNode());
					DebugLocation(185, 39);
					adaptor.AddChild(root_1, stream_params_.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:186:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				{
				DebugLocation(186, 3);
				// MathLang.g:186:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				DebugEnterAlt(1);
				// MathLang.g:186:4: i1= IDENT ASSIGN i2= IDENT '(' params_ ')'
				{
				DebugLocation(186, 6);
				i1=(IToken)Match(input,IDENT,Follow._IDENT_in_call1993); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i1);

				DebugLocation(186, 13);
				ASSIGN149=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_call1995); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN149);

				DebugLocation(186, 22);
				i2=(IToken)Match(input,IDENT,Follow._IDENT_in_call1999); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i2);

				DebugLocation(186, 29);
				char_literal150=(IToken)Match(input,61,Follow._61_in_call2001); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal150);

				DebugLocation(186, 33);
				PushFollow(Follow._params__in_call2003);
				params_151=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_151.Tree);
				DebugLocation(186, 41);
				char_literal152=(IToken)Match(input,62,Follow._62_in_call2005); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal152);


				}



				{
				// AST REWRITE
				// elements: i1, params_, i2, ASSIGN
				// token labels: i2, i1
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleITokenStream stream_i2=new RewriteRuleITokenStream(adaptor,"token i2",i2);
				RewriteRuleITokenStream stream_i1=new RewriteRuleITokenStream(adaptor,"token i1",i1);
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 186:46: -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
				{
					DebugLocation(186, 48);
					// MathLang.g:186:48: ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(186, 50);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(186, 57);
					adaptor.AddChild(root_1, stream_i1.NextNode());
					DebugLocation(186, 61);
					// MathLang.g:186:61: ^( CALL $i2 params_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(186, 63);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_2);

					DebugLocation(186, 68);
					adaptor.AddChild(root_2, stream_i2.NextNode());
					DebugLocation(186, 72);
					adaptor.AddChild(root_2, stream_params_.NextTree());

					adaptor.AddChild(root_1, root_2);
					}

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("call", 25);
			LeaveRule("call", 25);
			Leave_call();
		}
		DebugLocation(187, 0);
		} finally { DebugExitRule(GrammarFileName, "call"); }
		return retval;

	}
	// $ANTLR end "call"

	public class exprList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_exprList();
	partial void Leave_exprList();

	// $ANTLR start "exprList"
	// MathLang.g:189:1: exprList : ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 26);
		TraceIn("exprList", 26);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal154=null;
		IToken char_literal156=null;
		MathLangParser.simpleExpr_return simpleExpr153 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr155 = default(MathLangParser.groupExpr_return);

		object char_literal154_tree=null;
		object char_literal156_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(189, 0);
		try
		{
			// MathLang.g:189:9: ( ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:190:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(190, 2);
			// MathLang.g:190:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			int alt38=2;
			try { DebugEnterSubRule(38);
			try { DebugEnterDecision(38, decisionCanBacktrack[38]);
			int LA38_0 = input.LA(1);

			if ((LA38_0==PRINT||LA38_0==IDENT||LA38_0==PRINTSTR))
			{
				alt38=1;
			}
			else if ((LA38_0==IF||LA38_0==FOR||(LA38_0>=WHILE && LA38_0<=REPEAT)||LA38_0==BEGIN||(LA38_0>=FUNC && LA38_0<=PROC)))
			{
				alt38=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 38, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(38); }
			switch (alt38)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:190:4: simpleExpr ( ';' )+
				{
				DebugLocation(190, 4);
				PushFollow(Follow._simpleExpr_in_exprList2035);
				simpleExpr153=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr153.Tree);
				DebugLocation(190, 15);
				// MathLang.g:190:15: ( ';' )+
				int cnt36=0;
				try { DebugEnterSubRule(36);
				while (true)
				{
					int alt36=2;
					try { DebugEnterDecision(36, decisionCanBacktrack[36]);
					int LA36_0 = input.LA(1);

					if ((LA36_0==69))
					{
						int LA36_2 = input.LA(2);

						if ((EvaluatePredicate(synpred86_MathLang_fragment)))
						{
							alt36=1;
						}


					}


					} finally { DebugExitDecision(36); }
					switch (alt36)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:190:16: ';'
						{
						DebugLocation(190, 19);
						char_literal154=(IToken)Match(input,69,Follow._69_in_exprList2038); if (state.failed) return retval;

						}
						break;

					default:
						if (cnt36 >= 1)
							goto loop36;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee36 = new EarlyExitException( 36, input );
						DebugRecognitionException(eee36);
						throw eee36;
					}
					cnt36++;
				}
				loop36:
					;

				} finally { DebugExitSubRule(36); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:191:3: groupExpr ( ';' )*
				{
				DebugLocation(191, 3);
				PushFollow(Follow._groupExpr_in_exprList2046);
				groupExpr155=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr155.Tree);
				DebugLocation(191, 13);
				// MathLang.g:191:13: ( ';' )*
				try { DebugEnterSubRule(37);
				while (true)
				{
					int alt37=2;
					try { DebugEnterDecision(37, decisionCanBacktrack[37]);
					int LA37_0 = input.LA(1);

					if ((LA37_0==69))
					{
						int LA37_2 = input.LA(2);

						if ((EvaluatePredicate(synpred88_MathLang_fragment)))
						{
							alt37=1;
						}


					}


					} finally { DebugExitDecision(37); }
					switch ( alt37 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:191:14: ';'
						{
						DebugLocation(191, 17);
						char_literal156=(IToken)Match(input,69,Follow._69_in_exprList2049); if (state.failed) return retval;

						}
						break;

					default:
						goto loop37;
					}
				}

				loop37:
					;

				} finally { DebugExitSubRule(37); }


				}
				break;

			}
			} finally { DebugExitSubRule(38); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("exprList", 26);
			LeaveRule("exprList", 26);
			Leave_exprList();
		}
		DebugLocation(193, 0);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class main__return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_main_();
	partial void Leave_main_();

	// $ANTLR start "main_"
	// MathLang.g:195:1: main_ : BEGIN ( exprList )* END '.' ;
	[GrammarRule("main_")]
	private MathLangParser.main__return main_()
	{
		Enter_main_();
		EnterRule("main_", 27);
		TraceIn("main_", 27);
		MathLangParser.main__return retval = new MathLangParser.main__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN157=null;
		IToken END159=null;
		IToken char_literal160=null;
		MathLangParser.exprList_return exprList158 = default(MathLangParser.exprList_return);

		object BEGIN157_tree=null;
		object END159_tree=null;
		object char_literal160_tree=null;

		try { DebugEnterRule(GrammarFileName, "main_");
		DebugLocation(195, 0);
		try
		{
			// MathLang.g:195:6: ( BEGIN ( exprList )* END '.' )
			DebugEnterAlt(1);
			// MathLang.g:196:1: BEGIN ( exprList )* END '.'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(196, 6);
			BEGIN157=(IToken)Match(input,BEGIN,Follow._BEGIN_in_main_2062); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			BEGIN157_tree = (object)adaptor.Create(BEGIN157);
			root_0 = (object)adaptor.BecomeRoot(BEGIN157_tree, root_0);
			}
			DebugLocation(196, 8);
			// MathLang.g:196:8: ( exprList )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				int LA39_0 = input.LA(1);

				if ((LA39_0==IF||LA39_0==FOR||(LA39_0>=WHILE && LA39_0<=REPEAT)||LA39_0==BEGIN||LA39_0==PRINT||(LA39_0>=FUNC && LA39_0<=PROC)||LA39_0==IDENT||LA39_0==PRINTSTR))
				{
					alt39=1;
				}


				} finally { DebugExitDecision(39); }
				switch ( alt39 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: exprList
					{
					DebugLocation(196, 8);
					PushFollow(Follow._exprList_in_main_2065);
					exprList158=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList158.Tree);

					}
					break;

				default:
					goto loop39;
				}
			}

			loop39:
				;

			} finally { DebugExitSubRule(39); }

			DebugLocation(196, 21);
			END159=(IToken)Match(input,END,Follow._END_in_main_2068); if (state.failed) return retval;
			DebugLocation(196, 26);
			char_literal160=(IToken)Match(input,78,Follow._78_in_main_2071); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("main_", 27);
			LeaveRule("main_", 27);
			Leave_main_();
		}
		DebugLocation(197, 0);
		} finally { DebugExitRule(GrammarFileName, "main_"); }
		return retval;

	}
	// $ANTLR end "main_"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:199:1: program : ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) );
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 28);
		TraceIn("program", 28);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.func_decl_return func_decl161 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl162 = default(MathLangParser.proc_decl_return);
		MathLangParser.const__return const_163 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars164 = default(MathLangParser.vars_return);
		MathLangParser.func_decl_return func_decl165 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl166 = default(MathLangParser.proc_decl_return);
		MathLangParser.vars_return vars167 = default(MathLangParser.vars_return);
		MathLangParser.main__return main_168 = default(MathLangParser.main__return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(199, 0);
		try
		{
			// MathLang.g:199:8: ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) )
			int alt46=2;
			try { DebugEnterDecision(46, decisionCanBacktrack[46]);
			int LA46_0 = input.LA(1);

			if ((LA46_0==EOF||(LA46_0>=FUNC && LA46_0<=PROC)))
			{
				alt46=1;
			}
			else if ((LA46_0==VAR||LA46_0==CONST_))
			{
				alt46=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 46, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(46); }
			switch (alt46)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:199:10: ( ( func_decl )* ( proc_decl )* )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(199, 10);
				// MathLang.g:199:10: ( ( func_decl )* ( proc_decl )* )
				DebugEnterAlt(1);
				// MathLang.g:199:12: ( func_decl )* ( proc_decl )*
				{
				DebugLocation(199, 12);
				// MathLang.g:199:12: ( func_decl )*
				try { DebugEnterSubRule(40);
				while (true)
				{
					int alt40=2;
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					int LA40_0 = input.LA(1);

					if ((LA40_0==FUNC))
					{
						alt40=1;
					}


					} finally { DebugExitDecision(40); }
					switch ( alt40 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: func_decl
						{
						DebugLocation(199, 12);
						PushFollow(Follow._func_decl_in_program2082);
						func_decl161=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl161.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }

				DebugLocation(199, 23);
				// MathLang.g:199:23: ( proc_decl )*
				try { DebugEnterSubRule(41);
				while (true)
				{
					int alt41=2;
					try { DebugEnterDecision(41, decisionCanBacktrack[41]);
					int LA41_0 = input.LA(1);

					if ((LA41_0==PROC))
					{
						alt41=1;
					}


					} finally { DebugExitDecision(41); }
					switch ( alt41 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: proc_decl
						{
						DebugLocation(199, 23);
						PushFollow(Follow._proc_decl_in_program2085);
						proc_decl162=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl162.Tree);

						}
						break;

					default:
						goto loop41;
					}
				}

				loop41:
					;

				} finally { DebugExitSubRule(41); }


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:200:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(200, 2);
				// MathLang.g:200:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				DebugEnterAlt(1);
				// MathLang.g:200:3: ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_
				{
				DebugLocation(200, 3);
				// MathLang.g:200:3: ( const_ )*
				try { DebugEnterSubRule(42);
				while (true)
				{
					int alt42=2;
					try { DebugEnterDecision(42, decisionCanBacktrack[42]);
					int LA42_0 = input.LA(1);

					if ((LA42_0==CONST_))
					{
						alt42=1;
					}


					} finally { DebugExitDecision(42); }
					switch ( alt42 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: const_
						{
						DebugLocation(200, 3);
						PushFollow(Follow._const__in_program2091);
						const_163=const_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_163.Tree);

						}
						break;

					default:
						goto loop42;
					}
				}

				loop42:
					;

				} finally { DebugExitSubRule(42); }

				DebugLocation(200, 11);
				// MathLang.g:200:11: ( vars )+
				int cnt43=0;
				try { DebugEnterSubRule(43);
				while (true)
				{
					int alt43=2;
					try { DebugEnterDecision(43, decisionCanBacktrack[43]);
					int LA43_0 = input.LA(1);

					if ((LA43_0==VAR))
					{
						int LA43_3 = input.LA(2);

						if ((EvaluatePredicate(synpred94_MathLang_fragment)))
						{
							alt43=1;
						}


					}


					} finally { DebugExitDecision(43); }
					switch (alt43)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(200, 11);
						PushFollow(Follow._vars_in_program2094);
						vars164=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars164.Tree);

						}
						break;

					default:
						if (cnt43 >= 1)
							goto loop43;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee43 = new EarlyExitException( 43, input );
						DebugRecognitionException(eee43);
						throw eee43;
					}
					cnt43++;
				}
				loop43:
					;

				} finally { DebugExitSubRule(43); }

				DebugLocation(200, 18);
				// MathLang.g:200:18: ( func_decl | proc_decl )*
				try { DebugEnterSubRule(44);
				while (true)
				{
					int alt44=3;
					try { DebugEnterDecision(44, decisionCanBacktrack[44]);
					int LA44_0 = input.LA(1);

					if ((LA44_0==FUNC))
					{
						alt44=1;
					}
					else if ((LA44_0==PROC))
					{
						alt44=2;
					}


					} finally { DebugExitDecision(44); }
					switch ( alt44 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:200:19: func_decl
						{
						DebugLocation(200, 19);
						PushFollow(Follow._func_decl_in_program2099);
						func_decl165=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl165.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:200:29: proc_decl
						{
						DebugLocation(200, 29);
						PushFollow(Follow._proc_decl_in_program2101);
						proc_decl166=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl166.Tree);

						}
						break;

					default:
						goto loop44;
					}
				}

				loop44:
					;

				} finally { DebugExitSubRule(44); }

				DebugLocation(200, 41);
				// MathLang.g:200:41: ( vars )*
				try { DebugEnterSubRule(45);
				while (true)
				{
					int alt45=2;
					try { DebugEnterDecision(45, decisionCanBacktrack[45]);
					int LA45_0 = input.LA(1);

					if ((LA45_0==VAR))
					{
						alt45=1;
					}


					} finally { DebugExitDecision(45); }
					switch ( alt45 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(200, 41);
						PushFollow(Follow._vars_in_program2105);
						vars167=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars167.Tree);

						}
						break;

					default:
						goto loop45;
					}
				}

				loop45:
					;

				} finally { DebugExitSubRule(45); }

				DebugLocation(200, 47);
				PushFollow(Follow._main__in_program2108);
				main_168=main_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, main_168.Tree);

				}


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 28);
			LeaveRule("program", 28);
			Leave_program();
		}
		DebugLocation(201, 0);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:203:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 29);
		TraceIn("result", 29);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF170=null;
		MathLangParser.program_return program169 = default(MathLangParser.program_return);

		object EOF170_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(203, 41);
		try
		{
			// MathLang.g:203:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// MathLang.g:203:9: program EOF
			{
			DebugLocation(203, 9);
			PushFollow(Follow._program_in_result2117);
			program169=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_program.Add(program169.Tree);
			DebugLocation(203, 17);
			EOF170=(IToken)Match(input,EOF,Follow._EOF_in_result2119); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF170);



			{
			// AST REWRITE
			// elements: program
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 203:21: -> ^( PROGRAM program )
			{
				DebugLocation(203, 24);
				// MathLang.g:203:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(203, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(203, 34);
				adaptor.AddChild(root_1, stream_program.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 29);
			LeaveRule("result", 29);
			Leave_result();
		}
		DebugLocation(203, 41);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:205:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 30);
		TraceIn("execute", 30);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result171 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(205, 0);
		try
		{
			// MathLang.g:205:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:206:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(206, 3);
			PushFollow(Follow._result_in_execute2138);
			result171=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result171.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 30);
			LeaveRule("execute", 30);
			Leave_execute();
		}
		DebugLocation(207, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred53_MathLang_fragment();
	partial void Leave_synpred53_MathLang_fragment();

	// $ANTLR start synpred53_MathLang
	public void synpred53_MathLang_fragment()
	{
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);

		Enter_synpred53_MathLang_fragment();
		EnterRule("synpred53_MathLang_fragment", 83);
		TraceIn("synpred53_MathLang_fragment", 83);
		try
		{
			// MathLang.g:135:42: ( ELSIF t2= term THEN lst2= exprList )
			DebugEnterAlt(1);
			// MathLang.g:135:42: ELSIF t2= term THEN lst2= exprList
			{
			DebugLocation(135, 42);
			Match(input,ELSIF,Follow._ELSIF_in_synpred53_MathLang1451); if (state.failed) return;
			DebugLocation(135, 50);
			PushFollow(Follow._term_in_synpred53_MathLang1455);
			t2=term();
			PopFollow();
			if (state.failed) return;
			DebugLocation(135, 56);
			Match(input,THEN,Follow._THEN_in_synpred53_MathLang1457); if (state.failed) return;
			DebugLocation(135, 65);
			PushFollow(Follow._exprList_in_synpred53_MathLang1461);
			lst2=exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred53_MathLang_fragment", 83);
			LeaveRule("synpred53_MathLang_fragment", 83);
			Leave_synpred53_MathLang_fragment();
		}
	}
	// $ANTLR end synpred53_MathLang

	partial void Enter_synpred54_MathLang_fragment();
	partial void Leave_synpred54_MathLang_fragment();

	// $ANTLR start synpred54_MathLang
	public void synpred54_MathLang_fragment()
	{
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);

		Enter_synpred54_MathLang_fragment();
		EnterRule("synpred54_MathLang_fragment", 84);
		TraceIn("synpred54_MathLang_fragment", 84);
		try
		{
			// MathLang.g:135:78: ( ELSE lst3= exprList )
			DebugEnterAlt(1);
			// MathLang.g:135:78: ELSE lst3= exprList
			{
			DebugLocation(135, 78);
			Match(input,ELSE,Follow._ELSE_in_synpred54_MathLang1466); if (state.failed) return;
			DebugLocation(135, 87);
			PushFollow(Follow._exprList_in_synpred54_MathLang1470);
			lst3=exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred54_MathLang_fragment", 84);
			LeaveRule("synpred54_MathLang_fragment", 84);
			Leave_synpred54_MathLang_fragment();
		}
	}
	// $ANTLR end synpred54_MathLang

	partial void Enter_synpred77_MathLang_fragment();
	partial void Leave_synpred77_MathLang_fragment();

	// $ANTLR start synpred77_MathLang
	public void synpred77_MathLang_fragment()
	{
		Enter_synpred77_MathLang_fragment();
		EnterRule("synpred77_MathLang_fragment", 107);
		TraceIn("synpred77_MathLang_fragment", 107);
		try
		{
			// MathLang.g:173:33: ( ';' type_decl )
			DebugEnterAlt(1);
			// MathLang.g:173:33: ';' type_decl
			{
			DebugLocation(173, 33);
			Match(input,69,Follow._69_in_synpred77_MathLang1870); if (state.failed) return;
			DebugLocation(173, 37);
			PushFollow(Follow._type_decl_in_synpred77_MathLang1872);
			type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred77_MathLang_fragment", 107);
			LeaveRule("synpred77_MathLang_fragment", 107);
			Leave_synpred77_MathLang_fragment();
		}
	}
	// $ANTLR end synpred77_MathLang

	partial void Enter_synpred79_MathLang_fragment();
	partial void Leave_synpred79_MathLang_fragment();

	// $ANTLR start synpred79_MathLang
	public void synpred79_MathLang_fragment()
	{
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);

		Enter_synpred79_MathLang_fragment();
		EnterRule("synpred79_MathLang_fragment", 109);
		TraceIn("synpred79_MathLang_fragment", 109);
		try
		{
			// MathLang.g:173:61: (t2= type_decl )
			DebugEnterAlt(1);
			// MathLang.g:173:61: t2= type_decl
			{
			DebugLocation(173, 61);
			PushFollow(Follow._type_decl_in_synpred79_MathLang1884);
			t2=type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred79_MathLang_fragment", 109);
			LeaveRule("synpred79_MathLang_fragment", 109);
			Leave_synpred79_MathLang_fragment();
		}
	}
	// $ANTLR end synpred79_MathLang

	partial void Enter_synpred86_MathLang_fragment();
	partial void Leave_synpred86_MathLang_fragment();

	// $ANTLR start synpred86_MathLang
	public void synpred86_MathLang_fragment()
	{
		Enter_synpred86_MathLang_fragment();
		EnterRule("synpred86_MathLang_fragment", 116);
		TraceIn("synpred86_MathLang_fragment", 116);
		try
		{
			// MathLang.g:190:16: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:190:16: ';'
			{
			DebugLocation(190, 16);
			Match(input,69,Follow._69_in_synpred86_MathLang2038); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred86_MathLang_fragment", 116);
			LeaveRule("synpred86_MathLang_fragment", 116);
			Leave_synpred86_MathLang_fragment();
		}
	}
	// $ANTLR end synpred86_MathLang

	partial void Enter_synpred88_MathLang_fragment();
	partial void Leave_synpred88_MathLang_fragment();

	// $ANTLR start synpred88_MathLang
	public void synpred88_MathLang_fragment()
	{
		Enter_synpred88_MathLang_fragment();
		EnterRule("synpred88_MathLang_fragment", 118);
		TraceIn("synpred88_MathLang_fragment", 118);
		try
		{
			// MathLang.g:191:14: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:191:14: ';'
			{
			DebugLocation(191, 14);
			Match(input,69,Follow._69_in_synpred88_MathLang2049); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred88_MathLang_fragment", 118);
			LeaveRule("synpred88_MathLang_fragment", 118);
			Leave_synpred88_MathLang_fragment();
		}
	}
	// $ANTLR end synpred88_MathLang

	partial void Enter_synpred94_MathLang_fragment();
	partial void Leave_synpred94_MathLang_fragment();

	// $ANTLR start synpred94_MathLang
	public void synpred94_MathLang_fragment()
	{
		Enter_synpred94_MathLang_fragment();
		EnterRule("synpred94_MathLang_fragment", 124);
		TraceIn("synpred94_MathLang_fragment", 124);
		try
		{
			// MathLang.g:200:11: ( vars )
			DebugEnterAlt(1);
			// MathLang.g:200:11: vars
			{
			DebugLocation(200, 11);
			PushFollow(Follow._vars_in_synpred94_MathLang2094);
			vars();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred94_MathLang_fragment", 124);
			LeaveRule("synpred94_MathLang_fragment", 124);
			Leave_synpred94_MathLang_fragment();
		}
	}
	// $ANTLR end synpred94_MathLang
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA8 dfa8;
	DFA19 dfa19;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa8 = new DFA8( this );
		dfa19 = new DFA19( this );
	}

	private class DFA8 : DFA
	{
		private const string DFA8_eotS =
			"\xA\xFFFF";
		private const string DFA8_eofS =
			"\xA\xFFFF";
		private const string DFA8_minS =
			"\x1\x24\x1\x35\x2\xFFFF\x1\x4\x3\xFFFF\x1\x6\x1\xFFFF";
		private const string DFA8_maxS =
			"\x1\x3C\x1\x3F\x2\xFFFF\x1\x51\x3\xFFFF\x1\x45\x1\xFFFF";
		private const string DFA8_acceptS =
			"\x2\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x5\x1\x6\x1\x2\x1\xFFFF\x1\x1";
		private const string DFA8_specialS =
			"\xA\xFFFF}>";
		private static readonly string[] DFA8_transitionS =
			{
				"\x1\x2\xB\xFFFF\x1\x1\xB\xFFFF\x1\x3",
				"\x1\x4\x7\xFFFF\x1\x6\x1\xFFFF\x1\x5",
				"",
				"",
				"\x2\x9\x29\xFFFF\x1\x9\x1\x8\xC\xFFFF\x1\x9\x13\xFFFF\x1\x7",
				"",
				"",
				"",
				"\x2\x9\xA\xFFFF\x2\x9\x1D\xFFFF\x4\x9\x1\xFFFF\x6\x9\x1\xFFFF\x1\x6"+
				"\x1\xFFFF\x1\x9\x5\xFFFF\x1\x9",
				""
			};

		private static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
		private static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
		private static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
		private static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
		private static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
		private static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
		private static readonly short[][] DFA8_transition;

		static DFA8()
		{
			int numStates = DFA8_transitionS.Length;
			DFA8_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA8_transition[i] = DFA.UnpackEncodedString(DFA8_transitionS[i]);
			}
		}

		public DFA8( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 8;
			this.eot = DFA8_eot;
			this.eof = DFA8_eof;
			this.min = DFA8_min;
			this.max = DFA8_max;
			this.accept = DFA8_accept;
			this.special = DFA8_special;
			this.transition = DFA8_transition;
		}

		public override string Description { get { return "125:1: simpleExpr : ( IDENT ASSIGN term | IDENT ASSIGN '\\'' charValue '\\'' | PRINT term | PRINTSTR term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA19 : DFA
	{
		private const string DFA19_eotS =
			"\x7\xFFFF";
		private const string DFA19_eofS =
			"\x7\xFFFF";
		private const string DFA19_minS =
			"\x3\x30\x1\x1B\x1\xFFFF\x1\x30\x1\xFFFF";
		private const string DFA19_maxS =
			"\x1\x30\x1\x4F\x1\x30\x1\x27\x1\xFFFF\x1\x4F\x1\xFFFF";
		private const string DFA19_acceptS =
			"\x4\xFFFF\x1\x1\x1\xFFFF\x1\x2";
		private const string DFA19_specialS =
			"\x7\xFFFF}>";
		private static readonly string[] DFA19_transitionS =
			{
				"\x1\x1",
				"\x1\x4\x13\xFFFF\x1\x3\xA\xFFFF\x1\x2",
				"\x1\x5",
				"\x4\x4\x8\xFFFF\x1\x6",
				"",
				"\x1\x4\x13\xFFFF\x1\x3\xA\xFFFF\x1\x2",
				""
			};

		private static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
		private static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
		private static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
		private static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
		private static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
		private static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
		private static readonly short[][] DFA19_transition;

		static DFA19()
		{
			int numStates = DFA19_transitionS.Length;
			DFA19_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA19_transition[i] = DFA.UnpackEncodedString(DFA19_transitionS[i]);
			}
		}

		public DFA19( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 19;
			this.eot = DFA19_eot;
			this.eof = DFA19_eof;
			this.min = DFA19_min;
			this.max = DFA19_max;
			this.accept = DFA19_accept;
			this.special = DFA19_special;
			this.transition = DFA19_transition;
		}

		public override string Description { get { return "152:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _61_in_group1058 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_group1061 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_group1063 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_value_in_group1068 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1072 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1076 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1081 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_group1083 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _index__in_group1085 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_group1086 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult1106 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _set_in_mult1110 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_mult1121 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _mult_in_add1133 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _set_in_add1138 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _mult_in_add1149 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _add_in_compare1161 = new BitSet(new ulong[]{0xFC0000000000002UL});
		public static readonly BitSet _set_in_compare1164 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _add_in_compare1191 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_div1199 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _set_in_div1201 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _compare_in_div1210 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _div_in_and_logic1217 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _AND_in_and_logic1220 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _div_in_and_logic1223 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _and_logic_in_or_logic1231 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or_logic1234 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _and_logic_in_or_logic1237 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _or_logic_in_term1245 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_logic_value0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_index_1282 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_charValue0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1352 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1354 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1357 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1361 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1363 = new BitSet(new ulong[]{0x0UL,0x20000UL});
		public static readonly BitSet _81_in_simpleExpr1366 = new BitSet(new ulong[]{0xEC1E000000000000UL,0x1FFFFUL});
		public static readonly BitSet _charValue_in_simpleExpr1368 = new BitSet(new ulong[]{0x0UL,0x20000UL});
		public static readonly BitSet _81_in_simpleExpr1370 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINT_in_simpleExpr1374 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1377 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINTSTR_in_simpleExpr1381 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1384 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1389 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_simpleExpr1391 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _index__in_simpleExpr1393 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_simpleExpr1394 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1396 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_in_simpleExpr1423 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_groupExpr1434 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1436 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1440 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_groupExpr1442 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1444 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1448 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSIF_in_groupExpr1451 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1455 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1457 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1461 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSE_in_groupExpr1466 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1470 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_groupExpr1511 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_groupExpr1513 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_groupExpr1515 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1519 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _TO_in_groupExpr1521 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1525 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1527 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1529 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_groupExpr1558 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1561 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1563 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_groupExpr1564 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1567 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1570 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_groupExpr1574 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1577 = new BitSet(new ulong[]{0x10010C1407104000UL});
		public static readonly BitSet _UNTIL_in_groupExpr1580 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1583 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1587 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1589 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _END_in_groupExpr1592 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_groupExpr1594 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_groupExpr1606 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_groupExpr1609 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_const_decl1619 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _EQUALS_in_const_decl1622 = new BitSet(new ulong[]{0x1800000000000UL});
		public static readonly BitSet _set_in_const_decl1625 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_const_decl1632 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _CONST__in_const_1643 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _const_decl_in_const_1646 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _IDENT_in_type_decl1659 = new BitSet(new ulong[]{0x1000000000000UL,0x8010UL});
		public static readonly BitSet _79_in_type_decl1662 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1664 = new BitSet(new ulong[]{0x1000000000000UL,0x8010UL});
		public static readonly BitSet _68_in_type_decl1670 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1672 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_type_decl1684 = new BitSet(new ulong[]{0x0UL,0x8010UL});
		public static readonly BitSet _79_in_type_decl1687 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1689 = new BitSet(new ulong[]{0x0UL,0x8010UL});
		public static readonly BitSet _68_in_type_decl1692 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ARRAY_in_type_decl1694 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_type_decl1696 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_type_decl1698 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_type_decl1700 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_type_decl1701 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_type_decl1702 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_type_decl1704 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _OF_in_type_decl1706 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1708 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_vars1733 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_vars1737 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_vars1739 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _term_in_param1750 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _param_in_params_1759 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _79_in_params_1761 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _param_in_params_1763 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _FUNC_in_func_sign1785 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_func_sign1787 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_func_sign1789 = new BitSet(new ulong[]{0x4001000000000000UL,0x20UL});
		public static readonly BitSet _type_decl_in_func_sign1795 = new BitSet(new ulong[]{0x4001000000000000UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1798 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1800 = new BitSet(new ulong[]{0x4001000000000000UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1806 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _VAR_in_func_sign1808 = new BitSet(new ulong[]{0x4001000000000000UL,0x20UL});
		public static readonly BitSet _type_decl_in_func_sign1812 = new BitSet(new ulong[]{0x4001000000000000UL,0x20UL});
		public static readonly BitSet _62_in_func_sign1816 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_func_sign1818 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_func_sign1820 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1822 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_in_proc_sign1857 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_proc_sign1859 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_proc_sign1861 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1867 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1870 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1872 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1876 = new BitSet(new ulong[]{0x1000200000000UL});
		public static readonly BitSet _VAR_in_proc_sign1880 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1884 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _62_in_proc_sign1888 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1890 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_sign_in_func_decl1924 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_decl1927 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _const__in_func_decl1930 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _vars_in_func_decl1933 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _groupExpr_in_func_decl1936 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_decl1938 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_sign_in_proc_decl1947 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_decl1950 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _const__in_proc_decl1953 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _vars_in_proc_decl1956 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _groupExpr_in_proc_decl1959 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_decl1961 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1970 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call1972 = new BitSet(new ulong[]{0x6001800000000030UL});
		public static readonly BitSet _params__in_call1974 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_call1976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1993 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_call1995 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_call1999 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call2001 = new BitSet(new ulong[]{0x6001800000000030UL});
		public static readonly BitSet _params__in_call2003 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_call2005 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList2035 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_exprList2038 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _groupExpr_in_exprList2046 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_exprList2049 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _BEGIN_in_main_2062 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _exprList_in_main_2065 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _END_in_main_2068 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_main_2071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_program2082 = new BitSet(new ulong[]{0x10010C1403104002UL});
		public static readonly BitSet _proc_decl_in_program2085 = new BitSet(new ulong[]{0x10010C1403104002UL});
		public static readonly BitSet _const__in_program2091 = new BitSet(new ulong[]{0x20200000000UL});
		public static readonly BitSet _vars_in_program2094 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _func_decl_in_program2099 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _proc_decl_in_program2101 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _vars_in_program2105 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _main__in_program2108 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result2117 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result2119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute2138 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSIF_in_synpred53_MathLang1451 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_synpred53_MathLang1455 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_synpred53_MathLang1457 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_synpred53_MathLang1461 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred54_MathLang1466 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_synpred54_MathLang1470 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred77_MathLang1870 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_synpred77_MathLang1872 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_decl_in_synpred79_MathLang1884 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred86_MathLang2038 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred88_MathLang2049 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _vars_in_synpred94_MathLang2094 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
