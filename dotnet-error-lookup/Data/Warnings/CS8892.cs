namespace dotnet_error_lookup.Data.Errors;

public class CS8892 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8892";
    string IErrorOrWarning.Message => @"Method '{0}' will not be used as an entry point because a synchronous entry point '{1}' was found.";
    string IErrorOrWarning.Explanation => @"[original] Method '{0}' will not be used as an entry point because a synchronous entry point '{1}' was found.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
