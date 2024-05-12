namespace dotnet_error_lookup.Data.Errors;

public class CS0768 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0768";
    string IErrorOrWarning.Message => @"Constructor '{0}' cannot call itself through another constructor";
    string IErrorOrWarning.Explanation => @"[original] Constructor '{0}' cannot call itself through another constructor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
