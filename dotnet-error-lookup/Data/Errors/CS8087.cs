namespace dotnet_error_lookup.Data.Errors;

public class CS8087 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8087";
    string IErrorOrWarning.Message => @"A '{0}' character may only be escaped by doubling '{0}{0}' in an interpolated string.";
    string IErrorOrWarning.Explanation => @"[original] A '{0}' character may only be escaped by doubling '{0}{0}' in an interpolated string.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
