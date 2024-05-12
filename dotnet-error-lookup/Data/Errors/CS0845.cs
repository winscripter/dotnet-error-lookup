namespace dotnet_error_lookup.Data.Errors;

public class CS0845 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0845";
    string IErrorOrWarning.Message => @"An expression tree lambda may not contain a coalescing operator with a null or default literal left-hand side";
    string IErrorOrWarning.Explanation => @"[original] An expression tree lambda may not contain a coalescing operator with a null or default literal left-hand side";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0845";
}
