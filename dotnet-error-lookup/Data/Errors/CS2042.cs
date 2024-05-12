namespace dotnet_error_lookup.Data.Errors;

public class CS2042 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2042";
    string IErrorOrWarning.Message => @"Invalid debug information format: {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid debug information format: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
