namespace dotnet_error_lookup.Data.Errors;

public class CS7099 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7099";
    string IErrorOrWarning.Message => @"Metadata references are not supported.";
    string IErrorOrWarning.Explanation => @"[original] Metadata references are not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
