namespace dotnet_error_lookup.Data.Errors;

public class CS0071 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0071";
    string IErrorOrWarning.Message => @"An explicit interface implementation of an event must use event accessor syntax";
    string IErrorOrWarning.Explanation => @"[original] An explicit interface implementation of an event must use event accessor syntax";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0071";
}
