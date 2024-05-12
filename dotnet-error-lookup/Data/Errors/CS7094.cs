namespace dotnet_error_lookup.Data.Errors;

public class CS7094 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7094";
    string IErrorOrWarning.Message => @"Cannot await in the filter expression of a catch clause";
    string IErrorOrWarning.Explanation => @"[original] Cannot await in the filter expression of a catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
