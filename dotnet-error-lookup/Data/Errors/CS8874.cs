namespace dotnet_error_lookup.Data.Errors;

public class CS8874 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8874";
    string IErrorOrWarning.Message => @"Record member '{0}' must return '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' must return '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
