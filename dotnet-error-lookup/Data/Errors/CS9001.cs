namespace dotnet_error_lookup.Data.Errors;

public class CS9001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9001";
    string IErrorOrWarning.Message => @"Multi-line raw string literals are only allowed in verbatim interpolated strings.";
    string IErrorOrWarning.Explanation => @"[original] Multi-line raw string literals are only allowed in verbatim interpolated strings.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
