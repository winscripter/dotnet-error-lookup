namespace dotnet_error_lookup.Data.Errors;

public class CS7049 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7049";
    string IErrorOrWarning.Message => @"Security attribute '{0}' has an invalid SecurityAction value '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Security attribute '{0}' has an invalid SecurityAction value '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
