namespace dotnet_error_lookup.Data.Errors;

public class CS9123 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9123";
    string IErrorOrWarning.Message => @"The '&' operator should not be used on parameters or local variables in async methods.";
    string IErrorOrWarning.Explanation => @"[original] The '&' operator should not be used on parameters or local variables in async methods.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
