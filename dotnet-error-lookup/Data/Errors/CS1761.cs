namespace dotnet_error_lookup.Data.Errors;

public class CS1761 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1761";
    string IErrorOrWarning.Message => @"Embedding the interop type '{0}' from assembly '{1}' causes a name clash in the current assembly. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.Explanation => @"[original] Embedding the interop type '{0}' from assembly '{1}' causes a name clash in the current assembly. Consider setting the 'Embed Interop Types' property to false.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
