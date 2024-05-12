namespace dotnet_error_lookup.Data.Errors;

public class CS7057 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7057";
    string IErrorOrWarning.Message => @"Error reading file '{0}' specified for the named argument '{1}' for PermissionSet attribute: '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Error reading file '{0}' specified for the named argument '{1}' for PermissionSet attribute: '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
