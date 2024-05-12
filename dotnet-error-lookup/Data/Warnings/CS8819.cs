namespace dotnet_error_lookup.Data.Errors;

public class CS8819 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8819";
    string IErrorOrWarning.Message => @"Nullability of reference types in return type doesn't match partial method declaration.";
    string IErrorOrWarning.Explanation => @"[original] Nullability of reference types in return type doesn't match partial method declaration.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings";
}
