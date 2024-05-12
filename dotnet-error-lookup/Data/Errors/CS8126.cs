namespace dotnet_error_lookup.Data.Errors;

public class CS8126 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8126";
    string IErrorOrWarning.Message => @"Tuple element name '{0}' is disallowed at any position.";
    string IErrorOrWarning.Explanation => @"[original] Tuple element name '{0}' is disallowed at any position.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
