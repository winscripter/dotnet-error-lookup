namespace dotnet_error_lookup.Data.Errors;

public class CS9064 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9064";
    string IErrorOrWarning.Message => @"Target runtime doesn't support ref fields.";
    string IErrorOrWarning.Explanation => @"[original] Target runtime doesn't support ref fields.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
