namespace dotnet_error_lookup.Data.Errors;

public class CS7032 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7032";
    string IErrorOrWarning.Message => @"Key file '{0}' is missing the private key needed for signing";
    string IErrorOrWarning.Explanation => @"[original] Key file '{0}' is missing the private key needed for signing";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
