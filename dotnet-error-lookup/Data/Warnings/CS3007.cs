namespace dotnet_error_lookup.Data.Errors;

public class CS3007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3007";
    string IErrorOrWarning.Message => @"Overloaded method '{0}' differing only by unnamed array types is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Overloaded method '{0}' differing only by unnamed array types is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs3007";
}
