namespace dotnet_error_lookup.Data.Errors;

public class CS1737 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1737";
    string IErrorOrWarning.Message => @"Optional parameters must appear after all required parameters";
    string IErrorOrWarning.Explanation => @"[original] Optional parameters must appear after all required parameters";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1737";
}
