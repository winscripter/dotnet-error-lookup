namespace dotnet_error_lookup.Data.Errors;

public class CS8906 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8906";
    string IErrorOrWarning.Message => @"Record equality contract property '{0}' must have a get accessor.";
    string IErrorOrWarning.Explanation => @"[original] Record equality contract property '{0}' must have a get accessor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
