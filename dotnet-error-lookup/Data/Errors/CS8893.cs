namespace dotnet_error_lookup.Data.Errors;

public class CS8893 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8893";
    string IErrorOrWarning.Message => @"'{0}' is not a valid calling convention type for 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not a valid calling convention type for 'UnmanagedCallersOnly'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
