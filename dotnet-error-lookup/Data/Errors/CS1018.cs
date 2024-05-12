namespace dotnet_error_lookup.Data.Errors;

public class CS1018 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1018";
    string IErrorOrWarning.Message => @"Keyword 'this' or 'base' expected";
    string IErrorOrWarning.Explanation => @"[original] Keyword 'this' or 'base' expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1018";
}
