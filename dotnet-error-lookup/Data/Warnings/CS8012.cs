namespace dotnet_error_lookup.Data.Errors;

public class CS8012 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8012";
    string IErrorOrWarning.Message => @"Referenced assembly '{0}' targets a different processor.";
    string IErrorOrWarning.Explanation => @"[original] Referenced assembly '{0}' targets a different processor.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
