namespace dotnet_error_lookup.Data.Errors;

public class CS8881 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8881";
    string IErrorOrWarning.Message => @"Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.Explanation => @"[original] Field '{0}' must be fully assigned before control is returned to the caller. Consider updating to language version '{1}' to auto-default the field.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
