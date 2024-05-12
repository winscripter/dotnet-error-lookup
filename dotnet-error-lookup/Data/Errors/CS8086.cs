namespace dotnet_error_lookup.Data.Errors;

public class CS8086 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8086";
    string IErrorOrWarning.Message => @"A '{0}' character must be escaped (by doubling) in an interpolated string.";
    string IErrorOrWarning.Explanation => @"[original] A '{0}' character must be escaped (by doubling) in an interpolated string.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
