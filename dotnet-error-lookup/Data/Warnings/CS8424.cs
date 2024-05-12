namespace dotnet_error_lookup.Data.Errors;

public class CS8424 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8424";
    string IErrorOrWarning.Message => @"The EnumeratorCancellationAttribute applied to parameter '{0}' will have no effect. The attribute is only effective on a parameter of type CancellationToken in an async-iterator method returning IAsyncEnumerable";
    string IErrorOrWarning.Explanation => @"[original] The EnumeratorCancellationAttribute applied to parameter '{0}' will have no effect. The attribute is only effective on a parameter of type CancellationToken in an async-iterator method returning IAsyncEnumerable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
