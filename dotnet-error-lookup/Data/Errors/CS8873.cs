namespace dotnet_error_lookup.Data.Errors;

public class CS8873 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8873";
    string IErrorOrWarning.Message => @"Record member '{0}' must be public.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' must be public.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
