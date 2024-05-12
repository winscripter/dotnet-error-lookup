namespace dotnet_error_lookup.Data.Errors;

public class CS8512 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8512";
    string IErrorOrWarning.Message => @"The name '\_' refers to the constant, not the discard pattern. Use 'var \_' to discard the value, or '@\_' to refer to a constant by that name.";
    string IErrorOrWarning.Explanation => @"[original] The name '\_' refers to the constant, not the discard pattern. Use 'var \_' to discard the value, or '@\_' to refer to a constant by that name.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
