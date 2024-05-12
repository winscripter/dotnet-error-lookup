namespace dotnet_error_lookup.Data.Errors;

public class CS8605 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8605";
    string IErrorOrWarning.Message => @"Unboxing a possibly null value.";
    string IErrorOrWarning.Explanation => @"[original] Unboxing a possibly null value.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
