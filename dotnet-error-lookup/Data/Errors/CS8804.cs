namespace dotnet_error_lookup.Data.Errors;

public class CS8804 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8804";
    string IErrorOrWarning.Message => @"Cannot specify /main if there is a compilation unit with top-level statements.";
    string IErrorOrWarning.Explanation => @"[original] Cannot specify /main if there is a compilation unit with top-level statements.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
