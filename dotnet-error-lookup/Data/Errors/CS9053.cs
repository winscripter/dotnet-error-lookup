namespace dotnet_error_lookup.Data.Errors;

public class CS9053 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9053";
    string IErrorOrWarning.Message => @"File-local type '{0}' cannot be used as a base type of non-file-local type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' cannot be used as a base type of non-file-local type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
