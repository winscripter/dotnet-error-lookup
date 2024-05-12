namespace dotnet_error_lookup.Data.Errors;

public class CS7047 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7047";
    string IErrorOrWarning.Message => @"Attribute parameter '{0}' or '{1}' must be specified.";
    string IErrorOrWarning.Explanation => @"[original] Attribute parameter '{0}' or '{1}' must be specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
