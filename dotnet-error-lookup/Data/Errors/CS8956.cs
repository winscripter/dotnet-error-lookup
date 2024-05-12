namespace dotnet_error_lookup.Data.Errors;

public class CS8956 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8956";
    string IErrorOrWarning.Message => @"File-scoped namespace must precede all other members in a file.";
    string IErrorOrWarning.Explanation => @"[original] File-scoped namespace must precede all other members in a file.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
