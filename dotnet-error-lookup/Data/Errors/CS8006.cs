namespace dotnet_error_lookup.Data.Errors;

public class CS8006 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8006";
    string IErrorOrWarning.Message => @"Forwarded type '{0}' conflicts with type declared in primary module of this assembly.";
    string IErrorOrWarning.Explanation => @"[original] Forwarded type '{0}' conflicts with type declared in primary module of this assembly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
