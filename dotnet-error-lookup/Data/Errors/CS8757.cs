namespace dotnet_error_lookup.Data.Errors;

public class CS8757 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8757";
    string IErrorOrWarning.Message => @"No overload for '{0}' matches function pointer '{1}'";
    string IErrorOrWarning.Explanation => @"[original] No overload for '{0}' matches function pointer '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
