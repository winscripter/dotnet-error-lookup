namespace dotnet_error_lookup.Data.Errors;

public class CS8810 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8810";
    string IErrorOrWarning.Message => @"'&' on method groups cannot be used in expression trees";
    string IErrorOrWarning.Explanation => @"[original] '&' on method groups cannot be used in expression trees";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
