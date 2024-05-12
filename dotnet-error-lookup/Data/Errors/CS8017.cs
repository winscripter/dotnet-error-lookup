namespace dotnet_error_lookup.Data.Errors;

public class CS8017 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8017";
    string IErrorOrWarning.Message => @"The parameter has multiple distinct default values.";
    string IErrorOrWarning.Explanation => @"[original] The parameter has multiple distinct default values.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
