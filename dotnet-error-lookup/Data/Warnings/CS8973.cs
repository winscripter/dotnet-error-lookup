namespace dotnet_error_lookup.Data.Errors;

public class CS8973 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8973";
    string IErrorOrWarning.Message => @"The operation may overflow '{0}' at runtime (use 'unchecked' syntax to override)";
    string IErrorOrWarning.Explanation => @"[original] The operation may overflow '{0}' at runtime (use 'unchecked' syntax to override)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
