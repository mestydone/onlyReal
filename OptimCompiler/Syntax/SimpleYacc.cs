// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  DESKTOP-KO2BEQ3
// DateTime: 06.05.2019 10:35:12
// UserName: 1
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using ProgramTree;

namespace SimpleParser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,ASSIGN=5,SEMICOLON=6,
    WHILE=7,FOR=8,TO=9,PRINTLN=10,LPAREN=11,RPAREN=12,
    IF=13,THEN=14,ELSE=15,COLUMN=16,ADD=17,SUB=18,
    MULT=19,DIV=20,LOGIC_AND=21,LOGIC_OR=22,LOGIC_NOT=23,TRUE=24,
    FALSE=25,EQUALS=26,GTHAN=27,LTHAN=28,GEQ=29,LEQ=30,
    NEQ=31,TINT=32,TREAL=33,TBOOL=34,INUM=35,RNUM=36,
    ID=37};

public struct ValueType
{ 
            public double dVal; 
            public int iVal; 
            public string sVal; 
            public Node nVal;
            public ExprNode eVal;
            public StatementNode stVal;
            public BlockNode blVal;
			public type tVal;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
// ��� ���������� ����������� � ����� GPPGParser, �������������� ����� ������, ������������ �������� gppg
    public BlockNode root; // �������� ���� ��������������� ������ 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
	private bool InDefSect = false;
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[51];
  private static State[] states = new State[93];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "LT", "LF", "E", "T", "F", "assign", "statement", "while", 
      "for", "println", "if", "var", "varlist", "stlist", "block", "type_", "progr", 
      "$accept", "Anon@1", };

  static Parser() {
    states[0] = new State(new int[]{3,4},new int[]{-19,1,-17,3});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(-3,new int[]{-16,5});
    states[5] = new State(new int[]{4,6,37,24,7,54,8,60,10,69,13,74,32,89,33,90,34,91,3,4},new int[]{-9,7,-8,8,-2,10,-10,53,-11,59,-12,67,-13,73,-14,81,-18,83,-17,92});
    states[6] = new State(-48);
    states[7] = new State(-4);
    states[8] = new State(new int[]{6,9});
    states[9] = new State(-5);
    states[10] = new State(new int[]{5,11});
    states[11] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,12,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[12] = new State(new int[]{26,13,27,32,28,44,29,46,30,48,31,50,6,-14,9,-14});
    states[13] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,14,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[14] = new State(new int[]{22,15,26,-23,27,-23,28,-23,29,-23,30,-23,31,-23,6,-23,9,-23,12,-23});
    states[15] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-4,16,-5,35,-6,43,-7,40,-2,23});
    states[16] = new State(new int[]{21,17,22,-30,26,-30,27,-30,28,-30,29,-30,30,-30,31,-30,6,-30,9,-30,12,-30});
    states[17] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-5,18,-6,43,-7,40,-2,23});
    states[18] = new State(new int[]{17,19,18,36,21,-32,22,-32,26,-32,27,-32,28,-32,29,-32,30,-32,31,-32,6,-32,9,-32,12,-32});
    states[19] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-6,20,-7,40,-2,23});
    states[20] = new State(new int[]{19,21,20,38,17,-34,18,-34,21,-34,22,-34,26,-34,27,-34,28,-34,29,-34,30,-34,31,-34,6,-34,9,-34,12,-34});
    states[21] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29},new int[]{-7,22,-2,23});
    states[22] = new State(-37);
    states[23] = new State(-40);
    states[24] = new State(-12);
    states[25] = new State(-41);
    states[26] = new State(-42);
    states[27] = new State(-43);
    states[28] = new State(-44);
    states[29] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,30,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[30] = new State(new int[]{12,31,26,13,27,32,28,44,29,46,30,48,31,50});
    states[31] = new State(-45);
    states[32] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,33,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[33] = new State(new int[]{22,15,26,-24,27,-24,28,-24,29,-24,30,-24,31,-24,6,-24,9,-24,12,-24});
    states[34] = new State(new int[]{21,17,22,-29,26,-29,27,-29,28,-29,29,-29,30,-29,31,-29,6,-29,9,-29,12,-29});
    states[35] = new State(new int[]{17,19,18,36,21,-31,22,-31,26,-31,27,-31,28,-31,29,-31,30,-31,31,-31,6,-31,9,-31,12,-31});
    states[36] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-6,37,-7,40,-2,23});
    states[37] = new State(new int[]{19,21,20,38,17,-35,18,-35,21,-35,22,-35,26,-35,27,-35,28,-35,29,-35,30,-35,31,-35,6,-35,9,-35,12,-35});
    states[38] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29},new int[]{-7,39,-2,23});
    states[39] = new State(-38);
    states[40] = new State(-36);
    states[41] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29},new int[]{-7,42,-2,23});
    states[42] = new State(-39);
    states[43] = new State(new int[]{19,21,20,38,17,-33,18,-33,21,-33,22,-33,26,-33,27,-33,28,-33,29,-33,30,-33,31,-33,6,-33,9,-33,12,-33});
    states[44] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,45,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[45] = new State(new int[]{22,15,26,-25,27,-25,28,-25,29,-25,30,-25,31,-25,6,-25,9,-25,12,-25});
    states[46] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,47,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[47] = new State(new int[]{22,15,26,-26,27,-26,28,-26,29,-26,30,-26,31,-26,6,-26,9,-26,12,-26});
    states[48] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,49,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[49] = new State(new int[]{22,15,26,-27,27,-27,28,-27,29,-27,30,-27,31,-27,6,-27,9,-27,12,-27});
    states[50] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-3,51,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[51] = new State(new int[]{22,15,26,-28,27,-28,28,-28,29,-28,30,-28,31,-28,6,-28,9,-28,12,-28});
    states[52] = new State(new int[]{22,15,26,-22,27,-22,28,-22,29,-22,30,-22,31,-22,6,-22,9,-22,12,-22});
    states[53] = new State(-6);
    states[54] = new State(new int[]{11,55});
    states[55] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,56,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[56] = new State(new int[]{12,57,26,13,27,32,28,44,29,46,30,48,31,50});
    states[57] = new State(new int[]{37,24,7,54,8,60,10,69,13,74,32,89,33,90,34,91,3,4},new int[]{-9,58,-8,8,-2,10,-10,53,-11,59,-12,67,-13,73,-14,81,-18,83,-17,92});
    states[58] = new State(-49);
    states[59] = new State(-7);
    states[60] = new State(new int[]{11,61});
    states[61] = new State(new int[]{37,24},new int[]{-8,62,-2,10});
    states[62] = new State(new int[]{9,63});
    states[63] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,64,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[64] = new State(new int[]{12,65,26,13,27,32,28,44,29,46,30,48,31,50});
    states[65] = new State(new int[]{37,24,7,54,8,60,10,69,13,74,32,89,33,90,34,91,3,4},new int[]{-9,66,-8,8,-2,10,-10,53,-11,59,-12,67,-13,73,-14,81,-18,83,-17,92});
    states[66] = new State(-50);
    states[67] = new State(new int[]{6,68});
    states[68] = new State(-8);
    states[69] = new State(new int[]{11,70});
    states[70] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,71,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[71] = new State(new int[]{12,72,26,13,27,32,28,44,29,46,30,48,31,50});
    states[72] = new State(-13);
    states[73] = new State(-9);
    states[74] = new State(new int[]{11,75});
    states[75] = new State(new int[]{37,24,35,25,36,26,24,27,25,28,11,29,23,41},new int[]{-1,76,-3,52,-4,34,-5,35,-6,43,-7,40,-2,23});
    states[76] = new State(new int[]{12,77,26,13,27,32,28,44,29,46,30,48,31,50});
    states[77] = new State(new int[]{37,24,7,54,8,60,10,69,13,74,32,89,33,90,34,91,3,4},new int[]{-9,78,-8,8,-2,10,-10,53,-11,59,-12,67,-13,73,-14,81,-18,83,-17,92});
    states[78] = new State(new int[]{15,79,4,-46,37,-46,7,-46,8,-46,10,-46,13,-46,32,-46,33,-46,34,-46,3,-46});
    states[79] = new State(new int[]{37,24,7,54,8,60,10,69,13,74,32,89,33,90,34,91,3,4},new int[]{-9,80,-8,8,-2,10,-10,53,-11,59,-12,67,-13,73,-14,81,-18,83,-17,92});
    states[80] = new State(-47);
    states[81] = new State(new int[]{6,82});
    states[82] = new State(-10);
    states[83] = new State(-18,new int[]{-21,84});
    states[84] = new State(new int[]{37,24},new int[]{-15,85,-2,88});
    states[85] = new State(new int[]{16,86,6,-19});
    states[86] = new State(new int[]{37,24},new int[]{-2,87});
    states[87] = new State(-21);
    states[88] = new State(-20);
    states[89] = new State(-15);
    states[90] = new State(-16);
    states[91] = new State(-17);
    states[92] = new State(-11);

    rules[1] = new Rule(-20, new int[]{-19,2});
    rules[2] = new Rule(-19, new int[]{-17});
    rules[3] = new Rule(-16, new int[]{});
    rules[4] = new Rule(-16, new int[]{-16,-9});
    rules[5] = new Rule(-9, new int[]{-8,6});
    rules[6] = new Rule(-9, new int[]{-10});
    rules[7] = new Rule(-9, new int[]{-11});
    rules[8] = new Rule(-9, new int[]{-12,6});
    rules[9] = new Rule(-9, new int[]{-13});
    rules[10] = new Rule(-9, new int[]{-14,6});
    rules[11] = new Rule(-9, new int[]{-17});
    rules[12] = new Rule(-2, new int[]{37});
    rules[13] = new Rule(-12, new int[]{10,11,-1,12});
    rules[14] = new Rule(-8, new int[]{-2,5,-1});
    rules[15] = new Rule(-18, new int[]{32});
    rules[16] = new Rule(-18, new int[]{33});
    rules[17] = new Rule(-18, new int[]{34});
    rules[18] = new Rule(-21, new int[]{});
    rules[19] = new Rule(-14, new int[]{-18,-21,-15});
    rules[20] = new Rule(-15, new int[]{-2});
    rules[21] = new Rule(-15, new int[]{-15,16,-2});
    rules[22] = new Rule(-1, new int[]{-3});
    rules[23] = new Rule(-1, new int[]{-1,26,-3});
    rules[24] = new Rule(-1, new int[]{-1,27,-3});
    rules[25] = new Rule(-1, new int[]{-1,28,-3});
    rules[26] = new Rule(-1, new int[]{-1,29,-3});
    rules[27] = new Rule(-1, new int[]{-1,30,-3});
    rules[28] = new Rule(-1, new int[]{-1,31,-3});
    rules[29] = new Rule(-3, new int[]{-4});
    rules[30] = new Rule(-3, new int[]{-3,22,-4});
    rules[31] = new Rule(-4, new int[]{-5});
    rules[32] = new Rule(-4, new int[]{-4,21,-5});
    rules[33] = new Rule(-5, new int[]{-6});
    rules[34] = new Rule(-5, new int[]{-5,17,-6});
    rules[35] = new Rule(-5, new int[]{-5,18,-6});
    rules[36] = new Rule(-6, new int[]{-7});
    rules[37] = new Rule(-6, new int[]{-6,19,-7});
    rules[38] = new Rule(-6, new int[]{-6,20,-7});
    rules[39] = new Rule(-6, new int[]{23,-7});
    rules[40] = new Rule(-7, new int[]{-2});
    rules[41] = new Rule(-7, new int[]{35});
    rules[42] = new Rule(-7, new int[]{36});
    rules[43] = new Rule(-7, new int[]{24});
    rules[44] = new Rule(-7, new int[]{25});
    rules[45] = new Rule(-7, new int[]{11,-1,12});
    rules[46] = new Rule(-13, new int[]{13,11,-1,12,-9});
    rules[47] = new Rule(-13, new int[]{13,11,-1,12,-9,15,-9});
    rules[48] = new Rule(-17, new int[]{3,-16,4});
    rules[49] = new Rule(-10, new int[]{7,11,-1,12,-9});
    rules[50] = new Rule(-11, new int[]{8,11,-8,9,-1,12,-9});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> block
{ root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> /* empty */
{ 
                CurrentSemanticValue.blVal = new BlockNode(); 
            }
        break;
      case 4: // stlist -> stlist, statement
{ 
                ValueStack[ValueStack.Depth-2].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
                CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; 
            }
        break;
      case 5: // statement -> assign, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 6: // statement -> while
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 7: // statement -> for
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 8: // statement -> println, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 9: // statement -> if
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 10: // statement -> var, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 11: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 12: // ident -> ID
{
				CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal);
                if (!InDefSect)
				{
                    if (!SymbolTable.vars.ContainsKey(ValueStack[ValueStack.Depth-1].sVal))
                        throw new Exception("("+LocationStack[LocationStack.Depth-1].StartLine+","+LocationStack[LocationStack.Depth-1].StartColumn+"): ���������� "+ValueStack[ValueStack.Depth-1].sVal+" �� �������");
					CurrentSemanticValue.eVal.Type = SymbolTable.vars[ValueStack[ValueStack.Depth-1].sVal];
                }
            }
        break;
      case 13: // println -> PRINTLN, LPAREN, expr, RPAREN
{ CurrentSemanticValue.stVal = new PrintlnNode(ValueStack[ValueStack.Depth-2].eVal); }
        break;
      case 14: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal, LocationStack[LocationStack.Depth-1]); }
        break;
      case 15: // type_ -> TINT
{ CurrentSemanticValue.tVal = type.tint; }
        break;
      case 16: // type_ -> TREAL
{ CurrentSemanticValue.tVal = type.treal; }
        break;
      case 17: // type_ -> TBOOL
{ CurrentSemanticValue.tVal = type.tbool; }
        break;
      case 18: // Anon@1 -> /* empty */
{ InDefSect = true; }
        break;
      case 19: // var -> type_, Anon@1, varlist
{ 
			foreach (var v in (ValueStack[ValueStack.Depth-1].stVal as VarDefNode).vars)
			{
				SymbolTable.NewVarDef(v.Name, ValueStack[ValueStack.Depth-3].tVal);
				v.Type = ValueStack[ValueStack.Depth-3].tVal;
			}
			CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal;
			InDefSect = false;	
		}
        break;
      case 20: // varlist -> ident
{ 
			CurrentSemanticValue.stVal = new VarDefNode(ValueStack[ValueStack.Depth-1].eVal as IdNode); 
		}
        break;
      case 21: // varlist -> varlist, COLUMN, ident
{ 
			(ValueStack[ValueStack.Depth-3].stVal as VarDefNode).Add(ValueStack[ValueStack.Depth-1].eVal as IdNode);
			CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-3].stVal;
		}
        break;
      case 22: // expr -> LT
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 23: // expr -> expr, EQUALS, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "==", LocationStack[LocationStack.Depth-2]); }
        break;
      case 24: // expr -> expr, GTHAN, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, ">", LocationStack[LocationStack.Depth-2]); }
        break;
      case 25: // expr -> expr, LTHAN, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "<", LocationStack[LocationStack.Depth-2]); }
        break;
      case 26: // expr -> expr, GEQ, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, ">=", LocationStack[LocationStack.Depth-2]); }
        break;
      case 27: // expr -> expr, LEQ, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "<=", LocationStack[LocationStack.Depth-2]); }
        break;
      case 28: // expr -> expr, NEQ, LT
{ CurrentSemanticValue.eVal = new LogicOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "!=", LocationStack[LocationStack.Depth-2]); }
        break;
      case 29: // LT -> LF
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 30: // LT -> LT, LOGIC_OR, LF
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "||", LocationStack[LocationStack.Depth-2]); }
        break;
      case 31: // LF -> E
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 32: // LF -> LF, LOGIC_AND, E
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "&&", LocationStack[LocationStack.Depth-2]); }
        break;
      case 33: // E -> T
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 34: // E -> E, ADD, T
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "+"/*SimpleParser.Tokens.ADD*/, LocationStack[LocationStack.Depth-2]); }
        break;
      case 35: // E -> E, SUB, T
{ CurrentSemanticValue.eVal = new BinOpNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "-"/*SimpleParser.Tokens.SUB*/, LocationStack[LocationStack.Depth-2]); }
        break;
      case 36: // T -> F
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 37: // T -> T, MULT, F
{ CurrentSemanticValue.eVal = new BinOpNode ( ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "*"/*SimpleParser.Tokens.MULT*/, LocationStack[LocationStack.Depth-2]); }
        break;
      case 38: // T -> T, DIV, F
{ CurrentSemanticValue.eVal = new BinOpNode (ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "/"/*SimpleParser.Tokens.DIV*/, LocationStack[LocationStack.Depth-2]); }
        break;
      case 39: // T -> LOGIC_NOT, F
{ CurrentSemanticValue.eVal = new LogicNotNode(ValueStack[ValueStack.Depth-1].eVal, LocationStack[LocationStack.Depth-2]); }
        break;
      case 40: // F -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 41: // F -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 42: // F -> RNUM
{ CurrentSemanticValue.eVal = new DoubleNumNode(ValueStack[ValueStack.Depth-1].dVal); }
        break;
      case 43: // F -> TRUE
{ CurrentSemanticValue.eVal = new BooleanNode(true); }
        break;
      case 44: // F -> FALSE
{ CurrentSemanticValue.eVal = new BooleanNode(false); }
        break;
      case 45: // F -> LPAREN, expr, RPAREN
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal as ExprNode; }
        break;
      case 46: // if -> IF, LPAREN, expr, RPAREN, statement
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 47: // if -> IF, LPAREN, expr, RPAREN, statement, ELSE, statement
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].stVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 48: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 49: // while -> WHILE, LPAREN, expr, RPAREN, statement
{ CurrentSemanticValue.stVal = new WhileNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 50: // for -> FOR, LPAREN, assign, TO, expr, RPAREN, statement
{ CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-5].stVal as AssignNode, ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].stVal); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
