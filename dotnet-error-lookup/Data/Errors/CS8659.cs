namespace dotnet_error_lookup.Data.Errors;

public class CS8659 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8659";
    string IErrorOrWarning.Message => @"Auto-implemented property '{0}' cannot be marked 'readonly' because it has a 'set' accessor.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented property '{0}' cannot be marked 'readonly' because it has a 'set' accessor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
