namespace dotnet_error_lookup.Data.Errors;

public class CS9007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9007";
    string IErrorOrWarning.Message => @"The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive closing braces as content.";
    string IErrorOrWarning.Explanation => @"[original] The interpolated raw string literal does not start with enough '$' characters to allow this many consecutive closing braces as content.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
