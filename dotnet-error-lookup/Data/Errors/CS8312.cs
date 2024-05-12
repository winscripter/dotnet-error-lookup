namespace dotnet_error_lookup.Data.Errors;

public class CS8312 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8312";
    string IErrorOrWarning.Message => @"Use of default literal is not valid in this context";
    string IErrorOrWarning.Explanation => @"[original] Use of default literal is not valid in this context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
