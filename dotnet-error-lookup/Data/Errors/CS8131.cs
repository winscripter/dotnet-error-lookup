namespace dotnet_error_lookup.Data.Errors;

public class CS8131 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8131";
    string IErrorOrWarning.Message => @"Deconstruct assignment requires an expression with a type on the right-hand-side.";
    string IErrorOrWarning.Explanation => @"[original] Deconstruct assignment requires an expression with a type on the right-hand-side.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8131";
}
