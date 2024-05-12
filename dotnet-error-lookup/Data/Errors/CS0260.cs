namespace dotnet_error_lookup.Data.Errors;

public class CS0260 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0260";
    string IErrorOrWarning.Message => @"Missing partial modifier on declaration of type '{0}'; another partial declaration of this type exists";
    string IErrorOrWarning.Explanation => @"[original] Missing partial modifier on declaration of type '{0}'; another partial declaration of this type exists";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0260";
}
