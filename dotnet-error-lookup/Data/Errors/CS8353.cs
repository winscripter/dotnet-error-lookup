namespace dotnet_error_lookup.Data.Errors;

public class CS8353 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8353";
    string IErrorOrWarning.Message => @"A result of a stackalloc expression of type '{0}' cannot be used in this context because it may be exposed outside of the containing method";
    string IErrorOrWarning.Explanation => @"[original] A result of a stackalloc expression of type '{0}' cannot be used in this context because it may be exposed outside of the containing method";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
