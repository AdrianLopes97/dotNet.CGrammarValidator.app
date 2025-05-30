//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Assignment.g4 by ANTLR 4.13.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.2")]
[System.CLSCompliant(false)]
public partial class AssignmentParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, ID=12, NUMBER=13, CHAR=14, WS=15;
	public const int
		RULE_assignment = 0, RULE_type = 1, RULE_expr = 2;
	public static readonly string[] ruleNames = {
		"assignment", "type", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "'='", "';'", "'int'", "'float'", "'char'", "'*'", "'/'", "'+'", 
		"'-'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"ID", "NUMBER", "CHAR", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Assignment.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static AssignmentParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public AssignmentParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public AssignmentParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class AssignmentContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TypeContext type() {
			return GetRuleContext<TypeContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(AssignmentParser.ID, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public AssignmentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_assignment; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterAssignment(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitAssignment(this);
		}
	}

	[RuleVersion(0)]
	public AssignmentContext assignment() {
		AssignmentContext _localctx = new AssignmentContext(Context, State);
		EnterRule(_localctx, 0, RULE_assignment);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 6;
			type();
			State = 7;
			Match(ID);
			State = 8;
			Match(T__0);
			State = 9;
			expr(0);
			State = 10;
			Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeContext : ParserRuleContext {
		public TypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterType(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitType(this);
		}
	}

	[RuleVersion(0)]
	public TypeContext type() {
		TypeContext _localctx = new TypeContext(Context, State);
		EnterRule(_localctx, 2, RULE_type);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & 56L) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MulDivExprContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public MulDivExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterMulDivExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitMulDivExpr(this);
		}
	}
	public partial class IdExprContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ID() { return GetToken(AssignmentParser.ID, 0); }
		public IdExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterIdExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitIdExpr(this);
		}
	}
	public partial class NumberExprContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NUMBER() { return GetToken(AssignmentParser.NUMBER, 0); }
		public NumberExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterNumberExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitNumberExpr(this);
		}
	}
	public partial class ParenExprContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ParenExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterParenExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitParenExpr(this);
		}
	}
	public partial class AddSubExprContext : ExprContext {
		public IToken op;
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public AddSubExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterAddSubExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitAddSubExpr(this);
		}
	}
	public partial class CharExprContext : ExprContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CHAR() { return GetToken(AssignmentParser.CHAR, 0); }
		public CharExprContext(ExprContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.EnterCharExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IAssignmentListener typedListener = listener as IAssignmentListener;
			if (typedListener != null) typedListener.ExitCharExpr(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 4;
		EnterRecursionRule(_localctx, 4, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 22;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case ID:
				{
				_localctx = new IdExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 15;
				Match(ID);
				}
				break;
			case NUMBER:
				{
				_localctx = new NumberExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 16;
				Match(NUMBER);
				}
				break;
			case CHAR:
				{
				_localctx = new CharExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 17;
				Match(CHAR);
				}
				break;
			case T__9:
				{
				_localctx = new ParenExprContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 18;
				Match(T__9);
				State = 19;
				expr(0);
				State = 20;
				Match(T__10);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 32;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 30;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new MulDivExprContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 24;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 25;
						((MulDivExprContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__5 || _la==T__6) ) {
							((MulDivExprContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 26;
						expr(7);
						}
						break;
					case 2:
						{
						_localctx = new AddSubExprContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 27;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 28;
						((AddSubExprContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__7 || _la==T__8) ) {
							((AddSubExprContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 29;
						expr(6);
						}
						break;
					}
					} 
				}
				State = 34;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 2: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 6);
		case 1: return Precpred(Context, 5);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,15,36,2,0,7,0,2,1,7,1,2,2,7,2,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,2,
		1,2,1,2,1,2,1,2,1,2,1,2,1,2,3,2,23,8,2,1,2,1,2,1,2,1,2,1,2,1,2,5,2,31,
		8,2,10,2,12,2,34,9,2,1,2,0,1,4,3,0,2,4,0,3,1,0,3,5,1,0,6,7,1,0,8,9,37,
		0,6,1,0,0,0,2,12,1,0,0,0,4,22,1,0,0,0,6,7,3,2,1,0,7,8,5,12,0,0,8,9,5,1,
		0,0,9,10,3,4,2,0,10,11,5,2,0,0,11,1,1,0,0,0,12,13,7,0,0,0,13,3,1,0,0,0,
		14,15,6,2,-1,0,15,23,5,12,0,0,16,23,5,13,0,0,17,23,5,14,0,0,18,19,5,10,
		0,0,19,20,3,4,2,0,20,21,5,11,0,0,21,23,1,0,0,0,22,14,1,0,0,0,22,16,1,0,
		0,0,22,17,1,0,0,0,22,18,1,0,0,0,23,32,1,0,0,0,24,25,10,6,0,0,25,26,7,1,
		0,0,26,31,3,4,2,7,27,28,10,5,0,0,28,29,7,2,0,0,29,31,3,4,2,6,30,24,1,0,
		0,0,30,27,1,0,0,0,31,34,1,0,0,0,32,30,1,0,0,0,32,33,1,0,0,0,33,5,1,0,0,
		0,34,32,1,0,0,0,3,22,30,32
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
