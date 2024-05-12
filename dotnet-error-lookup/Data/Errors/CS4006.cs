namespace dotnet_error_lookup.Data.Errors;

public class CS4006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4006";
    string IErrorOrWarning.Message => @"\_\_arglist is not allowed in the parameter list of async methods";
    string IErrorOrWarning.Explanation => @"[original] \_\_arglist is not allowed in the parameter list of async methods";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
