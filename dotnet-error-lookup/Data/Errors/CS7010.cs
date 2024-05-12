namespace dotnet_error_lookup.Data.Errors;

public class CS7010 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS7010";
    string IErrorOrWarning.Message => @"Quoted file name expected";
    string IErrorOrWarning.Explanation => @"[original] Quoted file name expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
