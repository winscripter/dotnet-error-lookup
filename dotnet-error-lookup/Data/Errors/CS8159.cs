namespace dotnet_error_lookup.Data.Errors;

public class CS8159 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8159";
    string IErrorOrWarning.Message => @"Cannot return the range variable '{0}' by reference";
    string IErrorOrWarning.Explanation => @"[original] Cannot return the range variable '{0}' by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8159";
}
