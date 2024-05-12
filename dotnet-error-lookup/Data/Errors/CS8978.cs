namespace dotnet_error_lookup.Data.Errors;

public class CS8978 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8978";
    string IErrorOrWarning.Message => @"'{0}' cannot be made nullable.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' cannot be made nullable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
