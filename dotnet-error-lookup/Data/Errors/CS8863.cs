namespace dotnet_error_lookup.Data.Errors;

public class CS8863 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8863";
    string IErrorOrWarning.Message => @"Only a single partial type declaration may have a parameter list";
    string IErrorOrWarning.Explanation => @"[original] Only a single partial type declaration may have a parameter list";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
