namespace dotnet_error_lookup.Data.Errors;

public class CS0563 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0563";
    string IErrorOrWarning.Message => @"One of the parameters of a binary operator must be the containing type";
    string IErrorOrWarning.Explanation => @"[original] One of the parameters of a binary operator must be the containing type";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0563";
}
