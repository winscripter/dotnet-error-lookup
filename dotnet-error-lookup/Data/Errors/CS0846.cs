namespace dotnet_error_lookup.Data.Errors;

public class CS0846 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0846";
    string IErrorOrWarning.Message => @"A nested array initializer is expected";
    string IErrorOrWarning.Explanation => @"[original] A nested array initializer is expected";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0846";
}
