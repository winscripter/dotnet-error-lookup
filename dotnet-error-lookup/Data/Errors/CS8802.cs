namespace dotnet_error_lookup.Data.Errors;

public class CS8802 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8802";
    string IErrorOrWarning.Message => @"Only one compilation unit can have top-level statements.";
    string IErrorOrWarning.Explanation => @"[original] Only one compilation unit can have top-level statements.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
