namespace dotnet_error_lookup.Data.Errors;

public class CS8183 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8183";
    string IErrorOrWarning.Message => @"Cannot infer the type of implicitly-typed discard.";
    string IErrorOrWarning.Explanation => @"[original] Cannot infer the type of implicitly-typed discard.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
