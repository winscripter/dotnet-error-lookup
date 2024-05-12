namespace dotnet_error_lookup.Data.Errors;

public class CS8089 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8089";
    string IErrorOrWarning.Message => @"Empty format specifier.";
    string IErrorOrWarning.Explanation => @"[original] Empty format specifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
