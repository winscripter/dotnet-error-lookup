namespace dotnet_error_lookup.Data.Errors;

public class CS8510 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8510";
    string IErrorOrWarning.Message => @"The pattern is unreachable. It has already been handled by a previous arm of the switch expression or it is impossible to match.";
    string IErrorOrWarning.Explanation => @"[original] The pattern is unreachable. It has already been handled by a previous arm of the switch expression or it is impossible to match.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
