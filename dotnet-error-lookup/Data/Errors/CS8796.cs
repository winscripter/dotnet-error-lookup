namespace dotnet_error_lookup.Data.Errors;

public class CS8796 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8796";
    string IErrorOrWarning.Message => @"Partial method '{0}' must have accessibility modifiers because it has a non-void return type.";
    string IErrorOrWarning.Explanation => @"[original] Partial method '{0}' must have accessibility modifiers because it has a non-void return type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
