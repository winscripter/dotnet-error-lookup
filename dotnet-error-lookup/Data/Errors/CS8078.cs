namespace dotnet_error_lookup.Data.Errors;

public class CS8078 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8078";
    string IErrorOrWarning.Message => @"An expression is too long or complex to compile";
    string IErrorOrWarning.Explanation => @"[original] An expression is too long or complex to compile";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
