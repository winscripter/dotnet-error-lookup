namespace dotnet_error_lookup.Data.Errors;

public class CS7036 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7036";
    string IErrorOrWarning.Message => @"There is no argument given that corresponds to the required parameter '{0}' of '{1}'";
    string IErrorOrWarning.Explanation => @"[original] There is no argument given that corresponds to the required parameter '{0}' of '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
