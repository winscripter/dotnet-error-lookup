namespace dotnet_error_lookup.Data.Errors;

public class CS8814 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8814";
    string IErrorOrWarning.Message => @"Module initializer method '{0}' must be accessible at the module level";
    string IErrorOrWarning.Explanation => @"[original] Module initializer method '{0}' must be accessible at the module level";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
