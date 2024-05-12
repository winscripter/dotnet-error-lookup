namespace dotnet_error_lookup.Data.Errors;

public class CS8508 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8508";
    string IErrorOrWarning.Message => @"The syntax 'var' for a pattern is not permitted to refer to a type, but '{0}' is in scope here.";
    string IErrorOrWarning.Explanation => @"[original] The syntax 'var' for a pattern is not permitted to refer to a type, but '{0}' is in scope here.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
