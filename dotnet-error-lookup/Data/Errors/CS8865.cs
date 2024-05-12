namespace dotnet_error_lookup.Data.Errors;

public class CS8865 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8865";
    string IErrorOrWarning.Message => @"Only records may inherit from records.";
    string IErrorOrWarning.Explanation => @"[original] Only records may inherit from records.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
