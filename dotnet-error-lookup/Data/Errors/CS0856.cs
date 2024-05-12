namespace dotnet_error_lookup.Data.Errors;

public class CS0856 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0856";
    string IErrorOrWarning.Message => @"Indexed property '{0}' has non-optional arguments which must be provided";
    string IErrorOrWarning.Explanation => @"[original] Indexed property '{0}' has non-optional arguments which must be provided";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
