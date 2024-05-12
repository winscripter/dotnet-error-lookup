namespace dotnet_error_lookup.Data.Errors;

public class CS8303 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8303";
    string IErrorOrWarning.Message => @"Specified language version '{0}' cannot have leading zeroes";
    string IErrorOrWarning.Explanation => @"[original] Specified language version '{0}' cannot have leading zeroes";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/feature-version-errors";
}
