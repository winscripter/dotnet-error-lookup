namespace dotnet_error_lookup.Data.Errors;

public class CS8172 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8172";
    string IErrorOrWarning.Message => @"Cannot initialize a by-reference variable with a value";
    string IErrorOrWarning.Explanation => @"[original] Cannot initialize a by-reference variable with a value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8172";
}
