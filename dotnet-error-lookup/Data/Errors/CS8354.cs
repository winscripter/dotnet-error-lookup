namespace dotnet_error_lookup.Data.Errors;

public class CS8354 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8354";
    string IErrorOrWarning.Message => @"Cannot return 'this' by reference.";
    string IErrorOrWarning.Explanation => @"[original] Cannot return 'this' by reference.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8354";
}
