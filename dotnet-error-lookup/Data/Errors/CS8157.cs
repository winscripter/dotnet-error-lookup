namespace dotnet_error_lookup.Data.Errors;

public class CS8157 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8157";
    string IErrorOrWarning.Message => @"Cannot return '{0}' by reference because it was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.Explanation => @"[original] Cannot return '{0}' by reference because it was initialized to a value that cannot be returned by reference";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8157";
}
