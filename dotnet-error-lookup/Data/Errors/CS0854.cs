namespace dotnet_error_lookup.Data.Errors;

public class CS0854 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0854";
    string IErrorOrWarning.Message => @"An expression tree may not contain a call or invocation that uses optional arguments";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a call or invocation that uses optional arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0854";
}
