namespace dotnet_error_lookup.Data.Errors;

public class CS8765 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8765";
    string IErrorOrWarning.Message => @"Nullability of type of parameter '{0}' doesn't match overridden member (possibly because of nullability attributes).";
    string IErrorOrWarning.Explanation => @"[original] Nullability of type of parameter '{0}' doesn't match overridden member (possibly because of nullability attributes).";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
