namespace dotnet_error_lookup.Data.Errors;

public class CS8716 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8716";
    string IErrorOrWarning.Message => @"There is no target type for the default literal.";
    string IErrorOrWarning.Explanation => @"[original] There is no target type for the default literal.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
