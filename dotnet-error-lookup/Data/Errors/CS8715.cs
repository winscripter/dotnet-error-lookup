namespace dotnet_error_lookup.Data.Errors;

public class CS8715 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8715";
    string IErrorOrWarning.Message => @"Duplicate null suppression operator ('!')";
    string IErrorOrWarning.Explanation => @"[original] Duplicate null suppression operator ('!')";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
