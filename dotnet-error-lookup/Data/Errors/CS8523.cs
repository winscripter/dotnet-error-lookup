namespace dotnet_error_lookup.Data.Errors;

public class CS8523 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8523";
    string IErrorOrWarning.Message => @"The discard pattern is not permitted as a case label in a switch statement. Use 'case var \_:' for a discard pattern, or 'case @\_:' for a constant named '\_'.";
    string IErrorOrWarning.Explanation => @"[original] The discard pattern is not permitted as a case label in a switch statement. Use 'case var \_:' for a discard pattern, or 'case @\_:' for a constant named '\_'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
