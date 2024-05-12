namespace dotnet_error_lookup.Data.Errors;

public class CS1540 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1540";
    string IErrorOrWarning.Message => @"Cannot access protected member '{0}' via a qualifier of type '{1}'; the qualifier must be of type '{2}' (or derived from it)";
    string IErrorOrWarning.Explanation => @"[original] Cannot access protected member '{0}' via a qualifier of type '{1}'; the qualifier must be of type '{2}' (or derived from it)";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1540";
}
