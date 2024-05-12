namespace dotnet_error_lookup.Data.Errors;

public class CS7048 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7048";
    string IErrorOrWarning.Message => @"First argument to a security attribute must be a valid SecurityAction";
    string IErrorOrWarning.Explanation => @"[original] First argument to a security attribute must be a valid SecurityAction";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
