namespace dotnet_error_lookup.Data.Errors;

public class CS8952 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8952";
    string IErrorOrWarning.Message => @"An expression tree may not contain an interpolated string handler conversion.";
    string IErrorOrWarning.Explanation => @"[original] An expression tree may not contain an interpolated string handler conversion.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
