namespace dotnet_error_lookup.Data.Errors;

public class CS9109 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9109";
    string IErrorOrWarning.Message => @"Cannot use ref, out, or in primary constructor parameter '{0}' inside an instance member";
    string IErrorOrWarning.Explanation => @"[original] Cannot use ref, out, or in primary constructor parameter '{0}' inside an instance member";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
