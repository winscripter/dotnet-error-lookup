namespace dotnet_error_lookup.Data.Errors;

public class CS9108 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9108";
    string IErrorOrWarning.Message => @"Cannot use parameter '{0}' that has ref-like type inside an anonymous method, lambda expression, query expression, or local function";
    string IErrorOrWarning.Explanation => @"[original] Cannot use parameter '{0}' that has ref-like type inside an anonymous method, lambda expression, query expression, or local function";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
