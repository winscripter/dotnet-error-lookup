namespace dotnet_error_lookup.Data.Errors;

public class CS7056 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7056";
    string IErrorOrWarning.Message => @"Unable to resolve file path '{0}' specified for the named argument '{1}' for PermissionSet attribute";
    string IErrorOrWarning.Explanation => @"[original] Unable to resolve file path '{0}' specified for the named argument '{1}' for PermissionSet attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
