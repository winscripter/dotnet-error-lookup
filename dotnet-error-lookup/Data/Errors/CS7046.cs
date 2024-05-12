namespace dotnet_error_lookup.Data.Errors;

public class CS7046 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7046";
    string IErrorOrWarning.Message => @"Attribute parameter '{0}' must be specified.";
    string IErrorOrWarning.Explanation => @"[original] Attribute parameter '{0}' must be specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
