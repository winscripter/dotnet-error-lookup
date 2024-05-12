namespace dotnet_error_lookup.Data.Errors;

public class CS8658 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8658";
    string IErrorOrWarning.Message => @"Auto-implemented 'set' accessor '{0}' cannot be marked 'readonly'.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented 'set' accessor '{0}' cannot be marked 'readonly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
