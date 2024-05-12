namespace dotnet_error_lookup.Data.Errors;

public class CS9075 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9075";
    string IErrorOrWarning.Message => @"Cannot return a parameter by reference '{0}' because it is scoped to the current method";
    string IErrorOrWarning.Explanation => @"[original] Cannot return a parameter by reference '{0}' because it is scoped to the current method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
