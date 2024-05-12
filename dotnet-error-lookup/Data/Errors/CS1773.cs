namespace dotnet_error_lookup.Data.Errors;

public class CS1773 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1773";
    string IErrorOrWarning.Message => @"Invalid version {0} for /subsystemversion. The version must be 6.02 or greater for ARM or AppContainerExe, and 4.00 or greater otherwise";
    string IErrorOrWarning.Explanation => @"[original] Invalid version {0} for /subsystemversion. The version must be 6.02 or greater for ARM or AppContainerExe, and 4.00 or greater otherwise";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
