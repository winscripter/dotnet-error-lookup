namespace dotnet_error_lookup.Data.Errors;

public class CS7045 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7045";
    string IErrorOrWarning.Message => @"Parameter not valid for the specified unmanaged type.";
    string IErrorOrWarning.Explanation => @"[original] Parameter not valid for the specified unmanaged type.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
