namespace dotnet_error_lookup.Data.Errors;

public class CS8352 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8352";
    string IErrorOrWarning.Message => @"Cannot use variable '{0}' in this context because it may expose referenced variables outside of their declaration scope";
    string IErrorOrWarning.Explanation => @"[original] Cannot use variable '{0}' in this context because it may expose referenced variables outside of their declaration scope";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
