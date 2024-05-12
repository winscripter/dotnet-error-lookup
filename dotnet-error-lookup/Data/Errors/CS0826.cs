namespace dotnet_error_lookup.Data.Errors;

public class CS0826 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0826";
    string IErrorOrWarning.Message => @"No best type found for implicitly-typed array";
    string IErrorOrWarning.Explanation => @"[original] No best type found for implicitly-typed array";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0826";
}
