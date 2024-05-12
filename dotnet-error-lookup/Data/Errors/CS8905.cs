namespace dotnet_error_lookup.Data.Errors;

public class CS8905 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8905";
    string IErrorOrWarning.Message => @"A function pointer cannot be called with named arguments.";
    string IErrorOrWarning.Explanation => @"[original] A function pointer cannot be called with named arguments.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
