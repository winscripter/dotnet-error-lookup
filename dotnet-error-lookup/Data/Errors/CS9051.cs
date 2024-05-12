namespace dotnet_error_lookup.Data.Errors;

public class CS9051 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9051";
    string IErrorOrWarning.Message => @"File-local type '{0}' cannot be used in a member signature in non-file-local type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' cannot be used in a member signature in non-file-local type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
