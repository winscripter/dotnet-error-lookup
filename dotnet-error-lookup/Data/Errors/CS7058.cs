namespace dotnet_error_lookup.Data.Errors;

public class CS7058 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7058";
    string IErrorOrWarning.Message => @"The specified version string '{0}' does not conform to the required format - major.minor.build.revision (without wildcards)";
    string IErrorOrWarning.Explanation => @"[original] The specified version string '{0}' does not conform to the required format - major.minor.build.revision (without wildcards)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
