namespace dotnet_error_lookup.Data.Errors;

public class CS8147 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8147";
    string IErrorOrWarning.Message => @"Properties which return by reference cannot have set accessors";
    string IErrorOrWarning.Explanation => @"[original] Properties which return by reference cannot have set accessors";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8147";
}
