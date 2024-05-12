namespace dotnet_error_lookup.Data.Errors;

public class CS8415 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8415";
    string IErrorOrWarning.Message => @"Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'foreach' rather than 'await foreach'?";
    string IErrorOrWarning.Explanation => @"[original] Asynchronous foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'foreach' rather than 'await foreach'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
