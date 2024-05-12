namespace dotnet_error_lookup.Data.Errors;

public class CS9006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9006";
    string IErrorOrWarning.Message => @"The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive opening braces as content.";
    string IErrorOrWarning.Explanation => @"[original] The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive opening braces as content.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
