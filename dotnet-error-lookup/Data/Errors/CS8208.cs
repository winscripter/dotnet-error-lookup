namespace dotnet_error_lookup.Data.Errors;

public class CS8208 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8208";
    string IErrorOrWarning.Message => @"It is not legal to use the type 'dynamic' in a pattern.";
    string IErrorOrWarning.Explanation => @"[original] It is not legal to use the type 'dynamic' in a pattern.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
