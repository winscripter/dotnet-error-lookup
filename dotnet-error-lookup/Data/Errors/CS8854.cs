namespace dotnet_error_lookup.Data.Errors;

public class CS8854 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8854";
    string IErrorOrWarning.Message => @"'{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' does not implement interface member '{1}'. '{2}' cannot implement '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
