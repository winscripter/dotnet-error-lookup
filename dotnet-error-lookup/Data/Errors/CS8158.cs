namespace dotnet_error_lookup.Data.Errors;

public class CS8158 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8158";
    string IErrorOrWarning.Message => @"Cannot return by reference a member of '{0}' because it was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.Explanation => @"[original] Cannot return by reference a member of '{0}' because it was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8158";
}
