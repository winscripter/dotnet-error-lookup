namespace dotnet_error_lookup.Data.Errors;

public class CS1994 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1994";
    string IErrorOrWarning.Message => @"The 'async' modifier can only be used in methods that have a body.";
    string IErrorOrWarning.Explanation => @"[original] The 'async' modifier can only be used in methods that have a body.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1994";
}
