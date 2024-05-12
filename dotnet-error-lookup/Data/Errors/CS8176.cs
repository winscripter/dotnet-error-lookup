namespace dotnet_error_lookup.Data.Errors;

public class CS8176 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8176";
    string IErrorOrWarning.Message => @"Iterators cannot have by-reference locals";
    string IErrorOrWarning.Explanation => @"[original] Iterators cannot have by-reference locals";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8176";
}
