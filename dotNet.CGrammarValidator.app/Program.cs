using Antlr4.Runtime;
using dotNet.CGrammarValidator.app;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma linha de atribuição (ex: int x = 5 + y;):");
        var input = Console.ReadLine();

        if (input == null) 
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        AntlrInputStream inputStream = new AntlrInputStream(input);
        AssignmentLexer lexer = new AssignmentLexer(inputStream);
        CommonTokenStream tokenStream = new CommonTokenStream(lexer);
        AssignmentParser parser = new AssignmentParser(tokenStream);

        // Configura o listener de erro para lançar exceções
        parser.RemoveErrorListeners();
        parser.AddErrorListener(new ThrowingErrorListener());

        try
        {
            var tree = parser.assignment();
            Console.WriteLine("Atribuição válida!");
            Console.WriteLine(tree.ToStringTree(parser));
        }
        catch (Exception e)
        {
            Console.WriteLine("Atribuição inválida: " + e.Message);
        }
    }
}
