namespace dotnet_error_lookup.Data.Errors;

public class CS0173 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0173";
    string IErrorOrWarning.Message => @"Type of conditional expression cannot be determined because there is no implicit conversion between '{0}' and '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Type of conditional expression cannot be determined because there is no implicit conversion between '{0}' and '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0173";
}
