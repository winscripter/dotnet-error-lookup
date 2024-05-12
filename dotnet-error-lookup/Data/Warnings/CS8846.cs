namespace dotnet_error_lookup.Data.Errors;

public class CS8846 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8846";
    string IErrorOrWarning.Message => @"The switch expression does not handle all possible values of its input type (it is not exhaustive). For example, the pattern '{0}' is not covered. However, a pattern with a 'when' clause might successfully match this value.";
    string IErrorOrWarning.Explanation => @"[original] The switch expression does not handle all possible values of its input type (it is not exhaustive). For example, the pattern '{0}' is not covered. However, a pattern with a 'when' clause might successfully match this value.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
