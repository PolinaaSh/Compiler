grammar MathLang;

options {
  language=CSharp3;
  output=AST;
  backtrack = true;
}


tokens {
  TRUE	  = 'true'     ;
  FALSE   = 'false'    ;
  AND     = 'and'	   ;
  OR      = 'or '      ;
  UNKNOWN              ;
  SCOPEBLOCK           ;
  BLOCK                ;
  PROGRAM			   ;
  CONVERT              ;
  INDEX                ;
  IF      = 'if'       ;
  THEN    = 'then'     ;
  ELSE    = 'else'     ;
  ELSIF   = 'elsif'    ;
  DIV     = 'div'      ;
  MOD     = 'mod'      ;
  FOR     = 'for'      ;
  TO      = 'to'       ;
  DOWNTO  = 'downto'   ;
  DO      = 'do'       ;
  WHILE   = 'while'    ;
  REPEAT  = 'repeat'   ;
  UNTIL   = 'until'    ;
  INT     = 'integer'  ;
  REAL    = 'real'     ;
  CHAR    = 'char'     ;
  BOOL    = 'boolean'  ;
  CALL                 ;
  PARAMS               ;
  VAR     = 'var'      ;
  BEGIN   = 'begin'    ;
  END     = 'end'      ;
  PRINT   = 'print'    ;
  RINTSTR = 'printStr' ;
  INPUT   = 'input'    ;
  ARRAY   = 'array'    ;
  OF      = 'of'       ;
  CONST_  = 'const'    ;
  FUNC    = 'function' ;
  PROC    = 'procedure';
}

@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;



NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )*
;

ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIVIDE: '/'     ;
ASSIGN: ':='    ;
GE:     '>='    ;
LE:     '<='    ;
NEQUALS:'<>'    ;
EQUALS: '='     ;
GT:     '>'     ;
LT:     '<'     ;


group:
  '('! term ')'!
| logic_value
| NUMBER
| IDENT
| (IDENT '[' index_']') ->^(IDENT ^(INDEX index_))
;

mult: group ( ( MUL | DIVIDE )^ group )*  ;
add:  mult  ( ( ADD | SUB )^ mult  )*  ;
compare: add (( GE | LE | NEQUALS | EQUALS | GT | LT )^ add)?;
div: compare((DIV | MOD)^ compare)*;
and_logic:div (AND^ div)*;
or_logic: and_logic (OR^ and_logic)*;
term: or_logic;

logic_value: TRUE|FALSE ;

type: INT | REAL | BOOL |CHAR 
;

index_: IDENT|NUMBER
;

simpleExpr:
  IDENT ASSIGN^ term
| PRINT^ term
| PRINTSTR^ term
|( IDENT '[' index_']' ASSIGN term)-> ^(ASSIGN ^( IDENT ^(INDEX  index_) ) term)
| call
;

groupExpr:
 ( IF '(' t1=term ')' THEN lst=exprList (ELSIF t2=term THEN lst2=exprList)* (ELSE lst3=exprList)?)->^(IF $t1 $lst (^(ELSIF $t2 $lst2))* (^(ELSE $lst3))?)
|( FOR IDENT ASSIGN t1=term TO t2=term DO exprList)->^(FOR ^(ASSIGN IDENT $t1) ^(LT IDENT $t2) exprList)
| WHILE^ '('!term')'! DO! exprList
| REPEAT^ exprList+ UNTIL! term
| BEGIN exprList+ END ';' -> ^(BLOCK exprList+)
|func_decl
|proc_decl
;


const_decl:
 IDENT^ EQUALS! (IDENT|NUMBER) (';'!)+ 
;
const_:
CONST_^ const_decl+
;

type_decl:
 ( (IDENT (',' IDENT)*)+)':' type-> ^(type IDENT+)
| IDENT (',' IDENT)*':' ARRAY '[' group '.''.'group ']' OF type -> ^(type ^(ARRAY IDENT+ group+))
;

vars:
 VAR^ (type_decl ';'!)+
;

param: term
;

params_:
(param(',' param)*)? -> ^(PARAMS param*)
;

func_sign:
(FUNC IDENT '('( t1 =type_decl (';' type_decl)*)*(';' VAR t2=type_decl*)*')' ':' type ';')-> ^(FUNC type IDENT ^(PARAMS $t1* ^(VAR $t2)*))
;

proc_sign:
(PROC IDENT '('(( t1=type_decl (';' type_decl)* ';')* VAR t2=type_decl*)*')' ';')-> ^(PROC IDENT ^(PARAMS  $t1*  ^(VAR $t2)*))
;

func_decl:
func_sign^ ';'! const_* vars* groupExpr ';'!
;

proc_decl:
proc_sign^ ';'! const_* vars* groupExpr ';'!
;

call:
IDENT '(' params_ ')' -> ^(CALL IDENT params_)
| (i1=IDENT ASSIGN i2=IDENT '(' params_ ')') ->^(ASSIGN $i1 ^(CALL $i2 params_))
;

exprList: 
 ( simpleExpr (';'!)+ 
| groupExpr (';'!)*
)
;

main_:
BEGIN^ exprList* END! '.'!
;

program: ( func_decl* proc_decl*)
|(const_* vars+  (func_decl|proc_decl)* vars* main_)
;

result: program EOF -> ^(PROGRAM program);

public execute:
  result
;
