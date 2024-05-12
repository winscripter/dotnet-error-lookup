namespace dotnet_error_lookup.Data.Errors;

public class CS7038 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7038";
    string IErrorOrWarning.Message => @"Failed to emit module '{0}': {1}";
    string IErrorOrWarning.Explanation => @"[original] Failed to emit module '{0}': {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
