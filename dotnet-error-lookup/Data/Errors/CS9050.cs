namespace dotnet_error_lookup.Data.Errors;

public class CS9050 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS9050";
    string IErrorOrWarning.Message => @"A ref field cannot refer to a ref struct.";
    string IErrorOrWarning.Explanation => @"[original] A ref field cannot refer to a ref struct.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs9050";
}
