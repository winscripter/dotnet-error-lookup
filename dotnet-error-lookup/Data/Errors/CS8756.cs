namespace dotnet_error_lookup.Data.Errors;

public class CS8756 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8756";
    string IErrorOrWarning.Message => @"Function pointer '{0}' does not take {1} arguments";
    string IErrorOrWarning.Explanation => @"[original] Function pointer '{0}' does not take {1} arguments";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
