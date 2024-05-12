namespace dotnet_error_lookup.Data.Errors;

public class CS8414 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8414";
    string IErrorOrWarning.Message => @"foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'await foreach' rather than 'foreach'?";
    string IErrorOrWarning.Explanation => @"[original] foreach statement cannot operate on variables of type '{0}' because '{0}' does not contain a public instance or extension definition for '{1}'. Did you mean 'await foreach' rather than 'foreach'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
