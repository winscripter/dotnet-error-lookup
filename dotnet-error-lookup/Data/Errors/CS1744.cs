namespace dotnet_error_lookup.Data.Errors;

public class CS1744 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1744";
    string IErrorOrWarning.Message => @"Named argument '{0}' specifies a parameter for which a positional argument has already been given";
    string IErrorOrWarning.Explanation => @"[original] Named argument '{0}' specifies a parameter for which a positional argument has already been given";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
