namespace dotnet_error_lookup.Data.Errors;

public class CS8916 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8916";
    string IErrorOrWarning.Message => @"Attributes on lambda expressions require a parenthesized parameter list.";
    string IErrorOrWarning.Explanation => @"[original] Attributes on lambda expressions require a parenthesized parameter list.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
