namespace dotnet_error_lookup.Data.Errors;

public class CS4016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4016";
    string IErrorOrWarning.Message => @"Since this is an async method, the return expression must be of type '{0}' rather than '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Since this is an async method, the return expression must be of type '{0}' rather than '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
