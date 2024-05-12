namespace dotnet_error_lookup.Data.Errors;

public class CS8001 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8001";
    string IErrorOrWarning.Message => @"The command line switch '{0}' is not yet implemented and was ignored.";
    string IErrorOrWarning.Explanation => @"[original] The command line switch '{0}' is not yet implemented and was ignored.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
