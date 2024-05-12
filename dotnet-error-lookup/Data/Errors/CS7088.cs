namespace dotnet_error_lookup.Data.Errors;

public class CS7088 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7088";
    string IErrorOrWarning.Message => @"Invalid '{0}' value: '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Invalid '{0}' value: '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
