namespace dotnet_error_lookup.Data.Errors;

public class CS1039 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1039";
    string IErrorOrWarning.Message => @"Unterminated string literal";
    string IErrorOrWarning.Explanation => @"[original] Unterminated string literal";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1039";
}
