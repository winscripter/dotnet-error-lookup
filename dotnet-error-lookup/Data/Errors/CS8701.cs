namespace dotnet_error_lookup.Data.Errors;

public class CS8701 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8701";
    string IErrorOrWarning.Message => @"Target runtime doesn't support default interface implementation.";
    string IErrorOrWarning.Explanation => @"[original] Target runtime doesn't support default interface implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
