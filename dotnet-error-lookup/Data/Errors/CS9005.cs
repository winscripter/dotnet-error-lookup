namespace dotnet_error_lookup.Data.Errors;

public class CS9005 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9005";
    string IErrorOrWarning.Message => @"The interpolation must end with the same number of closing braces as the number of '$' characters that the raw string literal started with.";
    string IErrorOrWarning.Explanation => @"[original] The interpolation must end with the same number of closing braces as the number of '$' characters that the raw string literal started with.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
