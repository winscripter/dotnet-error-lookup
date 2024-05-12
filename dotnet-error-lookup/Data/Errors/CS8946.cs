namespace dotnet_error_lookup.Data.Errors;

public class CS8946 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8946";
    string IErrorOrWarning.Message => @"'{0}' is not an interpolated string handler type.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not an interpolated string handler type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
