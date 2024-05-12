namespace dotnet_error_lookup.Data.Errors;

public class CS8795 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8795";
    string IErrorOrWarning.Message => @"Partial method '{0}' must have an implementation part because it has accessibility modifiers.";
    string IErrorOrWarning.Explanation => @"[original] Partial method '{0}' must have an implementation part because it has accessibility modifiers.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
