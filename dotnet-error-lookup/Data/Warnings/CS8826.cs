namespace dotnet_error_lookup.Data.Errors;

public class CS8826 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8826";
    string IErrorOrWarning.Message => @"Partial method declarations '{0}' and '{1}' have signature differences.";
    string IErrorOrWarning.Explanation => @"[original] Partial method declarations '{0}' and '{1}' have signature differences.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
