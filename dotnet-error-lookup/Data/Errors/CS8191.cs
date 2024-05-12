namespace dotnet_error_lookup.Data.Errors;

public class CS8191 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8191";
    string IErrorOrWarning.Message => @"Provided documentation mode is unsupported or invalid: '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Provided documentation mode is unsupported or invalid: '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
