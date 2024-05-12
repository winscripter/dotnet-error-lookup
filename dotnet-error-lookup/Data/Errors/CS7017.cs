namespace dotnet_error_lookup.Data.Errors;

public class CS7017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7017";
    string IErrorOrWarning.Message => @"Member definition, statement, or end-of-file expected";
    string IErrorOrWarning.Explanation => @"[original] Member definition, statement, or end-of-file expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
