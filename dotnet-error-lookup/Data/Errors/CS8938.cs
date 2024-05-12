namespace dotnet_error_lookup.Data.Errors;

public class CS8938 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8938";
    string IErrorOrWarning.Message => @"The #line directive value is missing or out of range";
    string IErrorOrWarning.Explanation => @"[original] The #line directive value is missing or out of range";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
