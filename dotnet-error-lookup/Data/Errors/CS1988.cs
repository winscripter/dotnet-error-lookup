namespace dotnet_error_lookup.Data.Errors;

public class CS1988 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1988";
    string IErrorOrWarning.Message => @"Async methods cannot have ref, in or out parameters";
    string IErrorOrWarning.Explanation => @"[original] Async methods cannot have ref, in or out parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1988";
}
