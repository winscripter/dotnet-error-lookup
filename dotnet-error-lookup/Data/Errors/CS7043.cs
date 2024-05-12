namespace dotnet_error_lookup.Data.Errors;

public class CS7043 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7043";
    string IErrorOrWarning.Message => @"Cannot update '{0}'; attribute '{1}' is missing.";
    string IErrorOrWarning.Explanation => @"[original] Cannot update '{0}'; attribute '{1}' is missing.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
