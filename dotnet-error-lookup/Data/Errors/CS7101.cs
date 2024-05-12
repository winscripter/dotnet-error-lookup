namespace dotnet_error_lookup.Data.Errors;

public class CS7101 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7101";
    string IErrorOrWarning.Message => @"Member '{0}' added during the current debug session can only be accessed from within its declaring assembly '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' added during the current debug session can only be accessed from within its declaring assembly '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
