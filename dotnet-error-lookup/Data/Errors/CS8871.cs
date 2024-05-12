namespace dotnet_error_lookup.Data.Errors;

public class CS8871 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8871";
    string IErrorOrWarning.Message => @"'{0}' does not override expected method from '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not override expected method from '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
