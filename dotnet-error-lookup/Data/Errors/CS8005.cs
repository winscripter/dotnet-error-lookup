namespace dotnet_error_lookup.Data.Errors;

public class CS8005 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8005";
    string IErrorOrWarning.Message => @"Type '{0}' exported from module '{1}' conflicts with type '{2}' exported from module '{3}'.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' exported from module '{1}' conflicts with type '{2}' exported from module '{3}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
