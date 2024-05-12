namespace dotnet_error_lookup.Data.Errors;

public class CS9034 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9034";
    string IErrorOrWarning.Message => @"Required member '{0}' must be settable.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' must be settable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
