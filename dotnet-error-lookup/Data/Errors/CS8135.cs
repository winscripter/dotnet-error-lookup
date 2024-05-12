namespace dotnet_error_lookup.Data.Errors;

public class CS8135 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8135";
    string IErrorOrWarning.Message => @"Tuple with {0} elements cannot be converted to type '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Tuple with {0} elements cannot be converted to type '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
