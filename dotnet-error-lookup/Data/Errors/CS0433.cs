namespace dotnet_error_lookup.Data.Errors;

public class CS0433 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0433";
    string IErrorOrWarning.Message => @"The type '{1}' exists in both '{0}' and '{2}'";
    string IErrorOrWarning.Explanation => @"[original] The type '{1}' exists in both '{0}' and '{2}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0433";
}
