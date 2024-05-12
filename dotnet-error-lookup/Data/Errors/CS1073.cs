namespace dotnet_error_lookup.Data.Errors;

public class CS1073 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1073";
    string IErrorOrWarning.Message => @"Unexpected token '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Unexpected token '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
