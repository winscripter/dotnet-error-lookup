namespace dotnet_error_lookup.Data.Errors;

public class CS7095 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS7095";
    string IErrorOrWarning.Message => @"Filter expression is a constant 'true', consider removing the filter";
    string IErrorOrWarning.Explanation => @"[original] Filter expression is a constant 'true', consider removing the filter";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
