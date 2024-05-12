namespace dotnet_error_lookup.Data.Errors;

public class CS8798 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8798";
    string IErrorOrWarning.Message => @"Partial method '{0}' must have accessibility modifiers because it has a 'virtual', 'override', 'sealed', 'new', or 'extern' modifier.";
    string IErrorOrWarning.Explanation => @"[original] Partial method '{0}' must have accessibility modifiers because it has a 'virtual', 'override', 'sealed', 'new', or 'extern' modifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
