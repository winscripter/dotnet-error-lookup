namespace dotnet_error_lookup.Data.Errors;

public class CS8300 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8300";
    string IErrorOrWarning.Message => @"Merge conflict marker encountered";
    string IErrorOrWarning.Explanation => @"[original] Merge conflict marker encountered";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
