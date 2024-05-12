namespace dotnet_error_lookup.Data.Errors;

public class CS8848 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8848";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be used here due to precedence. Use parentheses to disambiguate.";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be used here due to precedence. Use parentheses to disambiguate.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
