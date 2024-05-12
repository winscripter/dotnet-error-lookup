namespace dotnet_error_lookup.Data.Errors;

public class CS9133 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9133";
    string IErrorOrWarning.Message => @"'static' modifier must precede 'unsafe' modifier.";
    string IErrorOrWarning.Explanation => @"[original] 'static' modifier must precede 'unsafe' modifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
