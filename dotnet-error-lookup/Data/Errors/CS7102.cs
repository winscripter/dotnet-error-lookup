namespace dotnet_error_lookup.Data.Errors;

public class CS7102 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7102";
    string IErrorOrWarning.Message => @"Compilation options '{0}' and '{1}' can't both be specified at the same time.";
    string IErrorOrWarning.Explanation => @"[original] Compilation options '{0}' and '{1}' can't both be specified at the same time.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
