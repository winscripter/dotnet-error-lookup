namespace dotnet_error_lookup.Data.Errors;

public class CS9043 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9043";
    string IErrorOrWarning.Message => @"Ref returning properties cannot be required.";
    string IErrorOrWarning.Explanation => @"[original] Ref returning properties cannot be required.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs9043";
}
