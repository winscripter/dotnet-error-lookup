namespace dotnet_error_lookup.Data.Errors;

public class CS7026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7026";
    string IErrorOrWarning.Message => @"Assembly and module attributes are not allowed in this context";
    string IErrorOrWarning.Explanation => @"[original] Assembly and module attributes are not allowed in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
