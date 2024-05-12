namespace dotnet_error_lookup.Data.Errors;

public class CS7028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7028";
    string IErrorOrWarning.Message => @"Error signing output with public key from container '{0}' -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Error signing output with public key from container '{0}' -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
