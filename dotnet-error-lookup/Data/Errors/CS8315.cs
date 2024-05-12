namespace dotnet_error_lookup.Data.Errors;

public class CS8315 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8315";
    string IErrorOrWarning.Message => @"Operator '{0}' is ambiguous on operands '{1}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' is ambiguous on operands '{1}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
