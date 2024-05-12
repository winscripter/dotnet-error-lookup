namespace dotnet_error_lookup.Data.Errors;

public class CS4003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4003";
    string IErrorOrWarning.Message => @"'await' cannot be used as an identifier within an async method or lambda expression";
    string IErrorOrWarning.Explanation => @"[original] 'await' cannot be used as an identifier within an async method or lambda expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
