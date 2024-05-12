namespace dotnet_error_lookup.Data.Errors;

public class CS8901 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8901";
    string IErrorOrWarning.Message => @"'{0}' is attributed with 'UnmanagedCallersOnly' and cannot be called directly. Obtain a function pointer to this method.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is attributed with 'UnmanagedCallersOnly' and cannot be called directly. Obtain a function pointer to this method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
