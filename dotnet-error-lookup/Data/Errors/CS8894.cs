namespace dotnet_error_lookup.Data.Errors;

public class CS8894 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8894";
    string IErrorOrWarning.Message => @"Cannot use '{0}' as a {1} type on a method attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.Explanation => @"[original] Cannot use '{0}' as a {1} type on a method attributed with 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
