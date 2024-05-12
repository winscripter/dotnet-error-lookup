namespace dotnet_error_lookup.Data.Errors;

public class CS8861 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8861";
    string IErrorOrWarning.Message => @"Unexpected argument list.";
    string IErrorOrWarning.Explanation => @"[original] Unexpected argument list.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
