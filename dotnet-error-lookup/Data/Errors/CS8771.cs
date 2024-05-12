namespace dotnet_error_lookup.Data.Errors;

public class CS8771 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8771";
    string IErrorOrWarning.Message => @"Output directory could not be determined";
    string IErrorOrWarning.Explanation => @"[original] Output directory could not be determined";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
