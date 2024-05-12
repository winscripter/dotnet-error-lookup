namespace dotnet_error_lookup.Data.Errors;

public class CS9021 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9021";
    string IErrorOrWarning.Message => @"Control is returned to caller before auto-implemented property '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.Explanation => @"[original] Control is returned to caller before auto-implemented property '{0}' is explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
