namespace dotnet_error_lookup.Data.Errors;

public class CS8519 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8519";
    string IErrorOrWarning.Message => @"The given expression never matches the provided pattern.";
    string IErrorOrWarning.Explanation => @"[original] The given expression never matches the provided pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
