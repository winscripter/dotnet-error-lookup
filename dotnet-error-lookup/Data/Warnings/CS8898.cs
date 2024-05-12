namespace dotnet_error_lookup.Data.Errors;

public class CS8898 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8898";
    string IErrorOrWarning.Message => @"'{0}': static types cannot be used as return types";
    string IErrorOrWarning.Explanation => @"[original] '{0}': static types cannot be used as return types";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
