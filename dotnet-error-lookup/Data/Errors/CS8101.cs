namespace dotnet_error_lookup.Data.Errors;

public class CS8101 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8101";
    string IErrorOrWarning.Message => @"The pathmap option was incorrectly formatted.";
    string IErrorOrWarning.Explanation => @"[original] The pathmap option was incorrectly formatted.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
