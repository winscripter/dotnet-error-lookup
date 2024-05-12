namespace dotnet_error_lookup.Data.Errors;

public class CS8896 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8896";
    string IErrorOrWarning.Message => @"'UnmanagedCallersOnly' can only be applied to ordinary static non-abstract, non-virtual methods or static local functions.";
    string IErrorOrWarning.Explanation => @"[original] 'UnmanagedCallersOnly' can only be applied to ordinary static non-abstract, non-virtual methods or static local functions.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
