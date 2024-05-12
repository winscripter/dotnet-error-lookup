namespace dotnet_error_lookup.Data.Errors;

public class CS8919 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8919";
    string IErrorOrWarning.Message => @"Target runtime doesn't support static abstract members in interfaces.";
    string IErrorOrWarning.Explanation => @"[original] Target runtime doesn't support static abstract members in interfaces.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
