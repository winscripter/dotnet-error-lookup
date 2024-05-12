namespace dotnet_error_lookup.Data.Errors;

public class CS9008 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9008";
    string IErrorOrWarning.Message => @"Sequence of '@' characters is not allowed. A verbatim string or identifier can only have one '@' character and a raw string cannot have any.";
    string IErrorOrWarning.Explanation => @"[original] Sequence of '@' characters is not allowed. A verbatim string or identifier can only have one '@' character and a raw string cannot have any.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
