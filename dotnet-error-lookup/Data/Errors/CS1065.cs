namespace dotnet_error_lookup.Data.Errors;

public class CS1065 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1065";
    string IErrorOrWarning.Message => @"Default values are not valid in this context.";
    string IErrorOrWarning.Explanation => @"[original] Default values are not valid in this context.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1065";
}
