// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2017-01-06 23:27:23

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "TRUE", "FALSE", "AND", "OR", "UNKNOWN", "SCOPEBLOCK", "BLOCK", "PROGRAM", "CONVERT", "INDEX", "IF", "THEN", "ELSE", "ELSIF", "DIV", "MOD", "FOR", "TO", "DOWNTO", "DO", "WHILE", "REPEAT", "UNTIL", "INT", "REAL", "CHAR", "BOOL", "CALL", "PARAMS", "VAR", "BEGIN", "END", "PRINT", "RINTSTR", "INPUT", "ARRAY", "OF", "CONST_", "FUNC", "PROC", "WS", "SL_COMMENT", "ML_COMMENT", "NUMBER", "IDENT", "ADD", "SUB", "MUL", "DIVIDE", "ASSIGN", "GE", "LE", "NEQUALS", "EQUALS", "GT", "LT", "'('", "')'", "'['", "']'", "'\\''", "'!'", "'?'", "'@'", "':'", "';'", "'#'", "'$'", "'%'", "'^'", "'&'", "'{'", "'}'", "'~'", "'.'", "','", "'_'"
	};
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
	// MathLang.g:95:1: group : ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) | '\\'' charValue '\\'' );
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
		IToken char_literal11=null;
		IToken char_literal13=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);
		MathLangParser.logic_value_return logic_value4 = default(MathLangParser.logic_value_return);
		MathLangParser.index__return index_9 = default(MathLangParser.index__return);
		MathLangParser.charValue_return charValue12 = default(MathLangParser.charValue_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object NUMBER5_tree=null;
		object IDENT6_tree=null;
		object IDENT7_tree=null;
		object char_literal8_tree=null;
		object char_literal10_tree=null;
		object char_literal11_tree=null;
		object char_literal13_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(95, 0);
		try
		{
			// MathLang.g:95:6: ( '(' term ')' | logic_value | NUMBER | IDENT | ( IDENT '[' index_ ']' ) -> ^( IDENT ^( INDEX index_ ) ) | '\\'' charValue '\\'' )
			int alt1=6;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 60:
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

				if ((LA1_4==62))
				{
					alt1=5;
				}
				else if ((LA1_4==EOF||(LA1_4>=AND && LA1_4<=OR)||(LA1_4>=IF && LA1_4<=TO)||(LA1_4>=DO && LA1_4<=UNTIL)||(LA1_4>=BEGIN && LA1_4<=PRINT)||(LA1_4>=FUNC && LA1_4<=PROC)||(LA1_4>=IDENT && LA1_4<=DIVIDE)||(LA1_4>=GE && LA1_4<=LT)||LA1_4==61||LA1_4==63||LA1_4==69||(LA1_4>=78 && LA1_4<=79)))
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
			case 64:
				{
				alt1=6;
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
				char_literal1=(IToken)Match(input,60,Follow._60_in_group1057); if (state.failed) return retval;
				DebugLocation(96, 8);
				PushFollow(Follow._term_in_group1060);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(96, 16);
				char_literal3=(IToken)Match(input,61,Follow._61_in_group1062); if (state.failed) return retval;

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
				char_literal8=(IToken)Match(input,62,Follow._62_in_group1082); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal8);

				DebugLocation(100, 14);
				PushFollow(Follow._index__in_group1084);
				index_9=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_9.Tree);
				DebugLocation(100, 20);
				char_literal10=(IToken)Match(input,63,Follow._63_in_group1085); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal10);


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
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:101:3: '\\'' charValue '\\''
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(101, 3);
				char_literal11=(IToken)Match(input,64,Follow._64_in_group1101); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal11_tree = (object)adaptor.Create(char_literal11);
				adaptor.AddChild(root_0, char_literal11_tree);
				}
				DebugLocation(101, 8);
				PushFollow(Follow._charValue_in_group1103);
				charValue12=charValue();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, charValue12.Tree);
				DebugLocation(101, 18);
				char_literal13=(IToken)Match(input,64,Follow._64_in_group1105); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal13_tree = (object)adaptor.Create(char_literal13);
				adaptor.AddChild(root_0, char_literal13_tree);
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

		IToken set15=null;
		MathLangParser.group_return group14 = default(MathLangParser.group_return);
		MathLangParser.group_return group16 = default(MathLangParser.group_return);

		object set15_tree=null;

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
			PushFollow(Follow._group_in_mult1113);
			group14=group();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group14.Tree);
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
					set15=(IToken)input.LT(1);
					set15=(IToken)input.LT(1);
					if ((input.LA(1)>=MUL && input.LA(1)<=DIVIDE))
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

					DebugLocation(104, 33);
					PushFollow(Follow._group_in_mult1128);
					group16=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group16.Tree);

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

		IToken set18=null;
		MathLangParser.mult_return mult17 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult19 = default(MathLangParser.mult_return);

		object set18_tree=null;

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
			PushFollow(Follow._mult_in_add1140);
			mult17=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult17.Tree);
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
					set18=(IToken)input.LT(1);
					set18=(IToken)input.LT(1);
					if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
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

					DebugLocation(105, 30);
					PushFollow(Follow._mult_in_add1156);
					mult19=mult();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult19.Tree);

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

		IToken set21=null;
		MathLangParser.add_return add20 = default(MathLangParser.add_return);
		MathLangParser.add_return add22 = default(MathLangParser.add_return);

		object set21_tree=null;

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
			PushFollow(Follow._add_in_compare1168);
			add20=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add20.Tree);
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
				set21=(IToken)input.LT(1);
				set21=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=LT))
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

				DebugLocation(106, 57);
				PushFollow(Follow._add_in_compare1198);
				add22=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add22.Tree);

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

		IToken set24=null;
		MathLangParser.compare_return compare23 = default(MathLangParser.compare_return);
		MathLangParser.compare_return compare25 = default(MathLangParser.compare_return);

		object set24_tree=null;

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
			PushFollow(Follow._compare_in_div1206);
			compare23=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare23.Tree);
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
					set24=(IToken)input.LT(1);
					set24=(IToken)input.LT(1);
					if ((input.LA(1)>=DIV && input.LA(1)<=MOD))
					{
						input.Consume();
						if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set24), root_0);
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
					PushFollow(Follow._compare_in_div1217);
					compare25=compare();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare25.Tree);

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

		IToken AND27=null;
		MathLangParser.div_return div26 = default(MathLangParser.div_return);
		MathLangParser.div_return div28 = default(MathLangParser.div_return);

		object AND27_tree=null;

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
			PushFollow(Follow._div_in_and_logic1224);
			div26=div();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div26.Tree);
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
					AND27=(IToken)Match(input,AND,Follow._AND_in_and_logic1227); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					AND27_tree = (object)adaptor.Create(AND27);
					root_0 = (object)adaptor.BecomeRoot(AND27_tree, root_0);
					}
					DebugLocation(108, 21);
					PushFollow(Follow._div_in_and_logic1230);
					div28=div();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, div28.Tree);

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

		IToken OR30=null;
		MathLangParser.and_logic_return and_logic29 = default(MathLangParser.and_logic_return);
		MathLangParser.and_logic_return and_logic31 = default(MathLangParser.and_logic_return);

		object OR30_tree=null;

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
			PushFollow(Follow._and_logic_in_or_logic1238);
			and_logic29=and_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic29.Tree);
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
					OR30=(IToken)Match(input,OR,Follow._OR_in_or_logic1241); if (state.failed) return retval;
					if ( state.backtracking == 0 ) {
					OR30_tree = (object)adaptor.Create(OR30);
					root_0 = (object)adaptor.BecomeRoot(OR30_tree, root_0);
					}
					DebugLocation(109, 26);
					PushFollow(Follow._and_logic_in_or_logic1244);
					and_logic31=and_logic();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic31.Tree);

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

		MathLangParser.or_logic_return or_logic32 = default(MathLangParser.or_logic_return);


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
			PushFollow(Follow._or_logic_in_term1252);
			or_logic32=or_logic();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic32.Tree);

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

		IToken set33=null;

		object set33_tree=null;

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
			set33=(IToken)input.LT(1);
			if ((input.LA(1)>=TRUE && input.LA(1)<=FALSE))
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

		IToken set34=null;

		object set34_tree=null;

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
			set34=(IToken)input.LT(1);
			if ((input.LA(1)>=INT && input.LA(1)<=BOOL))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set34));
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

		MathLangParser.term_return term35 = default(MathLangParser.term_return);


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
			PushFollow(Follow._term_in_index_1289);
			term35=term();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term35.Tree);

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

	public class simpleExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_simpleExpr();
	partial void Leave_simpleExpr();

	// $ANTLR start "simpleExpr"
	// MathLang.g:120:1: simpleExpr : ( IDENT ASSIGN term | PRINT term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call );
	[GrammarRule("simpleExpr")]
	private MathLangParser.simpleExpr_return simpleExpr()
	{
		Enter_simpleExpr();
		EnterRule("simpleExpr", 12);
		TraceIn("simpleExpr", 12);
		MathLangParser.simpleExpr_return retval = new MathLangParser.simpleExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IDENT36=null;
		IToken ASSIGN37=null;
		IToken PRINT39=null;
		IToken IDENT41=null;
		IToken char_literal42=null;
		IToken char_literal44=null;
		IToken ASSIGN45=null;
		MathLangParser.term_return term38 = default(MathLangParser.term_return);
		MathLangParser.term_return term40 = default(MathLangParser.term_return);
		MathLangParser.index__return index_43 = default(MathLangParser.index__return);
		MathLangParser.term_return term46 = default(MathLangParser.term_return);
		MathLangParser.call_return call47 = default(MathLangParser.call_return);

		object IDENT36_tree=null;
		object ASSIGN37_tree=null;
		object PRINT39_tree=null;
		object IDENT41_tree=null;
		object char_literal42_tree=null;
		object char_literal44_tree=null;
		object ASSIGN45_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_index_=new RewriteRuleSubtreeStream(adaptor,"rule index_");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		try { DebugEnterRule(GrammarFileName, "simpleExpr");
		DebugLocation(120, 0);
		try
		{
			// MathLang.g:120:11: ( IDENT ASSIGN term | PRINT term | ( IDENT '[' index_ ']' ASSIGN term ) -> ^( ASSIGN ^( IDENT ^( INDEX index_ ) ) term ) | call )
			int alt8=4;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			int LA8_0 = input.LA(1);

			if ((LA8_0==IDENT))
			{
				switch (input.LA(2))
				{
				case ASSIGN:
					{
					int LA8_3 = input.LA(3);

					if ((LA8_3==IDENT))
					{
						int LA8_6 = input.LA(4);

						if ((LA8_6==60))
						{
							alt8=4;
						}
						else if (((LA8_6>=AND && LA8_6<=OR)||(LA8_6>=DIV && LA8_6<=MOD)||(LA8_6>=ADD && LA8_6<=DIVIDE)||(LA8_6>=GE && LA8_6<=LT)||LA8_6==62||LA8_6==69))
						{
							alt8=1;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 8, 6, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else if (((LA8_3>=TRUE && LA8_3<=FALSE)||LA8_3==NUMBER||LA8_3==60||LA8_3==64))
					{
						alt8=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 8, 3, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case 62:
					{
					alt8=3;
					}
					break;
				case 60:
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
				// MathLang.g:121:2: IDENT ASSIGN term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(121, 2);
				IDENT36=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1298); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				IDENT36_tree = (object)adaptor.Create(IDENT36);
				adaptor.AddChild(root_0, IDENT36_tree);
				}
				DebugLocation(121, 14);
				ASSIGN37=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1300); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				ASSIGN37_tree = (object)adaptor.Create(ASSIGN37);
				root_0 = (object)adaptor.BecomeRoot(ASSIGN37_tree, root_0);
				}
				DebugLocation(121, 16);
				PushFollow(Follow._term_in_simpleExpr1303);
				term38=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term38.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:122:3: PRINT term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 8);
				PRINT39=(IToken)Match(input,PRINT,Follow._PRINT_in_simpleExpr1307); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				PRINT39_tree = (object)adaptor.Create(PRINT39);
				root_0 = (object)adaptor.BecomeRoot(PRINT39_tree, root_0);
				}
				DebugLocation(122, 10);
				PushFollow(Follow._term_in_simpleExpr1310);
				term40=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term40.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:123:2: ( IDENT '[' index_ ']' ASSIGN term )
				{
				DebugLocation(123, 2);
				// MathLang.g:123:2: ( IDENT '[' index_ ']' ASSIGN term )
				DebugEnterAlt(1);
				// MathLang.g:123:4: IDENT '[' index_ ']' ASSIGN term
				{
				DebugLocation(123, 4);
				IDENT41=(IToken)Match(input,IDENT,Follow._IDENT_in_simpleExpr1315); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT41);

				DebugLocation(123, 10);
				char_literal42=(IToken)Match(input,62,Follow._62_in_simpleExpr1317); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal42);

				DebugLocation(123, 14);
				PushFollow(Follow._index__in_simpleExpr1319);
				index_43=index_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_index_.Add(index_43.Tree);
				DebugLocation(123, 20);
				char_literal44=(IToken)Match(input,63,Follow._63_in_simpleExpr1320); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal44);

				DebugLocation(123, 24);
				ASSIGN45=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_simpleExpr1322); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN45);

				DebugLocation(123, 31);
				PushFollow(Follow._term_in_simpleExpr1324);
				term46=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(term46.Tree);

				}



				{
				// AST REWRITE
				// elements: index_, IDENT, ASSIGN, term
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
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:124:3: call
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 3);
				PushFollow(Follow._call_in_simpleExpr1349);
				call47=call();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call47.Tree);

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

	public class charValue_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_charValue();
	partial void Leave_charValue();

	// $ANTLR start "charValue"
	// MathLang.g:127:1: charValue : ( '+' | '-' | '*' | '/' | '!' | '?' | '@' | '<' | '>' | ':' | ';' | '#' | '$' | '%' | '^' | '&' | '(' | ')' | '{' | '}' | '[' | ']' | '~' | '.' | ',' | '_' | IDENT | NUMBER );
	[GrammarRule("charValue")]
	private MathLangParser.charValue_return charValue()
	{
		Enter_charValue();
		EnterRule("charValue", 13);
		TraceIn("charValue", 13);
		MathLangParser.charValue_return retval = new MathLangParser.charValue_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set48=null;

		object set48_tree=null;

		try { DebugEnterRule(GrammarFileName, "charValue");
		DebugLocation(127, 0);
		try
		{
			// MathLang.g:127:10: ( '+' | '-' | '*' | '/' | '!' | '?' | '@' | '<' | '>' | ':' | ';' | '#' | '$' | '%' | '^' | '&' | '(' | ')' | '{' | '}' | '[' | ']' | '~' | '.' | ',' | '_' | IDENT | NUMBER )
			DebugEnterAlt(1);
			// MathLang.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(127, 10);
			set48=(IToken)input.LT(1);
			if ((input.LA(1)>=NUMBER && input.LA(1)<=DIVIDE)||(input.LA(1)>=GT && input.LA(1)<=63)||(input.LA(1)>=65 && input.LA(1)<=80))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set48));
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
			TraceOut("charValue", 13);
			LeaveRule("charValue", 13);
			Leave_charValue();
		}
		DebugLocation(130, 0);
		} finally { DebugExitRule(GrammarFileName, "charValue"); }
		return retval;

	}
	// $ANTLR end "charValue"

	public class groupExpr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_groupExpr();
	partial void Leave_groupExpr();

	// $ANTLR start "groupExpr"
	// MathLang.g:133:1: groupExpr : ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl );
	[GrammarRule("groupExpr")]
	private MathLangParser.groupExpr_return groupExpr()
	{
		Enter_groupExpr();
		EnterRule("groupExpr", 14);
		TraceIn("groupExpr", 14);
		MathLangParser.groupExpr_return retval = new MathLangParser.groupExpr_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken IF49=null;
		IToken char_literal50=null;
		IToken char_literal51=null;
		IToken THEN52=null;
		IToken ELSIF53=null;
		IToken THEN54=null;
		IToken ELSE55=null;
		IToken FOR56=null;
		IToken IDENT57=null;
		IToken ASSIGN58=null;
		IToken TO59=null;
		IToken DO60=null;
		IToken WHILE62=null;
		IToken char_literal63=null;
		IToken char_literal65=null;
		IToken DO66=null;
		IToken REPEAT68=null;
		IToken UNTIL70=null;
		IToken BEGIN72=null;
		IToken END74=null;
		IToken char_literal75=null;
		MathLangParser.term_return t1 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst = default(MathLangParser.exprList_return);
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList61 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term64 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList67 = default(MathLangParser.exprList_return);
		MathLangParser.exprList_return exprList69 = default(MathLangParser.exprList_return);
		MathLangParser.term_return term71 = default(MathLangParser.term_return);
		MathLangParser.exprList_return exprList73 = default(MathLangParser.exprList_return);
		MathLangParser.func_decl_return func_decl76 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl77 = default(MathLangParser.proc_decl_return);

		object IF49_tree=null;
		object char_literal50_tree=null;
		object char_literal51_tree=null;
		object THEN52_tree=null;
		object ELSIF53_tree=null;
		object THEN54_tree=null;
		object ELSE55_tree=null;
		object FOR56_tree=null;
		object IDENT57_tree=null;
		object ASSIGN58_tree=null;
		object TO59_tree=null;
		object DO60_tree=null;
		object WHILE62_tree=null;
		object char_literal63_tree=null;
		object char_literal65_tree=null;
		object DO66_tree=null;
		object REPEAT68_tree=null;
		object UNTIL70_tree=null;
		object BEGIN72_tree=null;
		object END74_tree=null;
		object char_literal75_tree=null;
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
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_IF=new RewriteRuleITokenStream(adaptor,"token IF");
		RewriteRuleSubtreeStream stream_term=new RewriteRuleSubtreeStream(adaptor,"rule term");
		RewriteRuleSubtreeStream stream_exprList=new RewriteRuleSubtreeStream(adaptor,"rule exprList");
		try { DebugEnterRule(GrammarFileName, "groupExpr");
		DebugLocation(133, 0);
		try
		{
			// MathLang.g:133:10: ( ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? ) -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? ) | ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList ) -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList ) | WHILE '(' term ')' DO exprList | REPEAT ( exprList )+ UNTIL term | BEGIN ( exprList )+ END ';' -> ^( BLOCK ( exprList )+ ) | func_decl | proc_decl )
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
				// MathLang.g:134:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				{
				DebugLocation(134, 2);
				// MathLang.g:134:2: ( IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )? )
				DebugEnterAlt(1);
				// MathLang.g:134:4: IF '(' t1= term ')' THEN lst= exprList ( ELSIF t2= term THEN lst2= exprList )* ( ELSE lst3= exprList )?
				{
				DebugLocation(134, 4);
				IF49=(IToken)Match(input,IF,Follow._IF_in_groupExpr1428); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IF.Add(IF49);

				DebugLocation(134, 7);
				char_literal50=(IToken)Match(input,60,Follow._60_in_groupExpr1430); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal50);

				DebugLocation(134, 13);
				PushFollow(Follow._term_in_groupExpr1434);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(134, 19);
				char_literal51=(IToken)Match(input,61,Follow._61_in_groupExpr1436); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal51);

				DebugLocation(134, 23);
				THEN52=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1438); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_THEN.Add(THEN52);

				DebugLocation(134, 31);
				PushFollow(Follow._exprList_in_groupExpr1442);
				lst=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(lst.Tree);
				DebugLocation(134, 41);
				// MathLang.g:134:41: ( ELSIF t2= term THEN lst2= exprList )*
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if ((LA9_0==ELSIF))
					{
						int LA9_2 = input.LA(2);

						if ((EvaluatePredicate(synpred54_MathLang_fragment)))
						{
							alt9=1;
						}


					}


					} finally { DebugExitDecision(9); }
					switch ( alt9 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:134:42: ELSIF t2= term THEN lst2= exprList
						{
						DebugLocation(134, 42);
						ELSIF53=(IToken)Match(input,ELSIF,Follow._ELSIF_in_groupExpr1445); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_ELSIF.Add(ELSIF53);

						DebugLocation(134, 50);
						PushFollow(Follow._term_in_groupExpr1449);
						t2=term();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
						DebugLocation(134, 56);
						THEN54=(IToken)Match(input,THEN,Follow._THEN_in_groupExpr1451); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_THEN.Add(THEN54);

						DebugLocation(134, 65);
						PushFollow(Follow._exprList_in_groupExpr1455);
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

				DebugLocation(134, 77);
				// MathLang.g:134:77: ( ELSE lst3= exprList )?
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==ELSE))
				{
					int LA10_1 = input.LA(2);

					if ((EvaluatePredicate(synpred55_MathLang_fragment)))
					{
						alt10=1;
					}
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:134:78: ELSE lst3= exprList
					{
					DebugLocation(134, 78);
					ELSE55=(IToken)Match(input,ELSE,Follow._ELSE_in_groupExpr1460); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_ELSE.Add(ELSE55);

					DebugLocation(134, 87);
					PushFollow(Follow._exprList_in_groupExpr1464);
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
				// elements: ELSE, t1, lst2, IF, t2, lst3, ELSIF, lst
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
				// 134:99: -> ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
				{
					DebugLocation(134, 101);
					// MathLang.g:134:101: ^( IF $t1 $lst ( ^( ELSIF $t2 $lst2) )* ( ^( ELSE $lst3) )? )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(134, 103);
					root_1 = (object)adaptor.BecomeRoot(stream_IF.NextNode(), root_1);

					DebugLocation(134, 106);
					adaptor.AddChild(root_1, stream_t1.NextTree());
					DebugLocation(134, 110);
					adaptor.AddChild(root_1, stream_lst.NextTree());
					DebugLocation(134, 115);
					// MathLang.g:134:115: ( ^( ELSIF $t2 $lst2) )*
					while ( stream_lst2.HasNext||stream_t2.HasNext||stream_ELSIF.HasNext )
					{
						DebugLocation(134, 116);
						// MathLang.g:134:116: ^( ELSIF $t2 $lst2)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(134, 118);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSIF.NextNode(), root_2);

						DebugLocation(134, 124);
						adaptor.AddChild(root_2, stream_t2.NextTree());
						DebugLocation(134, 128);
						adaptor.AddChild(root_2, stream_lst2.NextTree());

						adaptor.AddChild(root_1, root_2);
						}

					}
					stream_lst2.Reset();
					stream_t2.Reset();
					stream_ELSIF.Reset();
					DebugLocation(134, 137);
					// MathLang.g:134:137: ( ^( ELSE $lst3) )?
					if ( stream_ELSE.HasNext||stream_lst3.HasNext )
					{
						DebugLocation(134, 138);
						// MathLang.g:134:138: ^( ELSE $lst3)
						{
						object root_2 = (object)adaptor.Nil();
						DebugLocation(134, 140);
						root_2 = (object)adaptor.BecomeRoot(stream_ELSE.NextNode(), root_2);

						DebugLocation(134, 145);
						adaptor.AddChild(root_2, stream_lst3.NextTree());

						adaptor.AddChild(root_1, root_2);
						}

					}
					stream_ELSE.Reset();
					stream_lst3.Reset();

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
				// MathLang.g:135:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				{
				DebugLocation(135, 2);
				// MathLang.g:135:2: ( FOR IDENT ASSIGN t1= term TO t2= term DO exprList )
				DebugEnterAlt(1);
				// MathLang.g:135:4: FOR IDENT ASSIGN t1= term TO t2= term DO exprList
				{
				DebugLocation(135, 4);
				FOR56=(IToken)Match(input,FOR,Follow._FOR_in_groupExpr1505); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_FOR.Add(FOR56);

				DebugLocation(135, 8);
				IDENT57=(IToken)Match(input,IDENT,Follow._IDENT_in_groupExpr1507); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT57);

				DebugLocation(135, 14);
				ASSIGN58=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_groupExpr1509); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN58);

				DebugLocation(135, 23);
				PushFollow(Follow._term_in_groupExpr1513);
				t1=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t1.Tree);
				DebugLocation(135, 29);
				TO59=(IToken)Match(input,TO,Follow._TO_in_groupExpr1515); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_TO.Add(TO59);

				DebugLocation(135, 34);
				PushFollow(Follow._term_in_groupExpr1519);
				t2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_term.Add(t2.Tree);
				DebugLocation(135, 40);
				DO60=(IToken)Match(input,DO,Follow._DO_in_groupExpr1521); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_DO.Add(DO60);

				DebugLocation(135, 43);
				PushFollow(Follow._exprList_in_groupExpr1523);
				exprList61=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_exprList.Add(exprList61.Tree);

				}



				{
				// AST REWRITE
				// elements: ASSIGN, IDENT, IDENT, t2, t1, exprList, FOR
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
				// 135:52: -> ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList )
				{
					DebugLocation(135, 54);
					// MathLang.g:135:54: ^( FOR ^( ASSIGN IDENT $t1) ^( LE IDENT $t2) exprList )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(135, 56);
					root_1 = (object)adaptor.BecomeRoot(stream_FOR.NextNode(), root_1);

					DebugLocation(135, 60);
					// MathLang.g:135:60: ^( ASSIGN IDENT $t1)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(135, 62);
					root_2 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_2);

					DebugLocation(135, 69);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(135, 75);
					adaptor.AddChild(root_2, stream_t1.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(135, 80);
					// MathLang.g:135:80: ^( LE IDENT $t2)
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(135, 82);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(LE, "LE"), root_2);

					DebugLocation(135, 85);
					adaptor.AddChild(root_2, stream_IDENT.NextNode());
					DebugLocation(135, 91);
					adaptor.AddChild(root_2, stream_t2.NextTree());

					adaptor.AddChild(root_1, root_2);
					}
					DebugLocation(135, 96);
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
				// MathLang.g:136:3: WHILE '(' term ')' DO exprList
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 8);
				WHILE62=(IToken)Match(input,WHILE,Follow._WHILE_in_groupExpr1552); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				WHILE62_tree = (object)adaptor.Create(WHILE62);
				root_0 = (object)adaptor.BecomeRoot(WHILE62_tree, root_0);
				}
				DebugLocation(136, 13);
				char_literal63=(IToken)Match(input,60,Follow._60_in_groupExpr1555); if (state.failed) return retval;
				DebugLocation(136, 14);
				PushFollow(Follow._term_in_groupExpr1557);
				term64=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term64.Tree);
				DebugLocation(136, 21);
				char_literal65=(IToken)Match(input,61,Follow._61_in_groupExpr1558); if (state.failed) return retval;
				DebugLocation(136, 25);
				DO66=(IToken)Match(input,DO,Follow._DO_in_groupExpr1561); if (state.failed) return retval;
				DebugLocation(136, 27);
				PushFollow(Follow._exprList_in_groupExpr1564);
				exprList67=exprList();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList67.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:137:3: REPEAT ( exprList )+ UNTIL term
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(137, 9);
				REPEAT68=(IToken)Match(input,REPEAT,Follow._REPEAT_in_groupExpr1568); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				REPEAT68_tree = (object)adaptor.Create(REPEAT68);
				root_0 = (object)adaptor.BecomeRoot(REPEAT68_tree, root_0);
				}
				DebugLocation(137, 11);
				// MathLang.g:137:11: ( exprList )+
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
						DebugLocation(137, 11);
						PushFollow(Follow._exprList_in_groupExpr1571);
						exprList69=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList69.Tree);

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

				DebugLocation(137, 26);
				UNTIL70=(IToken)Match(input,UNTIL,Follow._UNTIL_in_groupExpr1574); if (state.failed) return retval;
				DebugLocation(137, 28);
				PushFollow(Follow._term_in_groupExpr1577);
				term71=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term71.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:138:3: BEGIN ( exprList )+ END ';'
				{
				DebugLocation(138, 3);
				BEGIN72=(IToken)Match(input,BEGIN,Follow._BEGIN_in_groupExpr1581); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_BEGIN.Add(BEGIN72);

				DebugLocation(138, 9);
				// MathLang.g:138:9: ( exprList )+
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
						DebugLocation(138, 9);
						PushFollow(Follow._exprList_in_groupExpr1583);
						exprList73=exprList();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) stream_exprList.Add(exprList73.Tree);

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

				DebugLocation(138, 19);
				END74=(IToken)Match(input,END,Follow._END_in_groupExpr1586); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_END.Add(END74);

				DebugLocation(138, 23);
				char_literal75=(IToken)Match(input,69,Follow._69_in_groupExpr1588); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_69.Add(char_literal75);



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
				// 138:27: -> ^( BLOCK ( exprList )+ )
				{
					DebugLocation(138, 30);
					// MathLang.g:138:30: ^( BLOCK ( exprList )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(138, 32);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

					DebugLocation(138, 38);
					if ( !(stream_exprList.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_exprList.HasNext )
					{
						DebugLocation(138, 38);
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
				// MathLang.g:139:2: func_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(139, 2);
				PushFollow(Follow._func_decl_in_groupExpr1600);
				func_decl76=func_decl();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl76.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:140:2: proc_decl
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(140, 2);
				PushFollow(Follow._proc_decl_in_groupExpr1603);
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
			TraceOut("groupExpr", 14);
			LeaveRule("groupExpr", 14);
			Leave_groupExpr();
		}
		DebugLocation(141, 0);
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
	// MathLang.g:144:1: const_decl : IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ ;
	[GrammarRule("const_decl")]
	private MathLangParser.const_decl_return const_decl()
	{
		Enter_const_decl();
		EnterRule("const_decl", 15);
		TraceIn("const_decl", 15);
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
		DebugLocation(144, 0);
		try
		{
			// MathLang.g:144:11: ( IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:145:2: IDENT EQUALS ( IDENT | NUMBER ) ( ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(145, 7);
			IDENT78=(IToken)Match(input,IDENT,Follow._IDENT_in_const_decl1613); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IDENT78_tree = (object)adaptor.Create(IDENT78);
			root_0 = (object)adaptor.BecomeRoot(IDENT78_tree, root_0);
			}
			DebugLocation(145, 15);
			EQUALS79=(IToken)Match(input,EQUALS,Follow._EQUALS_in_const_decl1616); if (state.failed) return retval;
			DebugLocation(145, 17);
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

			DebugLocation(145, 32);
			// MathLang.g:145:32: ( ';' )+
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
					// MathLang.g:145:33: ';'
					{
					DebugLocation(145, 36);
					char_literal81=(IToken)Match(input,69,Follow._69_in_const_decl1626); if (state.failed) return retval;

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
		DebugLocation(146, 0);
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
	// MathLang.g:147:1: const_ : CONST_ ( const_decl )+ ;
	[GrammarRule("const_")]
	private MathLangParser.const__return const_()
	{
		Enter_const_();
		EnterRule("const_", 16);
		TraceIn("const_", 16);
		MathLangParser.const__return retval = new MathLangParser.const__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken CONST_82=null;
		MathLangParser.const_decl_return const_decl83 = default(MathLangParser.const_decl_return);

		object CONST_82_tree=null;

		try { DebugEnterRule(GrammarFileName, "const_");
		DebugLocation(147, 0);
		try
		{
			// MathLang.g:147:7: ( CONST_ ( const_decl )+ )
			DebugEnterAlt(1);
			// MathLang.g:148:1: CONST_ ( const_decl )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(148, 7);
			CONST_82=(IToken)Match(input,CONST_,Follow._CONST__in_const_1637); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONST_82_tree = (object)adaptor.Create(CONST_82);
			root_0 = (object)adaptor.BecomeRoot(CONST_82_tree, root_0);
			}
			DebugLocation(148, 9);
			// MathLang.g:148:9: ( const_decl )+
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
					DebugLocation(148, 9);
					PushFollow(Follow._const_decl_in_const_1640);
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
			TraceOut("const_", 16);
			LeaveRule("const_", 16);
			Leave_const_();
		}
		DebugLocation(149, 0);
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
	// MathLang.g:151:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );
	[GrammarRule("type_decl")]
	private MathLangParser.type_decl_return type_decl()
	{
		Enter_type_decl();
		EnterRule("type_decl", 17);
		TraceIn("type_decl", 17);
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
		RewriteRuleITokenStream stream_79=new RewriteRuleITokenStream(adaptor,"token 79");
		RewriteRuleITokenStream stream_78=new RewriteRuleITokenStream(adaptor,"token 78");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_OF=new RewriteRuleITokenStream(adaptor,"token OF");
		RewriteRuleITokenStream stream_62=new RewriteRuleITokenStream(adaptor,"token 62");
		RewriteRuleITokenStream stream_63=new RewriteRuleITokenStream(adaptor,"token 63");
		RewriteRuleITokenStream stream_ARRAY=new RewriteRuleITokenStream(adaptor,"token ARRAY");
		RewriteRuleSubtreeStream stream_group=new RewriteRuleSubtreeStream(adaptor,"rule group");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "type_decl");
		DebugLocation(151, 0);
		try
		{
			// MathLang.g:151:10: ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) )
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
				// MathLang.g:152:2: ( ( IDENT ( ',' IDENT )* )+ ) ':' type
				{
				DebugLocation(152, 2);
				// MathLang.g:152:2: ( ( IDENT ( ',' IDENT )* )+ )
				DebugEnterAlt(1);
				// MathLang.g:152:4: ( IDENT ( ',' IDENT )* )+
				{
				DebugLocation(152, 4);
				// MathLang.g:152:4: ( IDENT ( ',' IDENT )* )+
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
						// MathLang.g:152:5: IDENT ( ',' IDENT )*
						{
						DebugLocation(152, 5);
						IDENT84=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1653); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT84);

						DebugLocation(152, 11);
						// MathLang.g:152:11: ( ',' IDENT )*
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
								// MathLang.g:152:12: ',' IDENT
								{
								DebugLocation(152, 12);
								char_literal85=(IToken)Match(input,79,Follow._79_in_type_decl1656); if (state.failed) return retval; 
								if ( state.backtracking == 0 ) stream_79.Add(char_literal85);

								DebugLocation(152, 16);
								IDENT86=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1658); if (state.failed) return retval; 
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

				DebugLocation(152, 26);
				char_literal87=(IToken)Match(input,68,Follow._68_in_type_decl1664); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal87);

				DebugLocation(152, 30);
				PushFollow(Follow._type_in_type_decl1666);
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
				// 152:34: -> ^( type ( IDENT )+ )
				{
					DebugLocation(152, 37);
					// MathLang.g:152:37: ^( type ( IDENT )+ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(152, 39);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(152, 44);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(152, 44);
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
				// MathLang.g:153:3: IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type
				{
				DebugLocation(153, 3);
				IDENT89=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1678); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT89);

				DebugLocation(153, 9);
				// MathLang.g:153:9: ( ',' IDENT )*
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
						// MathLang.g:153:10: ',' IDENT
						{
						DebugLocation(153, 10);
						char_literal90=(IToken)Match(input,79,Follow._79_in_type_decl1681); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_79.Add(char_literal90);

						DebugLocation(153, 14);
						IDENT91=(IToken)Match(input,IDENT,Follow._IDENT_in_type_decl1683); if (state.failed) return retval; 
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

				DebugLocation(153, 21);
				char_literal92=(IToken)Match(input,68,Follow._68_in_type_decl1686); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_68.Add(char_literal92);

				DebugLocation(153, 25);
				ARRAY93=(IToken)Match(input,ARRAY,Follow._ARRAY_in_type_decl1688); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ARRAY.Add(ARRAY93);

				DebugLocation(153, 31);
				char_literal94=(IToken)Match(input,62,Follow._62_in_type_decl1690); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_62.Add(char_literal94);

				DebugLocation(153, 35);
				PushFollow(Follow._group_in_type_decl1692);
				group95=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group95.Tree);
				DebugLocation(153, 41);
				char_literal96=(IToken)Match(input,78,Follow._78_in_type_decl1694); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_78.Add(char_literal96);

				DebugLocation(153, 44);
				char_literal97=(IToken)Match(input,78,Follow._78_in_type_decl1695); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_78.Add(char_literal97);

				DebugLocation(153, 47);
				PushFollow(Follow._group_in_type_decl1696);
				group98=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_group.Add(group98.Tree);
				DebugLocation(153, 53);
				char_literal99=(IToken)Match(input,63,Follow._63_in_type_decl1698); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_63.Add(char_literal99);

				DebugLocation(153, 57);
				OF100=(IToken)Match(input,OF,Follow._OF_in_type_decl1700); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_OF.Add(OF100);

				DebugLocation(153, 60);
				PushFollow(Follow._type_in_type_decl1702);
				type101=type();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_type.Add(type101.Tree);


				{
				// AST REWRITE
				// elements: ARRAY, group, type, IDENT
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				if ( state.backtracking == 0 ) {
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 153:65: -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
				{
					DebugLocation(153, 68);
					// MathLang.g:153:68: ^( type ^( ARRAY ( IDENT )+ ( group )+ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(153, 70);
					root_1 = (object)adaptor.BecomeRoot(stream_type.NextNode(), root_1);

					DebugLocation(153, 75);
					// MathLang.g:153:75: ^( ARRAY ( IDENT )+ ( group )+ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(153, 77);
					root_2 = (object)adaptor.BecomeRoot(stream_ARRAY.NextNode(), root_2);

					DebugLocation(153, 83);
					if ( !(stream_IDENT.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_IDENT.HasNext )
					{
						DebugLocation(153, 83);
						adaptor.AddChild(root_2, stream_IDENT.NextNode());

					}
					stream_IDENT.Reset();
					DebugLocation(153, 90);
					if ( !(stream_group.HasNext) )
					{
						throw new RewriteEarlyExitException();
					}
					while ( stream_group.HasNext )
					{
						DebugLocation(153, 90);
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
		DebugLocation(154, 0);
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
	// MathLang.g:156:1: vars : VAR ( type_decl ';' )+ ;
	[GrammarRule("vars")]
	private MathLangParser.vars_return vars()
	{
		Enter_vars();
		EnterRule("vars", 18);
		TraceIn("vars", 18);
		MathLangParser.vars_return retval = new MathLangParser.vars_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken VAR102=null;
		IToken char_literal104=null;
		MathLangParser.type_decl_return type_decl103 = default(MathLangParser.type_decl_return);

		object VAR102_tree=null;
		object char_literal104_tree=null;

		try { DebugEnterRule(GrammarFileName, "vars");
		DebugLocation(156, 0);
		try
		{
			// MathLang.g:156:5: ( VAR ( type_decl ';' )+ )
			DebugEnterAlt(1);
			// MathLang.g:157:2: VAR ( type_decl ';' )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(157, 5);
			VAR102=(IToken)Match(input,VAR,Follow._VAR_in_vars1727); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			VAR102_tree = (object)adaptor.Create(VAR102);
			root_0 = (object)adaptor.BecomeRoot(VAR102_tree, root_0);
			}
			DebugLocation(157, 7);
			// MathLang.g:157:7: ( type_decl ';' )+
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
					// MathLang.g:157:8: type_decl ';'
					{
					DebugLocation(157, 8);
					PushFollow(Follow._type_decl_in_vars1731);
					type_decl103=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_decl103.Tree);
					DebugLocation(157, 21);
					char_literal104=(IToken)Match(input,69,Follow._69_in_vars1733); if (state.failed) return retval;

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
		DebugLocation(158, 0);
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
	// MathLang.g:160:1: param : term ;
	[GrammarRule("param")]
	private MathLangParser.param_return param()
	{
		Enter_param();
		EnterRule("param", 19);
		TraceIn("param", 19);
		MathLangParser.param_return retval = new MathLangParser.param_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.term_return term105 = default(MathLangParser.term_return);


		try { DebugEnterRule(GrammarFileName, "param");
		DebugLocation(160, 0);
		try
		{
			// MathLang.g:160:6: ( term )
			DebugEnterAlt(1);
			// MathLang.g:160:8: term
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(160, 8);
			PushFollow(Follow._term_in_param1744);
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
			TraceOut("param", 19);
			LeaveRule("param", 19);
			Leave_param();
		}
		DebugLocation(161, 0);
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
	// MathLang.g:163:1: params_ : ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) ;
	[GrammarRule("params_")]
	private MathLangParser.params__return params_()
	{
		Enter_params_();
		EnterRule("params_", 20);
		TraceIn("params_", 20);
		MathLangParser.params__return retval = new MathLangParser.params__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal107=null;
		MathLangParser.param_return param106 = default(MathLangParser.param_return);
		MathLangParser.param_return param108 = default(MathLangParser.param_return);

		object char_literal107_tree=null;
		RewriteRuleITokenStream stream_79=new RewriteRuleITokenStream(adaptor,"token 79");
		RewriteRuleSubtreeStream stream_param=new RewriteRuleSubtreeStream(adaptor,"rule param");
		try { DebugEnterRule(GrammarFileName, "params_");
		DebugLocation(163, 0);
		try
		{
			// MathLang.g:163:8: ( ( param ( ',' param )* )? -> ^( PARAMS ( param )* ) )
			DebugEnterAlt(1);
			// MathLang.g:164:1: ( param ( ',' param )* )?
			{
			DebugLocation(164, 1);
			// MathLang.g:164:1: ( param ( ',' param )* )?
			int alt22=2;
			try { DebugEnterSubRule(22);
			try { DebugEnterDecision(22, decisionCanBacktrack[22]);
			int LA22_0 = input.LA(1);

			if (((LA22_0>=TRUE && LA22_0<=FALSE)||(LA22_0>=NUMBER && LA22_0<=IDENT)||LA22_0==60||LA22_0==64))
			{
				alt22=1;
			}
			} finally { DebugExitDecision(22); }
			switch (alt22)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:164:2: param ( ',' param )*
				{
				DebugLocation(164, 2);
				PushFollow(Follow._param_in_params_1753);
				param106=param();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_param.Add(param106.Tree);
				DebugLocation(164, 7);
				// MathLang.g:164:7: ( ',' param )*
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
						// MathLang.g:164:8: ',' param
						{
						DebugLocation(164, 8);
						char_literal107=(IToken)Match(input,79,Follow._79_in_params_1755); if (state.failed) return retval; 
						if ( state.backtracking == 0 ) stream_79.Add(char_literal107);

						DebugLocation(164, 12);
						PushFollow(Follow._param_in_params_1757);
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
			// 164:22: -> ^( PARAMS ( param )* )
			{
				DebugLocation(164, 25);
				// MathLang.g:164:25: ^( PARAMS ( param )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(164, 27);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_1);

				DebugLocation(164, 34);
				// MathLang.g:164:34: ( param )*
				while ( stream_param.HasNext )
				{
					DebugLocation(164, 34);
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
		DebugLocation(165, 0);
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
	// MathLang.g:167:1: func_sign : ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) ;
	[GrammarRule("func_sign")]
	private MathLangParser.func_sign_return func_sign()
	{
		Enter_func_sign();
		EnterRule("func_sign", 21);
		TraceIn("func_sign", 21);
		MathLangParser.func_sign_return retval = new MathLangParser.func_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken FUNC109=null;
		IToken IDENT110=null;
		IToken char_literal111=null;
		IToken char_literal112=null;
		IToken char_literal114=null;
		IToken VAR115=null;
		IToken char_literal116=null;
		IToken char_literal117=null;
		IToken char_literal119=null;
		MathLangParser.type_decl_return t1 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl113 = default(MathLangParser.type_decl_return);
		MathLangParser.type_return type118 = default(MathLangParser.type_return);

		object FUNC109_tree=null;
		object IDENT110_tree=null;
		object char_literal111_tree=null;
		object char_literal112_tree=null;
		object char_literal114_tree=null;
		object VAR115_tree=null;
		object char_literal116_tree=null;
		object char_literal117_tree=null;
		object char_literal119_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_68=new RewriteRuleITokenStream(adaptor,"token 68");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_FUNC=new RewriteRuleITokenStream(adaptor,"token FUNC");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		RewriteRuleSubtreeStream stream_type=new RewriteRuleSubtreeStream(adaptor,"rule type");
		try { DebugEnterRule(GrammarFileName, "func_sign");
		DebugLocation(167, 0);
		try
		{
			// MathLang.g:167:10: ( ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' ) -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:168:1: ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' )
			{
			DebugLocation(168, 1);
			// MathLang.g:168:1: ( FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';' )
			DebugEnterAlt(1);
			// MathLang.g:168:2: FUNC IDENT '(' (t1= type_decl ( ';' type_decl )* )* ( ';' VAR (t2= type_decl )* )* ')' ':' type ';'
			{
			DebugLocation(168, 2);
			FUNC109=(IToken)Match(input,FUNC,Follow._FUNC_in_func_sign1779); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_FUNC.Add(FUNC109);

			DebugLocation(168, 7);
			IDENT110=(IToken)Match(input,IDENT,Follow._IDENT_in_func_sign1781); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT110);

			DebugLocation(168, 13);
			char_literal111=(IToken)Match(input,60,Follow._60_in_func_sign1783); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal111);

			DebugLocation(168, 16);
			// MathLang.g:168:16: (t1= type_decl ( ';' type_decl )* )*
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
					// MathLang.g:168:18: t1= type_decl ( ';' type_decl )*
					{
					DebugLocation(168, 21);
					PushFollow(Follow._type_decl_in_func_sign1789);
					t1=type_decl();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_type_decl.Add(t1.Tree);
					DebugLocation(168, 32);
					// MathLang.g:168:32: ( ';' type_decl )*
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
							// MathLang.g:168:33: ';' type_decl
							{
							DebugLocation(168, 33);
							char_literal112=(IToken)Match(input,69,Follow._69_in_func_sign1792); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_69.Add(char_literal112);

							DebugLocation(168, 37);
							PushFollow(Follow._type_decl_in_func_sign1794);
							type_decl113=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl113.Tree);

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

			DebugLocation(168, 50);
			// MathLang.g:168:50: ( ';' VAR (t2= type_decl )* )*
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
					// MathLang.g:168:51: ';' VAR (t2= type_decl )*
					{
					DebugLocation(168, 51);
					char_literal114=(IToken)Match(input,69,Follow._69_in_func_sign1800); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_69.Add(char_literal114);

					DebugLocation(168, 55);
					VAR115=(IToken)Match(input,VAR,Follow._VAR_in_func_sign1802); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_VAR.Add(VAR115);

					DebugLocation(168, 61);
					// MathLang.g:168:61: (t2= type_decl )*
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
							DebugLocation(168, 61);
							PushFollow(Follow._type_decl_in_func_sign1806);
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

			DebugLocation(168, 74);
			char_literal116=(IToken)Match(input,61,Follow._61_in_func_sign1810); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal116);

			DebugLocation(168, 78);
			char_literal117=(IToken)Match(input,68,Follow._68_in_func_sign1812); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_68.Add(char_literal117);

			DebugLocation(168, 82);
			PushFollow(Follow._type_in_func_sign1814);
			type118=type();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_type.Add(type118.Tree);
			DebugLocation(168, 87);
			char_literal119=(IToken)Match(input,69,Follow._69_in_func_sign1816); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal119);


			}



			{
			// AST REWRITE
			// elements: IDENT, type, FUNC, t2, VAR, t1
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
			// 168:91: -> ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
			{
				DebugLocation(168, 94);
				// MathLang.g:168:94: ^( FUNC type IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(168, 96);
				root_1 = (object)adaptor.BecomeRoot(stream_FUNC.NextNode(), root_1);

				DebugLocation(168, 101);
				adaptor.AddChild(root_1, stream_type.NextTree());
				DebugLocation(168, 106);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(168, 112);
				// MathLang.g:168:112: ^( PARAMS ( $t1)* ( ^( VAR $t2) )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(168, 114);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(168, 121);
				// MathLang.g:168:121: ( $t1)*
				while ( stream_t1.HasNext )
				{
					DebugLocation(168, 121);
					adaptor.AddChild(root_2, stream_t1.NextTree());

				}
				stream_t1.Reset();
				DebugLocation(168, 126);
				// MathLang.g:168:126: ( ^( VAR $t2) )*
				while ( stream_t2.HasNext||stream_VAR.HasNext )
				{
					DebugLocation(168, 126);
					// MathLang.g:168:126: ^( VAR $t2)
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(168, 128);
					root_3 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_3);

					DebugLocation(168, 132);
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
			TraceOut("func_sign", 21);
			LeaveRule("func_sign", 21);
			Leave_func_sign();
		}
		DebugLocation(169, 0);
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
	// MathLang.g:171:1: proc_sign : ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) ;
	[GrammarRule("proc_sign")]
	private MathLangParser.proc_sign_return proc_sign()
	{
		Enter_proc_sign();
		EnterRule("proc_sign", 22);
		TraceIn("proc_sign", 22);
		MathLangParser.proc_sign_return retval = new MathLangParser.proc_sign_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken PROC120=null;
		IToken IDENT121=null;
		IToken char_literal122=null;
		IToken char_literal123=null;
		IToken char_literal125=null;
		IToken VAR126=null;
		IToken char_literal127=null;
		IToken char_literal128=null;
		MathLangParser.type_decl_return t1 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);
		MathLangParser.type_decl_return type_decl124 = default(MathLangParser.type_decl_return);

		object PROC120_tree=null;
		object IDENT121_tree=null;
		object char_literal122_tree=null;
		object char_literal123_tree=null;
		object char_literal125_tree=null;
		object VAR126_tree=null;
		object char_literal127_tree=null;
		object char_literal128_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_69=new RewriteRuleITokenStream(adaptor,"token 69");
		RewriteRuleITokenStream stream_VAR=new RewriteRuleITokenStream(adaptor,"token VAR");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_PROC=new RewriteRuleITokenStream(adaptor,"token PROC");
		RewriteRuleSubtreeStream stream_type_decl=new RewriteRuleSubtreeStream(adaptor,"rule type_decl");
		try { DebugEnterRule(GrammarFileName, "proc_sign");
		DebugLocation(171, 0);
		try
		{
			// MathLang.g:171:10: ( ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' ) -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) ) )
			DebugEnterAlt(1);
			// MathLang.g:172:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			{
			DebugLocation(172, 1);
			// MathLang.g:172:1: ( PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';' )
			DebugEnterAlt(1);
			// MathLang.g:172:2: PROC IDENT '(' ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )* ')' ';'
			{
			DebugLocation(172, 2);
			PROC120=(IToken)Match(input,PROC,Follow._PROC_in_proc_sign1851); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_PROC.Add(PROC120);

			DebugLocation(172, 7);
			IDENT121=(IToken)Match(input,IDENT,Follow._IDENT_in_proc_sign1853); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT121);

			DebugLocation(172, 13);
			char_literal122=(IToken)Match(input,60,Follow._60_in_proc_sign1855); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_60.Add(char_literal122);

			DebugLocation(172, 16);
			// MathLang.g:172:16: ( (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )* )*
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
					// MathLang.g:172:17: (t1= type_decl ( ';' type_decl )* ';' )* VAR (t2= type_decl )*
					{
					DebugLocation(172, 17);
					// MathLang.g:172:17: (t1= type_decl ( ';' type_decl )* ';' )*
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
							// MathLang.g:172:19: t1= type_decl ( ';' type_decl )* ';'
							{
							DebugLocation(172, 21);
							PushFollow(Follow._type_decl_in_proc_sign1861);
							t1=type_decl();
							PopFollow();
							if (state.failed) return retval;
							if ( state.backtracking == 0 ) stream_type_decl.Add(t1.Tree);
							DebugLocation(172, 32);
							// MathLang.g:172:32: ( ';' type_decl )*
							try { DebugEnterSubRule(27);
							while (true)
							{
								int alt27=2;
								try { DebugEnterDecision(27, decisionCanBacktrack[27]);
								int LA27_0 = input.LA(1);

								if ((LA27_0==69))
								{
									int LA27_1 = input.LA(2);

									if ((EvaluatePredicate(synpred78_MathLang_fragment)))
									{
										alt27=1;
									}


								}


								} finally { DebugExitDecision(27); }
								switch ( alt27 )
								{
								case 1:
									DebugEnterAlt(1);
									// MathLang.g:172:33: ';' type_decl
									{
									DebugLocation(172, 33);
									char_literal123=(IToken)Match(input,69,Follow._69_in_proc_sign1864); if (state.failed) return retval; 
									if ( state.backtracking == 0 ) stream_69.Add(char_literal123);

									DebugLocation(172, 37);
									PushFollow(Follow._type_decl_in_proc_sign1866);
									type_decl124=type_decl();
									PopFollow();
									if (state.failed) return retval;
									if ( state.backtracking == 0 ) stream_type_decl.Add(type_decl124.Tree);

									}
									break;

								default:
									goto loop27;
								}
							}

							loop27:
								;

							} finally { DebugExitSubRule(27); }

							DebugLocation(172, 49);
							char_literal125=(IToken)Match(input,69,Follow._69_in_proc_sign1870); if (state.failed) return retval; 
							if ( state.backtracking == 0 ) stream_69.Add(char_literal125);


							}
							break;

						default:
							goto loop28;
						}
					}

					loop28:
						;

					} finally { DebugExitSubRule(28); }

					DebugLocation(172, 55);
					VAR126=(IToken)Match(input,VAR,Follow._VAR_in_proc_sign1874); if (state.failed) return retval; 
					if ( state.backtracking == 0 ) stream_VAR.Add(VAR126);

					DebugLocation(172, 61);
					// MathLang.g:172:61: (t2= type_decl )*
					try { DebugEnterSubRule(29);
					while (true)
					{
						int alt29=2;
						try { DebugEnterDecision(29, decisionCanBacktrack[29]);
						int LA29_0 = input.LA(1);

						if ((LA29_0==IDENT))
						{
							int LA29_2 = input.LA(2);

							if ((EvaluatePredicate(synpred80_MathLang_fragment)))
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
							DebugLocation(172, 61);
							PushFollow(Follow._type_decl_in_proc_sign1878);
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

			DebugLocation(172, 74);
			char_literal127=(IToken)Match(input,61,Follow._61_in_proc_sign1882); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_61.Add(char_literal127);

			DebugLocation(172, 78);
			char_literal128=(IToken)Match(input,69,Follow._69_in_proc_sign1884); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_69.Add(char_literal128);


			}



			{
			// AST REWRITE
			// elements: t2, t1, IDENT, VAR, PROC
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
			// 172:82: -> ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
			{
				DebugLocation(172, 85);
				// MathLang.g:172:85: ^( PROC IDENT ^( PARAMS ( $t1)* ( ^( VAR $t2) )* ) )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(172, 87);
				root_1 = (object)adaptor.BecomeRoot(stream_PROC.NextNode(), root_1);

				DebugLocation(172, 92);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(172, 98);
				// MathLang.g:172:98: ^( PARAMS ( $t1)* ( ^( VAR $t2) )* )
				{
				object root_2 = (object)adaptor.Nil();
				DebugLocation(172, 100);
				root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAMS, "PARAMS"), root_2);

				DebugLocation(172, 108);
				// MathLang.g:172:108: ( $t1)*
				while ( stream_t1.HasNext )
				{
					DebugLocation(172, 108);
					adaptor.AddChild(root_2, stream_t1.NextTree());

				}
				stream_t1.Reset();
				DebugLocation(172, 114);
				// MathLang.g:172:114: ( ^( VAR $t2) )*
				while ( stream_t2.HasNext||stream_VAR.HasNext )
				{
					DebugLocation(172, 114);
					// MathLang.g:172:114: ^( VAR $t2)
					{
					object root_3 = (object)adaptor.Nil();
					DebugLocation(172, 116);
					root_3 = (object)adaptor.BecomeRoot(stream_VAR.NextNode(), root_3);

					DebugLocation(172, 120);
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
			TraceOut("proc_sign", 22);
			LeaveRule("proc_sign", 22);
			Leave_proc_sign();
		}
		DebugLocation(173, 0);
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
	// MathLang.g:175:1: func_decl : func_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("func_decl")]
	private MathLangParser.func_decl_return func_decl()
	{
		Enter_func_decl();
		EnterRule("func_decl", 23);
		TraceIn("func_decl", 23);
		MathLangParser.func_decl_return retval = new MathLangParser.func_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal130=null;
		IToken char_literal134=null;
		MathLangParser.func_sign_return func_sign129 = default(MathLangParser.func_sign_return);
		MathLangParser.const__return const_131 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars132 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr133 = default(MathLangParser.groupExpr_return);

		object char_literal130_tree=null;
		object char_literal134_tree=null;

		try { DebugEnterRule(GrammarFileName, "func_decl");
		DebugLocation(175, 0);
		try
		{
			// MathLang.g:175:10: ( func_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:176:1: func_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(176, 10);
			PushFollow(Follow._func_sign_in_func_decl1918);
			func_sign129=func_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(func_sign129.Tree, root_0);
			DebugLocation(176, 15);
			char_literal130=(IToken)Match(input,69,Follow._69_in_func_decl1921); if (state.failed) return retval;
			DebugLocation(176, 17);
			// MathLang.g:176:17: ( const_ )*
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
					DebugLocation(176, 17);
					PushFollow(Follow._const__in_func_decl1924);
					const_131=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_131.Tree);

					}
					break;

				default:
					goto loop31;
				}
			}

			loop31:
				;

			} finally { DebugExitSubRule(31); }

			DebugLocation(176, 25);
			// MathLang.g:176:25: ( vars )*
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
					DebugLocation(176, 25);
					PushFollow(Follow._vars_in_func_decl1927);
					vars132=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars132.Tree);

					}
					break;

				default:
					goto loop32;
				}
			}

			loop32:
				;

			} finally { DebugExitSubRule(32); }

			DebugLocation(176, 31);
			PushFollow(Follow._groupExpr_in_func_decl1930);
			groupExpr133=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr133.Tree);
			DebugLocation(176, 44);
			char_literal134=(IToken)Match(input,69,Follow._69_in_func_decl1932); if (state.failed) return retval;

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
		DebugLocation(177, 0);
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
	// MathLang.g:179:1: proc_decl : proc_sign ';' ( const_ )* ( vars )* groupExpr ';' ;
	[GrammarRule("proc_decl")]
	private MathLangParser.proc_decl_return proc_decl()
	{
		Enter_proc_decl();
		EnterRule("proc_decl", 24);
		TraceIn("proc_decl", 24);
		MathLangParser.proc_decl_return retval = new MathLangParser.proc_decl_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal136=null;
		IToken char_literal140=null;
		MathLangParser.proc_sign_return proc_sign135 = default(MathLangParser.proc_sign_return);
		MathLangParser.const__return const_137 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars138 = default(MathLangParser.vars_return);
		MathLangParser.groupExpr_return groupExpr139 = default(MathLangParser.groupExpr_return);

		object char_literal136_tree=null;
		object char_literal140_tree=null;

		try { DebugEnterRule(GrammarFileName, "proc_decl");
		DebugLocation(179, 0);
		try
		{
			// MathLang.g:179:10: ( proc_sign ';' ( const_ )* ( vars )* groupExpr ';' )
			DebugEnterAlt(1);
			// MathLang.g:180:1: proc_sign ';' ( const_ )* ( vars )* groupExpr ';'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(180, 10);
			PushFollow(Follow._proc_sign_in_proc_decl1941);
			proc_sign135=proc_sign();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot(proc_sign135.Tree, root_0);
			DebugLocation(180, 15);
			char_literal136=(IToken)Match(input,69,Follow._69_in_proc_decl1944); if (state.failed) return retval;
			DebugLocation(180, 17);
			// MathLang.g:180:17: ( const_ )*
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
					DebugLocation(180, 17);
					PushFollow(Follow._const__in_proc_decl1947);
					const_137=const_();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_137.Tree);

					}
					break;

				default:
					goto loop33;
				}
			}

			loop33:
				;

			} finally { DebugExitSubRule(33); }

			DebugLocation(180, 25);
			// MathLang.g:180:25: ( vars )*
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
					DebugLocation(180, 25);
					PushFollow(Follow._vars_in_proc_decl1950);
					vars138=vars();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars138.Tree);

					}
					break;

				default:
					goto loop34;
				}
			}

			loop34:
				;

			} finally { DebugExitSubRule(34); }

			DebugLocation(180, 31);
			PushFollow(Follow._groupExpr_in_proc_decl1953);
			groupExpr139=groupExpr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr139.Tree);
			DebugLocation(180, 44);
			char_literal140=(IToken)Match(input,69,Follow._69_in_proc_decl1955); if (state.failed) return retval;

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
		DebugLocation(181, 0);
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
	// MathLang.g:183:1: call : ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) );
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
		IToken IDENT141=null;
		IToken char_literal142=null;
		IToken char_literal144=null;
		IToken ASSIGN145=null;
		IToken char_literal146=null;
		IToken char_literal148=null;
		MathLangParser.params__return params_143 = default(MathLangParser.params__return);
		MathLangParser.params__return params_147 = default(MathLangParser.params__return);

		object i1_tree=null;
		object i2_tree=null;
		object IDENT141_tree=null;
		object char_literal142_tree=null;
		object char_literal144_tree=null;
		object ASSIGN145_tree=null;
		object char_literal146_tree=null;
		object char_literal148_tree=null;
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_60=new RewriteRuleITokenStream(adaptor,"token 60");
		RewriteRuleITokenStream stream_61=new RewriteRuleITokenStream(adaptor,"token 61");
		RewriteRuleITokenStream stream_ASSIGN=new RewriteRuleITokenStream(adaptor,"token ASSIGN");
		RewriteRuleSubtreeStream stream_params_=new RewriteRuleSubtreeStream(adaptor,"rule params_");
		try { DebugEnterRule(GrammarFileName, "call");
		DebugLocation(183, 0);
		try
		{
			// MathLang.g:183:5: ( IDENT '(' params_ ')' -> ^( CALL IDENT params_ ) | (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' ) -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) ) )
			int alt35=2;
			try { DebugEnterDecision(35, decisionCanBacktrack[35]);
			int LA35_0 = input.LA(1);

			if ((LA35_0==IDENT))
			{
				int LA35_1 = input.LA(2);

				if ((LA35_1==60))
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
				// MathLang.g:184:1: IDENT '(' params_ ')'
				{
				DebugLocation(184, 1);
				IDENT141=(IToken)Match(input,IDENT,Follow._IDENT_in_call1964); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(IDENT141);

				DebugLocation(184, 7);
				char_literal142=(IToken)Match(input,60,Follow._60_in_call1966); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal142);

				DebugLocation(184, 11);
				PushFollow(Follow._params__in_call1968);
				params_143=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_143.Tree);
				DebugLocation(184, 19);
				char_literal144=(IToken)Match(input,61,Follow._61_in_call1970); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal144);



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
				// 184:23: -> ^( CALL IDENT params_ )
				{
					DebugLocation(184, 26);
					// MathLang.g:184:26: ^( CALL IDENT params_ )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(184, 28);
					root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_1);

					DebugLocation(184, 33);
					adaptor.AddChild(root_1, stream_IDENT.NextNode());
					DebugLocation(184, 39);
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
				// MathLang.g:185:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				{
				DebugLocation(185, 3);
				// MathLang.g:185:3: (i1= IDENT ASSIGN i2= IDENT '(' params_ ')' )
				DebugEnterAlt(1);
				// MathLang.g:185:4: i1= IDENT ASSIGN i2= IDENT '(' params_ ')'
				{
				DebugLocation(185, 6);
				i1=(IToken)Match(input,IDENT,Follow._IDENT_in_call1987); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i1);

				DebugLocation(185, 13);
				ASSIGN145=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_call1989); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_ASSIGN.Add(ASSIGN145);

				DebugLocation(185, 22);
				i2=(IToken)Match(input,IDENT,Follow._IDENT_in_call1993); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_IDENT.Add(i2);

				DebugLocation(185, 29);
				char_literal146=(IToken)Match(input,60,Follow._60_in_call1995); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_60.Add(char_literal146);

				DebugLocation(185, 33);
				PushFollow(Follow._params__in_call1997);
				params_147=params_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) stream_params_.Add(params_147.Tree);
				DebugLocation(185, 41);
				char_literal148=(IToken)Match(input,61,Follow._61_in_call1999); if (state.failed) return retval; 
				if ( state.backtracking == 0 ) stream_61.Add(char_literal148);


				}



				{
				// AST REWRITE
				// elements: i2, ASSIGN, params_, i1
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
				// 185:46: -> ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
				{
					DebugLocation(185, 48);
					// MathLang.g:185:48: ^( ASSIGN $i1 ^( CALL $i2 params_ ) )
					{
					object root_1 = (object)adaptor.Nil();
					DebugLocation(185, 50);
					root_1 = (object)adaptor.BecomeRoot(stream_ASSIGN.NextNode(), root_1);

					DebugLocation(185, 57);
					adaptor.AddChild(root_1, stream_i1.NextNode());
					DebugLocation(185, 61);
					// MathLang.g:185:61: ^( CALL $i2 params_ )
					{
					object root_2 = (object)adaptor.Nil();
					DebugLocation(185, 63);
					root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(CALL, "CALL"), root_2);

					DebugLocation(185, 68);
					adaptor.AddChild(root_2, stream_i2.NextNode());
					DebugLocation(185, 72);
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
		DebugLocation(186, 0);
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
	// MathLang.g:188:1: exprList : ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) ;
	[GrammarRule("exprList")]
	private MathLangParser.exprList_return exprList()
	{
		Enter_exprList();
		EnterRule("exprList", 26);
		TraceIn("exprList", 26);
		MathLangParser.exprList_return retval = new MathLangParser.exprList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal150=null;
		IToken char_literal152=null;
		MathLangParser.simpleExpr_return simpleExpr149 = default(MathLangParser.simpleExpr_return);
		MathLangParser.groupExpr_return groupExpr151 = default(MathLangParser.groupExpr_return);

		object char_literal150_tree=null;
		object char_literal152_tree=null;

		try { DebugEnterRule(GrammarFileName, "exprList");
		DebugLocation(188, 0);
		try
		{
			// MathLang.g:188:9: ( ( simpleExpr ( ';' )+ | groupExpr ( ';' )* ) )
			DebugEnterAlt(1);
			// MathLang.g:189:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(189, 2);
			// MathLang.g:189:2: ( simpleExpr ( ';' )+ | groupExpr ( ';' )* )
			int alt38=2;
			try { DebugEnterSubRule(38);
			try { DebugEnterDecision(38, decisionCanBacktrack[38]);
			int LA38_0 = input.LA(1);

			if ((LA38_0==PRINT||LA38_0==IDENT))
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
				// MathLang.g:189:4: simpleExpr ( ';' )+
				{
				DebugLocation(189, 4);
				PushFollow(Follow._simpleExpr_in_exprList2029);
				simpleExpr149=simpleExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, simpleExpr149.Tree);
				DebugLocation(189, 15);
				// MathLang.g:189:15: ( ';' )+
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

						if ((EvaluatePredicate(synpred87_MathLang_fragment)))
						{
							alt36=1;
						}


					}


					} finally { DebugExitDecision(36); }
					switch (alt36)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:189:16: ';'
						{
						DebugLocation(189, 19);
						char_literal150=(IToken)Match(input,69,Follow._69_in_exprList2032); if (state.failed) return retval;

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
				// MathLang.g:190:3: groupExpr ( ';' )*
				{
				DebugLocation(190, 3);
				PushFollow(Follow._groupExpr_in_exprList2040);
				groupExpr151=groupExpr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, groupExpr151.Tree);
				DebugLocation(190, 13);
				// MathLang.g:190:13: ( ';' )*
				try { DebugEnterSubRule(37);
				while (true)
				{
					int alt37=2;
					try { DebugEnterDecision(37, decisionCanBacktrack[37]);
					int LA37_0 = input.LA(1);

					if ((LA37_0==69))
					{
						int LA37_2 = input.LA(2);

						if ((EvaluatePredicate(synpred89_MathLang_fragment)))
						{
							alt37=1;
						}


					}


					} finally { DebugExitDecision(37); }
					switch ( alt37 )
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:190:14: ';'
						{
						DebugLocation(190, 17);
						char_literal152=(IToken)Match(input,69,Follow._69_in_exprList2043); if (state.failed) return retval;

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
		DebugLocation(192, 0);
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
	// MathLang.g:194:1: main_ : BEGIN ( exprList )* END '.' ;
	[GrammarRule("main_")]
	private MathLangParser.main__return main_()
	{
		Enter_main_();
		EnterRule("main_", 27);
		TraceIn("main_", 27);
		MathLangParser.main__return retval = new MathLangParser.main__return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken BEGIN153=null;
		IToken END155=null;
		IToken char_literal156=null;
		MathLangParser.exprList_return exprList154 = default(MathLangParser.exprList_return);

		object BEGIN153_tree=null;
		object END155_tree=null;
		object char_literal156_tree=null;

		try { DebugEnterRule(GrammarFileName, "main_");
		DebugLocation(194, 0);
		try
		{
			// MathLang.g:194:6: ( BEGIN ( exprList )* END '.' )
			DebugEnterAlt(1);
			// MathLang.g:195:1: BEGIN ( exprList )* END '.'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(195, 6);
			BEGIN153=(IToken)Match(input,BEGIN,Follow._BEGIN_in_main_2056); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			BEGIN153_tree = (object)adaptor.Create(BEGIN153);
			root_0 = (object)adaptor.BecomeRoot(BEGIN153_tree, root_0);
			}
			DebugLocation(195, 8);
			// MathLang.g:195:8: ( exprList )*
			try { DebugEnterSubRule(39);
			while (true)
			{
				int alt39=2;
				try { DebugEnterDecision(39, decisionCanBacktrack[39]);
				int LA39_0 = input.LA(1);

				if ((LA39_0==IF||LA39_0==FOR||(LA39_0>=WHILE && LA39_0<=REPEAT)||LA39_0==BEGIN||LA39_0==PRINT||(LA39_0>=FUNC && LA39_0<=PROC)||LA39_0==IDENT))
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
					DebugLocation(195, 8);
					PushFollow(Follow._exprList_in_main_2059);
					exprList154=exprList();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList154.Tree);

					}
					break;

				default:
					goto loop39;
				}
			}

			loop39:
				;

			} finally { DebugExitSubRule(39); }

			DebugLocation(195, 21);
			END155=(IToken)Match(input,END,Follow._END_in_main_2062); if (state.failed) return retval;
			DebugLocation(195, 26);
			char_literal156=(IToken)Match(input,78,Follow._78_in_main_2065); if (state.failed) return retval;

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
		DebugLocation(196, 0);
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
	// MathLang.g:198:1: program : ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) );
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 28);
		TraceIn("program", 28);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.func_decl_return func_decl157 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl158 = default(MathLangParser.proc_decl_return);
		MathLangParser.const__return const_159 = default(MathLangParser.const__return);
		MathLangParser.vars_return vars160 = default(MathLangParser.vars_return);
		MathLangParser.func_decl_return func_decl161 = default(MathLangParser.func_decl_return);
		MathLangParser.proc_decl_return proc_decl162 = default(MathLangParser.proc_decl_return);
		MathLangParser.vars_return vars163 = default(MathLangParser.vars_return);
		MathLangParser.main__return main_164 = default(MathLangParser.main__return);


		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(198, 0);
		try
		{
			// MathLang.g:198:8: ( ( ( func_decl )* ( proc_decl )* ) | ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ ) )
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
				// MathLang.g:198:10: ( ( func_decl )* ( proc_decl )* )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(198, 10);
				// MathLang.g:198:10: ( ( func_decl )* ( proc_decl )* )
				DebugEnterAlt(1);
				// MathLang.g:198:12: ( func_decl )* ( proc_decl )*
				{
				DebugLocation(198, 12);
				// MathLang.g:198:12: ( func_decl )*
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
						DebugLocation(198, 12);
						PushFollow(Follow._func_decl_in_program2076);
						func_decl157=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl157.Tree);

						}
						break;

					default:
						goto loop40;
					}
				}

				loop40:
					;

				} finally { DebugExitSubRule(40); }

				DebugLocation(198, 23);
				// MathLang.g:198:23: ( proc_decl )*
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
						DebugLocation(198, 23);
						PushFollow(Follow._proc_decl_in_program2079);
						proc_decl158=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl158.Tree);

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
				// MathLang.g:199:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(199, 2);
				// MathLang.g:199:2: ( ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_ )
				DebugEnterAlt(1);
				// MathLang.g:199:3: ( const_ )* ( vars )+ ( func_decl | proc_decl )* ( vars )* main_
				{
				DebugLocation(199, 3);
				// MathLang.g:199:3: ( const_ )*
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
						DebugLocation(199, 3);
						PushFollow(Follow._const__in_program2085);
						const_159=const_();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, const_159.Tree);

						}
						break;

					default:
						goto loop42;
					}
				}

				loop42:
					;

				} finally { DebugExitSubRule(42); }

				DebugLocation(199, 11);
				// MathLang.g:199:11: ( vars )+
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

						if ((EvaluatePredicate(synpred95_MathLang_fragment)))
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
						DebugLocation(199, 11);
						PushFollow(Follow._vars_in_program2088);
						vars160=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars160.Tree);

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

				DebugLocation(199, 18);
				// MathLang.g:199:18: ( func_decl | proc_decl )*
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
						// MathLang.g:199:19: func_decl
						{
						DebugLocation(199, 19);
						PushFollow(Follow._func_decl_in_program2093);
						func_decl161=func_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_decl161.Tree);

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// MathLang.g:199:29: proc_decl
						{
						DebugLocation(199, 29);
						PushFollow(Follow._proc_decl_in_program2095);
						proc_decl162=proc_decl();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, proc_decl162.Tree);

						}
						break;

					default:
						goto loop44;
					}
				}

				loop44:
					;

				} finally { DebugExitSubRule(44); }

				DebugLocation(199, 41);
				// MathLang.g:199:41: ( vars )*
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
						DebugLocation(199, 41);
						PushFollow(Follow._vars_in_program2099);
						vars163=vars();
						PopFollow();
						if (state.failed) return retval;
						if ( state.backtracking == 0 ) adaptor.AddChild(root_0, vars163.Tree);

						}
						break;

					default:
						goto loop45;
					}
				}

				loop45:
					;

				} finally { DebugExitSubRule(45); }

				DebugLocation(199, 47);
				PushFollow(Follow._main__in_program2102);
				main_164=main_();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, main_164.Tree);

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
		DebugLocation(200, 0);
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
	// MathLang.g:202:1: result : program EOF -> ^( PROGRAM program ) ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 29);
		TraceIn("result", 29);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF166=null;
		MathLangParser.program_return program165 = default(MathLangParser.program_return);

		object EOF166_tree=null;
		RewriteRuleITokenStream stream_EOF=new RewriteRuleITokenStream(adaptor,"token EOF");
		RewriteRuleSubtreeStream stream_program=new RewriteRuleSubtreeStream(adaptor,"rule program");
		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(202, 41);
		try
		{
			// MathLang.g:202:7: ( program EOF -> ^( PROGRAM program ) )
			DebugEnterAlt(1);
			// MathLang.g:202:9: program EOF
			{
			DebugLocation(202, 9);
			PushFollow(Follow._program_in_result2111);
			program165=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) stream_program.Add(program165.Tree);
			DebugLocation(202, 17);
			EOF166=(IToken)Match(input,EOF,Follow._EOF_in_result2113); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_EOF.Add(EOF166);



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
			// 202:21: -> ^( PROGRAM program )
			{
				DebugLocation(202, 24);
				// MathLang.g:202:24: ^( PROGRAM program )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(202, 26);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(202, 34);
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
		DebugLocation(202, 41);
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
	// MathLang.g:204:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 30);
		TraceIn("execute", 30);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		MathLangParser.result_return result167 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(204, 0);
		try
		{
			// MathLang.g:204:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:205:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(205, 3);
			PushFollow(Follow._result_in_execute2132);
			result167=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result167.Tree);

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
		DebugLocation(206, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred54_MathLang_fragment();
	partial void Leave_synpred54_MathLang_fragment();

	// $ANTLR start synpred54_MathLang
	public void synpred54_MathLang_fragment()
	{
		MathLangParser.term_return t2 = default(MathLangParser.term_return);
		MathLangParser.exprList_return lst2 = default(MathLangParser.exprList_return);

		Enter_synpred54_MathLang_fragment();
		EnterRule("synpred54_MathLang_fragment", 84);
		TraceIn("synpred54_MathLang_fragment", 84);
		try
		{
			// MathLang.g:134:42: ( ELSIF t2= term THEN lst2= exprList )
			DebugEnterAlt(1);
			// MathLang.g:134:42: ELSIF t2= term THEN lst2= exprList
			{
			DebugLocation(134, 42);
			Match(input,ELSIF,Follow._ELSIF_in_synpred54_MathLang1445); if (state.failed) return;
			DebugLocation(134, 50);
			PushFollow(Follow._term_in_synpred54_MathLang1449);
			t2=term();
			PopFollow();
			if (state.failed) return;
			DebugLocation(134, 56);
			Match(input,THEN,Follow._THEN_in_synpred54_MathLang1451); if (state.failed) return;
			DebugLocation(134, 65);
			PushFollow(Follow._exprList_in_synpred54_MathLang1455);
			lst2=exprList();
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

	partial void Enter_synpred55_MathLang_fragment();
	partial void Leave_synpred55_MathLang_fragment();

	// $ANTLR start synpred55_MathLang
	public void synpred55_MathLang_fragment()
	{
		MathLangParser.exprList_return lst3 = default(MathLangParser.exprList_return);

		Enter_synpred55_MathLang_fragment();
		EnterRule("synpred55_MathLang_fragment", 85);
		TraceIn("synpred55_MathLang_fragment", 85);
		try
		{
			// MathLang.g:134:78: ( ELSE lst3= exprList )
			DebugEnterAlt(1);
			// MathLang.g:134:78: ELSE lst3= exprList
			{
			DebugLocation(134, 78);
			Match(input,ELSE,Follow._ELSE_in_synpred55_MathLang1460); if (state.failed) return;
			DebugLocation(134, 87);
			PushFollow(Follow._exprList_in_synpred55_MathLang1464);
			lst3=exprList();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred55_MathLang_fragment", 85);
			LeaveRule("synpred55_MathLang_fragment", 85);
			Leave_synpred55_MathLang_fragment();
		}
	}
	// $ANTLR end synpred55_MathLang

	partial void Enter_synpred78_MathLang_fragment();
	partial void Leave_synpred78_MathLang_fragment();

	// $ANTLR start synpred78_MathLang
	public void synpred78_MathLang_fragment()
	{
		Enter_synpred78_MathLang_fragment();
		EnterRule("synpred78_MathLang_fragment", 108);
		TraceIn("synpred78_MathLang_fragment", 108);
		try
		{
			// MathLang.g:172:33: ( ';' type_decl )
			DebugEnterAlt(1);
			// MathLang.g:172:33: ';' type_decl
			{
			DebugLocation(172, 33);
			Match(input,69,Follow._69_in_synpred78_MathLang1864); if (state.failed) return;
			DebugLocation(172, 37);
			PushFollow(Follow._type_decl_in_synpred78_MathLang1866);
			type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred78_MathLang_fragment", 108);
			LeaveRule("synpred78_MathLang_fragment", 108);
			Leave_synpred78_MathLang_fragment();
		}
	}
	// $ANTLR end synpred78_MathLang

	partial void Enter_synpred80_MathLang_fragment();
	partial void Leave_synpred80_MathLang_fragment();

	// $ANTLR start synpred80_MathLang
	public void synpred80_MathLang_fragment()
	{
		MathLangParser.type_decl_return t2 = default(MathLangParser.type_decl_return);

		Enter_synpred80_MathLang_fragment();
		EnterRule("synpred80_MathLang_fragment", 110);
		TraceIn("synpred80_MathLang_fragment", 110);
		try
		{
			// MathLang.g:172:61: (t2= type_decl )
			DebugEnterAlt(1);
			// MathLang.g:172:61: t2= type_decl
			{
			DebugLocation(172, 61);
			PushFollow(Follow._type_decl_in_synpred80_MathLang1878);
			t2=type_decl();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred80_MathLang_fragment", 110);
			LeaveRule("synpred80_MathLang_fragment", 110);
			Leave_synpred80_MathLang_fragment();
		}
	}
	// $ANTLR end synpred80_MathLang

	partial void Enter_synpred87_MathLang_fragment();
	partial void Leave_synpred87_MathLang_fragment();

	// $ANTLR start synpred87_MathLang
	public void synpred87_MathLang_fragment()
	{
		Enter_synpred87_MathLang_fragment();
		EnterRule("synpred87_MathLang_fragment", 117);
		TraceIn("synpred87_MathLang_fragment", 117);
		try
		{
			// MathLang.g:189:16: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:189:16: ';'
			{
			DebugLocation(189, 16);
			Match(input,69,Follow._69_in_synpred87_MathLang2032); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred87_MathLang_fragment", 117);
			LeaveRule("synpred87_MathLang_fragment", 117);
			Leave_synpred87_MathLang_fragment();
		}
	}
	// $ANTLR end synpred87_MathLang

	partial void Enter_synpred89_MathLang_fragment();
	partial void Leave_synpred89_MathLang_fragment();

	// $ANTLR start synpred89_MathLang
	public void synpred89_MathLang_fragment()
	{
		Enter_synpred89_MathLang_fragment();
		EnterRule("synpred89_MathLang_fragment", 119);
		TraceIn("synpred89_MathLang_fragment", 119);
		try
		{
			// MathLang.g:190:14: ( ';' )
			DebugEnterAlt(1);
			// MathLang.g:190:14: ';'
			{
			DebugLocation(190, 14);
			Match(input,69,Follow._69_in_synpred89_MathLang2043); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred89_MathLang_fragment", 119);
			LeaveRule("synpred89_MathLang_fragment", 119);
			Leave_synpred89_MathLang_fragment();
		}
	}
	// $ANTLR end synpred89_MathLang

	partial void Enter_synpred95_MathLang_fragment();
	partial void Leave_synpred95_MathLang_fragment();

	// $ANTLR start synpred95_MathLang
	public void synpred95_MathLang_fragment()
	{
		Enter_synpred95_MathLang_fragment();
		EnterRule("synpred95_MathLang_fragment", 125);
		TraceIn("synpred95_MathLang_fragment", 125);
		try
		{
			// MathLang.g:199:11: ( vars )
			DebugEnterAlt(1);
			// MathLang.g:199:11: vars
			{
			DebugLocation(199, 11);
			PushFollow(Follow._vars_in_synpred95_MathLang2088);
			vars();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred95_MathLang_fragment", 125);
			LeaveRule("synpred95_MathLang_fragment", 125);
			Leave_synpred95_MathLang_fragment();
		}
	}
	// $ANTLR end synpred95_MathLang
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

		public override string Description { get { return "151:1: type_decl : ( ( ( IDENT ( ',' IDENT )* )+ ) ':' type -> ^( type ( IDENT )+ ) | IDENT ( ',' IDENT )* ':' ARRAY '[' group '.' '.' group ']' OF type -> ^( type ^( ARRAY ( IDENT )+ ( group )+ ) ) );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}


	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _60_in_group1057 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_group1060 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_group1062 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logic_value_in_group1067 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_group1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1075 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_group1080 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_group1082 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _index__in_group1084 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_group1085 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _64_in_group1101 = new BitSet(new ulong[]{0xFC1F800000000000UL,0x1FFFEUL});
		public static readonly BitSet _charValue_in_group1103 = new BitSet(new ulong[]{0x0UL,0x1UL});
		public static readonly BitSet _64_in_group1105 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_mult1113 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _set_in_mult1117 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _group_in_mult1128 = new BitSet(new ulong[]{0x18000000000002UL});
		public static readonly BitSet _mult_in_add1140 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _set_in_add1145 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _mult_in_add1156 = new BitSet(new ulong[]{0x6000000000002UL});
		public static readonly BitSet _add_in_compare1168 = new BitSet(new ulong[]{0xFC0000000000002UL});
		public static readonly BitSet _set_in_compare1171 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _add_in_compare1198 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_div1206 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _set_in_div1208 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _compare_in_div1217 = new BitSet(new ulong[]{0xC0002UL});
		public static readonly BitSet _div_in_and_logic1224 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _AND_in_and_logic1227 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _div_in_and_logic1230 = new BitSet(new ulong[]{0x42UL});
		public static readonly BitSet _and_logic_in_or_logic1238 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _OR_in_or_logic1241 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _and_logic_in_or_logic1244 = new BitSet(new ulong[]{0x82UL});
		public static readonly BitSet _or_logic_in_term1252 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_logic_value0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_type0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_index_1289 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1298 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1300 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_simpleExpr1303 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PRINT_in_simpleExpr1307 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_simpleExpr1310 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_simpleExpr1315 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_simpleExpr1317 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _index__in_simpleExpr1319 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_simpleExpr1320 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_simpleExpr1322 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_simpleExpr1324 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _call_in_simpleExpr1349 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_charValue0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IF_in_groupExpr1428 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_groupExpr1430 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1434 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1436 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1438 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1442 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSIF_in_groupExpr1445 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1449 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_groupExpr1451 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1455 = new BitSet(new ulong[]{0x30002UL});
		public static readonly BitSet _ELSE_in_groupExpr1460 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1464 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FOR_in_groupExpr1505 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_groupExpr1507 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_groupExpr1509 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1513 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _TO_in_groupExpr1515 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1519 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1521 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1523 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WHILE_in_groupExpr1552 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_groupExpr1555 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1557 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_groupExpr1558 = new BitSet(new ulong[]{0x800000UL});
		public static readonly BitSet _DO_in_groupExpr1561 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1564 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REPEAT_in_groupExpr1568 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1571 = new BitSet(new ulong[]{0x10C1407104000UL});
		public static readonly BitSet _UNTIL_in_groupExpr1574 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_groupExpr1577 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _BEGIN_in_groupExpr1581 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_groupExpr1583 = new BitSet(new ulong[]{0x10C1C03104000UL});
		public static readonly BitSet _END_in_groupExpr1586 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_groupExpr1588 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_groupExpr1600 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_decl_in_groupExpr1603 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_const_decl1613 = new BitSet(new ulong[]{0x200000000000000UL});
		public static readonly BitSet _EQUALS_in_const_decl1616 = new BitSet(new ulong[]{0x1800000000000UL});
		public static readonly BitSet _set_in_const_decl1619 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_const_decl1626 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _CONST__in_const_1637 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _const_decl_in_const_1640 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _IDENT_in_type_decl1653 = new BitSet(new ulong[]{0x1000000000000UL,0x8010UL});
		public static readonly BitSet _79_in_type_decl1656 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1658 = new BitSet(new ulong[]{0x1000000000000UL,0x8010UL});
		public static readonly BitSet _68_in_type_decl1664 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1666 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_type_decl1678 = new BitSet(new ulong[]{0x0UL,0x8010UL});
		public static readonly BitSet _79_in_type_decl1681 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_type_decl1683 = new BitSet(new ulong[]{0x0UL,0x8010UL});
		public static readonly BitSet _68_in_type_decl1686 = new BitSet(new ulong[]{0x8000000000UL});
		public static readonly BitSet _ARRAY_in_type_decl1688 = new BitSet(new ulong[]{0x4000000000000000UL});
		public static readonly BitSet _62_in_type_decl1690 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _group_in_type_decl1692 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_type_decl1694 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_type_decl1695 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _group_in_type_decl1696 = new BitSet(new ulong[]{0x8000000000000000UL});
		public static readonly BitSet _63_in_type_decl1698 = new BitSet(new ulong[]{0x10000000000UL});
		public static readonly BitSet _OF_in_type_decl1700 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_type_decl1702 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _VAR_in_vars1727 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_vars1731 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_vars1733 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _term_in_param1744 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _param_in_params_1753 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _79_in_params_1755 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _param_in_params_1757 = new BitSet(new ulong[]{0x2UL,0x8000UL});
		public static readonly BitSet _FUNC_in_func_sign1779 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_func_sign1781 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_func_sign1783 = new BitSet(new ulong[]{0x2001000000000000UL,0x20UL});
		public static readonly BitSet _type_decl_in_func_sign1789 = new BitSet(new ulong[]{0x2001000000000000UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1792 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_func_sign1794 = new BitSet(new ulong[]{0x2001000000000000UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1800 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _VAR_in_func_sign1802 = new BitSet(new ulong[]{0x2001000000000000UL,0x20UL});
		public static readonly BitSet _type_decl_in_func_sign1806 = new BitSet(new ulong[]{0x2001000000000000UL,0x20UL});
		public static readonly BitSet _61_in_func_sign1810 = new BitSet(new ulong[]{0x0UL,0x10UL});
		public static readonly BitSet _68_in_func_sign1812 = new BitSet(new ulong[]{0x78000000UL});
		public static readonly BitSet _type_in_func_sign1814 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_sign1816 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _PROC_in_proc_sign1851 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_proc_sign1853 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_proc_sign1855 = new BitSet(new ulong[]{0x2001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1861 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1864 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1866 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1870 = new BitSet(new ulong[]{0x1000200000000UL});
		public static readonly BitSet _VAR_in_proc_sign1874 = new BitSet(new ulong[]{0x2001000200000000UL});
		public static readonly BitSet _type_decl_in_proc_sign1878 = new BitSet(new ulong[]{0x2001000200000000UL});
		public static readonly BitSet _61_in_proc_sign1882 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_sign1884 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_sign_in_func_decl1918 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_decl1921 = new BitSet(new ulong[]{0x10E1603104000UL});
		public static readonly BitSet _const__in_func_decl1924 = new BitSet(new ulong[]{0x10E1603104000UL});
		public static readonly BitSet _vars_in_func_decl1927 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _groupExpr_in_func_decl1930 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_func_decl1932 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _proc_sign_in_proc_decl1941 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_decl1944 = new BitSet(new ulong[]{0x10E1603104000UL});
		public static readonly BitSet _const__in_proc_decl1947 = new BitSet(new ulong[]{0x10E1603104000UL});
		public static readonly BitSet _vars_in_proc_decl1950 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _groupExpr_in_proc_decl1953 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_proc_decl1955 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1964 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_call1966 = new BitSet(new ulong[]{0x3001800000000030UL,0x1UL});
		public static readonly BitSet _params__in_call1968 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call1970 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_call1987 = new BitSet(new ulong[]{0x20000000000000UL});
		public static readonly BitSet _ASSIGN_in_call1989 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _IDENT_in_call1993 = new BitSet(new ulong[]{0x1000000000000000UL});
		public static readonly BitSet _60_in_call1995 = new BitSet(new ulong[]{0x3001800000000030UL,0x1UL});
		public static readonly BitSet _params__in_call1997 = new BitSet(new ulong[]{0x2000000000000000UL});
		public static readonly BitSet _61_in_call1999 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _simpleExpr_in_exprList2029 = new BitSet(new ulong[]{0x0UL,0x20UL});
		public static readonly BitSet _69_in_exprList2032 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _groupExpr_in_exprList2040 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _69_in_exprList2043 = new BitSet(new ulong[]{0x2UL,0x20UL});
		public static readonly BitSet _BEGIN_in_main_2056 = new BitSet(new ulong[]{0x10C1C03104000UL});
		public static readonly BitSet _exprList_in_main_2059 = new BitSet(new ulong[]{0x10C1C03104000UL});
		public static readonly BitSet _END_in_main_2062 = new BitSet(new ulong[]{0x0UL,0x4000UL});
		public static readonly BitSet _78_in_main_2065 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _func_decl_in_program2076 = new BitSet(new ulong[]{0x10C1403104002UL});
		public static readonly BitSet _proc_decl_in_program2079 = new BitSet(new ulong[]{0x10C1403104002UL});
		public static readonly BitSet _const__in_program2085 = new BitSet(new ulong[]{0x20200000000UL});
		public static readonly BitSet _vars_in_program2088 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _func_decl_in_program2093 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _proc_decl_in_program2095 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _vars_in_program2099 = new BitSet(new ulong[]{0x10C1603104000UL});
		public static readonly BitSet _main__in_program2102 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _program_in_result2111 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result2113 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute2132 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSIF_in_synpred54_MathLang1445 = new BitSet(new ulong[]{0x1001800000000030UL,0x1UL});
		public static readonly BitSet _term_in_synpred54_MathLang1449 = new BitSet(new ulong[]{0x8000UL});
		public static readonly BitSet _THEN_in_synpred54_MathLang1451 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_synpred54_MathLang1455 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ELSE_in_synpred55_MathLang1460 = new BitSet(new ulong[]{0x10C1403104000UL});
		public static readonly BitSet _exprList_in_synpred55_MathLang1464 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred78_MathLang1864 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _type_decl_in_synpred78_MathLang1866 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _type_decl_in_synpred80_MathLang1878 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred87_MathLang2032 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _69_in_synpred89_MathLang2043 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _vars_in_synpred95_MathLang2088 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
