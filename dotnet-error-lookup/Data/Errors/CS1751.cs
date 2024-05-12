namespace dotnet_error_lookup.Data.Errors;

public class CS1751 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1751";
    string IErrorOrWarning.Message => @"Cannot specify a default value for a parameter array";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify a default value for a parameter array";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1751";
}
