// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2016-12-20 15:06:37

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TRUE", "FALSE", "AND", "OR", "UNKNOWN", "BLOCK", "PROGRAM", "CONVERT", "INDEX", "IF", "THEN", "ELSE", "ELSIF", "DIV", "MOD", "FOR", "TO", "DOWNTO", "DO", "WHILE", "REPEAT", "UNTIL", "INT", "REAL", "CHAR", "BOOL", "CALL", "PARAMS", "VAR", "BEGIN", "END", "PRINT", "INPUT", "ARRAY", "OF", "CONST_", "FUNC", "PROC", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIDE", "ASSIGN", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "'('", "')'", "'['", "']'", "';'", "','", "':'", "'.'"
	};
	public const int EOF=-1;
	public const int T__58=58;
	public const int T__59=59;
	public const int T__60=60;
	public const int T__61=61;
	public const int T__62=62;
	public const int T__63=63;
	public const int T__64=64;
	public const int T__65=65;
	public const int TRUE=4;
	public const int FALSE=5;
	public const int AND=6;
	public const int OR=7;
	public const int UNKNOWN=8;
	public const int BLOCK=9;
	public const int PROGRAM=10;
	public const int CONVERT=11;
	public const int INDEX=12;
	public const int IF=13;
	public const int THEN=14;
	public const int ELSE=15;
	public const int ELSIF=16;
	public const int DIV=17;
	public const int MOD=18;
	public const int FOR=19;
	public const int TO=20;
	public const int DOWNTO=21;
	public const int DO=22;
	public const int WHILE=23;
	public const int REPEAT=24;
	public const int UNTIL=25;
	public const int INT=26;
	public const int REAL=27;
	public const int CHAR=28;
	public const int BOOL=29;
	public const int CALL=30;
	public const int PARAMS=31;
	public const int VAR=32;
	public const int BEGIN=33;
	public const int END=34;
	public const int PRINT=35;
	public const int INPUT=36;
	public const int ARRAY=37;
	public const int OF=38;
	public const int CONST_=39;
	public const int FUNC=40;
	public const int PROC=41;
	public const int WS=42;
	public const int SL_COMMENT=43;
	public const int ML_COMMENT=44;
	public const int NUMBER=45;
	public const int IDENT=46;
	public const int ADD=47;
	public const int SUB=48;
	public const int MUL=49;
	public const int DIVIDE=50;
	public const int ASSIGN=51;
	public const int GE=52;
	public const int LE=53;
	public const int NEQUALS=54;
	public const int EQUALS=55;
	public const int GT=56;
	public const int LT=57;

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
				false, true, true, false, false, false, false, true, true, false, false, 
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
	// MathLang.g:93:1: group : ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) );
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
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(93, 0);
		try
		{
			// MathLang.g:93:6: ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 58:
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

				if ((LA1_4==60))
				{
					alt1=5;
				}
				else if ((LA1_4==EOF||(LA1_4>=AND && LA1_4<=OR)||(LA1_4>=IF && LA1_4<=UNTIL)||(LA1_4>=BEGIN && LA1_4<=END)||(LA1_4>=FUNC && LA1_4<=PROC)||(LA1_4>=IDENT && LA1_4<=DIVIDE)||(LA1_4>=GE && LA1_4<=LT)||LA1_4==59||(LA1_4>=61 && LA1_4<=63)||LA1_4==65))
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
				// MathLang.g:94:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 6);
				char_literal1=(IToken)Match(input,58,Follow._58_in_group1031); if (state.failed) return retval;
				DebugLocation(94, 8);
				PushFollow(Follow._term_in_group1034);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(94, 16);
				char_literal3=(IToken)Match(input,59,Follow._59_in_group1036); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:95:2: logic_value
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(95, 2);
				PushFollow(Follow._logic_value_in_group1040);
				logic_value4=logic_value();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, logic_value4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:96:3: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(96, 3);
				NUMBER5=(IToken)Match(input,NUMBER,Follow._NUMBER_in_group1044); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NUMBER5_tree = (object)adaptor.Create(NUMBER5);
				adaptor.AddChild(root_0, NUMBER5_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:97:3: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(97, 3);
				IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_group1048); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT6_tree = (object)adaptor.Create(IDENT6);
				adaptor.AddChild(root_0, IDENT6_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:98:4: ( IDENT '[' index_ ']' )
				{
				DebugLocation(98, 4);
				// MathLang.g:98:4: ( IDENT '[' index_ ']' )
				DebugEnterAlt(1);
				// MathLang.g:98:5: IDENT '[' index_ ']'
				{
				DebugLocation(98, 5);
				IDENT7=(IToken)Match(input,IDENT,Follow._IDENT_in_group1054); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT7);

				DebugLocation(98, 11);
				char_literal8=(IToken)Match(input,60,Follow._60_in_group1056); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal8);

				DebugLocation(98, 15);
				PushFollow(Follow._index__in_group1058);
				index_9=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_9.Tree);
				DebugLocation(98, 21);
				char_literal10=(IToken)Match(input,61,Follow._61_in_group1059); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal10);


				}



				{
				// AST REWRITE
				// elements: index_, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 98:26: -> ^( IDENT ^( INDEX index_ ) )
				{
					DebugLocation(98, 28);
					// MathLang.g:98:28: ^( IDENT ^( INDEX index_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(98, 30);
					root_1 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_1);

					DebugLocation(98, 36);
					// MathLang.g:98:36: ^( INDEX index_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(98, 38);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_2);

					DebugLocation(98, 44);
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
		DebugLocation(99, 0);
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
	// MathLang.g:101:1: mult : group ( ( MUL | DIVIDE ) group )* ;
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
		DebugLocation(101, 42);
		try
		{
			// MathLang.g:101:5: ( group ( ( MUL | DIVIDE ) group )* )
			DebugEnterAlt(1);
			// MathLang.g:101:7: group ( ( MUL | DIVIDE ) group )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(101, 7);
			PushFollow(Follow._group_in_mult1079);
			group11=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);
			DebugLocation(101, 13);
			// MathLang.g:101:13: ( ( MUL | DIVIDE ) group )*
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
					// MathLang.g:101:15: ( MUL | DIVIDE ) group
					{
					DebugLocation(101, 15);
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

					DebugLocation(101, 33);
					PushFollow(Follow._group_in_mult1094);
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
		DebugLocation(101, 42);
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
	// MathLang.g:102:1: add : mult ( ( ADD | SUB ) mult )* ;
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
		DebugLocation(102, 39);
		try
		{
			// MathLang.g:102:4: ( mult ( ( ADD | SUB ) mult )* )
			DebugEnterAlt(1);
			// MathLang.g:102:7: mult ( ( ADD | SUB ) mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 7);
			PushFollow(Follow._mult_in_add1106);
			mult14=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);
			DebugLocation(102, 13);
			// MathLang.g:102:13: ( ( ADD | SUB ) mult )*
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
					// MathLang.g:102:15: ( ADD | SUB ) mult
					{
					DebugLocation(102, 15);
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

					DebugLocation(102, 30);
					PushFollow(Follow._mult_in_add1122);
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
		DebugLocation(102, 39);
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
	// MathLang.g:103:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
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
		DebugLocation(103, 61);
		try
		{
			// MathLang.g:103:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
			DebugEnterAlt(1);
			// MathLang.g:103:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(103, 10);
			PushFollow(Follow._add_in_compare1134);
			add17=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);
			DebugLocation(103, 14);
			// MathLang.g:103:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
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
				// MathLang.g:103:15: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(103, 15);
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

				DebugLocation(103, 57);
				PushFollow(Follow._add_in_compare1164);
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
		DebugLocation(103, 61);
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
	// MathLang.g:104:1: div : compare ( ( DIV | MOD ) compare )* ;
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
		DebugLocation(104, 35);
		try
		{
			// MathLang.g:104:4: ( compare ( ( DIV | MOD ) compare )* )
			DebugEnterAlt(1);
			// MathLang.g:104:6: compare ( ( DIV | MOD ) compare )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 6);
			PushFollow(Follow._compare_in_div1172);
			compare20=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare20.Tree);
			DebugLocation(104, 13);
			// MathLang.g:104:13: ( ( DIV | MOD ) compare )*
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
					// MathLang.g:104:14: ( DIV | MOD ) compare
					{
					DebugLocation(104, 14);
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

					DebugLocation(104, 27);
					PushFollow(Follow._compare_in_div1183);
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
		DebugLocation(104, 35);
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
	// MathLang.g:105:1: and_logic : div ( AND div )* ;
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
		DebugLocation(105, 25);
		try
		{
			// MathLang.g:105:10: ( div ( AND div )* )
			DebugEnterAlt(1);
			// MathLang.g:105:11: div ( AND div )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 11);
			PushFollow(Follow._div_in_and_logic1190);
			div23=div();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div23.Tree);
			DebugLocation(105, 15);
			// MathLang.g:105:15: ( AND div )*
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
					// MathLang.g:105:16: AND div
					{
					DebugLocation(105, 19);
					AND24=(IToken)Match(input,AND,Follow._AND_in_and_logic1193); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND24_tree = (object)adaptor.Create(AND24);
					root_0 = (object)adaptor.BecomeRoot(AND24_tree, root_0);
					}
					DebugLocation(105, 21);
					PushFollow(Follow._div_in_and_logic1196);
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
		DebugLocation(105, 25);
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
	// MathLang.g:106:1: or_logic : and_logic ( OR and_logic )* ;
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
		DebugLocation(106, 36);
		try
		{
			// MathLang.g:106:9: ( and_logic ( OR and_logic )* )
			DebugEnterAlt(1);
			// MathLang.g:106:11: and_logic ( OR and_logic )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(106, 11);
			PushFollow(Follow._and_logic_in_or_logic1204);
			and_logic26=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic26.Tree);
			DebugLocation(106, 21);
			// MathLang.g:106:21: ( OR and_logic )*
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
					// MathLang.g:106:22: OR and_logic
					{
					DebugLocation(106, 24);
					OR27=(IToken)Match(input,OR,Follow._OR_in_or_logic1207); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR27_tree = (object)adaptor.Create(OR27);
					root_0 = (object)adaptor.BecomeRoot(OR27_tree, root_0);
					}
					DebugLocation(106, 26);
					PushFollow(Follow._and_logic_in_or_logic1210);
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
		DebugLocation(106, 36);
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
	// MathLang.g:107:1: term : or_logic ;
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
		DebugLocation(107, 14);
		try
		{
			// MathLang.g:107:5: ( or_logic )
			DebugEnterAlt(1);
			// MathLang.g:107:7: or_logic
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 7);
			PushFollow(Follow._or_logic_in_term1218);
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
		DebugLocation(107, 14);
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
	// MathLang.g:109:1: logic_value : ( TRUE | FALSE );
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
		DebugLocation(109, 24);
		try
		{
			// MathLang.g:109:12: ( TRUE | FALSE )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 12);
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
		DebugLocation(109, 24);
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
	// MathLang.g:111:1: type : ( INT | REAL | BOOL | CHAR );
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
		DebugLocation(111, 0);
		try
		{
			// MathLang.g:111:5: ( INT | REAL | BOOL | CHAR )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(111, 5);
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
		DebugLocation(112, 0);
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
	// MathLang.g:114:1: index_ : ( IDENT | NUMBER );
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
		DebugLocation(114, 0);
		try
		{
			// MathLang.g:114:7: ( IDENT | NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 7);
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
		DebugLocation(115, 0);
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
	// MathLang.g:117:1: simpleExpr : ( IDENT ASSIGN term | ( IDENT '[' index_ ']' ASSIGN group ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group ) | call );
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
		IToken IDENT36=null;
		IToken char_literal37=null;
		IToken char_literal39=null;
		IToken ASSIGN40=null;
		MathLangParser.term_return term35 = default(MathLangParser.term_return);
		MathLangParser.index__return index_38 = default(MathLangParser.index__return);
		MathLangParser.group_return group41 = default(MathLangParser.group_return);
		MathLangParser.call_return call42 = default(MathLangParser.call_return);

		object IDENT33_tree=null;
		object ASSIGN34_tree=null;
		object IDENT36_tree=null;
		object char_literal37_tree=null;
		object char_literal39_tree=null;
		object ASSIGN40_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(117, 0);
		try
		{
			// MathLang.g:117:11: ( IDENT ASSIGN term | ( IDENT '[' index_ ']' ASSIGN group ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group ) | call )
			int alt8=3;
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
				case 60:
					{
					alt8=2;
					}
					break;
				case 58:
					{
					alt8=3;
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
				// MathLang.g:118:3: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(118, 3);
				IDENT33=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1267); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT33_tree = (object)adaptor.Create(IDENT33);
				adaptor.AddChild(root_0, IDENT33_tree);
				}
				DebugLocation(118, 15);
				ASSIGN34=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1269); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN34_tree = (object)adaptor.Create(ASSIGN34);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN34_tree, root_0);
				}
				DebugLocation(118, 17);
				PushFollow(Follow._term_in_simpleExpr1272);
				term35=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term35.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:119:2: ( IDENT '[' index_ ']' ASSIGN group )
				{
				DebugLocation(119, 2);
				// MathLang.g:119:2: ( IDENT '[' index_ ']' ASSIGN group )
				DebugEnterAlt(1);
				// MathLang.g:119:4: IDENT '[' index_ ']' ASSIGN group
				{
				DebugLocation(119, 4);
				IDENT36=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1277); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT36);

				DebugLocation(119, 10);
				char_literal37=(IToken)Match(input,60,Follow._60_in_simpleExpr1279); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal37);

				DebugLocation(119, 14);
				PushFollow(Follow._index__in_simpleExpr1281);
				index_38=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_38.Tree);
				DebugLocation(119, 20);
				char_literal39=(IToken)Match(input,61,Follow._61_in_simpleExpr1282); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal39);

				DebugLocation(119, 24);
				ASSIGN40=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1284); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN40);

				DebugLocation(119, 31);
				PushFollow(Follow._group_in_simpleExpr1286);
				group41=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group41.Tree);

				}



				{
				// AST REWRITE
				// elements: index_, ASSIGN, IDENT, group
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 119:37: -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group )
				{
					DebugLocation(119, 40);
					// MathLang.g:119:40: ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) group )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(119, 42);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(119, 49);
					// MathLang.g:119:49: ^( IDENT ^( INDEX index_ ) )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(119, 52);
					root_2 = (object)adaptor.BecomeRoot(stream_IDENT.NextNode(), root_2);

					DebugLocation(119, 58);
					// MathLang.g:119:58: ^( INDEX index_ )
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(119, 60);
					root_3 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEX, "INDEX"), root_3);

					DebugLocation(119, 67);
					adaptor.AddChild(root_3, stream_index_.NextTree());

					adaptor.AddChild(root_2, root_3);
					}

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(119, 77);
					adaptor.AddChild(root_1, stream_group.NextTree());

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
				// MathLang.g:120:3: call
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(120, 3);
				PushFollow(Follow._call_in_simpleExpr1311);
				call42=call();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call42.Tree);

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
		DebugLocation(121, 0);
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
	// MathLang.g:123:1: groupExpr : ( IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )? | FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO exprList | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl );
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 13);
		TraceIn("groupExpr", 13);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF43=null;
		IToken char_literal44=null;
		IToken char_literal46=null;
		IToken THEN47=null;
		IToken ELSIF49=null;
		IToken THEN51=null;
		IToken ELSE53=null;
		IToken FOR55=null;
		IToken IDENT56=null;
		IToken ASSIGN57=null;
		IToken set59=null;
		IToken DO61=null;
		IToken WHILE63=null;
		IToken char_literal64=null;
		IToken char_literal66=null;
		IToken DO67=null;
		IToken REPEAT69=null;
		IToken UNTIL71=null;
		IToken BEGIN73=null;
		IToken END75=null;
		MathLangParser.term_return term45 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList48 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term50 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList52 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList54 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term58 = default(MathLangParser.term_return);
		MathLangParser.term_return term60 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList62 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term65 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList68 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList70 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term72 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList74 = default(MathLangParser.exprList_return);
		MathLangParser.func_decl_return func_decl76 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl77 = default(MathLangParser.proc_decl_return);

		object IF43_tree=null;
		object char_literal44_tree=null;
		object char_literal46_tree=null;
		object THEN47_tree=null;
		object ELSIF49_tree=null;
		object THEN51_tree=null;
		object ELSE53_tree=null;
		object FOR55_tree=null;
		object IDENT56_tree=null;
		object ASSIGN57_tree=null;
		object set59_tree=null;
		object DO61_tree=null;
		object WHILE63_tree=null;
		object char_literal64_tree=null;
		object char_literal66_tree=null;
		object DO67_tree=null;
		object REPEAT69_tree=null;
		object UNTIL71_tree=null;
		object BEGIN73_tree=null;
		object END75_tree=null;
		RewriteRuleITokenStream stream_END=new RewriteRuleITokenStream(adaptor,"token END");
		RewriteRuleITokenStream stream_BEGIN=new RewriteRuleITokenStream(adaptor,"token BEGIN");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(123, 0);
		try
		{
			// MathLang.g:123:10: ( IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )? | FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO exprList | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl )
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
				// MathLang.g:124:3: IF '(' term ')' THEN exprList ( ELSIF term THEN exprList )* ( ELSE exprList )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 5);
				IF43=(IToken)Match(input,IF,Follow._IF_in_groupExpr1321); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				IF43_tree = (object)adaptor.Create(IF43);
				root_0 = (object)adaptor.BecomeRoot(IF43_tree, root_0);
				}
				DebugLocation(124, 10);
				char_literal44=(IToken)Match(input,58,Follow._58_in_groupExpr1324); if (state.failed) return retval;
				DebugLocation(124, 12);
				PushFollow(Follow._term_in_groupExpr1327);
				term45=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term45.Tree);
				DebugLocation(124, 20);
				char_literal46=(IToken)Match(input,59,Follow._59_in_groupExpr1329); if (state.failed) return retval;
				DebugLocation(124, 26);
				THEN47=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1332); if (state.failed) return retval;
				DebugLocation(124, 28);
				PushFollow(Follow._exprList_in_groupExpr1335);
				exprList48=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList48.Tree);
				DebugLocation(124, 37);
				// MathLang.g:124:37: ( ELSIF term THEN exprList )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==ELSIF))
					{
						int LA9_2 = input.LA(2);

						if ((EvaluatePredicate(synpred26_MathLang_fragment)))
						{
							alt9=1;
						}


					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:124:38: ELSIF term THEN exprList
						{
						DebugLocation(124, 38);
						ELSIF49=(IToken)Match(input,ELSIF,Follow._ELSIF_in_groupExpr1338); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						ELSIF49_tree = (object)adaptor.Create(ELSIF49);
						adaptor.AddChild(root_0, ELSIF49_tree);
						}
						DebugLocation(124, 44);
						PushFollow(Follow._term_in_groupExpr1340);
						term50=term();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term50.Tree);
						DebugLocation(124, 49);
						THEN51=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1342); if (state.failed) return retval;
						if ( state.backtracking==0 ) {
						THEN51_tree = (object)adaptor.Create(THEN51);
						adaptor.AddChild(root_0, THEN51_tree);
						}
						DebugLocation(124, 54);
						PushFollow(Follow._exprList_in_groupExpr1344);
						exprList52=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList52.Tree);

						}
						break;

					default:
						goto loop9;
					}
				}

				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(124, 65);
				// MathLang.g:124:65: ( ELSE exprList )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==ELSE))
				{
					int LA10_1 = input.LA(2);

					if ((EvaluatePredicate(synpred27_MathLang_fragment)))
					{
						alt10=1;
					}
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:124:66: ELSE exprList
					{
					DebugLocation(124, 66);
					ELSE53=(IToken)Match(input,ELSE,Follow._ELSE_in_groupExpr1349); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					ELSE53_tree = (object)adaptor.Create(ELSE53);
					adaptor.AddChild(root_0, ELSE53_tree);
					}
					DebugLocation(124, 71);
					PushFollow(Follow._exprList_in_groupExpr1351);
					exprList54=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList54.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(10); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:125:3: FOR IDENT ASSIGN term ( TO | DOWNTO ) term DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(125, 6);
				FOR55=(IToken)Match(input,FOR,Follow._FOR_in_groupExpr1357); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				FOR55_tree = (object)adaptor.Create(FOR55);
				root_0 = (object)adaptor.BecomeRoot(FOR55_tree, root_0);
				}
				DebugLocation(125, 8);
				IDENT56=(IToken)Match(input,IDENT,Follow._IDENT_in_groupExpr1360); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT56_tree = (object)adaptor.Create(IDENT56);
				adaptor.AddChild(root_0, IDENT56_tree);
				}
				DebugLocation(125, 20);
				ASSIGN57=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_groupExpr1362); if (state.failed) return retval;
				DebugLocation(125, 22);
				PushFollow(Follow._term_in_groupExpr1365);
				term58=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term58.Tree);
				DebugLocation(125, 27);
				set59=(IToken)input.LT(1);
				if ((input.LA(1)>=TO && input.LA(1)<=DOWNTO))
				{
					input.Consume();
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(125, 40);
				PushFollow(Follow._term_in_groupExpr1374);
				term60=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term60.Tree);
				DebugLocation(125, 47);
				DO61=(IToken)Match(input,DO,Follow._DO_in_groupExpr1376); if (state.failed) return retval;
				DebugLocation(125, 49);
				PushFollow(Follow._exprList_in_groupExpr1379);
				exprList62=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList62.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:126:3: WHILE '(' term ')' DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 8);
				WHILE63=(IToken)Match(input,WHILE,Follow._WHILE_in_groupExpr1383); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE63_tree = (object)adaptor.Create(WHILE63);
				root_0 = (object)adaptor.BecomeRoot(WHILE63_tree, root_0);
				}
				DebugLocation(126, 13);
				char_literal64=(IToken)Match(input,58,Follow._58_in_groupExpr1386); if (state.failed) return retval;
				DebugLocation(126, 14);
				PushFollow(Follow._term_in_groupExpr1388);
				term65=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term65.Tree);
				DebugLocation(126, 21);
				char_literal66=(IToken)Match(input,59,Follow._59_in_groupExpr1389); if (state.failed) return retval;
				DebugLocation(126, 25);
				DO67=(IToken)Match(input,DO,Follow._DO_in_groupExpr1392); if (state.failed) return retval;
				DebugLocation(126, 27);
				PushFollow(Follow._exprList_in_groupExpr1395);
				exprList68=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList68.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:127:3: REPEAT ( exprList )+ UNTIL term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 9);
				REPEAT69=(IToken)Match(input,REPEAT,Follow._REPEAT_in_groupExpr1399); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				REPEAT69_tree = (object)adaptor.Create(REPEAT69);
				root_0 = (object)adaptor.BecomeRoot(REPEAT69_tree, root_0);
				}
				DebugLocation(127, 11);
				// MathLang.g:127:11: ( exprList )+
				int cnt11=0;
				try { DebugEnterSubRule(11);
				while (true)
				{
					int alt11=2;
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==IF||LA11_0==FOR||(LA11_0>=WHILE && LA11_0<=REPEAT)||LA11_0==BEGIN||(LA11_0>=FUNC && LA11_0<=PROC)||LA11_0==IDENT))
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
						DebugLocation(127, 11);
						PushFollow(Follow._exprList_in_groupExpr1402);
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

				DebugLocation(127, 26);
				UNTIL71=(IToken)Match(input,UNTIL,Follow._UNTIL_in_groupExpr1405); if (state.failed) return retval;
				DebugLocation(127, 28);
				PushFollow(Follow._term_in_groupExpr1408);
				term72=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term72.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:128:3: BEGIN ( exprList )+ END
				{
				DebugLocation(128, 3);
				BEGIN73=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1412); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN73);

				DebugLocation(128, 9);
				// MathLang.g:128:9: ( exprList )+
				int cnt12=0;
				try { DebugEnterSubRule(12);
				while (true)
				{
					int alt12=2;
					try { DebugEnterDecision(12, decisionCanBacktrack[12]);
					int LA12_0 = input.LA(1);

					if ((LA12_0==IF||LA12_0==FOR||(LA12_0>=WHILE && LA12_0<=REPEAT)||LA12_0==BEGIN||(LA12_0>=FUNC && LA12_0<=PROC)||LA12_0==IDENT))
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
						DebugLocation(128, 9);
						PushFollow(Follow._exprList_in_groupExpr1414);
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

				DebugLocation(128, 19);
				END75=(IToken)Match(input,END,Follow._END_in_groupExpr1417); if (state.failed) return retval; 
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
				// 128:24: -> ^( BLOCK ( exprList )+ )
				{
					DebugLocation(128, 27);
					// MathLang.g:128:27: ^( BLOCK ( exprList )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(128, 29);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(128, 35);
					if ( !(stream_exprList.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_exprList.HasNext )
					{
						DebugLocation(128, 35);
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
				// MathLang.g:129:2: func_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(129, 2);
				PushFollow(Follow._func_decl_in_groupExpr1430);
				func_decl76=func_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl76.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:130:2: proc_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(130, 2);
				PushFollow(Follow._proc_decl_in_groupExpr1433);
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
		DebugLocation(131, 0);
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
	// MathLang.g:134:1: const_decl : IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ ;
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
		DebugLocation(134, 0);
		try
		{
			// MathLang.g:134:11: ( IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:135:2: IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(135, 7);
			IDENT78=(IToken)Match(input,IDENT,Follow._IDENT_in_const_decl1443); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IDENT78_tree = (object)adaptor.Create(IDENT78);
			root_0 = (object)adaptor.BecomeRoot(IDENT78_tree, root_0);
			}
			DebugLocation(135, 15);
			EQUALS79=(IToken)Match(input,EQUALS,Follow._EQUALS_in_const_decl1446); if (state.failed) return retval;
			DebugLocation(135, 17);
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

			DebugLocation(135, 32);
			// MathLang.g:135:32: ( ';' )+
			int cnt14=0;
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if ((LA14_0==62))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch (alt14)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:135:33: ';'
					{
					DebugLocation(135, 36);
					char_literal81=(IToken)Match(input,62,Follow._62_in_const_decl1456); if (state.failed) return retval;

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
		DebugLocation(136, 0);
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
	// MathLang.g:137:1: const_ : CONST_ ( const_decl )+ ;
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
		DebugLocation(137, 0);
		try
		{
			// MathLang.g:137:7: ( CONST_ ( const_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:138:1: CONST_ ( const_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(138, 7);
			CONST_82=(IToken)Match(input,CONST_,Follow._CONST__in_const_1467); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_82_tree = (object)adaptor.Create(CONST_82);
			root_0 = (object)adaptor.BecomeRoot(CONST_82_tree, root_0);
			}
			DebugLocation(138, 9);
			// MathLang.g:138:9: ( const_decl )+
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
					DebugLocation(138, 9);
					PushFollow(Follow._const_decl_in_const_1470);
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
		DebugLocation(139, 0);
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
	// MathLang.g:141:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );
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
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_65=new RewriteRuleITokenStream(adaptor,"token 65");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type_decl");
		DebugLocation(141, 0);
		try
		{
			// MathLang.g:141:10: ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) )
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
				// MathLang.g:142:2: ( ( IDENT ( ',' IDENT )* )+ ) ':' type
				{
				DebugLocation(142, 2);
				// MathLang.g:142:2: ( ( IDENT ( ',' IDENT )* )+ )
				DebugEnterAlt(1);
				// MathLang.g:142:4: ( IDENT ( ',' IDENT )* )+
				{
				DebugLocation(142, 4);
				// MathLang.g:142:4: ( IDENT ( ',' IDENT )* )+
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
						// MathLang.g:142:5: IDENT ( ',' IDENT )*
						{
						DebugLocation(142, 5);
						IDENT84=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1483); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT84);

						DebugLocation(142, 11);
						// MathLang.g:142:11: ( ',' IDENT )*
						try { DebugEnterSubRule(16);
						while (true)
						{
							int alt16=2;
							try { DebugEnterDecision(16, decisionCanBacktrack[16]);
							int LA16_0 = input.LA(1);

							if ((LA16_0==63))
							{
								alt16=1;
							}


							} finally { DebugExitDecision(16); }
							switch ( alt16 )
							{
							case 1:
								DebugEnterAlt(1);
								// MathLang.g:142:12: ',' IDENT
								{
								DebugLocation(142, 12);
								char_literal85=(IToken)Match(input,63,Follow._63_in_type_decl1486); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_63.Add(char_literal85);

								DebugLocation(142, 16);
								IDENT86=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1488); if (state.failed) return retval; 
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

				DebugLocation(142, 26);
				char_literal87=(IToken)Match(input,64,Follow._64_in_type_decl1494); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal87);

				DebugLocation(142, 30);
				PushFollow(Follow._type_in_type_decl1496);
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
				// 142:34: -> ^( type ( IDENT )+ )
				{
					DebugLocation(142, 37);
					// MathLang.g:142:37: ^( type ( IDENT )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(142, 39);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(142, 44);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(142, 44);
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
				// MathLang.g:143:3: IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type
				{
				DebugLocation(143, 3);
				IDENT89=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1508); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT89);

				DebugLocation(143, 9);
				// MathLang.g:143:9: ( ',' IDENT )*
				try { DebugEnterSubRule(18);
				while (true)
				{
					int alt18=2;
					try { DebugEnterDecision(18, decisionCanBacktrack[18]);
					int LA18_0 = input.LA(1);

					if ((LA18_0==63))
					{
						alt18=1;
					}


					} finally { DebugExitDecision(18); }
					switch ( alt18 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:143:10: ',' IDENT
						{
						DebugLocation(143, 10);
						char_literal90=(IToken)Match(input,63,Follow._63_in_type_decl1511); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_63.Add(char_literal90);

						DebugLocation(143, 14);
						IDENT91=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1513); if (state.failed) return retval; 
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

				DebugLocation(143, 21);
				char_literal92=(IToken)Match(input,64,Follow._64_in_type_decl1516); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_64.Add(char_literal92);

				DebugLocation(143, 25);
				ARRAY93=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_decl1518); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY93);

				DebugLocation(143, 31);
				char_literal94=(IToken)Match(input,60,Follow._60_in_type_decl1520); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal94);

				DebugLocation(143, 35);
				PushFollow(Follow._group_in_type_decl1522);
				group95=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group95.Tree);
				DebugLocation(143, 41);
				char_literal96=(IToken)Match(input,65,Follow._65_in_type_decl1524); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal96);

				DebugLocation(143, 44);
				char_literal97=(IToken)Match(input,65,Follow._65_in_type_decl1525); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_65.Add(char_literal97);

				DebugLocation(143, 47);
				PushFollow(Follow._group_in_type_decl1526);
				group98=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group98.Tree);
				DebugLocation(143, 53);
				char_literal99=(IToken)Match(input,61,Follow._61_in_type_decl1528); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal99);

				DebugLocation(143, 57);
				OF100=(IToken)Match(input,OF,Follow._OF_in_type_decl1530); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF100);

				DebugLocation(143, 60);
				PushFollow(Follow._type_in_type_decl1532);
				type101=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type101.Tree);


				{
				// AST REWRITE
				// elements: type, group, ARRAY, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 143:65: -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
				{
					DebugLocation(143, 68);
					// MathLang.g:143:68: ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(143, 70);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(143, 75);
					// MathLang.g:143:75: ^( ARRAY ( IDENT )+ ( group )+ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(143, 77);
					root_2 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_2);

					DebugLocation(143, 83);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(143, 83);
						adaptor.AddChild(root_2, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();
					DebugLocation(143, 90);
					if ( !(stream_group.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_group.HasNext )
					{
						DebugLocation(143, 90);
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
		DebugLocation(144, 0);
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
	// MathLang.g:146:1: vars : VAR ( type_decl ';' )+ ;
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
		DebugLocation(146, 0);
		try
		{
			// MathLang.g:146:5: ( VAR ( type_decl ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:147:2: VAR ( type_decl ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(147, 5);
			VAR102=(IToken)Match(input,VAR,Follow._VAR_in_vars1557); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR102_tree = (object)adaptor.Create(VAR102);
			root_0 = (object)adaptor.BecomeRoot(VAR102_tree, root_0);
			}
			DebugLocation(147, 7);
			// MathLang.g:147:7: ( type_decl ';' )+
			int cnt20=0;
			try { DebugEnterSubRule(20);
			while (true)
			{
				int alt20=2;
				try { DebugEnterDecision(20, decisionCanBacktrack[20]);
				int LA20_0 = input.LA(1);

				if ((LA20_0==IDENT))
				{
					int LA20_2 = input.LA(2);

					if ((LA20_2==IDENT||(LA20_2>=63 && LA20_2<=64)))
					{
						alt20=1;
					}


				}


				} finally { DebugExitDecision(20); }
				switch (alt20)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:147:8: type_decl ';'
					{
					DebugLocation(147, 8);
					PushFollow(Follow._type_decl_in_vars1561);
					type_decl103=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl103.Tree);
					DebugLocation(147, 21);
					char_literal104=(IToken)Match(input,62,Follow._62_in_vars1563); if (state.failed) return retval;

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
		DebugLocation(148, 0);
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
	// MathLang.g:150:1: param : term ;
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
		DebugLocation(150, 0);
		try
		{
			// MathLang.g:150:6: ( term )
			DebugEnterAlt(1);
			// MathLang.g:150:8: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(150, 8);
			PushFollow(Follow._term_in_param1574);
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
		DebugLocation(151, 0);
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
	// MathLang.g:153:1: params_ : ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) ;
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
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleSubtreeStream stream_param=new RewriteRuleSubtreeStream(adaptor,"rule param");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(153, 0);
		try
		{
			// MathLang.g:153:8: ( ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) )
			DebugEnterAlt(1);
			// MathLang.g:154:1: ( param ( ',' param )* )?
			{
			DebugLocation(154, 1);
			// MathLang.g:154:1: ( param ( ',' param )* )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if (((LA22_0>=TRUE && LA22_0<=FALSE)||(LA22_0>=NUMBER && LA22_0<=IDENT)||LA22_0==58))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:154:2: param ( ',' param )*
				{
				DebugLocation(154, 2);
				PushFollow(Follow._param_in_params_1583);
				param106=param();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_param.Add(param106.Tree);
				DebugLocation(154, 7);
				// MathLang.g:154:7: ( ',' param )*
				try { DebugEnterSubRule(21);
				while (true)
				{
					int alt21=2;
					try { DebugEnterDecision(21, decisionCanBacktrack[21]);
					int LA21_0 = input.LA(1);

					if ((LA21_0==63))
					{
						alt21=1;
					}


					} finally { DebugExitDecision(21); }
					switch ( alt21 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:154:8: ',' param
						{
						DebugLocation(154, 8);
						char_literal107=(IToken)Match(input,63,Follow._63_in_params_1585); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_63.Add(char_literal107);

						DebugLocation(154, 12);
						PushFollow(Follow._param_in_params_1587);
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
			// 154:22: -> ^( PARAMS ( param )* )
			{
				DebugLocation(154, 25);
				// MathLang.g:154:25: ^( PARAMS ( param )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(154, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(154, 34);
				// MathLang.g:154:34: ( param )*
				while ( stream_param.HasNext )
				{
					DebugLocation(154, 34);
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
		DebugLocation(155, 0);
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
	// MathLang.g:157:1: param_var : VAR ( type_decl )+ ;
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
		DebugLocation(157, 0);
		try
		{
			// MathLang.g:157:10: ( VAR ( type_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:157:12: VAR ( type_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(157, 15);
			VAR109=(IToken)Match(input,VAR,Follow._VAR_in_param_var1608); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR109_tree = (object)adaptor.Create(VAR109);
			root_0 = (object)adaptor.BecomeRoot(VAR109_tree, root_0);
			}
			DebugLocation(157, 17);
			// MathLang.g:157:17: ( type_decl )+
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
					DebugLocation(157, 17);
					PushFollow(Follow._type_decl_in_param_var1611);
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
		DebugLocation(158, 0);
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
	// MathLang.g:160:1: func_sign : ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) ;
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
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_64=new RewriteRuleITokenStream(adaptor,"token 64");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_FUNC=new RewriteRuleITokenStream(adaptor,"token FUNC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "func_sign");
		DebugLocation(160, 0);
		try
		{
			// MathLang.g:160:10: ( ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:161:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			{
			DebugLocation(161, 1);
			// MathLang.g:161:1: ( FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';' )
			DebugEnterAlt(1);
			// MathLang.g:161:2: FUNC IDENT '(' ( type_decl ( ';' type_decl )* )* ')' ':' type ';'
			{
			DebugLocation(161, 2);
			FUNC111=(IToken)Match(input,FUNC,Follow._FUNC_in_func_sign1621); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC.Add(FUNC111);

			DebugLocation(161, 7);
			IDENT112=(IToken)Match(input,IDENT,Follow._IDENT_in_func_sign1623); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT112);

			DebugLocation(161, 13);
			char_literal113=(IToken)Match(input,58,Follow._58_in_func_sign1625); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal113);

			DebugLocation(161, 16);
			// MathLang.g:161:16: ( type_decl ( ';' type_decl )* )*
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
					// MathLang.g:161:18: type_decl ( ';' type_decl )*
					{
					DebugLocation(161, 18);
					PushFollow(Follow._type_decl_in_func_sign1628);
					type_decl114=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl114.Tree);
					DebugLocation(161, 28);
					// MathLang.g:161:28: ( ';' type_decl )*
					try { DebugEnterSubRule(24);
					while (true)
					{
						int alt24=2;
						try { DebugEnterDecision(24, decisionCanBacktrack[24]);
						int LA24_0 = input.LA(1);

						if ((LA24_0==62))
						{
							alt24=1;
						}


						} finally { DebugExitDecision(24); }
						switch ( alt24 )
						{
						case 1:
							DebugEnterAlt(1);
							// MathLang.g:161:29: ';' type_decl
							{
							DebugLocation(161, 29);
							char_literal115=(IToken)Match(input,62,Follow._62_in_func_sign1631); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_62.Add(char_literal115);

							DebugLocation(161, 33);
							PushFollow(Follow._type_decl_in_func_sign1633);
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

			DebugLocation(161, 46);
			char_literal117=(IToken)Match(input,59,Follow._59_in_func_sign1638); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal117);

			DebugLocation(161, 50);
			char_literal118=(IToken)Match(input,64,Follow._64_in_func_sign1640); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_64.Add(char_literal118);

			DebugLocation(161, 54);
			PushFollow(Follow._type_in_func_sign1642);
			type119=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type119.Tree);
			DebugLocation(161, 59);
			char_literal120=(IToken)Match(input,62,Follow._62_in_func_sign1644); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal120);


			}



			{
			// AST REWRITE
			// elements: IDENT, type_decl, type, FUNC
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 161:63: -> ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
			{
				DebugLocation(161, 66);
				// MathLang.g:161:66: ^( FUNC type IDENT ^( PARAMS ( type_decl )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(161, 68);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

				DebugLocation(161, 73);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(161, 78);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(161, 84);
				// MathLang.g:161:84: ^( PARAMS ( type_decl )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(161, 86);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(161, 93);
				// MathLang.g:161:93: ( type_decl )*
				while ( stream_type_decl.HasNext )
				{
					DebugLocation(161, 93);
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
		DebugLocation(162, 0);
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
	// MathLang.g:164:1: proc_sign : ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) ) ;
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
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_PROC=new RewriteRuleITokenStream(adaptor,"token PROC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_param_var=new RewriteRuleSubtreeStream(adaptor,"rule param_var");
		try { DebugEnterRule(GrammarFileName, "proc_sign");
		DebugLocation(164, 0);
		try
		{
			// MathLang.g:164:10: ( ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:165:1: ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' )
			{
			DebugLocation(165, 1);
			// MathLang.g:165:1: ( PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:165:2: PROC IDENT '(' ( type_decl ( ';' type_decl )* ';' param_var )* ')' ';'
			{
			DebugLocation(165, 2);
			PROC121=(IToken)Match(input,PROC,Follow._PROC_in_proc_sign1670); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC.Add(PROC121);

			DebugLocation(165, 7);
			IDENT122=(IToken)Match(input,IDENT,Follow._IDENT_in_proc_sign1672); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT122);

			DebugLocation(165, 13);
			char_literal123=(IToken)Match(input,58,Follow._58_in_proc_sign1674); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal123);

			DebugLocation(165, 16);
			// MathLang.g:165:16: ( type_decl ( ';' type_decl )* ';' param_var )*
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
					// MathLang.g:165:18: type_decl ( ';' type_decl )* ';' param_var
					{
					DebugLocation(165, 18);
					PushFollow(Follow._type_decl_in_proc_sign1677);
					type_decl124=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl124.Tree);
					DebugLocation(165, 28);
					// MathLang.g:165:28: ( ';' type_decl )*
					try { DebugEnterSubRule(26);
					while (true)
					{
						int alt26=2;
						try { DebugEnterDecision(26, decisionCanBacktrack[26]);
						int LA26_0 = input.LA(1);

						if ((LA26_0==62))
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
							// MathLang.g:165:29: ';' type_decl
							{
							DebugLocation(165, 29);
							char_literal125=(IToken)Match(input,62,Follow._62_in_proc_sign1680); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_62.Add(char_literal125);

							DebugLocation(165, 33);
							PushFollow(Follow._type_decl_in_proc_sign1682);
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

					DebugLocation(165, 45);
					char_literal127=(IToken)Match(input,62,Follow._62_in_proc_sign1686); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_62.Add(char_literal127);

					DebugLocation(165, 49);
					PushFollow(Follow._param_var_in_proc_sign1688);
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

			DebugLocation(165, 60);
			char_literal129=(IToken)Match(input,59,Follow._59_in_proc_sign1691); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal129);

			DebugLocation(165, 64);
			char_literal130=(IToken)Match(input,62,Follow._62_in_proc_sign1693); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_62.Add(char_literal130);


			}



			{
			// AST REWRITE
			// elements: param_var, PROC, IDENT, type_decl
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 165:68: -> ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) )
			{
				DebugLocation(165, 71);
				// MathLang.g:165:71: ^( PROC IDENT ^( PARAMS ( ( type_decl )+ param_var )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(165, 73);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC.NextNode(), root_1);

				DebugLocation(165, 78);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(165, 84);
				// MathLang.g:165:84: ^( PARAMS ( ( type_decl )+ param_var )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(165, 86);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(165, 94);
				// MathLang.g:165:94: ( ( type_decl )+ param_var )*
				while ( stream_param_var.HasNext )
				{
					DebugLocation(165, 95);
					if ( !(stream_type_decl.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_type_decl.HasNext )
					{
						DebugLocation(165, 95);
						adaptor.AddChild(root_2, stream_type_decl.NextTree());

					}
					stream_type_decl.Reset();
					DebugLocation(165, 106);
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
		DebugLocation(166, 0);
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
	// MathLang.g:168:1: func_decl : func_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
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
		DebugLocation(168, 0);
		try
		{
			// MathLang.g:168:10: ( func_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:169:1: func_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(169, 10);
			PushFollow(Follow._func_sign_in_func_decl1722);
			func_sign131=func_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(func_sign131.Tree, root_0);
			DebugLocation(169, 15);
			char_literal132=(IToken)Match(input,62,Follow._62_in_func_decl1725); if (state.failed) return retval;
			DebugLocation(169, 17);
			// MathLang.g:169:17: ( const_ )*
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
					DebugLocation(169, 17);
					PushFollow(Follow._const__in_func_decl1728);
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

			DebugLocation(169, 25);
			// MathLang.g:169:25: ( vars )*
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
					DebugLocation(169, 25);
					PushFollow(Follow._vars_in_func_decl1731);
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

			DebugLocation(169, 31);
			PushFollow(Follow._groupExpr_in_func_decl1734);
			groupExpr135=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr135.Tree);
			DebugLocation(169, 44);
			char_literal136=(IToken)Match(input,62,Follow._62_in_func_decl1736); if (state.failed) return retval;

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
		DebugLocation(170, 0);
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
	// MathLang.g:172:1: proc_decl : proc_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
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
		DebugLocation(172, 0);
		try
		{
			// MathLang.g:172:10: ( proc_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:173:1: proc_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(173, 10);
			PushFollow(Follow._proc_sign_in_proc_decl1745);
			proc_sign137=proc_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(proc_sign137.Tree, root_0);
			DebugLocation(173, 15);
			char_literal138=(IToken)Match(input,62,Follow._62_in_proc_decl1748); if (state.failed) return retval;
			DebugLocation(173, 17);
			// MathLang.g:173:17: ( const_ )*
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
					DebugLocation(173, 17);
					PushFollow(Follow._const__in_proc_decl1751);
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

			DebugLocation(173, 25);
			// MathLang.g:173:25: ( vars )*
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
					DebugLocation(173, 25);
					PushFollow(Follow._vars_in_proc_decl1754);
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

			DebugLocation(173, 31);
			PushFollow(Follow._groupExpr_in_proc_decl1757);
			groupExpr141=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr141.Tree);
			DebugLocation(173, 44);
			char_literal142=(IToken)Match(input,62,Follow._62_in_proc_decl1759); if (state.failed) return retval;

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
		DebugLocation(174, 0);
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
	// MathLang.g:176:1: call : IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) ;
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
		RewriteRuleITokenStream stream_58=new RewriteRuleITokenStream(adaptor,"token 58");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "call");
		DebugLocation(176, 0);
		try
		{
			// MathLang.g:176:5: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) )
			DebugEnterAlt(1);
			// MathLang.g:177:1: IDENT '(' params_ ')'
			{
			DebugLocation(177, 1);
			IDENT143=(IToken)Match(input,IDENT,Follow._IDENT_in_call1768); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT143);

			DebugLocation(177, 7);
			char_literal144=(IToken)Match(input,58,Follow._58_in_call1770); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_58.Add(char_literal144);

			DebugLocation(177, 11);
			PushFollow(Follow._params__in_call1772);
			params_145=params_();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_params_.Add(params_145.Tree);
			DebugLocation(177, 19);
			char_literal146=(IToken)Match(input,59,Follow._59_in_call1774); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_59.Add(char_literal146);



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
			// 177:23: -> ^( CALL IDENT params_ )
			{
				DebugLocation(177, 26);
				// MathLang.g:177:26: ^( CALL IDENT params_ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(177, 28);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

				DebugLocation(177, 33);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(177, 39);
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
		DebugLocation(178, 0);
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
	// MathLang.g:180:1: exprList : ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) ;
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
		DebugLocation(180, 0);
		try
		{
			// MathLang.g:180:9: ( ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:181:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(181, 2);
			// MathLang.g:181:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			int alt34=2;
			try { DebugEnterSubRule(34);
			try { DebugEnterDecision(34, decisionCanBacktrack[34]);
			int LA34_0 = input.LA(1);

			if ((LA34_0==IDENT))
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
				// MathLang.g:181:4: simpleExpr ( ';' )+
				{
				DebugLocation(181, 4);
				PushFollow(Follow._simpleExpr_in_exprList1796);
				simpleExpr147=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr147.Tree);
				DebugLocation(181, 15);
				// MathLang.g:181:15: ( ';' )+
				int cnt32=0;
				try { DebugEnterSubRule(32);
				while (true)
				{
					int alt32=2;
					try { DebugEnterDecision(32, decisionCanBacktrack[32]);
					int LA32_0 = input.LA(1);

					if ((LA32_0==62))
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
						// MathLang.g:181:16: ';'
						{
						DebugLocation(181, 19);
						char_literal148=(IToken)Match(input,62,Follow._62_in_exprList1799); if (state.failed) return retval;

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
				// MathLang.g:182:3: groupExpr ( ';' )*
				{
				DebugLocation(182, 3);
				PushFollow(Follow._groupExpr_in_exprList1807);
				groupExpr149=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr149.Tree);
				DebugLocation(182, 13);
				// MathLang.g:182:13: ( ';' )*
				try { DebugEnterSubRule(33);
				while (true)
				{
					int alt33=2;
					try { DebugEnterDecision(33, decisionCanBacktrack[33]);
					int LA33_0 = input.LA(1);

					if ((LA33_0==62))
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
						// MathLang.g:182:14: ';'
						{
						DebugLocation(182, 17);
						char_literal150=(IToken)Match(input,62,Follow._62_in_exprList1810); if (state.failed) return retval;

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
		DebugLocation(184, 0);
		} finally { DebugExitRule(GrammarFileName, "exprList"); }
		return retval;

	}
	// $ANTLR end "exprList"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:186:1: program : ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* ( exprList )* '.' ) );
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 27);
		TraceIn("program", 27);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal159=null;
		MathLangParser.func_decl_return func_decl151 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl152 = default(MathLangParser.proc_decl_return);
		MathLangParser.const__return const_153 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars154 = default(MathLangParser.vars_return);
		MathLangParser.func_decl_return func_decl155 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl156 = default(MathLangParser.proc_decl_return);
		MathLangParser.vars_return vars157 = default(MathLangParser.vars_return);
		MathLangParser.exprList_return exprList158 = default(MathLangParser.exprList_return);

		object char_literal159_tree=null;

		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(186, 0);
		try
		{
			// MathLang.g:186:8: ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* ( exprList )* '.' ) )
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
				// MathLang.g:186:10: ( ( func_decl )* ( proc_decl )* )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(186, 10);
				// MathLang.g:186:10: ( ( func_decl )* ( proc_decl )* )
				DebugEnterAlt(1);
				// MathLang.g:186:12: ( func_decl )* ( proc_decl )*
				{
				DebugLocation(186, 12);
				// MathLang.g:186:12: ( func_decl )*
				try { DebugEnterSubRule(35);
				while (true)
				{
					int alt35=2;
					try { DebugEnterDecision(35, decisionCanBacktrack[35]);
					int LA35_0 = input.LA(1);

					if ((LA35_0==FUNC))
					{
						alt35=1;
					}


					} finally { DebugExitDecision(35); }
					switch ( alt35 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: func_decl
						{
						DebugLocation(186, 12);
						PushFollow(Follow._func_decl_in_program1825);
						func_decl151=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl151.Tree);

						}
						break;

					default:
						goto loop35;
					}
				}

				loop35:
					;

				} finally { DebugExitSubRule(35); }

				DebugLocation(186, 23);
				// MathLang.g:186:23: ( proc_decl )*
				try { DebugEnterSubRule(36);
				while (true)
				{
					int alt36=2;
					try { DebugEnterDecision(36, decisionCanBacktrack[36]);
					int LA36_0 = input.LA(1);

					if ((LA36_0==PROC))
					{
						alt36=1;
					}


					} finally { DebugExitDecision(36); }
					switch ( alt36 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: proc_decl
						{
						DebugLocation(186, 23);
						PushFollow(Follow._proc_decl_in_program1828);
						proc_decl152=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl152.Tree);

						}
						break;

					default:
						goto loop36;
					}
				}

				loop36:
					;

				} finally { DebugExitSubRule(36); }


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:186:35: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* ( exprList )* '.' )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(186, 35);
				// MathLang.g:186:35: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* ( exprList )* '.' )
				DebugEnterAlt(1);
				// MathLang.g:186:36: ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* ( exprList )* '.'
				{
				DebugLocation(186, 36);
				// MathLang.g:186:36: ( const_ )*
				try { DebugEnterSubRule(37);
				while (true)
				{
					int alt37=2;
					try { DebugEnterDecision(37, decisionCanBacktrack[37]);
					int LA37_0 = input.LA(1);

					if ((LA37_0==CONST_))
					{
						alt37=1;
					}


					} finally { DebugExitDecision(37); }
					switch ( alt37 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: const_
						{
						DebugLocation(186, 36);
						PushFollow(Follow._const__in_program1833);
						const_153=const_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_153.Tree);

						}
						break;

					default:
						goto loop37;
					}
				}

				loop37:
					;

				} finally { DebugExitSubRule(37); }

				DebugLocation(186, 44);
				// MathLang.g:186:44: ( vars )+
				int cnt38=0;
				try { DebugEnterSubRule(38);
				while (true)
				{
					int alt38=2;
					try { DebugEnterDecision(38, decisionCanBacktrack[38]);
					try
					{
						alt38 = dfa38.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(38); }
					switch (alt38)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(186, 44);
						PushFollow(Follow._vars_in_program1836);
						vars154=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars154.Tree);

						}
						break;

					default:
						if (cnt38 >= 1)
							goto loop38;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee38 = new EarlyExitException( 38, input );
						DebugRecognitionException(eee38);
						throw eee38;
					}
					cnt38++;
				}
				loop38:
					;

				} finally { DebugExitSubRule(38); }

				DebugLocation(186, 50);
				// MathLang.g:186:50: ( func_decl | proc_decl )*
				try { DebugEnterSubRule(39);
				while (true)
				{
					int alt39=3;
					try { DebugEnterDecision(39, decisionCanBacktrack[39]);
					try
					{
						alt39 = dfa39.Predict(input);
					}
					catch (NoViableAltException nvae)
					{
						DebugRecognitionException(nvae);
						throw;
					}
					} finally { DebugExitDecision(39); }
					switch ( alt39 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:186:51: func_decl
						{
						DebugLocation(186, 51);
						PushFollow(Follow._func_decl_in_program1840);
						func_decl155=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl155.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:186:61: proc_decl
						{
						DebugLocation(186, 61);
						PushFollow(Follow._proc_decl_in_program1842);
						proc_decl156=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl156.Tree);

						}
						break;

					default:
						goto loop39;
					}
				}

				loop39:
					;

				} finally { DebugExitSubRule(39); }

				DebugLocation(186, 73);
				// MathLang.g:186:73: ( vars )*
				try { DebugEnterSubRule(40);
				while (true)
				{
					int alt40=2;
					try { DebugEnterDecision(40, decisionCanBacktrack[40]);
					int LA40_0 = input.LA(1);

					if ((LA40_0==VAR))
					{
						alt40=1;
					}


					} finally { DebugExitDecision(40); }
					switch ( alt40 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: vars
						{
						DebugLocation(186, 73);
						PushFollow(Follow._vars_in_program1846);
						vars157=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars157.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }

				DebugLocation(186, 80);
				// MathLang.g:186:80: ( exprList )*
				try { DebugEnterSubRule(41);
				while (true)
				{
					int alt41=2;
					try { DebugEnterDecision(41, decisionCanBacktrack[41]);
					int LA41_0 = input.LA(1);

					if ((LA41_0==IF||LA41_0==FOR||(LA41_0>=WHILE && LA41_0<=REPEAT)||LA41_0==BEGIN||(LA41_0>=FUNC && LA41_0<=PROC)||LA41_0==IDENT))
					{
						alt41=1;
					}


					} finally { DebugExitDecision(41); }
					switch ( alt41 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:0:0: exprList
						{
						DebugLocation(186, 80);
						PushFollow(Follow._exprList_in_program1850);
						exprList158=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList158.Tree);

						}
						break;

					default:
						goto loop41;
					}
				}

				loop41:
					;

				} finally { DebugExitSubRule(41); }

				DebugLocation(186, 93);
				char_literal159=(IToken)Match(input,65,Follow._65_in_program1853); if (state.failed) return retval;

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
		DebugLocation(187, 0);
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
	// MathLang.g:189:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 28);
		TraceIn("result", 28);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF161=null;
		MathLangParser.program_return program160 = default(MathLangParser.program_return);

		object EOF161_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(189, 41);
		try
		{
			// MathLang.g:189:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// MathLang.g:189:9: program EOF
			{
			DebugLocation(189, 9);
			PushFollow(Follow._program_in_result1863);
			program160=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_program.Add(program160.Tree);
			DebugLocation(189, 17);
			EOF161=(IToken)Match(input,EOF,Follow._EOF_in_result1865); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF161);



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
			// 189:21: -> ^( PROGRAM program )
			{
				DebugLocation(189, 24);
				// MathLang.g:189:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(189, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(189, 34);
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
		DebugLocation(189, 41);
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
	// MathLang.g:191:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 29);
		TraceIn("execute", 29);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result162 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(191, 0);
		try
		{
			// MathLang.g:191:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:192:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(192, 3);
			PushFollow(Follow._result_in_execute1884);
			result162=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result162.Tree);

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
		DebugLocation(193, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred26_MathLang_fragment();
	partial void Leave_synpred26_MathLang_fragment();

	// $ANTLR start synpred26_MathLang
	public void synpred26_MathLang_fragment()
	{
		Enter_synpred26_MathLang_fragment();
		EnterRule("synpred26_MathLang_fragment", 55);
		TraceIn("synpred26_MathLang_fragment", 55);
		try
		{
			// MathLang.g:124:38: ( ELSIF term THEN exprList )
			DebugEnterAlt(1);
			// MathLang.g:124:38: ELSIF term THEN exprList
			{
			DebugLocation(124, 38);
			Match(input,ELSIF,Follow._ELSIF_in_synpred26_MathLang1338); if (state.failed) return;
			DebugLocation(124, 44);
			PushFollow(Follow._term_in_synpred26_MathLang1340);
			term();
			PopFollow();
			if (state.failed) return;
			DebugLocation(124, 49);
			Match(input,THEN,Follow._THEN_in_synpred26_MathLang1342); if (state.failed) return;
			DebugLocation(124, 54);
			PushFollow(Follow._exprList_in_synpred26_MathLang1344);
			exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred26_MathLang_fragment", 55);
			LeaveRule("synpred26_MathLang_fragment", 55);
			Leave_synpred26_MathLang_fragment();
		}
	}
	// $ANTLR end synpred26_MathLang

	partial void Enter_synpred27_MathLang_fragment();
	partial void Leave_synpred27_MathLang_fragment();

	// $ANTLR start synpred27_MathLang
	public void synpred27_MathLang_fragment()
	{
		Enter_synpred27_MathLang_fragment();
		EnterRule("synpred27_MathLang_fragment", 56);
		TraceIn("synpred27_MathLang_fragment", 56);
		try
		{
			// MathLang.g:124:66: ( ELSE exprList )
			DebugEnterAlt(1);
			// MathLang.g:124:66: ELSE exprList
			{
			DebugLocation(124, 66);
			Match(input,ELSE,Follow._ELSE_in_synpred27_MathLang1349); if (state.failed) return;
			DebugLocation(124, 71);
			PushFollow(Follow._exprList_in_synpred27_MathLang1351);
			exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred27_MathLang_fragment", 56);
			LeaveRule("synpred27_MathLang_fragment", 56);
			Leave_synpred27_MathLang_fragment();
		}
	}
	// $ANTLR end synpred27_MathLang

	partial void Enter_synpred47_MathLang_fragment();
	partial void Leave_synpred47_MathLang_fragment();

	// $ANTLR start synpred47_MathLang
	public void synpred47_MathLang_fragment()
	{
		Enter_synpred47_MathLang_fragment();
		EnterRule("synpred47_MathLang_fragment", 76);
		TraceIn("synpred47_MathLang_fragment", 76);
		try
		{
			// MathLang.g:157:17: ( type_decl )
			DebugEnterAlt(1);
			// MathLang.g:157:17: type_decl
			{
			DebugLocation(157, 17);
			PushFollow(Follow._type_decl_in_synpred47_MathLang1611);
			type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_MathLang_fragment", 76);
			LeaveRule("synpred47_MathLang_fragment", 76);
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
		EnterRule("synpred56_MathLang_fragment", 85);
		TraceIn("synpred56_MathLang_fragment", 85);
		try
		{
			// MathLang.g:181:16: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:181:16: ';'
			{
			DebugLocation(181, 16);
			Match(input,62,Follow._62_in_synpred56_MathLang1799); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred56_MathLang_fragment", 85);
			LeaveRule("synpred56_MathLang_fragment", 85);
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
		EnterRule("synpred58_MathLang_fragment", 87);
		TraceIn("synpred58_MathLang_fragment", 87);
		try
		{
			// MathLang.g:182:14: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:182:14: ';'
			{
			DebugLocation(182, 14);
			Match(input,62,Follow._62_in_synpred58_MathLang1810); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred58_MathLang_fragment", 87);
			LeaveRule("synpred58_MathLang_fragment", 87);
			Leave_synpred58_MathLang_fragment();
		}
	}
	// $ANTLR end synpred58_MathLang

	partial void Enter_synpred63_MathLang_fragment();
	partial void Leave_synpred63_MathLang_fragment();

	// $ANTLR start synpred63_MathLang
	public void synpred63_MathLang_fragment()
	{
		Enter_synpred63_MathLang_fragment();
		EnterRule("synpred63_MathLang_fragment", 92);
		TraceIn("synpred63_MathLang_fragment", 92);
		try
		{
			// MathLang.g:186:44: ( vars )
			DebugEnterAlt(1);
			// MathLang.g:186:44: vars
			{
			DebugLocation(186, 44);
			PushFollow(Follow._vars_in_synpred63_MathLang1836);
			vars();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred63_MathLang_fragment", 92);
			LeaveRule("synpred63_MathLang_fragment", 92);
			Leave_synpred63_MathLang_fragment();
		}
	}
	// $ANTLR end synpred63_MathLang

	partial void Enter_synpred64_MathLang_fragment();
	partial void Leave_synpred64_MathLang_fragment();

	// $ANTLR start synpred64_MathLang
	public void synpred64_MathLang_fragment()
	{
		Enter_synpred64_MathLang_fragment();
		EnterRule("synpred64_MathLang_fragment", 93);
		TraceIn("synpred64_MathLang_fragment", 93);
		try
		{
			// MathLang.g:186:51: ( func_decl )
			DebugEnterAlt(1);
			// MathLang.g:186:51: func_decl
			{
			DebugLocation(186, 51);
			PushFollow(Follow._func_decl_in_synpred64_MathLang1840);
			func_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred64_MathLang_fragment", 93);
			LeaveRule("synpred64_MathLang_fragment", 93);
			Leave_synpred64_MathLang_fragment();
		}
	}
	// $ANTLR end synpred64_MathLang

	partial void Enter_synpred65_MathLang_fragment();
	partial void Leave_synpred65_MathLang_fragment();

	// $ANTLR start synpred65_MathLang
	public void synpred65_MathLang_fragment()
	{
		Enter_synpred65_MathLang_fragment();
		EnterRule("synpred65_MathLang_fragment", 94);
		TraceIn("synpred65_MathLang_fragment", 94);
		try
		{
			// MathLang.g:186:61: ( proc_decl )
			DebugEnterAlt(1);
			// MathLang.g:186:61: proc_decl
			{
			DebugLocation(186, 61);
			PushFollow(Follow._proc_decl_in_synpred65_MathLang1842);
			proc_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred65_MathLang_fragment", 94);
			LeaveRule("synpred65_MathLang_fragment", 94);
			Leave_synpred65_MathLang_fragment();
		}
	}
	// $ANTLR end synpred65_MathLang
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
	DFA38 dfa38;
	DFA39 dfa39;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa19 = new DFA19( this );
		dfa38 = new DFA38( this, SpecialStateTransition38 );
		dfa39 = new DFA39( this, SpecialStateTransition39 );
	}

	private class DFA19 : DFA
	{
		private const string DFA19_eotS =
			"\x7\xFFFF";
		private const string DFA19_eofS =
			"\x7\xFFFF";
		private const string DFA19_minS =
			"\x3\x2E\x1\x1A\x1\xFFFF\x1\x2E\x1\xFFFF";
		private const string DFA19_maxS =
			"\x1\x2E\x1\x40\x1\x2E\x1\x25\x1\xFFFF\x1\x40\x1\xFFFF";
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

		public override string Description { get { return "141:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA38 : DFA
	{
		private const string DFA38_eotS =
			"\xC\xFFFF";
		private const string DFA38_eofS =
			"\xC\xFFFF";
		private const string DFA38_minS =
			"\x1\xD\x2\xFFFF\x1\x0\x8\xFFFF";
		private const string DFA38_maxS =
			"\x1\x41\x2\xFFFF\x1\x0\x8\xFFFF";
		private const string DFA38_acceptS =
			"\x1\xFFFF\x1\x2\x9\xFFFF\x1\x1";
		private const string DFA38_specialS =
			"\x3\xFFFF\x1\x0\x8\xFFFF}>";
		private static readonly string[] DFA38_transitionS =
			{
				"\x1\x1\x5\xFFFF\x1\x1\x3\xFFFF\x2\x1\x7\xFFFF\x1\x3\x1\x1\x6\xFFFF"+
				"\x2\x1\x4\xFFFF\x1\x1\x12\xFFFF\x1\x1",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
		private static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
		private static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
		private static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
		private static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
		private static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
		private static readonly short[][] DFA38_transition;

		static DFA38()
		{
			int numStates = DFA38_transitionS.Length;
			DFA38_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA38_transition[i] = DFA.UnpackEncodedString(DFA38_transitionS[i]);
			}
		}

		public DFA38( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 38;
			this.eot = DFA38_eot;
			this.eof = DFA38_eof;
			this.min = DFA38_min;
			this.max = DFA38_max;
			this.accept = DFA38_accept;
			this.special = DFA38_special;
			this.transition = DFA38_transition;
		}

		public override string Description { get { return "()+ loopback of 186:44: ( vars )+"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition38(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA38_3 = input.LA(1);


				int index38_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred63_MathLang_fragment)) ) {s = 11;}

				else if ( (true) ) {s = 1;}


				input.Seek(index38_3);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 38, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA39 : DFA
	{
		private const string DFA39_eotS =
			"\xD\xFFFF";
		private const string DFA39_eofS =
			"\xD\xFFFF";
		private const string DFA39_minS =
			"\x1\xD\x7\xFFFF\x2\x0\x3\xFFFF";
		private const string DFA39_maxS =
			"\x1\x41\x7\xFFFF\x2\x0\x3\xFFFF";
		private const string DFA39_acceptS =
			"\x1\xFFFF\x1\x3\x9\xFFFF\x1\x1\x1\x2";
		private const string DFA39_specialS =
			"\x8\xFFFF\x1\x0\x1\x1\x3\xFFFF}>";
		private static readonly string[] DFA39_transitionS =
			{
				"\x1\x1\x5\xFFFF\x1\x1\x3\xFFFF\x2\x1\x7\xFFFF\x2\x1\x6\xFFFF\x1\x8"+
				"\x1\x9\x4\xFFFF\x1\x1\x12\xFFFF\x1\x1",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				""
			};

		private static readonly short[] DFA39_eot = DFA.UnpackEncodedString(DFA39_eotS);
		private static readonly short[] DFA39_eof = DFA.UnpackEncodedString(DFA39_eofS);
		private static readonly char[] DFA39_min = DFA.UnpackEncodedStringToUnsignedChars(DFA39_minS);
		private static readonly char[] DFA39_max = DFA.UnpackEncodedStringToUnsignedChars(DFA39_maxS);
		private static readonly short[] DFA39_accept = DFA.UnpackEncodedString(DFA39_acceptS);
		private static readonly short[] DFA39_special = DFA.UnpackEncodedString(DFA39_specialS);
		private static readonly short[][] DFA39_transition;

		static DFA39()
		{
			int numStates = DFA39_transitionS.Length;
			DFA39_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA39_transition[i] = DFA.UnpackEncodedString(DFA39_transitionS[i]);
			}
		}

		public DFA39( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
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

		public override string Description { get { return "()* loopback of 186:50: ( func_decl | proc_decl )*"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition39(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA39_8 = input.LA(1);


				int index39_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred64_MathLang_fragment)) ) {s = 11;}

				else if ( (true) ) {s = 1;}


				input.Seek(index39_8);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA39_9 = input.LA(1);


				int index39_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_MathLang_fragment)) ) {s = 12;}

				else if ( (true) ) {s = 1;}


				input.Seek(index39_9);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 39, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _58_in_group1031 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_group1034 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_group1036 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_value_in_group1040 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1044 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1048 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1054 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_group1056 = new BitSet(new ulong[]{0x600000000000UL});
		public static readonly BitSet _index__in_group1058 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_group1059 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult1079 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _set_in_mult1083 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _group_in_mult1094 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _mult_in_add1106 = new BitSet(new ulong[]{0x1800000000002UL});
		public static readonly BitSet _set_in_add1111 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _mult_in_add1122 = new BitSet(new ulong[]{0x1800000000002UL});
		public static readonly BitSet _add_in_compare1134 = new BitSet(new ulong[]{0x3F0000000000002UL});
		public static readonly BitSet _set_in_compare1137 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _add_in_compare1164 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_div1172 = new BitSet(new ulong[]{0x60002UL});
		public static readonly BitSet _set_in_div1174 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _compare_in_div1183 = new BitSet(new ulong[]{0x60002UL});
		public static readonly BitSet _div_in_and_logic1190 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _AND_in_and_logic1193 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _div_in_and_logic1196 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _and_logic_in_or_logic1204 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or_logic1207 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _and_logic_in_or_logic1210 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _or_logic_in_term1218 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_logic_value0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_index_0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1267 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1269 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_simpleExpr1272 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1277 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_simpleExpr1279 = new BitSet(new ulong[]{0x600000000000UL});
		public static readonly BitSet _index__in_simpleExpr1281 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_simpleExpr1282 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1284 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _group_in_simpleExpr1286 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_in_simpleExpr1311 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_groupExpr1321 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_groupExpr1324 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1327 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_groupExpr1329 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _THEN_in_groupExpr1332 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1335 = new BitSet(new ulong[]{0x18002UL});
		public static readonly BitSet _ELSIF_in_groupExpr1338 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1340 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _THEN_in_groupExpr1342 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1344 = new BitSet(new ulong[]{0x18002UL});
		public static readonly BitSet _ELSE_in_groupExpr1349 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1351 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_groupExpr1357 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _IDENT_in_groupExpr1360 = new BitSet(new ulong[]{0x8000000000000UL});
		public static readonly BitSet _ASSIGN_in_groupExpr1362 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1365 = new BitSet(new ulong[]{0x300000UL});
		public static readonly BitSet _set_in_groupExpr1367 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1374 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _DO_in_groupExpr1376 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1379 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_groupExpr1383 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_groupExpr1386 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1388 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_groupExpr1389 = new BitSet(new ulong[]{0x400000UL});
		public static readonly BitSet _DO_in_groupExpr1392 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1395 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_groupExpr1399 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1402 = new BitSet(new ulong[]{0x430203882000UL});
		public static readonly BitSet _UNTIL_in_groupExpr1405 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_groupExpr1408 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1412 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_groupExpr1414 = new BitSet(new ulong[]{0x430601882000UL});
		public static readonly BitSet _END_in_groupExpr1417 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_groupExpr1430 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_groupExpr1433 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_const_decl1443 = new BitSet(new ulong[]{0x80000000000000UL});
		public static readonly BitSet _EQUALS_in_const_decl1446 = new BitSet(new ulong[]{0x600000000000UL});
		public static readonly BitSet _set_in_const_decl1449 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_const_decl1456 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _CONST__in_const_1467 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _const_decl_in_const_1470 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _IDENT_in_type_decl1483 = new BitSet(new ulong[]{0x8000400000000000UL,0x1UL});
		public static readonly BitSet _63_in_type_decl1486 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1488 = new BitSet(new ulong[]{0x8000400000000000UL,0x1UL});
		public static readonly BitSet _64_in_type_decl1494 = new BitSet(new ulong[]{0x3C000000UL});
		public static readonly BitSet _type_in_type_decl1496 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_type_decl1508 = new BitSet(new ulong[]{0x8000000000000000UL,0x1UL});
		public static readonly BitSet _63_in_type_decl1511 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1513 = new BitSet(new ulong[]{0x8000000000000000UL,0x1UL});
		public static readonly BitSet _64_in_type_decl1516 = new BitSet(new ulong[]{0x2000000000UL});
		public static readonly BitSet _ARRAY_in_type_decl1518 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_type_decl1520 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _group_in_type_decl1522 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_type_decl1524 = new BitSet(new ulong[]{0x0UL,0x2UL});
		public static readonly BitSet _65_in_type_decl1525 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _group_in_type_decl1526 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_type_decl1528 = new BitSet(new ulong[]{0x4000000000UL});
		public static readonly BitSet _OF_in_type_decl1530 = new BitSet(new ulong[]{0x3C000000UL});
		public static readonly BitSet _type_in_type_decl1532 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_vars1557 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _type_decl_in_vars1561 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_vars1563 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _term_in_param1574 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _param_in_params_1583 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _63_in_params_1585 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _param_in_params_1587 = new BitSet(new ulong[]{0x8000000000000002UL});
		public static readonly BitSet _VAR_in_param_var1608 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _type_decl_in_param_var1611 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _FUNC_in_func_sign1621 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _IDENT_in_func_sign1623 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_func_sign1625 = new BitSet(new ulong[]{0x800400000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1628 = new BitSet(new ulong[]{0x4800400000000000UL});
		public static readonly BitSet _62_in_func_sign1631 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1633 = new BitSet(new ulong[]{0x4800400000000000UL});
		public static readonly BitSet _59_in_func_sign1638 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_func_sign1640 = new BitSet(new ulong[]{0x3C000000UL});
		public static readonly BitSet _type_in_func_sign1642 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_func_sign1644 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_in_proc_sign1670 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _IDENT_in_proc_sign1672 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_proc_sign1674 = new BitSet(new ulong[]{0x800400000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1677 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_proc_sign1680 = new BitSet(new ulong[]{0x400000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1682 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_proc_sign1686 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _param_var_in_proc_sign1688 = new BitSet(new ulong[]{0x800400000000000UL});
		public static readonly BitSet _59_in_proc_sign1691 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_proc_sign1693 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_sign_in_func_decl1722 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_func_decl1725 = new BitSet(new ulong[]{0x438301882000UL});
		public static readonly BitSet _const__in_func_decl1728 = new BitSet(new ulong[]{0x438301882000UL});
		public static readonly BitSet _vars_in_func_decl1731 = new BitSet(new ulong[]{0x430301882000UL});
		public static readonly BitSet _groupExpr_in_func_decl1734 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_func_decl1736 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_sign_in_proc_decl1745 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_proc_decl1748 = new BitSet(new ulong[]{0x438301882000UL});
		public static readonly BitSet _const__in_proc_decl1751 = new BitSet(new ulong[]{0x438301882000UL});
		public static readonly BitSet _vars_in_proc_decl1754 = new BitSet(new ulong[]{0x430301882000UL});
		public static readonly BitSet _groupExpr_in_proc_decl1757 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_proc_decl1759 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1768 = new BitSet(new ulong[]{0x400000000000000UL});
		public static readonly BitSet _58_in_call1770 = new BitSet(new ulong[]{0xC00600000000030UL});
		public static readonly BitSet _params__in_call1772 = new BitSet(new ulong[]{0x800000000000000UL});
		public static readonly BitSet _59_in_call1774 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList1796 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_exprList1799 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _groupExpr_in_exprList1807 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _62_in_exprList1810 = new BitSet(new ulong[]{0x4000000000000002UL});
		public static readonly BitSet _func_decl_in_program1825 = new BitSet(new ulong[]{0x430201882002UL});
		public static readonly BitSet _proc_decl_in_program1828 = new BitSet(new ulong[]{0x430201882002UL});
		public static readonly BitSet _const__in_program1833 = new BitSet(new ulong[]{0x8100000000UL});
		public static readonly BitSet _vars_in_program1836 = new BitSet(new ulong[]{0x430301882000UL,0x2UL});
		public static readonly BitSet _func_decl_in_program1840 = new BitSet(new ulong[]{0x430301882000UL,0x2UL});
		public static readonly BitSet _proc_decl_in_program1842 = new BitSet(new ulong[]{0x430301882000UL,0x2UL});
		public static readonly BitSet _vars_in_program1846 = new BitSet(new ulong[]{0x430301882000UL,0x2UL});
		public static readonly BitSet _exprList_in_program1850 = new BitSet(new ulong[]{0x430201882000UL,0x2UL});
		public static readonly BitSet _65_in_program1853 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result1863 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1865 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1884 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSIF_in_synpred26_MathLang1338 = new BitSet(new ulong[]{0x400600000000030UL});
		public static readonly BitSet _term_in_synpred26_MathLang1340 = new BitSet(new ulong[]{0x4000UL});
		public static readonly BitSet _THEN_in_synpred26_MathLang1342 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_synpred26_MathLang1344 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred27_MathLang1349 = new BitSet(new ulong[]{0x430201882000UL});
		public static readonly BitSet _exprList_in_synpred27_MathLang1351 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_decl_in_synpred47_MathLang1611 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _62_in_synpred56_MathLang1799 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _62_in_synpred58_MathLang1810 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _vars_in_synpred63_MathLang1836 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_synpred64_MathLang1840 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_synpred65_MathLang1842 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
