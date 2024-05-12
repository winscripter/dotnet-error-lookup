namespace dotnet_error_lookup.Data.Errors;

public class CS1926 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1926";
    string IErrorOrWarning.Message => @"Error opening Win32 manifest file {0} -- {1}";
    string IErrorOrWarning.Explanation => @"[original] Error opening Win32 manifest file {0} -- {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1926";
}
