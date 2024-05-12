namespace dotnet_error_lookup.Data.Errors;

public class CS7096 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7096";
    string IErrorOrWarning.Message => @"Cannot continue since the edit includes a reference to an embedded type: '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot continue since the edit includes a reference to an embedded type: '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
