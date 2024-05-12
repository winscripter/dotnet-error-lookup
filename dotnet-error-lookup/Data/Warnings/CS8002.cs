namespace dotnet_error_lookup.Data.Errors;

public class CS8002 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8002";
    string IErrorOrWarning.Message => @"Referenced assembly '{0}' does not have a strong name.";
    string IErrorOrWarning.Explanation => @"[original] Referenced assembly '{0}' does not have a strong name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
