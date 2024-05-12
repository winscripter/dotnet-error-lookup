namespace dotnet_error_lookup.Data.Errors;

public class CS0618 : IErrorOrWarning
{
    SyntaxErrorType IErrorOrWarning.ErrorType => SyntaxErrorType.Warning;
    string IErrorOrWarning.Name => @"CS0618";
    string IErrorOrWarning.Message => @"'{0}' is obsolete: '{1}'";
    string IErrorOrWarning.Explanation => @"[original] '{0}' is obsolete: '{1}'";
    string IErrorOrWarning.SampleCode => string.Empty;
    string IErrorOrWarning.SampleFix => string.Empty;
    string IErrorOrWarning.DocumentationReference => @"https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0618";
}
