// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2016-12-22 14:41:33

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TRUE", "FALSE", "AND", "OR", "UNKNOWN", "SCOPEBLOCK", "BLOCK", "PROGRAM", "CONVERT", "INDEX", "IF", "THEN", "ELSE", "ELSIF", "DIV", "MOD", "FOR", "TO", "DOWNTO", "DO", "WHILE", "REPEAT", "UNTIL", "INT", "REAL", "CHAR", "BOOL", "CALL", "PARAMS", "VAR", "BEGIN", "END", "PRINT", "INPUT", "ARRAY", "OF", "CONST_", "FUNC", "PROC", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIDE", "ASSIGN", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "'('", "')'", "'['", "']'", "';'", "','", "':'", "'.'"
	};
	public const int EOF=-1;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int T__66=66;
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
	public const int INPUT=37;
	public const int ARRAY=38;
	public const int OF=39;
	public const int CONST_=40;
	public const int FUNC=41;
	public const int PROC=42;
	public const int WS=43;
	public const int SL_COMMENT=44;
	public const int ML_COMMENT=45;
	public const int NUMBER=46;
	public const int IDENT=47;
	public const int ADD=48;
	public const int SUB=49;
	public const int MUL=50;
	public const int DIVIDE=51;
	public const int ASSIGN=52;
	public const int GE=53;
	public const int LE=54;
	public const int NEQUALS=55;
	public const int EQUALS=56;
	public const int GT=57;
	public const int LT=58;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, true, true, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, true, false, false, false, false, false, false, false, 
				false, true, true, false, false, false, false, false, true, false, false, 
				false, , , , , , , , , , , , , 
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
	// MathLang.g:94:1: group : ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) );
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
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(94, 0);
		try
		{
			// MathLang.g:94:6: ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 59:
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

				if ((LA1_4==61))
				{
					alt1=5;
				}
				else if ((LA1_4==EOF||(LA1_4>=AND && LA1_4<=OR)||(LA1_4>=IF && LA1_4<=TO)||(LA1_4>=DO && LA1_4<=UNTIL)||(LA1_4>=BEGIN && LA1_4<=PRINT)||(LA1_4>=FUNC && LA1_4<=PROC)||(LA1_4>=IDENT && LA1_4<=DIVIDE)||(LA1_4>=GE && LA1_4<=LT)||LA1_4==60||(LA1_4>=62 && LA1_4<=64)||LA1_4==66))
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
				// MathLang.g:95:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 6);
				char_literal1=(IToken)Match(input,59,Follow._59_in_group1047); if (state.failed) return retval;
				DebugLocation(95, 8);
				PushFollow(Follow._term_in_group1050);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(95, 16);
				char_literal3=(IToken)Match(input,60,Follow._60_in_group1052); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:96:2: logic_value
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 2);
				PushFollow(Follow._logic_value_in_group1056);
				logic_value4=logic_value();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_value4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:97:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 3);
				NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group1060); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER5_tree = (object)adaptor.Create(NUMBER5);
				adaptor.AddChild(root_0, NUMBER5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:98:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(98, 3);
				IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_group1064); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT6_tree = (object)adaptor.Create(IDENT6);
				adaptor.AddChild(root_0, IDENT6_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:99:4: ( IDENT '[' index_ ']' )
				{
				DebugLocation(99, 4);
				// MathLang.g:99:4: ( IDENT '[' index_ ']' )
				DebugEnterAlt(1);
				// MathLang.g:99:5: IDENT '[' index_ ']'
				{
				DebugLocation(99, 5);
				IDENT7=(IToken)Match(input,IDENT,Follow._IDENT_in_group1070); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT7);

				DebugLocation(99, 11);
				char_literal8=(IToken)Match(input,61,Follow._61_in_group1072); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal8);

				DebugLocation(99, 15);
				PushFollow(Follow._index__in_group1074);
				index_9=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_9.Tree);
				DebugLocation(99, 21);
				char_literal10=(IToken)Match(input,62,Follow._62_in_group1075); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal10);


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
				// 99:26: -> ^( IDENT ^( INDEX index_ ) )
				{
					DebugLocation(99, 28);
					// MathLang.g:99:28: ^( IDENT ^( INDEX index_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(99, 30);
					root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

					DebugLocation(99, 36);
					// MathLang.g:99:36: ^( INDEX index_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(99, 38);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_2);

					DebugLocation(99, 44);
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
		DebugLocation(100, 0);
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
	// MathLang.g:102:1: mult : group ( ( MUL | DIVIDE ) group )* ;
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
		DebugLocation(102, 42);
		try
		{
			// MathLang.g:102:5: ( group ( ( MUL | DIVIDE ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:102:7: group ( ( MUL | DIVIDE ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 7);
			PushFollow(Follow._group_in_mult1095);
			group11=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);
			DebugLocation(102, 13);
			// MathLang.g:102:13: ( ( MUL | DIVIDE ) group )*
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
					// MathLang.g:102:15: ( MUL | DIVIDE ) group
					{
					DebugLocation(102, 15);
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

					DebugLocation(102, 33);
					PushFollow(Follow._group_in_mult1110);
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
		DebugLocation(102, 42);
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
	// MathLang.g:103:1: add : mult ( ( ADD | SUB ) mult )* ;
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
		DebugLocation(103, 39);
		try
		{
			// MathLang.g:103:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:103:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 7);
			PushFollow(Follow._mult_in_add1122);
			mult14=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);
			DebugLocation(103, 13);
			// MathLang.g:103:13: ( ( ADD | SUB ) mult )*
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
					// MathLang.g:103:15: ( ADD | SUB ) mult
					{
					DebugLocation(103, 15);
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

					DebugLocation(103, 30);
					PushFollow(Follow._mult_in_add1138);
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
		DebugLocation(103, 39);
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
	// MathLang.g:104:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
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
		DebugLocation(104, 61);
		try
		{
			// MathLang.g:104:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:104:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 10);
			PushFollow(Follow._add_in_compare1150);
			add17=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
			DebugLocation(104, 14);
			// MathLang.g:104:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
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
				// MathLang.g:104:15: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(104, 15);
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

				DebugLocation(104, 57);
				PushFollow(Follow._add_in_compare1180);
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
		DebugLocation(104, 61);
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
	// MathLang.g:105:1: div : compare ( ( DIV | MOD ) compare )* ;
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
		DebugLocation(105, 35);
		try
		{
			// MathLang.g:105:4: ( compare ( ( DIV | MOD ) compare )* )
			DebugEnterAlt(1);
			// MathLang.g:105:6: compare ( ( DIV | MOD ) compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 6);
			PushFollow(Follow._compare_in_div1188);
			compare20=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare20.Tree);
			DebugLocation(105, 13);
			// MathLang.g:105:13: ( ( DIV | MOD ) compare )*
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
					// MathLang.g:105:14: ( DIV | MOD ) compare
					{
					DebugLocation(105, 14);
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

					DebugLocation(105, 27);
					PushFollow(Follow._compare_in_div1199);
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
		DebugLocation(105, 35);
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
	// MathLang.g:106:1: and_logic : div ( AND div )* ;
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
		DebugLocation(106, 25);
		try
		{
			// MathLang.g:106:10: ( div ( AND div )* )
			DebugEnterAlt(1);
			// MathLang.g:106:11: div ( AND div )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 11);
			PushFollow(Follow._div_in_and_logic1206);
			div23=div();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div23.Tree);
			DebugLocation(106, 15);
			// MathLang.g:106:15: ( AND div )*
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
					// MathLang.g:106:16: AND div
					{
					DebugLocation(106, 19);
					AND24=(IToken)Match(input,AND,Follow._AND_in_and_logic1209); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND24_tree = (object)adaptor.Create(AND24);
					root_0 = (object)adaptor.BecomeRoot(AND24_tree, root_0);
					}
					DebugLocation(106, 21);
					PushFollow(Follow._div_in_and_logic1212);
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
		DebugLocation(106, 25);
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
	// MathLang.g:107:1: or_logic : and_logic ( OR and_logic )* ;
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
		DebugLocation(107, 36);
		try
		{
			// MathLang.g:107:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:107:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 11);
			PushFollow(Follow._and_logic_in_or_logic1220);
			and_logic26=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic26.Tree);
			DebugLocation(107, 21);
			// MathLang.g:107:21: ( OR and_logic )*
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
					// MathLang.g:107:22: OR and_logic
					{
					DebugLocation(107, 24);
					OR27=(IToken)Match(input,OR,Follow._OR_in_or_logic1223); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR27_tree = (object)adaptor.Create(OR27);
					root_0 = (object)adaptor.BecomeRoot(OR27_tree, root_0);
					}
					DebugLocation(107, 26);
					PushFollow(Follow._and_logic_in_or_logic1226);
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
		DebugLocation(107, 36);
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
	// MathLang.g:108:1: term : or_logic ;
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
		DebugLocation(108, 14);
		try
		{
			// MathLang.g:108:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:108:7: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(108, 7);
			PushFollow(Follow._or_logic_in_term1234);
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
		DebugLocation(108, 14);
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
	// MathLang.g:110:1: logic_value : ( TRUE | FALSE );
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
		DebugLocation(110, 24);
		try
		{
			// MathLang.g:110:12: ( TRUE | FALSE )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(110, 12);
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
		DebugLocation(110, 24);
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
	// MathLang.g:112:1: type : ( INT | REAL | BOOL | CHAR );
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
		DebugLocation(112, 0);
		try
		{
			// MathLang.g:112:5: ( INT | REAL | BOOL | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(112, 5);
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
		DebugLocation(113, 0);
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
	// MathLang.g:115:1: index_ : ( IDENT | NUMBER );
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
		DebugLocation(115, 0);
		try
		{
			// MathLang.g:115:7: ( IDENT | NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(115, 7);
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
		DebugLocation(116, 0);
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
	// MathLang.g:118:1: simpleExpr : ( IDENT ASSIGN term | PRINT term | ( IDENT '[' index_ ']' ASSIGN group ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group ) | call );
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
		IToken IDENT38=null;
		IToken char_literal39=null;
		IToken char_literal41=null;
		IToken ASSIGN42=null;
		MathLangParser.term_return term35 = default(MathLangParser.term_return);
		MathLangParser.term_return term37 = default(MathLangParser.term_return);
		MathLangParser.index__return index_40 = default(MathLangParser.index__return);
		MathLangParser.group_return group43 = default(MathLangParser.group_return);
		MathLangParser.call_return call44 = default(MathLangParser.call_return);

		object IDENT33_tree=null;
		object ASSIGN34_tree=null;
		object PRINT36_tree=null;
		object IDENT38_tree=null;
		object char_literal39_tree=null;
		object char_literal41_tree=null;
		object ASSIGN42_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(118, 0);
		try
		{
			// MathLang.g:118:11: ( IDENT ASSIGN term | PRINT term | ( IDENT '[' index_ ']' ASSIGN group ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group ) | call )
			int alt8=4;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==IDENT))
			{
				switch (input.LA(2))
				{
				case ASSIGN:
					{
					alt8=1;
					}
					break;
				case 61:
					{
					alt8=3;
					}
					break;
				case 59:
					{
					alt8=4;
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
			else if ((LA8_0==PRINT))
			{
				alt8=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:119:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(119, 3);
				IDENT33=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1283); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT33_tree = (object)adaptor.Create(IDENT33);
				adaptor.AddChild(root_0, IDENT33_tree);
				}
				DebugLocation(119, 15);
				ASSIGN34=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1285); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN34_tree = (object)adaptor.Create(ASSIGN34);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN34_tree, root_0);
				}
				DebugLocation(119, 17);
				PushFollow(Follow._term_in_simpleExpr1288);
				term35=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:120:3: PRINT term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(120, 8);
				PRINT36=(IToken)Match(input,PRINT,Follow._PRINT_in_simpleExpr1292); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINT36_tree = (object)adaptor.Create(PRINT36);
				root_0 = (object)adaptor.BecomeRoot(PRINT36_tree, root_0);
				}
				DebugLocation(120, 10);
				PushFollow(Follow._term_in_simpleExpr1295);
				term37=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term37.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:121:2: ( IDENT '[' index_ ']' ASSIGN group )
				{
				DebugLocation(121, 2);
				// MathLang.g:121:2: ( IDENT '[' index_ ']' ASSIGN group )
				DebugEnterAlt(1);
				// MathLang.g:121:4: IDENT '[' index_ ']' ASSIGN group
				{
				DebugLocation(121, 4);
				IDENT38=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1300); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT38);

				DebugLocation(121, 10);
				char_literal39=(IToken)Match(input,61,Follow._61_in_simpleExpr1302); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal39);

				DebugLocation(121, 14);
				PushFollow(Follow._index__in_simpleExpr1304);
				index_40=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_40.Tree);
				DebugLocation(121, 20);
				char_literal41=(IToken)Match(input,62,Follow._62_in_simpleExpr1305); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal41);

				DebugLocation(121, 24);
				ASSIGN42=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1307); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN42);

				DebugLocation(121, 31);
				PushFollow(Follow._group_in_simpleExpr1309);
				group43=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group43.Tree);

				}



				{
				// AST REWRITE
				// elements: ASSIGN, index_, IDENT, group
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 121:37: -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group )
				{
					DebugLocation(121, 40);
					// MathLang.g:121:40: ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(121, 42);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(121, 49);
					// MathLang.g:121:49: ^( IDENT ^( INDEX index_ ) )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(121, 52);
					root_2 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_2);

					DebugLocation(121, 58);
					// MathLang.g:121:58: ^( INDEX index_ )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(121, 60);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_3);

					DebugLocation(121, 67);
					adaptor.AddChild(root_3, stream_index_.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(121, 77);
					adaptor.AddChild(root_1, stream_group.NextTree());

					adaptor.AddChild(root_0, root_1);
					}

				}

				retval.Tree = root_0;
				}
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:122:3: call
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 3);
				PushFollow(Follow._call_in_simpleExpr1334);
				call44=call();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call44.Tree);

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
		DebugLocation(123, 0);
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
	// MathLang.g:125:1: groupExpr : ( IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )? | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl );
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 13);
		TraceIn("groupExpr", 13);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF45=null;
		IToken char_literal46=null;
		IToken char_literal48=null;
		IToken THEN49=null;
		IToken ELSIF51=null;
		IToken THEN53=null;
		IToken ELSE55=null;
		IToken FOR57=null;
		IToken IDENT58=null;
		IToken ASSIGN59=null;
		IToken TO60=null;
		IToken DO61=null;
		IToken WHILE63=null;
		IToken char_literal64=null;
		IToken char_literal66=null;
		IToken DO67=null;
		IToken REPEAT69=null;
		IToken UNTIL71=null;
		IToken BEGIN73=null;
		IToken END75=null;
		MathLangParser.term_return t1 = default(MathLangParser.term_return);
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.term_return term47 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList50 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term52 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList54 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList56 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList62 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term65 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList68 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList70 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term72 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList74 = default(MathLangParser.exprList_return);
		MathLangParser.func_decl_return func_decl76 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl77 = default(MathLangParser.proc_decl_return);

		object IF45_tree=null;
		object char_literal46_tree=null;
		object char_literal48_tree=null;
		object THEN49_tree=null;
		object ELSIF51_tree=null;
		object THEN53_tree=null;
		object ELSE55_tree=null;
		object FOR57_tree=null;
		object IDENT58_tree=null;
		object ASSIGN59_tree=null;
		object TO60_tree=null;
		object DO61_tree=null;
		object WHILE63_tree=null;
		object char_literal64_tree=null;
		object char_literal66_tree=null;
		object DO67_tree=null;
		object REPEAT69_tree=null;
		object UNTIL71_tree=null;
		object BEGIN73_tree=null;
		object END75_tree=null;
		RewriteRuleITokenStream stream_FOR=new RewriteRuleITokenStream(adaptor,"token FOR");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_DO=new RewriteRuleITokenStream(adaptor,"token DO");
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_TO=new RewriteRuleITokenStream(adaptor,"token TO");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(125, 0);
		try
		{
			// MathLang.g:125:10: ( IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )? | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl )
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
				// MathLang.g:126:3: IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 5);
				IF45=(IToken)Match(input,IF,Follow._IF_in_groupExpr1344); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				IF45_tree = (object)adaptor.Create(IF45);
				root_0 = (object)adaptor.BecomeRoot(IF45_tree, root_0);
				}
				DebugLocation(126, 10);
				char_literal46=(IToken)Match(input,59,Follow._59_in_groupExpr1347); if (state.failed) return retval;
				DebugLocation(126, 12);
				PushFollow(Follow._term_in_groupExpr1350);
				term47=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term47.Tree);
				DebugLocation(126, 20);
				char_literal48=(IToken)Match(input,60,Follow._60_in_groupExpr1352); if (state.failed) return retval;
				DebugLocation(126, 26);
				THEN49=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1355); if (state.failed) return retval;
				DebugLocation(126, 28);
				PushFollow(Follow._exprList_in_groupExpr1358);
				exprList50=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList50.Tree);
				DebugLocation(126, 37);
				// MathLang.g:126:37: ( ELSIF term THEN exprList )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==ELSIF))
					{
						int LA9_2 = input.LA(2);

						if ((EvaluatePredicate(synpred27_MathLang_fragment)))
						{
							alt9=1;
						}


					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:126:38: ELSIF term THEN exprList
						{
						DebugLocation(126, 38);
						ELSIF51=(IToken)Match(input,ELSIF,Follow._ELSIF_in_groupExpr1361); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						ELSIF51_tree = (object)adaptor.Create(ELSIF51);
						adaptor.AddChild(root_0, ELSIF51_tree);
						}
						DebugLocation(126, 44);
						PushFollow(Follow._term_in_groupExpr1363);
						term52=term();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term52.Tree);
						DebugLocation(126, 49);
						THEN53=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1365); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						THEN53_tree = (object)adaptor.Create(THEN53);
						adaptor.AddChild(root_0, THEN53_tree);
						}
						DebugLocation(126, 54);
						PushFollow(Follow._exprList_in_groupExpr1367);
						exprList54=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList54.Tree);

						}
						break;

					default:
						goto loop9;
					}
				}

				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(126, 65);
				// MathLang.g:126:65: ( ELSE exprList )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==ELSE))
				{
					int LA10_1 = input.LA(2);

					if ((EvaluatePredicate(synpred28_MathLang_fragment)))
					{
						alt10=1;
					}
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:126:66: ELSE exprList
					{
					DebugLocation(126, 66);
					ELSE55=(IToken)Match(input,ELSE,Follow._ELSE_in_groupExpr1372); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					ELSE55_tree = (object)adaptor.Create(ELSE55);
					adaptor.AddChild(root_0, ELSE55_tree);
					}
					DebugLocation(126, 71);
					PushFollow(Follow._exprList_in_groupExpr1374);
					exprList56=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList56.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(10); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:127:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				{
				DebugLocation(127, 2);
				// MathLang.g:127:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				DebugEnterAlt(1);
				// MathLang.g:127:4: FOR IDENT ASSIGN t1= term TO t2= term DO exprList
				{
				DebugLocation(127, 4);
				FOR57=(IToken)Match(input,FOR,Follow._FOR_in_groupExpr1381); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR57);

				DebugLocation(127, 8);
				IDENT58=(IToken)Match(input,IDENT,Follow._IDENT_in_groupExpr1383); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT58);

				DebugLocation(127, 14);
				ASSIGN59=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_groupExpr1385); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN59);

				DebugLocation(127, 23);
				PushFollow(Follow._term_in_groupExpr1389);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(127, 29);
				TO60=(IToken)Match(input,TO,Follow._TO_in_groupExpr1391); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TO.Add(TO60);

				DebugLocation(127, 34);
				PushFollow(Follow._term_in_groupExpr1395);
				t2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
				DebugLocation(127, 40);
				DO61=(IToken)Match(input,DO,Follow._DO_in_groupExpr1397); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DO.Add(DO61);

				DebugLocation(127, 43);
				PushFollow(Follow._exprList_in_groupExpr1399);
				exprList62=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(exprList62.Tree);

				}



				{
				// AST REWRITE
				// elements: IDENT, exprList, t1, IDENT, t2, ASSIGN, FOR
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
				// 127:52: -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList )
				{
					DebugLocation(127, 54);
					// MathLang.g:127:54: ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(127, 56);
					root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

					DebugLocation(127, 60);
					// MathLang.g:127:60: ^( ASSIGN IDENT $t1)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(127, 62);
					root_2 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

					DebugLocation(127, 69);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(127, 75);
					adaptor.AddChild(root_2, stream_t1.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(127, 80);
					// MathLang.g:127:80: ^( LE IDENT $t2)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(127, 82);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LE, "LE"), root_2);

					DebugLocation(127, 85);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(127, 91);
					adaptor.AddChild(root_2, stream_t2.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(127, 96);
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
				// MathLang.g:128:3: WHILE '(' term ')' DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(128, 8);
				WHILE63=(IToken)Match(input,WHILE,Follow._WHILE_in_groupExpr1428); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE63_tree = (object)adaptor.Create(WHILE63);
				root_0 = (object)adaptor.BecomeRoot(WHILE63_tree, root_0);
				}
				DebugLocation(128, 13);
				char_literal64=(IToken)Match(input,59,Follow._59_in_groupExpr1431); if (state.failed) return retval;
				DebugLocation(128, 14);
				PushFollow(Follow._term_in_groupExpr1433);
				term65=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term65.Tree);
				DebugLocation(128, 21);
				char_literal66=(IToken)Match(input,60,Follow._60_in_groupExpr1434); if (state.failed) return retval;
				DebugLocation(128, 25);
				DO67=(IToken)Match(input,DO,Follow._DO_in_groupExpr1437); if (state.failed) return retval;
				DebugLocation(128, 27);
				PushFollow(Follow._exprList_in_groupExpr1440);
				exprList68=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList68.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:129:3: REPEAT ( exprList )+ UNTIL term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 9);
				REPEAT69=(IToken)Match(input,REPEAT,Follow._REPEAT_in_groupExpr1444); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				REPEAT69_tree = (object)adaptor.Create(REPEAT69);
				root_0 = (object)adaptor.BecomeRoot(REPEAT69_tree, root_0);
				}
				DebugLocation(129, 11);
				// MathLang.g:129:11: ( exprList )+
				int cnt11=0;
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==IF||LA11_0==FOR||(LA11_0>=WHILE && LA11_0<=REPEAT)||LA11_0==BEGIN||LA11_0==PRINT||(LA11_0>=FUNC && LA11_0<=PROC)||LA11_0==IDENT))
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
						DebugLocation(129, 11);
						PushFollow(Follow._exprList_in_groupExpr1447);
						exprList70=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList70.Tree);

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

				DebugLocation(129, 26);
				UNTIL71=(IToken)Match(input,UNTIL,Follow._UNTIL_in_groupExpr1450); if (state.failed) return retval;
				DebugLocation(129, 28);
				PushFollow(Follow._term_in_groupExpr1453);
				term72=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term72.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:130:3: BEGIN ( exprList )+ END
				{
				DebugLocation(130, 3);
				BEGIN73=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1457); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN73);

				DebugLocation(130, 9);
				// MathLang.g:130:9: ( exprList )+
				int cnt12=0;
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==IF||LA12_0==FOR||(LA12_0>=WHILE && LA12_0<=REPEAT)||LA12_0==BEGIN||LA12_0==PRINT||(LA12_0>=FUNC && LA12_0<=PROC)||LA12_0==IDENT))
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
						DebugLocation(130, 9);
						PushFollow(Follow._exprList_in_groupExpr1459);
						exprList74=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_exprList.Add(exprList74.Tree);

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

				DebugLocation(130, 19);
				END75=(IToken)Match(input,END,Follow._END_in_groupExpr1462); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END75);



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
				// 130:24: -> ^( BLOCK ( exprList )+ )
				{
					DebugLocation(130, 27);
					// MathLang.g:130:27: ^( BLOCK ( exprList )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(130, 29);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(130, 35);
					if ( !(stream_exprList.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_exprList.HasNext )
					{
						DebugLocation(130, 35);
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
				// MathLang.g:131:2: func_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(131, 2);
				PushFollow(Follow._func_decl_in_groupExpr1475);
				func_decl76=func_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl76.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:132:2: proc_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(132, 2);
				PushFollow(Follow._proc_decl_in_groupExpr1478);
				proc_decl77=proc_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl77.Tree);

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
		DebugLocation(133, 0);
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
	// MathLang.g:136:1: const_decl : IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ ;
	[GrammarRule("const_decl")]
	private MathLangParser.const_decl_return const_decl()
	{
		Enter_const_decl();
		EnterRule("const_decl", 14);
		TraceIn("const_decl", 14);
		MathLangParser.const_decl_return retval = new MathLangParser.const_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT78=null;
		IToken EQUALS79=null;
		IToken set80=null;
		IToken char_literal81=null;

		object IDENT78_tree=null;
		object EQUALS79_tree=null;
		object set80_tree=null;
		object char_literal81_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_decl");
		DebugLocation(136, 0);
		try
		{
			// MathLang.g:136:11: ( IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:137:2: IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(137, 7);
			IDENT78=(IToken)Match(input,IDENT,Follow._IDENT_in_const_decl1488); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IDENT78_tree = (object)adaptor.Create(IDENT78);
			root_0 = (object)adaptor.BecomeRoot(IDENT78_tree, root_0);
			}
			DebugLocation(137, 15);
			EQUALS79=(IToken)Match(input,EQUALS,Follow._EQUALS_in_const_decl1491); if (state.failed) return retval;
			DebugLocation(137, 17);
			set80=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=IDENT))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set80));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}

			DebugLocation(137, 32);
			// MathLang.g:137:32: ( ';' )+
			int cnt14=0;
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==63))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:137:33: ';'
					{
					DebugLocation(137, 36);
					char_literal81=(IToken)Match(input,63,Follow._63_in_const_decl1501); if (state.failed) return retval;

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
		DebugLocation(138, 0);
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
	// MathLang.g:139:1: const_ : CONST_ ( const_decl )+ ;
	[GrammarRule("const_")]
	private MathLangParser.const__return const_()
	{
		Enter_const_();
		EnterRule("const_", 15);
		TraceIn("const_", 15);
		MathLangParser.const__return retval = new MathLangParser.const__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONST_82=null;
		MathLangParser.const_decl_return const_decl83 = default(MathLangParser.const_decl_return);

		object CONST_82_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_");
		DebugLocation(139, 0);
		try
		{
			// MathLang.g:139:7: ( CONST_ ( const_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:140:1: CONST_ ( const_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(140, 7);
			CONST_82=(IToken)Match(input,CONST_,Follow._CONST__in_const_1512); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_82_tree = (object)adaptor.Create(CONST_82);
			root_0 = (object)adaptor.BecomeRoot(CONST_82_tree, root_0);
			}
			DebugLocation(140, 9);
			// MathLang.g:140:9: ( const_decl )+
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
					DebugLocation(140, 9);
					PushFollow(Follow._const_decl_in_const_1515);
					const_decl83=const_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_decl83.Tree);

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
		DebugLocation(141, 0);
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
	// MathLang.g:143:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );
	[GrammarRule("type_decl")]
	private MathLangParser.type_decl_return type_decl()
	{
		Enter_type_decl();
		EnterRule("type_decl", 16);
		TraceIn("type_decl", 16);
		MathLangParser.type_decl_return retval = new MathLangParser.type_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT84=null;
		IToken char_literal85=null;
		IToken IDENT86=null;
		IToken char_literal87=null;
		IToken IDENT89=null;
		IToken char_literal90=null;
		IToken IDENT91=null;
		IToken char_literal92=null;
		IToken ARRAY93=null;
		IToken char_literal94=null;
		IToken char_literal96=null;
		IToken char_literal97=null;
		IToken char_literal99=null;
		IToken OF100=null;
		MathLangParser.type_return type88 = default(MathLangParser.type_return);
		MathLangParser.group_return group95 = default(MathLangParser.group_return);
		MathLangParser.group_return group98 = default(MathLangParser.group_return);
		MathLangParser.type_return type101 = default(MathLangParser.type_return);

		object IDENT84_tree=null;
		object char_literal85_tree=null;
		object IDENT86_tree=null;
		object char_literal87_tree=null;
		object IDENT89_tree=null;
		object char_literal90_tree=null;
		object IDENT91_tree=null;
		object char_literal92_tree=null;
		object ARRAY93_tree=null;
		object char_literal94_tree=null;
		object char_literal96_tree=null;
		object char_literal97_tree=null;
		object char_literal99_tree=null;
		object OF100_tree=null;
		RewriteRuleITokenStream stream_66=new RewriteRuleITokenStream(adaptor,"token 66");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type_decl");
		DebugLocation(143, 0);
		try
		{
			// MathLang.g:143:10: ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) )
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
				// MathLang.g:144:2: ( ( IDENT ( ',' IDENT )* )+ ) ':' type
				{
				DebugLocation(144, 2);
				// MathLang.g:144:2: ( ( IDENT ( ',' IDENT )* )+ )
				DebugEnterAlt(1);
				// MathLang.g:144:4: ( IDENT ( ',' IDENT )* )+
				{
				DebugLocation(144, 4);
				// MathLang.g:144:4: ( IDENT ( ',' IDENT )* )+
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
						// MathLang.g:144:5: IDENT ( ',' IDENT )*
						{
						DebugLocation(144, 5);
						IDENT84=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1528); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT84);

						DebugLocation(144, 11);
						// MathLang.g:144:11: ( ',' IDENT )*
						try { DebugEnterSubRule(16);
						while (true)
						{
							int alt16=2;
							try { DebugEnterDecision(16, decisionCanBacktrack[16]);
							int LA16_0 = input.LA(1);

							if ((LA16_0==64))
							{
								alt16=1;
							}


							} finally { DebugExitDecision(16); }
							switch ( alt16 )
							{
							case 1:
								DebugEnterAlt(1);
								// MathLang.g:144:12: ',' IDENT
								{
								DebugLocation(144, 12);
								char_literal85=(IToken)Match(input,64,Follow._64_in_type_decl1531); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_64.Add(char_literal85);

								DebugLocation(144, 16);
								IDENT86=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1533); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT86);


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

				DebugLocation(144, 26);
				char_literal87=(IToken)Match(input,65,Follow._65_in_type_decl1539); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal87);

				DebugLocation(144, 30);
				PushFollow(Follow._type_in_type_decl1541);
				type88=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type88.Tree);


				{
				// AST REWRITE
				// elements: IDENT, type
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 144:34: -> ^( type ( IDENT )+ )
				{
					DebugLocation(144, 37);
					// MathLang.g:144:37: ^( type ( IDENT )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(144, 39);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(144, 44);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(144, 44);
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
				// MathLang.g:145:3: IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type
				{
				DebugLocation(145, 3);
				IDENT89=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1553); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT89);

				DebugLocation(145, 9);
				// MathLang.g:145:9: ( ',' IDENT )*
				try { DebugEnterSubRule(18);
				while (true)
				{
					int alt18=2;
					try { DebugEnterDecision(18, decisionCanBacktrack[18]);
					int LA18_0 = input.LA(1);

					if ((LA18_0==64))
					{
						alt18=1;
					}


					} finally { DebugExitDecision(18); }
					switch ( alt18 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:145:10: ',' IDENT
						{
						DebugLocation(145, 10);
						char_literal90=(IToken)Match(input,64,Follow._64_in_type_decl1556); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_64.Add(char_literal90);

						DebugLocation(145, 14);
						IDENT91=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1558); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT91);


						}
						break;

					default:
						goto loop18;
					}
				}

				loop18:
					;

				} finally { DebugExitSubRule(18); }

				DebugLocation(145, 21);
				char_literal92=(IToken)Match(input,65,Follow._65_in_type_decl1561); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal92);

				DebugLocation(145, 25);
				ARRAY93=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_decl1563); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY93);

				DebugLocation(145, 31);
				char_literal94=(IToken)Match(input,61,Follow._61_in_type_decl1565); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal94);

				DebugLocation(145, 35);
				PushFollow(Follow._group_in_type_decl1567);
				group95=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group95.Tree);
				DebugLocation(145, 41);
				char_literal96=(IToken)Match(input,66,Follow._66_in_type_decl1569); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal96);

				DebugLocation(145, 44);
				char_literal97=(IToken)Match(input,66,Follow._66_in_type_decl1570); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_66.Add(char_literal97);

				DebugLocation(145, 47);
				PushFollow(Follow._group_in_type_decl1571);
				group98=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group98.Tree);
				DebugLocation(145, 53);
				char_literal99=(IToken)Match(input,62,Follow._62_in_type_decl1573); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal99);

				DebugLocation(145, 57);
				OF100=(IToken)Match(input,OF,Follow._OF_in_type_decl1575); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF100);

				DebugLocation(145, 60);
				PushFollow(Follow._type_in_type_decl1577);
				type101=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type101.Tree);


				{
				// AST REWRITE
				// elements: IDENT, type, group, ARRAY
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 145:65: -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
				{
					DebugLocation(145, 68);
					// MathLang.g:145:68: ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(145, 70);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(145, 75);
					// MathLang.g:145:75: ^( ARRAY ( IDENT )+ ( group )+ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(145, 77);
					root_2 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_2);

					DebugLocation(145, 83);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(145, 83);
						adaptor.AddChild(root_2, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();
					DebugLocation(145, 90);
					if ( !(stream_group.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_group.HasNext )
					{
						DebugLocation(145, 90);
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
		DebugLocation(146, 0);
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
	// MathLang.g:148:1: vars : VAR ( type_decl ';' )+ ;
	[GrammarRule("vars")]
	private MathLangParser.vars_return vars()
	{
		Enter_vars();
		EnterRule("vars", 17);
		TraceIn("vars", 17);
		MathLangParser.vars_return retval = new MathLangParser.vars_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR102=null;
		IToken char_literal104=null;
		MathLangParser.type_decl_return type_decl103 = default(MathLangParser.type_decl_return);

		object VAR102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "vars");
		DebugLocation(148, 0);
		try
		{
			// MathLang.g:148:5: ( VAR ( type_decl ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:149:2: VAR ( type_decl ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(149, 5);
			VAR102=(IToken)Match(input,VAR,Follow._VAR_in_vars1602); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR102_tree = (object)adaptor.Create(VAR102);
			root_0 = (object)adaptor.BecomeRoot(VAR102_tree, root_0);
			}
			DebugLocation(149, 7);
			// MathLang.g:149:7: ( type_decl ';' )+
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
					// MathLang.g:149:8: type_decl ';'
					{
					DebugLocation(149, 8);
					PushFollow(Follow._type_decl_in_vars1606);
					type_decl103=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl103.Tree);
					DebugLocation(149, 21);
					char_literal104=(IToken)Match(input,63,Follow._63_in_vars1608); if (state.failed) return retval;

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
		DebugLocation(150, 0);
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
	// MathLang.g:152:1: param : term ;
	[GrammarRule("param")]
	private MathLangParser.param_return param()
	{
		Enter_param();
		EnterRule("param", 18);
		TraceIn("param", 18);
		MathLangParser.param_return retval = new MathLangParser.param_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.term_return term105 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "param");
		DebugLocation(152, 0);
		try
		{
			// MathLang.g:152:6: ( term )
			DebugEnterAlt(1);
			// MathLang.g:152:8: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(152, 8);
			PushFollow(Follow._term_in_param1619);
			term105=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term105.Tree);

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
		DebugLocation(153, 0);
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
	// MathLang.g:155:1: params_ : ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) ;
	[GrammarRule("params_")]
	private MathLangParser.params__return params_()
	{
		Enter_params_();
		EnterRule("params_", 19);
		TraceIn("params_", 19);
		MathLangParser.params__return retval = new MathLangParser.params__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal107=null;
		MathLangParser.param_return param106 = default(MathLangParser.param_return);
		MathLangParser.param_return param108 = default(MathLangParser.param_return);

		object char_literal107_tree=null;
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleSubtreeStream stream_param=new RewriteRuleSubtreeStream(adaptor,"rule param");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(155, 0);
		try
		{
			// MathLang.g:155:8: ( ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) )
			DebugEnterAlt(1);
			// MathLang.g:156:1: ( param ( ',' param )* )?
			{
			DebugLocation(156, 1);
			// MathLang.g:156:1: ( param ( ',' param )* )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if (((LA22_0>=TRUE && LA22_0<=FALSE)||(LA22_0>=NUMBER && LA22_0<=IDENT)||LA22_0==59))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:156:2: param ( ',' param )*
				{
				DebugLocation(156, 2);
				PushFollow(Follow._param_in_params_1628);
				param106=param();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_param.Add(param106.Tree);
				DebugLocation(156, 7);
				// MathLang.g:156:7: ( ',' param )*
				try { DebugEnterSubRule(21);
				while (true)
				{
					int alt21=2;
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==64))
					{
						alt21=1;
					}


					} finally { DebugExitDecision(21); }
					switch ( alt21 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:156:8: ',' param
						{
						DebugLocation(156, 8);
						char_literal107=(IToken)Match(input,64,Follow._64_in_params_1630); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_64.Add(char_literal107);

						DebugLocation(156, 12);
						PushFollow(Follow._param_in_params_1632);
						param108=param();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_param.Add(param108.Tree);

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
			// 156:22: -> ^( PARAMS ( param )* )
			{
				DebugLocation(156, 25);
				// MathLang.g:156:25: ^( PARAMS ( param )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(156, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(156, 34);
				// MathLang.g:156:34: ( param )*
				while ( stream_param.HasNext )
				{
					DebugLocation(156, 34);
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
		DebugLocation(157, 0);
		} finally { DebugExitRule(GrammarFileName, "params_"); }
		return retval;

	}
	// $ANTLR end "params_"

	public class param_var_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_param_var();
	partial void Leave_param_var();

	// $ANTLR start "param_var"
	// MathLang.g:159:1: param_var : VAR ( type_decl )+ ;
	[GrammarRule("param_var")]
	private MathLangParser.param_var_return param_var()
	{
		Enter_param_var();
		EnterRule("param_var", 20);
		TraceIn("param_var", 20);
		MathLangParser.param_var_return retval = new MathLangParser.param_var_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR109=null;
		MathLangParser.type_decl_return type_decl110 = default(MathLangParser.type_decl_return);

		object VAR109_tree=null;

		try { DebugEnterRule(GrammarFileName, "param_var");
		DebugLocation(159, 0);
		try
		{
			// MathLang.g:159:10: ( VAR ( type_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:159:12: VAR ( type_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(159, 15);
			VAR109=(IToken)Match(input,VAR,Follow._VAR_in_param_var1653); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR109_tree = (object)adaptor.Create(VAR109);
			root_0 = (object)adaptor.BecomeRoot(VAR109_tree, root_0);
			}
			DebugLocation(159, 17);
			// MathLang.g:159:17: ( type_decl )+
			int cnt23=0;
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if ((LA23_0==IDENT))
				{
					int LA23_2 = input.LA(2);

					if ((EvaluatePredicate(synpred47_MathLang_fragment)))
					{
						alt23=1;
					}


				}


				} finally { DebugExitDecision(23); }
				switch (alt23)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: type_decl
					{
					DebugLocation(159, 17);
					PushFollow(Follow._type_decl_in_param_var1656);
					type_decl110=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl110.Tree);

					}
					break;

				default:
					if (cnt23 >= 1)
						goto loop23;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee23 = new EarlyExitException( 23, input );
					DebugRecognitionException(eee23);
					throw eee23;
				}
				cnt23++;
			}
			loop23:
				;

			} finally { DebugExitSubRule(23); }


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
			TraceOut("param_var", 20);
			LeaveRule("param_var", 20);
			Leave_param_var();
		}
		DebugLocation(160, 0);
		} finally { DebugExitRule(GrammarFileName, "param_var"); }
		return retval;

	}
	// $ANTLR end "param_var"

	public class func_sign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_func_sign();
	partial void Leave_func_sign();

	// $ANTLR start "func_sign"
	// MathLang.g:162:1: func_sign : ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) ;
	[GrammarRule("func_sign")]
	private MathLangParser.func_sign_return func_sign()
	{
		Enter_func_sign();
		EnterRule("func_sign", 21);
		TraceIn("func_sign", 21);
		MathLangParser.func_sign_return retval = new MathLangParser.func_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNC111=null;
		IToken IDENT112=null;
		IToken char_literal113=null;
		IToken char_literal115=null;
		IToken char_literal117=null;
		IToken char_literal118=null;
		IToken char_literal120=null;
		MathLangParser.type_decl_return type_decl114 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl116 = default(MathLangParser.type_decl_return);
		MathLangParser.type_return type119 = default(MathLangParser.type_return);

		object FUNC111_tree=null;
		object IDENT112_tree=null;
		object char_literal113_tree=null;
		object char_literal115_tree=null;
		object char_literal117_tree=null;
		object char_literal118_tree=null;
		object char_literal120_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_FUNC=new RewriteRuleITokenStream(adaptor,"token FUNC");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "func_sign");
		DebugLocation(162, 0);
		try
		{
			// MathLang.g:162:10: ( ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:163:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			{
			DebugLocation(163, 1);
			// MathLang.g:163:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			DebugEnterAlt(1);
			// MathLang.g:163:2: FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';'
			{
			DebugLocation(163, 2);
			FUNC111=(IToken)Match(input,FUNC,Follow._FUNC_in_func_sign1666); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC.Add(FUNC111);

			DebugLocation(163, 7);
			IDENT112=(IToken)Match(input,IDENT,Follow._IDENT_in_func_sign1668); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT112);

			DebugLocation(163, 13);
			char_literal113=(IToken)Match(input,59,Follow._59_in_func_sign1670); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal113);

			DebugLocation(163, 16);
			// MathLang.g:163:16: ( type_decl ( ';' type_decl )* )*
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
					// MathLang.g:163:18: type_decl ( ';' type_decl )*
					{
					DebugLocation(163, 18);
					PushFollow(Follow._type_decl_in_func_sign1673);
					type_decl114=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl114.Tree);
					DebugLocation(163, 28);
					// MathLang.g:163:28: ( ';' type_decl )*
					try { DebugEnterSubRule(24);
					while (true)
					{
						int alt24=2;
						try { DebugEnterDecision(24, decisionCanBacktrack[24]);
						int LA24_0 = input.LA(1);

						if ((LA24_0==63))
						{
							alt24=1;
						}


						} finally { DebugExitDecision(24); }
						switch ( alt24 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:163:29: ';' type_decl
							{
							DebugLocation(163, 29);
							char_literal115=(IToken)Match(input,63,Follow._63_in_func_sign1676); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_63.Add(char_literal115);

							DebugLocation(163, 33);
							PushFollow(Follow._type_decl_in_func_sign1678);
							type_decl116=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl116.Tree);

							}
							break;

						default:
							goto loop24;
						}
					}

					loop24:
						;

					} finally { DebugExitSubRule(24); }


					}
					break;

				default:
					goto loop25;
				}
			}

			loop25:
				;

			} finally { DebugExitSubRule(25); }

			DebugLocation(163, 46);
			char_literal117=(IToken)Match(input,60,Follow._60_in_func_sign1683); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal117);

			DebugLocation(163, 50);
			char_literal118=(IToken)Match(input,65,Follow._65_in_func_sign1685); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_65.Add(char_literal118);

			DebugLocation(163, 54);
			PushFollow(Follow._type_in_func_sign1687);
			type119=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type119.Tree);
			DebugLocation(163, 59);
			char_literal120=(IToken)Match(input,63,Follow._63_in_func_sign1689); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_63.Add(char_literal120);


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
			// 163:63: -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
			{
				DebugLocation(163, 66);
				// MathLang.g:163:66: ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(163, 68);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

				DebugLocation(163, 73);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(163, 78);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(163, 84);
				// MathLang.g:163:84: ^( PARAMS ( type_decl )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(163, 86);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(163, 93);
				// MathLang.g:163:93: ( type_decl )*
				while ( stream_type_decl.HasNext )
				{
					DebugLocation(163, 93);
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
			TraceOut("func_sign", 21);
			LeaveRule("func_sign", 21);
			Leave_func_sign();
		}
		DebugLocation(164, 0);
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
	// MathLang.g:166:1: proc_sign : ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) ) ;
	[GrammarRule("proc_sign")]
	private MathLangParser.proc_sign_return proc_sign()
	{
		Enter_proc_sign();
		EnterRule("proc_sign", 22);
		TraceIn("proc_sign", 22);
		MathLangParser.proc_sign_return retval = new MathLangParser.proc_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROC121=null;
		IToken IDENT122=null;
		IToken char_literal123=null;
		IToken char_literal125=null;
		IToken char_literal127=null;
		IToken char_literal129=null;
		IToken char_literal130=null;
		MathLangParser.type_decl_return type_decl124 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl126 = default(MathLangParser.type_decl_return);
		MathLangParser.param_var_return param_var128 = default(MathLangParser.param_var_return);

		object PROC121_tree=null;
		object IDENT122_tree=null;
		object char_literal123_tree=null;
		object char_literal125_tree=null;
		object char_literal127_tree=null;
		object char_literal129_tree=null;
		object char_literal130_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_PROC=new RewriteRuleITokenStream(adaptor,"token PROC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_param_var=new RewriteRuleSubtreeStream(adaptor,"rule param_var");
		try { DebugEnterRule(GrammarFileName, "proc_sign");
		DebugLocation(166, 0);
		try
		{
			// MathLang.g:166:10: ( ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:167:1: ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' )
			{
			DebugLocation(167, 1);
			// MathLang.g:167:1: ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:167:2: PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';'
			{
			DebugLocation(167, 2);
			PROC121=(IToken)Match(input,PROC,Follow._PROC_in_proc_sign1715); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC.Add(PROC121);

			DebugLocation(167, 7);
			IDENT122=(IToken)Match(input,IDENT,Follow._IDENT_in_proc_sign1717); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT122);

			DebugLocation(167, 13);
			char_literal123=(IToken)Match(input,59,Follow._59_in_proc_sign1719); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal123);

			DebugLocation(167, 16);
			// MathLang.g:167:16: ( type_decl ( ';' type_decl )* ';' param_var )*
			try { DebugEnterSubRule(27);
			while (true)
			{
				int alt27=2;
				try { DebugEnterDecision(27, decisionCanBacktrack[27]);
				int LA27_0 = input.LA(1);

				if ((LA27_0==IDENT))
				{
					alt27=1;
				}


				} finally { DebugExitDecision(27); }
				switch ( alt27 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:167:18: type_decl ( ';' type_decl )* ';' param_var
					{
					DebugLocation(167, 18);
					PushFollow(Follow._type_decl_in_proc_sign1722);
					type_decl124=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl124.Tree);
					DebugLocation(167, 28);
					// MathLang.g:167:28: ( ';' type_decl )*
					try { DebugEnterSubRule(26);
					while (true)
					{
						int alt26=2;
						try { DebugEnterDecision(26, decisionCanBacktrack[26]);
						int LA26_0 = input.LA(1);

						if ((LA26_0==63))
						{
							int LA26_1 = input.LA(2);

							if ((LA26_1==IDENT))
							{
								alt26=1;
							}


						}


						} finally { DebugExitDecision(26); }
						switch ( alt26 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:167:29: ';' type_decl
							{
							DebugLocation(167, 29);
							char_literal125=(IToken)Match(input,63,Follow._63_in_proc_sign1725); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_63.Add(char_literal125);

							DebugLocation(167, 33);
							PushFollow(Follow._type_decl_in_proc_sign1727);
							type_decl126=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl126.Tree);

							}
							break;

						default:
							goto loop26;
						}
					}

					loop26:
						;

					} finally { DebugExitSubRule(26); }

					DebugLocation(167, 45);
					char_literal127=(IToken)Match(input,63,Follow._63_in_proc_sign1731); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_63.Add(char_literal127);

					DebugLocation(167, 49);
					PushFollow(Follow._param_var_in_proc_sign1733);
					param_var128=param_var();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_param_var.Add(param_var128.Tree);

					}
					break;

				default:
					goto loop27;
				}
			}

			loop27:
				;

			} finally { DebugExitSubRule(27); }

			DebugLocation(167, 60);
			char_literal129=(IToken)Match(input,60,Follow._60_in_proc_sign1736); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal129);

			DebugLocation(167, 64);
			char_literal130=(IToken)Match(input,63,Follow._63_in_proc_sign1738); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_63.Add(char_literal130);


			}



			{
			// AST REWRITE
			// elements: type_decl, PROC, IDENT, param_var
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 167:68: -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) )
			{
				DebugLocation(167, 71);
				// MathLang.g:167:71: ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(167, 73);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC.NextNode(), root_1);

				DebugLocation(167, 78);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(167, 84);
				// MathLang.g:167:84: ^( PARAMS ( ( type_decl )+ param_var )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(167, 86);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(167, 94);
				// MathLang.g:167:94: ( ( type_decl )+ param_var )*
				while ( stream_param_var.HasNext )
				{
					DebugLocation(167, 95);
					if ( !(stream_type_decl.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_type_decl.HasNext )
					{
						DebugLocation(167, 95);
						adaptor.AddChild(root_2, stream_type_decl.NextTree());

					}
					stream_type_decl.Reset();
					DebugLocation(167, 106);
					adaptor.AddChild(root_2, stream_param_var.NextTree());

				}
				stream_param_var.Reset();

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
		DebugLocation(168, 0);
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
	// MathLang.g:170:1: func_decl : func_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("func_decl")]
	private MathLangParser.func_decl_return func_decl()
	{
		Enter_func_decl();
		EnterRule("func_decl", 23);
		TraceIn("func_decl", 23);
		MathLangParser.func_decl_return retval = new MathLangParser.func_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal132=null;
		IToken char_literal136=null;
		MathLangParser.func_sign_return func_sign131 = default(MathLangParser.func_sign_return);
		MathLangParser.const__return const_133 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars134 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr135 = default(MathLangParser.groupExpr_return);

		object char_literal132_tree=null;
		object char_literal136_tree=null;

		try { DebugEnterRule(GrammarFileName, "func_decl");
		DebugLocation(170, 0);
		try
		{
			// MathLang.g:170:10: ( func_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:171:1: func_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(171, 10);
			PushFollow(Follow._func_sign_in_func_decl1767);
			func_sign131=func_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(func_sign131.Tree, root_0);
			DebugLocation(171, 15);
			char_literal132=(IToken)Match(input,63,Follow._63_in_func_decl1770); if (state.failed) return retval;
			DebugLocation(171, 17);
			// MathLang.g:171:17: ( const_ )*
			try { DebugEnterSubRule(28);
			while (true)
			{
				int alt28=2;
				try { DebugEnterDecision(28, decisionCanBacktrack[28]);
				int LA28_0 = input.LA(1);

				if ((LA28_0==CONST_))
				{
					alt28=1;
				}


				} finally { DebugExitDecision(28); }
				switch ( alt28 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_
					{
					DebugLocation(171, 17);
					PushFollow(Follow._const__in_func_decl1773);
					const_133=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_133.Tree);

					}
					break;

				default:
					goto loop28;
				}
			}

			loop28:
				;

			} finally { DebugExitSubRule(28); }

			DebugLocation(171, 25);
			// MathLang.g:171:25: ( vars )*
			try { DebugEnterSubRule(29);
			while (true)
			{
				int alt29=2;
				try { DebugEnterDecision(29, decisionCanBacktrack[29]);
				int LA29_0 = input.LA(1);

				if ((LA29_0==VAR))
				{
					alt29=1;
				}


				} finally { DebugExitDecision(29); }
				switch ( alt29 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: vars
					{
					DebugLocation(171, 25);
					PushFollow(Follow._vars_in_func_decl1776);
					vars134=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars134.Tree);

					}
					break;

				default:
					goto loop29;
				}
			}

			loop29:
				;

			} finally { DebugExitSubRule(29); }

			DebugLocation(171, 31);
			PushFollow(Follow._groupExpr_in_func_decl1779);
			groupExpr135=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr135.Tree);
			DebugLocation(171, 44);
			char_literal136=(IToken)Match(input,63,Follow._63_in_func_decl1781); if (state.failed) return retval;

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
		DebugLocation(172, 0);
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
	// MathLang.g:174:1: proc_decl : proc_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("proc_decl")]
	private MathLangParser.proc_decl_return proc_decl()
	{
		Enter_proc_decl();
		EnterRule("proc_decl", 24);
		TraceIn("proc_decl", 24);
		MathLangParser.proc_decl_return retval = new MathLangParser.proc_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal138=null;
		IToken char_literal142=null;
		MathLangParser.proc_sign_return proc_sign137 = default(MathLangParser.proc_sign_return);
		MathLangParser.const__return const_139 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars140 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr141 = default(MathLangParser.groupExpr_return);

		object char_literal138_tree=null;
		object char_literal142_tree=null;

		try { DebugEnterRule(GrammarFileName, "proc_decl");
		DebugLocation(174, 0);
		try
		{
			// MathLang.g:174:10: ( proc_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:175:1: proc_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(175, 10);
			PushFollow(Follow._proc_sign_in_proc_decl1790);
			proc_sign137=proc_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(proc_sign137.Tree, root_0);
			DebugLocation(175, 15);
			char_literal138=(IToken)Match(input,63,Follow._63_in_proc_decl1793); if (state.failed) return retval;
			DebugLocation(175, 17);
			// MathLang.g:175:17: ( const_ )*
			try { DebugEnterSubRule(30);
			while (true)
			{
				int alt30=2;
				try { DebugEnterDecision(30, decisionCanBacktrack[30]);
				int LA30_0 = input.LA(1);

				if ((LA30_0==CONST_))
				{
					alt30=1;
				}


				} finally { DebugExitDecision(30); }
				switch ( alt30 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: const_
					{
					DebugLocation(175, 17);
					PushFollow(Follow._const__in_proc_decl1796);
					const_139=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_139.Tree);

					}
					break;

				default:
					goto loop30;
				}
			}

			loop30:
				;

			} finally { DebugExitSubRule(30); }

			DebugLocation(175, 25);
			// MathLang.g:175:25: ( vars )*
			try { DebugEnterSubRule(31);
			while (true)
			{
				int alt31=2;
				try { DebugEnterDecision(31, decisionCanBacktrack[31]);
				int LA31_0 = input.LA(1);

				if ((LA31_0==VAR))
				{
					alt31=1;
				}


				} finally { DebugExitDecision(31); }
				switch ( alt31 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: vars
					{
					DebugLocation(175, 25);
					PushFollow(Follow._vars_in_proc_decl1799);
					vars140=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars140.Tree);

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }

			DebugLocation(175, 31);
			PushFollow(Follow._groupExpr_in_proc_decl1802);
			groupExpr141=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr141.Tree);
			DebugLocation(175, 44);
			char_literal142=(IToken)Match(input,63,Follow._63_in_proc_decl1804); if (state.failed) return retval;

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
		DebugLocation(176, 0);
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
	// MathLang.g:178:1: call : IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) ;
	[GrammarRule("call")]
	private MathLangParser.call_return call()
	{
		Enter_call();
		EnterRule("call", 25);
		TraceIn("call", 25);
		MathLangParser.call_return retval = new MathLangParser.call_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT143=null;
		IToken char_literal144=null;
		IToken char_literal146=null;
		MathLangParser.params__return params_145 = default(MathLangParser.params__return);

		object IDENT143_tree=null;
		object char_literal144_tree=null;
		object char_literal146_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_59=new RewriteRuleITokenStream(adaptor,"token 59");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "call");
		DebugLocation(178, 0);
		try
		{
			// MathLang.g:178:5: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) )
			DebugEnterAlt(1);
			// MathLang.g:179:1: IDENT '(' params_ ')'
			{
			DebugLocation(179, 1);
			IDENT143=(IToken)Match(input,IDENT,Follow._IDENT_in_call1813); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT143);

			DebugLocation(179, 7);
			char_literal144=(IToken)Match(input,59,Follow._59_in_call1815); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal144);

			DebugLocation(179, 11);
			PushFollow(Follow._params__in_call1817);
			params_145=params_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_params_.Add(params_145.Tree);
			DebugLocation(179, 19);
			char_literal146=(IToken)Match(input,60,Follow._60_in_call1819); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal146);



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
			// 179:23: -> ^( CALL IDENT params_ )
			{
				DebugLocation(179, 26);
				// MathLang.g:179:26: ^( CALL IDENT params_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(179, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

				DebugLocation(179, 33);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(179, 39);
				adaptor.AddChild(root_1, stream_params_.NextTree());

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
			TraceOut("call", 25);
			LeaveRule("call", 25);
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
		EnterRule("exprList", 26);
		TraceIn("exprList", 26);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal148=null;
		IToken char_literal150=null;
		MathLangParser.simpleExpr_return simpleExpr147 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr149 = default(MathLangParser.groupExpr_return);

		object char_literal148_tree=null;
		object char_literal150_tree=null;

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
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==PRINT||LA34_0==IDENT))
			{
				alt34=1;
			}
			else if ((LA34_0==IF||LA34_0==FOR||(LA34_0>=WHILE && LA34_0<=REPEAT)||LA34_0==BEGIN||(LA34_0>=FUNC && LA34_0<=PROC)))
			{
				alt34=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 34, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(34); }
			switch (alt34)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:183:4: simpleExpr ( ';' )+
				{
				DebugLocation(183, 4);
				PushFollow(Follow._simpleExpr_in_exprList1841);
				simpleExpr147=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr147.Tree);
				DebugLocation(183, 15);
				// MathLang.g:183:15: ( ';' )+
				int cnt32=0;
				try { DebugEnterSubRule(32);
				while (true)
				{
					int alt32=2;
					try { DebugEnterDecision(32, decisionCanBacktrack[32]);
					int LA32_0 = input.LA(1);

					if ((LA32_0==63))
					{
						int LA32_2 = input.LA(2);

						if ((EvaluatePredicate(synpred56_MathLang_fragment)))
						{
							alt32=1;
						}


					}


					} finally { DebugExitDecision(32); }
					switch (alt32)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:183:16: ';'
						{
						DebugLocation(183, 19);
						char_literal148=(IToken)Match(input,63,Follow._63_in_exprList1844); if (state.failed) return retval;

						}
						break;

					default:
						if (cnt32 >= 1)
							goto loop32;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee32 = new EarlyExitException( 32, input );
						DebugRecognitionException(eee32);
						throw eee32;
					}
					cnt32++;
				}
				loop32:
					;

				} finally { DebugExitSubRule(32); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:184:3: groupExpr ( ';' )*
				{
				DebugLocation(184, 3);
				PushFollow(Follow._groupExpr_in_exprList1852);
				groupExpr149=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr149.Tree);
				DebugLocation(184, 13);
				// MathLang.g:184:13: ( ';' )*
				try { DebugEnterSubRule(33);
				while (true)
				{
					int alt33=2;
					try { DebugEnterDecision(33, decisionCanBacktrack[33]);
					int LA33_0 = input.LA(1);

					if ((LA33_0==63))
					{
						int LA33_2 = input.LA(2);

						if ((EvaluatePredicate(synpred58_MathLang_fragment)))
						{
							alt33=1;
						}


					}


					} finally { DebugExitDecision(33); }
					switch ( alt33 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:184:14: ';'
						{
						DebugLocation(184, 17);
						char_literal150=(IToken)Match(input,63,Follow._63_in_exprList1855); if (state.failed) return retval;

						}
						break;

					default:
						goto loop33;
					}
				}

				loop33:
					;

				} finally { DebugExitSubRule(33); }


				}
				break;

			}
			} finally { DebugExitSubRule(34); }


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
		EnterRule("main_", 27);
		TraceIn("main_", 27);
		MathLangParser.main__return retval = new MathLangParser.main__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN151=null;
		IToken END153=null;
		IToken char_literal154=null;
		MathLangParser.exprList_return exprList152 = default(MathLangParser.exprList_return);

		object BEGIN151_tree=null;
		object END153_tree=null;
		object char_literal154_tree=null;

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
			BEGIN151=(IToken)Match(input,BEGIN,Follow._BEGIN_in_main_1868); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			BEGIN151_tree = (object)adaptor.Create(BEGIN151);
			root_0 = (object)adaptor.BecomeRoot(BEGIN151_tree, root_0);
			}
			DebugLocation(189, 8);
			// MathLang.g:189:8: ( exprList )*
			try { DebugEnterSubRule(35);
			while (true)
			{
				int alt35=2;
				try { DebugEnterDecision(35, decisionCanBacktrack[35]);
				int LA35_0 = input.LA(1);

				if ((LA35_0==IF||LA35_0==FOR||(LA35_0>=WHILE && LA35_0<=REPEAT)||LA35_0==BEGIN||LA35_0==PRINT||(LA35_0>=FUNC && LA35_0<=PROC)||LA35_0==IDENT))
				{
					alt35=1;
				}


				} finally { DebugExitDecision(35); }
				switch ( alt35 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: exprList
					{
					DebugLocation(189, 8);
					PushFollow(Follow._exprList_in_main_1871);
					exprList152=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList152.Tree);

					}
					break;

				default:
					goto loop35;
				}
			}

			loop35:
				;

			} finally { DebugExitSubRule(35); }

			DebugLocation(189, 21);
			END153=(IToken)Match(input,END,Follow._END_in_main_1874); if (state.failed) return retval;
			DebugLocation(189, 26);
			char_literal154=(IToken)Match(input,66,Follow._66_in_main_1877); if (state.failed) return retval;

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
		EnterRule("program", 28);
		TraceIn("program", 28);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.func_decl_return func_decl155 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl156 = default(MathLangParser.proc_decl_return);
		MathLangParser.const__return const_157 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars158 = default(MathLangParser.vars_return);
		MathLangParser.func_decl_return func_decl159 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl160 = default(MathLangParser.proc_decl_return);
		MathLangParser.vars_return vars161 = default(MathLangParser.vars_return);
		MathLangParser.main__return main_162 = default(MathLangParser.main__return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(192, 0);
		try
		{
			// MathLang.g:192:8: ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) )
			int alt42=2;
			try { DebugEnterDecision(42, decisionCanBacktrack[42]);
			int LA42_0 = input.LA(1);

			if ((LA42_0==EOF||(LA42_0>=FUNC && LA42_0<=PROC)))
			{
				alt42=1;
			}
			else if ((LA42_0==VAR||LA42_0==CONST_))
			{
				alt42=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 42, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(42); }
			switch (alt42)
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
				try { DebugEnterSubRule(36);
				while (true)
				{
					int alt36=2;
					try { DebugEnterDecision(36, decisionCanBacktrack[36]);
					int LA36_0 = input.LA(1);

					if ((LA36_0==FUNC))
					{
						alt36=1;
					}


					} finally { DebugExitDecision(36); }
					switch ( alt36 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: func_decl
						{
						DebugLocation(192, 12);
						PushFollow(Follow._func_decl_in_program1888);
						func_decl155=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl155.Tree);

						}
						break;

					default:
						goto loop36;
					}
				}

				loop36:
					;

				} finally { DebugExitSubRule(36); }

				DebugLocation(192, 23);
				// MathLang.g:192:23: ( proc_decl )*
				try { DebugEnterSubRule(37);
				while (true)
				{
					int alt37=2;
					try { DebugEnterDecision(37, decisionCanBacktrack[37]);
					int LA37_0 = input.LA(1);

					if ((LA37_0==PROC))
					{
						alt37=1;
					}


					} finally { DebugExitDecision(37); }
					switch ( alt37 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: proc_decl
						{
						DebugLocation(192, 23);
						PushFollow(Follow._proc_decl_in_program1891);
						proc_decl156=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl156.Tree);

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
				try { DebugEnterSubRule(38);
				while (true)
				{
					int alt38=2;
					try { DebugEnterDecision(38, decisionCanBacktrack[38]);
					int LA38_0 = input.LA(1);

					if ((LA38_0==CONST_))
					{
						alt38=1;
					}


					} finally { DebugExitDecision(38); }
					switch ( alt38 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: const_
						{
						DebugLocation(193, 3);
						PushFollow(Follow._const__in_program1897);
						const_157=const_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_157.Tree);

						}
						break;

					default:
						goto loop38;
					}
				}

				loop38:
					;

				} finally { DebugExitSubRule(38); }

				DebugLocation(193, 11);
				// MathLang.g:193:11: ( vars )+
				int cnt39=0;
				try { DebugEnterSubRule(39);
				while (true)
				{
					int alt39=2;
					try { DebugEnterDecision(39, decisionCanBacktrack[39]);
					int LA39_0 = input.LA(1);

					if ((LA39_0==VAR))
					{
						int LA39_3 = input.LA(2);

						if ((EvaluatePredicate(synpred64_MathLang_fragment)))
						{
							alt39=1;
						}


					}


					} finally { DebugExitDecision(39); }
					switch (alt39)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(193, 11);
						PushFollow(Follow._vars_in_program1900);
						vars158=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars158.Tree);

						}
						break;

					default:
						if (cnt39 >= 1)
							goto loop39;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee39 = new EarlyExitException( 39, input );
						DebugRecognitionException(eee39);
						throw eee39;
					}
					cnt39++;
				}
				loop39:
					;

				} finally { DebugExitSubRule(39); }

				DebugLocation(193, 18);
				// MathLang.g:193:18: ( func_decl | proc_decl )*
				try { DebugEnterSubRule(40);
				while (true)
				{
					int alt40=3;
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					int LA40_0 = input.LA(1);

					if ((LA40_0==FUNC))
					{
						alt40=1;
					}
					else if ((LA40_0==PROC))
					{
						alt40=2;
					}


					} finally { DebugExitDecision(40); }
					switch ( alt40 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:193:19: func_decl
						{
						DebugLocation(193, 19);
						PushFollow(Follow._func_decl_in_program1905);
						func_decl159=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl159.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:193:29: proc_decl
						{
						DebugLocation(193, 29);
						PushFollow(Follow._proc_decl_in_program1907);
						proc_decl160=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl160.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }

				DebugLocation(193, 41);
				// MathLang.g:193:41: ( vars )*
				try { DebugEnterSubRule(41);
				while (true)
				{
					int alt41=2;
					try { DebugEnterDecision(41, decisionCanBacktrack[41]);
					int LA41_0 = input.LA(1);

					if ((LA41_0==VAR))
					{
						alt41=1;
					}


					} finally { DebugExitDecision(41); }
					switch ( alt41 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(193, 41);
						PushFollow(Follow._vars_in_program1911);
						vars161=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars161.Tree);

						}
						break;

					default:
						goto loop41;
					}
				}

				loop41:
					;

				} finally { DebugExitSubRule(41); }

				DebugLocation(193, 47);
				PushFollow(Follow._main__in_program1914);
				main_162=main_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, main_162.Tree);

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
		EnterRule("result", 29);
		TraceIn("result", 29);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF164=null;
		MathLangParser.program_return program163 = default(MathLangParser.program_return);

		object EOF164_tree=null;
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
			PushFollow(Follow._program_in_result1923);
			program163=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_program.Add(program163.Tree);
			DebugLocation(196, 17);
			EOF164=(IToken)Match(input,EOF,Follow._EOF_in_result1925); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF164);



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
			TraceOut("result", 29);
			LeaveRule("result", 29);
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
		EnterRule("execute", 30);
		TraceIn("execute", 30);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result165 = default(MathLangParser.result_return);


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
			PushFollow(Follow._result_in_execute1944);
			result165=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result165.Tree);

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
		DebugLocation(200, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred27_MathLang_fragment();
	partial void Leave_synpred27_MathLang_fragment();

	// $ANTLR start synpred27_MathLang
	public void synpred27_MathLang_fragment()
	{
		Enter_synpred27_MathLang_fragment();
		EnterRule("synpred27_MathLang_fragment", 57);
		TraceIn("synpred27_MathLang_fragment", 57);
		try
		{
			// MathLang.g:126:38: ( ELSIF term THEN exprList )
			DebugEnterAlt(1);
			// MathLang.g:126:38: ELSIF term THEN exprList
			{
			DebugLocation(126, 38);
			Match(input,ELSIF,Follow._ELSIF_in_synpred27_MathLang1361); if (state.failed) return;
			DebugLocation(126, 44);
			PushFollow(Follow._term_in_synpred27_MathLang1363);
			term();
			PopFollow();
			if (state.failed) return;
			DebugLocation(126, 49);
			Match(input,THEN,Follow._THEN_in_synpred27_MathLang1365); if (state.failed) return;
			DebugLocation(126, 54);
			PushFollow(Follow._exprList_in_synpred27_MathLang1367);
			exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred27_MathLang_fragment", 57);
			LeaveRule("synpred27_MathLang_fragment", 57);
			Leave_synpred27_MathLang_fragment();
		}
	}
	// $ANTLR end synpred27_MathLang

	partial void Enter_synpred28_MathLang_fragment();
	partial void Leave_synpred28_MathLang_fragment();

	// $ANTLR start synpred28_MathLang
	public void synpred28_MathLang_fragment()
	{
		Enter_synpred28_MathLang_fragment();
		EnterRule("synpred28_MathLang_fragment", 58);
		TraceIn("synpred28_MathLang_fragment", 58);
		try
		{
			// MathLang.g:126:66: ( ELSE exprList )
			DebugEnterAlt(1);
			// MathLang.g:126:66: ELSE exprList
			{
			DebugLocation(126, 66);
			Match(input,ELSE,Follow._ELSE_in_synpred28_MathLang1372); if (state.failed) return;
			DebugLocation(126, 71);
			PushFollow(Follow._exprList_in_synpred28_MathLang1374);
			exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred28_MathLang_fragment", 58);
			LeaveRule("synpred28_MathLang_fragment", 58);
			Leave_synpred28_MathLang_fragment();
		}
	}
	// $ANTLR end synpred28_MathLang

	partial void Enter_synpred47_MathLang_fragment();
	partial void Leave_synpred47_MathLang_fragment();

	// $ANTLR start synpred47_MathLang
	public void synpred47_MathLang_fragment()
	{
		Enter_synpred47_MathLang_fragment();
		EnterRule("synpred47_MathLang_fragment", 77);
		TraceIn("synpred47_MathLang_fragment", 77);
		try
		{
			// MathLang.g:159:17: ( type_decl )
			DebugEnterAlt(1);
			// MathLang.g:159:17: type_decl
			{
			DebugLocation(159, 17);
			PushFollow(Follow._type_decl_in_synpred47_MathLang1656);
			type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_MathLang_fragment", 77);
			LeaveRule("synpred47_MathLang_fragment", 77);
			Leave_synpred47_MathLang_fragment();
		}
	}
	// $ANTLR end synpred47_MathLang

	partial void Enter_synpred56_MathLang_fragment();
	partial void Leave_synpred56_MathLang_fragment();

	// $ANTLR start synpred56_MathLang
	public void synpred56_MathLang_fragment()
	{
		Enter_synpred56_MathLang_fragment();
		EnterRule("synpred56_MathLang_fragment", 86);
		TraceIn("synpred56_MathLang_fragment", 86);
		try
		{
			// MathLang.g:183:16: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:183:16: ';'
			{
			DebugLocation(183, 16);
			Match(input,63,Follow._63_in_synpred56_MathLang1844); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred56_MathLang_fragment", 86);
			LeaveRule("synpred56_MathLang_fragment", 86);
			Leave_synpred56_MathLang_fragment();
		}
	}
	// $ANTLR end synpred56_MathLang

	partial void Enter_synpred58_MathLang_fragment();
	partial void Leave_synpred58_MathLang_fragment();

	// $ANTLR start synpred58_MathLang
	public void synpred58_MathLang_fragment()
	{
		Enter_synpred58_MathLang_fragment();
		EnterRule("synpred58_MathLang_fragment", 88);
		TraceIn("synpred58_MathLang_fragment", 88);
		try
		{
			// MathLang.g:184:14: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:184:14: ';'
			{
			DebugLocation(184, 14);
			Match(input,63,Follow._63_in_synpred58_MathLang1855); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred58_MathLang_fragment", 88);
			LeaveRule("synpred58_MathLang_fragment", 88);
			Leave_synpred58_MathLang_fragment();
		}
	}
	// $ANTLR end synpred58_MathLang

	partial void Enter_synpred64_MathLang_fragment();
	partial void Leave_synpred64_MathLang_fragment();

	// $ANTLR start synpred64_MathLang
	public void synpred64_MathLang_fragment()
	{
		Enter_synpred64_MathLang_fragment();
		EnterRule("synpred64_MathLang_fragment", 94);
		TraceIn("synpred64_MathLang_fragment", 94);
		try
		{
			// MathLang.g:193:11: ( vars )
			DebugEnterAlt(1);
			// MathLang.g:193:11: vars
			{
			DebugLocation(193, 11);
			PushFollow(Follow._vars_in_synpred64_MathLang1900);
			vars();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred64_MathLang_fragment", 94);
			LeaveRule("synpred64_MathLang_fragment", 94);
			Leave_synpred64_MathLang_fragment();
		}
	}
	// $ANTLR end synpred64_MathLang
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
			"\x3\x2F\x1\x1B\x1\xFFFF\x1\x2F\x1\xFFFF";
		private const string DFA19_maxS =
			"\x1\x2F\x1\x41\x1\x2F\x1\x26\x1\xFFFF\x1\x41\x1\xFFFF";
		private const string DFA19_acceptS =
			"\x4\xFFFF\x1\x1\x1\xFFFF\x1\x2";
		private const string DFA19_specialS =
			"\x7\xFFFF}>";
		private static readonly string[] DFA19_transitionS =
			{
				"\x1\x1",
				"\x1\x4\x10\xFFFF\x1\x2\x1\x3",
				"\x1\x5",
				"\x4\x4\x7\xFFFF\x1\x6",
				"",
				"\x1\x4\x10\xFFFF\x1\x2\x1\x3",
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

		public override string Description { get { return "143:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _59_in_group1047 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_group1050 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_group1052 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_value_in_group1056 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1060 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1064 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1070 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_group1072 = new BitSet(new ulong[]{0xC00000000000UL});
		public static readonly BitSet _index__in_group1074 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_group1075 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult1095 = new BitSet(new ulong[]{0xC000000000002UL});
		public static readonly BitSet _set_in_mult1099 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _group_in_mult1110 = new BitSet(new ulong[]{0xC000000000002UL});
		public static readonly BitSet _mult_in_add1122 = new BitSet(new ulong[]{0x3000000000002UL});
		public static readonly BitSet _set_in_add1127 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _mult_in_add1138 = new BitSet(new ulong[]{0x3000000000002UL});
		public static readonly BitSet _add_in_compare1150 = new BitSet(new ulong[]{0x7E0000000000002UL});
		public static readonly BitSet _set_in_compare1153 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _add_in_compare1180 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_div1188 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _set_in_div1190 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _compare_in_div1199 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _div_in_and_logic1206 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _AND_in_and_logic1209 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _div_in_and_logic1212 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _and_logic_in_or_logic1220 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or_logic1223 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _and_logic_in_or_logic1226 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _or_logic_in_term1234 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_logic_value0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_index_0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1283 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1285 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_simpleExpr1288 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINT_in_simpleExpr1292 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_simpleExpr1295 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1300 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_simpleExpr1302 = new BitSet(new ulong[]{0xC00000000000UL});
		public static readonly BitSet _index__in_simpleExpr1304 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_simpleExpr1305 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1307 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _group_in_simpleExpr1309 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_in_simpleExpr1334 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_groupExpr1344 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_groupExpr1347 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1350 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_groupExpr1352 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1355 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1358 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSIF_in_groupExpr1361 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1363 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1365 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1367 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSE_in_groupExpr1372 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1374 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_groupExpr1381 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _IDENT_in_groupExpr1383 = new BitSet(new ulong[]{0x10000000000000UL});
		public static readonly BitSet _ASSIGN_in_groupExpr1385 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1389 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _TO_in_groupExpr1391 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1395 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1397 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1399 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_groupExpr1428 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_groupExpr1431 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1433 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_groupExpr1434 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1437 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1440 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_groupExpr1444 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1447 = new BitSet(new ulong[]{0x861407104000UL});
		public static readonly BitSet _UNTIL_in_groupExpr1450 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_groupExpr1453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1457 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1459 = new BitSet(new ulong[]{0x861C03104000UL});
		public static readonly BitSet _END_in_groupExpr1462 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_groupExpr1475 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_groupExpr1478 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_const_decl1488 = new BitSet(new ulong[]{0x100000000000000UL});
		public static readonly BitSet _EQUALS_in_const_decl1491 = new BitSet(new ulong[]{0xC00000000000UL});
		public static readonly BitSet _set_in_const_decl1494 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_const_decl1501 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _CONST__in_const_1512 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _const_decl_in_const_1515 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _IDENT_in_type_decl1528 = new BitSet(new ulong[]{0x800000000000UL,0x3UL});
		public static readonly BitSet _64_in_type_decl1531 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1533 = new BitSet(new ulong[]{0x800000000000UL,0x3UL});
		public static readonly BitSet _65_in_type_decl1539 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1541 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_type_decl1553 = new BitSet(new ulong[]{0x0UL,0x3UL});
		public static readonly BitSet _64_in_type_decl1556 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1558 = new BitSet(new ulong[]{0x0UL,0x3UL});
		public static readonly BitSet _65_in_type_decl1561 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _ARRAY_in_type_decl1563 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_type_decl1565 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _group_in_type_decl1567 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_type_decl1569 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_type_decl1570 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _group_in_type_decl1571 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_type_decl1573 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _OF_in_type_decl1575 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_vars1602 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _type_decl_in_vars1606 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_vars1608 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _term_in_param1619 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _param_in_params_1628 = new BitSet(new ulong[]{0x2UL,0x1UL});
		public static readonly BitSet _64_in_params_1630 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _param_in_params_1632 = new BitSet(new ulong[]{0x2UL,0x1UL});
		public static readonly BitSet _VAR_in_param_var1653 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _type_decl_in_param_var1656 = new BitSet(new ulong[]{0x800000000002UL});
		public static readonly BitSet _FUNC_in_func_sign1666 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _IDENT_in_func_sign1668 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_func_sign1670 = new BitSet(new ulong[]{0x1000800000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1673 = new BitSet(new ulong[]{0x9000800000000000UL});
		public static readonly BitSet _63_in_func_sign1676 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1678 = new BitSet(new ulong[]{0x9000800000000000UL});
		public static readonly BitSet _60_in_func_sign1683 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_func_sign1685 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_func_sign1687 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_func_sign1689 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_in_proc_sign1715 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _IDENT_in_proc_sign1717 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_proc_sign1719 = new BitSet(new ulong[]{0x1000800000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1722 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_proc_sign1725 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1727 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_proc_sign1731 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _param_var_in_proc_sign1733 = new BitSet(new ulong[]{0x1000800000000000UL});
		public static readonly BitSet _60_in_proc_sign1736 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_proc_sign1738 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_sign_in_func_decl1767 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_func_decl1770 = new BitSet(new ulong[]{0x871603104000UL});
		public static readonly BitSet _const__in_func_decl1773 = new BitSet(new ulong[]{0x871603104000UL});
		public static readonly BitSet _vars_in_func_decl1776 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _groupExpr_in_func_decl1779 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_func_decl1781 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_sign_in_proc_decl1790 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_proc_decl1793 = new BitSet(new ulong[]{0x871603104000UL});
		public static readonly BitSet _const__in_proc_decl1796 = new BitSet(new ulong[]{0x871603104000UL});
		public static readonly BitSet _vars_in_proc_decl1799 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _groupExpr_in_proc_decl1802 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_proc_decl1804 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1813 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_call1815 = new BitSet(new ulong[]{0x1800C00000000030UL});
		public static readonly BitSet _params__in_call1817 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_call1819 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList1841 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_exprList1844 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _groupExpr_in_exprList1852 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _63_in_exprList1855 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _BEGIN_in_main_1868 = new BitSet(new ulong[]{0x861C03104000UL});
		public static readonly BitSet _exprList_in_main_1871 = new BitSet(new ulong[]{0x861C03104000UL});
		public static readonly BitSet _END_in_main_1874 = new BitSet(new ulong[]{0x0UL,0x4UL});
		public static readonly BitSet _66_in_main_1877 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_program1888 = new BitSet(new ulong[]{0x861403104002UL});
		public static readonly BitSet _proc_decl_in_program1891 = new BitSet(new ulong[]{0x861403104002UL});
		public static readonly BitSet _const__in_program1897 = new BitSet(new ulong[]{0x10200000000UL});
		public static readonly BitSet _vars_in_program1900 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _func_decl_in_program1905 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _proc_decl_in_program1907 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _vars_in_program1911 = new BitSet(new ulong[]{0x861603104000UL});
		public static readonly BitSet _main__in_program1914 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result1923 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1925 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1944 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSIF_in_synpred27_MathLang1361 = new BitSet(new ulong[]{0x800C00000000030UL});
		public static readonly BitSet _term_in_synpred27_MathLang1363 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_synpred27_MathLang1365 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_synpred27_MathLang1367 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred28_MathLang1372 = new BitSet(new ulong[]{0x861403104000UL});
		public static readonly BitSet _exprList_in_synpred28_MathLang1374 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_decl_in_synpred47_MathLang1656 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _63_in_synpred56_MathLang1844 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _63_in_synpred58_MathLang1855 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _vars_in_synpred64_MathLang1900 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
