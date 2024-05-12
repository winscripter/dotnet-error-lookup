namespace dotnet_error_lookup.Data.Errors;

public class CS0420 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0420";
    string IErrorOrWarning.Message => @"'{0}': a reference to a volatile field will not be treated as volatile";
    string IErrorOrWarning.Explanation => @"[original] '{0}': a reference to a volatile field will not be treated as volatile";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0420";
}
