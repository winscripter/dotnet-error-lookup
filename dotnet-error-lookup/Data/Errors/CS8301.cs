namespace dotnet_error_lookup.Data.Errors;

public class CS8301 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8301";
    string IErrorOrWarning.Message => @"Invalid name for a preprocessing symbol; '{0}' is not a valid identifier";
    string IErrorOrWarning.Explanation => @"[original] Invalid name for a preprocessing symbol; '{0}' is not a valid identifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
