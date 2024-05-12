namespace dotnet_error_lookup.Data.Errors;

public class CS9063 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9063";
    string IErrorOrWarning.Message => @"UnscopedRefAttribute cannot be applied to this parameter because it is unscoped by default.";
    string IErrorOrWarning.Explanation => @"[original] UnscopedRefAttribute cannot be applied to this parameter because it is unscoped by default.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
