namespace dotnet_error_lookup.Data.Errors;

public class CS8885 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8885";
    string IErrorOrWarning.Message => @"The 'this' object cannot be used before all of its fields have been assigned. Consider updating to language version '{0}' to auto-default the unassigned fields.";
    string IErrorOrWarning.Explanation => @"[original] The 'this' object cannot be used before all of its fields have been assigned. Consider updating to language version '{0}' to auto-default the unassigned fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
