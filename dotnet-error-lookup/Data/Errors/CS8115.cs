namespace dotnet_error_lookup.Data.Errors;

public class CS8115 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8115";
    string IErrorOrWarning.Message => @"A throw expression is not allowed in this context.";
    string IErrorOrWarning.Explanation => @"[original] A throw expression is not allowed in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
