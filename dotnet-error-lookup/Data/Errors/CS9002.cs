namespace dotnet_error_lookup.Data.Errors;

public class CS9002 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9002";
    string IErrorOrWarning.Message => @"Multi-line raw string literals must contain at least one line of content.";
    string IErrorOrWarning.Explanation => @"[original] Multi-line raw string literals must contain at least one line of content.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
