namespace dotnet_error_lookup.Data.Errors;

public class CS8055 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8055";
    string IErrorOrWarning.Message => @"Cannot emit debug information for a source text without encoding.";
    string IErrorOrWarning.Explanation => @"[original] Cannot emit debug information for a source text without encoding.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
