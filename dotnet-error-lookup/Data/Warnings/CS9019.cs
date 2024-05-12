namespace dotnet_error_lookup.Data.Errors;

public class CS9019 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9019";
    string IErrorOrWarning.Message => @"Field '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.Explanation => @"[original] Field '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
