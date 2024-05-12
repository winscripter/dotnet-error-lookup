namespace dotnet_error_lookup.Data.Errors;

public class CS8505 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8505";
    string IErrorOrWarning.Message => @"A default literal 'default' is not valid as a pattern. Use another literal (e.g. '0' or 'null') as appropriate. To match everything, use a discard pattern '\_'.";
    string IErrorOrWarning.Explanation => @"[original] A default literal 'default' is not valid as a pattern. Use another literal (e.g. '0' or 'null') as appropriate. To match everything, use a discard pattern '\_'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
