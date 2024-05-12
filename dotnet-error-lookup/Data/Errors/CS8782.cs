namespace dotnet_error_lookup.Data.Errors;

public class CS8782 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8782";
    string IErrorOrWarning.Message => @"Relational patterns may not be used for a floating-point NaN.";
    string IErrorOrWarning.Explanation => @"[original] Relational patterns may not be used for a floating-point NaN.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
