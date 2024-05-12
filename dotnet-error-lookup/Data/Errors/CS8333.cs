namespace dotnet_error_lookup.Data.Errors;

public class CS8333 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS8333";
    string IErrorOrWarning.Message => @"Cannot return {0} '{1}' by writable reference because it is a readonly variable";
    string IErrorOrWarning.Explanation => @"[original] Cannot return {0} '{1}' by writable reference because it is a readonly variable";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs8333";
}
