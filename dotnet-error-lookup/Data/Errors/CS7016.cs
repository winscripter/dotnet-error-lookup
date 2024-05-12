namespace dotnet_error_lookup.Data.Errors;

public class CS7016 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7016";
    string IErrorOrWarning.Message => @"Alias '{0}' conflicts with {1} definition";
    string IErrorOrWarning.Explanation => @"[original] Alias '{0}' conflicts with {1} definition";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
