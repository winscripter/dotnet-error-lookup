namespace dotnet_error_lookup.Data.Errors;

public class CS8093 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8093";
    string IErrorOrWarning.Message => @"Extension method groups are not allowed as an argument to 'nameof'.";
    string IErrorOrWarning.Explanation => @"[original] Extension method groups are not allowed as an argument to 'nameof'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
