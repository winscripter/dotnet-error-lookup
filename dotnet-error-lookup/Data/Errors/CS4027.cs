namespace dotnet_error_lookup.Data.Errors;

public class CS4027 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4027";
    string IErrorOrWarning.Message => @"'{0}' does not implement '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
