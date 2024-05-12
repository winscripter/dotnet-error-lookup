namespace dotnet_error_lookup.Data.Errors;

public class CS9028 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9028";
    string IErrorOrWarning.Message => @"The #line span directive requires space before the first parenthesis, before the character offset, and before the file name";
    string IErrorOrWarning.Explanation => @"[original] The #line span directive requires space before the first parenthesis, before the character offset, and before the file name";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"";
}
