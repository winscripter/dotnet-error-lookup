namespace dotnet_error_lookup.Data.Errors;

public class CS8662 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8662";
    string IErrorOrWarning.Message => @"Field-like event '{0}' cannot be 'readonly'.";
    string IErrorOrWarning.Explanation => @"[original] Field-like event '{0}' cannot be 'readonly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
