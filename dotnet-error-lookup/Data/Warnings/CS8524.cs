namespace dotnet_error_lookup.Data.Errors;

public class CS8524 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8524";
    string IErrorOrWarning.Message => @"The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value. For example, the pattern '{0}' is not covered.";
    string IErrorOrWarning.Explanation => @"[original] The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value. For example, the pattern '{0}' is not covered.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
