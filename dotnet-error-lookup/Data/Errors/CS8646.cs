namespace dotnet_error_lookup.Data.Errors;

public class CS8646 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8646";
    string IErrorOrWarning.Message => @"'{0}' is explicitly implemented more than once.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is explicitly implemented more than once.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
