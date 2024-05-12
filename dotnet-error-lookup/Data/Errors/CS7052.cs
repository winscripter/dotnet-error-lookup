namespace dotnet_error_lookup.Data.Errors;

public class CS7052 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7052";
    string IErrorOrWarning.Message => @"SecurityAction value '{0}' is invalid for PrincipalPermission attribute";
    string IErrorOrWarning.Explanation => @"[original] SecurityAction value '{0}' is invalid for PrincipalPermission attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
