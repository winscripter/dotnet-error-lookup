namespace dotnet_error_lookup.Data.Errors;

public class CS8945 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8945";
    string IErrorOrWarning.Message => @"'{0}' is not a valid parameter name from '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid parameter name from '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
