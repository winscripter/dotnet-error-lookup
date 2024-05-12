namespace dotnet_error_lookup.Data.Errors;

public class CS8953 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8953";
    string IErrorOrWarning.Message => @"An interpolated string handler construction cannot use dynamic. Manually construct an instance of '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] An interpolated string handler construction cannot use dynamic. Manually construct an instance of '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
