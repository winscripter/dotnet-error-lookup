namespace dotnet_error_lookup.Data.Errors;

public class CS1740 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS1740";
    string IErrorOrWarning.Message => @"Named argument '{0}' cannot be specified multiple times";
    string IErrorOrWarning.Explanation => @"[original] Named argument '{0}' cannot be specified multiple times";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1740";
}
