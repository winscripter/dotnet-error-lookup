namespace dotnet_error_lookup.Data.Errors;

public class CS8900 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8900";
    string IErrorOrWarning.Message => @"Module initializer cannot be attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.Explanation => @"[original] Module initializer cannot be attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
