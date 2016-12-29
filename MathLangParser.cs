// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2016-12-29 21:28:45

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TRUE", "FALSE", "AND", "OR", "UNKNOWN", "SCOPEBLOCK", "BLOCK", "PROGRAM", "CONVERT", "INDEX", "IF", "THEN", "ELSE", "ELSIF", "DIV", "MOD", "FOR", "TO", "DOWNTO", "DO", "WHILE", "REPEAT", "UNTIL", "INT", "REAL", "CHAR", "BOOL", "CALL", "PARAMS", "VAR", "BEGIN", "END", "PRINT", "RINTSTR", "INPUT", "ARRAY", "OF", "CONST_", "FUNC", "PROC", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIDE", "ASSIGN", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "PRINTSTR", "'('", "')'", "'['", "']'", "';'", "','", "':'", "'.'"
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
				false, false, false, false, true, false, true, false, false, false, 
				false, false, false, true, true, false, false, false, false, false, 
				true, false, false, false, , , , , , , , , , , , , , , , 
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
	// MathLang.g:95:1: group : ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) );
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
		DebugLocation(95, 0);
		try
		{
			// MathLang.g:95:6: ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) )
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
				else if ((LA1_4==EOF||(LA1_4>=AND && LA1_4<=OR)||(LA1_4>=IF && LA1_4<=TO)||(LA1_4>=DO && LA1_4<=UNTIL)||(LA1_4>=BEGIN && LA1_4<=PRINT)||(LA1_4>=FUNC && LA1_4<=PROC)||(LA1_4>=IDENT && LA1_4<=DIVIDE)||(LA1_4>=GE && LA1_4<=PRINTSTR)||LA1_4==62||(LA1_4>=64 && LA1_4<=66)||LA1_4==68))
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
				// MathLang.g:96:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 6);
				char_literal1=(IToken)Match(input,61,Follow._61_in_group1057); if (state.failed) return retval;
				DebugLocation(96, 8);
				PushFollow(Follow._term_in_group1060);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(96, 16);
				char_literal3=(IToken)Match(input,62,Follow._62_in_group1062); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:97:3: logic_value
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 3);
				PushFollow(Follow._logic_value_in_group1067);
				logic_value4=logic_value();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_value4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:98:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(98, 3);
				NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group1071); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER5_tree = (object)adaptor.Create(NUMBER5);
				adaptor.AddChild(root_0, NUMBER5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:99:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(99, 3);
				IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_group1075); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT6_tree = (object)adaptor.Create(IDENT6);
				adaptor.AddChild(root_0, IDENT6_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:100:3: ( IDENT '[' index_ ']' )
				{
				DebugLocation(100, 3);
				// MathLang.g:100:3: ( IDENT '[' index_ ']' )
				DebugEnterAlt(1);
				// MathLang.g:100:4: IDENT '[' index_ ']'
				{
				DebugLocation(100, 4);
				IDENT7=(IToken)Match(input,IDENT,Follow._IDENT_in_group1080); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT7);

				DebugLocation(100, 10);
				char_literal8=(IToken)Match(input,63,Follow._63_in_group1082); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal8);

				DebugLocation(100, 14);
				PushFollow(Follow._index__in_group1084);
				index_9=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_9.Tree);
				DebugLocation(100, 20);
				char_literal10=(IToken)Match(input,64,Follow._64_in_group1085); if (state.failed) return retval; 
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
				// 100:25: -> ^( IDENT ^( INDEX index_ ) )
				{
					DebugLocation(100, 27);
					// MathLang.g:100:27: ^( IDENT ^( INDEX index_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(100, 29);
					root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

					DebugLocation(100, 35);
					// MathLang.g:100:35: ^( INDEX index_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(100, 37);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_2);

					DebugLocation(100, 43);
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
		DebugLocation(101, 0);
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
	// MathLang.g:103:1: mult : group ( ( MUL | DIVIDE ) group )* ;
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
		DebugLocation(103, 42);
		try
		{
			// MathLang.g:103:5: ( group ( ( MUL | DIVIDE ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:103:7: group ( ( MUL | DIVIDE ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 7);
			PushFollow(Follow._group_in_mult1105);
			group11=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);
			DebugLocation(103, 13);
			// MathLang.g:103:13: ( ( MUL | DIVIDE ) group )*
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
					// MathLang.g:103:15: ( MUL | DIVIDE ) group
					{
					DebugLocation(103, 15);
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

					DebugLocation(103, 33);
					PushFollow(Follow._group_in_mult1120);
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
		DebugLocation(103, 42);
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
	// MathLang.g:104:1: add : mult ( ( ADD | SUB ) mult )* ;
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
		DebugLocation(104, 39);
		try
		{
			// MathLang.g:104:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:104:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 7);
			PushFollow(Follow._mult_in_add1132);
			mult14=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);
			DebugLocation(104, 13);
			// MathLang.g:104:13: ( ( ADD | SUB ) mult )*
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
					// MathLang.g:104:15: ( ADD | SUB ) mult
					{
					DebugLocation(104, 15);
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

					DebugLocation(104, 30);
					PushFollow(Follow._mult_in_add1148);
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
		DebugLocation(104, 39);
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
	// MathLang.g:105:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
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
		DebugLocation(105, 61);
		try
		{
			// MathLang.g:105:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:105:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 10);
			PushFollow(Follow._add_in_compare1160);
			add17=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
			DebugLocation(105, 14);
			// MathLang.g:105:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
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
				// MathLang.g:105:15: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(105, 15);
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

				DebugLocation(105, 57);
				PushFollow(Follow._add_in_compare1190);
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
		DebugLocation(105, 61);
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
	// MathLang.g:106:1: div : compare ( ( DIV | MOD ) compare )* ;
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
		DebugLocation(106, 35);
		try
		{
			// MathLang.g:106:4: ( compare ( ( DIV | MOD ) compare )* )
			DebugEnterAlt(1);
			// MathLang.g:106:6: compare ( ( DIV | MOD ) compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 6);
			PushFollow(Follow._compare_in_div1198);
			compare20=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare20.Tree);
			DebugLocation(106, 13);
			// MathLang.g:106:13: ( ( DIV | MOD ) compare )*
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
					// MathLang.g:106:14: ( DIV | MOD ) compare
					{
					DebugLocation(106, 14);
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

					DebugLocation(106, 27);
					PushFollow(Follow._compare_in_div1209);
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
		DebugLocation(106, 35);
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
	// MathLang.g:107:1: and_logic : div ( AND div )* ;
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
		DebugLocation(107, 25);
		try
		{
			// MathLang.g:107:10: ( div ( AND div )* )
			DebugEnterAlt(1);
			// MathLang.g:107:11: div ( AND div )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 11);
			PushFollow(Follow._div_in_and_logic1216);
			div23=div();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div23.Tree);
			DebugLocation(107, 15);
			// MathLang.g:107:15: ( AND div )*
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
					// MathLang.g:107:16: AND div
					{
					DebugLocation(107, 19);
					AND24=(IToken)Match(input,AND,Follow._AND_in_and_logic1219); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND24_tree = (object)adaptor.Create(AND24);
					root_0 = (object)adaptor.BecomeRoot(AND24_tree, root_0);
					}
					DebugLocation(107, 21);
					PushFollow(Follow._div_in_and_logic1222);
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
		DebugLocation(107, 25);
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
	// MathLang.g:108:1: or_logic : and_logic ( OR and_logic )* ;
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
		DebugLocation(108, 36);
		try
		{
			// MathLang.g:108:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:108:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 11);
			PushFollow(Follow._and_logic_in_or_logic1230);
			and_logic26=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic26.Tree);
			DebugLocation(108, 21);
			// MathLang.g:108:21: ( OR and_logic )*
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
					// MathLang.g:108:22: OR and_logic
					{
					DebugLocation(108, 24);
					OR27=(IToken)Match(input,OR,Follow._OR_in_or_logic1233); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR27_tree = (object)adaptor.Create(OR27);
					root_0 = (object)adaptor.BecomeRoot(OR27_tree, root_0);
					}
					DebugLocation(108, 26);
					PushFollow(Follow._and_logic_in_or_logic1236);
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
		DebugLocation(108, 36);
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
	// MathLang.g:109:1: term : or_logic ;
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
		DebugLocation(109, 14);
		try
		{
			// MathLang.g:109:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:109:7: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 7);
			PushFollow(Follow._or_logic_in_term1244);
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
		DebugLocation(109, 14);
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
	// MathLang.g:111:1: logic_value : ( TRUE | FALSE );
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
		DebugLocation(111, 24);
		try
		{
			// MathLang.g:111:12: ( TRUE | FALSE )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 12);
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
		DebugLocation(111, 24);
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
	// MathLang.g:113:1: type : ( INT | REAL | BOOL | CHAR );
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
		DebugLocation(113, 0);
		try
		{
			// MathLang.g:113:5: ( INT | REAL | BOOL | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(113, 5);
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
		DebugLocation(114, 0);
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
	// MathLang.g:116:1: index_ : ( IDENT | NUMBER );
	[GrammarRule("index_")]
	private MathLangParser.index__return index_()
	{
		Enter_index_();
		EnterRule("index_", 11);
		TraceIn("index_", 11);
		MathLangParser.index__return retval = new MathLangParser.index__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set32=null;

		object set32_tree=null;

		try { DebugEnterRule(GrammarFileName, "index_");
		DebugLocation(116, 0);
		try
		{
			// MathLang.g:116:7: ( IDENT | NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(116, 7);
			set32=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=IDENT))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set32));
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
			TraceOut("index_", 11);
			LeaveRule("index_", 11);
			Leave_index_();
		}
		DebugLocation(117, 0);
		} finally { DebugExitRule(GrammarFileName, "index_"); }
		return retval;

	}
	// $ANTLR end "index_"

	public class simpleExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_simpleExpr();
	partial void Leave_simpleExpr();

	// $ANTLR start "simpleExpr"
	// MathLang.g:119:1: simpleExpr : ( IDENT ASSIGN term | PRINT term | PRINTSTR term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call );
	[GrammarRule("simpleExpr")]
	private MathLangParser.simpleExpr_return simpleExpr()
	{
		Enter_simpleExpr();
		EnterRule("simpleExpr", 12);
		TraceIn("simpleExpr", 12);
		MathLangParser.simpleExpr_return retval = new MathLangParser.simpleExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT33=null;
		IToken ASSIGN34=null;
		IToken PRINT36=null;
		IToken PRINTSTR38=null;
		IToken IDENT40=null;
		IToken char_literal41=null;
		IToken char_literal43=null;
		IToken ASSIGN44=null;
		MathLangParser.term_return term35 = default(MathLangParser.term_return);
		MathLangParser.term_return term37 = default(MathLangParser.term_return);
		MathLangParser.term_return term39 = default(MathLangParser.term_return);
		MathLangParser.index__return index_42 = default(MathLangParser.index__return);
		MathLangParser.term_return term45 = default(MathLangParser.term_return);
		MathLangParser.call_return call46 = default(MathLangParser.call_return);

		object IDENT33_tree=null;
		object ASSIGN34_tree=null;
		object PRINT36_tree=null;
		object PRINTSTR38_tree=null;
		object IDENT40_tree=null;
		object char_literal41_tree=null;
		object char_literal43_tree=null;
		object ASSIGN44_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(119, 0);
		try
		{
			// MathLang.g:119:11: ( IDENT ASSIGN term | PRINT term | PRINTSTR term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call )
			int alt8=5;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			switch (input.LA(1))
			{
			case IDENT:
				{
				switch (input.LA(2))
				{
				case ASSIGN:
					{
					int LA8_4 = input.LA(3);

					if ((LA8_4==IDENT))
					{
						int LA8_7 = input.LA(4);

						if ((LA8_7==61))
						{
							alt8=5;
						}
						else if (((LA8_7>=AND && LA8_7<=OR)||(LA8_7>=DIV && LA8_7<=MOD)||(LA8_7>=ADD && LA8_7<=DIVIDE)||(LA8_7>=GE && LA8_7<=LT)||LA8_7==63||LA8_7==65))
						{
							alt8=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 8, 7, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else if (((LA8_4>=TRUE && LA8_4<=FALSE)||LA8_4==NUMBER||LA8_4==61))
					{
						alt8=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 8, 4, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case 63:
					{
					alt8=4;
					}
					break;
				case 61:
					{
					alt8=5;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 8, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case PRINT:
				{
				alt8=2;
				}
				break;
			case PRINTSTR:
				{
				alt8=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:120:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(120, 3);
				IDENT33=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1293); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT33_tree = (object)adaptor.Create(IDENT33);
				adaptor.AddChild(root_0, IDENT33_tree);
				}
				DebugLocation(120, 15);
				ASSIGN34=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1295); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN34_tree = (object)adaptor.Create(ASSIGN34);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN34_tree, root_0);
				}
				DebugLocation(120, 17);
				PushFollow(Follow._term_in_simpleExpr1298);
				term35=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:121:3: PRINT term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(121, 8);
				PRINT36=(IToken)Match(input,PRINT,Follow._PRINT_in_simpleExpr1302); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINT36_tree = (object)adaptor.Create(PRINT36);
				root_0 = (object)adaptor.BecomeRoot(PRINT36_tree, root_0);
				}
				DebugLocation(121, 10);
				PushFollow(Follow._term_in_simpleExpr1305);
				term37=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term37.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:122:3: PRINTSTR term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 11);
				PRINTSTR38=(IToken)Match(input,PRINTSTR,Follow._PRINTSTR_in_simpleExpr1309); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINTSTR38_tree = (object)adaptor.Create(PRINTSTR38);
				root_0 = (object)adaptor.BecomeRoot(PRINTSTR38_tree, root_0);
				}
				DebugLocation(122, 13);
				PushFollow(Follow._term_in_simpleExpr1312);
				term39=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term39.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:123:2: ( IDENT '[' index_ ']' ASSIGN term )
				{
				DebugLocation(123, 2);
				// MathLang.g:123:2: ( IDENT '[' index_ ']' ASSIGN term )
				DebugEnterAlt(1);
				// MathLang.g:123:4: IDENT '[' index_ ']' ASSIGN term
				{
				DebugLocation(123, 4);
				IDENT40=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1317); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT40);

				DebugLocation(123, 10);
				char_literal41=(IToken)Match(input,63,Follow._63_in_simpleExpr1319); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal41);

				DebugLocation(123, 14);
				PushFollow(Follow._index__in_simpleExpr1321);
				index_42=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_42.Tree);
				DebugLocation(123, 20);
				char_literal43=(IToken)Match(input,64,Follow._64_in_simpleExpr1322); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal43);

				DebugLocation(123, 24);
				ASSIGN44=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1324); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN44);

				DebugLocation(123, 31);
				PushFollow(Follow._term_in_simpleExpr1326);
				term45=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(term45.Tree);

				}



				{
				// AST REWRITE
				// elements: term, index_, IDENT, ASSIGN
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 123:36: -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term )
				{
					DebugLocation(123, 39);
					// MathLang.g:123:39: ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(123, 41);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(123, 48);
					// MathLang.g:123:48: ^( IDENT ^( INDEX index_ ) )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(123, 51);
					root_2 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_2);

					DebugLocation(123, 57);
					// MathLang.g:123:57: ^( INDEX index_ )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(123, 59);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_3);

					DebugLocation(123, 66);
					adaptor.AddChild(root_3, stream_index_.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(123, 76);
					adaptor.AddChild(root_1, stream_term.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:124:3: call
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 3);
				PushFollow(Follow._call_in_simpleExpr1351);
				call46=call();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call46.Tree);

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
			TraceOut("simpleExpr", 12);
			LeaveRule("simpleExpr", 12);
			Leave_simpleExpr();
		}
		DebugLocation(125, 0);
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
	// MathLang.g:127:1: groupExpr : ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl );
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 13);
		TraceIn("groupExpr", 13);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF47=null;
		IToken char_literal48=null;
		IToken char_literal49=null;
		IToken THEN50=null;
		IToken ELSIF51=null;
		IToken THEN52=null;
		IToken ELSE53=null;
		IToken FOR54=null;
		IToken IDENT55=null;
		IToken ASSIGN56=null;
		IToken TO57=null;
		IToken DO58=null;
		IToken WHILE60=null;
		IToken char_literal61=null;
		IToken char_literal63=null;
		IToken DO64=null;
		IToken REPEAT66=null;
		IToken UNTIL68=null;
		IToken BEGIN70=null;
		IToken END72=null;
		IToken char_literal73=null;
		MathLangParser.term_return t1 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst = default(MathLangParser.exprList_return);
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList59 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term62 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList65 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList67 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term69 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList71 = default(MathLangParser.exprList_return);
		MathLangParser.func_decl_return func_decl74 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl75 = default(MathLangParser.proc_decl_return);

		object IF47_tree=null;
		object char_literal48_tree=null;
		object char_literal49_tree=null;
		object THEN50_tree=null;
		object ELSIF51_tree=null;
		object THEN52_tree=null;
		object ELSE53_tree=null;
		object FOR54_tree=null;
		object IDENT55_tree=null;
		object ASSIGN56_tree=null;
		object TO57_tree=null;
		object DO58_tree=null;
		object WHILE60_tree=null;
		object char_literal61_tree=null;
		object char_literal63_tree=null;
		object DO64_tree=null;
		object REPEAT66_tree=null;
		object UNTIL68_tree=null;
		object BEGIN70_tree=null;
		object END72_tree=null;
		object char_literal73_tree=null;
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
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(127, 0);
		try
		{
			// MathLang.g:127:10: ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl )
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
				// MathLang.g:128:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				{
				DebugLocation(128, 2);
				// MathLang.g:128:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				DebugEnterAlt(1);
				// MathLang.g:128:4: IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )?
				{
				DebugLocation(128, 4);
				IF47=(IToken)Match(input,IF,Follow._IF_in_groupExpr1362); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IF.Add(IF47);

				DebugLocation(128, 7);
				char_literal48=(IToken)Match(input,61,Follow._61_in_groupExpr1364); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal48);

				DebugLocation(128, 13);
				PushFollow(Follow._term_in_groupExpr1368);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(128, 19);
				char_literal49=(IToken)Match(input,62,Follow._62_in_groupExpr1370); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal49);

				DebugLocation(128, 23);
				THEN50=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1372); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_THEN.Add(THEN50);

				DebugLocation(128, 31);
				PushFollow(Follow._exprList_in_groupExpr1376);
				lst=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(lst.Tree);
				DebugLocation(128, 41);
				// MathLang.g:128:41: ( ELSIF t2= term THEN lst2= exprList )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==ELSIF))
					{
						int LA9_2 = input.LA(2);

						if ((EvaluatePredicate(synpred28_MathLang_fragment)))
						{
							alt9=1;
						}


					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:128:42: ELSIF t2= term THEN lst2= exprList
						{
						DebugLocation(128, 42);
						ELSIF51=(IToken)Match(input,ELSIF,Follow._ELSIF_in_groupExpr1379); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_ELSIF.Add(ELSIF51);

						DebugLocation(128, 50);
						PushFollow(Follow._term_in_groupExpr1383);
						t2=term();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
						DebugLocation(128, 56);
						THEN52=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1385); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_THEN.Add(THEN52);

						DebugLocation(128, 65);
						PushFollow(Follow._exprList_in_groupExpr1389);
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

				DebugLocation(128, 77);
				// MathLang.g:128:77: ( ELSE lst3= exprList )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==ELSE))
				{
					int LA10_1 = input.LA(2);

					if ((EvaluatePredicate(synpred29_MathLang_fragment)))
					{
						alt10=1;
					}
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:128:78: ELSE lst3= exprList
					{
					DebugLocation(128, 78);
					ELSE53=(IToken)Match(input,ELSE,Follow._ELSE_in_groupExpr1394); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE53);

					DebugLocation(128, 87);
					PushFollow(Follow._exprList_in_groupExpr1398);
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
				// elements: IF, t2, ELSIF, lst3, lst, ELSE, lst2, t1
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
				// 128:99: -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
				{
					DebugLocation(128, 101);
					// MathLang.g:128:101: ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(128, 103);
					root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

					DebugLocation(128, 106);
					adaptor.AddChild(root_1, stream_t1.NextTree());
					DebugLocation(128, 110);
					adaptor.AddChild(root_1, stream_lst.NextTree());
					DebugLocation(128, 115);
					// MathLang.g:128:115: ( ^( ELSIF $t2 $lst2) )*
					while ( stream_t2.HasNext||stream_ELSIF.HasNext||stream_lst2.HasNext )
					{
						DebugLocation(128, 116);
						// MathLang.g:128:116: ^( ELSIF $t2 $lst2)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(128, 118);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSIF.NextNode(), root_2);

						DebugLocation(128, 124);
						adaptor.AddChild(root_2, stream_t2.NextTree());
						DebugLocation(128, 128);
						adaptor.AddChild(root_2, stream_lst2.NextTree());

						adaptor.AddChild(root_1, root_2);
						}

					}
					stream_t2.Reset();
					stream_ELSIF.Reset();
					stream_lst2.Reset();
					DebugLocation(128, 137);
					// MathLang.g:128:137: ( ^( ELSE $lst3) )?
					if ( stream_lst3.HasNext||stream_ELSE.HasNext )
					{
						DebugLocation(128, 138);
						// MathLang.g:128:138: ^( ELSE $lst3)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(128, 140);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_2);

						DebugLocation(128, 145);
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
				// MathLang.g:129:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				{
				DebugLocation(129, 2);
				// MathLang.g:129:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				DebugEnterAlt(1);
				// MathLang.g:129:4: FOR IDENT ASSIGN t1= term TO t2= term DO exprList
				{
				DebugLocation(129, 4);
				FOR54=(IToken)Match(input,FOR,Follow._FOR_in_groupExpr1439); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR54);

				DebugLocation(129, 8);
				IDENT55=(IToken)Match(input,IDENT,Follow._IDENT_in_groupExpr1441); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT55);

				DebugLocation(129, 14);
				ASSIGN56=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_groupExpr1443); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN56);

				DebugLocation(129, 23);
				PushFollow(Follow._term_in_groupExpr1447);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(129, 29);
				TO57=(IToken)Match(input,TO,Follow._TO_in_groupExpr1449); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TO.Add(TO57);

				DebugLocation(129, 34);
				PushFollow(Follow._term_in_groupExpr1453);
				t2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
				DebugLocation(129, 40);
				DO58=(IToken)Match(input,DO,Follow._DO_in_groupExpr1455); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DO.Add(DO58);

				DebugLocation(129, 43);
				PushFollow(Follow._exprList_in_groupExpr1457);
				exprList59=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(exprList59.Tree);

				}



				{
				// AST REWRITE
				// elements: IDENT, IDENT, t2, exprList, ASSIGN, FOR, t1
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
				// 129:52: -> ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList )
				{
					DebugLocation(129, 54);
					// MathLang.g:129:54: ^( FOR ^( ASSIGN IDENT $t1) ^( LT IDENT $t2) exprList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(129, 56);
					root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

					DebugLocation(129, 60);
					// MathLang.g:129:60: ^( ASSIGN IDENT $t1)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(129, 62);
					root_2 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

					DebugLocation(129, 69);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(129, 75);
					adaptor.AddChild(root_2, stream_t1.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(129, 80);
					// MathLang.g:129:80: ^( LT IDENT $t2)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(129, 82);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LT, "LT"), root_2);

					DebugLocation(129, 85);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(129, 91);
					adaptor.AddChild(root_2, stream_t2.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(129, 96);
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
				// MathLang.g:130:3: WHILE '(' term ')' DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 8);
				WHILE60=(IToken)Match(input,WHILE,Follow._WHILE_in_groupExpr1486); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE60_tree = (object)adaptor.Create(WHILE60);
				root_0 = (object)adaptor.BecomeRoot(WHILE60_tree, root_0);
				}
				DebugLocation(130, 13);
				char_literal61=(IToken)Match(input,61,Follow._61_in_groupExpr1489); if (state.failed) return retval;
				DebugLocation(130, 14);
				PushFollow(Follow._term_in_groupExpr1491);
				term62=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term62.Tree);
				DebugLocation(130, 21);
				char_literal63=(IToken)Match(input,62,Follow._62_in_groupExpr1492); if (state.failed) return retval;
				DebugLocation(130, 25);
				DO64=(IToken)Match(input,DO,Follow._DO_in_groupExpr1495); if (state.failed) return retval;
				DebugLocation(130, 27);
				PushFollow(Follow._exprList_in_groupExpr1498);
				exprList65=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList65.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:131:3: REPEAT ( exprList )+ UNTIL term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 9);
				REPEAT66=(IToken)Match(input,REPEAT,Follow._REPEAT_in_groupExpr1502); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				REPEAT66_tree = (object)adaptor.Create(REPEAT66);
				root_0 = (object)adaptor.BecomeRoot(REPEAT66_tree, root_0);
				}
				DebugLocation(131, 11);
				// MathLang.g:131:11: ( exprList )+
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
						DebugLocation(131, 11);
						PushFollow(Follow._exprList_in_groupExpr1505);
						exprList67=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList67.Tree);

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

				DebugLocation(131, 26);
				UNTIL68=(IToken)Match(input,UNTIL,Follow._UNTIL_in_groupExpr1508); if (state.failed) return retval;
				DebugLocation(131, 28);
				PushFollow(Follow._term_in_groupExpr1511);
				term69=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term69.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:132:3: BEGIN ( exprList )+ END ';'
				{
				DebugLocation(132, 3);
				BEGIN70=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1515); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN70);

				DebugLocation(132, 9);
				// MathLang.g:132:9: ( exprList )+
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
						DebugLocation(132, 9);
						PushFollow(Follow._exprList_in_groupExpr1517);
						exprList71=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_exprList.Add(exprList71.Tree);

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

				DebugLocation(132, 19);
				END72=(IToken)Match(input,END,Follow._END_in_groupExpr1520); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END72);

				DebugLocation(132, 23);
				char_literal73=(IToken)Match(input,65,Follow._65_in_groupExpr1522); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal73);



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
				// 132:27: -> ^( BLOCK ( exprList )+ )
				{
					DebugLocation(132, 30);
					// MathLang.g:132:30: ^( BLOCK ( exprList )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(132, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(132, 38);
					if ( !(stream_exprList.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_exprList.HasNext )
					{
						DebugLocation(132, 38);
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
				// MathLang.g:133:2: func_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(133, 2);
				PushFollow(Follow._func_decl_in_groupExpr1534);
				func_decl74=func_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl74.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:134:2: proc_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(134, 2);
				PushFollow(Follow._proc_decl_in_groupExpr1537);
				proc_decl75=proc_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl75.Tree);

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
			TraceOut("groupExpr", 13);
			LeaveRule("groupExpr", 13);
			Leave_groupExpr();
		}
		DebugLocation(135, 0);
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
	// MathLang.g:138:1: const_decl : IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ ;
	[GrammarRule("const_decl")]
	private MathLangParser.const_decl_return const_decl()
	{
		Enter_const_decl();
		EnterRule("const_decl", 14);
		TraceIn("const_decl", 14);
		MathLangParser.const_decl_return retval = new MathLangParser.const_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT76=null;
		IToken EQUALS77=null;
		IToken set78=null;
		IToken char_literal79=null;

		object IDENT76_tree=null;
		object EQUALS77_tree=null;
		object set78_tree=null;
		object char_literal79_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_decl");
		DebugLocation(138, 0);
		try
		{
			// MathLang.g:138:11: ( IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:139:2: IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(139, 7);
			IDENT76=(IToken)Match(input,IDENT,Follow._IDENT_in_const_decl1547); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IDENT76_tree = (object)adaptor.Create(IDENT76);
			root_0 = (object)adaptor.BecomeRoot(IDENT76_tree, root_0);
			}
			DebugLocation(139, 15);
			EQUALS77=(IToken)Match(input,EQUALS,Follow._EQUALS_in_const_decl1550); if (state.failed) return retval;
			DebugLocation(139, 17);
			set78=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=IDENT))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set78));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(139, 32);
			// MathLang.g:139:32: ( ';' )+
			int cnt14=0;
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==65))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:139:33: ';'
					{
					DebugLocation(139, 36);
					char_literal79=(IToken)Match(input,65,Follow._65_in_const_decl1560); if (state.failed) return retval;

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
			TraceOut("const_decl", 14);
			LeaveRule("const_decl", 14);
			Leave_const_decl();
		}
		DebugLocation(140, 0);
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
	// MathLang.g:141:1: const_ : CONST_ ( const_decl )+ ;
	[GrammarRule("const_")]
	private MathLangParser.const__return const_()
	{
		Enter_const_();
		EnterRule("const_", 15);
		TraceIn("const_", 15);
		MathLangParser.const__return retval = new MathLangParser.const__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONST_80=null;
		MathLangParser.const_decl_return const_decl81 = default(MathLangParser.const_decl_return);

		object CONST_80_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_");
		DebugLocation(141, 0);
		try
		{
			// MathLang.g:141:7: ( CONST_ ( const_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:142:1: CONST_ ( const_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(142, 7);
			CONST_80=(IToken)Match(input,CONST_,Follow._CONST__in_const_1571); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_80_tree = (object)adaptor.Create(CONST_80);
			root_0 = (object)adaptor.BecomeRoot(CONST_80_tree, root_0);
			}
			DebugLocation(142, 9);
			// MathLang.g:142:9: ( const_decl )+
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
					DebugLocation(142, 9);
					PushFollow(Follow._const_decl_in_const_1574);
					const_decl81=const_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_decl81.Tree);

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
			TraceOut("const_", 15);
			LeaveRule("const_", 15);
			Leave_const_();
		}
		DebugLocation(143, 0);
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
	// MathLang.g:145:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );
	[GrammarRule("type_decl")]
	private MathLangParser.type_decl_return type_decl()
	{
		Enter_type_decl();
		EnterRule("type_decl", 16);
		TraceIn("type_decl", 16);
		MathLangParser.type_decl_return retval = new MathLangParser.type_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT82=null;
		IToken char_literal83=null;
		IToken IDENT84=null;
		IToken char_literal85=null;
		IToken IDENT87=null;
		IToken char_literal88=null;
		IToken IDENT89=null;
		IToken char_literal90=null;
		IToken ARRAY91=null;
		IToken char_literal92=null;
		IToken char_literal94=null;
		IToken char_literal95=null;
		IToken char_literal97=null;
		IToken OF98=null;
		MathLangParser.type_return type86 = default(MathLangParser.type_return);
		MathLangParser.group_return group93 = default(MathLangParser.group_return);
		MathLangParser.group_return group96 = default(MathLangParser.group_return);
		MathLangParser.type_return type99 = default(MathLangParser.type_return);

		object IDENT82_tree=null;
		object char_literal83_tree=null;
		object IDENT84_tree=null;
		object char_literal85_tree=null;
		object IDENT87_tree=null;
		object char_literal88_tree=null;
		object IDENT89_tree=null;
		object char_literal90_tree=null;
		object ARRAY91_tree=null;
		object char_literal92_tree=null;
		object char_literal94_tree=null;
		object char_literal95_tree=null;
		object char_literal97_tree=null;
		object OF98_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type_decl");
		DebugLocation(145, 0);
		try
		{
			// MathLang.g:145:10: ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) )
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
				// MathLang.g:146:2: ( ( IDENT ( ',' IDENT )* )+ ) ':' type
				{
				DebugLocation(146, 2);
				// MathLang.g:146:2: ( ( IDENT ( ',' IDENT )* )+ )
				DebugEnterAlt(1);
				// MathLang.g:146:4: ( IDENT ( ',' IDENT )* )+
				{
				DebugLocation(146, 4);
				// MathLang.g:146:4: ( IDENT ( ',' IDENT )* )+
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
						// MathLang.g:146:5: IDENT ( ',' IDENT )*
						{
						DebugLocation(146, 5);
						IDENT82=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1587); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT82);

						DebugLocation(146, 11);
						// MathLang.g:146:11: ( ',' IDENT )*
						try { DebugEnterSubRule(16);
						while (true)
						{
							int alt16=2;
							try { DebugEnterDecision(16, decisionCanBacktrack[16]);
							int LA16_0 = input.LA(1);

							if ((LA16_0==66))
							{
								alt16=1;
							}


							} finally { DebugExitDecision(16); }
							switch ( alt16 )
							{
							case 1:
								DebugEnterAlt(1);
								// MathLang.g:146:12: ',' IDENT
								{
								DebugLocation(146, 12);
								char_literal83=(IToken)Match(input,66,Follow._66_in_type_decl1590); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_66.Add(char_literal83);

								DebugLocation(146, 16);
								IDENT84=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1592); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT84);


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

				DebugLocation(146, 26);
				char_literal85=(IToken)Match(input,67,Follow._67_in_type_decl1598); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_67.Add(char_literal85);

				DebugLocation(146, 30);
				PushFollow(Follow._type_in_type_decl1600);
				type86=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type86.Tree);


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
				// 146:34: -> ^( type ( IDENT )+ )
				{
					DebugLocation(146, 37);
					// MathLang.g:146:37: ^( type ( IDENT )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(146, 39);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(146, 44);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(146, 44);
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
				// MathLang.g:147:3: IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type
				{
				DebugLocation(147, 3);
				IDENT87=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1612); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT87);

				DebugLocation(147, 9);
				// MathLang.g:147:9: ( ',' IDENT )*
				try { DebugEnterSubRule(18);
				while (true)
				{
					int alt18=2;
					try { DebugEnterDecision(18, decisionCanBacktrack[18]);
					int LA18_0 = input.LA(1);

					if ((LA18_0==66))
					{
						alt18=1;
					}


					} finally { DebugExitDecision(18); }
					switch ( alt18 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:147:10: ',' IDENT
						{
						DebugLocation(147, 10);
						char_literal88=(IToken)Match(input,66,Follow._66_in_type_decl1615); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_66.Add(char_literal88);

						DebugLocation(147, 14);
						IDENT89=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1617); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT89);


						}
						break;

					default:
						goto loop18;
					}
				}

				loop18:
					;

				} finally { DebugExitSubRule(18); }

				DebugLocation(147, 21);
				char_literal90=(IToken)Match(input,67,Follow._67_in_type_decl1620); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_67.Add(char_literal90);

				DebugLocation(147, 25);
				ARRAY91=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_decl1622); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY91);

				DebugLocation(147, 31);
				char_literal92=(IToken)Match(input,63,Follow._63_in_type_decl1624); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal92);

				DebugLocation(147, 35);
				PushFollow(Follow._group_in_type_decl1626);
				group93=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group93.Tree);
				DebugLocation(147, 41);
				char_literal94=(IToken)Match(input,68,Follow._68_in_type_decl1628); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal94);

				DebugLocation(147, 44);
				char_literal95=(IToken)Match(input,68,Follow._68_in_type_decl1629); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal95);

				DebugLocation(147, 47);
				PushFollow(Follow._group_in_type_decl1630);
				group96=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group96.Tree);
				DebugLocation(147, 53);
				char_literal97=(IToken)Match(input,64,Follow._64_in_type_decl1632); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal97);

				DebugLocation(147, 57);
				OF98=(IToken)Match(input,OF,Follow._OF_in_type_decl1634); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF98);

				DebugLocation(147, 60);
				PushFollow(Follow._type_in_type_decl1636);
				type99=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type99.Tree);


				{
				// AST REWRITE
				// elements: type, ARRAY, IDENT, group
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 147:65: -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
				{
					DebugLocation(147, 68);
					// MathLang.g:147:68: ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(147, 70);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(147, 75);
					// MathLang.g:147:75: ^( ARRAY ( IDENT )+ ( group )+ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(147, 77);
					root_2 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_2);

					DebugLocation(147, 83);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(147, 83);
						adaptor.AddChild(root_2, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();
					DebugLocation(147, 90);
					if ( !(stream_group.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_group.HasNext )
					{
						DebugLocation(147, 90);
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
			TraceOut("type_decl", 16);
			LeaveRule("type_decl", 16);
			Leave_type_decl();
		}
		DebugLocation(148, 0);
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
	// MathLang.g:150:1: vars : VAR ( type_decl ';' )+ ;
	[GrammarRule("vars")]
	private MathLangParser.vars_return vars()
	{
		Enter_vars();
		EnterRule("vars", 17);
		TraceIn("vars", 17);
		MathLangParser.vars_return retval = new MathLangParser.vars_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR100=null;
		IToken char_literal102=null;
		MathLangParser.type_decl_return type_decl101 = default(MathLangParser.type_decl_return);

		object VAR100_tree=null;
		object char_literal102_tree=null;

		try { DebugEnterRule(GrammarFileName, "vars");
		DebugLocation(150, 0);
		try
		{
			// MathLang.g:150:5: ( VAR ( type_decl ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:151:2: VAR ( type_decl ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(151, 5);
			VAR100=(IToken)Match(input,VAR,Follow._VAR_in_vars1661); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR100_tree = (object)adaptor.Create(VAR100);
			root_0 = (object)adaptor.BecomeRoot(VAR100_tree, root_0);
			}
			DebugLocation(151, 7);
			// MathLang.g:151:7: ( type_decl ';' )+
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
					// MathLang.g:151:8: type_decl ';'
					{
					DebugLocation(151, 8);
					PushFollow(Follow._type_decl_in_vars1665);
					type_decl101=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl101.Tree);
					DebugLocation(151, 21);
					char_literal102=(IToken)Match(input,65,Follow._65_in_vars1667); if (state.failed) return retval;

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
			TraceOut("vars", 17);
			LeaveRule("vars", 17);
			Leave_vars();
		}
		DebugLocation(152, 0);
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
	// MathLang.g:154:1: param : term ;
	[GrammarRule("param")]
	private MathLangParser.param_return param()
	{
		Enter_param();
		EnterRule("param", 18);
		TraceIn("param", 18);
		MathLangParser.param_return retval = new MathLangParser.param_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.term_return term103 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "param");
		DebugLocation(154, 0);
		try
		{
			// MathLang.g:154:6: ( term )
			DebugEnterAlt(1);
			// MathLang.g:154:8: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(154, 8);
			PushFollow(Follow._term_in_param1678);
			term103=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term103.Tree);

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
			TraceOut("param", 18);
			LeaveRule("param", 18);
			Leave_param();
		}
		DebugLocation(155, 0);
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
	// MathLang.g:157:1: params_ : ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) ;
	[GrammarRule("params_")]
	private MathLangParser.params__return params_()
	{
		Enter_params_();
		EnterRule("params_", 19);
		TraceIn("params_", 19);
		MathLangParser.params__return retval = new MathLangParser.params__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal105=null;
		MathLangParser.param_return param104 = default(MathLangParser.param_return);
		MathLangParser.param_return param106 = default(MathLangParser.param_return);

		object char_literal105_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleSubtreeStream stream_param=new RewriteRuleSubtreeStream(adaptor,"rule param");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(157, 0);
		try
		{
			// MathLang.g:157:8: ( ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) )
			DebugEnterAlt(1);
			// MathLang.g:158:1: ( param ( ',' param )* )?
			{
			DebugLocation(158, 1);
			// MathLang.g:158:1: ( param ( ',' param )* )?
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
				// MathLang.g:158:2: param ( ',' param )*
				{
				DebugLocation(158, 2);
				PushFollow(Follow._param_in_params_1687);
				param104=param();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_param.Add(param104.Tree);
				DebugLocation(158, 7);
				// MathLang.g:158:7: ( ',' param )*
				try { DebugEnterSubRule(21);
				while (true)
				{
					int alt21=2;
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==66))
					{
						alt21=1;
					}


					} finally { DebugExitDecision(21); }
					switch ( alt21 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:158:8: ',' param
						{
						DebugLocation(158, 8);
						char_literal105=(IToken)Match(input,66,Follow._66_in_params_1689); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_66.Add(char_literal105);

						DebugLocation(158, 12);
						PushFollow(Follow._param_in_params_1691);
						param106=param();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_param.Add(param106.Tree);

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
			// 158:22: -> ^( PARAMS ( param )* )
			{
				DebugLocation(158, 25);
				// MathLang.g:158:25: ^( PARAMS ( param )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(158, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(158, 34);
				// MathLang.g:158:34: ( param )*
				while ( stream_param.HasNext )
				{
					DebugLocation(158, 34);
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
			TraceOut("params_", 19);
			LeaveRule("params_", 19);
			Leave_params_();
		}
		DebugLocation(159, 0);
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
	// MathLang.g:161:1: func_sign : ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) ;
	[GrammarRule("func_sign")]
	private MathLangParser.func_sign_return func_sign()
	{
		Enter_func_sign();
		EnterRule("func_sign", 20);
		TraceIn("func_sign", 20);
		MathLangParser.func_sign_return retval = new MathLangParser.func_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNC107=null;
		IToken IDENT108=null;
		IToken char_literal109=null;
		IToken char_literal111=null;
		IToken char_literal113=null;
		IToken char_literal114=null;
		IToken char_literal116=null;
		MathLangParser.type_decl_return type_decl110 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl112 = default(MathLangParser.type_decl_return);
		MathLangParser.type_return type115 = default(MathLangParser.type_return);

		object FUNC107_tree=null;
		object IDENT108_tree=null;
		object char_literal109_tree=null;
		object char_literal111_tree=null;
		object char_literal113_tree=null;
		object char_literal114_tree=null;
		object char_literal116_tree=null;
		RewriteRuleITokenStream stream_67=new RewriteRuleITokenStream(adaptor,"token 67");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_FUNC=new RewriteRuleITokenStream(adaptor,"token FUNC");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "func_sign");
		DebugLocation(161, 0);
		try
		{
			// MathLang.g:161:10: ( ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:162:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			{
			DebugLocation(162, 1);
			// MathLang.g:162:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			DebugEnterAlt(1);
			// MathLang.g:162:2: FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';'
			{
			DebugLocation(162, 2);
			FUNC107=(IToken)Match(input,FUNC,Follow._FUNC_in_func_sign1713); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC.Add(FUNC107);

			DebugLocation(162, 7);
			IDENT108=(IToken)Match(input,IDENT,Follow._IDENT_in_func_sign1715); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT108);

			DebugLocation(162, 13);
			char_literal109=(IToken)Match(input,61,Follow._61_in_func_sign1717); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal109);

			DebugLocation(162, 16);
			// MathLang.g:162:16: ( type_decl ( ';' type_decl )* )*
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
					// MathLang.g:162:18: type_decl ( ';' type_decl )*
					{
					DebugLocation(162, 18);
					PushFollow(Follow._type_decl_in_func_sign1720);
					type_decl110=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl110.Tree);
					DebugLocation(162, 28);
					// MathLang.g:162:28: ( ';' type_decl )*
					try { DebugEnterSubRule(23);
					while (true)
					{
						int alt23=2;
						try { DebugEnterDecision(23, decisionCanBacktrack[23]);
						int LA23_0 = input.LA(1);

						if ((LA23_0==65))
						{
							alt23=1;
						}


						} finally { DebugExitDecision(23); }
						switch ( alt23 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:162:29: ';' type_decl
							{
							DebugLocation(162, 29);
							char_literal111=(IToken)Match(input,65,Follow._65_in_func_sign1723); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_65.Add(char_literal111);

							DebugLocation(162, 33);
							PushFollow(Follow._type_decl_in_func_sign1725);
							type_decl112=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl112.Tree);

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

			DebugLocation(162, 46);
			char_literal113=(IToken)Match(input,62,Follow._62_in_func_sign1730); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal113);

			DebugLocation(162, 50);
			char_literal114=(IToken)Match(input,67,Follow._67_in_func_sign1732); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_67.Add(char_literal114);

			DebugLocation(162, 54);
			PushFollow(Follow._type_in_func_sign1734);
			type115=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type115.Tree);
			DebugLocation(162, 59);
			char_literal116=(IToken)Match(input,65,Follow._65_in_func_sign1736); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal116);


			}



			{
			// AST REWRITE
			// elements: IDENT, FUNC, type, type_decl
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 162:63: -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
			{
				DebugLocation(162, 66);
				// MathLang.g:162:66: ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(162, 68);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

				DebugLocation(162, 73);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(162, 78);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(162, 84);
				// MathLang.g:162:84: ^( PARAMS ( type_decl )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(162, 86);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(162, 93);
				// MathLang.g:162:93: ( type_decl )*
				while ( stream_type_decl.HasNext )
				{
					DebugLocation(162, 93);
					adaptor.AddChild(root_2, stream_type_decl.NextTree());

				}
				stream_type_decl.Reset();

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
			TraceOut("func_sign", 20);
			LeaveRule("func_sign", 20);
			Leave_func_sign();
		}
		DebugLocation(163, 0);
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
	// MathLang.g:165:1: proc_sign : ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) ;
	[GrammarRule("proc_sign")]
	private MathLangParser.proc_sign_return proc_sign()
	{
		Enter_proc_sign();
		EnterRule("proc_sign", 21);
		TraceIn("proc_sign", 21);
		MathLangParser.proc_sign_return retval = new MathLangParser.proc_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROC117=null;
		IToken IDENT118=null;
		IToken char_literal119=null;
		IToken char_literal120=null;
		IToken char_literal122=null;
		IToken VAR123=null;
		IToken char_literal124=null;
		IToken char_literal125=null;
		MathLangParser.type_decl_return t1 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl121 = default(MathLangParser.type_decl_return);

		object PROC117_tree=null;
		object IDENT118_tree=null;
		object char_literal119_tree=null;
		object char_literal120_tree=null;
		object char_literal122_tree=null;
		object VAR123_tree=null;
		object char_literal124_tree=null;
		object char_literal125_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_PROC=new RewriteRuleITokenStream(adaptor,"token PROC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		try { DebugEnterRule(GrammarFileName, "proc_sign");
		DebugLocation(165, 0);
		try
		{
			// MathLang.g:165:10: ( ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:166:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			{
			DebugLocation(166, 1);
			// MathLang.g:166:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:166:2: PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';'
			{
			DebugLocation(166, 2);
			PROC117=(IToken)Match(input,PROC,Follow._PROC_in_proc_sign1762); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC.Add(PROC117);

			DebugLocation(166, 7);
			IDENT118=(IToken)Match(input,IDENT,Follow._IDENT_in_proc_sign1764); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT118);

			DebugLocation(166, 13);
			char_literal119=(IToken)Match(input,61,Follow._61_in_proc_sign1766); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal119);

			DebugLocation(166, 16);
			// MathLang.g:166:16: ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==VAR||LA28_0==IDENT))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:166:17: (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )*
					{
					DebugLocation(166, 17);
					// MathLang.g:166:17: (t1= type_decl ( ';' type_decl )* ';' )*
					try { DebugEnterSubRule(26);
					while (true)
					{
						int alt26=2;
						try { DebugEnterDecision(26, decisionCanBacktrack[26]);
						int LA26_0 = input.LA(1);

						if ((LA26_0==IDENT))
						{
							alt26=1;
						}


						} finally { DebugExitDecision(26); }
						switch ( alt26 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:166:19: t1= type_decl ( ';' type_decl )* ';'
							{
							DebugLocation(166, 21);
							PushFollow(Follow._type_decl_in_proc_sign1772);
							t1=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t1.Tree);
							DebugLocation(166, 32);
							// MathLang.g:166:32: ( ';' type_decl )*
							try { DebugEnterSubRule(25);
							while (true)
							{
								int alt25=2;
								try { DebugEnterDecision(25, decisionCanBacktrack[25]);
								int LA25_0 = input.LA(1);

								if ((LA25_0==65))
								{
									int LA25_1 = input.LA(2);

									if ((EvaluatePredicate(synpred50_MathLang_fragment)))
									{
										alt25=1;
									}


								}


								} finally { DebugExitDecision(25); }
								switch ( alt25 )
								{
								case 1:
									DebugEnterAlt(1);
									// MathLang.g:166:33: ';' type_decl
									{
									DebugLocation(166, 33);
									char_literal120=(IToken)Match(input,65,Follow._65_in_proc_sign1775); if (state.failed) return retval; 
									if ( state.backtracking == 0 ) stream_65.Add(char_literal120);

									DebugLocation(166, 37);
									PushFollow(Follow._type_decl_in_proc_sign1777);
									type_decl121=type_decl();
									PopFollow();
									if (state.failed) return retval;
									if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl121.Tree);

									}
									break;

								default:
									goto loop25;
								}
							}

							loop25:
								;

							} finally { DebugExitSubRule(25); }

							DebugLocation(166, 49);
							char_literal122=(IToken)Match(input,65,Follow._65_in_proc_sign1781); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_65.Add(char_literal122);


							}
							break;

						default:
							goto loop26;
						}
					}

					loop26:
						;

					} finally { DebugExitSubRule(26); }

					DebugLocation(166, 55);
					VAR123=(IToken)Match(input,VAR,Follow._VAR_in_proc_sign1785); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_VAR.Add(VAR123);

					DebugLocation(166, 61);
					// MathLang.g:166:61: (t2= type_decl )*
					try { DebugEnterSubRule(27);
					while (true)
					{
						int alt27=2;
						try { DebugEnterDecision(27, decisionCanBacktrack[27]);
						int LA27_0 = input.LA(1);

						if ((LA27_0==IDENT))
						{
							int LA27_2 = input.LA(2);

							if ((EvaluatePredicate(synpred52_MathLang_fragment)))
							{
								alt27=1;
							}


						}


						} finally { DebugExitDecision(27); }
						switch ( alt27 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:0:0: t2= type_decl
							{
							DebugLocation(166, 61);
							PushFollow(Follow._type_decl_in_proc_sign1789);
							t2=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t2.Tree);

							}
							break;

						default:
							goto loop27;
						}
					}

					loop27:
						;

					} finally { DebugExitSubRule(27); }


					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }

			DebugLocation(166, 74);
			char_literal124=(IToken)Match(input,62,Follow._62_in_proc_sign1793); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal124);

			DebugLocation(166, 78);
			char_literal125=(IToken)Match(input,65,Follow._65_in_proc_sign1795); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal125);


			}



			{
			// AST REWRITE
			// elements: PROC, IDENT, t2, VAR, t1
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
			// 166:82: -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
			{
				DebugLocation(166, 85);
				// MathLang.g:166:85: ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(166, 87);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC.NextNode(), root_1);

				DebugLocation(166, 92);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(166, 98);
				// MathLang.g:166:98: ^( PARAMS ( $t1)* ( ^( VAR $t2) )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(166, 100);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(166, 108);
				// MathLang.g:166:108: ( $t1)*
				while ( stream_t1.HasNext )
				{
					DebugLocation(166, 108);
					adaptor.AddChild(root_2, stream_t1.NextTree());

				}
				stream_t1.Reset();
				DebugLocation(166, 114);
				// MathLang.g:166:114: ( ^( VAR $t2) )*
				while ( stream_t2.HasNext||stream_VAR.HasNext )
				{
					DebugLocation(166, 114);
					// MathLang.g:166:114: ^( VAR $t2)
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(166, 116);
					root_3 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_3);

					DebugLocation(166, 120);
					adaptor.AddChild(root_3, stream_t2.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

				}
				stream_t2.Reset();
				stream_VAR.Reset();

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
			TraceOut("proc_sign", 21);
			LeaveRule("proc_sign", 21);
			Leave_proc_sign();
		}
		DebugLocation(167, 0);
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
	// MathLang.g:169:1: func_decl : func_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("func_decl")]
	private MathLangParser.func_decl_return func_decl()
	{
		Enter_func_decl();
		EnterRule("func_decl", 22);
		TraceIn("func_decl", 22);
		MathLangParser.func_decl_return retval = new MathLangParser.func_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal127=null;
		IToken char_literal131=null;
		MathLangParser.func_sign_return func_sign126 = default(MathLangParser.func_sign_return);
		MathLangParser.const__return const_128 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars129 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr130 = default(MathLangParser.groupExpr_return);

		object char_literal127_tree=null;
		object char_literal131_tree=null;

		try { DebugEnterRule(GrammarFileName, "func_decl");
		DebugLocation(169, 0);
		try
		{
			// MathLang.g:169:10: ( func_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:170:1: func_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(170, 10);
			PushFollow(Follow._func_sign_in_func_decl1829);
			func_sign126=func_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(func_sign126.Tree, root_0);
			DebugLocation(170, 15);
			char_literal127=(IToken)Match(input,65,Follow._65_in_func_decl1832); if (state.failed) return retval;
			DebugLocation(170, 17);
			// MathLang.g:170:17: ( const_ )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==CONST_))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_
					{
					DebugLocation(170, 17);
					PushFollow(Follow._const__in_func_decl1835);
					const_128=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_128.Tree);

					}
					break;

				default:
					goto loop29;
				}
			}

			loop29:
				;

			} finally { DebugExitSubRule(29); }

			DebugLocation(170, 25);
			// MathLang.g:170:25: ( vars )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==VAR))
				{
					alt30=1;
				}


				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: vars
					{
					DebugLocation(170, 25);
					PushFollow(Follow._vars_in_func_decl1838);
					vars129=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars129.Tree);

					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }

			DebugLocation(170, 31);
			PushFollow(Follow._groupExpr_in_func_decl1841);
			groupExpr130=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr130.Tree);
			DebugLocation(170, 44);
			char_literal131=(IToken)Match(input,65,Follow._65_in_func_decl1843); if (state.failed) return retval;

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
			TraceOut("func_decl", 22);
			LeaveRule("func_decl", 22);
			Leave_func_decl();
		}
		DebugLocation(171, 0);
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
	// MathLang.g:173:1: proc_decl : proc_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("proc_decl")]
	private MathLangParser.proc_decl_return proc_decl()
	{
		Enter_proc_decl();
		EnterRule("proc_decl", 23);
		TraceIn("proc_decl", 23);
		MathLangParser.proc_decl_return retval = new MathLangParser.proc_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal133=null;
		IToken char_literal137=null;
		MathLangParser.proc_sign_return proc_sign132 = default(MathLangParser.proc_sign_return);
		MathLangParser.const__return const_134 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars135 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr136 = default(MathLangParser.groupExpr_return);

		object char_literal133_tree=null;
		object char_literal137_tree=null;

		try { DebugEnterRule(GrammarFileName, "proc_decl");
		DebugLocation(173, 0);
		try
		{
			// MathLang.g:173:10: ( proc_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:174:1: proc_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(174, 10);
			PushFollow(Follow._proc_sign_in_proc_decl1852);
			proc_sign132=proc_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(proc_sign132.Tree, root_0);
			DebugLocation(174, 15);
			char_literal133=(IToken)Match(input,65,Follow._65_in_proc_decl1855); if (state.failed) return retval;
			DebugLocation(174, 17);
			// MathLang.g:174:17: ( const_ )*
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
					DebugLocation(174, 17);
					PushFollow(Follow._const__in_proc_decl1858);
					const_134=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_134.Tree);

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }

			DebugLocation(174, 25);
			// MathLang.g:174:25: ( vars )*
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
					DebugLocation(174, 25);
					PushFollow(Follow._vars_in_proc_decl1861);
					vars135=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars135.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }

			DebugLocation(174, 31);
			PushFollow(Follow._groupExpr_in_proc_decl1864);
			groupExpr136=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr136.Tree);
			DebugLocation(174, 44);
			char_literal137=(IToken)Match(input,65,Follow._65_in_proc_decl1866); if (state.failed) return retval;

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
			TraceOut("proc_decl", 23);
			LeaveRule("proc_decl", 23);
			Leave_proc_decl();
		}
		DebugLocation(175, 0);
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
	// MathLang.g:177:1: call : ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) );
	[GrammarRule("call")]
	private MathLangParser.call_return call()
	{
		Enter_call();
		EnterRule("call", 24);
		TraceIn("call", 24);
		MathLangParser.call_return retval = new MathLangParser.call_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken i1=null;
		IToken i2=null;
		IToken IDENT138=null;
		IToken char_literal139=null;
		IToken char_literal141=null;
		IToken ASSIGN142=null;
		IToken char_literal143=null;
		IToken char_literal145=null;
		MathLangParser.params__return params_140 = default(MathLangParser.params__return);
		MathLangParser.params__return params_144 = default(MathLangParser.params__return);

		object i1_tree=null;
		object i2_tree=null;
		object IDENT138_tree=null;
		object char_literal139_tree=null;
		object char_literal141_tree=null;
		object ASSIGN142_tree=null;
		object char_literal143_tree=null;
		object char_literal145_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "call");
		DebugLocation(177, 0);
		try
		{
			// MathLang.g:177:5: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) )
			int alt33=2;
			try { DebugEnterDecision(33, decisionCanBacktrack[33]);
			int LA33_0 = input.LA(1);

			if ((LA33_0==IDENT))
			{
				int LA33_1 = input.LA(2);

				if ((LA33_1==61))
				{
					alt33=1;
				}
				else if ((LA33_1==ASSIGN))
				{
					alt33=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 33, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 33, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(33); }
			switch (alt33)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:178:1: IDENT '(' params_ ')'
				{
				DebugLocation(178, 1);
				IDENT138=(IToken)Match(input,IDENT,Follow._IDENT_in_call1875); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT138);

				DebugLocation(178, 7);
				char_literal139=(IToken)Match(input,61,Follow._61_in_call1877); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal139);

				DebugLocation(178, 11);
				PushFollow(Follow._params__in_call1879);
				params_140=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_140.Tree);
				DebugLocation(178, 19);
				char_literal141=(IToken)Match(input,62,Follow._62_in_call1881); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal141);



				{
				// AST REWRITE
				// elements: IDENT, params_
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 178:23: -> ^( CALL IDENT params_ )
				{
					DebugLocation(178, 26);
					// MathLang.g:178:26: ^( CALL IDENT params_ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(178, 28);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

					DebugLocation(178, 33);
					adaptor.AddChild(root_1, stream_IDENT.NextNode());
					DebugLocation(178, 39);
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
				// MathLang.g:179:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				{
				DebugLocation(179, 3);
				// MathLang.g:179:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				DebugEnterAlt(1);
				// MathLang.g:179:4: i1= IDENT ASSIGN i2= IDENT '(' params_ ')'
				{
				DebugLocation(179, 6);
				i1=(IToken)Match(input,IDENT,Follow._IDENT_in_call1898); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i1);

				DebugLocation(179, 13);
				ASSIGN142=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_call1900); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN142);

				DebugLocation(179, 22);
				i2=(IToken)Match(input,IDENT,Follow._IDENT_in_call1904); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i2);

				DebugLocation(179, 29);
				char_literal143=(IToken)Match(input,61,Follow._61_in_call1906); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal143);

				DebugLocation(179, 33);
				PushFollow(Follow._params__in_call1908);
				params_144=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_144.Tree);
				DebugLocation(179, 41);
				char_literal145=(IToken)Match(input,62,Follow._62_in_call1910); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal145);


				}



				{
				// AST REWRITE
				// elements: params_, ASSIGN, i1, i2
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
				// 179:46: -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
				{
					DebugLocation(179, 48);
					// MathLang.g:179:48: ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(179, 50);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(179, 57);
					adaptor.AddChild(root_1, stream_i1.NextNode());
					DebugLocation(179, 61);
					// MathLang.g:179:61: ^( CALL $i2 params_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(179, 63);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_2);

					DebugLocation(179, 68);
					adaptor.AddChild(root_2, stream_i2.NextNode());
					DebugLocation(179, 72);
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
			TraceOut("call", 24);
			LeaveRule("call", 24);
			Leave_call();
		}
		DebugLocation(180, 0);
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
	// MathLang.g:182:1: exprList : ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 25);
		TraceIn("exprList", 25);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal147=null;
		IToken char_literal149=null;
		MathLangParser.simpleExpr_return simpleExpr146 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr148 = default(MathLangParser.groupExpr_return);

		object char_literal147_tree=null;
		object char_literal149_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(182, 0);
		try
		{
			// MathLang.g:182:9: ( ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:183:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(183, 2);
			// MathLang.g:183:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			int alt36=2;
			try { DebugEnterSubRule(36);
			try { DebugEnterDecision(36, decisionCanBacktrack[36]);
			int LA36_0 = input.LA(1);

			if ((LA36_0==PRINT||LA36_0==IDENT||LA36_0==PRINTSTR))
			{
				alt36=1;
			}
			else if ((LA36_0==IF||LA36_0==FOR||(LA36_0>=WHILE && LA36_0<=REPEAT)||LA36_0==BEGIN||(LA36_0>=FUNC && LA36_0<=PROC)))
			{
				alt36=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 36, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(36); }
			switch (alt36)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:183:4: simpleExpr ( ';' )+
				{
				DebugLocation(183, 4);
				PushFollow(Follow._simpleExpr_in_exprList1940);
				simpleExpr146=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr146.Tree);
				DebugLocation(183, 15);
				// MathLang.g:183:15: ( ';' )+
				int cnt34=0;
				try { DebugEnterSubRule(34);
				while (true)
				{
					int alt34=2;
					try { DebugEnterDecision(34, decisionCanBacktrack[34]);
					int LA34_0 = input.LA(1);

					if ((LA34_0==65))
					{
						int LA34_2 = input.LA(2);

						if ((EvaluatePredicate(synpred59_MathLang_fragment)))
						{
							alt34=1;
						}


					}


					} finally { DebugExitDecision(34); }
					switch (alt34)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:183:16: ';'
						{
						DebugLocation(183, 19);
						char_literal147=(IToken)Match(input,65,Follow._65_in_exprList1943); if (state.failed) return retval;

						}
						break;

					default:
						if (cnt34 >= 1)
							goto loop34;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee34 = new EarlyExitException( 34, input );
						DebugRecognitionException(eee34);
						throw eee34;
					}
					cnt34++;
				}
				loop34:
					;

				} finally { DebugExitSubRule(34); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:184:3: groupExpr ( ';' )*
				{
				DebugLocation(184, 3);
				PushFollow(Follow._groupExpr_in_exprList1951);
				groupExpr148=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr148.Tree);
				DebugLocation(184, 13);
				// MathLang.g:184:13: ( ';' )*
				try { DebugEnterSubRule(35);
				while (true)
				{
					int alt35=2;
					try { DebugEnterDecision(35, decisionCanBacktrack[35]);
					int LA35_0 = input.LA(1);

					if ((LA35_0==65))
					{
						int LA35_2 = input.LA(2);

						if ((EvaluatePredicate(synpred61_MathLang_fragment)))
						{
							alt35=1;
						}


					}


					} finally { DebugExitDecision(35); }
					switch ( alt35 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:184:14: ';'
						{
						DebugLocation(184, 17);
						char_literal149=(IToken)Match(input,65,Follow._65_in_exprList1954); if (state.failed) return retval;

						}
						break;

					default:
						goto loop35;
					}
				}

				loop35:
					;

				} finally { DebugExitSubRule(35); }


				}
				break;

			}
			} finally { DebugExitSubRule(36); }


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
			TraceOut("exprList", 25);
			LeaveRule("exprList", 25);
			Leave_exprList();
		}
		DebugLocation(186, 0);
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
	// MathLang.g:188:1: main_ : BEGIN ( exprList )* END '.' ;
	[GrammarRule("main_")]
	private MathLangParser.main__return main_()
	{
		Enter_main_();
		EnterRule("main_", 26);
		TraceIn("main_", 26);
		MathLangParser.main__return retval = new MathLangParser.main__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN150=null;
		IToken END152=null;
		IToken char_literal153=null;
		MathLangParser.exprList_return exprList151 = default(MathLangParser.exprList_return);

		object BEGIN150_tree=null;
		object END152_tree=null;
		object char_literal153_tree=null;

		try { DebugEnterRule(GrammarFileName, "main_");
		DebugLocation(188, 0);
		try
		{
			// MathLang.g:188:6: ( BEGIN ( exprList )* END '.' )
			DebugEnterAlt(1);
			// MathLang.g:189:1: BEGIN ( exprList )* END '.'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(189, 6);
			BEGIN150=(IToken)Match(input,BEGIN,Follow._BEGIN_in_main_1967); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			BEGIN150_tree = (object)adaptor.Create(BEGIN150);
			root_0 = (object)adaptor.BecomeRoot(BEGIN150_tree, root_0);
			}
			DebugLocation(189, 8);
			// MathLang.g:189:8: ( exprList )*
			try { DebugEnterSubRule(37);
			while (true)
			{
				int alt37=2;
				try { DebugEnterDecision(37, decisionCanBacktrack[37]);
				int LA37_0 = input.LA(1);

				if ((LA37_0==IF||LA37_0==FOR||(LA37_0>=WHILE && LA37_0<=REPEAT)||LA37_0==BEGIN||LA37_0==PRINT||(LA37_0>=FUNC && LA37_0<=PROC)||LA37_0==IDENT||LA37_0==PRINTSTR))
				{
					alt37=1;
				}


				} finally { DebugExitDecision(37); }
				switch ( alt37 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: exprList
					{
					DebugLocation(189, 8);
					PushFollow(Follow._exprList_in_main_1970);
					exprList151=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList151.Tree);

					}
					break;

				default:
					goto loop37;
				}
			}

			loop37:
				;

			} finally { DebugExitSubRule(37); }

			DebugLocation(189, 21);
			END152=(IToken)Match(input,END,Follow._END_in_main_1973); if (state.failed) return retval;
			DebugLocation(189, 26);
			char_literal153=(IToken)Match(input,68,Follow._68_in_main_1976); if (state.failed) return retval;

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
			TraceOut("main_", 26);
			LeaveRule("main_", 26);
			Leave_main_();
		}
		DebugLocation(190, 0);
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
	// MathLang.g:192:1: program : ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) );
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 27);
		TraceIn("program", 27);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.func_decl_return func_decl154 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl155 = default(MathLangParser.proc_decl_return);
		MathLangParser.const__return const_156 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars157 = default(MathLangParser.vars_return);
		MathLangParser.func_decl_return func_decl158 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl159 = default(MathLangParser.proc_decl_return);
		MathLangParser.vars_return vars160 = default(MathLangParser.vars_return);
		MathLangParser.main__return main_161 = default(MathLangParser.main__return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(192, 0);
		try
		{
			// MathLang.g:192:8: ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) )
			int alt44=2;
			try { DebugEnterDecision(44, decisionCanBacktrack[44]);
			int LA44_0 = input.LA(1);

			if ((LA44_0==EOF||(LA44_0>=FUNC && LA44_0<=PROC)))
			{
				alt44=1;
			}
			else if ((LA44_0==VAR||LA44_0==CONST_))
			{
				alt44=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 44, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(44); }
			switch (alt44)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:192:10: ( ( func_decl )* ( proc_decl )* )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(192, 10);
				// MathLang.g:192:10: ( ( func_decl )* ( proc_decl )* )
				DebugEnterAlt(1);
				// MathLang.g:192:12: ( func_decl )* ( proc_decl )*
				{
				DebugLocation(192, 12);
				// MathLang.g:192:12: ( func_decl )*
				try { DebugEnterSubRule(38);
				while (true)
				{
					int alt38=2;
					try { DebugEnterDecision(38, decisionCanBacktrack[38]);
					int LA38_0 = input.LA(1);

					if ((LA38_0==FUNC))
					{
						alt38=1;
					}


					} finally { DebugExitDecision(38); }
					switch ( alt38 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: func_decl
						{
						DebugLocation(192, 12);
						PushFollow(Follow._func_decl_in_program1987);
						func_decl154=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl154.Tree);

						}
						break;

					default:
						goto loop38;
					}
				}

				loop38:
					;

				} finally { DebugExitSubRule(38); }

				DebugLocation(192, 23);
				// MathLang.g:192:23: ( proc_decl )*
				try { DebugEnterSubRule(39);
				while (true)
				{
					int alt39=2;
					try { DebugEnterDecision(39, decisionCanBacktrack[39]);
					int LA39_0 = input.LA(1);

					if ((LA39_0==PROC))
					{
						alt39=1;
					}


					} finally { DebugExitDecision(39); }
					switch ( alt39 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: proc_decl
						{
						DebugLocation(192, 23);
						PushFollow(Follow._proc_decl_in_program1990);
						proc_decl155=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl155.Tree);

						}
						break;

					default:
						goto loop39;
					}
				}

				loop39:
					;

				} finally { DebugExitSubRule(39); }


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:193:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(193, 2);
				// MathLang.g:193:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				DebugEnterAlt(1);
				// MathLang.g:193:3: ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_
				{
				DebugLocation(193, 3);
				// MathLang.g:193:3: ( const_ )*
				try { DebugEnterSubRule(40);
				while (true)
				{
					int alt40=2;
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					int LA40_0 = input.LA(1);

					if ((LA40_0==CONST_))
					{
						alt40=1;
					}


					} finally { DebugExitDecision(40); }
					switch ( alt40 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: const_
						{
						DebugLocation(193, 3);
						PushFollow(Follow._const__in_program1996);
						const_156=const_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_156.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }

				DebugLocation(193, 11);
				// MathLang.g:193:11: ( vars )+
				int cnt41=0;
				try { DebugEnterSubRule(41);
				while (true)
				{
					int alt41=2;
					try { DebugEnterDecision(41, decisionCanBacktrack[41]);
					int LA41_0 = input.LA(1);

					if ((LA41_0==VAR))
					{
						int LA41_3 = input.LA(2);

						if ((EvaluatePredicate(synpred67_MathLang_fragment)))
						{
							alt41=1;
						}


					}


					} finally { DebugExitDecision(41); }
					switch (alt41)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(193, 11);
						PushFollow(Follow._vars_in_program1999);
						vars157=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars157.Tree);

						}
						break;

					default:
						if (cnt41 >= 1)
							goto loop41;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee41 = new EarlyExitException( 41, input );
						DebugRecognitionException(eee41);
						throw eee41;
					}
					cnt41++;
				}
				loop41:
					;

				} finally { DebugExitSubRule(41); }

				DebugLocation(193, 18);
				// MathLang.g:193:18: ( func_decl | proc_decl )*
				try { DebugEnterSubRule(42);
				while (true)
				{
					int alt42=3;
					try { DebugEnterDecision(42, decisionCanBacktrack[42]);
					int LA42_0 = input.LA(1);

					if ((LA42_0==FUNC))
					{
						alt42=1;
					}
					else if ((LA42_0==PROC))
					{
						alt42=2;
					}


					} finally { DebugExitDecision(42); }
					switch ( alt42 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:193:19: func_decl
						{
						DebugLocation(193, 19);
						PushFollow(Follow._func_decl_in_program2004);
						func_decl158=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl158.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:193:29: proc_decl
						{
						DebugLocation(193, 29);
						PushFollow(Follow._proc_decl_in_program2006);
						proc_decl159=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl159.Tree);

						}
						break;

					default:
						goto loop42;
					}
				}

				loop42:
					;

				} finally { DebugExitSubRule(42); }

				DebugLocation(193, 41);
				// MathLang.g:193:41: ( vars )*
				try { DebugEnterSubRule(43);
				while (true)
				{
					int alt43=2;
					try { DebugEnterDecision(43, decisionCanBacktrack[43]);
					int LA43_0 = input.LA(1);

					if ((LA43_0==VAR))
					{
						alt43=1;
					}


					} finally { DebugExitDecision(43); }
					switch ( alt43 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(193, 41);
						PushFollow(Follow._vars_in_program2010);
						vars160=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars160.Tree);

						}
						break;

					default:
						goto loop43;
					}
				}

				loop43:
					;

				} finally { DebugExitSubRule(43); }

				DebugLocation(193, 47);
				PushFollow(Follow._main__in_program2013);
				main_161=main_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, main_161.Tree);

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
			TraceOut("program", 27);
			LeaveRule("program", 27);
			Leave_program();
		}
		DebugLocation(194, 0);
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
	// MathLang.g:196:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 28);
		TraceIn("result", 28);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF163=null;
		MathLangParser.program_return program162 = default(MathLangParser.program_return);

		object EOF163_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(196, 41);
		try
		{
			// MathLang.g:196:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// MathLang.g:196:9: program EOF
			{
			DebugLocation(196, 9);
			PushFollow(Follow._program_in_result2022);
			program162=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_program.Add(program162.Tree);
			DebugLocation(196, 17);
			EOF163=(IToken)Match(input,EOF,Follow._EOF_in_result2024); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF163);



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
			// 196:21: -> ^( PROGRAM program )
			{
				DebugLocation(196, 24);
				// MathLang.g:196:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(196, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(196, 34);
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
			TraceOut("result", 28);
			LeaveRule("result", 28);
			Leave_result();
		}
		DebugLocation(196, 41);
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
	// MathLang.g:198:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 29);
		TraceIn("execute", 29);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result164 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(198, 0);
		try
		{
			// MathLang.g:198:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:199:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(199, 3);
			PushFollow(Follow._result_in_execute2043);
			result164=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result164.Tree);

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
			TraceOut("execute", 29);
			LeaveRule("execute", 29);
			Leave_execute();
		}
		DebugLocation(200, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred28_MathLang_fragment();
	partial void Leave_synpred28_MathLang_fragment();

	// $ANTLR start synpred28_MathLang
	public void synpred28_MathLang_fragment()
	{
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);

		Enter_synpred28_MathLang_fragment();
		EnterRule("synpred28_MathLang_fragment", 57);
		TraceIn("synpred28_MathLang_fragment", 57);
		try
		{
			// MathLang.g:128:42: ( ELSIF t2= term THEN lst2= exprList )
			DebugEnterAlt(1);
			// MathLang.g:128:42: ELSIF t2= term THEN lst2= exprList
			{
			DebugLocation(128, 42);
			Match(input,ELSIF,Follow._ELSIF_in_synpred28_MathLang1379); if (state.failed) return;
			DebugLocation(128, 50);
			PushFollow(Follow._term_in_synpred28_MathLang1383);
			t2=term();
			PopFollow();
			if (state.failed) return;
			DebugLocation(128, 56);
			Match(input,THEN,Follow._THEN_in_synpred28_MathLang1385); if (state.failed) return;
			DebugLocation(128, 65);
			PushFollow(Follow._exprList_in_synpred28_MathLang1389);
			lst2=exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred28_MathLang_fragment", 57);
			LeaveRule("synpred28_MathLang_fragment", 57);
			Leave_synpred28_MathLang_fragment();
		}
	}
	// $ANTLR end synpred28_MathLang

	partial void Enter_synpred29_MathLang_fragment();
	partial void Leave_synpred29_MathLang_fragment();

	// $ANTLR start synpred29_MathLang
	public void synpred29_MathLang_fragment()
	{
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);

		Enter_synpred29_MathLang_fragment();
		EnterRule("synpred29_MathLang_fragment", 58);
		TraceIn("synpred29_MathLang_fragment", 58);
		try
		{
			// MathLang.g:128:78: ( ELSE lst3= exprList )
			DebugEnterAlt(1);
			// MathLang.g:128:78: ELSE lst3= exprList
			{
			DebugLocation(128, 78);
			Match(input,ELSE,Follow._ELSE_in_synpred29_MathLang1394); if (state.failed) return;
			DebugLocation(128, 87);
			PushFollow(Follow._exprList_in_synpred29_MathLang1398);
			lst3=exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred29_MathLang_fragment", 58);
			LeaveRule("synpred29_MathLang_fragment", 58);
			Leave_synpred29_MathLang_fragment();
		}
	}
	// $ANTLR end synpred29_MathLang

	partial void Enter_synpred50_MathLang_fragment();
	partial void Leave_synpred50_MathLang_fragment();

	// $ANTLR start synpred50_MathLang
	public void synpred50_MathLang_fragment()
	{
		Enter_synpred50_MathLang_fragment();
		EnterRule("synpred50_MathLang_fragment", 79);
		TraceIn("synpred50_MathLang_fragment", 79);
		try
		{
			// MathLang.g:166:33: ( ';' type_decl )
			DebugEnterAlt(1);
			// MathLang.g:166:33: ';' type_decl
			{
			DebugLocation(166, 33);
			Match(input,65,Follow._65_in_synpred50_MathLang1775); if (state.failed) return;
			DebugLocation(166, 37);
			PushFollow(Follow._type_decl_in_synpred50_MathLang1777);
			type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred50_MathLang_fragment", 79);
			LeaveRule("synpred50_MathLang_fragment", 79);
			Leave_synpred50_MathLang_fragment();
		}
	}
	// $ANTLR end synpred50_MathLang

	partial void Enter_synpred52_MathLang_fragment();
	partial void Leave_synpred52_MathLang_fragment();

	// $ANTLR start synpred52_MathLang
	public void synpred52_MathLang_fragment()
	{
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);

		Enter_synpred52_MathLang_fragment();
		EnterRule("synpred52_MathLang_fragment", 81);
		TraceIn("synpred52_MathLang_fragment", 81);
		try
		{
			// MathLang.g:166:61: (t2= type_decl )
			DebugEnterAlt(1);
			// MathLang.g:166:61: t2= type_decl
			{
			DebugLocation(166, 61);
			PushFollow(Follow._type_decl_in_synpred52_MathLang1789);
			t2=type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred52_MathLang_fragment", 81);
			LeaveRule("synpred52_MathLang_fragment", 81);
			Leave_synpred52_MathLang_fragment();
		}
	}
	// $ANTLR end synpred52_MathLang

	partial void Enter_synpred59_MathLang_fragment();
	partial void Leave_synpred59_MathLang_fragment();

	// $ANTLR start synpred59_MathLang
	public void synpred59_MathLang_fragment()
	{
		Enter_synpred59_MathLang_fragment();
		EnterRule("synpred59_MathLang_fragment", 88);
		TraceIn("synpred59_MathLang_fragment", 88);
		try
		{
			// MathLang.g:183:16: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:183:16: ';'
			{
			DebugLocation(183, 16);
			Match(input,65,Follow._65_in_synpred59_MathLang1943); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred59_MathLang_fragment", 88);
			LeaveRule("synpred59_MathLang_fragment", 88);
			Leave_synpred59_MathLang_fragment();
		}
	}
	// $ANTLR end synpred59_MathLang

	partial void Enter_synpred61_MathLang_fragment();
	partial void Leave_synpred61_MathLang_fragment();

	// $ANTLR start synpred61_MathLang
	public void synpred61_MathLang_fragment()
	{
		Enter_synpred61_MathLang_fragment();
		EnterRule("synpred61_MathLang_fragment", 90);
		TraceIn("synpred61_MathLang_fragment", 90);
		try
		{
			// MathLang.g:184:14: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:184:14: ';'
			{
			DebugLocation(184, 14);
			Match(input,65,Follow._65_in_synpred61_MathLang1954); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred61_MathLang_fragment", 90);
			LeaveRule("synpred61_MathLang_fragment", 90);
			Leave_synpred61_MathLang_fragment();
		}
	}
	// $ANTLR end synpred61_MathLang

	partial void Enter_synpred67_MathLang_fragment();
	partial void Leave_synpred67_MathLang_fragment();

	// $ANTLR start synpred67_MathLang
	public void synpred67_MathLang_fragment()
	{
		Enter_synpred67_MathLang_fragment();
		EnterRule("synpred67_MathLang_fragment", 96);
		TraceIn("synpred67_MathLang_fragment", 96);
		try
		{
			// MathLang.g:193:11: ( vars )
			DebugEnterAlt(1);
			// MathLang.g:193:11: vars
			{
			DebugLocation(193, 11);
			PushFollow(Follow._vars_in_synpred67_MathLang1999);
			vars();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred67_MathLang_fragment", 96);
			LeaveRule("synpred67_MathLang_fragment", 96);
			Leave_synpred67_MathLang_fragment();
		}
	}
	// $ANTLR end synpred67_MathLang
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
	DFA19 dfa19;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa19 = new DFA19( this );
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
			"\x1\x30\x1\x43\x1\x30\x1\x27\x1\xFFFF\x1\x43\x1\xFFFF";
		private const string DFA19_acceptS =
			"\x4\xFFFF\x1\x1\x1\xFFFF\x1\x2";
		private const string DFA19_specialS =
			"\x7\xFFFF}>";
		private static readonly string[] DFA19_transitionS =
			{
				"\x1\x1",
				"\x1\x4\x11\xFFFF\x1\x2\x1\x3",
				"\x1\x5",
				"\x4\x4\x8\xFFFF\x1\x6",
				"",
				"\x1\x4\x11\xFFFF\x1\x2\x1\x3",
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

		public override string Description { get { return "145:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _61_in_group1057 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_group1060 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_group1062 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_value_in_group1067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1075 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1080 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_group1082 = new BitSet(new ulong[]{0x1800000000000UL});
		public static readonly BitSet _index__in_group1084 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_group1085 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult1105 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _set_in_mult1109 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_mult1120 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _mult_in_add1132 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _set_in_add1137 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _mult_in_add1148 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _add_in_compare1160 = new BitSet(new ulong[]{0xFC0000000000002UL});
		public static readonly BitSet _set_in_compare1163 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _add_in_compare1190 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_div1198 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _set_in_div1200 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _compare_in_div1209 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _div_in_and_logic1216 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _AND_in_and_logic1219 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _div_in_and_logic1222 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _and_logic_in_or_logic1230 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or_logic1233 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _and_logic_in_or_logic1236 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _or_logic_in_term1244 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_logic_value0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_index_0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1293 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1295 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1298 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINT_in_simpleExpr1302 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1305 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINTSTR_in_simpleExpr1309 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1312 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1317 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_simpleExpr1319 = new BitSet(new ulong[]{0x1800000000000UL});
		public static readonly BitSet _index__in_simpleExpr1321 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_simpleExpr1322 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1324 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_simpleExpr1326 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_in_simpleExpr1351 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_groupExpr1362 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1364 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1368 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_groupExpr1370 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1372 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1376 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSIF_in_groupExpr1379 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1383 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1385 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1389 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSE_in_groupExpr1394 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_groupExpr1439 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_groupExpr1441 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_groupExpr1443 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1447 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _TO_in_groupExpr1449 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1453 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1455 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1457 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_groupExpr1486 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1489 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1491 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_groupExpr1492 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1495 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1498 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_groupExpr1502 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1505 = new BitSet(new ulong[]{0x10010C1407104000UL});
		public static readonly BitSet _UNTIL_in_groupExpr1508 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_groupExpr1511 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1515 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1517 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _END_in_groupExpr1520 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_groupExpr1522 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_groupExpr1534 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_groupExpr1537 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_const_decl1547 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _EQUALS_in_const_decl1550 = new BitSet(new ulong[]{0x1800000000000UL});
		public static readonly BitSet _set_in_const_decl1553 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_const_decl1560 = new BitSet(new ulong[]{0x2UL,0x2UL});
		public static readonly BitSet _CONST__in_const_1571 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _const_decl_in_const_1574 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _IDENT_in_type_decl1587 = new BitSet(new ulong[]{0x1000000000000UL,0xCUL});
		public static readonly BitSet _66_in_type_decl1590 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1592 = new BitSet(new ulong[]{0x1000000000000UL,0xCUL});
		public static readonly BitSet _67_in_type_decl1598 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_type_decl1612 = new BitSet(new ulong[]{0x0UL,0xCUL});
		public static readonly BitSet _66_in_type_decl1615 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1617 = new BitSet(new ulong[]{0x0UL,0xCUL});
		public static readonly BitSet _67_in_type_decl1620 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ARRAY_in_type_decl1622 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_type_decl1624 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_type_decl1626 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_type_decl1628 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_type_decl1629 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _group_in_type_decl1630 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_type_decl1632 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _OF_in_type_decl1634 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1636 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_vars1661 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_vars1665 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_vars1667 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _term_in_param1678 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _param_in_params_1687 = new BitSet(new ulong[]{0x2UL,0x4UL});
		public static readonly BitSet _66_in_params_1689 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _param_in_params_1691 = new BitSet(new ulong[]{0x2UL,0x4UL});
		public static readonly BitSet _FUNC_in_func_sign1713 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_func_sign1715 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_func_sign1717 = new BitSet(new ulong[]{0x4001000000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1720 = new BitSet(new ulong[]{0x4001000000000000UL,0x2UL});
		public static readonly BitSet _65_in_func_sign1723 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1725 = new BitSet(new ulong[]{0x4001000000000000UL,0x2UL});
		public static readonly BitSet _62_in_func_sign1730 = new BitSet(new ulong[]{0x0UL,0x8UL});
		public static readonly BitSet _67_in_func_sign1732 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_func_sign1734 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_func_sign1736 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_in_proc_sign1762 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_proc_sign1764 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_proc_sign1766 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1772 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_proc_sign1775 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1777 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_proc_sign1781 = new BitSet(new ulong[]{0x1000200000000UL});
		public static readonly BitSet _VAR_in_proc_sign1785 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1789 = new BitSet(new ulong[]{0x4001000200000000UL});
		public static readonly BitSet _62_in_proc_sign1793 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_proc_sign1795 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_sign_in_func_decl1829 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_func_decl1832 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _const__in_func_decl1835 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _vars_in_func_decl1838 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _groupExpr_in_func_decl1841 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_func_decl1843 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_sign_in_proc_decl1852 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_proc_decl1855 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _const__in_proc_decl1858 = new BitSet(new ulong[]{0x10010E1603104000UL});
		public static readonly BitSet _vars_in_proc_decl1861 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _groupExpr_in_proc_decl1864 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_proc_decl1866 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1875 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call1877 = new BitSet(new ulong[]{0x6001800000000030UL});
		public static readonly BitSet _params__in_call1879 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_call1881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1898 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_call1900 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_call1904 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call1906 = new BitSet(new ulong[]{0x6001800000000030UL});
		public static readonly BitSet _params__in_call1908 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_call1910 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList1940 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_exprList1943 = new BitSet(new ulong[]{0x2UL,0x2UL});
		public static readonly BitSet _groupExpr_in_exprList1951 = new BitSet(new ulong[]{0x2UL,0x2UL});
		public static readonly BitSet _65_in_exprList1954 = new BitSet(new ulong[]{0x2UL,0x2UL});
		public static readonly BitSet _BEGIN_in_main_1967 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _exprList_in_main_1970 = new BitSet(new ulong[]{0x10010C1C03104000UL});
		public static readonly BitSet _END_in_main_1973 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_main_1976 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_program1987 = new BitSet(new ulong[]{0x10010C1403104002UL});
		public static readonly BitSet _proc_decl_in_program1990 = new BitSet(new ulong[]{0x10010C1403104002UL});
		public static readonly BitSet _const__in_program1996 = new BitSet(new ulong[]{0x20200000000UL});
		public static readonly BitSet _vars_in_program1999 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _func_decl_in_program2004 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _proc_decl_in_program2006 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _vars_in_program2010 = new BitSet(new ulong[]{0x10010C1603104000UL});
		public static readonly BitSet _main__in_program2013 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result2022 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result2024 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute2043 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSIF_in_synpred28_MathLang1379 = new BitSet(new ulong[]{0x2001800000000030UL});
		public static readonly BitSet _term_in_synpred28_MathLang1383 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_synpred28_MathLang1385 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_synpred28_MathLang1389 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred29_MathLang1394 = new BitSet(new ulong[]{0x10010C1403104000UL});
		public static readonly BitSet _exprList_in_synpred29_MathLang1398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _65_in_synpred50_MathLang1775 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_synpred50_MathLang1777 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_decl_in_synpred52_MathLang1789 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _65_in_synpred59_MathLang1943 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _65_in_synpred61_MathLang1954 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _vars_in_synpred67_MathLang1999 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
