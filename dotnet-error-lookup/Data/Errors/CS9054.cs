namespace dotnet_error_lookup.Data.Errors;

public class CS9054 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9054";
    string IErrorOrWarning.Message => @"File-local type '{0}' must be defined in a top level type; '{0}' is a nested type.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' must be defined in a top level type; '{0}' is a nested type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
