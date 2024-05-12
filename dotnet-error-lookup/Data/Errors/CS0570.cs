namespace dotnet_error_lookup.Data.Errors;

public class CS0570 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0570";
    string IErrorOrWarning.Message => @"'{0}' is not supported by the language";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not supported by the language";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0570";
}
