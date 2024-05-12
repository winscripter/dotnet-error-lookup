namespace dotnet_error_lookup.Data.Errors;

public class CS8700 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8700";
    string IErrorOrWarning.Message => @"Multiple analyzer config files cannot be in the same directory ('{0}').";
    string IErrorOrWarning.Explanation => @"[original] Multiple analyzer config files cannot be in the same directory ('{0}').";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
