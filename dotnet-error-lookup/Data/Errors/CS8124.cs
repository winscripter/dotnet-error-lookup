namespace dotnet_error_lookup.Data.Errors;

public class CS8124 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8124";
    string IErrorOrWarning.Message => @"Tuple must contain at least two elements.";
    string IErrorOrWarning.Explanation => @"[original] Tuple must contain at least two elements.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8124";
}
