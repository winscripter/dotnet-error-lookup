namespace dotnet_error_lookup.Data.Errors;

public class CS9073 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9073";
    string IErrorOrWarning.Message => @"The 'scoped' modifier of parameter '{0}' doesn't match target '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The 'scoped' modifier of parameter '{0}' doesn't match target '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
