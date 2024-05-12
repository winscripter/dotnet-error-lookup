namespace dotnet_error_lookup.Data.Errors;

public class CS8656 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8656";
    string IErrorOrWarning.Message => @"Call to non-readonly member '{0}' from a 'readonly' member results in an implicit copy of '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Call to non-readonly member '{0}' from a 'readonly' member results in an implicit copy of '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
