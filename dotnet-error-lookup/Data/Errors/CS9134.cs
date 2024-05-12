namespace dotnet_error_lookup.Data.Errors;

public class CS9134 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9134";
    string IErrorOrWarning.Message => @"A switch expression arm does not begin with a 'case' keyword.";
    string IErrorOrWarning.Explanation => @"[original] A switch expression arm does not begin with a 'case' keyword.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
