namespace dotnet_error_lookup.Data.Errors;

public class CS1946 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1946";
    string IErrorOrWarning.Message => @"An anonymous method expression cannot be converted to an expression tree";
    string IErrorOrWarning.Explanation => @"[original] An anonymous method expression cannot be converted to an expression tree";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1946";
}
