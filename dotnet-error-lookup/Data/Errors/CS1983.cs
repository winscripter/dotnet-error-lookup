namespace dotnet_error_lookup.Data.Errors;

public class CS1983 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1983";
    string IErrorOrWarning.Message => @"The return type of an async method must be void, Task, Task\<T\>, a task-like type, IAsyncEnumerable\<T\>, or IAsyncEnumerator\<T\>";
    string IErrorOrWarning.Explanation => @"[original] The return type of an async method must be void, Task, Task\<T\>, a task-like type, IAsyncEnumerable\<T\>, or IAsyncEnumerator\<T\>";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1983";
}
