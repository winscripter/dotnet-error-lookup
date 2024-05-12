namespace dotnet_error_lookup.Data.Errors;

public class CS8309 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8309";
    string IErrorOrWarning.Message => @"Cannot compile net modules when using /refout or /refonly.";
    string IErrorOrWarning.Explanation => @"[original] Cannot compile net modules when using /refout or /refonly.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
