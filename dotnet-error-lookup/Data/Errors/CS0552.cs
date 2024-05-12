namespace dotnet_error_lookup.Data.Errors;

public class CS0552 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Error;
    string IErrorOrWarning.Name => @"CS0552";
    string IErrorOrWarning.Message => @"'{0}': user-defined conversions to or from an interface are not allowed";
    string IErrorOrWarning.Explanation => @"[original] '{0}': user-defined conversions to or from an interface are not allowed";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0552";
}
