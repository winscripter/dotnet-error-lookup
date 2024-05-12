namespace dotnet_error_lookup.Data.Errors;

public class CS8803 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8803";
    string IErrorOrWarning.Message => @"Top-level statements must precede namespace and type declarations.";
    string IErrorOrWarning.Explanation => @"[original] Top-level statements must precede namespace and type declarations.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8803";
}
