namespace dotnet_error_lookup.Data.Errors;

public class CS0571 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0571";
    string IErrorOrWarning.Message => @"'{0}': cannot explicitly call operator or accessor";
    string IErrorOrWarning.Explanation => @"[original] '{0}': cannot explicitly call operator or accessor";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0571";
}
