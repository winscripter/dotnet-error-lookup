namespace dotnet_error_lookup.Data.Errors;

public class CS8119 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8119";
    string IErrorOrWarning.Message => @"The switch expression must be a value; found '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] The switch expression must be a value; found '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
