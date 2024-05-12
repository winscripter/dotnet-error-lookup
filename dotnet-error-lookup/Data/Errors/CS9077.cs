namespace dotnet_error_lookup.Data.Errors;

public class CS9077 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9077";
    string IErrorOrWarning.Message => @"Cannot return a parameter by reference '{0}' through a ref parameter; it can only be returned in a return statement";
    string IErrorOrWarning.Explanation => @"[original] Cannot return a parameter by reference '{0}' through a ref parameter; it can only be returned in a return statement";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
