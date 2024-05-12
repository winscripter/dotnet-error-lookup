namespace dotnet_error_lookup.Data.Errors;

public class CS8308 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8308";
    string IErrorOrWarning.Message => @"Do not use refout when using refonly.";
    string IErrorOrWarning.Explanation => @"[original] Do not use refout when using refonly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
