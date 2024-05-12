namespace dotnet_error_lookup.Data.Errors;

public class CS9004 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9004";
    string IErrorOrWarning.Message => @"Not enough quotes for raw string literal.";
    string IErrorOrWarning.Explanation => @"[original] Not enough quotes for raw string literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
