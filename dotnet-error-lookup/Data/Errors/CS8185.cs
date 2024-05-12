namespace dotnet_error_lookup.Data.Errors;

public class CS8185 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8185";
    string IErrorOrWarning.Message => @"A declaration is not allowed in this context.";
    string IErrorOrWarning.Explanation => @"[original] A declaration is not allowed in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
