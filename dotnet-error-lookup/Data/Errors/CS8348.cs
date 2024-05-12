namespace dotnet_error_lookup.Data.Errors;

public class CS8348 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8348";
    string IErrorOrWarning.Message => @"Cannot use a member of result of '{0}' in this context because it may expose variables referenced by parameter '{1}' outside of their declaration scope";
    string IErrorOrWarning.Explanation => @"[original] Cannot use a member of result of '{0}' in this context because it may expose variables referenced by parameter '{1}' outside of their declaration scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
