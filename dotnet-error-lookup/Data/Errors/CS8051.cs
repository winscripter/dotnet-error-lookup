namespace dotnet_error_lookup.Data.Errors;

public class CS8051 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8051";
    string IErrorOrWarning.Message => @"Auto-implemented properties must have get accessors.";
    string IErrorOrWarning.Explanation => @"[original] Auto-implemented properties must have get accessors.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
