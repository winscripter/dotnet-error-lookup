namespace dotnet_error_lookup.Data.Errors;

public class CS9027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9027";
    string IErrorOrWarning.Message => @"Unexpected keyword 'unchecked'";
    string IErrorOrWarning.Explanation => @"[original] Unexpected keyword 'unchecked'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
