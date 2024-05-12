namespace dotnet_error_lookup.Data.Errors;

public class CS8989 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8989";
    string IErrorOrWarning.Message => @"The 'parameter null-checking' feature is not supported.";
    string IErrorOrWarning.Explanation => @"[original] The 'parameter null-checking' feature is not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
