namespace dotnet_error_lookup.Data.Errors;

public class CS7003 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7003";
    string IErrorOrWarning.Message => @"Unexpected use of an unbound generic name";
    string IErrorOrWarning.Explanation => @"[original] Unexpected use of an unbound generic name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs7003";
}
