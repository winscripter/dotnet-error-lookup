namespace dotnet_error_lookup.Data.Errors;

public class CS8879 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8879";
    string IErrorOrWarning.Message => @"Record member '{0}' must be private.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' must be private.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
