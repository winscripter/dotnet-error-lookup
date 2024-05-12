namespace dotnet_error_lookup.Data.Errors;

public class CS1986 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1986";
    string IErrorOrWarning.Message => @"'await' requires that the type {0} have a suitable 'GetAwaiter' method";
    string IErrorOrWarning.Explanation => @"[original] 'await' requires that the type {0} have a suitable 'GetAwaiter' method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1986";
}
