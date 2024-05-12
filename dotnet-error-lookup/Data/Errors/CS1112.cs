namespace dotnet_error_lookup.Data.Errors;

public class CS1112 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1112";
    string IErrorOrWarning.Message => @"Do not use 'System.Runtime.CompilerServices.ExtensionAttribute'. Use the 'this' keyword instead.";
    string IErrorOrWarning.Explanation => @"[original] Do not use 'System.Runtime.CompilerServices.ExtensionAttribute'. Use the 'this' keyword instead.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1112";
}
