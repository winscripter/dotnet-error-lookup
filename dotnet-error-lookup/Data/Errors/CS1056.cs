namespace dotnet_error_lookup.Data.Errors;

public class CS1056 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1056";
    string IErrorOrWarning.Message => @"Unexpected character '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Unexpected character '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1056";
}
