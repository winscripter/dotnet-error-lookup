namespace dotnet_error_lookup.Data.Errors;

public class CS9067 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9067";
    string IErrorOrWarning.Message => @"Analyzer reference '{0}' specified multiple times";
    string IErrorOrWarning.Explanation => @"[original] Analyzer reference '{0}' specified multiple times";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
