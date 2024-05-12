namespace dotnet_error_lookup.Data.Errors;

public class CS8635 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8635";
    string IErrorOrWarning.Message => @"Unexpected character sequence '...'";
    string IErrorOrWarning.Explanation => @"[original] Unexpected character sequence '...'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
