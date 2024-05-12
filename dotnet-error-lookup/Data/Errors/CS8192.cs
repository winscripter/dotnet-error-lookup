namespace dotnet_error_lookup.Data.Errors;

public class CS8192 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8192";
    string IErrorOrWarning.Message => @"Provided language version is unsupported or invalid: '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Provided language version is unsupported or invalid: '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
