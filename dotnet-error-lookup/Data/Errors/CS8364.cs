namespace dotnet_error_lookup.Data.Errors;

public class CS8364 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8364";
    string IErrorOrWarning.Message => @"Arguments with 'in' modifier cannot be used in dynamically dispatched expressions.";
    string IErrorOrWarning.Explanation => @"[original] Arguments with 'in' modifier cannot be used in dynamically dispatched expressions.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
