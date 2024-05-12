namespace dotnet_error_lookup.Data.Errors;

public class CS8168 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8168";
    string IErrorOrWarning.Message => @"Cannot return local '{0}' by reference because it is not a ref local";
    string IErrorOrWarning.Explanation => @"[original] Cannot return local '{0}' by reference because it is not a ref local";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8168";
}
