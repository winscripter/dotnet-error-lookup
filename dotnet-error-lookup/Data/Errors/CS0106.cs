namespace dotnet_error_lookup.Data.Errors;

public class CS0106 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0106";
    string IErrorOrWarning.Message => @"The modifier '{0}' is not valid for this item";
    string IErrorOrWarning.Explanation => @"[original] The modifier '{0}' is not valid for this item";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0106";
}
