namespace dotnet_error_lookup.Data.Errors;

public class CS8668 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8668";
    string IErrorOrWarning.Message => @"Expected 'warnings', 'annotations', or end of directive";
    string IErrorOrWarning.Explanation => @"[original] Expected 'warnings', 'annotations', or end of directive";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
