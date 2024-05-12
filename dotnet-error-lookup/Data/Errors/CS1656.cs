namespace dotnet_error_lookup.Data.Errors;

public class CS1656 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1656";
    string IErrorOrWarning.Message => @"Cannot assign to '{0}' because it is a '{1}'";
    string IErrorOrWarning.Explanation => @"[original] Cannot assign to '{0}' because it is a '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1656";
}
