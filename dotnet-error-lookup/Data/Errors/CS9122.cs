namespace dotnet_error_lookup.Data.Errors;

public class CS9122 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9122";
    string IErrorOrWarning.Message => @"Unexpected parameter list.";
    string IErrorOrWarning.Explanation => @"[original] Unexpected parameter list.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
