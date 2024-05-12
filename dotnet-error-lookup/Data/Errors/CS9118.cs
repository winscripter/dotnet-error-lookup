namespace dotnet_error_lookup.Data.Errors;

public class CS9118 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9118";
    string IErrorOrWarning.Message => @"Members of primary constructor parameter '{0}' of a readonly type cannot be returned by writable reference";
    string IErrorOrWarning.Explanation => @"[original] Members of primary constructor parameter '{0}' of a readonly type cannot be returned by writable reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
