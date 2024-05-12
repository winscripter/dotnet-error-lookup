namespace dotnet_error_lookup.Data.Errors;

public class CS9057 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9057";
    string IErrorOrWarning.Message => @"The analyzer assembly '{0}' references version '{1}' of the compiler, which is newer than the currently running version '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] The analyzer assembly '{0}' references version '{1}' of the compiler, which is newer than the currently running version '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
