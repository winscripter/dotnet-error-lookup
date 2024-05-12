namespace dotnet_error_lookup.Data.Errors;

public class CS2041 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2041";
    string IErrorOrWarning.Message => @"Invalid output name: {0}";
    string IErrorOrWarning.Explanation => @"[original] Invalid output name: {0}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
