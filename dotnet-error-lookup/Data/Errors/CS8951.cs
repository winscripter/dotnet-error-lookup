namespace dotnet_error_lookup.Data.Errors;

public class CS8951 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8951";
    string IErrorOrWarning.Message => @"Parameter '{0}' is not explicitly provided, but is used as an argument to the interpolated string handler conversion on parameter '{1}'. Specify the value of '{0}' before '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' is not explicitly provided, but is used as an argument to the interpolated string handler conversion on parameter '{1}'. Specify the value of '{0}' before '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
