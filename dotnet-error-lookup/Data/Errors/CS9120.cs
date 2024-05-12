namespace dotnet_error_lookup.Data.Errors;

public class CS9120 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9120";
    string IErrorOrWarning.Message => @"Cannot return primary constructor parameter '{0}' by reference.";
    string IErrorOrWarning.Explanation => @"[original] Cannot return primary constructor parameter '{0}' by reference.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
