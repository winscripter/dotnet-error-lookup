namespace dotnet_error_lookup.Data.Errors;

public class CS9095 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9095";
    string IErrorOrWarning.Message => @"This returns by reference a member of parameter '{0}' through a ref parameter; but it can only safely be returned in a return statement";
    string IErrorOrWarning.Explanation => @"[original] This returns by reference a member of parameter '{0}' through a ref parameter; but it can only safely be returned in a return statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
