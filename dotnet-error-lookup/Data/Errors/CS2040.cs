namespace dotnet_error_lookup.Data.Errors;

public class CS2040 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2040";
    string IErrorOrWarning.Message => @"Command-line syntax error: Missing Guid for option '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Command-line syntax error: Missing Guid for option '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
