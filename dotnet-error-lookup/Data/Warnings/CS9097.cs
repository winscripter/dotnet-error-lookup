namespace dotnet_error_lookup.Data.Errors;

public class CS9097 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9097";
    string IErrorOrWarning.Message => @"This ref-assigns '{1}' to '{0}' but '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escapes scopes than '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] This ref-assigns '{1}' to '{0}' but '{1}' has a wider value escape scope than '{0}' allowing assignment through '{0}' of values with narrower escapes scopes than '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
