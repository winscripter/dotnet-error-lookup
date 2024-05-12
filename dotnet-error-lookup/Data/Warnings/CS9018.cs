namespace dotnet_error_lookup.Data.Errors;

public class CS9018 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9018";
    string IErrorOrWarning.Message => @"Auto-implemented property '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented property '{0}' is read before being explicitly assigned, causing a preceding implicit assignment of 'default'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
