namespace dotnet_error_lookup.Data.Errors;

public class CS8111 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8111";
    string IErrorOrWarning.Message => @"Invalid instrumentation kind: {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid instrumentation kind: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
