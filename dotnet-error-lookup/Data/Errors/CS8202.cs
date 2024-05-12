namespace dotnet_error_lookup.Data.Errors;

public class CS8202 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8202";
    string IErrorOrWarning.Message => @"Public signing is not supported for netmodules.";
    string IErrorOrWarning.Explanation => @"[original] Public signing is not supported for netmodules.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
