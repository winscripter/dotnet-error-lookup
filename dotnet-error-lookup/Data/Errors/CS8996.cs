namespace dotnet_error_lookup.Data.Errors;

public class CS8996 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8996";
    string IErrorOrWarning.Message => @"Raw string literals are not allowed in preprocessor directives.";
    string IErrorOrWarning.Explanation => @"[original] Raw string literals are not allowed in preprocessor directives.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
