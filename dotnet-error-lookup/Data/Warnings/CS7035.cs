namespace dotnet_error_lookup.Data.Errors;

public class CS7035 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7035";
    string IErrorOrWarning.Message => @"The specified version string '{0}' does not conform to the recommended format - major.minor.build.revision";
    string IErrorOrWarning.Explanation => @"[original] The specified version string '{0}' does not conform to the recommended format - major.minor.build.revision";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
