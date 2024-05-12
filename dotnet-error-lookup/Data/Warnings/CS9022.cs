namespace dotnet_error_lookup.Data.Errors;

public class CS9022 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9022";
    string IErrorOrWarning.Message => @"Control is returned to caller before field '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.Explanation => @"[original] Control is returned to caller before field '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
