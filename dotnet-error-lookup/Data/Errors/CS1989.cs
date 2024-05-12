namespace dotnet_error_lookup.Data.Errors;

public class CS1989 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1989";
    string IErrorOrWarning.Message => @"Async lambda expressions cannot be converted to expression trees";
    string IErrorOrWarning.Explanation => @"[original] Async lambda expressions cannot be converted to expression trees";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
