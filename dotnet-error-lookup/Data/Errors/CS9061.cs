namespace dotnet_error_lookup.Data.Errors;

public class CS9061 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9061";
    string IErrorOrWarning.Message => @"The 'scoped' modifier cannot be used with discard.";
    string IErrorOrWarning.Explanation => @"[original] The 'scoped' modifier cannot be used with discard.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
