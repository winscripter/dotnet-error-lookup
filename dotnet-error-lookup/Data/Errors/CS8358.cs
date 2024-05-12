namespace dotnet_error_lookup.Data.Errors;

public class CS8358 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8358";
    string IErrorOrWarning.Message => @"Cannot use attribute constructor '{0}' because it has 'in' parameters.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use attribute constructor '{0}' because it has 'in' parameters.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
