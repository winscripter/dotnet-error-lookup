namespace dotnet_error_lookup.Data.Errors;

public class CS8014 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8014";
    string IErrorOrWarning.Message => @"Reference to '{0}' netmodule missing.";
    string IErrorOrWarning.Explanation => @"[original] Reference to '{0}' netmodule missing.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
