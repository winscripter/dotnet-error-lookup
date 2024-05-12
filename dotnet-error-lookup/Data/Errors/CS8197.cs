namespace dotnet_error_lookup.Data.Errors;

public class CS8197 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8197";
    string IErrorOrWarning.Message => @"Cannot infer the type of implicitly-typed out variable '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot infer the type of implicitly-typed out variable '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
