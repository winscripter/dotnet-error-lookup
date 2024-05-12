namespace dotnet_error_lookup.Data.Errors;

public class CS0595 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0595";
    string IErrorOrWarning.Message => @"Invalid real literal.";
    string IErrorOrWarning.Explanation => @"[original] Invalid real literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
