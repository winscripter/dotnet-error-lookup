namespace dotnet_error_lookup.Data.Errors;

public class CS8160 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8160";
    string IErrorOrWarning.Message => @"A readonly field cannot be returned by writable reference";
    string IErrorOrWarning.Explanation => @"[original] A readonly field cannot be returned by writable reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8160";
}
