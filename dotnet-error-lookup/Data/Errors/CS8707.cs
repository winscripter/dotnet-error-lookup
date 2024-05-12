namespace dotnet_error_lookup.Data.Errors;

public class CS8707 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8707";
    string IErrorOrWarning.Message => @"Target runtime doesn't support 'protected', 'protected internal', or 'private protected' accessibility for a member of an interface.";
    string IErrorOrWarning.Explanation => @"[original] Target runtime doesn't support 'protected', 'protected internal', or 'private protected' accessibility for a member of an interface.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
