namespace dotnet_error_lookup.Data.Errors;

public class CS4031 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4031";
    string IErrorOrWarning.Message => @"Async methods are not allowed in an Interface, Class, or Structure which has the 'SecurityCritical' or 'SecuritySafeCritical' attribute.";
    string IErrorOrWarning.Explanation => @"[original] Async methods are not allowed in an Interface, Class, or Structure which has the 'SecurityCritical' or 'SecuritySafeCritical' attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
