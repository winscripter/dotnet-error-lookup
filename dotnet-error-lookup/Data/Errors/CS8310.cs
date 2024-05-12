namespace dotnet_error_lookup.Data.Errors;

public class CS8310 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8310";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be applied to operand '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be applied to operand '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
