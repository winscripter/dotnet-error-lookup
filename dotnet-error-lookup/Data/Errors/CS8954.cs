namespace dotnet_error_lookup.Data.Errors;

public class CS8954 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8954";
    string IErrorOrWarning.Message => @"Source file can only contain one file-scoped namespace declaration.";
    string IErrorOrWarning.Explanation => @"[original] Source file can only contain one file-scoped namespace declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
