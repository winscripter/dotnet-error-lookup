namespace dotnet_error_lookup.Data.Errors;

public class CS7055 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7055";
    string IErrorOrWarning.Message => @"Unmanaged type '{0}' is only valid for fields.";
    string IErrorOrWarning.Explanation => @"[original] Unmanaged type '{0}' is only valid for fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
