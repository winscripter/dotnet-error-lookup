namespace dotnet_error_lookup.Data.Errors;

public class CS8997 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8997";
    string IErrorOrWarning.Message => @"Unterminated raw string literal.";
    string IErrorOrWarning.Explanation => @"[original] Unterminated raw string literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
