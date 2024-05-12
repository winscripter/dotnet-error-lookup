namespace dotnet_error_lookup.Data.Errors;

public class CS9113 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9113";
    string IErrorOrWarning.Message => @"Parameter '{0}' is unread.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' is unread.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
