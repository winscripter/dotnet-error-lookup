namespace dotnet_error_lookup.Data.Errors;

public class CS1758 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1758";
    string IErrorOrWarning.Message => @"Cannot embed interop type '{0}' found in both assembly '{1}' and '{2}'. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.Explanation => @"[original] Cannot embed interop type '{0}' found in both assembly '{1}' and '{2}'. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
