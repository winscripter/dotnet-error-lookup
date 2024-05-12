namespace dotnet_error_lookup.Data.Errors;

public class CS7067 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7067";
    string IErrorOrWarning.Message => @"Attribute constructor parameter '{0}' is optional, but no default parameter value was specified.";
    string IErrorOrWarning.Explanation => @"[original] Attribute constructor parameter '{0}' is optional, but no default parameter value was specified.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
