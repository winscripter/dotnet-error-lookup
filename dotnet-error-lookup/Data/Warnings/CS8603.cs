namespace dotnet_error_lookup.Data.Errors;

public class CS8603 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8603";
    string IErrorOrWarning.Message => @"Possible null reference return.";
    string IErrorOrWarning.Explanation => @"[original] Possible null reference return.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
