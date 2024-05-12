namespace dotnet_error_lookup.Data.Errors;

public class CS9031 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9031";
    string IErrorOrWarning.Message => @"Required member '{0}' cannot be hidden by '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Required member '{0}' cannot be hidden by '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
