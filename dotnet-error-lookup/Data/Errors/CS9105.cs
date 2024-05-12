namespace dotnet_error_lookup.Data.Errors;

public class CS9105 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9105";
    string IErrorOrWarning.Message => @"Cannot use primary constructor parameter '{0}' in this context.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use primary constructor parameter '{0}' in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
