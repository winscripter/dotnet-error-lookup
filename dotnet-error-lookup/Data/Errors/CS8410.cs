namespace dotnet_error_lookup.Data.Errors;

public class CS8410 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8410";
    string IErrorOrWarning.Message => @"'{0}': type used in an asynchronous using statement must be implicitly convertible to 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method.";
    string IErrorOrWarning.Explanation => @"[original] '{0}': type used in an asynchronous using statement must be implicitly convertible to 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8410";
}
