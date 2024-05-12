namespace dotnet_error_lookup.Data.Errors;

public class CS8999 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8999";
    string IErrorOrWarning.Message => @"Line does not start with the same whitespace as the closing line of the raw string literal.";
    string IErrorOrWarning.Explanation => @"[original] Line does not start with the same whitespace as the closing line of the raw string literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
