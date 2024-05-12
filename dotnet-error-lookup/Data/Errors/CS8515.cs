namespace dotnet_error_lookup.Data.Errors;

public class CS8515 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8515";
    string IErrorOrWarning.Message => @"Parentheses are required around the switch governing expression.";
    string IErrorOrWarning.Explanation => @"[original] Parentheses are required around the switch governing expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8515";
}
