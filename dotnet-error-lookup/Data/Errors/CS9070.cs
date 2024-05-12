namespace dotnet_error_lookup.Data.Errors;

public class CS9070 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9070";
    string IErrorOrWarning.Message => @"'readonly' is not supported as a parameter modifier. Did you mean 'in'?";
    string IErrorOrWarning.Explanation => @"[original] 'readonly' is not supported as a parameter modifier. Did you mean 'in'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
