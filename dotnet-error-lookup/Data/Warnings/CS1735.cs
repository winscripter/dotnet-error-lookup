namespace dotnet_error_lookup.Data.Errors;

public class CS1735 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1735";
    string IErrorOrWarning.Message => @"XML comment on '{1}' has a typeparamref tag for '{0}', but there is no type parameter by that name";
    string IErrorOrWarning.Explanation => @"[original] XML comment on '{1}' has a typeparamref tag for '{0}', but there is no type parameter by that name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
