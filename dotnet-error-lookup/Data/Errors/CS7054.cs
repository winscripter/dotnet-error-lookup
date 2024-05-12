namespace dotnet_error_lookup.Data.Errors;

public class CS7054 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7054";
    string IErrorOrWarning.Message => @"Unmanaged type '{0}' not valid for fields.";
    string IErrorOrWarning.Explanation => @"[original] Unmanaged type '{0}' not valid for fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
