namespace dotnet_error_lookup.Data.Errors;

public class CS8855 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8855";
    string IErrorOrWarning.Message => @"Accessors '{0}' and '{1}' should both be init-only or neither";
    string IErrorOrWarning.Explanation => @"[original] Accessors '{0}' and '{1}' should both be init-only or neither";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
