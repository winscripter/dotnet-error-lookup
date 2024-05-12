namespace dotnet_error_lookup.Data.Errors;

public class CS8090 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8090";
    string IErrorOrWarning.Message => @"There is an error in a referenced assembly '{0}'.";
    string IErrorOrWarning.Explanation => @"[original] There is an error in a referenced assembly '{0}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
