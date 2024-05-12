namespace dotnet_error_lookup.Data.Errors;

public class CS8161 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8161";
    string IErrorOrWarning.Message => @"A static readonly field cannot be returned by writable reference";
    string IErrorOrWarning.Explanation => @"[original] A static readonly field cannot be returned by writable reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8161";
}
