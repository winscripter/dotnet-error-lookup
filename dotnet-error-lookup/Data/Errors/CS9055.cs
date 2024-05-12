namespace dotnet_error_lookup.Data.Errors;

public class CS9055 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9055";
    string IErrorOrWarning.Message => @"File-local type '{0}' cannot be used in a 'global using static' directive.";
    string IErrorOrWarning.Explanation => @"[original] File-local type '{0}' cannot be used in a 'global using static' directive.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
