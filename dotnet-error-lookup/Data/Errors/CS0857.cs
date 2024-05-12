namespace dotnet_error_lookup.Data.Errors;

public class CS0857 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0857";
    string IErrorOrWarning.Message => @"Indexed property '{0}' must have all arguments optional";
    string IErrorOrWarning.Explanation => @"[original] Indexed property '{0}' must have all arguments optional";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
