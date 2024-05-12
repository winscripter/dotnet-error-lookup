namespace dotnet_error_lookup.Data.Errors;

public class CS7025 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7025";
    string IErrorOrWarning.Message => @"Inconsistent accessibility: event type '{1}' is less accessible than event '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Inconsistent accessibility: event type '{1}' is less accessible than event '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
