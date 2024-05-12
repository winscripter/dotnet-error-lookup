namespace dotnet_error_lookup.Data.Errors;

public class CS9068 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9068";
    string IErrorOrWarning.Message => @"File-local type '{0}' must be declared in a file with a unique path. Path '{1}' is used in multiple files.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' must be declared in a file with a unique path. Path '{1}' is used in multiple files.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
