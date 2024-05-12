namespace dotnet_error_lookup.Data.Errors;

public class CS9088 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9088";
    string IErrorOrWarning.Message => @"This returns a parameter by reference '{0}' but it is scoped to the current method";
    string IErrorOrWarning.Explanation => @"[original] This returns a parameter by reference '{0}' but it is scoped to the current method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
