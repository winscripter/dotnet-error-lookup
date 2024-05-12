namespace dotnet_error_lookup.Data.Errors;

public class CS8360 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8360";
    string IErrorOrWarning.Message => @"Filter expression is a constant 'false', consider removing the try-catch block";
    string IErrorOrWarning.Explanation => @"[original] Filter expression is a constant 'false', consider removing the try-catch block";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
