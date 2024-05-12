namespace dotnet_error_lookup.Data.Errors;

public class CS8099 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8099";
    string IErrorOrWarning.Message => @"Source file references are not supported.";
    string IErrorOrWarning.Explanation => @"[original] Source file references are not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
