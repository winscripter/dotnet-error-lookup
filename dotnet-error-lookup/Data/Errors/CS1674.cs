namespace dotnet_error_lookup.Data.Errors;

public class CS1674 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1674";
    string IErrorOrWarning.Message => @"'{0}': type used in a using statement must be implicitly convertible to 'System.IDisposable'.";
    string IErrorOrWarning.Explanation => @"[original] '{0}': type used in a using statement must be implicitly convertible to 'System.IDisposable'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1674";
}
