namespace dotnet_error_lookup.Data.Errors;

public class CS0201 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0201";
    string IErrorOrWarning.Message => @"Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement";
    string IErrorOrWarning.Explanation => @"[original] Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0201";
}
