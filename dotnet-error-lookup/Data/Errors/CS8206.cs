namespace dotnet_error_lookup.Data.Errors;

public class CS8206 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8206";
    string IErrorOrWarning.Message => @"Module '{0}' in assembly '{1}' is forwarding the type '{2}' to multiple assemblies: '{3}' and '{4}'.";
    string IErrorOrWarning.Explanation => @"[original] Module '{0}' in assembly '{1}' is forwarding the type '{2}' to multiple assemblies: '{3}' and '{4}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
