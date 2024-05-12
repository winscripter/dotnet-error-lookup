namespace dotnet_error_lookup.Data.Errors;

public class CS7002 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7002";
    string IErrorOrWarning.Message => @"Unexpected use of a generic name";
    string IErrorOrWarning.Explanation => @"[original] Unexpected use of a generic name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
