namespace dotnet_error_lookup.Data.Errors;

public class CS8911 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8911";
    string IErrorOrWarning.Message => @"Using a function pointer type in this context is not supported.";
    string IErrorOrWarning.Explanation => @"[original] Using a function pointer type in this context is not supported.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
