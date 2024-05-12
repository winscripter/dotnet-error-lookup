namespace dotnet_error_lookup.Data.Errors;

public class CS7061 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7061";
    string IErrorOrWarning.Message => @"Duplicate '{0}' attribute in '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Duplicate '{0}' attribute in '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
