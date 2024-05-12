namespace dotnet_error_lookup.Data.Errors;

public class CS0821 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0821";
    string IErrorOrWarning.Message => @"Implicitly-typed local variables cannot be fixed";
    string IErrorOrWarning.Explanation => @"[original] Implicitly-typed local variables cannot be fixed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs0821";
}
