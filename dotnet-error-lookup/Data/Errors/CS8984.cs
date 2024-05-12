namespace dotnet_error_lookup.Data.Errors;

public class CS8984 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8984";
    string IErrorOrWarning.Message => @"Cannot update because an inferred delegate type has changed.";
    string IErrorOrWarning.Explanation => @"[original] Cannot update because an inferred delegate type has changed.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
