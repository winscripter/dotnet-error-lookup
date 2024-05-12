namespace dotnet_error_lookup.Data.Errors;

public class CS0116 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0116";
    string IErrorOrWarning.Message => @"A namespace cannot directly contain members such as fields, methods or statements";
    string IErrorOrWarning.Explanation => @"[original] A namespace cannot directly contain members such as fields, methods or statements";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0116";
}
