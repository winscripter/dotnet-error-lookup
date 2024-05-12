namespace dotnet_error_lookup.Data.Errors;

public class CS9000 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9000";
    string IErrorOrWarning.Message => @"Raw string literal delimiter must be on its own line.";
    string IErrorOrWarning.Explanation => @"[original] Raw string literal delimiter must be on its own line.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
