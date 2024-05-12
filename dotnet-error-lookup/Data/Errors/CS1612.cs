namespace dotnet_error_lookup.Data.Errors;

public class CS1612 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1612";
    string IErrorOrWarning.Message => @"Cannot modify the return value of '{0}' because it is not a variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot modify the return value of '{0}' because it is not a variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1612";
}
