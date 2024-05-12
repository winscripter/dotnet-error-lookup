namespace dotnet_error_lookup.Data.Errors;

public class CS1009 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1009";
    string IErrorOrWarning.Message => @"Unrecognized escape sequence";
    string IErrorOrWarning.Explanation => @"[original] Unrecognized escape sequence";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1009";
}
