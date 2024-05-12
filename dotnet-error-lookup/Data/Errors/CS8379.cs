namespace dotnet_error_lookup.Data.Errors;

public class CS8379 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8379";
    string IErrorOrWarning.Message => @"Type parameter '{1}' has the 'unmanaged' constraint so '{1}' cannot be used as a constraint for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Type parameter '{1}' has the 'unmanaged' constraint so '{1}' cannot be used as a constraint for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
