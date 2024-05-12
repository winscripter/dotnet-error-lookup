namespace dotnet_error_lookup.Data.Errors;

public class CS9062 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9062";
    string IErrorOrWarning.Message => @"Types and aliases cannot be named 'scoped'.";
    string IErrorOrWarning.Explanation => @"[original] Types and aliases cannot be named 'scoped'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
