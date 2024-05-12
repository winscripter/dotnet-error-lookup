namespace dotnet_error_lookup.Data.Errors;

public class CS8058 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8058";
    string IErrorOrWarning.Message => @"Feature '{0}' is experimental and unsupported; use '/features:{1}' to enable.";
    string IErrorOrWarning.Explanation => @"[original] Feature '{0}' is experimental and unsupported; use '/features:{1}' to enable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
