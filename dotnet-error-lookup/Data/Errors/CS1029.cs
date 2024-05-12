namespace dotnet_error_lookup.Data.Errors;

public class CS1029 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1029";
    string IErrorOrWarning.Message => @"#error: '{0}'";
    string IErrorOrWarning.Explanation => @"[original] #error: '{0}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1029";
}
