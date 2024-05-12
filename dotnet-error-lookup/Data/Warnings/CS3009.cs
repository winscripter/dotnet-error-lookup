namespace dotnet_error_lookup.Data.Errors;

public class CS3009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3009";
    string IErrorOrWarning.Message => @"'{0}': base type '{1}' is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] '{0}': base type '{1}' is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs3009";
}
