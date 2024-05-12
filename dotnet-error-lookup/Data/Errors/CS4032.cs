namespace dotnet_error_lookup.Data.Errors;

public class CS4032 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS4032";
    string IErrorOrWarning.Message => @"The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task\<{0}\>'.";
    string IErrorOrWarning.Explanation => @"[original] The 'await' operator can only be used within an async method. Consider marking this method with the 'async' modifier and changing its return type to 'Task\<{0}\>'.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs4032";
}
