namespace dotnet_error_lookup.Data.Errors;

public class CS8981 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS8981";
    string IErrorOrWarning.Message => @"The type name '{0}' only contains lower-cased ascii characters. Such names may become reserved for the language.";
    string IErrorOrWarning.Explanation => @"[original] The type name '{0}' only contains lower-cased ascii characters. Such names may become reserved for the language.";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/warning-waves";
}
