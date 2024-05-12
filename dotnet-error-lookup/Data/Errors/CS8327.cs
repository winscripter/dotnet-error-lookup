namespace dotnet_error_lookup.Data.Errors;

public class CS8327 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8327";
    string IErrorOrWarning.Message => @"The expression must be of type '{0}' to match the alternative ref value";
    string IErrorOrWarning.Explanation => @"[original] The expression must be of type '{0}' to match the alternative ref value";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
