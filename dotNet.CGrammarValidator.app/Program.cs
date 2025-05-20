using Antlr4.Runtime;
using dotNet.CGrammarValidator.app;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = Path.Combine("ANTLR", "AssignmentTestCases.txt");

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Arquivo não encontrado: {filePath}");
            return;
        }

        var lines = File.ReadAllLines(filePath);
        int lineNumber = 0;

        foreach (var rawLine in lines)
        {
            var input = rawLine.Trim();

            // Ignora linhas em branco e comentários
            if (string.IsNullOrWhiteSpace(input) || input.StartsWith("#"))
                continue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Linha {lineNumber}: {input}");

            AntlrInputStream inputStream = new AntlrInputStream(input);
            AssignmentLexer lexer = new AssignmentLexer(inputStream);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            AssignmentParser parser = new AssignmentParser(tokenStream);

            parser.RemoveErrorListeners();
            parser.AddErrorListener(ThrowingErrorListener.Instance);

            try
            {
                var tree = parser.assignment();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Válida");
                Console.WriteLine(tree.ToStringTree(parser));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Inválida: " + e.Message);
            }
            lineNumber++;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
