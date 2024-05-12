namespace dotnet_error_lookup.Data.Errors;

public class CS3003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3003";
    string IErrorOrWarning.Message => @"Type of '{0}' is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Type of '{0}' is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs3003";
}
