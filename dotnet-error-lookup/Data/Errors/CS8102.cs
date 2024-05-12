namespace dotnet_error_lookup.Data.Errors;

public class CS8102 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8102";
    string IErrorOrWarning.Message => @"Public signing was specified and requires a public key, but no public key was specified.";
    string IErrorOrWarning.Explanation => @"[original] Public signing was specified and requires a public key, but no public key was specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
