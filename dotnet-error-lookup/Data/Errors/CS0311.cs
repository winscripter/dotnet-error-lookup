namespace dotnet_error_lookup.Data.Errors;

public class CS0311 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0311";
    string IErrorOrWarning.Message => @"The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no implicit reference conversion from '{3}' to '{1}'.";
    string IErrorOrWarning.Explanation => @"[original] The type '{3}' cannot be used as type parameter '{2}' in the generic type or method '{0}'. There is no implicit reference conversion from '{3}' to '{1}'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0311";
}
