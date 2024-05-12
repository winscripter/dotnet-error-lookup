namespace dotnet_error_lookup.Data.Errors;

public class CS4034 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4034";
    string IErrorOrWarning.Message => @"The 'await' operator can only be used within an async {0}. Consider marking this {0} with the 'async' modifier.";
    string IErrorOrWarning.Explanation => @"[original] The 'await' operator can only be used within an async {0}. Consider marking this {0} with the 'async' modifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
