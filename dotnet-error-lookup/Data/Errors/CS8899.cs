namespace dotnet_error_lookup.Data.Errors;

public class CS8899 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8899";
    string IErrorOrWarning.Message => @"Application entry points cannot be attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.Explanation => @"[original] Application entry points cannot be attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
