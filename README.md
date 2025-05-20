# dotNet.CGrammarValidator.app

Este projeto é um validador de gramática C.

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
