namespace dotnet_error_lookup.Data.Errors;

public class CS0616 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0616";
    string IErrorOrWarning.Message => @"'{0}' is not an attribute class";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is not an attribute class";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0616";
}
