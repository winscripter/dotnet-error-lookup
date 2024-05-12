namespace dotnet_error_lookup.Data.Errors;

public class CS9115 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9115";
    string IErrorOrWarning.Message => @"A primary constructor parameter of a readonly type cannot be returned by writable reference";
    string IErrorOrWarning.Explanation => @"[original] A primary constructor parameter of a readonly type cannot be returned by writable reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
