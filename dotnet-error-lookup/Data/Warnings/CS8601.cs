namespace dotnet_error_lookup.Data.Errors;

public class CS8601 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8601";
    string IErrorOrWarning.Message => @"Possible null reference assignment.";
    string IErrorOrWarning.Explanation => @"[original] Possible null reference assignment.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
