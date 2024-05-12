namespace dotnet_error_lookup.Data.Errors;

public class CS8809 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8809";
    string IErrorOrWarning.Message => @"A return type can only have one '{0}' modifier.";
    string IErrorOrWarning.Explanation => @"[original] A return type can only have one '{0}' modifier.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
