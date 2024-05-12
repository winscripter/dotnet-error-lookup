namespace dotnet_error_lookup.Data.Errors;

public class CS7020 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7020";
    string IErrorOrWarning.Message => @"Cannot use 'yield' in top-level script code";
    string IErrorOrWarning.Explanation => @"[original] Cannot use 'yield' in top-level script code";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
