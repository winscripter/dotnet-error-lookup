namespace dotnet_error_lookup.Data.Errors;

public class CS8932 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8932";
    string IErrorOrWarning.Message => @"'UnmanagedCallersOnly' method '{0}' cannot implement interface member '{1}' in type '{2}'";
    string IErrorOrWarning.Explanation => @"[original] 'UnmanagedCallersOnly' method '{0}' cannot implement interface member '{1}' in type '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
