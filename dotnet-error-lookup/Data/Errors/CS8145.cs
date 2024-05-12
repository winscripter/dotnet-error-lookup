namespace dotnet_error_lookup.Data.Errors;

public class CS8145 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8145";
    string IErrorOrWarning.Message => @"Auto-implemented properties cannot return by reference";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented properties cannot return by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8145";
}
