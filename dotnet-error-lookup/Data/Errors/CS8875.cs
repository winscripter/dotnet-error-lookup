namespace dotnet_error_lookup.Data.Errors;

public class CS8875 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8875";
    string IErrorOrWarning.Message => @"Record member '{0}' must be protected.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' must be protected.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
