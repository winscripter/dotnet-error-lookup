namespace dotnet_error_lookup.Data.Errors;

public class CS8598 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8598";
    string IErrorOrWarning.Message => @"The suppression operator is not allowed in this context";
    string IErrorOrWarning.Explanation => @"[original] The suppression operator is not allowed in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
