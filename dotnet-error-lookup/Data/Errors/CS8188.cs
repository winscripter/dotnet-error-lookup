namespace dotnet_error_lookup.Data.Errors;

public class CS8188 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8188";
    string IErrorOrWarning.Message => @"An expression tree may not contain a throw-expression.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain a throw-expression.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
