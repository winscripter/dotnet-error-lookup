namespace dotnet_error_lookup.Data.Errors;

public class CS4007 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4007";
    string IErrorOrWarning.Message => @"'await' cannot be used in an expression containing the type '{0}'";
    string IErrorOrWarning.Explanation => @"[original] 'await' cannot be used in an expression containing the type '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
