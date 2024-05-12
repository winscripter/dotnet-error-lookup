namespace dotnet_error_lookup.Data.Errors;

public class CS8035 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8035";
    string IErrorOrWarning.Message => @"Error reading ruleset file {0} - {1}";
    string IErrorOrWarning.Explanation => @"[original] Error reading ruleset file {0} - {1}";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
