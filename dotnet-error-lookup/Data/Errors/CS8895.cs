namespace dotnet_error_lookup.Data.Errors;

public class CS8895 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8895";
    string IErrorOrWarning.Message => @"Methods attributed with 'UnmanagedCallersOnly' cannot have generic type parameters and cannot be declared in a generic type.";
    string IErrorOrWarning.Explanation => @"[original] Methods attributed with 'UnmanagedCallersOnly' cannot have generic type parameters and cannot be declared in a generic type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
