namespace dotnet_error_lookup.Data.Errors;

public class CS9029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9029";
    string IErrorOrWarning.Message => @"Types and aliases cannot be named 'required'.";
    string IErrorOrWarning.Explanation => @"[original] Types and aliases cannot be named 'required'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
