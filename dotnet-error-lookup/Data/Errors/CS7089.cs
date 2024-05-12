namespace dotnet_error_lookup.Data.Errors;

public class CS7089 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7089";
    string IErrorOrWarning.Message => @"AppConfigPath must be absolute.";
    string IErrorOrWarning.Explanation => @"[original] AppConfigPath must be absolute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
