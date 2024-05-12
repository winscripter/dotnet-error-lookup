namespace dotnet_error_lookup.Data.Errors;

public class CS3006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS3006";
    string IErrorOrWarning.Message => @"Overloaded method '{0}' differing only in ref or out, or in array rank, is not CLS-compliant";
    string IErrorOrWarning.Explanation => @"[original] Overloaded method '{0}' differing only in ref or out, or in array rank, is not CLS-compliant";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs3006";
}
