namespace dotnet_error_lookup.Data.Errors;

public class CS7014 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7014";
    string IErrorOrWarning.Message => @"Attributes are not valid in this context.";
    string IErrorOrWarning.Explanation => @"[original] Attributes are not valid in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
