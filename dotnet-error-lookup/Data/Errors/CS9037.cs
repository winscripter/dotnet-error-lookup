namespace dotnet_error_lookup.Data.Errors;

public class CS9037 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9037";
    string IErrorOrWarning.Message => @"The required members list for '{0}' is malformed and cannot be interpreted.";
    string IErrorOrWarning.Explanation => @"[original] The required members list for '{0}' is malformed and cannot be interpreted.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
