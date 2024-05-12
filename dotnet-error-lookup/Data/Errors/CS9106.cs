namespace dotnet_error_lookup.Data.Errors;

public class CS9106 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9106";
    string IErrorOrWarning.Message => @"Identifier '{0}' is ambiguous between type '{1}' and parameter '{2}' in this context.";
    string IErrorOrWarning.Explanation => @"[original] Identifier '{0}' is ambiguous between type '{1}' and parameter '{2}' in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
