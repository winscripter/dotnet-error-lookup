namespace dotnet_error_lookup.Data.Errors;

public class CS8797 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8797";
    string IErrorOrWarning.Message => @"Partial method '{0}' must have accessibility modifiers because it has 'out' parameters.";
    string IErrorOrWarning.Explanation => @"[original] Partial method '{0}' must have accessibility modifiers because it has 'out' parameters.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
