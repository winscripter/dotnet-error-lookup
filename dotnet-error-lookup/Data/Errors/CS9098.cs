namespace dotnet_error_lookup.Data.Errors;

public class CS9098 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9098";
    string IErrorOrWarning.Message => @"Implicitly typed lambda parameter '{0}' cannot have a default value.";
    string IErrorOrWarning.Explanation => @"[original] Implicitly typed lambda parameter '{0}' cannot have a default value.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
