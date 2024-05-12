namespace dotnet_error_lookup.Data.Errors;

public class CS9102 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9102";
    string IErrorOrWarning.Message => @"UnscopedRefAttribute cannot be applied to an interface implementation.";
    string IErrorOrWarning.Explanation => @"[original] UnscopedRefAttribute cannot be applied to an interface implementation.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
