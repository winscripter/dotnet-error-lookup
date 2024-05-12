namespace dotnet_error_lookup.Data.Errors;

public class CS4030 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4030";
    string IErrorOrWarning.Message => @"Security attribute '{0}' cannot be applied to an Async method.";
    string IErrorOrWarning.Explanation => @"[original] Security attribute '{0}' cannot be applied to an Async method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
