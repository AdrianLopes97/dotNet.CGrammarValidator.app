grammar Assignment;

// Regras sintáticas
assignment : type ID '=' expr ';' ;

type : 'int' | 'float' | 'char' ;

expr : expr op=('*'|'/') expr     # MulDivExpr
     | expr op=('+'|'-') expr     # AddSubExpr
     | ID                         # IdExpr
     | NUMBER                     # NumberExpr
     | CHAR                       # CharExpr
     | '(' expr ')'               # ParenExpr
     ;

// Tokens
ID     : [a-zA-Z_][a-zA-Z_0-9]* ;
NUMBER : [0-9]+ ('.' [0-9]+)? ;
CHAR   : '\'' . '\'' ;
WS     : [ \t\r\n]+ -> skip ;
