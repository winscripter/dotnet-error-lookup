namespace dotnet_error_lookup.Data.Errors;

public class CS9047 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9047";
    string IErrorOrWarning.Message => @"Operator '{0}' cannot be applied to operands of type '{1}' and '{2}' that are not UTF-8 byte representations";
    string IErrorOrWarning.Explanation => @"[original] Operator '{0}' cannot be applied to operands of type '{1}' and '{2}' that are not UTF-8 byte representations";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
