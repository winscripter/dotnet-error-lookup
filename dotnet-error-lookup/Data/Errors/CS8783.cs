namespace dotnet_error_lookup.Data.Errors;

public class CS8783 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8783";
    string IErrorOrWarning.Message => @"Local function '{0}' must be 'static' in order to use the Conditional attribute";
    string IErrorOrWarning.Explanation => @"[original] Local function '{0}' must be 'static' in order to use the Conditional attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
