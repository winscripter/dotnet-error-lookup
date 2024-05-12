namespace dotnet_error_lookup.Data.Errors;

public class CS9076 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9076";
    string IErrorOrWarning.Message => @"Cannot return by reference a member of parameter '{0}' because it is scoped to the current method";
    string IErrorOrWarning.Explanation => @"[original] Cannot return by reference a member of parameter '{0}' because it is scoped to the current method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
