namespace dotnet_error_lookup.Data.Errors;

public class CS9078 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9078";
    string IErrorOrWarning.Message => @"Cannot return by reference a member of parameter '{0}' through a ref parameter; it can only be returned in a return statement";
    string IErrorOrWarning.Explanation => @"[original] Cannot return by reference a member of parameter '{0}' through a ref parameter; it can only be returned in a return statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
