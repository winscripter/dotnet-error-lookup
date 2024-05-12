namespace dotnet_error_lookup.Data.Errors;

public class CS8146 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8146";
    string IErrorOrWarning.Message => @"Properties which return by reference must have a get accessor";
    string IErrorOrWarning.Explanation => @"[original] Properties which return by reference must have a get accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8146";
}
