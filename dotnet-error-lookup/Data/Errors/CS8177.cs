namespace dotnet_error_lookup.Data.Errors;

public class CS8177 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8177";
    string IErrorOrWarning.Message => @"Async methods cannot have by-reference locals";
    string IErrorOrWarning.Explanation => @"[original] Async methods cannot have by-reference locals";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8177";
}
