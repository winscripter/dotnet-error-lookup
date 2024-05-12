namespace dotnet_error_lookup.Data.Errors;

public class CS8602 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8602";
    string IErrorOrWarning.Message => @"Dereference of a possibly null reference.";
    string IErrorOrWarning.Explanation => @"[original] Dereference of a possibly null reference.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
