namespace dotnet_error_lookup.Data.Errors;

public class CS9096 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9096";
    string IErrorOrWarning.Message => @"Cannot ref-assign '{1}' to '{0}' because '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escapes scopes than '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot ref-assign '{1}' to '{0}' because '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escapes scopes than '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
