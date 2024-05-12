namespace dotnet_error_lookup.Data.Errors;

public class CS8794 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8794";
    string IErrorOrWarning.Message => @"An expression of type '{0}' always matches the provided pattern.";
    string IErrorOrWarning.Explanation => @"[original] An expression of type '{0}' always matches the provided pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
