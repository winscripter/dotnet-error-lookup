namespace dotnet_error_lookup.Data.Errors;

public class CS7013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7013";
    string IErrorOrWarning.Message => @"Name '{0}' exceeds the maximum length allowed in metadata.";
    string IErrorOrWarning.Explanation => @"[original] Name '{0}' exceeds the maximum length allowed in metadata.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
