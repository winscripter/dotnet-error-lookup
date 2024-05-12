namespace dotnet_error_lookup.Data.Errors;

public class CS0834 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0834";
    string IErrorOrWarning.Message => @"A lambda expression with a statement body cannot be converted to an expression tree";
    string IErrorOrWarning.Explanation => @"[original] A lambda expression with a statement body cannot be converted to an expression tree";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0834";
}
