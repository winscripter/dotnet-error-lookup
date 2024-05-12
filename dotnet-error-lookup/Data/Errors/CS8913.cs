namespace dotnet_error_lookup.Data.Errors;

public class CS8913 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8913";
    string IErrorOrWarning.Message => @"The positional member '{0}' found corresponding to this parameter is hidden.";
    string IErrorOrWarning.Explanation => @"[original] The positional member '{0}' found corresponding to this parameter is hidden.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
