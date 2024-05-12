namespace dotnet_error_lookup.Data.Errors;

public class CS1742 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1742";
    string IErrorOrWarning.Message => @"An array access may not have a named argument specifier";
    string IErrorOrWarning.Explanation => @"[original] An array access may not have a named argument specifier";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1742";
}
