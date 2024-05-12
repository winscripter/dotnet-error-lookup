namespace dotnet_error_lookup.Data.Errors;

public class CS8980 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8980";
    string IErrorOrWarning.Message => @"Slice patterns may only be used once and directly inside a list pattern.";
    string IErrorOrWarning.Explanation => @"[original] Slice patterns may only be used once and directly inside a list pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
