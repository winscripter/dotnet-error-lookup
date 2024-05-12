namespace dotnet_error_lookup.Data.Errors;

public class CS7071 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7071";
    string IErrorOrWarning.Message => @"Assembly reference '{0}' is invalid and cannot be resolved";
    string IErrorOrWarning.Explanation => @"[original] Assembly reference '{0}' is invalid and cannot be resolved";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
