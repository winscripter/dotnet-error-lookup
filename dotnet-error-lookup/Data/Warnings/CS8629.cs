namespace dotnet_error_lookup.Data.Errors;

public class CS8629 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8629";
    string IErrorOrWarning.Message => @"Nullable value type may be null.";
    string IErrorOrWarning.Explanation => @"[original] Nullable value type may be null.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
