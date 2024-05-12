namespace dotnet_error_lookup.Data.Errors;

public class CS8323 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8323";
    string IErrorOrWarning.Message => @"Named argument '{0}' is used out-of-position but is followed by an unnamed argument";
    string IErrorOrWarning.Explanation => @"[original] Named argument '{0}' is used out-of-position but is followed by an unnamed argument";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
