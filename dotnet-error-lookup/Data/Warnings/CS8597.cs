namespace dotnet_error_lookup.Data.Errors;

public class CS8597 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8597";
    string IErrorOrWarning.Message => @"Thrown value may be null.";
    string IErrorOrWarning.Explanation => @"[original] Thrown value may be null.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
