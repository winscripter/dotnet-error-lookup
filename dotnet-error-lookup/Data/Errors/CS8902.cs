namespace dotnet_error_lookup.Data.Errors;

public class CS8902 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8902";
    string IErrorOrWarning.Message => @"'{0}' is attributed with 'UnmanagedCallersOnly' and cannot be converted to a delegate type. Obtain a function pointer to this method.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is attributed with 'UnmanagedCallersOnly' and cannot be converted to a delegate type. Obtain a function pointer to this method.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
