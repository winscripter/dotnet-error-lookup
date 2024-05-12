namespace dotnet_error_lookup.Data.Errors;

public class CS1919 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1919";
    string IErrorOrWarning.Message => @"Unsafe type '{0}' cannot be used in object creation";
    string IErrorOrWarning.Explanation => @"[original] Unsafe type '{0}' cannot be used in object creation";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1919";
}
