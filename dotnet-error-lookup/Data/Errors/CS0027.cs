namespace dotnet_error_lookup.Data.Errors;

public class CS0027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0027";
    string IErrorOrWarning.Message => @"Keyword 'this' is not available in the current context";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'this' is not available in the current context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0027";
}
