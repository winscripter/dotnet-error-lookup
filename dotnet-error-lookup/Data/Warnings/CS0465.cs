namespace dotnet_error_lookup.Data.Errors;

public class CS0465 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0465";
    string IErrorOrWarning.Message => @"Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?";
    string IErrorOrWarning.Explanation => @"[original] Introducing a 'Finalize' method can interfere with destructor invocation. Did you intend to declare a destructor?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0465";
}
