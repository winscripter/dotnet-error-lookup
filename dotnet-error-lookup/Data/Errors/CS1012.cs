namespace dotnet_error_lookup.Data.Errors;

public class CS1012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1012";
    string IErrorOrWarning.Message => @"Too many characters in character literal";
    string IErrorOrWarning.Explanation => @"[original] Too many characters in character literal";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs1012";
}
