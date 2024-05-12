namespace dotnet_error_lookup.Data.Errors;

public class CS8513 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8513";
    string IErrorOrWarning.Message => @"The name '\_' refers to the type '{0}', not the discard pattern. Use '@\_' for the type, or 'var \_' to discard.";
    string IErrorOrWarning.Explanation => @"[original] The name '\_' refers to the type '{0}', not the discard pattern. Use '@\_' for the type, or 'var \_' to discard.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
