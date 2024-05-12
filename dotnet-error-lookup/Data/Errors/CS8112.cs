namespace dotnet_error_lookup.Data.Errors;

public class CS8112 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8112";
    string IErrorOrWarning.Message => @"Local function '{0}' must declare a body because it is not marked 'static extern'.";
    string IErrorOrWarning.Explanation => @"[original] Local function '{0}' must declare a body because it is not marked 'static extern'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
