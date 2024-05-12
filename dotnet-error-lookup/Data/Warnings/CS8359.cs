namespace dotnet_error_lookup.Data.Errors;

public class CS8359 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8359";
    string IErrorOrWarning.Message => @"Filter expression is a constant 'false', consider removing the catch clause";
    string IErrorOrWarning.Explanation => @"[original] Filter expression is a constant 'false', consider removing the catch clause";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
