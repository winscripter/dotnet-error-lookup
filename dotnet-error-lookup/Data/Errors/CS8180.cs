namespace dotnet_error_lookup.Data.Errors;

public class CS8180 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8180";
    string IErrorOrWarning.Message => @"{ or ; or =\> expected";
    string IErrorOrWarning.Explanation => @"[original] { or ; or =\> expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
