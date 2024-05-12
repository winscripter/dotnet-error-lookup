namespace dotnet_error_lookup.Data.Errors;

public class CS0115 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0115";
    string IErrorOrWarning.Message => @"'{0}': no suitable method found to override";
    string IErrorOrWarning.Explanation => @"[original] '{0}': no suitable method found to override";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0115";
}
