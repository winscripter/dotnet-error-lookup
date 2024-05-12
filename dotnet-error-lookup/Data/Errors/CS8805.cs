namespace dotnet_error_lookup.Data.Errors;

public class CS8805 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8805";
    string IErrorOrWarning.Message => @"Program using top-level statements must be an executable.";
    string IErrorOrWarning.Explanation => @"[original] Program using top-level statements must be an executable.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
