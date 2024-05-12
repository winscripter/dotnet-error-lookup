namespace dotnet_error_lookup.Data.Errors;

public class CS7034 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7034";
    string IErrorOrWarning.Message => @"The specified version string '{0}' does not conform to the required format - major[.minor[.build[.revision]]]";
    string IErrorOrWarning.Explanation => @"[original] The specified version string '{0}' does not conform to the required format - major[.minor[.build[.revision]]]";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
