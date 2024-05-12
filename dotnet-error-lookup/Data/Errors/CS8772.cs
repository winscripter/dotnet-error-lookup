namespace dotnet_error_lookup.Data.Errors;

public class CS8772 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8772";
    string IErrorOrWarning.Message => @"stdin argument '-' is specified, but input has not been redirected from the standard input stream.";
    string IErrorOrWarning.Explanation => @"[original] stdin argument '-' is specified, but input has not been redirected from the standard input stream.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
