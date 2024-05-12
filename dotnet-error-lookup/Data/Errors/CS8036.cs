namespace dotnet_error_lookup.Data.Errors;

public class CS8036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8036";
    string IErrorOrWarning.Message => @"Error reading debug information for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Error reading debug information for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
