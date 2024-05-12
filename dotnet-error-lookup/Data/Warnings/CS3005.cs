namespace dotnet_error_lookup.Data.Errors;

public class CS3005 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3005";
    string IErrorOrWarning.Message => @"Identifier '{0}' differing only in case is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Identifier '{0}' differing only in case is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3005";
}
