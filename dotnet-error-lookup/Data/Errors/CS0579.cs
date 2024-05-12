namespace dotnet_error_lookup.Data.Errors;

public class CS0579 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0579";
    string IErrorOrWarning.Message => @"Duplicate '{0}' attribute";
    string IErrorOrWarning.Explanation => @"[original] Duplicate '{0}' attribute";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0579";
}
