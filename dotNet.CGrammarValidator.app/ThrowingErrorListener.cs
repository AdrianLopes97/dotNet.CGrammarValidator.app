using Antlr4.Runtime;

namespace dotNet.CGrammarValidator.app
{
    class ThrowingErrorListener : BaseErrorListener
    {
        public static readonly ThrowingErrorListener Instance = new ThrowingErrorListener();

        public override void SyntaxError(
            TextWriter output,
            IRecognizer recognizer,
            IToken offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e)
        {
            throw new Exception($"Linha {line}:{charPositionInLine} - {msg}");
        }
    }
}
