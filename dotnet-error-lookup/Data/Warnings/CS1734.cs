namespace dotnet_error_lookup.Data.Errors;

public class CS1734 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1734";
    string IErrorOrWarning.Message => @"XML comment on '{1}' has a paramref tag for '{0}', but there is no parameter by that name";
    string IErrorOrWarning.Explanation => @"[original] XML comment on '{1}' has a paramref tag for '{0}', but there is no parameter by that name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
