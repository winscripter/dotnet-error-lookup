namespace dotnet_error_lookup.Data.Errors;

public class CS8128 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8128";
    string IErrorOrWarning.Message => @"Member '{0}' was not found on type '{1}' from assembly '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Member '{0}' was not found on type '{1}' from assembly '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
