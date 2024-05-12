namespace dotnet_error_lookup.Data.Errors;

public class CS8778 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8778";
    string IErrorOrWarning.Message => @"Constant value '{0}' may overflow '{1}' at runtime (use 'unchecked' syntax to override)";
    string IErrorOrWarning.Explanation => @"[original] Constant value '{0}' may overflow '{1}' at runtime (use 'unchecked' syntax to override)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
