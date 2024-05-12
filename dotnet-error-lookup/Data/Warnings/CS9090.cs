namespace dotnet_error_lookup.Data.Errors;

public class CS9090 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9090";
    string IErrorOrWarning.Message => @"This returns by reference a member of parameter '{0}' that is scoped to the current method";
    string IErrorOrWarning.Explanation => @"[original] This returns by reference a member of parameter '{0}' that is scoped to the current method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
