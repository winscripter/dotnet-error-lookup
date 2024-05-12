namespace dotnet_error_lookup.Data.Errors;

public class CS1756 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1756";
    string IErrorOrWarning.Message => @"Interop type '{0}' cannot be embedded because it is missing the required '{1}' attribute.";
    string IErrorOrWarning.Explanation => @"[original] Interop type '{0}' cannot be embedded because it is missing the required '{1}' attribute.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
