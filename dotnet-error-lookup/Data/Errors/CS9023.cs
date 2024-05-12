namespace dotnet_error_lookup.Data.Errors;

public class CS9023 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9023";
    string IErrorOrWarning.Message => @"User-defined operator '{0}' cannot be declared checked";
    string IErrorOrWarning.Explanation => @"[original] User-defined operator '{0}' cannot be declared checked";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
