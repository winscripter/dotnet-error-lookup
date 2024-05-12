namespace dotnet_error_lookup.Data.Errors;

public class CS7091 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7091";
    string IErrorOrWarning.Message => @"Attribute '{0}' given in a source file conflicts with option '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Attribute '{0}' given in a source file conflicts with option '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
