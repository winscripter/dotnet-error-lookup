namespace dotnet_error_lookup.Data.Errors;

public class CS7087 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7087";
    string IErrorOrWarning.Message => @"Invalid module name: {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid module name: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
