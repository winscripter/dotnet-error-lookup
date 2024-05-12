namespace dotnet_error_lookup.Data.Errors;

public class CS1512 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1512";
    string IErrorOrWarning.Message => @"Keyword 'base' is not available in the current context";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'base' is not available in the current context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1512";
}
