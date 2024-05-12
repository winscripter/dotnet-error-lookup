namespace dotnet_error_lookup.Data.Errors;

public class CS9080 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9080";
    string IErrorOrWarning.Message => @"Use of variable '{0}' in this context may expose referenced variables outside of their declaration scope";
    string IErrorOrWarning.Explanation => @"[original] Use of variable '{0}' in this context may expose referenced variables outside of their declaration scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
