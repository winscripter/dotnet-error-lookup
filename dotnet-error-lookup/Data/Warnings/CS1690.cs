namespace dotnet_error_lookup.Data.Errors;

public class CS1690 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1690";
    string IErrorOrWarning.Message => @"Accessing a member on '{0}' may cause a runtime exception because it is a field of a marshal-by-reference class";
    string IErrorOrWarning.Explanation => @"[original] Accessing a member on '{0}' may cause a runtime exception because it is a field of a marshal-by-reference class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1690";
}
