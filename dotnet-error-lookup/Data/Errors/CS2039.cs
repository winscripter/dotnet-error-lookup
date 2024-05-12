namespace dotnet_error_lookup.Data.Errors;

public class CS2039 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2039";
    string IErrorOrWarning.Message => @"Command-line syntax error: Invalid Guid format '{0}' for option '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Command-line syntax error: Invalid Guid format '{0}' for option '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
