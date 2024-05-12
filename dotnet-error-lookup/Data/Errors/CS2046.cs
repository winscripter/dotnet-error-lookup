namespace dotnet_error_lookup.Data.Errors;

public class CS2046 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS2046";
    string IErrorOrWarning.Message => @"Command-line syntax error: '{0}' is not a valid value for the '{1}' option. The value must be of the form '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Command-line syntax error: '{0}' is not a valid value for the '{1}' option. The value must be of the form '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
