namespace dotnet_error_lookup.Data.Errors;

public class CS8162 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8162";
    string IErrorOrWarning.Message => @"Members of readonly field '{0}' cannot be returned by writable reference";
    string IErrorOrWarning.Explanation => @"[original] Members of readonly field '{0}' cannot be returned by writable reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8162";
}
