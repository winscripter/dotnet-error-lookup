namespace dotnet_error_lookup.Data.Errors;

public class CS8027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8027";
    string IErrorOrWarning.Message => @"The field has multiple distinct constant values.";
    string IErrorOrWarning.Explanation => @"[original] The field has multiple distinct constant values.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
