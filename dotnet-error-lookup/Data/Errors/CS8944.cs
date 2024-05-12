namespace dotnet_error_lookup.Data.Errors;

public class CS8944 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8944";
    string IErrorOrWarning.Message => @"'{0}' is not an instance method, the receiver cannot be an interpolated string handler argument.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not an instance method, the receiver cannot be an interpolated string handler argument.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
