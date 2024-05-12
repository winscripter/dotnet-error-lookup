namespace dotnet_error_lookup.Data.Errors;

public class CS4001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4001";
    string IErrorOrWarning.Message => @"Cannot await '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot await '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
