namespace dotnet_error_lookup.Data.Errors;

public class CS7033 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7033";
    string IErrorOrWarning.Message => @"Delay signing was specified and requires a public key, but no public key was specified";
    string IErrorOrWarning.Explanation => @"[original] Delay signing was specified and requires a public key, but no public key was specified";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
