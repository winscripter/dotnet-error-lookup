namespace dotnet_error_lookup.Data.Errors;

public class CS8705 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8705";
    string IErrorOrWarning.Message => @"Interface member '{0}' does not have a most specific implementation. Neither '{1}', nor '{2}' are most specific.";
    string IErrorOrWarning.Explanation => @"[original] Interface member '{0}' does not have a most specific implementation. Neither '{1}', nor '{2}' are most specific.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
