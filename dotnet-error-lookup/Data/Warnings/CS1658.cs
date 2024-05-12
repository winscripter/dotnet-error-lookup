namespace dotnet_error_lookup.Data.Errors;

public class CS1658 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS1658";
    string IErrorOrWarning.Message => @"{0}. See also error CS{1}.";
    string IErrorOrWarning.Explanation => @"[original] {0}. See also error CS{1}.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs1658";
}
