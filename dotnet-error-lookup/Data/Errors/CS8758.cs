namespace dotnet_error_lookup.Data.Errors;

public class CS8758 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8758";
    string IErrorOrWarning.Message => @"Ref mismatch between '{0}' and function pointer '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Ref mismatch between '{0}' and function pointer '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
