namespace dotnet_error_lookup.Data.Errors;

public class CS8175 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8175";
    string IErrorOrWarning.Message => @"Cannot use ref local '{0}' inside an anonymous method, lambda expression, or query expression";
    string IErrorOrWarning.Explanation => @"[original] Cannot use ref local '{0}' inside an anonymous method, lambda expression, or query expression";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8175";
}
