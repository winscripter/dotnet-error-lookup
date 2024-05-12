namespace dotnet_error_lookup.Data.Errors;

public class CS7029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7029";
    string IErrorOrWarning.Message => @"Friend access was granted by '{0}', but the strong name signing state of the output assembly does not match that of the granting assembly.";
    string IErrorOrWarning.Explanation => @"[original] Friend access was granted by '{0}', but the strong name signing state of the output assembly does not match that of the granting assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
