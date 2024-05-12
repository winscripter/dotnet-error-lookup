namespace dotnet_error_lookup.Data.Errors;

public class CS1564 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1564";
    string IErrorOrWarning.Message => @"Conflicting options specified: Win32 resource file; Win32 manifest";
    string IErrorOrWarning.Explanation => @"[original] Conflicting options specified: Win32 resource file; Win32 manifest";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1564";
}
