namespace dotnet_error_lookup.Data.Errors;

public class CS8350 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8350";
    string IErrorOrWarning.Message => @"This combination of arguments to '{0}' is disallowed because it may expose variables referenced by parameter '{1}' outside of their declaration scope";
    string IErrorOrWarning.Explanation => @"[original] This combination of arguments to '{0}' is disallowed because it may expose variables referenced by parameter '{1}' outside of their declaration scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
