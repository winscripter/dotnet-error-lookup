namespace dotnet_error_lookup.Data.Errors;

public class CS8381 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8381";
    string IErrorOrWarning.Message => @"Invalid rank specifier: expected ']'";
    string IErrorOrWarning.Explanation => @"[original] Invalid rank specifier: expected ']'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
