namespace dotnet_error_lookup.Data.Errors;

public class CS8120 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8120";
    string IErrorOrWarning.Message => @"The switch case is unreachable. It has already been handled by a previous case or it is impossible to match.";
    string IErrorOrWarning.Explanation => @"[original] The switch case is unreachable. It has already been handled by a previous case or it is impossible to match.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
