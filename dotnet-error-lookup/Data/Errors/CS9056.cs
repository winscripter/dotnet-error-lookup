namespace dotnet_error_lookup.Data.Errors;

public class CS9056 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9056";
    string IErrorOrWarning.Message => @"Types and aliases cannot be named 'file'.";
    string IErrorOrWarning.Explanation => @"[original] Types and aliases cannot be named 'file'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
