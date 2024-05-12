namespace dotnet_error_lookup.Data.Errors;

public class CS1741 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1741";
    string IErrorOrWarning.Message => @"A ref or out parameter cannot have a default value";
    string IErrorOrWarning.Explanation => @"[original] A ref or out parameter cannot have a default value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1741";
}
