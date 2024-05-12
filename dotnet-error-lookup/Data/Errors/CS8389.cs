namespace dotnet_error_lookup.Data.Errors;

public class CS8389 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8389";
    string IErrorOrWarning.Message => @"Omitting the type argument is not allowed in the current context";
    string IErrorOrWarning.Explanation => @"[original] Omitting the type argument is not allowed in the current context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
