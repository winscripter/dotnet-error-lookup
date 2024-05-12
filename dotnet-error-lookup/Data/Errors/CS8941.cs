namespace dotnet_error_lookup.Data.Errors;

public class CS8941 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8941";
    string IErrorOrWarning.Message => @"Interpolated string handler method '{0}' is malformed. It does not return 'void' or 'bool'.";
    string IErrorOrWarning.Explanation => @"[original] Interpolated string handler method '{0}' is malformed. It does not return 'void' or 'bool'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
