namespace dotnet_error_lookup.Data.Errors;

public class CS8909 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8909";
    string IErrorOrWarning.Message => @"Comparison of function pointers might yield an unexpected result, since pointers to the same function may be distinct.";
    string IErrorOrWarning.Explanation => @"[original] Comparison of function pointers might yield an unexpected result, since pointers to the same function may be distinct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
