namespace dotnet_error_lookup.Data.Errors;

public class CS1019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1019";
    string IErrorOrWarning.Message => @"Overloadable unary operator expected";
    string IErrorOrWarning.Explanation => @"[original] Overloadable unary operator expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1019";
}
