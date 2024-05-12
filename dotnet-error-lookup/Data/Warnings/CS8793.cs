namespace dotnet_error_lookup.Data.Errors;

public class CS8793 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8793";
    string IErrorOrWarning.Message => @"The given expression always matches the provided pattern.";
    string IErrorOrWarning.Explanation => @"[original] The given expression always matches the provided pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
