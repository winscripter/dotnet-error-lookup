namespace dotnet_error_lookup.Data.Errors;

public class CS9081 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS9081";
    string IErrorOrWarning.Message => @"A result of a stackalloc expression of type '{0}' in this context may be exposed outside of the containing method";
    string IErrorOrWarning.Explanation => @"[original] A result of a stackalloc expression of type '{0}' in this context may be exposed outside of the containing method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
