namespace dotnet_error_lookup.Data.Errors;

public class CS8942 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8942";
    string IErrorOrWarning.Message => @"Interpolated string handler method '{0}' has inconsistent return type. Expected to return '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Interpolated string handler method '{0}' has inconsistent return type. Expected to return '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
