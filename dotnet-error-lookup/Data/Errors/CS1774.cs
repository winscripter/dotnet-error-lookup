namespace dotnet_error_lookup.Data.Errors;

public class CS1774 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1774";
    string IErrorOrWarning.Message => @"Embedded interop method '{0}' contains a body.";
    string IErrorOrWarning.Explanation => @"[original] Embedded interop method '{0}' contains a body.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
