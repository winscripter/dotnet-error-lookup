namespace dotnet_error_lookup.Data.Errors;

public class CS8754 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8754";
    string IErrorOrWarning.Message => @"There is no target type for '{0}'";
    string IErrorOrWarning.Explanation => @"[original] There is no target type for '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
