namespace dotnet_error_lookup.Data.Errors;

public class CS8156 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8156";
    string IErrorOrWarning.Message => @"An expression cannot be used in this context because it may not be passed or returned by reference";
    string IErrorOrWarning.Explanation => @"[original] An expression cannot be used in this context because it may not be passed or returned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8156";
}
