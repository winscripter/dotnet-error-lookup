namespace dotnet_error_lookup.Data.Errors;

public class CS1766 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1766";
    string IErrorOrWarning.Message => @"Source interface '{0}' is missing method '{1}' which is required to embed event '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Source interface '{0}' is missing method '{1}' which is required to embed event '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
