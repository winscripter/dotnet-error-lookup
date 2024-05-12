namespace dotnet_error_lookup.Data.Errors;

public class CS8866 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8866";
    string IErrorOrWarning.Message => @"Record member '{0}' must be a readable instance property or field of type '{1}' to match positional parameter '{2}'.";
    string IErrorOrWarning.Explanation => @"[original] Record member '{0}' must be a readable instance property or field of type '{1}' to match positional parameter '{2}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
