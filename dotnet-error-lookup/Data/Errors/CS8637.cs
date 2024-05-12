namespace dotnet_error_lookup.Data.Errors;

public class CS8637 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8637";
    string IErrorOrWarning.Message => @"Expected 'enable', 'disable', or 'restore'";
    string IErrorOrWarning.Explanation => @"[original] Expected 'enable', 'disable', or 'restore'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
