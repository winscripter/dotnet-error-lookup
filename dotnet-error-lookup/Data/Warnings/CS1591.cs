namespace dotnet_error_lookup.Data.Errors;

public class CS1591 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1591";
    string IErrorOrWarning.Message => @"Missing XML comment for publicly visible type or member '{0}'";
    string IErrorOrWarning.Explanation => @"[original] Missing XML comment for publicly visible type or member '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1591";
}
