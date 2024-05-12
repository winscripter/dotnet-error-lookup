namespace dotnet_error_lookup.Data.Errors;

public class CS1001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1001";
    string IErrorOrWarning.Message => @"Identifier expected";
    string IErrorOrWarning.Explanation => @"[original] Identifier expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1001";
}
