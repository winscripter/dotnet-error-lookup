namespace dotnet_error_lookup.Data.Errors;

public class CS0039 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0039";
    string IErrorOrWarning.Message => @"Cannot convert type '{0}' to '{1}' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion";
    string IErrorOrWarning.Explanation => @"[original] Cannot convert type '{0}' to '{1}' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0039";
}
