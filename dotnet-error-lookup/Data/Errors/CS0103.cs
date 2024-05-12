namespace dotnet_error_lookup.Data.Errors;

public class CS0103 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0103";
    string IErrorOrWarning.Message => @"The name '{0}' does not exist in the current context";
    string IErrorOrWarning.Explanation => @"[original] The name '{0}' does not exist in the current context";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0103";
}
