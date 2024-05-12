namespace dotnet_error_lookup.Data.Errors;

public class CS8977 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8977";
    string IErrorOrWarning.Message => @"Cannot use 'ref', 'in', or 'out' in the signature of a method attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use 'ref', 'in', or 'out' in the signature of a method attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
