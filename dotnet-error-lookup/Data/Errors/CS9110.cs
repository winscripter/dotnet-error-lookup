namespace dotnet_error_lookup.Data.Errors;

public class CS9110 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9110";
    string IErrorOrWarning.Message => @"Cannot use primary constructor parameter '{0}' that has ref-like type inside an instance member";
    string IErrorOrWarning.Explanation => @"[original] Cannot use primary constructor parameter '{0}' that has ref-like type inside an instance member";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
