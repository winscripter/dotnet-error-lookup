namespace dotnet_error_lookup.Data.Errors;

public class CS1616 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1616";
    string IErrorOrWarning.Message => @"Option '{0}' overrides attribute '{1}' given in a source file or added module";
    string IErrorOrWarning.Explanation => @"[original] Option '{0}' overrides attribute '{1}' given in a source file or added module";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1616";
}
