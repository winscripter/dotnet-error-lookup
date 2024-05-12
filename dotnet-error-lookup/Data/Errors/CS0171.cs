namespace dotnet_error_lookup.Data.Errors;

public class CS0171 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0171";
    string IErrorOrWarning.Message => @"Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.Explanation => @"[original] Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
