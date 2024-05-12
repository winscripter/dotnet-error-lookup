namespace dotnet_error_lookup.Data.Errors;

public class CS1739 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1739";
    string IErrorOrWarning.Message => @"The best overload for '{0}' does not have a parameter named '{1}'";
    string IErrorOrWarning.Explanation => @"[original] The best overload for '{0}' does not have a parameter named '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1739";
}
