namespace dotnet_error_lookup.Data.Errors;

public class CS4012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4012";
    string IErrorOrWarning.Message => @"Parameters or locals of type '{0}' cannot be declared in async methods or async lambda expressions.";
    string IErrorOrWarning.Explanation => @"[original] Parameters or locals of type '{0}' cannot be declared in async methods or async lambda expressions.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
