namespace dotnet_error_lookup.Data.Errors;

public class CS8955 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8955";
    string IErrorOrWarning.Message => @"Source file can not contain both file-scoped and normal namespace declarations.";
    string IErrorOrWarning.Explanation => @"[original] Source file can not contain both file-scoped and normal namespace declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
