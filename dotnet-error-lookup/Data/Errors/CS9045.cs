namespace dotnet_error_lookup.Data.Errors;

public class CS9045 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9045";
    string IErrorOrWarning.Message => @"Required members are not allowed on the top level of a script or submission.";
    string IErrorOrWarning.Explanation => @"[original] Required members are not allowed on the top level of a script or submission.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
