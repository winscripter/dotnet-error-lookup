namespace dotnet_error_lookup.Data.Errors;

public class CS0504 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0504";
    string IErrorOrWarning.Message => @"The constant '{0}' cannot be marked static";
    string IErrorOrWarning.Explanation => @"[original] The constant '{0}' cannot be marked static";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0504";
}
