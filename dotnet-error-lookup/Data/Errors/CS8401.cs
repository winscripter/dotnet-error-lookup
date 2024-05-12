namespace dotnet_error_lookup.Data.Errors;

public class CS8401 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8401";
    string IErrorOrWarning.Message => @"To use '@$' instead of '$@' for an interpolated verbatim string, please use language version '{0}' or greater.";
    string IErrorOrWarning.Explanation => @"[original] To use '@$' instead of '$@' for an interpolated verbatim string, please use language version '{0}' or greater.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
