namespace dotnet_error_lookup.Data.Errors;

public class CS7000 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7000";
    string IErrorOrWarning.Message => @"Unexpected use of an aliased name";
    string IErrorOrWarning.Explanation => @"[original] Unexpected use of an aliased name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs7000";
}
