namespace dotnet_error_lookup.Data.Errors;

public class CS8521 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8521";
    string IErrorOrWarning.Message => @"Pattern-matching is not permitted for pointer types.";
    string IErrorOrWarning.Explanation => @"[original] Pattern-matching is not permitted for pointer types.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
