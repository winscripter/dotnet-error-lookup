namespace dotnet_error_lookup.Data.Errors;

public class CS8082 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8082";
    string IErrorOrWarning.Message => @"Sub-expression cannot be used in an argument to nameof.";
    string IErrorOrWarning.Explanation => @"[original] Sub-expression cannot be used in an argument to nameof.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
