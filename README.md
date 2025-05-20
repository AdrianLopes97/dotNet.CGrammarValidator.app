# dotNet.CGrammarValidator.app

Este projeto é um validador de gramática C.
Foi criado como parte de uma atividade avaliativa da AP2 para ULBRA - Compiladores

## Como usar

1. Clone o repositório.
2. Abra o projeto no Visual Studio ou sua IDE C# preferida.
3. Compile e execute o projeto. (versão do .net 8)
4. Forneça um arquivo de código C como entrada para validar sua gramática.

## Arquivos ANTLR

A gramática C é definida nos arquivos `.g4` localizados no diretório `ANTLR/`.

- `Assignment.g4`: Contém as regras da gramática.

## Gerando arquivos C# a partir da gramática ANTLR

Se você modificar o arquivo `Assignment.g4` ou adicionar uma nova gramática, você precisará gerar novamente os arquivos C# correspondentes. Siga estas etapas:

1.  **Configure o ANTLR:**
    *   Certifique-se de ter o Java Development Kit (JDK) instalado.
    *   Baixe o ANTLR Complete JAR (por exemplo, `antlr-4.13.2-complete.jar`) do [site oficial do ANTLR](https://www.antlr.org/download.html).
    *   Adicione o JAR do ANTLR ao seu CLASSPATH ou coloque-o em um diretório conhecido.
    *   Crie aliases ou scripts para facilitar a execução do ANTLR. Por exemplo, em PowerShell:
        ```powershell
        function antlr4 { java -jar /path/to/your/antlr-4.13.2-complete.jar $args }
        function grun { java -cp ".;/path/to/your/antlr-4.13.2-complete.jar" org.antlr.v4.gui.TestRig $args }
        ```
        Substitua `/path/to/your/` pelo caminho real onde você salvou o JAR.

2.  **Navegue até o diretório da gramática:**
    Abra um terminal ou prompt de comando e navegue até o diretório que contém o arquivo `.g4`:
    ```powershell
    cd c:\work\my-projects\ulbra\compiladores\dotNet.CGrammarValidator.app\dotNet.CGrammarValidator.app\ANTLR
    ```

3.  **Exclua os arquivos gerados anteriormente:**
    Antes de gerar os novos arquivos, é uma boa prática excluir os antigos para evitar conflitos. Os arquivos a serem excluídos neste projeto (se existirem) são:
    *   `AssignmentLexer.cs`
    *   `AssignmentParser.cs`
    *   `AssignmentListener.cs`
    *   `AssignmentBaseListener.cs`
    *   `Assignment.tokens`
    *   `AssignmentLexer.tokens`
    *   `Assignment.interp`
    *   `AssignmentLexer.interp`

4.  **Execute o ANTLR para gerar os arquivos C#:**
    Use o seguinte comando para gerar o lexer, parser e listener em C#:
    ```powershell
    antlr4 -Dlanguage=CSharp -o . Assignment.g4
    ```
    *   `-Dlanguage=CSharp`: Especifica a linguagem de destino como C#.
    *   `-o .`: Especifica o diretório de saída como o diretório atual.
    *   `Assignment.g4`: É o arquivo de gramática de entrada.

    Se você precisar de um visitor em vez de um listener (ou além dele), adicione a flag `-visitor`:
    ```powershell
    antlr4 -Dlanguage=CSharp -visitor -listener -o . Assignment.g4
    ```

5.  **Inclua os novos arquivos no projeto:**
    Após a geração, certifique-se de que os novos arquivos `.cs` estejam incluídos no seu projeto `.csproj` se eles não forem automaticamente detectados pela sua IDE.

## Resultados da Validação

A seguir estão os resultados obtidos ao validar o arquivo `ANTLR/AssignmentTestCases.txt` com a gramática `Assignment.g4` atual:

```
Linha 0: int a = 5;
Válida
(assignment (type int) a = (expr 5) ;)
```
**Explicação:** A atribuição `int a = 5;` é sintaticamente válida.
**Árvore de Análise Sintática:**
*   `assignment`: Representa a regra de atribuição completa.
*   `type int`: Indica que o tipo da variável é `int`.
*   `a`: É o identificador (nome) da variável.
*   `=`: É o operador de atribuição.
*   `expr 5`: Representa a expressão atribuída, que neste caso é o número `5`.
*   `;`: Marca o final da instrução de atribuição.

```
Linha 1: float z = 3.14 * r;
Válida
(assignment (type float) z = (expr (expr 3.14) * (expr r)) ;)
```
**Explicação:** A atribuição `float z = 3.14 * r;` é sintaticamente válida.
**Árvore de Análise Sintática:**
*   `assignment`: Representa a regra de atribuição.
*   `type float`: Indica que o tipo da variável é `float`.
*   `z`: É o identificador da variável.
*   `=`: Operador de atribuição.
*   `expr (expr 3.14) * (expr r)`: Representa a expressão de multiplicação.
    *   `expr 3.14`: O primeiro operando é o número `3.14`.
    *   `*`: O operador de multiplicação.
    *   `expr r`: O segundo operando é o identificador `r` (presumivelmente uma variável).
*   `;`: Marca o final da instrução.

```
Linha 2: char c = 'x';
Válida
(assignment (type char) c = (expr 'x') ;)
```
**Explicação:** A atribuição `char c = 'x';` é sintaticamente válida.
**Árvore de Análise Sintática:**
*   `assignment`: Representa a regra de atribuição.
*   `type char`: Indica que o tipo da variável é `char`.
*   `c`: É o identificador da variável.
*   `=`: Operador de atribuição.
*   `expr 'x'`: Representa a expressão atribuída, o caractere `'x'`.
*   `;`: Marca o final da instrução.

```
Linha 3: char c = x;
Válida
(assignment (type char) c = (expr x) ;)
```
**Explicação:** A atribuição `char c = x;` é sintaticamente válida. Assume-se que `x` é um identificador de uma variável previamente declarada e compatível com o tipo `char`.
**Árvore de Análise Sintática:**
*   `assignment`: Representa a regra de atribuição.
*   `type char`: Indica que o tipo da variável é `char`.
*   `c`: É o identificador da variável que está sendo declarada e atribuída.
*   `=`: Operador de atribuição.
*   `expr x`: Representa a expressão atribuída, que é o valor do identificador `x`.
*   `;`: Marca o final da instrução.

```
Linha 4: int 1x = 5;
Inválida: Linha 1:4 - extraneous input '1' expecting ID
```
**Explicação:** A declaração `int 1x = 5;` é inválida porque um identificador de variável (neste caso, `1x`) não pode começar com um dígito. A gramática espera um `ID` (identificador válido) após a palavra-chave `int`, mas encontrou `1`.

```
Linha 5: float = 3.14;
Inválida: Linha 1:6 - missing ID at '='
```
**Explicação:** A declaração `float = 3.14;` é inválida porque falta o identificador (nome da variável) antes do operador de atribuição `=`. A gramática espera um `ID` após a palavra-chave `float`.

```
Linha 6: int a = 5 + ;
Inválida: Linha 1:12 - mismatched input ';' expecting {'(', ID, NUMBER, CHAR}
```
**Explicação:** A atribuição `int a = 5 + ;` é inválida porque a expressão à direita do operador `+` está incompleta. A gramática esperava um operando (como um `ID`, `NUMBER`, `CHAR` ou uma sub-expressão entre parênteses `'(' expr ')'`) após o `+`, mas encontrou o terminador de instrução `;`.
