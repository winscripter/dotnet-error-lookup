namespace dotnet_error_lookup.Data.Errors;

public class CS9013 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9013";
    string IErrorOrWarning.Message => @"A string 'null' constant is not supported as a pattern for '{0}'. Use an empty string instead.";
    string IErrorOrWarning.Explanation => @"[original] A string 'null' constant is not supported as a pattern for '{0}'. Use an empty string instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
