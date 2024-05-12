namespace dotnet_error_lookup.Data.Errors;

public class CS8088 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8088";
    string IErrorOrWarning.Message => @"A format specifier may not contain trailing whitespace.";
    string IErrorOrWarning.Explanation => @"[original] A format specifier may not contain trailing whitespace.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
