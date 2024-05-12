namespace dotnet_error_lookup.Data.Errors;

public class CS8860 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8860";
    string IErrorOrWarning.Message => @"Types and aliases should not be named 'record'.";
    string IErrorOrWarning.Explanation => @"[original] Types and aliases should not be named 'record'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
