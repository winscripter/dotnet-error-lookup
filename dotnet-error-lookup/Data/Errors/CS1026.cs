namespace dotnet_error_lookup.Data.Errors;

public class CS1026 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1026";
    string IErrorOrWarning.Message => @") expected";
    string IErrorOrWarning.Explanation => @"[original] ) expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1026";
}
