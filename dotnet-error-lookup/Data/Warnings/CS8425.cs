namespace dotnet_error_lookup.Data.Errors;

public class CS8425 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8425";
    string IErrorOrWarning.Message => @"Async-iterator '{0}' has one or more parameters of type 'CancellationToken' but none of them is decorated with the 'EnumeratorCancellation' attribute, so the cancellation token parameter from the generated 'IAsyncEnumerable\<\>.GetAsyncEnumerator' will be unconsumed";
    string IErrorOrWarning.Explanation => @"[original] Async-iterator '{0}' has one or more parameters of type 'CancellationToken' but none of them is decorated with the 'EnumeratorCancellation' attribute, so the cancellation token parameter from the generated 'IAsyncEnumerable\<\>.GetAsyncEnumerator' will be unconsumed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
