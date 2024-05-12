namespace dotnet_error_lookup.Data.Errors;

public class CS8872 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8872";
    string IErrorOrWarning.Message => @"'{0}' must allow overriding because the containing record is not sealed.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' must allow overriding because the containing record is not sealed.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
