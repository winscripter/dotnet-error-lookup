namespace dotnet_error_lookup.Data.Errors;

public class CS9066 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9066";
    string IErrorOrWarning.Message => @"UnscopedRefAttribute cannot be applied to parameters that have a 'scoped' modifier.";
    string IErrorOrWarning.Explanation => @"[original] UnscopedRefAttribute cannot be applied to parameters that have a 'scoped' modifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
