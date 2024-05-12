namespace dotnet_error_lookup.Data.Errors;

public class CS0446 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0446";
    string IErrorOrWarning.Message => @"Foreach cannot operate on a '{0}'. Did you intend to invoke the '{0}'?";
    string IErrorOrWarning.Explanation => @"[original] Foreach cannot operate on a '{0}'. Did you intend to invoke the '{0}'?";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0446";
}
