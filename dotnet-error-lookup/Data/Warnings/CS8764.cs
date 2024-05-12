namespace dotnet_error_lookup.Data.Errors;

public class CS8764 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8764";
    string IErrorOrWarning.Message => @"Nullability of return type doesn't match overridden member (possibly because of nullability attributes).";
    string IErrorOrWarning.Explanation => @"[original] Nullability of return type doesn't match overridden member (possibly because of nullability attributes).";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
