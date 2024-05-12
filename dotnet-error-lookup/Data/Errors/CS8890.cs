namespace dotnet_error_lookup.Data.Errors;

public class CS8890 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8890";
    string IErrorOrWarning.Message => @"Type '{0}' is not defined.";
    string IErrorOrWarning.Explanation => @"[original] Type '{0}' is not defined.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
