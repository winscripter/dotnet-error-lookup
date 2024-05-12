namespace dotnet_error_lookup.Data.Errors;

public class CS9012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9012";
    string IErrorOrWarning.Message => @"Unexpected keyword 'record'. Did you mean 'record struct' or 'record class'?";
    string IErrorOrWarning.Explanation => @"[original] Unexpected keyword 'record'. Did you mean 'record struct' or 'record class'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
