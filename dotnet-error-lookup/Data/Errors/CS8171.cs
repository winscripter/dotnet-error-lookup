namespace dotnet_error_lookup.Data.Errors;

public class CS8171 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8171";
    string IErrorOrWarning.Message => @"Cannot initialize a by-value variable with a reference";
    string IErrorOrWarning.Explanation => @"[original] Cannot initialize a by-value variable with a reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8171";
}
