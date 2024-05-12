namespace dotnet_error_lookup.Data.Errors;

public class CS8106 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8106";
    string IErrorOrWarning.Message => @"Option '{0}' must be an absolute path.";
    string IErrorOrWarning.Explanation => @"[original] Option '{0}' must be an absolute path.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
