namespace dotnet_error_lookup.Data.Errors;

public class CS9087 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9087";
    string IErrorOrWarning.Message => @"This returns a parameter by reference '{0}' but it is not a ref parameter";
    string IErrorOrWarning.Explanation => @"[original] This returns a parameter by reference '{0}' but it is not a ref parameter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
