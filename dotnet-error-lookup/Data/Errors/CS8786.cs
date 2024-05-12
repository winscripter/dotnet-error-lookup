namespace dotnet_error_lookup.Data.Errors;

public class CS8786 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8786";
    string IErrorOrWarning.Message => @"Calling convention of '{0}' is not compatible with '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Calling convention of '{0}' is not compatible with '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
