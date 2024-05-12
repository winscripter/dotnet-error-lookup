namespace dotnet_error_lookup.Data.Errors;

public class CS8950 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8950";
    string IErrorOrWarning.Message => @"Parameter '{0}' is an argument to the interpolated string handler conversion on parameter '{1}', but the corresponding argument is specified after the interpolated string expression. Reorder the arguments to move '{0}' before '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] Parameter '{0}' is an argument to the interpolated string handler conversion on parameter '{1}', but the corresponding argument is specified after the interpolated string expression. Reorder the arguments to move '{0}' before '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
