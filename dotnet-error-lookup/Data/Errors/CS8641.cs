namespace dotnet_error_lookup.Data.Errors;

public class CS8641 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8641";
    string IErrorOrWarning.Message => @"'else' cannot start a statement.";
    string IErrorOrWarning.Explanation => @"[original] 'else' cannot start a statement.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
