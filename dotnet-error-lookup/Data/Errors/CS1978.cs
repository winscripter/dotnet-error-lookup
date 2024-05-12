namespace dotnet_error_lookup.Data.Errors;

public class CS1978 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1978";
    string IErrorOrWarning.Message => @"Cannot use an expression of type '{0}' as an argument to a dynamically dispatched operation.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use an expression of type '{0}' as an argument to a dynamically dispatched operation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
