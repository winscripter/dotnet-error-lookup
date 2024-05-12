namespace dotnet_error_lookup.Data.Errors;

public class CS9094 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9094";
    string IErrorOrWarning.Message => @"This returns a parameter by reference '{0}' through a ref parameter; but it can only safely be returned in a return statement";
    string IErrorOrWarning.Explanation => @"[original] This returns a parameter by reference '{0}' through a ref parameter; but it can only safely be returned in a return statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
