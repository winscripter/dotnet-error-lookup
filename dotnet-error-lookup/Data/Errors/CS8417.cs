namespace dotnet_error_lookup.Data.Errors;

public class CS8417 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8417";
    string IErrorOrWarning.Message => @"'{0}': type used in an asynchronous using statement must be implicitly convertible to 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method. Did you mean 'using' rather than 'await using'?";
    string IErrorOrWarning.Explanation => @"[original] '{0}': type used in an asynchronous using statement must be implicitly convertible to 'System.IAsyncDisposable' or implement a suitable 'DisposeAsync' method. Did you mean 'using' rather than 'await using'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
